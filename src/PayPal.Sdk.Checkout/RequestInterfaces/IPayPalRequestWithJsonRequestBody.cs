using System.Text.Json.Serialization.Metadata;

namespace PayPal.Sdk.Checkout.RequestInterfaces;

public interface IPayPalRequestWithJsonRequestBody<TRequestBody> : IPayPalRequestWithRequestBody<TRequestBody>
    where TRequestBody : notnull
{
    JsonTypeInfo<TRequestBody> JsonTypeInfoForRequestBody { get; }
}
