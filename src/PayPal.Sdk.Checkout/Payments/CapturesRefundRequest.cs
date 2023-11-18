using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using PayPal.Sdk.Checkout.RequestInterfaces;
using System;
using System.IO;
using System.Net.Http;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// Refunds a captured payment, by ID. For a full refund, include an empty payload in the JSON request body. For a partial refund, include an <code>amount</code> object in the JSON request body.
/// </summary>
public class CapturesRefundRequest : PayPalHttpRequest
    .WithJsonRequest<RefundRequest>
    .WithJsonResponse<Refund>,
    IConfigurePrefer, IConfigurePayPalRequestId
{
    public CapturesRefundRequest(string captureId) : base(
        "/v2/payments/captures/{capture_id}/refund", HttpMethod.Post,
        PayPalJsonSerializerContext.Default.PaymentRefund,
        PayPalJsonSerializerContext.Default.RefundRequest
    )
    {
        try
        {
            Path = Path.Replace("{capture_id}", Uri.EscapeDataString(captureId));
        }
        catch (IOException)
        {
        }

        ContentType = JsonMessageSerializer.ApplicationJson;
    }
}
