using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using PayPal.Sdk.Checkout.RequestInterfaces;
using System.Net.Http;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// Creates an order. Supports only orders with one purchase unit.
/// </summary>
public class OrdersCreateRequest : PayPalHttpRequest
    .WithJsonRequest<OrderRequest>
    .WithJsonResponse<Order>,
    IConfigurePrefer, IConfigurePayPalPartnerAttributionId
{
    public OrdersCreateRequest() : base(
        "/v2/checkout/orders", HttpMethod.Post,
        PayPalJsonSerializerContext.Default.Order,
        PayPalJsonSerializerContext.Default.OrderRequest
    )
    {
        ContentType = JsonMessageSerializer.ApplicationJson;
    }
}
