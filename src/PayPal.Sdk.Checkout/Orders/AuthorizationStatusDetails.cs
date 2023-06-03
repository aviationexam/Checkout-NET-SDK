using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The details of the authorized payment status.
/// </summary>
public class AuthorizationStatusDetails
{
    /// <summary>
    /// The reason why the authorized status is `PENDING`.
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; } = null!;
}
