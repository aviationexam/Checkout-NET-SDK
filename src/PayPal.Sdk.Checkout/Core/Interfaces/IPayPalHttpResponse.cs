using System.Net;
using System.Net.Http.Headers;

namespace PayPal.Sdk.Checkout.Core.Interfaces
{
    public interface IPayPalHttpResponse
    {
        HttpResponseHeaders ResponseHeaders { get; }

        HttpStatusCode ResponseStatusCode { get; }
    }

    public interface IPayPalHttpResponse<out TResponse> : IPayPalHttpResponse
    {
        TResponse? ResponseBody { get; }
    }
}
