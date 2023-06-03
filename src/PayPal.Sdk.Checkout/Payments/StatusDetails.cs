using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// The details of the captured payment status.
/// </summary>
[DataContract]
public class StatusDetails
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public StatusDetails()
    {
    }

    /// <summary>
    /// The reason why the captured payment status is `PENDING` or `DENIED`.
    /// </summary>
    [field: DataMember(Name = "reason", EmitDefaultValue = false)]
    public string Reason { get; set; } = null!;
}
