using PayPal.Sdk.Checkout.Core.MessageSerializers;

namespace PayPal.Sdk.Checkout.Orders;

/// <inheritdoc />
public class OrdersStringPatchRequest : OrdersPatchRequest<string, StringPatch>
{
    public OrdersStringPatchRequest(
        string orderId
    ) : base(
        orderId,
        PayPalJsonSerializerContext.Default.IReadOnlyCollectionStringPatch
    )
    {
    }
}
