using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The breakdown of the refund.
/// </summary>
[DataContract]
public class MerchantPayableBreakdown
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public MerchantPayableBreakdown()
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
    /// An array of breakdown values for the net amount. Returned when the currency of the refund is different from the currency of the PayPal account where the payee holds their funds.
    /// </summary>
    [DataMember(Name = "net_amount_breakdown", EmitDefaultValue = false)]
    public ICollection<NetAmountBreakdownItem> NetAmountBreakdown { get; set; } = null!;

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [DataMember(Name = "paypal_fee", EmitDefaultValue = false)]
    public Money PaypalFee { get; set; } = null!;

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [DataMember(Name = "total_refunded_amount", EmitDefaultValue = false)]
    public Money TotalRefundedAmount { get; set; } = null!;
}
