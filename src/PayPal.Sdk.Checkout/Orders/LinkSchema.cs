using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The request data or link target.
/// </summary>
public class LinkSchema<T>
{
    /// <summary>
    /// </summary>
    [JsonPropertyName("additionalItems")]
    public T AdditionalItems { get; set; } = default!;

    // /// <summary>
    // /// An array of sub-schemas. The data must validate against all sub-schemas.
    // /// </summary>
    // [DataMember(Name="allOf")]
    // public ICollection<AllOfItem> AllOf { get; set; } = null!;
    // /// <summary>
    // /// An array of sub-schemas. The data must validate against one or more sub-schemas.
    // /// </summary>
    // [DataMember(Name="anyOf")]
    // public ICollection<AnyOfItem> AnyOf { get; set; } = null!;
    /// <summary>
    /// </summary>
    [JsonPropertyName("definitions")]
    public T Definitions { get; set; } = default!;

    /// <summary>
    /// </summary>
    [JsonPropertyName("dependencies")]
    public T Dependencies { get; set; } = default!;

    /// <summary>
    /// </summary>
    [JsonPropertyName("fragmentResolution")]
    public string FragmentResolution { get; set; } = null!;

    /// <summary>
    /// An item.
    /// </summary>
    [JsonPropertyName("items")]
    public T Items { get; set; } = default!;

    // /// <summary>
    // /// An array of links.
    // /// </summary>
    // [DataMember(Name="links")]
    // public ICollection<Link> Links { get; set; } = null!;
    /// <summary>
    /// </summary>
    [JsonPropertyName("not")]
    public T Not { get; set; } = default!;

    // /// <summary>
    // /// An array of sub-schemas. The data must validate against one sub-schema.
    // /// </summary>
    // [DataMember(Name="oneOf")]
    // public ICollection<OneOfItem> OneOf { get; set; } = null!;
    /// <summary>
    /// To apply this schema to the instances' URIs, start the URIs with this value.
    /// </summary>
    [JsonPropertyName("pathStart")]
    public string PathStart { get; set; } = null!;

    /// <summary>
    /// </summary>
    [JsonPropertyName("patternProperties")]
    public T PatternProperties { get; set; } = default!;

    /// <summary>
    /// </summary>
    [JsonPropertyName("properties")]
    public T Properties { get; set; } = default!;
}
