using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// The details of the captured payment status.
/// </summary>
public class StatusDetails
{
    /// <summary>
    /// The reason why the captured payment status is `PENDING` or `DENIED`.
    /// </summary>
    [field: JsonPropertyName("reason")]
    public string Reason { get; set; } = null!;
}
