using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

public interface IMessageSerializer
{
    bool CanSerialize<TRequestBody>(TRequestBody body, string contentType)
        where TRequestBody : notnull;

    Task<HttpContent> SerializeAsync<TRequestBody>(
        TRequestBody body,
        JsonTypeInfo<TRequestBody>? requestBodyJsonTypeInfo,
        string contentType,
        CancellationToken cancellationToken
    )
        where TRequestBody : notnull;

    bool CanDeserialize<TResponse>(HttpContent response, MediaTypeHeaderValue contentType)
        where TResponse : notnull;

    Task<TResponse> DeserializeAsync<TResponse>(
        HttpContent response,
        JsonTypeInfo<TResponse>? responseJsonTypeInfo,
        MediaTypeHeaderValue contentType,
        CancellationToken cancellationToken
    )
        where TResponse : notnull;
}
