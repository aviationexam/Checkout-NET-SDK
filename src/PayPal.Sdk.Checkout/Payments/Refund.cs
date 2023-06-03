using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// The refund information.
/// </summary>
[DataContract]
public class Refund
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public Refund()
    {
    }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [DataMember(Name = "amount", EmitDefaultValue = false)]
    public Money Amount { get; set; } = null!;

    /// <summary>
    /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
    /// </summary>
    [DataMember(Name = "create_time", EmitDefaultValue = false)]
    public string CreateTime { get; set; } = null!;

    /// <summary>
    /// The PayPal-generated ID for the refund.
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
    public string InvoiceId { get; set; } = null!;

    /// <summary>
    /// An array of related [HATEOAS links](/docs/api/overview/#hateoas-links).
    /// </summary>
    [DataMember(Name = "links", EmitDefaultValue = false)]
    public ICollection<LinkDescription> Links { get; set; } = null!;

    /// <summary>
    /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    [DataMember(Name = "note_to_payer", EmitDefaultValue = false)]
    public string NoteToPayer { get; set; } = null!;

    /// <summary>
    /// The breakdown of the refund.
    /// </summary>
    [DataMember(Name = "seller_payable_breakdown", EmitDefaultValue = false)]
    public MerchantPayableBreakdown SellerPayableBreakdown { get; set; } = null!;

    /// <summary>
    /// The status of the capture.
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public string Status { get; set; } = null!;

    /// <summary>
    /// The details of the refund status.
    /// </summary>
    [DataMember(Name = "status_details", EmitDefaultValue = false)]
    public StatusDetails StatusDetails { get; set; } = null!;

    /// <summary>
    /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
    /// </summary>
    [DataMember(Name = "update_time", EmitDefaultValue = false)]
    public string UpdateTime { get; set; } = null!;
}
