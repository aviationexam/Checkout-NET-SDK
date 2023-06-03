using PayPal.Sdk.Checkout.Core.Converters;
using PayPal.Sdk.Checkout.Payments;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

[JsonSourceGenerationOptions(
    WriteIndented = true,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    GenerationMode = JsonSourceGenerationMode.Serialization
)]
[JsonSerializable(typeof(Authorization))]
[JsonSerializable(typeof(Capture))]
[JsonSerializable(typeof(CaptureRequest))]
[JsonSerializable(typeof(ReauthorizeRequest))]
[JsonSerializable(typeof(Refund))]
[JsonSerializable(typeof(RefundRequest))]
internal partial class PayPalPaymentsJsonSerializerContext : JsonSerializerContext
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

    private static PayPalPaymentsJsonSerializerContext? _convertersContext;

    /// <summary>
    /// The default <see cref="global::System.Text.Json.Serialization.JsonSerializerContext"/> associated with a default <see cref="global::System.Text.Json.JsonSerializerOptions"/> instance.
    /// </summary>
    public static PayPalPaymentsJsonSerializerContext CustomConverters => _convertersContext
        ??= new PayPalPaymentsJsonSerializerContext(
            new JsonSerializerOptions(ConvertersContextOptions)
        );
}
