using System.Text.Json.Serialization.Metadata;

namespace PayPal.Sdk.Checkout.RequestInterfaces;

public interface IPayPalRequestWithJsonResponseBody<TResponseType> : IPayPalRequestWithResponseBody<TResponseType>
    where TResponseType : notnull
{
    JsonTypeInfo<TResponseType> JsonTypeInfoForResponseType { get; }
}
