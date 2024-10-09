using Microsoft.Extensions.Options;
using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.Configuration;
using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.Interfaces;
using PayPal.Sdk.Checkout.RequestInterfaces;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Core;

public class PayPalHttpClient(
    HttpClient httpClient,
    IPayPayEncoder payPayEncoder,
    IOptions<PayPalOptions> payPalOptions,
    bool leaveOpen = true
) : IPayPalHttpClient
{
    public PayPalOptions GetPayPalOptions => payPalOptions.Value;

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
        TRequest request,
        CancellationToken cancellationToken
    )
        where TRequest : BaseHttpRequest
        where TRequestBody : notnull
    {
        if (request is IPayPalRequestWithRequestBody<TRequestBody> requestWithRequestBody)
        {
            return await payPayEncoder.SerializeRequestAsync(
                requestWithRequestBody.Body,
                (request as IPayPalRequestWithJsonRequestBody<TRequestBody>)?.JsonTypeInfoForRequestBody,
                requestWithRequestBody.ContentType,
                cancellationToken
            ).ConfigureAwait(false);
        }

        throw new ArgumentException(
            $"The request {typeof(TRequest)} do not implement {typeof(IPayPalRequestWithRequestBody<TRequestBody>)}",
            nameof(request)
        );
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
            cancellationToken
        ).ConfigureAwait(false);

        throw new PayPalHttpException(response.StatusCode, response.Headers, responseBodyContent);
    }

    protected virtual async Task<PayPalHttpResponse<TResponse>> ProcessResponseAsync<TResponse>(
        HttpResponseMessage response,
        JsonTypeInfo<TResponse>? jsonTypeInfoForResponseType,
        CancellationToken cancellationToken
    )
        where TResponse : notnull
    {
        if (response.IsSuccessStatusCode)
        {
            TResponse? responseBody = default;

            if (response.Content.Headers.ContentType != null)
            {
                responseBody = await payPayEncoder.DeserializeResponseAsync(
                    response.Content,
                    jsonTypeInfoForResponseType,
                    response.Content.Headers.ContentType,
                    cancellationToken
                ).ConfigureAwait(false);
            }

            return new PayPalHttpResponse<TResponse>(response.Headers, response.StatusCode, responseBody);
        }

        var responseBodyContent = await response.Content.ReadAsStringAsync(
            cancellationToken
        ).ConfigureAwait(false);

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
            using var httpContent = await CreateHttpContent<TRequest, TRequestBody>(
                request,
                cancellationToken
            ).ConfigureAwait(false);
            httpRequest.Content = httpContent;

            response = await httpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
        }
        else
        {
            response = await httpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
        }

        return await ProcessResponseAsync(
            response,
            (request as IPayPalRequestWithJsonResponseBody<TResponse>)?.JsonTypeInfoForResponseType,
            cancellationToken
        ).ConfigureAwait(false);
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
            throw new ArgumentException(
                $"Use the {nameof(ExecuteAsync)}<TRequest, TRequestBody, TResponse> method signature",
                nameof(request)
            );
        }

        var httpRequest = CreateHttpRequest(request, accessToken);

        var response = await httpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);

        return await ProcessResponseAsync(
            response,
            (request as IPayPalRequestWithJsonResponseBody<TResponse>)?.JsonTypeInfoForResponseType,
            cancellationToken
        ).ConfigureAwait(false);
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
            using var httpContent = await CreateHttpContent<TRequest, TRequestBody>(
                request,
                cancellationToken
            ).ConfigureAwait(false);
            httpRequest.Content = httpContent;

            response = await httpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
        }
        else
        {
            response = await httpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
        }

        return await ProcessResponseAsync(response, cancellationToken).ConfigureAwait(false);
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
            throw new ArgumentException(
                $"Use the {nameof(ExecuteVoidAsync)}<TRequest, TRequestBody> method signature",
                nameof(request)
            );
        }

        var httpRequest = CreateHttpRequest(request, accessToken);

        var response = await httpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);

        return await ProcessResponseAsync(response, cancellationToken).ConfigureAwait(false);
    }


    // ReSharper disable once RedundantDefaultMemberInitializer
    private bool _disposed = false;

    public void Dispose()
    {
        if (!_disposed)
        {
            if (!leaveOpen)
            {
                httpClient.Dispose();
            }

            _disposed = true;
        }
    }
}
