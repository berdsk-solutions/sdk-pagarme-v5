using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.CardBin.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.CardBin
{
    /// <summary>
    ///     Interface para o serviço de BIN de cartão.
    /// </summary>
    public interface IPmBinService
    {
        /// <summary>
        ///     Obtém informações sobre o BIN do cartão.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-informações-do-bin.md</para>
        /// </summary>
        /// <param name="bin">Bank Identifier Number (primeiros 6 dígitos do cartão)</param>
        /// <returns>Informações do BIN</returns>
        Task<PmBinResponse?> GetBinAsync(string bin);
    }
}