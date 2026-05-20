using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Net.Http;
using Berdsk.Sdk.PagarMe.V5.Services.Webhooks.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Webhooks
{
    /// <summary>
    ///     Serviço para gerenciamento de Webhooks no Pagar.me.
    /// </summary>
    /// <remarks>
    ///     Referência: https://docs.pagar.me/reference/exemplo-de-webhook-1.md
    /// </remarks>
    public class PmWebhookService : PmBaseService, IPmWebhookService
    {
        public PmWebhookService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmListWebhooksResponse?> ListWebhooksAsync(
            string status = null,
            string webhookEvent = null,
            DateTime? createdSince = null,
            DateTime? createdUntil = null,
            int? page = null,
            int? size = null)
        {
            var queryParameters = new List<string>();
            if (!string.IsNullOrEmpty(status)) queryParameters.Add($"status={status}");
            if (!string.IsNullOrEmpty(webhookEvent)) queryParameters.Add($"webhook_event={webhookEvent}");
            if (createdSince.HasValue) queryParameters.Add($"created_since={createdSince.Value:yyyy-MM-dd}");
            if (createdUntil.HasValue) queryParameters.Add($"created_until={createdUntil.Value:yyyy-MM-dd}");
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            var url = PmEndpoints.Hooks.Base;
            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListWebhooksResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmWebhookResponse?> GetWebhookAsync(string hookId)
        {
            var url = string.Format(PmEndpoints.Hooks.Get, hookId);
            return await GetAsync<PmWebhookResponse>(url);
        }

        /// <inheritdoc />
        public async Task<object?> RetryWebhookAsync(string hookId)
        {
            var url = string.Format(PmEndpoints.Hooks.Retry, hookId);
            return await PostAsync<object, object>(url, new { });
        }
    }
}


