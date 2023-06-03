using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System;
using System.IO;
using System.Net.Http;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// Shows details for a refund, by ID.
/// </summary>
public class RefundsGetRequest : BaseHttpRequest<Refund>
{
    public RefundsGetRequest(string refundId) : base("/v2/payments/refunds/{refund_id}", HttpMethod.Get)
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