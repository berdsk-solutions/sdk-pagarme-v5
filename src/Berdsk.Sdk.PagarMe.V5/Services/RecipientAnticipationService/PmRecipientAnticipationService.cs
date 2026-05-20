using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.RecipientAnticipationService.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientAnticipationService
{
    /// <inheritdoc />
    public class PmRecipientAnticipationService : PmBaseService, IPmRecipientAnticipationService
    {
        public PmRecipientAnticipationService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmAnticipationResponse?> CreateAnticipationAsync(string recipientId,
            PmCreateAnticipationRequest request)
        {
            var url = string.Format(PmEndpoints.Recipients.Anticipations, recipientId);
            return await PostAsync<PmAnticipationResponse, PmCreateAnticipationRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmAnticipationResponse?> GetAnticipationAsync(string recipientId, string anticipationId)
        {
            var url = string.Format(PmEndpoints.Recipients.GetAnticipation, recipientId, anticipationId);
            return await GetAsync<PmAnticipationResponse>(url);
        }

        /// <inheritdoc />
        public async Task<List<PmAnticipationResponse>?> ListAnticipationsAsync(string recipientId,
            int? page = null, int? count = null, string? id = null, string? paymentDate = null, long? amount = null)
        {
            var url = string.Format(PmEndpoints.Recipients.Anticipations, recipientId);
            var queryParameters = new List<string>();
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (count.HasValue) queryParameters.Add($"count={count.Value}");
            if (!string.IsNullOrEmpty(id)) queryParameters.Add($"id={id}");
            if (!string.IsNullOrEmpty(paymentDate)) queryParameters.Add($"payment_date={paymentDate}");
            if (amount.HasValue) queryParameters.Add($"amount={amount.Value}");

            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<List<PmAnticipationResponse>>(url);
        }

        /// <inheritdoc />
        public async Task<PmAnticipationSimulationResponse?> SimulateAnticipationAsync(string recipientId,
            PmSimulateAnticipationRequest request)
        {
            var url = string.Format(PmEndpoints.Recipients.SimulateAnticipation, recipientId);
            var queryParameters = new List<string>();
            queryParameters.Add($"requested_amount={request.RequestedAmount}");
            queryParameters.Add($"timeframe={request.Timeframe}");
            queryParameters.Add($"payment_date={request.PaymentDate:yyyy-MM-dd}");

            url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmAnticipationSimulationResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmAnticipationLimitsResponse?> GetAnticipationLimitsAsync(string recipientId,
            DateTime paymentDate, string timeframe)
        {
            var url = string.Format(PmEndpoints.Recipients.AnticipationLimits, recipientId);
            var queryParameters = new List<string>
            {
                $"payment_date={paymentDate:yyyy-MM-dd}",
                $"timeframe={timeframe}"
            };

            url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmAnticipationLimitsResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmAnticipationResponse?> CancelAnticipationAsync(string recipientId, string anticipationId)
        {
            var url = string.Format(PmEndpoints.Recipients.CancelAnticipation, recipientId, anticipationId);
            return await PostAsync<PmAnticipationResponse, object>(url, new { });
        }

        /// <inheritdoc />
        public async Task<PmAnticipationSettingsResponse?> UpdateAutomaticAnticipationSettingsAsync(string recipientId,
            PmUpdateAutomaticAnticipationSettingsRequest request)
        {
            var url = string.Format(PmEndpoints.Recipients.UpdateAutomaticAnticipationSettings, recipientId);
            return await PatchAsync<PmAnticipationSettingsResponse, PmUpdateAutomaticAnticipationSettingsRequest>(url,
                request);
        }
    }
}