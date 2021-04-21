using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// Updates an order that has the `CREATED` or `APPROVED` status. You cannot update an order with `COMPLETED` status.
    /// You can patch these attributes and objects:
    /// <table><thead><tr><th align="left">Attribute or object</th><th align="left">Operations</th></tr></thead>
    /// <tbody><tr><td><code>intent</code></td><td align="left">Replace</td></tr>
    /// <tr><td><code>purchase_units</code></td><td align="left">Replace, add</td></tr>
    /// <tr><td><code>purchase_units[].custom_id</code></td><td align="left">Replace, add, remove</td></tr>
    /// <tr><td><code>purchase_units[].description</code></td><td align="left">Replace, add, remove</td></tr>
    /// <tr><td><code>purchase_units[].payee.email</code></td><td align="left">Replace, add</td></tr>
    /// <tr><td><code>purchase_units[].shipping</code></td><td align="left">Replace, add, remove</td></tr>
    /// <tr><td><code>purchase_units[].soft_descriptor</code></td><td align="left">Replace, add, remove</td></tr>
    /// <tr><td><code>purchase_units[].amount</code></td><td align="left">Replace</td></tr><tr><td><code>purchase_units[].invoice_id</code></td><td align="left">Replace, add, remove</td></tr></tbody></table>
    /// </summary>
    public class OrdersPatchRequest<T> : BaseVoidHttpRequest<ICollection<Patch<T>>>
    {
        public OrdersPatchRequest(string orderId) : base("/v2/checkout/orders/{order_id}?", HttpMethod.Patch)
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
