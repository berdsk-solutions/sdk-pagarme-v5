using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Net.Http;
using Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.OrderItem;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order
{
    public class PmOrderService : PmBaseService, IPmOrderService
    {
        public PmOrderService(HttpClient httpClient) : base(httpClient)
        {
            Items = new PmOrderItemService(httpClient);
        }

        /// <inheritdoc />
        public IPmOrderItemService Items { get; }

        /// <inheritdoc />
        public async Task<PmOrderResponse?> CreateOrderAsync(PmCreateOrderRequest request)
        {
            return await PostAsync<PmOrderResponse, PmCreateOrderRequest>(PmEndpoints.Orders.Base, request);
        }

        /// <inheritdoc />
        public async Task<PmOrderResponse?> GetOrderAsync(string orderId)
        {
            var url = string.Format(PmEndpoints.Orders.Get, orderId);
            return await GetAsync<PmOrderResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmListOrdersResponse?> ListOrdersAsync(
            string? code = null,
            string? status = null,
            string? customerId = null,
            string? createdSince = null,
            string? createdUntil = null,
            int? page = null,
            int? size = null)
        {
            var queryParameters = new List<string>();
            if (!string.IsNullOrEmpty(code)) queryParameters.Add($"code={Uri.EscapeDataString(code)}");
            if (!string.IsNullOrEmpty(status)) queryParameters.Add($"status={Uri.EscapeDataString(status)}");
            if (!string.IsNullOrEmpty(customerId)) queryParameters.Add($"customer_id={Uri.EscapeDataString(customerId)}");
            if (!string.IsNullOrEmpty(createdSince))
                queryParameters.Add($"created_since={Uri.EscapeDataString(createdSince)}");
            if (!string.IsNullOrEmpty(createdUntil))
                queryParameters.Add($"created_until={Uri.EscapeDataString(createdUntil)}");
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            var url = PmEndpoints.Orders.Base;
            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListOrdersResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmOrderResponse?> CloseOrderAsync(string orderId, string status = "closed")
        {
            var url = string.Format(PmEndpoints.Orders.Close, orderId);
            return await PatchAsync<PmOrderResponse, object>(url, new { status });
        }

        /// <inheritdoc />
        public async Task<PmOrderChargeResponse?> AddChargeAsync(string orderId, PmOrderPaymentRequest request)
        {
            var url = string.Format(PmEndpoints.Orders.AddCharge, orderId);
            return await PostAsync<PmOrderChargeResponse, PmOrderPaymentRequest>(url, request);
        }
    }
}



