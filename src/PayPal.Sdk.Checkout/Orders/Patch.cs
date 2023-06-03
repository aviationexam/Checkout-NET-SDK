using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The JSON patch object to apply partial updates to resources.
/// </summary>
[DataContract]
public class Patch<T>
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public Patch()
    {
    }

    /// <summary>
    /// The <a href="https://tools.ietf.org/html/rfc6901">JSON Pointer</a> to the target document location from which to move the value. Required for the <code>move</code> operation.
    /// </summary>
    [DataMember(Name = "from", EmitDefaultValue = false)]
    public string From { get; set; } = null!;

    /// <summary>
    /// REQUIRED
    /// The operation.
    /// </summary>
    [DataMember(Name = "op", EmitDefaultValue = false)]
    public string Op { get; set; } = null!;

    /// <summary>
    /// The <a href="https://tools.ietf.org/html/rfc6901">JSON Pointer</a> to the target document location at which to complete the operation.
    /// </summary>
    [DataMember(Name = "path", EmitDefaultValue = false)]
    public string Path { get; set; } = null!;

    /// <summary>
    /// The value to apply. The <code>remove</code> operation does not require a value.
    /// </summary>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public T Value { get; set; } = default!;
}
