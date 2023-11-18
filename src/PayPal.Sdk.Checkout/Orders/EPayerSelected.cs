using Aviationexam.GeneratedJsonConverters.Attributes;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

[EnumJsonConverter]
public enum EPayerSelected : byte
{
    [EnumMember(Value = "PAYPAL")]
    PayPal,
}
