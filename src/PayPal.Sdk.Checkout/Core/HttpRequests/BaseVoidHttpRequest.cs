using System;
using System.Net.Http;
using PayPal.Sdk.Checkout.RequestInterfaces;

namespace PayPal.Sdk.Checkout.Core.HttpRequests;

public abstract class BaseVoidHttpRequest<TRequestBody>(
    string path,
    HttpMethod method
) : BaseHttpRequest(path, method), IPayPalRequestWithRequestBody<TRequestBody>
    where TRequestBody : notnull
{
    public string PayPalRequestId { get; } = Guid.NewGuid().ToString();

    public TRequestBody Body { get; private set; } = default!;

    public void SetRequestBody(TRequestBody request)
    {
        Body = request;
    }
}
