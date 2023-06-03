using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The phone information.
/// </summary>
public class PhoneWithType
{
    /// <summary>
    /// REQUIRED
    /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
    /// </summary>
    [JsonPropertyName("phone_number")]
    public Phone PhoneNumber { get; set; } = null!;

    /// <summary>
    /// The phone type.
    /// </summary>
    [JsonPropertyName("phone_type")]
    public EPhoneType? PhoneType { get; set; }
}
