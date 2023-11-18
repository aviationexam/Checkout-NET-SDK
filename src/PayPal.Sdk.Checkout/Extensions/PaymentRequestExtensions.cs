using PayPal.Sdk.Checkout.Authentication;
using PayPal.Sdk.Checkout.Core.Interfaces;
using PayPal.Sdk.Checkout.Payments;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Extensions;

public static class PaymentRequestExtensions
{
    public static async Task<PaymentCapture?> CapturePaymentAsync(
        this IPayPalHttpClient payPalHttpClient,
        AccessToken accessToken,
        string authorizationId,
        Action<AuthorizationsCaptureRequest>? configureRequest = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new AuthorizationsCaptureRequest(authorizationId);

        configureRequest?.Invoke(request);

        var response = await payPalHttpClient.ExecuteAsync<AuthorizationsCaptureRequest, CaptureRequest, PaymentCapture>(request, accessToken, cancellationToken);

        return response.ResponseBody;
    }

    public static async Task<PaymentRefund?> CapturesRefundAsync(
        this IPayPalHttpClient payPalHttpClient,
        AccessToken accessToken,
        string captureId,
        Action<CapturesRefundRequest>? configureRequest = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new CapturesRefundRequest(captureId);

        configureRequest?.Invoke(request);

        var response = await payPalHttpClient.ExecuteAsync<CapturesRefundRequest, RefundRequest, PaymentRefund>(request, accessToken, cancellationToken);

        return response.ResponseBody;
    }
}
