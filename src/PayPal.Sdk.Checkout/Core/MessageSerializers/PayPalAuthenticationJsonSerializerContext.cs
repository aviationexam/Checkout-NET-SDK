using PayPal.Sdk.Checkout.Authentication;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    GenerationMode = JsonSourceGenerationMode.Serialization
)]
[JsonSerializable(typeof(AccessToken))]
[JsonSerializable(typeof(RefreshToken))]
internal partial class PayPalAuthenticationJsonSerializerContext : JsonSerializerContext
{
}
