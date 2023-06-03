using PayPal.Sdk.Checkout.Core.HttpRequests;
using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json.Serialization.Metadata;

namespace PayPal.Sdk.Checkout.Orders;

/// <inheritdoc />
public class OrdersStringPatchRequest : OrdersPatchRequest<string, StringPatch>
{
    public OrdersStringPatchRequest(
        string orderId
    ) : base(orderId, PayPalOrderJsonSerializerContext.Default.IReadOnlyCollectionStringPatch)
    {
    }
}

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
public abstract class OrdersPatchRequest<T, TPathType> : PayPalHttpRequest
    .WithJsonRequest<IReadOnlyCollection<TPathType>>
    .WithoutResponse
    where TPathType : Patch<T>
{
    protected OrdersPatchRequest(
        string orderId,
        JsonTypeInfo<IReadOnlyCollection<TPathType>> jsonTypeInfoForRequestBody
    ) : base(
        "/v2/checkout/orders/{order_id}", HttpMethod.Patch,
        jsonTypeInfoForRequestBody
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
