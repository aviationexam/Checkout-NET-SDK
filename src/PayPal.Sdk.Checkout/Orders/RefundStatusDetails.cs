using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The details of the refund status.
    /// </summary>
    [DataContract]
    public class RefundStatusDetails
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public RefundStatusDetails()
        {
        }

        /// <summary>
        /// The reason why the refund has the `PENDING` or `FAILED` status.
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; } = null!;
    }
}
