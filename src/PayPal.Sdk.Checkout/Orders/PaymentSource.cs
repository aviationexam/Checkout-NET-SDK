using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The payment source definition.
/// </summary>
[DataContract]
public class PaymentSource
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public PaymentSource()
    {
    }

    /// <summary>
    /// The payment card to use to fund a payment. Can be a credit or debit card.
    /// </summary>
    [DataMember(Name = "card", EmitDefaultValue = false)]
    public Card Card { get; set; } = null!;

    /// <summary>
    /// The tokenized payment source to fund a payment.
    /// </summary>
    [DataMember(Name = "token", EmitDefaultValue = false)]
    public Token Token { get; set; } = null!;
}
