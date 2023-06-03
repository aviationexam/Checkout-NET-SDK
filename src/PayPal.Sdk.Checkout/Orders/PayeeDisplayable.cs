using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The merchant information. The merchant is also known as the payee. Appears to the customer in checkout, transactions, email receipts, and transaction history.
/// </summary>
[DataContract]
public class PayeeDisplayable
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public PayeeDisplayable()
    {
    }

    /// <summary>
    /// The name of the merchant. Appears to the customer in checkout, payment transactions, email receipts, and transaction history.
    /// </summary>
    [DataMember(Name = "brand_name", EmitDefaultValue = false)]
    public string BrandName { get; set; } = null!;

    /// <summary>
    /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
    /// </summary>
    [DataMember(Name = "business_phone", EmitDefaultValue = false)]
    public Phone BusinessPhone { get; set; } = null!;

    /// <summary>
    /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
    /// </summary>
    [DataMember(Name = "business_email", EmitDefaultValue = false)]
    public string Email { get; set; } = null!;
}
