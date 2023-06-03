using PayPal.Sdk.Checkout.RequestInterfaces;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json.Serialization.Metadata;

namespace PayPal.Sdk.Checkout.Core.HttpRequests;


public static partial class PayPalHttpRequest
{
    [SuppressMessage("ReSharper", "PartialTypeWithSinglePart")]
    public static partial class WithGetRequest
    {
        public abstract class WithJsonResponse<TResponseType> :
            BaseHttpRequest<TResponseType>,
            IPayPalRequestWithJsonResponseBody<TResponseType>
            where TResponseType : notnull
        {
            public JsonTypeInfo<TResponseType> JsonTypeInfoForResponseType { get; }

            protected WithJsonResponse(
                string path,
                JsonTypeInfo<TResponseType> jsonTypeInfoForResponseType
            ) : base(path, HttpMethod.Get)
            {
                JsonTypeInfoForResponseType = jsonTypeInfoForResponseType;
            }
        }
    }
}
