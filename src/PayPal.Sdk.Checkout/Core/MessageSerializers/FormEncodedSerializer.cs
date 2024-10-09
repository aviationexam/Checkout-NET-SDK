using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

public class FormEncodedSerializer : IMessageSerializer
{
    public const string ApplicationXForm = "application/x-www-form-urlencoded";

    public bool CanSerialize<TRequestBody>(
        TRequestBody body, string contentType
    ) where TRequestBody : notnull => string.Equals(contentType, ApplicationXForm, StringComparison.Ordinal);

    public Task<HttpContent> SerializeAsync<TRequestBody>(
        TRequestBody body,
        JsonTypeInfo<TRequestBody>? requestBodyJsonTypeInfo,
        string contentType,
        CancellationToken cancellationToken
    )
        where TRequestBody : notnull
    {
        if (body is IDictionary<string?, string?> dictionary)
        {
            return Task.FromResult<HttpContent>(new FormUrlEncodedContent(dictionary));
        }

        if (body is IReadOnlyDictionary<string?, string?> readOnlyDictionary)
        {
            return Task.FromResult<HttpContent>(new FormUrlEncodedContent(readOnlyDictionary));
        }

        throw new ArgumentException(
            "Request body must be IDictionary<string, string> when Content-Type is application/x-www-form-urlencoded",
            nameof(body)
        );
    }

    public bool CanDeserialize<TResponse>(
        HttpContent response, MediaTypeHeaderValue contentType
    ) where TResponse : notnull => false;

    public Task<TResponse> DeserializeAsync<TResponse>(
        HttpContent response,
        JsonTypeInfo<TResponse>? responseJsonTypeInfo,
        MediaTypeHeaderValue contentType,
        CancellationToken cancellationToken
    )
        where TResponse : notnull
    {
        throw new NotSupportedException($"{nameof(FormEncodedSerializer)}.{nameof(DeserializeAsync)} is not supported");
    }
}
