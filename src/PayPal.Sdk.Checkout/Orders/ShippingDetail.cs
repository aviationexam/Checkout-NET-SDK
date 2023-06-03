using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The shipping details.
/// </summary>
public class ShippingDetail
{
    /// <summary>
    /// The name of the party.
    /// </summary>
    [JsonPropertyName("name")]
    public ShippingName Name { get; set; } = null!;

    [JsonPropertyName("type")]
    public EShippingType? Type { get; set; }

    /// <summary>
    /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
    /// </summary>
    [JsonPropertyName("address")]
    public AddressPortable AddressPortable { get; set; } = null!;
}
