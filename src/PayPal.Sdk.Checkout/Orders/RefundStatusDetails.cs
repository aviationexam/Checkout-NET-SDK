using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The details of the refund status.
/// </summary>
public class RefundStatusDetails
{
    /// <summary>
    /// The reason why the refund has the `PENDING` or `FAILED` status.
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; } = null!;
}
