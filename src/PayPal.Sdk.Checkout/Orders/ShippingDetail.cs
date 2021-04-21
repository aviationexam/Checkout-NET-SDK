using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The shipping details.
    /// </summary>
    [DataContract]
    public class ShippingDetail
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public ShippingDetail()
        {
        }

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public AddressPortable AddressPortable { get; set; } = null!;

        /// <summary>
        /// The name of the party.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Name Name { get; set; } = null!;

        /// <summary>
        /// An array of shipping options that the payee or merchant offers to the payer to ship or pick up their items
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public ICollection<ShippingOption> Options { get; set; } = null!;
    }
}
