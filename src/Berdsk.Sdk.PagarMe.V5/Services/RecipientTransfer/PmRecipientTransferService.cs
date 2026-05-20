using System.Threading.Tasks;
using System.Net.Http;
using Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.RecipientTransfer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientTransfer
{
    /// <summary>
    ///     Serviço para gerenciamento de configurações de transferência de recebedores na Pagar.me v5.
    /// </summary>
    /// <inheritdoc />
    public class PmRecipientTransferService : PmBaseService, IPmRecipientTransferService
    {
        public PmRecipientTransferService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmRecipientResponse?> UpdateTransferSettingsAsync(string recipientId,
            PmUpdateTransferSettingsRequest request)
        {
            var url = string.Format(PmEndpoints.Recipients.UpdateTransferSettings, recipientId);
            return await PatchAsync<PmRecipientResponse, PmUpdateTransferSettingsRequest>(url, request);
        }
    }
}


