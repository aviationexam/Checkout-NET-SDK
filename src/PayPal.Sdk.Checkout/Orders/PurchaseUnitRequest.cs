using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The purchase unit request. Includes required information for the payment contract.
/// </summary>
public class PurchaseUnitRequest
{
    /// <summary>
    /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.<br/>If you specify `amount.breakdown`, the amount equals `item_total` plus `tax_total` plus `shipping` plus `handling` plus `insurance` minus `shipping_discount` minus discount.<br/>The amount must be a positive number. For listed of supported currencies and decimal precision, see the PayPal REST APIs <a href="/docs/integration/direct/rest/currency-codes/">Currency Codes</a>.
    /// </summary>
    [JsonPropertyName("amount")]
    public AmountWithBreakdown AmountWithBreakdown { get; set; } = null!;

    /// <summary>
    /// The API caller-provided external ID. Used to reconcile client transactions with PayPal transactions. Appears in transaction and settlement reports but is not visible to the payer.
    /// </summary>
    [JsonPropertyName("custom_id")]
    public string? CustomId { get; set; }

    /// <summary>
    /// The purchase description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; set; }

    /// <summary>
    /// An array of items that the customer purchases from the merchant.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<Item> Items { get; set; } = null!;

    /// <summary>
    /// The merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
    /// </summary>
    [JsonPropertyName("payee")]
    public Payee? Payee { get; set; }

    /// <summary>
    /// Any additional payment instructions for PayPal for Partner customers. Enables features for partners and marketplaces, such as delayed disbursement and collection of a platform fee. Applies during order creation for captured payments or during capture of authorized payments.
    /// </summary>
    [JsonPropertyName("payment_instruction")]
    public OrderPaymentInstruction? PaymentInstruction { get; set; }

    /// <summary>
    /// The API caller-provided external ID for the purchase unit. Required for multiple purchase units when you must update the order through `PATCH`. If you omit this value and the order contains only one purchase unit, PayPal sets this value to `default`.
    /// </summary>
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; set; } = null!;

    /// <summary>
    /// The shipping details.
    /// </summary>
    [JsonPropertyName("shipping")]
    public ShippingDetail? ShippingDetail { get; set; }

    /// <summary>
    /// The payment descriptor on account transactions on the customer's credit card statement. The maximum length of the soft descriptor is 22 characters. Of this, the PayPal prefix uses eight characters (`PAYPAL *`). So, the maximum length of the soft descriptor is:<pre>22 - length(PayPal *) - length(<var>soft_descriptor_in_profile</var> + 1)</pre>If the total length of the `soft_descriptor` exceeds 22 characters, the overflow is truncated.<br/><br/>For example, if:<ul><li>The PayPal prefix toggle is <code>PAYPAL *</code>.</li><li>The merchant descriptor in the profile is <code>VENMO</code>.</li><li>The soft descriptor is <code>JanesFlowerGifts LLC</code>.</li></ul>Then, the descriptor on the credit card is <code>PAYPAL *VENMO JanesFlo</code>.
    /// </summary>
    [JsonPropertyName("soft_descriptor")]
    public string? SoftDescriptor { get; set; }
}
