using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization.Metadata;

namespace PayPal.Sdk.Checkout.RequestInterfaces;

public interface IPayPalRequestWithResponseBody
{
}

public interface IPayPalRequestWithResponseBody<
    [SuppressMessage("ReSharper", "UnusedTypeParameter")]
TResponseType
> : IPayPalRequestWithResponseBody
    where TResponseType : notnull
{
}


public interface IPayPalRequestWithJsonResponseBody<TResponseType> : IPayPalRequestWithResponseBody<TResponseType>
    where TResponseType : notnull
{
    JsonTypeInfo<TResponseType> JsonTypeInfoForResponseType { get; }
}
