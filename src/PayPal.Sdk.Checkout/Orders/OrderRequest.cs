using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The order request details.
    /// </summary>
    [DataContract]
    public class OrderRequest
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public OrderRequest()
        {
        }

        /// <summary>
        /// Customizes the payer experience during the approval process for the payment with PayPal.<blockquote><strong>Note:</strong> Partners and Marketplaces might configure <code>brand_name</code> and <code>shipping_preference</code> during partner account setup, which overrides the request values.</blockquote>
        /// </summary>
        [DataMember(Name = "application_context", EmitDefaultValue = false)]
        public ApplicationContext ApplicationContext { get; set; } = null!;

        /// <summary>
        /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
        /// </summary>
        [DataMember(Name = "intent", EmitDefaultValue = true)]
        public EOrderIntent CheckoutPaymentIntent { get; set; }

        /// <summary>
        /// The customer who approves and pays for the order. The customer is also known as the payer.
        /// </summary>
        [DataMember(Name = "payer", EmitDefaultValue = false)]
        public Payer Payer { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// An array of purchase units. At present only 1 purchase_unit is supported. Each purchase unit establishes a contract between a payer and the payee. Each purchase unit represents either a full or partial order that the payer intends to purchase from the payee.
        /// </summary>
        [DataMember(Name = "purchase_units", EmitDefaultValue = false)]
        public ICollection<PurchaseUnitRequest> PurchaseUnits { get; set; } = null!;
    }
}
