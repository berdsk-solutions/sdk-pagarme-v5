using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.RecipientBalance.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientBalance
{
    /// <summary>
    /// Interface para o serviço de consulta de saldo de recebedores.
    /// </summary>
    public interface IPmRecipientBalanceService
    {
        /// <summary>
        ///     Obter saldo do recebedor.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-saldo.md</para>
        /// </summary>
        /// <param name="recipientId">Identificador do recebedor (rp_...)</param>
        /// <returns>Saldo do recebedor</returns>
        Task<PmRecipientBalanceResponse?> GetBalanceAsync(string recipientId);
    }
}


