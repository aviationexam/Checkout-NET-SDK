using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// The currency and amount for a financial transaction, such as a balance or payment due.
/// </summary>
public class PaymentMoney
{
    /// <summary>
    /// REQUIRED
    /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.
    /// </summary>
    [JsonPropertyName("currency_code")]
    public string CurrencyCode { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// The value, which might be:<ul><li>An integer for currencies like `JPY` that are not typically fractional.</li><li>A decimal fraction for currencies like `TND` that are subdivided into thousandths.</li></ul>For the required number of decimal places for a currency code, see [Currency Codes](/docs/integration/direct/rest/currency-codes/).
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; } = null!;
}
