using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// Completes an capture payment for an order.
/// </summary>
[DataContract]
public class OrderCaptureRequest
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public OrderCaptureRequest()
    {
    }

    /// <summary>
    /// The payment source definition.
    /// </summary>
    [DataMember(Name = "payment_source", EmitDefaultValue = false)]
    public PaymentSource PaymentSource { get; set; } = null!;
}
