using PayPal.Sdk.Checkout.Core.MessageSerializers;

namespace PayPal.Sdk.Checkout.Orders;

/// <inheritdoc />
public class OrdersStringPatchRequest(
    string orderId
) : OrdersPatchRequest<string, StringPatch>(
    orderId,
    PayPalJsonSerializerContext.Default.IReadOnlyCollectionStringPatch
);
