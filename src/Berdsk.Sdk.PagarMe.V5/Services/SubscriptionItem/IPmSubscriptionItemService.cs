using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItem.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItem
{
    /// <summary>
    ///     Interface para o serviço de itens de assinatura.
    /// </summary>
    public interface IPmSubscriptionItemService
    {
        /// <summary>
        ///     Inclui um item em uma assinatura.
        ///     <see href="https://docs.pagar.me/reference/incluir-item-1">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="request">Dados do item</param>
        /// <returns>Dados do item criado</returns>
        Task<PmSubscriptionItemResponse?> CreateSubscriptionItemAsync(string subscriptionId,
            PmCreateSubscriptionItemRequestDto request);

        /// <summary>
        ///     Obtém os dados de um item específico de uma assinatura.
        ///     <see href="https://docs.pagar.me/reference/obter-item-da-assinatura.md">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="itemId">Identificador do item (si_xxxxxxxxxxxxxxxx)</param>
        /// <returns>Dados do item</returns>
        Task<PmSubscriptionItemResponse?> GetSubscriptionItemAsync(string subscriptionId, string itemId);

        /// <summary>
        ///     Lista os itens de uma assinatura.
        ///     <see href="https://docs.pagar.me/reference/listar-itens-de-uma-assinatura.md">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="page">número da página</param>
        /// <param name="size">Quantidade de registros por página</param>
        /// <param name="name">Filtro por nome</param>
        /// <param name="code">Filtro por código</param>
        /// <param name="status">Filtro por status</param>
        /// <returns>Lista de itens</returns>
        Task<PmListSubscriptionItemsResponse?> ListSubscriptionItemsAsync(string subscriptionId, int? page = null,
            int? size = null, string? name = null, string? code = null, string? status = null);

        /// <summary>
        ///     Edita um item de uma assinatura.
        ///     <see href="https://docs.pagar.me/reference/editar-item.md">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="itemId">Identificador do item</param>
        /// <param name="request">Dados para atualização</param>
        /// <returns>Dados do item atualizado</returns>
        Task<PmSubscriptionItemResponse?> UpdateSubscriptionItemAsync(string subscriptionId, string itemId,
            PmUpdateSubscriptionItemRequest request);

        /// <summary>
        ///     Remove um item de uma assinatura.
        ///     <see href="https://docs.pagar.me/reference/remover-item.md">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="itemId">Identificador do item</param>
        /// <returns>Dados do item removido</returns>
        Task<PmSubscriptionItemResponse?> DeleteSubscriptionItemAsync(string subscriptionId, string itemId);
    }
}