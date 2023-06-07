using PayPal.Sdk.Checkout.Core.Converters;
using PayPal.Sdk.Checkout.Orders;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

[JsonSourceGenerationOptions(
    WriteIndented = true,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    GenerationMode = JsonSourceGenerationMode.Metadata
)]
[JsonSerializable(typeof(AuthorizeRequest))]
[JsonSerializable(typeof(IReadOnlyCollection<StringPatch>))]
[JsonSerializable(typeof(Order))]
[JsonSerializable(typeof(OrderActionRequest))]
[JsonSerializable(typeof(OrderCaptureRequest))]
[JsonSerializable(typeof(OrderRequest))]
internal partial class PayPalOrderJsonSerializerContext : JsonSerializerContext
{
    private static PayPalOrderJsonSerializerContext? _convertersContext;

    /// <summary>
    /// The default <see cref="global::System.Text.Json.Serialization.JsonSerializerContext"/> associated with a default <see cref="global::System.Text.Json.JsonSerializerOptions"/> instance.
    /// </summary>
    public static PayPalOrderJsonSerializerContext CustomConverters => _convertersContext
        ??= new PayPalOrderJsonSerializerContext(
            new JsonSerializerOptions(JsonSerializerOptionsForJsonSerializerContext.ConvertersContextOptions)
        );
}
