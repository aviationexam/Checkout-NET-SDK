using System.Diagnostics.CodeAnalysis;

namespace PayPal.Sdk.Checkout.RequestInterfaces;

public interface IPayPalRequestWithResponseBody;

public interface IPayPalRequestWithResponseBody<
    [SuppressMessage("ReSharper", "UnusedTypeParameter")]
TResponseType
> : IPayPalRequestWithResponseBody
    where TResponseType : notnull;
