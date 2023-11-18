using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System;
using System.IO;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// Shows details for an authorized payment, by ID.
/// </summary>
public class AuthorizationsGetRequest : PayPalHttpRequest
    .WithGetRequest
    .WithJsonResponse<PaymentAuthorization>
{
    public AuthorizationsGetRequest(string authorizationId) : base(
        "/v2/payments/authorizations/{authorization_id}",
        PayPalJsonSerializerContext.Default.PaymentAuthorization
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
