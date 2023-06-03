using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System;
using System.IO;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// Shows details for a captured payment, by ID.
/// </summary>
public class CapturesGetRequest : PayPalHttpRequest
    .WithGetRequest
    .WithJsonResponse<Capture>
{
    public CapturesGetRequest(string captureId) : base(
        "/v2/payments/captures/{capture_id}",
        PayPalPaymentsJsonSerializerContext.Default.Capture
        )
    {
        try
        {
            Path = Path.Replace("{capture_id}", Uri.EscapeDataString(Convert.ToString(captureId)));
        }
        catch (IOException)
        {
        }

        ContentType = JsonMessageSerializer.ApplicationJson;
    }
}
