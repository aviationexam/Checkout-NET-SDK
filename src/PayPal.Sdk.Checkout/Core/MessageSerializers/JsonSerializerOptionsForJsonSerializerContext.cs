using PayPal.Sdk.Checkout.Core.Converters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Core.MessageSerializers;

public static class JsonSerializerOptionsForJsonSerializerContext
{
    public static JsonSerializerOptions ConvertersContextOptions { get; } = new()
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
        },
    };
}
