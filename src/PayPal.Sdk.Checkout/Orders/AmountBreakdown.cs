using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The breakdown of the amount. Breakdown provides details such as total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.
    /// </summary>
    [DataContract]
    public class AmountBreakdown
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public AmountBreakdown()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "discount", EmitDefaultValue = false)]
        public Money? Discount { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "handling", EmitDefaultValue = false)]
        public Money? Handling { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "insurance", EmitDefaultValue = false)]
        public Money? Insurance { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "item_total", EmitDefaultValue = false)]
        public Money? ItemTotal { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "shipping", EmitDefaultValue = false)]
        public Money? Shipping { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "shipping_discount", EmitDefaultValue = false)]
        public Money? ShippingDiscount { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "tax_total", EmitDefaultValue = false)]
        public Money? TaxTotal { get; set; }
    }
}
