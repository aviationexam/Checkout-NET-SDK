using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// Refunds a captured payment, by ID. For a full refund, include an empty request body. For a partial refund, include an <code>amount</code> object in the request body.
/// </summary>
public class RefundRequest
{
    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("amount")]
    public PaymentMoney Amount { get; set; } = null!;

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public string InvoiceId { get; set; } = null!;

    /// <summary>
    /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    [JsonPropertyName("note_to_payer")]
    public string NoteToPayer { get; set; } = null!;
}
