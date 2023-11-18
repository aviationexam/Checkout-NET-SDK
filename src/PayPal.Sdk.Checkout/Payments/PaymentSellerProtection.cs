using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// The level of protection offered as defined by [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
/// </summary>
public class PaymentSellerProtection
{
    /// <summary>
    /// An array of conditions that are covered for the transaction.
    /// </summary>
    [JsonPropertyName("dispute_categories")]
    public ICollection<string> DisputeCategories { get; set; } = null!;

    /// <summary>
    /// Indicates whether the transaction is eligible for seller protection.
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = null!;
}
