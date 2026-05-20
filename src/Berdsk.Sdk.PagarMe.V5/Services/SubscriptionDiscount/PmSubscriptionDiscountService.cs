using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionDiscount.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionDiscount
{
    public class PmSubscriptionDiscountService : PmBaseService, IPmSubscriptionDiscountService
    {
        public PmSubscriptionDiscountService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionDiscountResponse?> CreateSubscriptionDiscountAsync(string subscriptionId,
            PmCreateSubscriptionDiscountRequest request)
        {
            var url = string.Format(PmEndpoints.SubscriptionDiscounts.Base, subscriptionId);
            return await PostAsync<PmSubscriptionDiscountResponse, PmCreateSubscriptionDiscountRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionDiscountResponse?> GetSubscriptionDiscountAsync(string subscriptionId,
            string discountId)
        {
            var url = string.Format(PmEndpoints.SubscriptionDiscounts.Get, subscriptionId, discountId);
            return await GetAsync<PmSubscriptionDiscountResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmListSubscriptionDiscountsResponse?> ListSubscriptionDiscountsAsync(string subscriptionId,
            int? page = null, int? size = null)
        {
            var url = string.Format(PmEndpoints.SubscriptionDiscounts.Base, subscriptionId);
            var queryParameters = new List<string>();
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListSubscriptionDiscountsResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmSubscriptionDiscountResponse?> DeleteSubscriptionDiscountAsync(string subscriptionId,
            string discountId)
        {
            var url = string.Format(PmEndpoints.SubscriptionDiscounts.Delete, subscriptionId, discountId);
            return await DeleteAsync<PmSubscriptionDiscountResponse>(url);
        }
    }
}


