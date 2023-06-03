using System.Text.Json;

namespace PayPal.Sdk.Checkout.Samples;

public static class ObjectExtensions
{
    public static string AsJson<TObject>(
        this TObject sourceObject
    ) => JsonSerializer.Serialize(
        sourceObject
    );
}
