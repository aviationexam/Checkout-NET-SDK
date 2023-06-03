using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.Configuration;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Core.Interfaces;

public interface IPayPalHttpClient : IDisposable
{
    PayPalOptions GetPayPalOptions { get; }

    Task<IPayPalHttpResponse<TResponse>> ExecuteAsync<TRequest, TRequestBody, TResponse>(
        TRequest request,
        AccessToken? accessToken = null,
        CancellationToken cancellationToken = default
    )
        where TRequest : BaseHttpRequest<TResponse, TRequestBody>
        where TRequestBody : notnull
        where TResponse : notnull;

    Task<IPayPalHttpResponse<TResponse>> ExecuteAsync<TRequest, TResponse>(
        TRequest request,
        AccessToken? accessToken,
        CancellationToken cancellationToken = default
    )
        where TRequest : BaseHttpRequest
        where TResponse : notnull;

    Task<IPayPalHttpResponse> ExecuteVoidAsync<TRequest, TRequestBody>(
        TRequest request,
        AccessToken? accessToken = null,
        CancellationToken cancellationToken = default
    )
        where TRequest : BaseVoidHttpRequest<TRequestBody>
        where TRequestBody : notnull;

    Task<IPayPalHttpResponse> ExecuteVoidAsync<TRequest>(
        TRequest request,
        AccessToken? accessToken = null,
        CancellationToken cancellationToken = default
    )
        where TRequest : BaseHttpRequest;
}
