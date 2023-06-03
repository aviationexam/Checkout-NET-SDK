using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Authentication;

public class RefreshToken
{
    [JsonPropertyName("refresh_token")]
    public string Token { get; set; } = null!;

    [JsonPropertyName("token_type")]
    public string TokenType { get; set; } = null!;

    [JsonPropertyName("expires_in")]
    public string ExpiresIn { get; set; } = null!;

    [JsonPropertyName("id_token")]
    public string IdToken { get; set; } = null!;
}
