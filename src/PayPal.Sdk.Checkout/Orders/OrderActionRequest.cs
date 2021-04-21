using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// Completes an action for an order.
    /// </summary>
    [DataContract]
    public class OrderActionRequest
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public OrderActionRequest()
        {
        }

        /// <summary>
        /// The payment source definition.
        /// </summary>
        [DataMember(Name = "payment_source", EmitDefaultValue = false)]
        public PaymentSource PaymentSource { get; set; } = null!;
    }
}
