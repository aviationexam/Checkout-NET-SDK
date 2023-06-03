using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The authorize an order request.
/// </summary>
public class AuthorizeRequest : OrderActionRequest
{
    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("amount")]
    public Money Amount { get; set; } = null!;

    /// <summary>
    /// The API caller-provided external ID for the purchase unit. Required for multiple purchase units.
    /// </summary>
    [JsonPropertyName("reference_id")]
    public string ReferenceId { get; set; } = null!;
}
