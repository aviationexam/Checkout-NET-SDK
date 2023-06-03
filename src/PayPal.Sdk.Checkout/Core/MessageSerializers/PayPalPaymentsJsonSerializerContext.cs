using PayPal.Sdk.Checkout.Payments;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

[JsonSourceGenerationOptions(
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
}
