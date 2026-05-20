using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionCycle.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionCycle
{
    /// <summary>
    /// Interface para o serviço de ciclos de assinatura.
    /// </summary>
    public interface IPmSubscriptionCycleService
    {
        /// <summary>
        ///     Lista os ciclos de uma assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/listar-ciclos-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="page">Número da página</param>
        /// <param name="size">Quantidade de registros por página</param>
        /// <returns>Lista de ciclos</returns>
        Task<PmListSubscriptionCyclesResponse?> ListSubscriptionCyclesAsync(string subscriptionId, int? page = null, int? size = null);

        /// <summary>
        ///     Obtém os dados de um ciclo específico.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-ciclo-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="cycleId">Identificador do ciclo</param>
        /// <returns>Dados do ciclo</returns>
        Task<PmSubscriptionCycleResponse?> GetSubscriptionCycleAsync(string subscriptionId, string cycleId);

        /// <summary>
        ///     Renova o ciclo atual da assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/renovar-ciclo-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <returns>Dados do ciclo renovado</returns>
        Task<PmSubscriptionCycleResponse?> RenewSubscriptionCycleAsync(string subscriptionId);
    }
}


