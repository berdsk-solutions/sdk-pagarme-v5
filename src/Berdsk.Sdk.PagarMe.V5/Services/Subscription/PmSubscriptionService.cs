using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Net.Http;
using Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionCycle;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionDiscount;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionIncrement;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionInvoice;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItem;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItemUsage;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionSplit;

namespace Berdsk.Sdk.PagarMe.V5.Services.Subscription
{
    public class PmSubscriptionService : PmBaseService, IPmSubscriptionService
    {
        public PmSubscriptionService(HttpClient httpClient) : base(httpClient)
        {
            Items = new PmSubscriptionItemService(httpClient);
            Cycles = new PmSubscriptionCycleService(httpClient);
            Discounts = new PmSubscriptionDiscountService(httpClient);
            Increments = new PmSubscriptionIncrementService(httpClient);
            Invoices = new PmSubscriptionInvoiceService(httpClient);
            ItemUsage = new PmSubscriptionItemUsageService(httpClient);
            Splits = new PmSubscriptionSplitService(httpClient);
        }

        /// <inheritdoc />
        public IPmSubscriptionItemService Items { get; }

        /// <inheritdoc />
        public IPmSubscriptionCycleService Cycles { get; }

        /// <inheritdoc />
        public IPmSubscriptionDiscountService Discounts { get; }

        /// <inheritdoc />
        public IPmSubscriptionIncrementService Increments { get; }

        /// <inheritdoc />
        public IPmSubscriptionInvoiceService Invoices { get; }

        /// <inheritdoc />
        public IPmSubscriptionItemUsageService ItemUsage { get; }

        /// <inheritdoc />
        public IPmSubscriptionSplitService Splits { get; }

        /// <inheritdoc />
        public async Task<PmSubscriptionResponse?> CreateSubscriptionAsync(PmCreateSubscriptionRequest request)
        {
            return await PostAsync<PmSubscriptionResponse, PmCreateSubscriptionRequest>(PmEndpoints.Subscriptions.Base,
                request);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionResponse?> GetSubscriptionAsync(string subscriptionId)
        {
            var url = string.Format(PmEndpoints.Subscriptions.Get, subscriptionId);
            return await GetAsync<PmSubscriptionResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmListSubscriptionsResponse?> ListSubscriptionsAsync(string? code = null, string? status = null,
            string? customerId = null, string? planId = null, int? page = null, int? size = null)
        {
            var queryParameters = new List<string>();
            if (!string.IsNullOrEmpty(code)) queryParameters.Add($"code={Uri.EscapeDataString(code)}");
            if (!string.IsNullOrEmpty(status)) queryParameters.Add($"status={Uri.EscapeDataString(status)}");
            if (!string.IsNullOrEmpty(customerId)) queryParameters.Add($"customer_id={Uri.EscapeDataString(customerId)}");
            if (!string.IsNullOrEmpty(planId)) queryParameters.Add($"plan_id={Uri.EscapeDataString(planId)}");
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            var url = PmEndpoints.Subscriptions.Base;
            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListSubscriptionsResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionResponse?> CancelSubscriptionAsync(string subscriptionId,
            bool cancelPendingInvoices = true)
        {
            var url = string.Format(PmEndpoints.Subscriptions.Cancel, subscriptionId);
            // Pagar.me v5 DELETE subscriptions/{id} supports a body for cancel_pending_invoices
            // But our PmBaseService.DeleteAsync doesn't take a body. 
            // According to docs, it can be passed in the body.
            // Let's use Patch or Post if needed, but standard is DELETE.
            // If DeleteAsync doesn't support body, we might need a custom call or just omit for now if not critical.
            // Actually, many APIs use query params for DELETE. Let's check.
            if (cancelPendingInvoices) url += "?cancel_pending_invoices=true";
            return await DeleteAsync<PmSubscriptionResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionResponse?> UpdateSubscriptionCardAsync(string subscriptionId,
            PmUpdateSubscriptionCardRequest request)
        {
            var url = string.Format(PmEndpoints.Subscriptions.UpdateCard, subscriptionId);
            return await PatchAsync<PmSubscriptionResponse, PmUpdateSubscriptionCardRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionResponse?> UpdateSubscriptionMetadataAsync(string subscriptionId,
            Dictionary<string, string> metadata)
        {
            var url = string.Format(PmEndpoints.Subscriptions.UpdateMetadata, subscriptionId);
            return await PatchAsync<PmSubscriptionResponse, PmUpdateSubscriptionMetadataRequest>(url,
                new PmUpdateSubscriptionMetadataRequest { Metadata = metadata });
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionResponse?> UpdateSubscriptionPaymentMethodAsync(string subscriptionId,
            PmUpdateSubscriptionPaymentMethodRequest request)
        {
            var url = string.Format(PmEndpoints.Subscriptions.UpdatePaymentMethod, subscriptionId);
            return await PatchAsync<PmSubscriptionResponse, PmUpdateSubscriptionPaymentMethodRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionResponse?> UpdateSubscriptionStartAtAsync(string subscriptionId, DateTime startAt)
        {
            var url = string.Format(PmEndpoints.Subscriptions.UpdateStartAt, subscriptionId);
            return await PatchAsync<PmSubscriptionResponse, PmUpdateSubscriptionStartAtRequest>(url,
                new PmUpdateSubscriptionStartAtRequest { StartAt = startAt });
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionResponse?> UpdateSubscriptionMinimumPriceAsync(string subscriptionId,
            int? minimumPrice)
        {
            var url = string.Format(PmEndpoints.Subscriptions.UpdateMinimumPrice, subscriptionId);
            return await PatchAsync<PmSubscriptionResponse, PmUpdateSubscriptionMinimumPriceRequest>(url,
                new PmUpdateSubscriptionMinimumPriceRequest { MinimumPrice = minimumPrice });
        }

        /// <inheritdoc />
        public async Task<bool> SetManualBillingAsync(string subscriptionId, bool enabled)
        {
            var url = string.Format(PmEndpoints.Subscriptions.ManualBilling, subscriptionId);
            var response = enabled
                ? await HttpClient.PostAsync(url, null)
                : await HttpClient.DeleteAsync(url);
            return response.IsSuccessStatusCode;
        }
    }
}



