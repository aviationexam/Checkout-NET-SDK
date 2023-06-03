using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The details for the merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
/// </summary>
public class PayeeBase
{
    /// <summary>
    /// The public ID for the payee- or merchant-created app. Introduced to support use cases, such as BrainTree integration with PayPal, where payee `email_address` or `merchant_id` is not available.
    /// </summary>
    [JsonPropertyName("client_id")]
    public string ClientId { get; set; } = null!;

    /// <summary>
    /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
    /// </summary>
    [JsonPropertyName("email_address")]
    public string Email { get; set; } = null!;

    /// <summary>
    /// The PayPal payer ID, which is a masked version of the PayPal account number intended for use with third parties. The account number is reversibly encrypted and a proprietary variant of Base32 is used to encode the result.
    /// </summary>
    [JsonPropertyName("merchant_id")]
    public string MerchantId { get; set; } = null!;
}
