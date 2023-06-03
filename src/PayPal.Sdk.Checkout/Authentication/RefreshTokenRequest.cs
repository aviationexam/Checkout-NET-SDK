using PayPal.Sdk.Checkout.Configuration;
using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PayPal.Sdk.Checkout.Authentication;

public class RefreshTokenRequest : PayPalHttpRequest
    .WithFormRequest
    .WithJsonResponse<RefreshToken>
{
    public RefreshTokenRequest(
        PayPalOptions options, string code
    ) : base(
        "/v1/identity/openidconnect/tokenservice", HttpMethod.Post,
        PayPalAuthenticationJsonSerializerContext.CustomConverters.RefreshToken
    )
    {
        Authorization = new AuthenticationHeaderValue("Basic", options.AuthorizationString());
        ContentType = FormEncodedSerializer.ApplicationXForm;

        var body = new Dictionary<string, string>
        {
            ["grant_type"] = "authorization_code",
            ["code"] = code,
        };

        SetRequestBody(body);
    }
}
