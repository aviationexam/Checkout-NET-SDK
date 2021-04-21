using PayPal.Sdk.Checkout.Core.MessageSerializers;
using PayPal.Sdk.Checkout.RequestInterfaces;
using System;
using System.IO;
using System.Net.Http;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// Captures payment for an order. To successfully capture payment for an order,
    /// the buyer must first approve the order or a valid payment_source must be provided in the request.
    /// A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response.
    /// </summary>
    public class OrdersCaptureRequest : BaseHttpRequest<Order, OrderActionRequest>, IConfigurePrefer, IConfigurePayPalRequestId, IConfigurePayPalMetadataId
    {
        public OrdersCaptureRequest(string orderId) : base("/v2/checkout/orders/{order_id}/capture?", HttpMethod.Post)
        {
            try
            {
                Path = Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(orderId)));
            }
            catch (IOException)
            {
            }

            ContentType = JsonSerializer.ApplicationJson;
        }
    }
}
