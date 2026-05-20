using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionIncrement.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionIncrement
{
    /// <summary>
    ///     Interface para o serviço de acréscimos (incrementos) de assinatura.
    /// </summary>
    public interface IPmSubscriptionIncrementService
    {
        /// <summary>
        ///     Inclui um incremento em uma assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/incluir-incremento-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="request">Dados do incremento</param>
        /// <returns>Dados do incremento criado</returns>
        Task<PmSubscriptionIncrementResponse?> CreateSubscriptionIncrementAsync(string subscriptionId,
            PmCreateSubscriptionIncrementRequest request);

        /// <summary>
        ///     Obtém os dados de um incremento específico de uma assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-incremento-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="incrementId">Identificador do incremento</param>
        /// <returns>Dados do incremento</returns>
        Task<PmSubscriptionIncrementResponse?> GetSubscriptionIncrementAsync(string subscriptionId, string incrementId);

        /// <summary>
        ///     Lista os incrementos de uma assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/listar-incrementos-2.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="page">Número da página</param>
        /// <param name="size">Quantidade de registros por página</param>
        /// <returns>Lista de incrementos</returns>
        Task<PmListSubscriptionIncrementsResponse?> ListSubscriptionIncrementsAsync(string subscriptionId,
            int? page = null, int? size = null);

        /// <summary>
        ///     Remove um incremento de uma assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/remover-incremento-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="incrementId">Identificador do incremento</param>
        /// <returns>Dados do incremento removido</returns>
        Task<PmSubscriptionIncrementResponse?> DeleteSubscriptionIncrementAsync(string subscriptionId,
            string incrementId);
    }
}