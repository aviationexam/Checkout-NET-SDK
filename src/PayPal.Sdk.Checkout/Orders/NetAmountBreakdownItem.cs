using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The net amount. Returned when the currency of the refund is different from the currency of the PayPal account where the merchant holds their funds.
/// </summary>
public class NetAmountBreakdownItem
{
    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("converted_amount")]
    public Money ConvertedAmount { get; set; } = null!;

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("payable_amount")]
    public Money PayableAmount { get; set; } = null!;
}
