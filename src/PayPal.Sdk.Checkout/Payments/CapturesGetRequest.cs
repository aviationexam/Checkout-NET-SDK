using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System;
using System.IO;
using System.Net.Http;

namespace PayPal.Sdk.Checkout.Payments
{
    /// <summary>
    /// Shows details for a captured payment, by ID.
    /// </summary>
    public class CapturesGetRequest : BaseHttpRequest<Capture>
    {
        public CapturesGetRequest(string captureId) : base("/v2/payments/captures/{capture_id}", HttpMethod.Get)
        {
            try
            {
                Path = Path.Replace("{capture_id}", Uri.EscapeDataString(Convert.ToString(captureId)));
            }
            catch (IOException)
            {
            }

            ContentType = JsonSerializer.ApplicationJson;
        }
    }
}
