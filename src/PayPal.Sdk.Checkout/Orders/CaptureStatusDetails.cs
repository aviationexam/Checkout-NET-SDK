using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The details of the captured payment status.
/// </summary>
public class CaptureStatusDetails
{
    /// <summary>
    /// The reason why the captured payment status is `PENDING` or `DENIED`.
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; } = null!;
}
