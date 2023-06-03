using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The collection of payments, or transactions, for a purchase unit in an order. For example, authorized payments, captured payments, and refunds.
/// </summary>
public class PaymentCollection
{
    /// <summary>
    /// An array of authorized payments for a purchase unit. A purchase unit can have zero or more authorized payments.
    /// </summary>
    [JsonPropertyName("authorizations")]
    public ICollection<Authorization> Authorizations { get; set; } = null!;

    /// <summary>
    /// An array of captured payments for a purchase unit. A purchase unit can have zero or more captured payments.
    /// </summary>
    [JsonPropertyName("captures")]
    public ICollection<Capture> Captures { get; set; } = null!;

    /// <summary>
    /// An array of refunds for a purchase unit. A purchase unit can have zero or more refunds.
    /// </summary>
    [JsonPropertyName("refunds")]
    public ICollection<Refund> Refunds { get; set; } = null!;
}
