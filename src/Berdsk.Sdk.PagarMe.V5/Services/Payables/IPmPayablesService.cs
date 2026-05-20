using System;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Payables.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Payables
{
    /// <summary>
    ///     Interface para o serviço de recebíveis (Payables).
    ///     <para>Referência: https://docs.pagar.me/reference/retornando-recebíveis.md</para>
    /// </summary>
    public interface IPmPayablesService
    {
        /// <summary>
        ///     Lista os recebíveis com filtros opcionais.
        ///     <para>Referência: https://docs.pagar.me/reference/retornando-recebíveis.md</para>
        /// </summary>
        /// <param name="createdSince">Filtro pela data de criação do payable, como data de partida</param>
        /// <param name="createdUntil">Filtro pela data de criação do payable, como data limite</param>
        /// <param name="status">Filtro pelo status do recebível. `paid` ou `waiting_funds`</param>
        /// <param name="paymentDateSince">Filtro pela data de pagamento do recebível, como data de partida</param>
        /// <param name="paymentDateUntil">Filtro pela data de pagamento do recebível, como data limite</param>
        /// <param name="type">Filtro pelo type do recebível. Pode ser `chargeback`, `refund`, `chargeback_refund` ou `credit`</param>
        /// <param name="updatedSince">Filtro pela data de atualização do recebível, como data de partida</param>
        /// <param name="updatedUntil">Filtro pela data de atualização do recebível, como data limite</param>
        /// <param name="chargeId">Filtro pelo código da cobrança</param>
        /// <param name="recipientId">Filtro pelo código do recebedor</param>
        /// <param name="splitId">Filtro pelo identificador da regra de split</param>
        /// <param name="id">Filtro pelo identificador do recebível</param>
        /// <param name="page">Filtro pela página de retorno</param>
        /// <param name="size">Filtro pela quantidade de objetos retornados. Deve ser menor ou igual a 1000</param>
        /// <returns>Lista de recebíveis e informações de paginação</returns>
        Task<PmListPayablesResponse?> ListPayablesAsync(
            DateTime? createdSince = null,
            DateTime? createdUntil = null,
            string? status = null,
            DateTime? paymentDateSince = null,
            DateTime? paymentDateUntil = null,
            string? type = null,
            DateTime? updatedSince = null,
            DateTime? updatedUntil = null,
            string? chargeId = null,
            string? recipientId = null,
            string? splitId = null,
            string? id = null,
            int? page = null,
            int? size = null);
    }
}