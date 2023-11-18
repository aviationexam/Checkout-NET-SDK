using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System;
using System.IO;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// Shows details for a refund, by ID.
/// </summary>
public class RefundsGetRequest : PayPalHttpRequest
    .WithGetRequest
    .WithJsonResponse<PaymentRefund>
{
    public RefundsGetRequest(string refundId) : base(
        "/v2/payments/refunds/{refund_id}",
        PayPalJsonSerializerContext.Default.PaymentRefund
    )
    {
        try
        {
            Path = Path.Replace("{refund_id}", Uri.EscapeDataString(Convert.ToString(refundId)));
        }
        catch (IOException)
        {
        }

        ContentType = JsonMessageSerializer.ApplicationJson;
    }
}
