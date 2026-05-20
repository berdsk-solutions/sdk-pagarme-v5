using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.RecipientBankAccount.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientBankAccount
{
    /// <summary>
    ///     Interface para o serviço de contas bancárias de recebedores.
    /// </summary>
    public interface IPmRecipientBankAccountService
    {
        /// <summary>
        ///     Atualiza a conta bancária padrão de um recebedor.
        ///     <para>Referência: https://docs.pagar.me/reference/atualizar-conta-bancária-do-recebedor-1.md</para>
        /// </summary>
        /// <param name="recipientId">ID do recebedor.</param>
        /// <param name="request">Dados da nova conta bancária.</param>
        /// <returns>Detalhes do recebedor com a conta atualizada.</returns>
        Task<PmRecipientResponse?> UpdateBankAccountAsync(string recipientId,
            PmUpdateRecipientBankAccountRequest request);
    }
}