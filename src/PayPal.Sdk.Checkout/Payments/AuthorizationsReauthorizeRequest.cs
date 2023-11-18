using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using PayPal.Sdk.Checkout.RequestInterfaces;
using System;
using System.IO;
using System.Net.Http;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// Reauthorizes an authorized PayPal account payment, by ID. To ensure that funds are still available, reauthorize a payment after its initial three-day honor period expires. You can reauthorize a payment only once from days four to 29.<br/><br/>If 30 days have transpired since the date of the original authorization, you must create an authorized payment instead of reauthorizing the original authorized payment.<br/><br/>A reauthorized payment itself has a new honor period of three days.<br/><br/>You can reauthorize an authorized payment once for up to 115% of the original authorized amount, not to exceed an increase of $75 USD.<br/><br/>Supports only the `amount` request parameter.
/// </summary>
public class AuthorizationsReauthorizeRequest : PayPalHttpRequest
    .WithJsonRequest<ReauthorizeRequest>
    .WithJsonResponse<Authorization>,
    IConfigurePrefer, IConfigurePayPalRequestId
{
    public AuthorizationsReauthorizeRequest(string authorizationId) : base(
        "/v2/payments/authorizations/{authorization_id}/reauthorize", HttpMethod.Post,
        PayPalJsonSerializerContext.Default.PaymentAuthorization,
        PayPalJsonSerializerContext.Default.ReauthorizeRequest
    )
    {
        try
        {
            Path = Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(authorizationId)));
        }
        catch (IOException)
        {
        }

        ContentType = JsonMessageSerializer.ApplicationJson;
    }
}
