using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Net.Http;
using Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItem.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItem
{
    public class PmSubscriptionItemService : PmBaseService, IPmSubscriptionItemService
    {
        public PmSubscriptionItemService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionItemResponse?> CreateSubscriptionItemAsync(string subscriptionId,
            PmCreateSubscriptionItemRequestDto request)
        {
            var url = string.Format(PmEndpoints.SubscriptionItems.Base, subscriptionId);
            return await PostAsync<PmSubscriptionItemResponse, PmCreateSubscriptionItemRequestDto>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionItemResponse?> GetSubscriptionItemAsync(string subscriptionId, string itemId)
        {
            var url = string.Format(PmEndpoints.SubscriptionItems.Get, subscriptionId, itemId);
            return await GetAsync<PmSubscriptionItemResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmListSubscriptionItemsResponse?> ListSubscriptionItemsAsync(string subscriptionId,
            int? page = null, int? size = null, string? name = null, string? code = null, string? status = null)
        {
            var url = string.Format(PmEndpoints.SubscriptionItems.Base, subscriptionId);
            var queryParameters = new List<string>();
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");
            if (!string.IsNullOrEmpty(name)) queryParameters.Add($"name={Uri.EscapeDataString(name)}");
            if (!string.IsNullOrEmpty(code)) queryParameters.Add($"code={Uri.EscapeDataString(code)}");
            if (!string.IsNullOrEmpty(status)) queryParameters.Add($"status={Uri.EscapeDataString(status)}");

            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListSubscriptionItemsResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionItemResponse?> UpdateSubscriptionItemAsync(string subscriptionId, string itemId,
            PmUpdateSubscriptionItemRequest request)
        {
            var url = string.Format(PmEndpoints.SubscriptionItems.Update, subscriptionId, itemId);
            return await PutAsync<PmSubscriptionItemResponse, PmUpdateSubscriptionItemRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionItemResponse?> DeleteSubscriptionItemAsync(string subscriptionId, string itemId)
        {
            var url = string.Format(PmEndpoints.SubscriptionItems.Delete, subscriptionId, itemId);
            return await DeleteAsync<PmSubscriptionItemResponse>(url);
        }
    }
}



