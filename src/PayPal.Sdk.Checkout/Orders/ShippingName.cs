using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The name of the party.
    /// </summary>
    [DataContract]
    public class ShippingName
    {
        /// <summary>
        /// When the party is a person, the party's full name.
        /// </summary>
        [DataMember(Name = "full_name", EmitDefaultValue = false)]
        public string FullName { get; set; } = null!;
    }
}
