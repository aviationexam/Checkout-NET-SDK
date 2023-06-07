using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Core.Interfaces;

public interface IPayPayEncoder
{
    Task<HttpContent> SerializeRequestAsync<TRequestBody>(
        TRequestBody body,
        JsonTypeInfo<TRequestBody>? requestBodyJsonTypeInfo,
        string contentType,
        CancellationToken cancellationToken = default
    )
        where TRequestBody : notnull;

    Task<TResponse> DeserializeResponseAsync<TResponse>(
        HttpContent httpContent,
        JsonTypeInfo<TResponse>? responseJsonTypeInfo,
        MediaTypeHeaderValue mediaTypeHeaderValue,
        CancellationToken cancellationToken = default
    ) where TResponse : notnull;
}
