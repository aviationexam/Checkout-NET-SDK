using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The payment card to use to fund a payment. Can be a credit or debit card.
/// </summary>
[DataContract]
public class Card
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public Card()
    {
    }

    /// <summary>
    /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
    /// </summary>
    [DataMember(Name = "billing_address", EmitDefaultValue = false)]
    public AddressPortable AddressPortable { get; set; } = null!;

    /// <summary>
    /// The card network or brand. Applies to credit, debit, gift, and payment cards.
    /// </summary>
    [DataMember(Name = "card_type", EmitDefaultValue = false)]
    public string CardType { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// The year and month, in ISO-8601 `YYYY-MM` date format. See [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
    /// </summary>
    [DataMember(Name = "expiry", EmitDefaultValue = false)]
    public string Expiry { get; set; } = null!;

    /// <summary>
    /// The PayPal-generated ID for the card.
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// The last digits of the payment card.
    /// </summary>
    [DataMember(Name = "last_digits", EmitDefaultValue = false)]
    public string LastDigits { get; set; } = null!;

    /// <summary>
    /// The card holder's name as it appears on the card.
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// The primary account number (PAN) for the payment card.
    /// </summary>
    [DataMember(Name = "number", EmitDefaultValue = false)]
    public string Number { get; set; } = null!;

    /// <summary>
    /// The three- or four-digit security code of the card. Also known as the CVV, CVC, CVN, CVE, or CID.
    /// </summary>
    [DataMember(Name = "security_code", EmitDefaultValue = false)]
    public string SecurityCode { get; set; } = null!;
}
