using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// The refund information.
/// </summary>
public class PaymentRefund
{
    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("amount")]
    public PaymentMoney Amount { get; set; } = null!;

    /// <summary>
    /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
    /// </summary>
    [JsonPropertyName("create_time")]
    public string CreateTime { get; set; } = null!;

    /// <summary>
    /// The PayPal-generated ID for the refund.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public string InvoiceId { get; set; } = null!;

    /// <summary>
    /// An array of related [HATEOAS links](/docs/api/overview/#hateoas-links).
    /// </summary>
    [JsonPropertyName("links")]
    public ICollection<PaymentLinkDescription> Links { get; set; } = null!;

    /// <summary>
    /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    [JsonPropertyName("note_to_payer")]
    public string NoteToPayer { get; set; } = null!;

    /// <summary>
    /// The breakdown of the refund.
    /// </summary>
    [JsonPropertyName("seller_payable_breakdown")]
    public PaymentMerchantPayableBreakdown SellerPayableBreakdown { get; set; } = null!;

    /// <summary>
    /// The status of the capture.
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = null!;

    /// <summary>
    /// The details of the refund status.
    /// </summary>
    [JsonPropertyName("status_details")]
    public StatusDetails StatusDetails { get; set; } = null!;

    /// <summary>
    /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
    /// </summary>
    [JsonPropertyName("update_time")]
    public string UpdateTime { get; set; } = null!;
}
