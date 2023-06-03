using PayPal.Sdk.Checkout.RequestInterfaces;
using System.Net.Http;
using System.Text.Json.Serialization.Metadata;

namespace PayPal.Sdk.Checkout.Core.HttpRequests;

public static partial class PayPalHttpRequest
{
    public static partial class WithJsonRequest<TRequestBody>
        where TRequestBody : notnull
    {
        public abstract class WithJsonResponse<TResponseType> :
            BaseHttpRequest<TResponseType, TRequestBody>,
            IPayPalRequestWithJsonResponseBody<TResponseType>,
            IPayPalRequestWithJsonRequestBody<TRequestBody>
            where TResponseType : notnull
        {
            public JsonTypeInfo<TResponseType> JsonTypeInfoForResponseType { get; }

            public JsonTypeInfo<TRequestBody> JsonTypeInfoForRequestBody { get; }

            protected WithJsonResponse(
                string path, HttpMethod method,
                JsonTypeInfo<TResponseType> jsonTypeInfoForResponseType,
                JsonTypeInfo<TRequestBody> jsonTypeInfoForRequestBody
            ) : base(path, method)
            {
                JsonTypeInfoForResponseType = jsonTypeInfoForResponseType;
                JsonTypeInfoForRequestBody = jsonTypeInfoForRequestBody;
            }
        }
    }
}
