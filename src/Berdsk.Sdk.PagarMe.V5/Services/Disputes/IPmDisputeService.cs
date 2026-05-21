using System;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Disputes.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Disputes
{
    /// <summary>
    ///     Interface para o serviço de consulta de disputas de chargeback.
    /// </summary>
    /// <remarks>
    ///     <see href="https://docs.pagar.me/reference/get_v1-disputes">Documentação Oficial PagarMe</see>
    /// </remarks>
    public interface IPmDisputeService
    {
        /// <summary>
        ///     Retorna uma lista paginada de disputas com base nos filtros fornecidos.
        /// </summary>
        /// <param name="createdAtLte">Filtrar valores menores ou iguais à data fornecida.</param>
        /// <param name="createdAtGte">Filtrar valores maiores ou iguais à data fornecida.</param>
        /// <param name="status">Filtra pelo status da disputa.</param>
        /// <param name="reasonCode">Filtra pelo código do motivo do chargeback.</param>
        /// <param name="network">Filtra pela bandeira do cartão.</param>
        /// <param name="forwardCursor">Identificador para avançar na paginação.</param>
        /// <param name="limit">Número máximo de registros a serem retornados (padrão 5, máximo 100).</param>
        /// <returns>Uma lista paginada de disputas.</returns>
        /// <remarks>
        ///     <see href="https://docs.pagar.me/reference/get_v1-disputes">Documentação Oficial PagarMe</see>
        /// </remarks>
        Task<PmListDisputesResponse> ListDisputesAsync(
            DateTime? createdAtLte = null,
            DateTime? createdAtGte = null,
            string status = null,
            int? reasonCode = null,
            string network = null,
            string forwardCursor = null,
            int? limit = null);

        /// <summary>
        ///     Consulta uma disputa específica.
        /// </summary>
        /// <param name="disputeId">ID único da disputa.</param>
        /// <returns>Os detalhes da disputa.</returns>
        /// <remarks>
        ///     <see href="https://docs.pagar.me/reference/get_v1-disputes-dispute-id">Documentação Oficial PagarMe</see>
        /// </remarks>
        Task<PmDisputeResponse> GetDisputeAsync(string disputeId);
    }
}