using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Charge.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Charge
{
    public class PmChargeService : PmBaseService, IPmChargeService
    {
        public PmChargeService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmChargeResponse?> GetChargeAsync(string chargeId)
        {
            var url = string.Format(PmEndpoints.Charges.Get, chargeId);
            return await GetAsync<PmChargeResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmListChargesResponse?> ListChargesAsync(
            string? code = null,
            string? status = null,
            string? paymentMethod = null,
            string? customerId = null,
            string? orderId = null,
            string? createdSince = null,
            string? createdUntil = null,
            int? page = null,
            int? size = null)
        {
            var queryParameters = new List<string>();
            if (!string.IsNullOrEmpty(code)) queryParameters.Add($"code={Uri.EscapeDataString(code)}");
            if (!string.IsNullOrEmpty(status)) queryParameters.Add($"status={Uri.EscapeDataString(status)}");
            if (!string.IsNullOrEmpty(paymentMethod))
                queryParameters.Add($"payment_method={Uri.EscapeDataString(paymentMethod)}");
            if (!string.IsNullOrEmpty(customerId))
                queryParameters.Add($"customer_id={Uri.EscapeDataString(customerId)}");
            if (!string.IsNullOrEmpty(orderId)) queryParameters.Add($"order_id={Uri.EscapeDataString(orderId)}");
            if (!string.IsNullOrEmpty(createdSince))
                queryParameters.Add($"created_since={Uri.EscapeDataString(createdSince)}");
            if (!string.IsNullOrEmpty(createdUntil))
                queryParameters.Add($"created_until={Uri.EscapeDataString(createdUntil)}");
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            var url = PmEndpoints.Charges.Base;
            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListChargesResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmChargeResponse?> CaptureChargeAsync(string chargeId, PmCaptureChargeRequest request)
        {
            var url = string.Format(PmEndpoints.Charges.Capture, chargeId);
            return await PostAsync<PmChargeResponse, PmCaptureChargeRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmChargeResponse?> CaptureChargeWithSplitAsync(string chargeId,
            PmCaptureChargeSplitRequest request)
        {
            var url = string.Format(PmEndpoints.Charges.Capture, chargeId);
            return await PostAsync<PmChargeResponse, PmCaptureChargeSplitRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmChargeResponse?> UpdateChargeCardAsync(string chargeId, PmUpdateChargeCardRequest request)
        {
            var url = string.Format(PmEndpoints.Charges.UpdateCard, chargeId);
            return await PatchAsync<PmChargeResponse, PmUpdateChargeCardRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmChargeResponse?> UpdateChargeDueDateAsync(string chargeId,
            PmUpdateChargeDueDateRequest request)
        {
            var url = string.Format(PmEndpoints.Charges.UpdateDueDate, chargeId);
            return await PatchAsync<PmChargeResponse, PmUpdateChargeDueDateRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmChargeResponse?> UpdateChargePaymentMethodAsync(string chargeId,
            PmUpdateChargePaymentMethodRequest request)
        {
            var url = string.Format(PmEndpoints.Charges.UpdatePaymentMethod, chargeId);
            return await PatchAsync<PmChargeResponse, PmUpdateChargePaymentMethodRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmChargeResponse?> CancelChargeAsync(string chargeId, int? amount = null)
        {
            var url = string.Format(PmEndpoints.Charges.Cancel, chargeId);
            object? request = amount.HasValue ? new { amount } : null;
            return await DeleteAsync<PmChargeResponse>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmChargeResponse?> CancelChargeWithSplitAsync(string chargeId,
            PmCancelChargeSplitRequest request)
        {
            var url = string.Format(PmEndpoints.Charges.Cancel, chargeId);
            return await DeleteAsync<PmChargeResponse>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmChargeResponse?> RetryChargeAsync(string chargeId)
        {
            var url = string.Format(PmEndpoints.Charges.Retry, chargeId);
            return await PostAsync<PmChargeResponse, object>(url, new { });
        }

        /// <inheritdoc />
        public async Task<PmChargeResponse?> ConfirmCashChargeAsync(string chargeId)
        {
            var url = string.Format(PmEndpoints.Charges.ConfirmCash, chargeId);
            return await PostAsync<PmChargeResponse, object>(url, new { });
        }
    }
}