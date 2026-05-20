using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.RecipientAnticipationService.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientAnticipationService
{
    /// <summary>
    ///     Interface para o serviço de antecipações de recebedores.
    /// </summary>
    public interface IPmRecipientAnticipationService
    {
        /// <summary>
        ///     Cria uma antecipação para um recebedor.
        ///     <para>Referência: https://docs.pagar.me/reference/criando-uma-antecipação</para>
        /// </summary>
        /// <param name="recipientId">Identificador do recebedor</param>
        /// <param name="request">Dados da antecipação</param>
        /// <returns>Dados da antecipação criada</returns>
        Task<PmAnticipationResponse?> CreateAnticipationAsync(string recipientId, PmCreateAnticipationRequest request);

        /// <summary>
        ///     Obtém os dados de uma antecipação específica.
        ///     <para>Referência: https://docs.pagar.me/reference/objeto-antecipação</para>
        /// </summary>
        /// <param name="recipientId">Identificador do recebedor</param>
        /// <param name="anticipationId">Identificador da antecipação</param>
        /// <returns>Dados da antecipação</returns>
        Task<PmAnticipationResponse?> GetAnticipationAsync(string recipientId, string anticipationId);

        /// <summary>
        ///     Lista as antecipações de um recebedor.
        ///     <para>Referência: https://docs.pagar.me/reference/retornando-antecipações</para>
        /// </summary>
        /// <param name="recipientId">Identificador do recebedor</param>
        /// <param name="page">Número da página</param>
        /// <param name="count">Quantidade de registros por página (máximo 1000)</param>
        /// <param name="id">ID da antecipação procurada</param>
        /// <param name="paymentDate">Data de pagamento procurada</param>
        /// <param name="amount">Filtro de amount</param>
        /// <returns>Lista de antecipações</returns>
        Task<List<PmAnticipationResponse>?> ListAnticipationsAsync(string recipientId, int? page = null,
            int? count = null, string? id = null, string? paymentDate = null, long? amount = null);

        /// <summary>
        ///     Simula uma antecipação spot para um recebedor.
        ///     <para>Referência: https://docs.pagar.me/reference/simulando-uma-antecipação-spot</para>
        /// </summary>
        /// <param name="recipientId">Identificador do recebedor</param>
        /// <param name="request">Dados para simulação</param>
        /// <returns>Dados da simulação</returns>
        Task<PmAnticipationSimulationResponse?> SimulateAnticipationAsync(string recipientId,
            PmSimulateAnticipationRequest request);

        /// <summary>
        ///     Obtém os limites máximos e mínimos de antecipação que um recebedor pode fazer.
        ///     <para>Referência: https://docs.pagar.me/reference/obtendo-os-limites-de-antecipação</para>
        /// </summary>
        /// <param name="recipientId">Identificador do recebedor</param>
        /// <param name="paymentDate">Data de pagamento desejada para a antecipação</param>
        /// <param name="timeframe">Define o período de onde os recebíveis serão escolhidos (start ou end)</param>
        /// <returns>Limites de antecipação</returns>
        Task<PmAnticipationLimitsResponse?> GetAnticipationLimitsAsync(string recipientId, DateTime paymentDate,
            string timeframe);

        /// <summary>
        ///     Cancela uma antecipação com status pending.
        ///     <para>Referência: https://docs.pagar.me/reference/cancelando-uma-antecipação-pending</para>
        /// </summary>
        /// <param name="recipientId">Identificador do recebedor</param>
        /// <param name="anticipationId">Identificador da antecipação</param>
        /// <returns>Dados da antecipação cancelada</returns>
        Task<PmAnticipationResponse?> CancelAnticipationAsync(string recipientId, string anticipationId);

        /// <summary>
        ///     Atualiza as configurações de antecipação automática de um recebedor.
        ///     <para>Referência: https://docs.pagar.me/reference/atualizar-informações-de-antecipação-automática-1.md</para>
        /// </summary>
        /// <param name="recipientId">Identificador do recebedor</param>
        /// <param name="request">Novas configurações</param>
        /// <returns>Configurações de antecipação atualizadas</returns>
        Task<PmAnticipationSettingsResponse?> UpdateAutomaticAnticipationSettingsAsync(string recipientId,
            PmUpdateAutomaticAnticipationSettingsRequest request);
    }
}