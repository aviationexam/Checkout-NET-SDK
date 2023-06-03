using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The details for the items to be purchased.
/// </summary>
[DataContract]
public class Item
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public Item()
    {
    }

    /// <summary>
    /// The item category type.
    /// </summary>
    [DataMember(Name = "category", EmitDefaultValue = false)]
    public EItemCategory? Category { get; set; }

    /// <summary>
    /// REQUIRED
    /// The item name or title.
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// The detailed item description.
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string? Description { get; set; }

    /// <summary>
    /// REQUIRED
    /// The item quantity. Must be a whole number.
    /// </summary>
    [DataMember(Name = "quantity", EmitDefaultValue = false)]
    public string Quantity { get; set; } = null!;

    /// <summary>
    /// The stock keeping unit (SKU) for the item.
    /// </summary>
    [DataMember(Name = "sku", EmitDefaultValue = false)]
    public string? Sku { get; set; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [DataMember(Name = "tax", EmitDefaultValue = false)]
    public Money? Tax { get; set; }

    /// <summary>
    /// REQUIRED
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [DataMember(Name = "unit_amount", EmitDefaultValue = false)]
    public Money UnitAmount { get; set; } = null!;
}
