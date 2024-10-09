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
        public abstract class WithJsonResponse<TResponseType>(
            string path,
            JsonTypeInfo<TResponseType> jsonTypeInfoForResponseType
        ) : BaseHttpRequest<TResponseType>(path, HttpMethod.Get),
            IPayPalRequestWithJsonResponseBody<TResponseType>
            where TResponseType : notnull
        {
            public JsonTypeInfo<TResponseType> JsonTypeInfoForResponseType { get; } = jsonTypeInfoForResponseType;
        }
    }
}
