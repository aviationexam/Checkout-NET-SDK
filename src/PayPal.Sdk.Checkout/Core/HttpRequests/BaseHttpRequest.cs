using PayPal.Sdk.Checkout.RequestInterfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PayPal.Sdk.Checkout.Core.HttpRequests;

public abstract class BaseHttpRequest(
    string path,
    HttpMethod method
)
{
    public HttpMethod Method { get; } = method;

    public string Path { get; protected set; } = path;

    public IDictionary<string, ICollection<string>> Headers { get; } = new Dictionary<string, ICollection<string>>();

    public AuthenticationHeaderValue? Authorization { get; protected set; }

    public string ContentType { get; protected set; } = null!;
}

public abstract class BaseHttpRequest<TResponseType>(
    string path,
    HttpMethod method
) : BaseHttpRequest(path, method), IPayPalRequestWithResponseBody<TResponseType>
    where TResponseType : notnull;

public abstract class BaseHttpRequest<TResponseType, TRequestBody>(
    string path,
    HttpMethod method
) : BaseHttpRequest<TResponseType>(path, method),
    IPayPalRequestWithRequestBody<TRequestBody>
    where TResponseType : notnull
    where TRequestBody : notnull
{
    public string PayPalRequestId { get; } = Guid.NewGuid().ToString();

    public TRequestBody Body { get; private set; } = default!;

    // ReSharper disable once MemberCanBeProtected.Global
    public void SetRequestBody(TRequestBody request)
    {
        Body = request;
    }
}
