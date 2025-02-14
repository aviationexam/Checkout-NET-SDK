using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// The request-related [HATEOAS link](/docs/api/overview/#hateoas-links) information.
/// </summary>
public class PaymentLinkDescription
{
    /// <summary>
    /// The media type in which to submit the request data.
    /// </summary>
    [JsonPropertyName("encType")]
    public string EncType { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// The complete target URL. To make the related call, combine the method with this [URI Template-formatted](https://tools.ietf.org/html/rfc6570) link. For pre-processing, include the `$`, `(`, and `)` characters. The `href` is the key HATEOAS component that links a completed call with a subsequent call.
    /// </summary>
    [JsonPropertyName("href")]
    public string Href { get; set; } = null!;

    /// <summary>
    /// The media type, as defined by [RFC 2046](https://www.ietf.org/rfc/rfc2046.txt). Describes the link target.
    /// </summary>
    [JsonPropertyName("mediaType")]
    public string MediaType { get; set; } = null!;

    /// <summary>
    /// The HTTP method required to make the related call.
    /// </summary>
    [JsonPropertyName("method")]
    public string Method { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// The [link relation type](https://tools.ietf.org/html/rfc5988#section-4), which serves as an ID for a link that unambiguously describes the semantics of the link. See [Link Relations](https://www.iana.org/assignments/link-relations/link-relations.xhtml).
    /// </summary>
    [JsonPropertyName("rel")]
    public string Rel { get; set; } = null!;

    // /// <summary>
    // /// The request data or link target.
    // /// </summary>
    // [DataMember(Name="schema")]
    // public LinkSchema<T> Schema { get; set; } = null!;
    // /// <summary>
    // /// The request data or link target.
    // /// </summary>
    // [DataMember(Name="targetSchema")]
    // public LinkSchema<T> TargetSchema { get; set; } = null!;
    /// <summary>
    /// The link title.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;
}
