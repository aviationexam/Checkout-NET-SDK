using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// Customizes the payer experience during the approval process for the payment with PayPal.<blockquote><strong>Note:</strong> Partners and Marketplaces might configure <code>brand_name</code> and <code>shipping_preference</code> during partner account setup, which overrides the request values.</blockquote>
/// </summary>
public class ApplicationContext
{
    /// <summary>
    /// The label that overrides the business name in the PayPal account on the PayPal site.
    /// </summary>
    [JsonPropertyName("brand_name")]
    public string? BrandName { get; set; }

    /// <summary>
    /// The URL where the customer is redirected after the customer approves the payment.
    /// </summary>
    [JsonPropertyName("return_url")]
    public string? ReturnUrl { get; set; }

    /// <summary>
    /// The URL where the customer is redirected after the customer cancels the payment.
    /// </summary>
    [JsonPropertyName("cancel_url")]
    public string? CancelUrl { get; set; }

    /// <summary>
    /// The type of landing page to show on the PayPal site for customer checkout.
    /// </summary>
    [JsonPropertyName("landing_page")]
    public ELandingPage? LandingPage { get; set; }

    /// <summary>
    /// The [language tag](https://tools.ietf.org/html/bcp47#section-2) for the language in which to localize the error-related strings,
    /// such as messages, issues, and suggested actions.
    /// The tag is made up of the [ISO 639-2 language code](https://www.loc.gov/standards/iso639-2/php/code_list.php),
    /// the optional [ISO-15924 script tag](https://www.unicode.org/iso15924/codelists.html),
    /// and the [ISO-3166 alpha-2 country code](/docs/integration/direct/rest/country-codes/).
    /// </summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>
    /// The customer and merchant payment preferences.
    /// </summary>
    [JsonPropertyName("payment_method")]
    public PaymentMethod? PaymentMethod { get; set; }

    /// <summary>
    /// The shipping preference:<ul><li>Displays the shipping address to the customer.</li><li>Enables the customer to choose an address on the PayPal site.</li><li>Restricts the customer from changing the address during the payment-approval process.</li></ul>
    /// </summary>
    [JsonPropertyName("shipping_preference")]
    public EShippingPreference? ShippingPreference { get; set; }

    /// <summary>
    /// Configures a <strong>Continue</strong> or <strong>Pay Now</strong> checkout flow.
    /// </summary>
    [JsonPropertyName("user_action")]
    public EUserAction? UserAction { get; set; }
}
