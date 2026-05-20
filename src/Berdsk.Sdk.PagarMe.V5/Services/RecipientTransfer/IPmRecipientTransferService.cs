using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.RecipientTransfer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientTransfer
{
    /// <summary>
    ///     Interface para o serviço de gerenciamento de configurações de transferência de recebedores na Pagar.me v5.
    /// </summary>
    public interface IPmRecipientTransferService
    {
        /// <summary>
        ///     Rota para atualizar as informações de transferência de um recebedor.
        ///     <see href="https://docs.pagar.me/reference/atualizar-informações-de-transferência-1">Documentação Oficial PagarMe</see>
        /// </summary>
        Task<PmRecipientResponse?> UpdateTransferSettingsAsync(string recipientId,
            PmUpdateTransferSettingsRequest request);
    }
}