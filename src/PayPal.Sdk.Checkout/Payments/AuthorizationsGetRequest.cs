using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System;
using System.IO;
using System.Net.Http;

namespace PayPal.Sdk.Checkout.Payments
{
    /// <summary>
    /// Shows details for an authorized payment, by ID.
    /// </summary>
    public class AuthorizationsGetRequest : BaseHttpRequest<Authorization>
    {
        public AuthorizationsGetRequest(string authorizationId) : base("/v2/payments/authorizations/{authorization_id}", HttpMethod.Get)
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
}
