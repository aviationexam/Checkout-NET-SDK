using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The tax ID of the customer. The customer is also known as the payer. Both `tax_id` and `tax_id_type` are required.
/// </summary>
[DataContract]
public class TaxInfo
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public TaxInfo()
    {
    }

    /// <summary>
    /// REQUIRED
    /// The customer's tax ID. Supported for the PayPal payment method only. Typically, the tax ID is 11 characters long for individuals and 14 characters long for businesses.
    /// </summary>
    [DataMember(Name = "tax_id", EmitDefaultValue = false)]
    public string TaxId { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// The customer's tax ID type. Supported for the PayPal payment method only.
    /// </summary>
    [DataMember(Name = "tax_id_type", EmitDefaultValue = true)]
    public ETaxIdType TaxIdType { get; set; }
}