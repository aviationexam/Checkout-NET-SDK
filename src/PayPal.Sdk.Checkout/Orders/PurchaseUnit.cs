using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The purchase unit details. Used to capture required information for the payment contract.
/// </summary>
public class PurchaseUnit
{
    /// <summary>
    /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.<br/>If you specify `amount.breakdown`, the amount equals `item_total` plus `tax_total` plus `shipping` plus `handling` plus `insurance` minus `shipping_discount` minus discount.<br/>The amount must be a positive number. For listed of supported currencies and decimal precision, see the PayPal REST APIs <a href="/docs/integration/direct/rest/currency-codes/">Currency Codes</a>.
    /// </summary>
    [JsonPropertyName("amount")]
    public AmountWithBreakdown AmountWithBreakdown { get; set; } = null!;

    /// <summary>
    /// The API caller-provided external ID. Used to reconcile API caller-initiated transactions with PayPal transactions. Appears in transaction and settlement reports.
    /// </summary>
    [JsonPropertyName("custom_id")]
    public string CustomId { get; set; } = null!;

    /// <summary>
    /// The purchase description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    /// <summary>
    /// The PayPal-generated ID for the purchase unit. This ID appears in both the payer's transaction history and the emails that the payer receives. In addition, this ID is available in transaction and settlement reports that merchants and API callers can use to reconcile transactions. This ID is only available when an order is saved by calling <code>v2/checkout/orders/id/save</code>.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    /// <summary>
    /// The API caller-provided external invoice ID for this order.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public string InvoiceId { get; set; } = null!;

    /// <summary>
    /// An array of items that the customer purchases from the merchant.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<Item> Items { get; set; } = null!;

    /// <summary>
    /// The merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
    /// </summary>
    [JsonPropertyName("payee")]
    public Payee Payee { get; set; } = null!;

    /// <summary>
    /// Any additional payment instructions for PayPal for Partner customers. Enables features for partners and marketplaces, such as delayed disbursement and collection of a platform fee. Applies during order creation for captured payments or during capture of authorized payments.
    /// </summary>
    [JsonPropertyName("payment_instruction")]
    public PaymentInstruction PaymentInstruction { get; set; } = null!;

    /// <summary>
    /// The collection of payments, or transactions, for a purchase unit in an order. For example, authorized payments, captured payments, and refunds.
    /// </summary>
    [JsonPropertyName("payments")]
    public PaymentCollection Payments { get; set; } = null!;

    /// <summary>
    /// The API caller-provided external ID for the purchase unit. Required for multiple purchase units when you must update the order through `PATCH`. If you omit this value and the order contains only one purchase unit, PayPal sets this value to `default`.
    /// </summary>
    [JsonPropertyName("reference_id")]
    public string ReferenceId { get; set; } = null!;

    /// <summary>
    /// The shipping details.
    /// </summary>
    [JsonPropertyName("shipping")]
    public ShippingDetail ShippingDetail { get; set; } = null!;

    /// <summary>
    /// The payment descriptor on account transactions on the customer's credit card statement. The maximum length of the soft descriptor is 22 characters. Of this, the PayPal prefix uses eight characters (`PAYPAL *`). So, the maximum length of the soft descriptor is:<pre>22 - length(PayPal *) - length(<var>soft_descriptor_in_profile</var> + 1)</pre>If the total length of the `soft_descriptor` exceeds 22 characters, the overflow is truncated.<br/><br/>For example, if:<ul><li>The PayPal prefix toggle is <code>PAYPAL *</code>.</li><li>The merchant descriptor in the profile is <code>VENMO</code>.</li><li>The soft descriptor is <code>JanesFlowerGifts LLC</code>.</li></ul>Then, the descriptor on the credit card is <code>PAYPAL *VENMO JanesFlo</code>.
    /// </summary>
    [JsonPropertyName("soft_descriptor")]
    public string SoftDescriptor { get; set; } = null!;
}
