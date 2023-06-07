using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

public class TextSerializer : IMessageSerializer
{
    private readonly Regex _contentTypeRegex = new("^text/.*$");

    public bool CanSerialize<TRequestBody>(
        TRequestBody body, string contentType
    ) where TRequestBody : notnull => _contentTypeRegex.Match(contentType).Success;

    public Task<HttpContent> SerializeAsync<TRequestBody>(
        TRequestBody body,
        JsonTypeInfo<TRequestBody>? requestBodyJsonTypeInfo,
        string contentType,
        CancellationToken cancellationToken
    )
        where TRequestBody : notnull
    {
        if (body is string bodyString)
        {
            return Task.FromResult((HttpContent) new StringContent(bodyString));
        }

        throw new ArgumentException("Request requestBody must be string when Content-Type is text/.*");
    }

    public bool CanDeserialize<TResponse>(
        HttpContent response, MediaTypeHeaderValue contentType
    ) where TResponse : notnull => _contentTypeRegex.Match(contentType.MediaType!).Success;

    public async Task<TResponse> DeserializeAsync<TResponse>(
        HttpContent response,
        JsonTypeInfo<TResponse>? responseJsonTypeInfo,
        MediaTypeHeaderValue contentType,
        CancellationToken cancellationToken
    )
        where TResponse : notnull
    {
        return (TResponse) (object) await response.ReadAsStringAsync(
            cancellationToken
        );
    }
}
