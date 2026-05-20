using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.RecipientBankAccount.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientBankAccount
{
    /// <inheritdoc />
    public class PmRecipientBankAccountService : PmBaseService, IPmRecipientBankAccountService
    {
        public PmRecipientBankAccountService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmRecipientResponse?> UpdateBankAccountAsync(string recipientId,
            PmUpdateRecipientBankAccountRequest request)
        {
            var url = string.Format(PmEndpoints.RecipientBankAccounts.Update, recipientId);
            return await PatchAsync<PmRecipientResponse, PmUpdateRecipientBankAccountRequest>(url, request);
        }
    }
}