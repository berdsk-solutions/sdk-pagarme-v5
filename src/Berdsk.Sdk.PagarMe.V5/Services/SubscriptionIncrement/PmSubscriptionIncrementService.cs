using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionIncrement.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionIncrement
{
    public class PmSubscriptionIncrementService : PmBaseService, IPmSubscriptionIncrementService
    {
        public PmSubscriptionIncrementService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionIncrementResponse?> CreateSubscriptionIncrementAsync(string subscriptionId,
            PmCreateSubscriptionIncrementRequest request)
        {
            var url = string.Format(PmEndpoints.SubscriptionIncrements.Base, subscriptionId);
            return await PostAsync<PmSubscriptionIncrementResponse, PmCreateSubscriptionIncrementRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionIncrementResponse?> GetSubscriptionIncrementAsync(string subscriptionId,
            string incrementId)
        {
            var url = string.Format(PmEndpoints.SubscriptionIncrements.Get, subscriptionId, incrementId);
            return await GetAsync<PmSubscriptionIncrementResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmListSubscriptionIncrementsResponse?> ListSubscriptionIncrementsAsync(string subscriptionId,
            int? page = null, int? size = null)
        {
            var url = string.Format(PmEndpoints.SubscriptionIncrements.Base, subscriptionId);
            var queryParameters = new List<string>();
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListSubscriptionIncrementsResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionIncrementResponse?> DeleteSubscriptionIncrementAsync(string subscriptionId,
            string incrementId)
        {
            var url = string.Format(PmEndpoints.SubscriptionIncrements.Delete, subscriptionId, incrementId);
            return await DeleteAsync<PmSubscriptionIncrementResponse>(url);
        }
    }
}