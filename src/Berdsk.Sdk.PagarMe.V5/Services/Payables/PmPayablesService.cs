using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Payables.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Payables
{
    /// <inheritdoc />
    public class PmPayablesService : PmBaseService, IPmPayablesService
    {
        public PmPayablesService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmListPayablesResponse?> ListPayablesAsync(
            DateTime? createdSince = null,
            DateTime? createdUntil = null,
            string? status = null,
            DateTime? paymentDateSince = null,
            DateTime? paymentDateUntil = null,
            string? type = null,
            DateTime? updatedSince = null,
            DateTime? updatedUntil = null,
            string? chargeId = null,
            string? recipientId = null,
            string? splitId = null,
            string? id = null,
            int? page = null,
            int? size = null)
        {
            var queryParameters = new List<string>();
            if (createdSince.HasValue) queryParameters.Add($"created_since={createdSince.Value:yyyy-MM-dd}");
            if (createdUntil.HasValue) queryParameters.Add($"created_until={createdUntil.Value:yyyy-MM-dd}");
            if (!string.IsNullOrEmpty(status)) queryParameters.Add($"status={status}");
            if (paymentDateSince.HasValue)
                queryParameters.Add($"payment_date_since={paymentDateSince.Value:yyyy-MM-dd}");
            if (paymentDateUntil.HasValue)
                queryParameters.Add($"payment_date_until={paymentDateUntil.Value:yyyy-MM-dd}");
            if (!string.IsNullOrEmpty(type)) queryParameters.Add($"type={type}");
            if (updatedSince.HasValue) queryParameters.Add($"updated_since={updatedSince.Value:yyyy-MM-dd}");
            if (updatedUntil.HasValue) queryParameters.Add($"updated_until={updatedUntil.Value:yyyy-MM-dd}");
            if (!string.IsNullOrEmpty(chargeId)) queryParameters.Add($"charge_id={chargeId}");
            if (!string.IsNullOrEmpty(recipientId)) queryParameters.Add($"recipient_id={recipientId}");
            if (!string.IsNullOrEmpty(splitId)) queryParameters.Add($"split_id={splitId}");
            if (!string.IsNullOrEmpty(id)) queryParameters.Add($"id={id}");
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            var url = PmEndpoints.Payables.Base;
            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListPayablesResponse>(url);
        }
    }
}