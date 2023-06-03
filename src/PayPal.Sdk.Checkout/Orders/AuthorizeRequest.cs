using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The authorize an order request.
/// </summary>
[DataContract]
public class AuthorizeRequest : OrderActionRequest
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public AuthorizeRequest()
    {
    }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [DataMember(Name = "amount", EmitDefaultValue = false)]
    public Money Amount { get; set; } = null!;

    /// <summary>
    /// The API caller-provided external ID for the purchase unit. Required for multiple purchase units.
    /// </summary>
    [DataMember(Name = "reference_id", EmitDefaultValue = false)]
    public string ReferenceId { get; set; } = null!;
}