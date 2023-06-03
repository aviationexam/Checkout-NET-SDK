using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using PayPal.Sdk.Checkout.RequestInterfaces;
using System;
using System.IO;
using System.Net.Http;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// Captures an authorized payment, by ID.
/// </summary>
public class AuthorizationsCaptureRequest : PayPalHttpRequest
    .WithJsonRequest<CaptureRequest>
    .WithJsonResponse<Capture>,
    IConfigurePrefer, IConfigurePayPalRequestId
{
    public AuthorizationsCaptureRequest(string authorizationId) : base(
        "/v2/payments/authorizations/{authorization_id}/capture", HttpMethod.Post,
        PayPalPaymentsJsonSerializerContext.CustomConverters.Capture,
        PayPalPaymentsJsonSerializerContext.CustomConverters.CaptureRequest
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
