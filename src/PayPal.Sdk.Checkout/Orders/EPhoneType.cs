using Aviationexam.GeneratedJsonConverters.Attributes;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

[EnumJsonConverter]
public enum EPhoneType : byte
{
    [EnumMember(Value = "FAX")]
    Fax,

    [EnumMember(Value = "HOME")]
    Home,

    [EnumMember(Value = "MOBILE")]
    Mobile,

    [EnumMember(Value = "OTHER")]
    Other,

    [EnumMember(Value = "PAGER")]
    Pager,
}
