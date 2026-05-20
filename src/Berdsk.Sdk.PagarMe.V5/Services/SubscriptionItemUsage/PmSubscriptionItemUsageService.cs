using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItemUsage.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItemUsage
{
    public class PmSubscriptionItemUsageService : PmBaseService, IPmSubscriptionItemUsageService
    {
        public PmSubscriptionItemUsageService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionItemUsageResponse?> CreateUsageAsync(string subscriptionId, string itemId,
            PmCreateSubscriptionItemUsageRequest request)
        {
            var url = string.Format(PmEndpoints.SubscriptionItemUsage.Base, subscriptionId, itemId);
            return await PostAsync<PmSubscriptionItemUsageResponse, PmCreateSubscriptionItemUsageRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmListSubscriptionItemUsagesResponse?> ListUsagesAsync(string subscriptionId, string itemId,
            int? page = null, int? size = null)
        {
            var url = string.Format(PmEndpoints.SubscriptionItemUsage.Base, subscriptionId, itemId);
            var queryParameters = new List<string>();
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListSubscriptionItemUsagesResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionItemUsageResponse?> DeleteUsageAsync(string subscriptionId, string itemId,
            string usageId)
        {
            var url = string.Format(PmEndpoints.SubscriptionItemUsage.Get, subscriptionId, itemId, usageId);
            return await DeleteAsync<PmSubscriptionItemUsageResponse>(url);
        }
    }
}


