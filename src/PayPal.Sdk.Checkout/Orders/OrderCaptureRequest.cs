using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// Completes an capture payment for an order.
/// </summary>
public class OrderCaptureRequest
{
    /// <summary>
    /// The payment source definition.
    /// </summary>
    [JsonPropertyName("payment_source")]
    public PaymentSource PaymentSource { get; set; } = null!;
}
