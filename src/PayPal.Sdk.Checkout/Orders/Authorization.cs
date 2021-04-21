using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The authorized payment transaction.
    /// </summary>
    [DataContract]
    public class Authorization
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Authorization()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount { get; set; } = null!;

        /// <summary>
        /// The details of the authorized payment status.
        /// </summary>
        [DataMember(Name = "status_details", EmitDefaultValue = false)]
        public AuthorizationStatusDetails AuthorizationStatusDetails { get; set; } = null!;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; } = null!;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name = "expiration_time", EmitDefaultValue = false)]
        public string ExpirationTime { get; set; } = null!;

        /// <summary>
        /// The PayPal-generated ID for the authorized payment.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
        public string InvoiceId { get; set; } = null!;

        /// <summary>
        /// An array of related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links).
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public ICollection<LinkDescription> Links { get; set; } = null!;

        /// <summary>
        /// The level of protection offered as defined by [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
        /// </summary>
        [DataMember(Name = "seller_protection", EmitDefaultValue = false)]
        public SellerProtection SellerProtection { get; set; } = null!;

        /// <summary>
        /// The status for the authorized payment.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public EAuthorizationStatus Status { get; set; }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name = "update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; } = null!;
    }
}
