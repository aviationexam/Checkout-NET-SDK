using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System;
using System.IO;
using System.Net.Http;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// Shows details for an order, by ID.
    /// </summary>
    public class OrdersGetRequest : BaseHttpRequest<Order>
    {
        public OrdersGetRequest(string orderId) : base("/v2/checkout/orders/{order_id}", HttpMethod.Get)
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
}
