using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Payments
{
    /// <summary>
    /// Refunds a captured payment, by ID. For a full refund, include an empty request body. For a partial refund, include an <code>amount</code> object in the request body.
    /// </summary>
    [DataContract]
    public class RefundRequest
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public RefundRequest()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
        public string InvoiceId { get; set; } = null!;

        /// <summary>
        /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "note_to_payer", EmitDefaultValue = false)]
        public string NoteToPayer { get; set; } = null!;
    }
}
