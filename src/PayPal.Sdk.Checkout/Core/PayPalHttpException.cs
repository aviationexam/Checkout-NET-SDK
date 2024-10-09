using System;
using System.Net;
using System.Net.Http.Headers;

namespace PayPal.Sdk.Checkout.Core;

public class PayPalHttpException(
    HttpStatusCode responseStatusCode,
    HttpResponseHeaders responseHeaders,
    string responseBodyContent
) : Exception(responseStatusCode.ToString())
{
    public HttpStatusCode ResponseStatusCode { get; } = responseStatusCode;

    public HttpResponseHeaders ResponseHeaders { get; } = responseHeaders;

    public string ResponseBodyContent { get; } = responseBodyContent;
}
