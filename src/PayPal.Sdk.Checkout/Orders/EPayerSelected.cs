using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders
{
    [DataContract]
    public enum EPayerSelected : byte
    {
        [EnumMember(Value = "PAYPAL")]
        PayPal,
    }
}
