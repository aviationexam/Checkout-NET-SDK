using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// A captured payment.
/// </summary>
public class Capture
{
    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("amount")]
    public Money Amount { get; set; } = null!;

    /// <summary>
    /// The details of the captured payment status.
    /// </summary>
    [JsonPropertyName("status_details")]
    public CaptureStatusDetails CaptureStatusDetails { get; set; } = null!;

    /// <summary>
    /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
    /// </summary>
    [JsonPropertyName("create_time")]
    public string CreateTime { get; set; } = null!;

    /// <summary>
    /// The funds that are held on behalf of the merchant.
    /// </summary>
    [JsonPropertyName("disbursement_mode")]
    public string DisbursementMode { get; set; } = null!;

    /// <summary>
    /// Indicates whether you can make additional captures against the authorized payment. Set to `true` if you do not intend to capture additional payments against the authorization. Set to `false` if you intend to capture additional payments against the authorization.
    /// </summary>
    [JsonPropertyName("final_capture")]
    public bool? FinalCapture { get; set; }

    /// <summary>
    /// The PayPal-generated ID for the captured payment.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public string InvoiceId { get; set; } = null!;

    /// <summary>
    /// An array of related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links).
    /// </summary>
    [JsonPropertyName("links")]
    public ICollection<LinkDescription> Links { get; set; } = null!;

    /// <summary>
    /// The level of protection offered as defined by [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
    /// </summary>
    [JsonPropertyName("seller_protection")]
    public SellerProtection SellerProtection { get; set; } = null!;

    /// <summary>
    /// The detailed breakdown of the captured payment.
    /// </summary>
    [JsonPropertyName("seller_receivable_breakdown")]
    public MerchantReceivableBreakdown SellerReceivableBreakdown { get; set; } = null!;

    /// <summary>
    /// The status of the captured payment.
    /// </summary>
    [JsonPropertyName("status")]
    public ECaptureStatus? Status { get; set; }

    /// <summary>
    /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
    /// </summary>
    [JsonPropertyName("update_time")]
    public string UpdateTime { get; set; } = null!;
}
