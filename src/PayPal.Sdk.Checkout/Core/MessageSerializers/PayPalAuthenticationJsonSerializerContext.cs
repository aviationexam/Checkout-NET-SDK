using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.Core.Converters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

[JsonSourceGenerationOptions(
    WriteIndented = true,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    GenerationMode = JsonSourceGenerationMode.Serialization
)]
[JsonSerializable(typeof(AccessToken))]
[JsonSerializable(typeof(RefreshToken))]
internal partial class PayPalAuthenticationJsonSerializerContext : JsonSerializerContext
{
    private static JsonSerializerOptions ConvertersContextOptions { get; } = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.Never,
        IgnoreReadOnlyFields = false,
        IgnoreReadOnlyProperties = false,
        IncludeFields = false,
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Converters =
        {
            new JsonStringEnumConverterFactory(),
        }
    };

    private static PayPalAuthenticationJsonSerializerContext? _convertersContext;

    /// <summary>
    /// The default <see cref="global::System.Text.Json.Serialization.JsonSerializerContext"/> associated with a default <see cref="global::System.Text.Json.JsonSerializerOptions"/> instance.
    /// </summary>
    public static PayPalAuthenticationJsonSerializerContext CustomConverters => _convertersContext
        ??= new PayPalAuthenticationJsonSerializerContext(
            new JsonSerializerOptions(ConvertersContextOptions)
        );
}
