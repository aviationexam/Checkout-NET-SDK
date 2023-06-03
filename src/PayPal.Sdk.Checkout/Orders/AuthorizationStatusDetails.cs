using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The details of the authorized payment status.
/// </summary>
[DataContract]
public class AuthorizationStatusDetails
{
    /// <summary>
    /// Required default constructor
    /// </summary>
    public AuthorizationStatusDetails()
    {
    }

    /// <summary>
    /// The reason why the authorized status is `PENDING`.
    /// </summary>
    [DataMember(Name = "reason", EmitDefaultValue = false)]
    public string Reason { get; set; } = null!;
}
