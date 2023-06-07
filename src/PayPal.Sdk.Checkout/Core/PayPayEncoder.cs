using PayPal.Sdk.Checkout.Core.Interfaces;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Core;

public class PayPayEncoder : IPayPayEncoder
{
    private readonly IReadOnlyCollection<IMessageSerializer> _messageSerializers;

    public PayPayEncoder()
    {
        _messageSerializers = new Collection<IMessageSerializer>
        {
            new FormEncodedSerializer(),
            new JsonMessageSerializer(),
            new TextSerializer(),
        };
    }

    public async Task<HttpContent> SerializeRequestAsync<TRequestBody>(
        TRequestBody body,
        JsonTypeInfo<TRequestBody>? requestBodyJsonTypeInfo,
        string contentType,
        CancellationToken cancellationToken
    )
        where TRequestBody : notnull
    {
        var serializer = _messageSerializers.FirstOrDefault(x => x.CanSerialize(body, contentType));

        if (serializer != null)
        {
            return await serializer.SerializeAsync(body, contentType, cancellationToken);
        }

        throw new ArgumentException($"Not found serializer for message {contentType}");
    }

    public async Task<TResponse> DeserializeResponseAsync<TResponse>(
        HttpContent httpContent,
        JsonTypeInfo<TResponse>? responseJsonTypeInfo,
        MediaTypeHeaderValue mediaTypeHeaderValue,
        CancellationToken cancellationToken
    )
        where TResponse : notnull
    {
        var serializer = _messageSerializers.FirstOrDefault(
            x => x.CanDeserialize<TResponse>(httpContent, mediaTypeHeaderValue)
        );

        if (serializer != null)
        {
            return await serializer.DeserializeAsync<TResponse>(httpContent, mediaTypeHeaderValue, cancellationToken);
        }

        throw new ArgumentException(
            $"Not found serializer for message CharSet={mediaTypeHeaderValue.CharSet} MediaType={mediaTypeHeaderValue.MediaType}"
        );
    }
}
