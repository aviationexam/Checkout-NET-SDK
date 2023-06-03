using PayPal.Sdk.Checkout.Orders;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    GenerationMode = JsonSourceGenerationMode.Serialization
)]
[JsonSerializable(typeof(AuthorizeRequest))]
[JsonSerializable(typeof(IReadOnlyCollection<StringPatch>))]
[JsonSerializable(typeof(Order))]
[JsonSerializable(typeof(OrderActionRequest))]
[JsonSerializable(typeof(OrderCaptureRequest))]
[JsonSerializable(typeof(OrderRequest))]
[JsonSerializable(typeof(OrdersValidateRequest))]
internal partial class PayPalOrderJsonSerializerContext : JsonSerializerContext
{
}
