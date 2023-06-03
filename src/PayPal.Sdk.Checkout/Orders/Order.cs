using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The order details.
/// </summary>
[DataContract]
public class Order
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public Order()
    {
    }

    /// <summary>
    /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
    /// </summary>
    [DataMember(Name = "intent", EmitDefaultValue = true)]
    public EOrderIntent CheckoutPaymentIntent { get; set; }

    /// <summary>
    /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
    /// </summary>
    [DataMember(Name = "create_time", EmitDefaultValue = false)]
    public string CreateTime { get; set; } = null!;

    /// <summary>
    /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
    /// </summary>
    [DataMember(Name = "expiration_time", EmitDefaultValue = false)]
    public string ExpirationTime { get; set; } = null!;

    /// <summary>
    /// The ID of the order.
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// An array of request-related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links). To complete payer approval, use the `approve` link with the `GET` method.
    /// </summary>
    [DataMember(Name = "links", EmitDefaultValue = false)]
    public ICollection<LinkDescription> Links { get; set; } = null!;

    /// <summary>
    /// The customer who approves and pays for the order. The customer is also known as the payer.
    /// </summary>
    [DataMember(Name = "payer", EmitDefaultValue = false)]
    public Payer Payer { get; set; } = null!;

    /// <summary>
    /// An array of purchase units. Each purchase unit establishes a contract between a customer and merchant. Each purchase unit represents either a full or partial order that the customer intends to purchase from the merchant.
    /// </summary>
    [DataMember(Name = "purchase_units", EmitDefaultValue = false)]
    public ICollection<PurchaseUnit> PurchaseUnits { get; set; } = null!;

    /// <summary>
    /// The order status.
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = true)]
    public EOrderStatus Status { get; set; }

    /// <summary>
    /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
    /// </summary>
    [DataMember(Name = "update_time", EmitDefaultValue = false)]
    public string UpdateTime { get; set; } = null!;
}
