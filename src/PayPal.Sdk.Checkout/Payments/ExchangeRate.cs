using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// The exchange rate that determines the amount to convert from one currency to another currency.
/// </summary>
public class ExchangeRate
{
    /// <summary>
    /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.
    /// </summary>
    [JsonPropertyName("PayPalCheckoutSdk_currency")]
    public string PayPalCheckoutSdkCurrency { get; set; } = null!;

    /// <summary>
    /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.
    /// </summary>
    [JsonPropertyName("target_currency")]
    public string TargetCurrency { get; set; } = null!;

    /// <summary>
    /// The target currency amount. Equivalent to one unit of the PayPal.Sdk.Checkout currency. Formatted as integer or decimal value with one to 15 digits to the right of the decimal point.
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; } = null!;
}
