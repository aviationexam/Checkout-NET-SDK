using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// Completes an action for an order.
/// </summary>
public class OrderActionRequest
{
    /// <summary>
    /// The payment source definition.
    /// </summary>
    [JsonPropertyName("payment_source")]
    public PaymentSource PaymentSource { get; set; } = null!;
}
