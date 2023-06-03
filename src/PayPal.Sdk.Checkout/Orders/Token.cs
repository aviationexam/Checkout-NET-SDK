using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The tokenized payment source to fund a payment.
/// </summary>
[DataContract]
public class Token
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public Token()
    {
    }

    /// <summary>
    /// The PayPal-generated ID for the token.
    /// </summary>
    [Required]
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// The tokenization method that generated the ID.
    /// </summary>
    [Required]
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public ETokenType? Type { get; set; }
}
