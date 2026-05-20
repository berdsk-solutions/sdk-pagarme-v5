using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Net.Http;
using Berdsk.Sdk.PagarMe.V5.Services.BalanceOperations.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.BalanceOperations
{
    /// <inheritdoc />
    public class PmBalanceOperationsService : PmBaseService, IPmBalanceOperationsService
    {
        public PmBalanceOperationsService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmListBalanceOperationsResponse?> ListBalanceOperationsAsync(
            DateTime? createdSince = null,
            DateTime? createdUntil = null,
            string? status = null,
            string? recipientId = null,
            int? page = null,
            int? size = null)
        {
            var queryParameters = new List<string>();
            if (createdSince.HasValue) queryParameters.Add($"created_since={createdSince.Value:yyyy-MM-dd}");
            if (createdUntil.HasValue) queryParameters.Add($"created_until={createdUntil.Value:yyyy-MM-dd}");
            if (!string.IsNullOrEmpty(status)) queryParameters.Add($"status={status}");
            if (!string.IsNullOrEmpty(recipientId)) queryParameters.Add($"recipient_id={recipientId}");
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            var url = PmEndpoints.BalanceOperations.Base;
            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListBalanceOperationsResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmBalanceOperationResponse?> GetBalanceOperationAsync(string balanceOperationId)
        {
            var url = string.Format(PmEndpoints.BalanceOperations.Get, balanceOperationId);
            return await GetAsync<PmBalanceOperationResponse>(url);
        }
    }
}


