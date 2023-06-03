using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The media type and context-encoding scheme.
/// </summary>
public class Media
{
    /// <summary>
    /// The content-encoding scheme. See [Multipurpose Internet Mail Extensions (MIME) Part One: Format of Internet Message Bodies](https://tools.ietf.org/html/rfc2045).
    /// </summary>
    [JsonPropertyName("binaryEncoding")]
    public string BinaryEncoding { get; set; } = null!;

    /// <summary>
    /// The media type. See [Multipurpose Internet Mail Extensions (MIME) Part Two: Media Types](https://tools.ietf.org/html/rfc2046).
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;
}
