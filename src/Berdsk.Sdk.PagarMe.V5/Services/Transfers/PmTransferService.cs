using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Berdsk.Sdk.PagarMe.V5.Services.Transfers.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Transfers
{
    /// <summary>
    ///     Serviço para gerenciamento de transferências.
    /// </summary>
    public class PmTransferService : PmBaseService, IPmTransferService
    {
        public PmTransferService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmTransferResponse?> CreateTransferAsync(PmCreateTransferRequest request, string? idempotencyKey = null)
        {
            var headers = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(idempotencyKey))
            {
                headers.Add("Idempotency-Key", idempotencyKey);
            }

            return await PostAsync<PmTransferResponse, PmCreateTransferRequest>(PmEndpoints.Transfers.Base, request, headers);
        }

        /// <inheritdoc />
        public async Task<PmListTransfersResponse?> ListTransfersAsync(
            int? count = null,
            string? cursor = null,
            string? bankAccountId = null,
            long? amount = null,
            string? recipientId = null,
            string? id = null,
            string? dateCreated = null)
        {
            var queryParameters = new List<string>();

            if (count.HasValue) queryParameters.Add($"count={count.Value}");
            if (!string.IsNullOrEmpty(cursor)) queryParameters.Add($"cursor={cursor}");
            if (!string.IsNullOrEmpty(bankAccountId)) queryParameters.Add($"bank_account_id={bankAccountId}");
            if (amount.HasValue) queryParameters.Add($"amount={amount.Value}");
            if (!string.IsNullOrEmpty(recipientId)) queryParameters.Add($"recipient_id={recipientId}");
            if (!string.IsNullOrEmpty(id)) queryParameters.Add($"id={id}");
            if (!string.IsNullOrEmpty(dateCreated)) queryParameters.Add($"date_created={dateCreated}");

            var url = PmEndpoints.Transfers.Base;
            if (queryParameters.Count > 0)
            {
                url += "?" + string.Join("&", queryParameters);
            }

            return await GetAsync<PmListTransfersResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmTransferResponse?> GetTransferAsync(string transferId)
        {
            var url = string.Format(PmEndpoints.Transfers.Get, transferId);
            return await GetAsync<PmTransferResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmTransferResponse?> CancelTransferAsync(string transferId)
        {
            var url = string.Format(PmEndpoints.Transfers.Get, transferId);
            return await DeleteAsync<PmTransferResponse>(url);
        }

        /// <inheritdoc />
        public async Task<object?> GetTransferReceiptAsync(string transferId)
        {
            var url = string.Format(PmEndpoints.Transfers.Receipt, transferId);
            // O MD diz que é POST
            return await PostAsync<object, object>(url, new { });
        }
    }
}


