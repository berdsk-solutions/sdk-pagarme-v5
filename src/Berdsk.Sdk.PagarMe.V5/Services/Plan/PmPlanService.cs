using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.PlanItem;

namespace Berdsk.Sdk.PagarMe.V5.Services.Plan
{
    public class PmPlanService : PmBaseService, IPmPlanService
    {
        public PmPlanService(HttpClient httpClient) : base(httpClient)
        {
            Items = new PmPlanItemService(httpClient);
        }

        /// <inheritdoc />
        public IPmPlanItemService Items { get; }

        /// <inheritdoc />
        public async Task<PmPlanResponse?> CreatePlanAsync(PmCreatePlanRequest request)
        {
            return await PostAsync<PmPlanResponse, PmCreatePlanRequest>(PmEndpoints.Plans.Base, request);
        }

        /// <inheritdoc />
        public async Task<PmPlanResponse?> GetPlanAsync(string planId)
        {
            var url = string.Format(PmEndpoints.Plans.Get, planId);
            return await GetAsync<PmPlanResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmPlanResponse?> UpdatePlanAsync(string planId, PmUpdatePlanRequest request)
        {
            var url = string.Format(PmEndpoints.Plans.Update, planId);
            return await PutAsync<PmPlanResponse, PmUpdatePlanRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmPlanResponse?> DeletePlanAsync(string planId)
        {
            var url = string.Format(PmEndpoints.Plans.Delete, planId);
            return await DeleteAsync<PmPlanResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmListPlansResponse?> ListPlansAsync(string? name = null, string? status = null,
            int? page = null,
            int? size = null)
        {
            var queryParameters = new List<string>();
            if (!string.IsNullOrEmpty(name)) queryParameters.Add($"name={Uri.EscapeDataString(name)}");
            if (!string.IsNullOrEmpty(status)) queryParameters.Add($"status={Uri.EscapeDataString(status)}");
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            var url = PmEndpoints.Plans.Base;
            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListPlansResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmPlanResponse?> UpdatePlanMetadataAsync(string planId, Dictionary<string, string> metadata)
        {
            var url = string.Format(PmEndpoints.Plans.UpdateMetadata, planId);
            return await PatchAsync<PmPlanResponse, PmUpdatePlanMetadataRequest>(url,
                new PmUpdatePlanMetadataRequest { Metadata = metadata });
        }
    }
}