using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// The platform or partner fee, commission, or brokerage fee that is associated with the transaction. Not a separate or isolated transaction leg from the external perspective. The platform fee is limited in scope and is always associated with the original payment for the purchase unit.
/// </summary>
[DataContract]
public class PlatformFee
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public PlatformFee()
    {
    }

    /// <summary>
    /// REQUIRED
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [DataMember(Name = "amount", EmitDefaultValue = false)]
    public Money Amount { get; set; } = null!;

    /// <summary>
    /// The details for the merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
    /// </summary>
    [DataMember(Name = "payee", EmitDefaultValue = false)]
    public MerchantBase Payee { get; set; } = null!;
}
