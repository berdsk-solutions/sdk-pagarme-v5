using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface
{
    /// <inheritdoc />
    public class PmSellerInterfaceService : PmBaseService, IPmSellerInterfaceService
    {
        public PmSellerInterfaceService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<List<PmReceivableUnitResponse>?> ListReceivableUnitsAsync(string recipientId,
            DateTime startDate,
            DateTime endDate)
        {
            var url = string.Format(PmEndpoints.Recipients.ReceivableUnits, recipientId);
            url += $"?start_date={startDate:yyyy-MM-ddTHH:mm:ssZ}&end_date={endDate:yyyy-MM-ddTHH:mm:ssZ}";
            return await GetAsync<List<PmReceivableUnitResponse>>(url);
        }

        /// <inheritdoc />
        public async Task<PmListSettlementObligationsResponse?> ListSettlementObligationsAsync(
            DateTime expectedSettlementDateSince,
            DateTime expectedSettlementDateUntil,
            string? recipientId = null,
            int? page = null,
            int? size = null)
        {
            var queryParameters = new List<string>
            {
                $"expected_settlement_date_since={expectedSettlementDateSince:yyyy-MM-dd}",
                $"expected_settlement_date_until={expectedSettlementDateUntil:yyyy-MM-dd}"
            };

            if (!string.IsNullOrEmpty(recipientId)) queryParameters.Add($"recipient_id={recipientId}");
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            var url = PmEndpoints.SellerInterface.SettlementObligations + "?" + string.Join("&", queryParameters);
            return await GetAsync<PmListSettlementObligationsResponse>(url);
        }

        /// <inheritdoc />
        public async Task<List<PmContractResponse>?> ListContractsAsync(
            string recipientId,
            DateTime expectedSettlementDateSince,
            DateTime expectedSettlementDateUntil)
        {
            var queryParameters = new List<string>
            {
                $"recipient_id={recipientId}",
                $"expected_settlement_date_since={expectedSettlementDateSince:yyyy-MM-dd}",
                $"expected_settlement_date_until={expectedSettlementDateUntil:yyyy-MM-dd}"
            };

            var url = PmEndpoints.SellerInterface.Contracts + "?" + string.Join("&", queryParameters);
            return await GetAsync<List<PmContractResponse>>(url);
        }

        /// <inheritdoc />
        public async Task<PmListContestationsResponse?> ListContestationsAsync(
            string contractKey,
            int? page = null,
            int? size = null,
            string? id = null,
            string? originalAssetHolderDocument = null,
            string? status = null,
            DateTime? createdAt = null)
        {
            var queryParameters = new List<string> { $"contract_key={contractKey}" };

            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");
            if (!string.IsNullOrEmpty(id)) queryParameters.Add($"id={id}");
            if (!string.IsNullOrEmpty(originalAssetHolderDocument))
                queryParameters.Add($"original_assetHolder_document={originalAssetHolderDocument}");
            if (!string.IsNullOrEmpty(status)) queryParameters.Add($"status={status}");
            if (createdAt.HasValue) queryParameters.Add($"created_at={createdAt.Value:yyyy-MM-dd}");

            var url = PmEndpoints.SellerInterface.Contestations + "?" + string.Join("&", queryParameters);
            return await GetAsync<PmListContestationsResponse>(url);
        }

        /// <inheritdoc />
        public async Task CreateContestationAsync(PmCreateContestationRequest request)
        {
            var url = PmEndpoints.SellerInterface.Contestations;
            await PostAsync<object, PmCreateContestationRequest>(url, request);
        }
    }
}