using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.OrderItem.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.OrderItem
{
    public class PmOrderItemService : PmBaseService, IPmOrderItemService
    {
        public PmOrderItemService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmOrderItemResponse?> CreateOrderItemAsync(string orderId, PmCreateOrderItemRequest request)
        {
            var url = string.Format(PmEndpoints.OrderItems.Base, orderId);
            return await PostAsync<PmOrderItemResponse, PmCreateOrderItemRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmOrderItemResponse?> GetOrderItemAsync(string orderId, string itemId)
        {
            var url = string.Format(PmEndpoints.OrderItems.Get, orderId, itemId);
            return await GetAsync<PmOrderItemResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmOrderItemResponse?> UpdateOrderItemAsync(string orderId, string itemId,
            PmUpdateOrderItemRequest request)
        {
            var url = string.Format(PmEndpoints.OrderItems.Update, orderId, itemId);
            return await PutAsync<PmOrderItemResponse, PmUpdateOrderItemRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmOrderItemResponse?> DeleteOrderItemAsync(string orderId, string itemId)
        {
            var url = string.Format(PmEndpoints.OrderItems.Delete, orderId, itemId);
            return await DeleteAsync<PmOrderItemResponse>(url);
        }

        /// <inheritdoc />
        public async Task<bool> DeleteAllOrderItemsAsync(string orderId)
        {
            var url = string.Format(PmEndpoints.OrderItems.DeleteAll, orderId);
            var response = await HttpClient.DeleteAsync(url);
            return response.IsSuccessStatusCode;
        }
    }
}