using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Core.Interfaces;

public interface IPayPayEncoder
{
    Task<HttpContent> SerializeRequestAsync<TRequestBody>(
        TRequestBody body,
        string contentType,
        CancellationToken cancellationToken = default
    )
        where TRequestBody : notnull;

    Task<TResponse> DeserializeResponseAsync<TResponse>(
        HttpContent httpContent,
        MediaTypeHeaderValue mediaTypeHeaderValue,
        CancellationToken cancellationToken = default
    ) where TResponse : notnull;
}
