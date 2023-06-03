using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System;
using System.IO;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// Shows details for an order, by ID.
/// </summary>
public class OrdersGetRequest : PayPalHttpRequest
    .WithGetRequest
    .WithJsonResponse<Order>
{
    public OrdersGetRequest(string orderId) : base(
        "/v2/checkout/orders/{order_id}",
        PayPalOrderJsonSerializerContext.CustomConverters.Order
    )
    {
        try
        {
            Path = Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(orderId)));
        }
        catch (IOException)
        {
        }

        ContentType = JsonMessageSerializer.ApplicationJson;
    }
}
