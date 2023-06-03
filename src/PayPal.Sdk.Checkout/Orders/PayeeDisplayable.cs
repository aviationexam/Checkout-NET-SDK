using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The merchant information. The merchant is also known as the payee. Appears to the customer in checkout, transactions, email receipts, and transaction history.
/// </summary>
public class PayeeDisplayable
{
    /// <summary>
    /// The name of the merchant. Appears to the customer in checkout, payment transactions, email receipts, and transaction history.
    /// </summary>
    [JsonPropertyName("brand_name")]
    public string BrandName { get; set; } = null!;

    /// <summary>
    /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
    /// </summary>
    [JsonPropertyName("business_phone")]
    public Phone BusinessPhone { get; set; } = null!;

    /// <summary>
    /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
    /// </summary>
    [JsonPropertyName("business_email")]
    public string Email { get; set; } = null!;
}
