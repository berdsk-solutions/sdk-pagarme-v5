using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionInvoice.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionInvoice
{
    public class PmSubscriptionInvoiceService : PmBaseService, IPmSubscriptionInvoiceService
    {
        public PmSubscriptionInvoiceService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmListSubscriptionInvoicesResponse?> ListSubscriptionInvoicesAsync(string subscriptionId,
            int? page = null, int? size = null)
        {
            var url = string.Format(PmEndpoints.SubscriptionInvoices.Base, subscriptionId);
            var queryParameters = new List<string>();
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListSubscriptionInvoicesResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionInvoiceResponse?> GetSubscriptionInvoiceAsync(string invoiceId)
        {
            var url = string.Format(PmEndpoints.SubscriptionInvoices.Get, invoiceId);
            return await GetAsync<PmSubscriptionInvoiceResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionInvoiceResponse?> CreateInvoiceAsync(string subscriptionId, string cycleId,
            Dictionary<string, string>? metadata = null)
        {
            var url = string.Format(PmEndpoints.SubscriptionCycles.Pay, subscriptionId, cycleId);
            return await PostAsync<PmSubscriptionInvoiceResponse, object>(url, new { metadata });
        }

        /// <inheritdoc />
        public async Task<PmListSubscriptionInvoicesResponse?> ListAllInvoicesAsync(string? status = null,
            int? page = null,
            int? size = null)
        {
            var url = PmEndpoints.SubscriptionInvoices.ListAll;
            var queryParameters = new List<string>();
            if (!string.IsNullOrEmpty(status)) queryParameters.Add($"status={Uri.EscapeDataString(status)}");
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListSubscriptionInvoicesResponse>(url);
        }
    }
}