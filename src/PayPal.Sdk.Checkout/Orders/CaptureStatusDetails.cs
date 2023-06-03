using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The details of the captured payment status.
/// </summary>
[DataContract]
public class CaptureStatusDetails
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public CaptureStatusDetails()
    {
    }

    /// <summary>
    /// The reason why the captured payment status is `PENDING` or `DENIED`.
    /// </summary>
    [DataMember(Name = "reason", EmitDefaultValue = false)]
    public string Reason { get; set; } = null!;
}
