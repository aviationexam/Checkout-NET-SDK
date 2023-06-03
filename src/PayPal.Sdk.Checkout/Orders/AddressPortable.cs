using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
/// </summary>
[DataContract]
public class AddressPortable
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public AddressPortable()
    {
    }

    /// <summary>
    /// The non-portable additional address details that are sometimes needed for compliance, risk, or other scenarios where fine-grain address information might be needed. Not portable with common third party and open source. Redundant with core fields.<br/>For example, `address_portable.address_line_1` is usually a combination of `address_details.street_number`, `street_name`, and `street_type`.
    /// </summary>
    [DataMember(Name = "address_details", EmitDefaultValue = false)]
    public AddressDetails AddressDetails { get; set; } = null!;

    /// <summary>
    /// The first line of the address. For example, number or street. For example, `173 Drury Lane`. Required for data entry and compliance and risk checks. Must contain the full address.
    /// </summary>
    [DataMember(Name = "address_line_1", EmitDefaultValue = false)]
    public string AddressLine1 { get; set; } = null!;

    /// <summary>
    /// The second line of the address. For example, suite or apartment number.
    /// </summary>
    [DataMember(Name = "address_line_2", EmitDefaultValue = false)]
    public string AddressLine2 { get; set; } = null!;

    /// <summary>
    /// The third line of the address, if needed. For example, a street complement for Brazil, direction text, such as `next to Walmart`, or a landmark in an Indian address.
    /// </summary>
    [DataMember(Name = "address_line_3", EmitDefaultValue = false)]
    public string AddressLine3 { get; set; } = null!;

    /// <summary>
    /// The highest level sub-division in a country, which is usually a province, state, or ISO-3166-2 subdivision. Format for postal delivery. For example, `CA` and not `California`. Value, by country, is:<ul><li>UK. A county.</li><li>US. A state.</li><li>Canada. A province.</li><li>Japan. A prefecture.</li><li>Switzerland. A kanton.</li></ul>
    /// </summary>
    [DataMember(Name = "admin_area_1", EmitDefaultValue = false)]
    public string AdminArea1 { get; set; } = null!;

    /// <summary>
    /// A city, town, or village. Smaller than `admin_area_level_1`.
    /// </summary>
    [DataMember(Name = "admin_area_2", EmitDefaultValue = false)]
    public string AdminArea2 { get; set; } = null!;

    /// <summary>
    /// A sub-locality, suburb, neighborhood, or district. Smaller than `admin_area_level_2`. Value is:<ul><li>Brazil. Suburb, bairro, or neighborhood.</li><li>India. Sub-locality or district. Street name information is not always available but a sub-locality or district can be a very small area.</li></ul>
    /// </summary>
    [DataMember(Name = "admin_area_3", EmitDefaultValue = false)]
    public string AdminArea3 { get; set; } = null!;

    /// <summary>
    /// The neighborhood, ward, or district. Smaller than `admin_area_level_3` or `sub_locality`. Value is:<ul><li>The postal sorting code for Guernsey and many French territories, such as French Guiana.</li><li>The fine-grained administrative levels in China.</li></ul>
    /// </summary>
    [DataMember(Name = "admin_area_4", EmitDefaultValue = false)]
    public string AdminArea4 { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// The [two-character ISO 3166-1 code](/docs/integration/direct/rest/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
    /// </summary>
    [DataMember(Name = "country_code", EmitDefaultValue = false)]
    public string CountryCode { get; set; } = null!;

    /// <summary>
    /// The postal code, which is the zip code or equivalent. Typically required for countries with a postal code or an equivalent. See [postal code](https://en.wikipedia.org/wiki/Postal_code).
    /// </summary>
    [DataMember(Name = "postal_code", EmitDefaultValue = false)]
    public string PostalCode { get; set; } = null!;
}
