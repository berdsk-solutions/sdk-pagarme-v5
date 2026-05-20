using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Cards
{
    public class PmCardService : PmBaseService, IPmCardService
    {
        public PmCardService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmCardResponse?> CreateCardAsync(string customerId, PmCreateCardRequest request)
        {
            var url = string.Format(PmEndpoints.Cards.Base, customerId);
            return await PostAsync<PmCardResponse, PmCreateCardRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmCardResponse?> GetCardAsync(string customerId, string cardId)
        {
            var url = string.Format(PmEndpoints.Cards.Get, customerId, cardId);
            return await GetAsync<PmCardResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmListCardsResponse?> ListCardsAsync(string customerId, int? page = null, int? size = null)
        {
            var url = string.Format(PmEndpoints.Cards.Base, customerId);
            var queryParameters = new List<string>();
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListCardsResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmCardResponse?> UpdateCardAsync(string customerId, string cardId,
            PmUpdateCardRequest request)
        {
            var url = string.Format(PmEndpoints.Cards.Update, customerId, cardId);
            return await PutAsync<PmCardResponse, PmUpdateCardRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmCardResponse?> DeleteCardAsync(string customerId, string cardId)
        {
            var url = string.Format(PmEndpoints.Cards.Delete, customerId, cardId);
            return await DeleteAsync<PmCardResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmCardResponse?> RenewCardAsync(string customerId, string cardId)
        {
            var url = string.Format(PmEndpoints.Cards.Renew, customerId, cardId);
            return await PostAsync<PmCardResponse, object>(url, new { });
        }

        /// <inheritdoc />
        public async Task<PmCardTokenResponse?> CreateCardTokenAsync(string publicKey, PmCreateCardTokenRequest request)
        {
            var url = $"{PmEndpoints.Tokens.Base}?appId={publicKey}";
            return await PostAsync<PmCardTokenResponse, PmCreateCardTokenRequest>(url, request);
        }
    }
}