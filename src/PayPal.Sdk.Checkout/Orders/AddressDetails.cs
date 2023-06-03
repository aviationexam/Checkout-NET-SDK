using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The non-portable additional address details that are sometimes needed for compliance, risk, or other scenarios where fine-grain address information might be needed. Not portable with common third party and open source. Redundant with core fields.<br/>For example, `address_portable.address_line_1` is usually a combination of `address_details.street_number`, `street_name`, and `street_type`.
/// </summary>
public class AddressDetails
{
    /// <summary>
    /// A named locations that represents the premise. Usually a building name or number or collection of buildings with a common name or number. For example, <code>Craven House</code>.
    /// </summary>
    [JsonPropertyName("building_name")]
    public string BuildingName { get; set; } = null!;

    /// <summary>
    /// The delivery service. Post office box, bag number, or post office name.
    /// </summary>
    [JsonPropertyName("delivery_service")]
    public string DeliveryService { get; set; } = null!;

    /// <summary>
    /// The street name. Just `Drury` in `Drury Lane`.
    /// </summary>
    [JsonPropertyName("street_name")]
    public string StreetName { get; set; } = null!;

    /// <summary>
    /// The street number.
    /// </summary>
    [JsonPropertyName("street_number")]
    public string StreetNumber { get; set; } = null!;

    /// <summary>
    /// The street type. For example, avenue, boulevard, road, or expressway.
    /// </summary>
    [JsonPropertyName("street_type")]
    public string StreetType { get; set; } = null!;

    /// <summary>
    /// The first-order entity below a named building or location that represents the sub-premise. Usually a single building within a collection of buildings with a common name. Can be a flat, story, floor, room, or apartment.
    /// </summary>
    [JsonPropertyName("sub_building")]
    public string SubBuilding { get; set; } = null!;
}
