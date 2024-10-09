using PayPal.Sdk.Checkout.Extensions;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace PayPal.Sdk.Checkout.Samples.CaptureIntentExamples;

public static class RunAllCaptureIntentFlow
{
    //Rename to Main1 => Main
    [SuppressMessage("ReSharper", "UnusedMember.Local")]
    private static async Task Main1()
    {
        var payPalHttpClient = SampleHttpClientFactory.CreateHttpClient();

        var accessToken = await payPalHttpClient.AuthenticateAsync().ConfigureAwait(false);

        Console.WriteLine("Running Capture Intent Flow..");
        var createOrderResponse = await payPalHttpClient.CreateOrder(accessToken!, true).ConfigureAwait(false);

        Console.WriteLine("Status: {0}", createOrderResponse!.Status);
        Console.WriteLine("Order Id: {0}", createOrderResponse.Id);
        Console.WriteLine("Intent: {0}", createOrderResponse.CheckoutPaymentIntent);
        Console.WriteLine("Links:");
        foreach (var link in createOrderResponse.Links)
        {
            Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
        }

        var amount = createOrderResponse.PurchaseUnits.Single().AmountWithBreakdown;
        Console.WriteLine("Total Amount: {0} {1}", amount.CurrencyCode, amount.Value);

        Console.WriteLine("Copy approve link and paste it in browser. Login with buyer account and follow the instructions.\nOnce approved hit enter...\n");
        Console.Read();

        Console.WriteLine("Capturing the payment...");
        var captureOrderResponse = await payPalHttpClient.CaptureOrder(accessToken!, createOrderResponse.Id, true).ConfigureAwait(false);

        var captureId = "";
        Console.WriteLine("Status: {0}", captureOrderResponse!.Status);
        Console.WriteLine("Order Id: {0}", captureOrderResponse.Id);
        Console.WriteLine("Intent: {0}", captureOrderResponse.CheckoutPaymentIntent);
        Console.WriteLine("Links:");
        foreach (var link in captureOrderResponse.Links)
        {
            Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
        }

        foreach (var purchaseUnit in captureOrderResponse.PurchaseUnits)
        {
            foreach (var capture in purchaseUnit.Payments.Captures)
            {
                captureId = capture.Id;
            }
        }

        var captureAmount = captureOrderResponse.PurchaseUnits.Single().AmountWithBreakdown;
        Console.WriteLine("Buyer:");
        Console.WriteLine("\tEmail Address: {0}\n\tName: {1} {2}", captureOrderResponse.Payer.Email, captureOrderResponse.Payer.Name.GivenName, captureOrderResponse.Payer.Name.Surname);
        Console.WriteLine("CaptureAmount: {0}", captureAmount);

        Console.WriteLine("Refunding the Order....");
        var refundOrderResponse = await payPalHttpClient.CapturesRefund(accessToken!, captureId, true).ConfigureAwait(false);
        Console.WriteLine("Status: {0}", refundOrderResponse!.Status);
        Console.WriteLine("Refund Id: {0}", refundOrderResponse.Id);
        Console.WriteLine("Links:");
        foreach (var link in refundOrderResponse.Links)
        {
            Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
        }
    }
}
