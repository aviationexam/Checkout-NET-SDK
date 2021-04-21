using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Payments
{
    /// <summary>
    /// The request data or link target.
    /// </summary>
    [DataContract]
    public class LinkSchema<T>
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public LinkSchema()
        {
        }

        /// <summary>
        /// </summary>
        [DataMember(Name = "additionalItems", EmitDefaultValue = false)]
        public T AdditionalItems { get; set; } = default!;

        // /// <summary>
        // /// An array of sub-schemas. The data must validate against all sub-schemas.
        // /// </summary>
        // [DataMember(Name="allOf", EmitDefaultValue = false)]
        // public ICollection<AllOfItem> AllOf { get; set; } = null!;
        // /// <summary>
        // /// An array of sub-schemas. The data must validate against one or more sub-schemas.
        // /// </summary>
        // [DataMember(Name="anyOf", EmitDefaultValue = false)]
        // public ICollection<AnyOfItem> AnyOf { get; set; } = null!;
        /// <summary>
        /// </summary>
        [DataMember(Name = "definitions", EmitDefaultValue = false)]
        public T Definitions { get; set; } = default!;

        /// <summary>
        /// </summary>
        [DataMember(Name = "dependencies", EmitDefaultValue = false)]
        public T Dependencies { get; set; } = default!;

        /// <summary>
        /// </summary>
        [DataMember(Name = "fragmentResolution", EmitDefaultValue = false)]
        public string FragmentResolution { get; set; } = null!;

        /// <summary>
        /// An item.
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public T Items { get; set; } = default!;

        // /// <summary>
        // /// An array of links.
        // /// </summary>
        // [DataMember(Name="links", EmitDefaultValue = false)]
        // public ICollection<Link> Links { get; set; } = null!;
        /// <summary>
        /// The media type and context-encoding scheme.
        /// </summary>
        [DataMember(Name = "media", EmitDefaultValue = false)]
        public Media Media { get; set; } = null!;

        /// <summary>
        /// </summary>
        [DataMember(Name = "not", EmitDefaultValue = false)]
        public T Not { get; set; } = default!;

        // /// <summary>
        // /// An array of sub-schemas. The data must validate against one sub-schema.
        // /// </summary>
        // [DataMember(Name="oneOf", EmitDefaultValue = false)]
        // public ICollection<OneOfItem> OneOf { get; set; } = null!;
        /// <summary>
        /// To apply this schema to the instances' URIs, start the URIs with this value.
        /// </summary>
        [DataMember(Name = "pathStart", EmitDefaultValue = false)]
        public string PathStart { get; set; } = null!;

        /// <summary>
        /// </summary>
        [DataMember(Name = "patternProperties", EmitDefaultValue = false)]
        public T PatternProperties { get; set; } = default!;

        /// <summary>
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public T Properties { get; set; } = default!;
    }
}
