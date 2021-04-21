using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The detailed breakdown of the captured payment.
    /// </summary>
    [DataContract]
    public class MerchantReceivableBreakdown
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public MerchantReceivableBreakdown()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "gross_amount", EmitDefaultValue = false)]
        public Money GrossAmount { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "net_amount", EmitDefaultValue = false)]
        public Money NetAmount { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "paypal_fee", EmitDefaultValue = false)]
        public Money PaypalFee { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "receivable_amount", EmitDefaultValue = false)]
        public Money ReceivableAmount { get; set; } = null!;
    }
}
