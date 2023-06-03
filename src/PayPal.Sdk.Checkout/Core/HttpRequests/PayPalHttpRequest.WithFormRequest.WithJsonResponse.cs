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
        public abstract class WithJsonResponse<TResponseType> :
            BaseHttpRequest<TResponseType, IDictionary<string, string>>,
            IPayPalRequestWithJsonResponseBody<TResponseType>
            where TResponseType : notnull
        {
            public JsonTypeInfo<TResponseType> JsonTypeInfoForResponseType { get; }

            protected WithJsonResponse(
                string path, HttpMethod method,
                JsonTypeInfo<TResponseType> jsonTypeInfoForResponseType
            ) : base(path, method)
            {
                JsonTypeInfoForResponseType = jsonTypeInfoForResponseType;
            }
        }
    }
}
