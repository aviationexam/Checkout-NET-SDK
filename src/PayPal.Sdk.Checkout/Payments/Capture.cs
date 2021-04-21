using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Payments
{
    /// <summary>
    /// A captured payment.
    /// </summary>
    [DataContract]
    public class Capture
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Capture()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount { get; set; } = null!;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; } = null!;

        /// <summary>
        /// The funds that are held on behalf of the merchant.
        /// </summary>
        [DataMember(Name = "disbursement_mode", EmitDefaultValue = false)]
        public string DisbursementMode { get; set; } = null!;

        /// <summary>
        /// Indicates whether you can make additional captures against the authorized payment. Set to `true` if you do not intend to capture additional payments against the authorization. Set to `false` if you intend to capture additional payments against the authorization.
        /// </summary>
        [DataMember(Name = "final_capture", EmitDefaultValue = false)]
        public bool? FinalCapture { get; set; } = null!;

        /// <summary>
        /// The PayPal-generated ID for the captured payment.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
        public string InvoiceId { get; set; } = null!;

        /// <summary>
        /// An array of related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public ICollection<LinkDescription> Links { get; set; } = null!;

        /// <summary>
        /// The level of protection offered as defined by [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
        /// </summary>
        [DataMember(Name = "seller_protection", EmitDefaultValue = false)]
        public SellerProtection SellerProtection { get; set; } = null!;

        /// <summary>
        /// The detailed breakdown of the captured payment.
        /// </summary>
        [DataMember(Name = "seller_receivable_breakdown", EmitDefaultValue = false)]
        public MerchantReceivableBreakdown SellerReceivableBreakdown { get; set; } = null!;

        /// <summary>
        /// The status of the captured payment.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; } = null!;

        /// <summary>
        /// The details of the captured payment status.
        /// </summary>
        [DataMember(Name = "status_details", EmitDefaultValue = false)]
        public StatusDetails StatusDetails { get; set; } = null!;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name = "update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; } = null!;
    }
}
