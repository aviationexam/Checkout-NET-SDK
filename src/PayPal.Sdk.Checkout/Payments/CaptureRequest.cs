using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Payments
{
    /// <summary>
    /// Captures either a portion or the full authorized amount of an authorized payment.
    /// </summary>
    [DataContract]
    public class CaptureRequest
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public CaptureRequest()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount { get; set; } = null!;

        /// <summary>
        /// Indicates whether you can make additional captures against the authorized payment. Set to `true` if you do not intend to capture additional payments against the authorization. Set to `false` if you intend to capture additional payments against the authorization.
        /// </summary>
        [DataMember(Name = "final_capture", EmitDefaultValue = false)]
        public bool? FinalCapture { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
        public string InvoiceId { get; set; } = null!;

        /// <summary>
        /// Any additional payment instructions for PayPal for Partner customers. Enables features for partners and marketplaces, such as delayed disbursement and collection of a platform fee. Applies during order creation for captured payments or during capture of authorized payments.
        /// </summary>
        [DataMember(Name = "payment_instruction", EmitDefaultValue = false)]
        public PaymentInstruction PaymentInstruction { get; set; } = null!;
    }
}
