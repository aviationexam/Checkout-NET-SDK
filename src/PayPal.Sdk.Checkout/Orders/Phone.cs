using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
/// </summary>
[DataContract]
public class Phone
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public Phone()
    {
    }

    /// <summary>
    /// The country calling code (CC), in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). The combined length of the CC and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and subscriber number (SN).
    /// </summary>
    [DataMember(Name = "country_code", EmitDefaultValue = false)]
    public string CountryCallingCode { get; set; } = null!;

    /// <summary>
    /// The extension number.
    /// </summary>
    [DataMember(Name = "extension_number", EmitDefaultValue = false)]
    public string ExtensionNumber { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// The national number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). The combined length of the country calling code (CC) and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and subscriber number (SN).
    /// </summary>
    [DataMember(Name = "national_number", EmitDefaultValue = false)]
    public string NationalNumber { get; set; } = null!;
}