using System;
using System.Net.Http;
using PayPal.Sdk.Checkout.RequestInterfaces;

namespace PayPal.Sdk.Checkout.Core.HttpRequests;

public abstract class BaseVoidHttpRequest<TRequestBody> : BaseHttpRequest, IPayPalRequestWithRequestBody<TRequestBody>
    where TRequestBody : notnull
{
    public string PayPalRequestId { get; }

    public TRequestBody Body { get; private set; } = default!;

    protected BaseVoidHttpRequest(
        string path, HttpMethod method
    ) : base(path, method)
    {
        PayPalRequestId = Guid.NewGuid().ToString();
    }

    public void SetRequestBody(TRequestBody request)
    {
        Body = request;
    }
}
