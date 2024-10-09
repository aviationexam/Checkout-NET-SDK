using PayPal.Sdk.Checkout.Core.Interfaces;
using System.Net;
using System.Net.Http.Headers;

namespace PayPal.Sdk.Checkout.Core;

public class PayPalHttpResponse(
    HttpResponseHeaders responseHeaders,
    HttpStatusCode responseStatusCode
) : IPayPalHttpResponse
{
    public HttpResponseHeaders ResponseHeaders { get; } = responseHeaders;

    public HttpStatusCode ResponseStatusCode { get; } = responseStatusCode;
}

public class PayPalHttpResponse<TResponse>(
    HttpResponseHeaders responseHeaders,
    HttpStatusCode responseStatusCode,
    TResponse? responseBody
) : PayPalHttpResponse(responseHeaders, responseStatusCode), IPayPalHttpResponse<TResponse>
{
    public TResponse? ResponseBody { get; } = responseBody;
}
