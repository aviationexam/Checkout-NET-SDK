using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

public class JsonMessageSerializer : IMessageSerializer
{
    public const string ApplicationJson = "application/json";

    public bool CanSerialize<TRequestBody>(
        TRequestBody body, string contentType
    ) where TRequestBody : notnull => string.Equals(contentType, ApplicationJson, StringComparison.Ordinal);

    public async Task<HttpContent> SerializeAsync<TRequestBody>(
        TRequestBody body,
        JsonTypeInfo<TRequestBody>? requestBodyJsonTypeInfo,
        string contentType,
        CancellationToken cancellationToken
    )
        where TRequestBody : notnull
    {
        _ = requestBodyJsonTypeInfo ?? throw new ArgumentNullException(nameof(requestBodyJsonTypeInfo));

        var memoryStream = new MemoryStream();

        await JsonSerializer.SerializeAsync(
            memoryStream,
            body,
            requestBodyJsonTypeInfo,
            cancellationToken
        ).ConfigureAwait(false);

        memoryStream.Seek(0, SeekOrigin.Begin);

        var content = new StreamContent(memoryStream);
        content.Headers.ContentType = new MediaTypeHeaderValue(ApplicationJson)
        {
            CharSet = Encoding.UTF8.WebName,
        };

        return content;
    }

    public bool CanDeserialize<TResponse>(
        HttpContent response, MediaTypeHeaderValue contentType
    ) where TResponse : notnull => string.Equals(contentType.MediaType, ApplicationJson, StringComparison.Ordinal);

    public async Task<TResponse> DeserializeAsync<TResponse>(
        HttpContent response,
        JsonTypeInfo<TResponse>? responseJsonTypeInfo,
        MediaTypeHeaderValue contentType,
        CancellationToken cancellationToken
    )
        where TResponse : notnull
    {
        _ = responseJsonTypeInfo ?? throw new ArgumentNullException(nameof(responseJsonTypeInfo));

        var stream = await response.ReadAsStreamAsync(
            cancellationToken
        ).ConfigureAwait(false);

        var deserializedResponse = await JsonSerializer.DeserializeAsync(
            stream,
            responseJsonTypeInfo,
            cancellationToken
        ).ConfigureAwait(false);

        return deserializedResponse ?? throw new NullReferenceException("Deserialize of the HttpContent is null");
    }
}
