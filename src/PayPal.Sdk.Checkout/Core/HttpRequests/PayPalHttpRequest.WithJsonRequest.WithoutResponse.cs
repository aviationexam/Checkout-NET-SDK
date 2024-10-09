using PayPal.Sdk.Checkout.RequestInterfaces;
using System.Net.Http;
using System.Text.Json.Serialization.Metadata;

namespace PayPal.Sdk.Checkout.Core.HttpRequests;

public static partial class PayPalHttpRequest
{
    public static partial class WithJsonRequest<TRequestBody>
        where TRequestBody : notnull
    {
        public abstract class WithoutResponse(
            string path,
            HttpMethod method,
            JsonTypeInfo<TRequestBody> jsonTypeInfoForRequestBody
        ) : BaseVoidHttpRequest<TRequestBody>(path, method),
            IPayPalRequestWithJsonRequestBody<TRequestBody>
        {
            public JsonTypeInfo<TRequestBody> JsonTypeInfoForRequestBody { get; } = jsonTypeInfoForRequestBody;
        }
    }
}
