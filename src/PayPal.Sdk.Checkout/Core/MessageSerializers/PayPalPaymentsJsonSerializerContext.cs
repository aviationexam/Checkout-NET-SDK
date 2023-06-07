using PayPal.Sdk.Checkout.Payments;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

[JsonSourceGenerationOptions(
    WriteIndented = true,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    GenerationMode = JsonSourceGenerationMode.Metadata
)]
[JsonSerializable(typeof(Authorization))]
[JsonSerializable(typeof(Capture))]
[JsonSerializable(typeof(CaptureRequest))]
[JsonSerializable(typeof(ReauthorizeRequest))]
[JsonSerializable(typeof(Refund))]
[JsonSerializable(typeof(RefundRequest))]
internal partial class PayPalPaymentsJsonSerializerContext : JsonSerializerContext
{
    private static PayPalPaymentsJsonSerializerContext? _convertersContext;

    /// <summary>
    /// The default <see cref="global::System.Text.Json.Serialization.JsonSerializerContext"/> associated with a default <see cref="global::System.Text.Json.JsonSerializerOptions"/> instance.
    /// </summary>
    public static PayPalPaymentsJsonSerializerContext CustomConverters => _convertersContext
        ??= new PayPalPaymentsJsonSerializerContext(
            new JsonSerializerOptions(JsonSerializerOptionsForJsonSerializerContext.ConvertersContextOptions)
        );
}
