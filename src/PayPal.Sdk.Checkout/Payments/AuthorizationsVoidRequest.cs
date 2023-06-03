using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System;
using System.IO;
using System.Net.Http;

namespace PayPal.Sdk.Checkout.Payments;

/// <summary>
/// Voids, or cancels, an authorized payment, by ID. You cannot void an authorized payment that has been fully captured.
/// </summary>
public class AuthorizationsVoidRequest : BaseHttpRequest
{
    public AuthorizationsVoidRequest(string authorizationId) : base("/v2/payments/authorizations/{authorization_id}/void", HttpMethod.Post)
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
