using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The JSON patch object to apply partial updates to resources.
/// </summary>
public abstract class Patch<T>
{
    /// <summary>
    /// The <a href="https://tools.ietf.org/html/rfc6901">JSON Pointer</a> to the target document location from which to move the value. Required for the <code>move</code> operation.
    /// </summary>
    [JsonPropertyName("from")]
    public string From { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// The operation.
    /// </summary>
    [JsonPropertyName("op")]
    public string Op { get; set; } = null!;

    /// <summary>
    /// The <a href="https://tools.ietf.org/html/rfc6901">JSON Pointer</a> to the target document location at which to complete the operation.
    /// </summary>
    [JsonPropertyName("path")]
    public string Path { get; set; } = null!;

    /// <summary>
    /// The value to apply. The <code>remove</code> operation does not require a value.
    /// </summary>
    [JsonPropertyName("value")]
    public T Value { get; set; } = default!;
}
