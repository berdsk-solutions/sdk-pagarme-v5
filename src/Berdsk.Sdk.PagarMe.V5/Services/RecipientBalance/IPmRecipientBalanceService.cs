using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.RecipientBalance.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientBalance
{
    /// <summary>
    ///     Interface para o serviço de consulta de saldo de recebedores.
    /// </summary>
    public interface IPmRecipientBalanceService
    {
        /// <summary>
        ///     Obter saldo do recebedor.
        ///     <see href="https://docs.pagar.me/reference/obter-saldo">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="recipientId">Identificador do recebedor (rp_...)</param>
        /// <returns>Saldo do recebedor</returns>
        Task<PmRecipientBalanceResponse?> GetBalanceAsync(string recipientId);
    }
}