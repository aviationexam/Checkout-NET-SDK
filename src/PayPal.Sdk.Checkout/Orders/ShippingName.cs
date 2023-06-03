using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The name of the party.
/// </summary>
public class ShippingName
{
    /// <summary>
    /// When the party is a person, the party's full name.
    /// </summary>
    [JsonPropertyName("full_name")]
    public string FullName { get; set; } = null!;
}
