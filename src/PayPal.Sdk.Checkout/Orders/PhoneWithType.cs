using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The phone information.
    /// </summary>
    [DataContract]
    public class PhoneWithType
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public PhoneWithType()
        {
        }

        /// <summary>
        /// REQUIRED
        /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [DataMember(Name = "phone_number", EmitDefaultValue = false)]
        public Phone PhoneNumber { get; set; } = null!;

        /// <summary>
        /// The phone type.
        /// </summary>
        [DataMember(Name = "phone_type", EmitDefaultValue = true)]
        public EPhoneType PhoneType { get; set; }
    }
}
