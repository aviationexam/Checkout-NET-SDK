using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The payment source definition.
/// </summary>
public class PaymentSource
{
    /// <summary>
    /// The payment card to use to fund a payment. Can be a credit or debit card.
    /// </summary>
    [JsonPropertyName("card")]
    public Card Card { get; set; } = null!;

    /// <summary>
    /// The tokenized payment source to fund a payment.
    /// </summary>
    [JsonPropertyName("token")]
    public Token Token { get; set; } = null!;
}
