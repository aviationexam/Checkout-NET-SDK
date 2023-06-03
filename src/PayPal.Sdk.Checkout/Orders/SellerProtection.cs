using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The level of protection offered as defined by [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
/// </summary>
public class SellerProtection
{
    /// <summary>
    /// An array of conditions that are covered for the transaction.
    /// </summary>
    [JsonPropertyName("dispute_categories")]
    public ICollection<string> DisputeCategories { get; set; } = null!;

    /// <summary>
    /// Indicates whether the transaction is eligible for seller protection. For information, see [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
    /// </summary>
    [JsonPropertyName("status")]
    public ESellerProtectionStatus? Status { get; set; }
}
