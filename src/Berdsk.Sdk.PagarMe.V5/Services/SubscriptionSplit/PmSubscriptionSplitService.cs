using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionSplit.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionSplit
{
    public class PmSubscriptionSplitService : PmBaseService, IPmSubscriptionSplitService
    {
        public PmSubscriptionSplitService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionSplitResponse?> GetSubscriptionSplitAsync(string subscriptionId)
        {
            var url = string.Format(PmEndpoints.SubscriptionSplit.Base, subscriptionId);
            return await GetAsync<PmSubscriptionSplitResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionSplitResponse?> UpdateSubscriptionSplitAsync(string subscriptionId,
            PmUpdateSubscriptionSplitRequest request)
        {
            var url = string.Format(PmEndpoints.SubscriptionSplit.Base, subscriptionId);
            return await PatchAsync<PmSubscriptionSplitResponse, PmUpdateSubscriptionSplitRequest>(url, request);
        }
    }
}