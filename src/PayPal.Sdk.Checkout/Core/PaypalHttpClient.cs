using Microsoft.Extensions.Options;
using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.Configuration;
using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.Interfaces;
using PayPal.Sdk.Checkout.RequestInterfaces;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Core;

// ReSharper disable once ClassWithVirtualMembersNeverInherited.Global
public class PayPalHttpClient : IPayPalHttpClient
{
    private readonly HttpClient _httpClient;

    private readonly IPayPayEncoder _payPayEncoder;

    private readonly IOptions<PayPalOptions> _payPalOptions;

    private readonly bool _leaveOpen;

    /// <param name="httpClient"></param>
    /// <param name="payPayEncoder"></param>
    /// <param name="payPalOptions"></param>
    /// <param name="leaveOpen">Mainly for test to call dispose on httpClient</param>
    public PayPalHttpClient(
        HttpClient httpClient,
        IPayPayEncoder payPayEncoder,
        IOptions<PayPalOptions> payPalOptions,
        bool leaveOpen = true
    )
    {
        _httpClient = httpClient;
        _payPayEncoder = payPayEncoder;
        _payPalOptions = payPalOptions;
        _leaveOpen = leaveOpen;
    }

    public PayPalOptions GetPayPalOptions => _payPalOptions.Value;

    protected virtual HttpRequestMessage CreateHttpRequest<TRequest>(
        TRequest request,
        AccessToken? accessToken = null
    )
        where TRequest : BaseHttpRequest
    {
        var httpRequest = new HttpRequestMessage(
            request.Method,
            new Uri(request.Path, UriKind.Relative)
        );

        foreach (var (header, headerValue) in request.Headers)
        {
            httpRequest.Headers.Add(header, headerValue);
        }

        if (request.Authorization != null)
        {
            httpRequest.Headers.Authorization = request.Authorization;
        }
        else if (accessToken != null)
        {
            httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken.Token);
        }

        if (request is IPayPalRequestWithRequestBody palRequestWithRequestBody)
        {
            httpRequest.Headers.Add("PayPal-Request-Id", palRequestWithRequestBody.PayPalRequestId);
        }

        return httpRequest;
    }

    protected virtual async Task<HttpContent> CreateHttpContent<TRequest, TRequestBody>(
        TRequest request
    )
        where TRequest : BaseHttpRequest
        where TRequestBody : notnull
    {
        if (request is IPayPalRequestWithRequestBody<TRequestBody> requestWithRequestBody)
        {
            return await _payPayEncoder.SerializeRequestAsync(requestWithRequestBody.Body, requestWithRequestBody.ContentType);
        }

        throw new ArgumentException($"The request {typeof(TRequest)} do not implement {typeof(IPayPalRequestWithRequestBody<TRequestBody>)}");
    }

    protected virtual async Task<PayPalHttpResponse> ProcessResponseAsync(
        HttpResponseMessage response, CancellationToken cancellationToken
    )
    {
        if (response.IsSuccessStatusCode)
        {
            return new PayPalHttpResponse(response.Headers, response.StatusCode);
        }

        var responseBodyContent = await response.Content.ReadAsStringAsync(
#if NET7_0_OR_GREATER
                cancellationToken
#endif
        );

        throw new PayPalHttpException(response.StatusCode, response.Headers, responseBodyContent);
    }

    protected virtual async Task<PayPalHttpResponse<TResponse>> ProcessResponseAsync<TResponse>(
        HttpResponseMessage response, CancellationToken cancellationToken
    )
        where TResponse : notnull
    {
        if (response.IsSuccessStatusCode)
        {
            TResponse? responseBody = default;

            if (response.Content.Headers.ContentType != null)
            {
                responseBody = await _payPayEncoder.DeserializeResponseAsync<TResponse>(
                    response.Content,
                    response.Content.Headers.ContentType,
                    cancellationToken
                );
            }

            return new PayPalHttpResponse<TResponse>(response.Headers, response.StatusCode, responseBody);
        }

        var responseBodyContent = await response.Content.ReadAsStringAsync(
#if NET7_0_OR_GREATER
                cancellationToken
#endif
        );

        throw new PayPalHttpException(response.StatusCode, response.Headers, responseBodyContent);
    }

    public virtual async Task<IPayPalHttpResponse<TResponse>> ExecuteAsync<TRequest, TRequestBody, TResponse>(
        TRequest request,
        AccessToken? accessToken,
        CancellationToken cancellationToken
    )
        where TRequest : BaseHttpRequest<TResponse, TRequestBody>
        where TRequestBody : notnull
        where TResponse : notnull
    {
        var httpRequest = CreateHttpRequest(request, accessToken);

        HttpResponseMessage response;
        if (request is IPayPalRequestWithRequestBody)
        {
            using var httpContent = await CreateHttpContent<TRequest, TRequestBody>(request);
            httpRequest.Content = httpContent;

            response = await _httpClient.SendAsync(httpRequest, cancellationToken);
        }
        else
        {
            response = await _httpClient.SendAsync(httpRequest, cancellationToken);
        }

        return await ProcessResponseAsync<TResponse>(response, cancellationToken);
    }

    public virtual async Task<IPayPalHttpResponse<TResponse>> ExecuteAsync<TRequest, TResponse>(
        TRequest request,
        AccessToken? accessToken,
        CancellationToken cancellationToken
    )
        where TRequest : BaseHttpRequest
        where TResponse : notnull
    {
        if (request is IPayPalRequestWithRequestBody)
        {
            throw new ArgumentException($"Use the {nameof(ExecuteAsync)}<TRequest, TRequestBody, TResponse> method signature");
        }

        var httpRequest = CreateHttpRequest(request, accessToken);

        var response = await _httpClient.SendAsync(httpRequest, cancellationToken);

        return await ProcessResponseAsync<TResponse>(response, cancellationToken);
    }

    public virtual async Task<IPayPalHttpResponse> ExecuteVoidAsync<TRequest, TRequestBody>(
        TRequest request,
        AccessToken? accessToken,
        CancellationToken cancellationToken
    )
        where TRequest : BaseVoidHttpRequest<TRequestBody>
        where TRequestBody : notnull
    {
        var httpRequest = CreateHttpRequest(request, accessToken);

        HttpResponseMessage response;
        if (request is IPayPalRequestWithRequestBody)
        {
            using var httpContent = await CreateHttpContent<TRequest, TRequestBody>(request);
            httpRequest.Content = httpContent;

            response = await _httpClient.SendAsync(httpRequest, cancellationToken);
        }
        else
        {
            response = await _httpClient.SendAsync(httpRequest, cancellationToken);
        }

        return await ProcessResponseAsync(response, cancellationToken);
    }

    public virtual async Task<IPayPalHttpResponse> ExecuteVoidAsync<TRequest>(
        TRequest request,
        AccessToken? accessToken,
        CancellationToken cancellationToken
    )
        where TRequest : BaseHttpRequest
    {
        if (request is IPayPalRequestWithRequestBody)
        {
            throw new ArgumentException($"Use the {nameof(ExecuteVoidAsync)}<TRequest, TRequestBody> method signature");
        }

        var httpRequest = CreateHttpRequest(request, accessToken);

        var response = await _httpClient.SendAsync(httpRequest, cancellationToken);

        return await ProcessResponseAsync(response, cancellationToken);
    }


    // ReSharper disable once RedundantDefaultMemberInitializer
    private bool _disposed = false;

    public void Dispose()
    {
        if (!_disposed)
        {
            if (!_leaveOpen)
            {
                _httpClient.Dispose();
            }

            _disposed = true;
        }
    }
}
