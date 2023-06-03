using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The payment card to use to fund a payment. Can be a credit or debit card.
/// </summary>
public class Card
{
    /// <summary>
    /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
    /// </summary>
    [JsonPropertyName("billing_address")]
    public AddressPortable AddressPortable { get; set; } = null!;

    /// <summary>
    /// The card network or brand. Applies to credit, debit, gift, and payment cards.
    /// </summary>
    [JsonPropertyName("card_type")]
    public string CardType { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// The year and month, in ISO-8601 `YYYY-MM` date format. See [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
    /// </summary>
    [JsonPropertyName("expiry")]
    public string Expiry { get; set; } = null!;

    /// <summary>
    /// The PayPal-generated ID for the card.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    /// <summary>
    /// The last digits of the payment card.
    /// </summary>
    [JsonPropertyName("last_digits")]
    public string LastDigits { get; set; } = null!;

    /// <summary>
    /// The card holder's name as it appears on the card.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// The primary account number (PAN) for the payment card.
    /// </summary>
    [JsonPropertyName("number")]
    public string Number { get; set; } = null!;

    /// <summary>
    /// The three- or four-digit security code of the card. Also known as the CVV, CVC, CVN, CVE, or CID.
    /// </summary>
    [JsonPropertyName("security_code")]
    public string SecurityCode { get; set; } = null!;
}
