using PayPal.Sdk.Checkout.Core.Converters;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

public class JsonMessageSerializer : IMessageSerializer
{
    public const string ApplicationJson = "application/json";

    public bool CanSerialize<TRequestBody>(
        TRequestBody body, string contentType
    ) where TRequestBody : notnull => contentType == ApplicationJson;

    private JsonSerializerOptions GetJsonSerializerOptions()
    {
        var jsonSerializerOptions = new JsonSerializerOptions();
        jsonSerializerOptions.Converters.Add(new JsonStringEnumConverterFactory());

        return jsonSerializerOptions;
    }

    public async Task<HttpContent> SerializeAsync<TRequestBody>(
        TRequestBody body, string contentType,
        CancellationToken cancellationToken
    )
        where TRequestBody : notnull
    {
        var memoryStream = new MemoryStream();

        await JsonSerializer.SerializeAsync(
            memoryStream,
            body,
            GetJsonSerializerOptions(),
            cancellationToken
        );

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
    ) where TResponse : notnull => contentType.MediaType == ApplicationJson;

    public async Task<TResponse> DeserializeAsync<TResponse>(
        HttpContent response, MediaTypeHeaderValue contentType,
        CancellationToken cancellationToken
    )
        where TResponse : notnull
    {
        var stream = await response.ReadAsStreamAsync(
#if NET7_0_OR_GREATER
            cancellationToken
#endif
        );

        var deserializedResponse = await JsonSerializer.DeserializeAsync<TResponse>(
            stream,
            GetJsonSerializerOptions(),
            cancellationToken
        );

        return deserializedResponse ?? throw new NullReferenceException("Deserialize of the HttpContent is null");
    }
}
