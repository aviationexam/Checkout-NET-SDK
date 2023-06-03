using System.Text.Json.Serialization.Metadata;

namespace PayPal.Sdk.Checkout.RequestInterfaces;

public interface IPayPalRequestWithRequestBody
{
    string ContentType { get; }

    string PayPalRequestId { get; }
}

public interface IPayPalRequestWithRequestBody<TRequestBody> : IPayPalRequestWithRequestBody
    where TRequestBody : notnull
{
    TRequestBody Body { get; }
}

public interface IPayPalRequestWithJsonRequestBody<TRequestBody> : IPayPalRequestWithRequestBody<TRequestBody>
    where TRequestBody : notnull
{
    JsonTypeInfo<TRequestBody> JsonTypeInfoForRequestBody { get; }
}
