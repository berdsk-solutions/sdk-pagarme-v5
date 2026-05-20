using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Berdsk.Sdk.PagarMe.V5.Services.Settlements.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Settlements
{
    /// <inheritdoc />
    public class PmSettlementService : PmBaseService, IPmSettlementService
    {
        public PmSettlementService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmListSettlementsResponse?> ListSettlementsAsync(
            string paymentDateStart,
            string paymentDateEnd,
            string? liquidationArrangementId = null,
            int? page = null,
            int? limit = null,
            bool? getIspb = null,
            string? settlementId = null,
            string? externalEnginePaymentId = null,
            string? order = null)
        {
            var queryParameters = new List<string>
            {
                $"payment_date_start={paymentDateStart}",
                $"payment_date_end={paymentDateEnd}"
            };

            if (!string.IsNullOrEmpty(liquidationArrangementId))
                queryParameters.Add($"liquidation_arrangement_id={liquidationArrangementId}");
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (limit.HasValue) queryParameters.Add($"limit={limit.Value}");
            if (getIspb.HasValue) queryParameters.Add($"get_ispb={getIspb.Value.ToString().ToLower()}");
            if (!string.IsNullOrEmpty(settlementId)) queryParameters.Add($"settlement_id={settlementId}");
            if (!string.IsNullOrEmpty(externalEnginePaymentId))
                queryParameters.Add($"external_engine_payment_id={externalEnginePaymentId}");
            if (!string.IsNullOrEmpty(order)) queryParameters.Add($"order={order}");

            var url = $"{PmEndpoints.Settlements.Base}?{string.Join("&", queryParameters)}";
            return await GetAsync<PmListSettlementsResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmListSettlementsResponse?> ListRecipientSettlementsAsync(
            string recipientId,
            string paymentDateStart,
            string paymentDateEnd)
        {
            var url = string.Format(PmEndpoints.Recipients.Settlements, recipientId);
            url += $"?payment_date_start={paymentDateStart}&payment_date_end={paymentDateEnd}";

            return await GetAsync<PmListSettlementsResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmSettlementResponse?> GetSettlementAsync(string settlementId)
        {
            var url = string.Format(PmEndpoints.Settlements.Get, settlementId);
            return await GetAsync<PmSettlementResponse>(url);
        }
    }
}


