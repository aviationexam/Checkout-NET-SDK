using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The tax ID of the customer. The customer is also known as the payer. Both `tax_id` and `tax_id_type` are required.
/// </summary>
public class TaxInfo
{
    /// <summary>
    /// REQUIRED
    /// The customer's tax ID. Supported for the PayPal payment method only. Typically, the tax ID is 11 characters long for individuals and 14 characters long for businesses.
    /// </summary>
    [JsonPropertyName("tax_id")]
    public string TaxId { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// The customer's tax ID type. Supported for the PayPal payment method only.
    /// </summary>
    [JsonPropertyName("tax_id_type")]
    public ETaxIdType? TaxIdType { get; set; }
}
