using PayPal.Sdk.Checkout.Core.Interfaces;
using System.Net;
using System.Net.Http.Headers;

namespace PayPal.Sdk.Checkout.Core
{
    public class PayPalHttpResponse : IPayPalHttpResponse
    {
        public HttpResponseHeaders ResponseHeaders { get; }

        public HttpStatusCode ResponseStatusCode { get; }

        public PayPalHttpResponse(
            HttpResponseHeaders responseHeaders,
            HttpStatusCode responseStatusCode
        )
        {
            ResponseHeaders = responseHeaders;
            ResponseStatusCode = responseStatusCode;
        }
    }

    public class PayPalHttpResponse<TResponse> : PayPalHttpResponse, IPayPalHttpResponse<TResponse>
    {
        public TResponse? ResponseBody { get; }

        public PayPalHttpResponse(
            HttpResponseHeaders responseHeaders,
            HttpStatusCode responseStatusCode,
            TResponse? responseBody
        ) : base(responseHeaders, responseStatusCode)
        {
            ResponseBody = responseBody;
        }
    }
}
