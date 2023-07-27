using PayPal.Sdk.Checkout.Authentication;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

[JsonSourceGenerationOptions(
    WriteIndented = true,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    GenerationMode = JsonSourceGenerationMode.Default
)]
[JsonSerializable(typeof(AccessToken))]
[JsonSerializable(typeof(RefreshToken))]
internal partial class PayPalAuthenticationJsonSerializerContext : JsonSerializerContext
{
    private static PayPalAuthenticationJsonSerializerContext? _convertersContext;

    /// <summary>
    /// The default <see cref="global::System.Text.Json.Serialization.JsonSerializerContext"/> associated with a default <see cref="global::System.Text.Json.JsonSerializerOptions"/> instance.
    /// </summary>
    public static PayPalAuthenticationJsonSerializerContext CustomConverters => _convertersContext
        ??= new PayPalAuthenticationJsonSerializerContext(
            new JsonSerializerOptions(JsonSerializerOptionsForJsonSerializerContext.ConvertersContextOptions)
        );
}
