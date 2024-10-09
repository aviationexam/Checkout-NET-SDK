using PayPal.Sdk.Checkout.RequestInterfaces;
using System.Net.Http;
using System.Text.Json.Serialization.Metadata;

namespace PayPal.Sdk.Checkout.Core.HttpRequests;

public static partial class PayPalHttpRequest
{
    public static partial class WithJsonRequest<TRequestBody>
        where TRequestBody : notnull
    {
        public abstract class WithJsonResponse<TResponseType>(
            string path,
            HttpMethod method,
            JsonTypeInfo<TResponseType> jsonTypeInfoForResponseType,
            JsonTypeInfo<TRequestBody> jsonTypeInfoForRequestBody
        ) : BaseHttpRequest<TResponseType, TRequestBody>(path, method),
            IPayPalRequestWithJsonResponseBody<TResponseType>,
            IPayPalRequestWithJsonRequestBody<TRequestBody>
            where TResponseType : notnull
        {
            public JsonTypeInfo<TResponseType> JsonTypeInfoForResponseType { get; } = jsonTypeInfoForResponseType;

            public JsonTypeInfo<TRequestBody> JsonTypeInfoForRequestBody { get; } = jsonTypeInfoForRequestBody;
        }
    }
}
