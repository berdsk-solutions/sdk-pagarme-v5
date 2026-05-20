using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.OrderItem.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.OrderItem
{
    /// <summary>
    ///     Interface para o serviço de itens de pedido.
    /// </summary>
    public interface IPmOrderItemService
    {
        /// <summary>
        ///     Inclui um item em um pedido aberto.
        ///     <para>Referência: https://docs.pagar.me/reference/incluir-item.md</para>
        /// </summary>
        /// <param name="orderId">Identificador do pedido (or_xxxxxxxxxxxxxxxx)</param>
        /// <param name="request">Dados do item</param>
        /// <returns>Dados do item criado</returns>
        Task<PmOrderItemResponse?> CreateOrderItemAsync(string orderId, PmCreateOrderItemRequest request);

        /// <summary>
        ///     Obtém os dados de um item específico de um pedido.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-item-do-pedido.md</para>
        /// </summary>
        /// <param name="orderId">Identificador do pedido</param>
        /// <param name="itemId">Identificador do item (ot_xxxxxxxxxxxxxxxx)</param>
        /// <returns>Dados do item</returns>
        Task<PmOrderItemResponse?> GetOrderItemAsync(string orderId, string itemId);

        /// <summary>
        ///     Edita um item de um pedido aberto.
        ///     <para>Referência: https://docs.pagar.me/reference/editar-item-do-pedido.md</para>
        /// </summary>
        /// <param name="orderId">Identificador do pedido</param>
        /// <param name="itemId">Identificador do item</param>
        /// <param name="request">Dados para atualização</param>
        /// <returns>Dados do item atualizado</returns>
        Task<PmOrderItemResponse?>
            UpdateOrderItemAsync(string orderId, string itemId, PmUpdateOrderItemRequest request);

        /// <summary>
        ///     Deleta um item de um pedido aberto.
        ///     <para>Referência: https://docs.pagar.me/reference/deletar-item.md</para>
        /// </summary>
        /// <param name="orderId">Identificador do pedido</param>
        /// <param name="itemId">Identificador do item</param>
        /// <returns>Dados do item deletado</returns>
        Task<PmOrderItemResponse?> DeleteOrderItemAsync(string orderId, string itemId);

        /// <summary>
        ///     Remove todos os itens de um pedido aberto.
        ///     <para>Referência: https://docs.pagar.me/reference/remover-todos-os-itens.md</para>
        /// </summary>
        /// <param name="orderId">Identificador do pedido</param>
        /// <returns>True se removido com sucesso</returns>
        Task<bool> DeleteAllOrderItemsAsync(string orderId);
    }
}