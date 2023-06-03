using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// The detailed breakdown of the captured payment.
/// </summary>
public class MerchantReceivableBreakdown
{
    /// <summary>
    /// The exchange rate that determines the amount to convert from one currency to another currency.
    /// </summary>
    [JsonPropertyName("exchange_rate")]
    public ExchangeRate ExchangeRate { get; set; } = null!;

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("gross_amount")]
    public Money GrossAmount { get; set; } = null!;

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("net_amount")]
    public Money NetAmount { get; set; } = null!;

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("paypal_fee")]
    public Money PaypalFee { get; set; } = null!;

    /// <summary>
    /// An array of platform or partner fees, commissions, or brokerage fees that associated with the captured payment.
    /// </summary>
    [JsonPropertyName("platform_fees")]
    public ICollection<PlatformFee> PlatformFees { get; set; } = null!;

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("receivable_amount")]
    public Money ReceivableAmount { get; set; } = null!;
}
