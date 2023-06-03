using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// Any additional payment instructions for PayPal for Partner customers. Enables features for partners and marketplaces, such as delayed disbursement and collection of a platform fee. Applies during order creation for captured payments or during capture of authorized payments.
/// </summary>
[DataContract]
public class PaymentInstruction
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public PaymentInstruction()
    {
    }

    /// <summary>
    /// The funds that are held on behalf of the merchant.
    /// </summary>
    [DataMember(Name = "platform_fees", EmitDefaultValue = false)]
    public ICollection<object>? PlatformFees { get; set; }

    /// <summary>
    /// The funds that are held on behalf of the merchant.
    /// </summary>
    [DataMember(Name = "payee_pricing_tier_id", EmitDefaultValue = false)]
    public string? PayeePricingTierId { get; set; }

    /// <summary>
    /// The funds that are held on behalf of the merchant.
    /// </summary>
    [DataMember(Name = "disbursement_mode", EmitDefaultValue = false)]
    public EDisbursementMode? DisbursementMode { get; set; }
}
