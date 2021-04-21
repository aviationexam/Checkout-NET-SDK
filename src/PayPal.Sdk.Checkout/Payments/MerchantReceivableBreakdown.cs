using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Payments
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
        /// The exchange rate that determines the amount to convert from one currency to another currency.
        /// </summary>
        [DataMember(Name = "exchange_rate", EmitDefaultValue = false)]
        public ExchangeRate ExchangeRate { get; set; } = null!;

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
        /// An array of platform or partner fees, commissions, or brokerage fees that associated with the captured payment.
        /// </summary>
        [DataMember(Name = "platform_fees", EmitDefaultValue = false)]
        public ICollection<PlatformFee> PlatformFees { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "receivable_amount", EmitDefaultValue = false)]
        public Money ReceivableAmount { get; set; } = null!;
    }
}
