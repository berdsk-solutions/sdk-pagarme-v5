using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.PlanItem.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.PlanItem
{
    public class PmPlanItemService : PmBaseService, IPmPlanItemService
    {
        public PmPlanItemService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmPlanItemResponse?> CreatePlanItemAsync(string planId, PmCreatePlanItemRequest request)
        {
            var url = string.Format(PmEndpoints.PlanItems.Base, planId);
            return await PostAsync<PmPlanItemResponse, PmCreatePlanItemRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmPlanItemResponse?> GetPlanItemAsync(string planId, string planItemId)
        {
            var url = string.Format(PmEndpoints.PlanItems.Get, planId, planItemId);
            return await GetAsync<PmPlanItemResponse>(url);
        }

        /// <inheritdoc />
        public async Task<List<PmPlanItemResponse>?> ListPlanItemsAsync(string planId)
        {
            var url = string.Format(PmEndpoints.PlanItems.Base, planId);
            return await GetAsync<List<PmPlanItemResponse>>(url);
        }

        /// <inheritdoc />
        public async Task<PmPlanItemResponse?> UpdatePlanItemAsync(string planId, string planItemId,
            PmUpdatePlanItemRequest request)
        {
            var url = string.Format(PmEndpoints.PlanItems.Update, planId, planItemId);
            return await PutAsync<PmPlanItemResponse, PmUpdatePlanItemRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmPlanItemResponse?> DeletePlanItemAsync(string planId, string planItemId)
        {
            var url = string.Format(PmEndpoints.PlanItems.Delete, planId, planItemId);
            return await DeleteAsync<PmPlanItemResponse>(url);
        }
    }
}