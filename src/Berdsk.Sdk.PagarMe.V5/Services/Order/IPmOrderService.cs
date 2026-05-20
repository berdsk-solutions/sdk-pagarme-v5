using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.OrderItem;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order
{
    /// <summary>
    /// Interface para o serviço de pedidos.
    /// </summary>
    public interface IPmOrderService
    {
        /// <summary>
        /// Serviço de itens do pedido.
        /// </summary>
        IPmOrderItemService Items { get; }

        /// <summary>
        ///     Cria um pedido.
        ///     <para>Referência: https://docs.pagar.me/reference/criar-pedido-2.md</para>
        ///     <para>Multimeios: https://docs.pagar.me/reference/criar-pedido-multimeios.md</para>
        ///     <para>Multicompradores: https://docs.pagar.me/reference/criar-pedido-multicompradores.md</para>
        /// </summary>
        /// <param name="request">Dados do pedido</param>
        /// <returns>Dados do pedido criado</returns>
        Task<PmOrderResponse?> CreateOrderAsync(PmCreateOrderRequest request);

        /// <summary>
        ///     Obtém os dados de um pedido.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-pedido.md</para>
        /// </summary>
        /// <param name="orderId">Identificador do pedido (or_xxxxxxxxxxxxxxxx)</param>
        /// <returns>Dados do pedido</returns>
        Task<PmOrderResponse?> GetOrderAsync(string orderId);

        /// <summary>
        ///     Lista os pedidos com filtros opcionais.
        ///     <para>Referência: https://docs.pagar.me/reference/listar-pedidos.md</para>
        /// </summary>
        /// <param name="code">código de referência do pedido</param>
        /// <param name="status">Status do pedido (pending, paid, canceled, failed)</param>
        /// <param name="customerId">código do cliente</param>
        /// <param name="createdSince">Data de início (YYYY-MM-DD)</param>
        /// <param name="createdUntil">Data de fim (YYYY-MM-DD)</param>
        /// <param name="page">página atual</param>
        /// <param name="size">Quantidade de itens</param>
        /// <returns>Lista de pedidos</returns>
        Task<PmListOrdersResponse?> ListOrdersAsync(
            string? code = null,
            string? status = null,
            string? customerId = null,
            string? createdSince = null,
            string? createdUntil = null,
            int? page = null,
            int? size = null);

        /// <summary>
        ///     Fecha um pedido aberto.
        ///     <para>Referência: https://docs.pagar.me/reference/fechar-um-pedido.md</para>
        /// </summary>
        /// <param name="orderId">Identificador do pedido</param>
        /// <param name="status">Status para fechamento (Geralmente 'closed')</param>
        /// <returns>Dados do pedido fechado</returns>
        Task<PmOrderResponse?> CloseOrderAsync(string orderId, string status = "closed");

        /// <summary>
        ///     Inclui uma nova cobrança em um pedido aberto.
        ///     <para>Referência: https://docs.pagar.me/reference/incluir-cobrança-no-pedido.md</para>
        /// </summary>
        /// <param name="orderId">Identificador do pedido</param>
        /// <param name="request">Dados da cobrança</param>
        /// <returns>Dados da cobrança criada</returns>
        Task<PmOrderChargeResponse?> AddChargeAsync(string orderId, PmOrderPaymentRequest request);
    }
}


