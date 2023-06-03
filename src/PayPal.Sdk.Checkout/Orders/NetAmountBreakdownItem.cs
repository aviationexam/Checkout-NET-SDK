using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The net amount. Returned when the currency of the refund is different from the currency of the PayPal account where the merchant holds their funds.
/// </summary>
[DataContract]
public class NetAmountBreakdownItem
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public NetAmountBreakdownItem()
    {
    }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [DataMember(Name = "converted_amount", EmitDefaultValue = false)]
    public Money ConvertedAmount { get; set; } = null!;

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [DataMember(Name = "payable_amount", EmitDefaultValue = false)]
    public Money PayableAmount { get; set; } = null!;
}