using PayPal.Sdk.Checkout.RequestInterfaces;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json.Serialization.Metadata;

namespace PayPal.Sdk.Checkout.Core.HttpRequests;

public static partial class PayPalHttpRequest
{
    [SuppressMessage("ReSharper", "PartialTypeWithSinglePart")]
    public static partial class WithFormRequest
    {
        public abstract class WithJsonResponse<TResponseType>(
            string path,
            HttpMethod method,
            JsonTypeInfo<TResponseType> jsonTypeInfoForResponseType
        ) : BaseHttpRequest<TResponseType, IDictionary<string, string>>(path, method),
            IPayPalRequestWithJsonResponseBody<TResponseType>
            where TResponseType : notnull
        {
            public JsonTypeInfo<TResponseType> JsonTypeInfoForResponseType { get; } = jsonTypeInfoForResponseType;
        }
    }
}
