using PayPal.Sdk.Checkout.RequestInterfaces;
using System.Net.Http;
using System.Text.Json.Serialization.Metadata;

namespace PayPal.Sdk.Checkout.Core.HttpRequests;

public static partial class PayPalHttpRequest
{
    public static partial class WithJsonRequest<TRequestBody>
        where TRequestBody : notnull
    {
        public abstract class WithoutResponse :
            BaseVoidHttpRequest<TRequestBody>,
            IPayPalRequestWithJsonRequestBody<TRequestBody>
        {
            public JsonTypeInfo<TRequestBody> JsonTypeInfoForRequestBody { get; }

            protected WithoutResponse(
                string path, HttpMethod method,
                JsonTypeInfo<TRequestBody> jsonTypeInfoForRequestBody
            ) : base(path, method)
            {
                JsonTypeInfoForRequestBody = jsonTypeInfoForRequestBody;
            }
        }
    }
}
