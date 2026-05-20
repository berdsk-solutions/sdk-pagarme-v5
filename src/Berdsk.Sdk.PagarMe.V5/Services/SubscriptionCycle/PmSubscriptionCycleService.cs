using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionCycle.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionCycle
{
    public class PmSubscriptionCycleService : PmBaseService, IPmSubscriptionCycleService
    {
        public PmSubscriptionCycleService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmListSubscriptionCyclesResponse?> ListSubscriptionCyclesAsync(string subscriptionId,
            int? page = null, int? size = null)
        {
            var url = string.Format(PmEndpoints.SubscriptionCycles.Base, subscriptionId);
            var queryParameters = new List<string>();
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListSubscriptionCyclesResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionCycleResponse?> GetSubscriptionCycleAsync(string subscriptionId, string cycleId)
        {
            var url = string.Format(PmEndpoints.SubscriptionCycles.Get, subscriptionId, cycleId);
            return await GetAsync<PmSubscriptionCycleResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionCycleResponse?> RenewSubscriptionCycleAsync(string subscriptionId)
        {
            var url = string.Format(PmEndpoints.SubscriptionCycles.Renew, subscriptionId);
            return await PostAsync<PmSubscriptionCycleResponse, object>(url, new { });
        }
    }
}