using Aviationexam.GeneratedJsonConverters.Attributes;

namespace PayPal.Sdk.Checkout.Configuration;

[EnumJsonConverter]
public enum EPayPalEnvironment : byte
{
    Sandbox = 0,
    Live = 1,
}
