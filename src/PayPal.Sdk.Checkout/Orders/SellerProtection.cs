using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The level of protection offered as defined by [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
    /// </summary>
    [DataContract]
    public class SellerProtection
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public SellerProtection()
        {
        }

        /// <summary>
        /// An array of conditions that are covered for the transaction.
        /// </summary>
        [DataMember(Name = "dispute_categories", EmitDefaultValue = false)]
        public ICollection<string> DisputeCategories { get; set; } = null!;

        /// <summary>
        /// Indicates whether the transaction is eligible for seller protection. For information, see [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public ESellerProtectionStatus Status { get; set; }
    }
}
