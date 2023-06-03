using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The details for the items to be purchased.
/// </summary>
public class Item
{
    /// <summary>
    /// The item category type.
    /// </summary>
    [JsonPropertyName("category")]
    public EItemCategory? Category { get; set; }

    /// <summary>
    /// REQUIRED
    /// The item name or title.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// The detailed item description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// REQUIRED
    /// The item quantity. Must be a whole number.
    /// </summary>
    [JsonPropertyName("quantity")]
    public string Quantity { get; set; } = null!;

    /// <summary>
    /// The stock keeping unit (SKU) for the item.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("tax")]
    public Money? Tax { get; set; }

    /// <summary>
    /// REQUIRED
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("unit_amount")]
    public Money UnitAmount { get; set; } = null!;
}
