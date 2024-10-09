using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

public partial class TextSerializer : IMessageSerializer
{
    [GeneratedRegex("^text/.*$", RegexOptions.None, matchTimeoutMilliseconds: 1000)]
    private static partial Regex MyRegex();

    public bool CanSerialize<TRequestBody>(
        TRequestBody body, string contentType
    ) where TRequestBody : notnull => MyRegex().Match(contentType).Success;

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

        throw new ArgumentException(
            "Request body must be string when Content-Type is text/.*",
            nameof(body)
        );
    }

    public bool CanDeserialize<TResponse>(
        HttpContent response, MediaTypeHeaderValue contentType
    ) where TResponse : notnull => MyRegex().Match(contentType.MediaType!).Success;

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
        ).ConfigureAwait(false);
    }
}
