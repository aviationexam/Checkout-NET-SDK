using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The collection of payments, or transactions, for a purchase unit in an order. For example, authorized payments, captured payments, and refunds.
    /// </summary>
    [DataContract]
    public class PaymentCollection
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public PaymentCollection()
        {
        }

        /// <summary>
        /// An array of authorized payments for a purchase unit. A purchase unit can have zero or more authorized payments.
        /// </summary>
        [DataMember(Name = "authorizations", EmitDefaultValue = false)]
        public ICollection<Authorization> Authorizations { get; set; } = null!;

        /// <summary>
        /// An array of captured payments for a purchase unit. A purchase unit can have zero or more captured payments.
        /// </summary>
        [DataMember(Name = "captures", EmitDefaultValue = false)]
        public ICollection<Capture> Captures { get; set; } = null!;

        /// <summary>
        /// An array of refunds for a purchase unit. A purchase unit can have zero or more refunds.
        /// </summary>
        [DataMember(Name = "refunds", EmitDefaultValue = false)]
        public ICollection<Refund> Refunds { get; set; } = null!;
    }
}
