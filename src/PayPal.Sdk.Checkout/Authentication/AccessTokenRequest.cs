using PayPal.Sdk.Checkout.Configuration;
using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PayPal.Sdk.Checkout.Authentication;

public class AccessTokenRequest : PayPalHttpRequest
    .WithFormRequest
    .WithJsonResponse<AccessToken>
{
    public AccessTokenRequest(
        PayPalOptions options,
        string? refreshToken = null
    ) : base(
        "/v1/oauth2/token", HttpMethod.Post,
        PayPalJsonSerializerContext.Default.AccessToken
    )
    {
        Authorization = new AuthenticationHeaderValue("Basic", options.AuthorizationString());
        ContentType = FormEncodedSerializer.ApplicationXForm;

        var body = new Dictionary<string, string>
        {
            ["grant_type"] = "client_credentials",
        };

        if (refreshToken != null)
        {
            body["grant_type"] = "refresh_token";
            body["refresh_token"] = refreshToken;
        }

        SetRequestBody(body);
    }
}
