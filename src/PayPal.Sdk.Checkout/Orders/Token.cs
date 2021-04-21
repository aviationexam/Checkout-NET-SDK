using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The tokenized payment source to fund a payment.
    /// </summary>
    [DataContract]
    public class Token
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Token()
        {
        }

        /// <summary>
        /// REQUIRED
        /// The PayPal-generated ID for the token.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// REQUIRED
        /// The tokenization method that generated the ID.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; } = null!;
    }
}
