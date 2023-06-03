using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The options that the payee or merchant offers to the payer to ship or pick up their items.
/// </summary>
public class ShippingOption
{
    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("amount")]
    public Money Amount { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// A unique ID that identifies a payer-selected shipping option.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// A description that the payer sees, which helps them choose an appropriate shipping option. For example, `Free Shipping`, `USPS Priority Shipping`, `Expédition prioritaire USPS`, or `USPS yōuxiān fā huò`. Localize this description to the payer's locale.
    /// </summary>
    [JsonPropertyName("label")]
    public string Label { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// If the API request sets `selected = true`, it represents the shipping option that the payee or merchant expects to be pre-selected for the payer when they first view the `shipping.options` in the PayPal Checkout experience. As part of the response if a `shipping.option` contains `selected=true`, it represents the shipping option that the payer selected during the course of checkout with PayPal. Only one `shipping.option` can be set to `selected=true`.
    /// </summary>
    [JsonPropertyName("selected")]
    public bool? Selected { get; set; } = null!;

    /// <summary>
    /// The method by which the payer wants to get their items.
    /// </summary>
    [JsonPropertyName("type")]
    public string ShippingType { get; set; } = null!;
}
