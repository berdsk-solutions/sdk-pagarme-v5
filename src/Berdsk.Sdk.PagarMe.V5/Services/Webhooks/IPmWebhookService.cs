using System;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Webhooks.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Webhooks
{
    /// <summary>
    ///     Interface para o serviço de webhooks.
    /// </summary>
    public interface IPmWebhookService
    {
        /// <summary>
        ///     Lista os webhooks enviados.
        /// </summary>
        /// <param name="status">Status do webhook ('pending', 'sent' ou 'failed').</param>
        /// <param name="webhookEvent">Nome do evento do webhook.</param>
        /// <param name="createdSince">Data de início do período de criação.</param>
        /// <param name="createdUntil">Data final do período de criação.</param>
        /// <param name="page">Número da página.</param>
        /// <param name="size">Quantidade de itens por página.</param>
        /// <returns>Uma lista paginada de webhooks.</returns>
        /// <remarks>
        ///     Referência: https://docs.pagar.me/reference/listar-webhooks.md
        /// </remarks>
        Task<PmListWebhooksResponse?> ListWebhooksAsync(
            string status = null,
            string webhookEvent = null,
            DateTime? createdSince = null,
            DateTime? createdUntil = null,
            int? page = null,
            int? size = null);

        /// <summary>
        ///     Obtém os detalhes de um webhook específico.
        /// </summary>
        /// <param name="hookId">Código do webhook.</param>
        /// <returns>Os detalhes do webhook.</returns>
        /// <remarks>
        ///     Referência: https://docs.pagar.me/reference/obter-webhook.md
        /// </remarks>
        Task<PmWebhookResponse?> GetWebhookAsync(string hookId);

        /// <summary>
        ///     Tenta reenviar um webhook que falhou ou que se deseja processar novamente.
        /// </summary>
        /// <param name="hookId">Código do webhook.</param>
        /// <returns>Um objeto vazio em caso de sucesso.</returns>
        /// <remarks>
        ///     Referência: https://docs.pagar.me/reference/enviar-webhook.md
        /// </remarks>
        Task<object?> RetryWebhookAsync(string hookId);
    }
}