using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The tokenized payment source to fund a payment.
/// </summary>
public class Token
{
    /// <summary>
    /// The PayPal-generated ID for the token.
    /// </summary>
    [Required]
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    /// <summary>
    /// The tokenization method that generated the ID.
    /// </summary>
    [Required]
    [JsonPropertyName("type")]
    public ETokenType? Type { get; set; }
}
