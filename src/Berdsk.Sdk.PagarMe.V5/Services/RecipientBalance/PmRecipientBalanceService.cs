using System.Threading.Tasks;
using System.Net.Http;
using Berdsk.Sdk.PagarMe.V5.Services.RecipientBalance.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientBalance
{
    /// <inheritdoc />
    public class PmRecipientBalanceService : PmBaseService, IPmRecipientBalanceService
    {
        public PmRecipientBalanceService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmRecipientBalanceResponse?> GetBalanceAsync(string recipientId)
        {
            var url = string.Format(PmEndpoints.Recipients.Balance, recipientId);
            return await GetAsync<PmRecipientBalanceResponse>(url);
        }
    }
}


