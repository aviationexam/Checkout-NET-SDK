using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// Any additional payment instructions for PayPal for Partner customers. Enables features for partners and marketplaces, such as delayed disbursement and collection of a platform fee. Applies during order creation for captured payments or during capture of authorized payments.
/// </summary>
public class PaymentInstruction
{
    /// <summary>
    /// The funds that are held on behalf of the merchant.
    /// </summary>
    [JsonPropertyName("platform_fees")]
    public ICollection<object>? PlatformFees { get; set; }

    /// <summary>
    /// The funds that are held on behalf of the merchant.
    /// </summary>
    [JsonPropertyName("payee_pricing_tier_id")]
    public string? PayeePricingTierId { get; set; }

    /// <summary>
    /// The funds that are held on behalf of the merchant.
    /// </summary>
    [JsonPropertyName("disbursement_mode")]
    public EDisbursementMode? DisbursementMode { get; set; }
}
