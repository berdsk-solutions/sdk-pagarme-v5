using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Disputes.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Disputes
{
    /// <inheritdoc />
    public class PmDisputeService : PmBaseService, IPmDisputeService
    {
        public PmDisputeService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmListDisputesResponse> ListDisputesAsync(
            DateTime? createdAtLte = null,
            DateTime? createdAtGte = null,
            string status = null,
            int? reasonCode = null,
            string network = null,
            string forwardCursor = null,
            int? limit = null)
        {
            var queryParameters = new List<string>();
            if (createdAtLte.HasValue) queryParameters.Add($"createdAt__lte={createdAtLte.Value:yyyy-MM-ddTHH:mm:ss}");
            if (createdAtGte.HasValue) queryParameters.Add($"createdAt__gte={createdAtGte.Value:yyyy-MM-ddTHH:mm:ss}");
            if (!string.IsNullOrEmpty(status)) queryParameters.Add($"status={status}");
            if (reasonCode.HasValue) queryParameters.Add($"reason.code={reasonCode.Value}");
            if (!string.IsNullOrEmpty(network)) queryParameters.Add($"network={network}");
            if (!string.IsNullOrEmpty(forwardCursor)) queryParameters.Add($"forwardCursor={forwardCursor}");
            if (limit.HasValue) queryParameters.Add($"limit={limit.Value}");

            var url = PmEndpoints.Disputes.Base;
            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListDisputesResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmDisputeResponse> GetDisputeAsync(string disputeId)
        {
            var url = string.Format(PmEndpoints.Disputes.Get, disputeId);
            return await GetAsync<PmDisputeResponse>(url);
        }
    }
}