using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The name of the party.
/// </summary>
public class Name
{
    /// <summary>
    /// DEPRECATED. The party's alternate name. Can be a business name, nickname, or any other name that cannot be split into first, last name. Required when the party is a business.
    /// </summary>
    [JsonPropertyName("alternate_full_name")]
    public string AlternateFullName { get; set; } = null!;

    /// <summary>
    /// When the party is a person, the party's full name.
    /// </summary>
    [JsonPropertyName("full_name")]
    public string FullName { get; set; } = null!;

    /// <summary>
    /// When the party is a person, the party's given, or first, name.
    /// </summary>
    [JsonPropertyName("given_name")]
    public string GivenName { get; set; } = null!;

    /// <summary>
    /// When the party is a person, the party's middle name. Use also to store multiple middle names including the patronymic, or father's, middle name.
    /// </summary>
    [JsonPropertyName("middle_name")]
    public string MiddleName { get; set; } = null!;

    /// <summary>
    /// The prefix, or title, to the party's name.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; } = null!;

    /// <summary>
    /// The suffix for the party's name.
    /// </summary>
    [JsonPropertyName("suffix")]
    public string Suffix { get; set; } = null!;

    /// <summary>
    /// When the party is a person, the party's surname or family name. Also known as the last name. Required when the party is a person. Use also to store multiple surnames including the matronymic, or mother's, surname.
    /// </summary>
    [JsonPropertyName("surname")]
    public string Surname { get; set; } = null!;
}
