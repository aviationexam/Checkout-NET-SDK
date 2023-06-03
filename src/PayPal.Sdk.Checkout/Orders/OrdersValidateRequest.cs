using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using PayPal.Sdk.Checkout.RequestInterfaces;
using System;
using System.IO;
using System.Net.Http;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// Validates a payment method and checks it for contingencies.
/// </summary>
public class OrdersValidateRequest : PayPalHttpRequest
    .WithJsonRequest<OrderActionRequest>
    .WithJsonResponse<Order>, IConfigurePayPalMetadataId
{
    public OrdersValidateRequest(string orderId) : base(
        "/v2/checkout/orders/{order_id}/validate-payment-method", HttpMethod.Post,
        PayPalOrderJsonSerializerContext.Default.Order,
        PayPalOrderJsonSerializerContext.Default.OrderActionRequest
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
