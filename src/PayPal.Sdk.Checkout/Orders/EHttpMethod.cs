using Aviationexam.GeneratedJsonConverters.Attributes;
using System.Runtime.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

[EnumJsonConverter]
public enum EHttpMethod : byte
{
    [EnumMember(Value = "GET")]
    Get,

    [EnumMember(Value = "POST")]
    Post,

    [EnumMember(Value = "PUT")]
    Put,

    [EnumMember(Value = "DELETE")]
    Delete,

    [EnumMember(Value = "HEAD")]
    Head,

    [EnumMember(Value = "CONNECT")]
    Connect,

    [EnumMember(Value = "OPTIONS")]
    Options,

    [EnumMember(Value = "PATCH")]
    Patch,
}
