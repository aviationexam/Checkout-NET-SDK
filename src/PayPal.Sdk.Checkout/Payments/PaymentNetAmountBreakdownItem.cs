using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// The net amount. Returned when the currency of the refund is different from the currency of the PayPal account where the merchant holds their funds.
/// </summary>
public class PaymentNetAmountBreakdownItem
{
    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("converted_amount")]
    public PaymentMoney ConvertedAmount { get; set; } = null!;

    /// <summary>
    /// The exchange rate that determines the amount to convert from one currency to another currency.
    /// </summary>
    [JsonPropertyName("exchange_rate")]
    public ExchangeRate ExchangeRate { get; set; } = null!;

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("payable_amount")]
    public PaymentMoney PayableAmount { get; set; } = null!;
}
