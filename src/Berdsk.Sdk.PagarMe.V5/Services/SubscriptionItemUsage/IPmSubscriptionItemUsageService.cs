using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItemUsage.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItemUsage
{
    /// <summary>
    /// Interface para o serviço de registros de uso de itens de assinatura.
    /// </summary>
    public interface IPmSubscriptionItemUsageService
    {
        /// <summary>
        ///     Inclui o registro de uso de um item de assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/incluir-uso.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="itemId">Identificador do item</param>
        /// <param name="request">Dados do uso</param>
        /// <returns>Dados do uso criado</returns>
        Task<PmSubscriptionItemUsageResponse?> CreateUsageAsync(string subscriptionId, string itemId, PmCreateSubscriptionItemUsageRequest request);

        /// <summary>
        ///     Lista os registros de uso de um item de assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/listar-uso.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="itemId">Identificador do item</param>
        /// <param name="page">Número da página</param>
        /// <param name="size">Quantidade de registros por página</param>
        /// <returns>Lista de usos</returns>
        Task<PmListSubscriptionItemUsagesResponse?> ListUsagesAsync(string subscriptionId, string itemId, int? page = null, int? size = null);

        /// <summary>
        ///     Remove um registro de uso de um item de assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/remover-uso.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="itemId">Identificador do item</param>
        /// <param name="usageId">Identificador do uso</param>
        /// <returns>Dados do uso removido</returns>
        Task<PmSubscriptionItemUsageResponse?> DeleteUsageAsync(string subscriptionId, string itemId, string usageId);
    }
}


