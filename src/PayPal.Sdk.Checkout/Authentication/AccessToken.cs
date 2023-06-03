using System;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Authentication;

public class AccessToken
{
    [JsonPropertyName("access_token")]
    public string Token { get; set; } = null!;

    [JsonPropertyName("token_type")]
    public string TokenType { get; set; } = null!;

    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }

    private DateTime ReceivedDate { get; }

    [JsonConstructor]
    public AccessToken(
        string token, string tokenType, int expiresIn
    ) : this()
    {
        Token = token;
        TokenType = tokenType;
        ExpiresIn = expiresIn;
    }

    public AccessToken(DateTime? receivedDate = null)
    {
        ReceivedDate = receivedDate ?? DateTime.Now;
    }

    public bool IsExpired(DateTime? now = null)
    {
        var expireDate = ReceivedDate.Add(TimeSpan.FromSeconds(ExpiresIn));

        now ??= DateTime.Now;

        return now.Value.CompareTo(expireDate) > 0;
    }
}
