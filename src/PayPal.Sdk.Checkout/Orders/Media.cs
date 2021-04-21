using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The media type and context-encoding scheme.
    /// </summary>
    [DataContract]
    public class Media
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Media()
        {
        }

        /// <summary>
        /// The content-encoding scheme. See [Multipurpose Internet Mail Extensions (MIME) Part One: Format of Internet Message Bodies](https://tools.ietf.org/html/rfc2045).
        /// </summary>
        [DataMember(Name = "binaryEncoding", EmitDefaultValue = false)]
        public string BinaryEncoding { get; set; } = null!;

        /// <summary>
        /// The media type. See [Multipurpose Internet Mail Extensions (MIME) Part Two: Media Types](https://tools.ietf.org/html/rfc2046).
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; } = null!;
    }
}
