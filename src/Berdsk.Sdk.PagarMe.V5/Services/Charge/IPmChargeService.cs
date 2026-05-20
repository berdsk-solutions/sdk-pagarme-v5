using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Charge.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Charge
{
    /// <summary>
    ///     Interface para o serviço de cobranças.
    /// </summary>
    public interface IPmChargeService
    {
        /// <summary>
        ///     Obtém os dados de uma cobrança.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-cobrança.md</para>
        /// </summary>
        /// <param name="chargeId">Identificador da cobrança (ch_xxxxxxxxxxxxxxxx)</param>
        /// <returns>Dados da cobrança</returns>
        Task<PmChargeResponse?> GetChargeAsync(string chargeId);

        /// <summary>
        ///     Lista as cobranças com filtros opcionais.
        ///     <para>Referência: https://docs.pagar.me/reference/listar-cobranças.md</para>
        /// </summary>
        /// <param name="code">código de referência da cobrança</param>
        /// <param name="status">Status da cobrança</param>
        /// <param name="paymentMethod">Método de pagamento</param>
        /// <param name="customerId">código do cliente</param>
        /// <param name="orderId">código do pedido</param>
        /// <param name="createdSince">Data de início (YYYY-MM-DD)</param>
        /// <param name="createdUntil">Data de fim (YYYY-MM-DD)</param>
        /// <param name="page">página atual</param>
        /// <param name="size">Quantidade de itens</param>
        /// <returns>Lista de cobranças</returns>
        Task<PmListChargesResponse?> ListChargesAsync(
            string? code = null,
            string? status = null,
            string? paymentMethod = null,
            string? customerId = null,
            string? orderId = null,
            string? createdSince = null,
            string? createdUntil = null,
            int? page = null,
            int? size = null);

        /// <summary>
        ///     Captura uma cobrança com status "authorized".
        ///     <para>Referência: https://docs.pagar.me/reference/capturar-cobrança.md</para>
        /// </summary>
        /// <param name="chargeId">Identificador da cobrança</param>
        /// <param name="request">Dados para captura</param>
        /// <returns>Dados da cobrança capturada</returns>
        Task<PmChargeResponse?> CaptureChargeAsync(string chargeId, PmCaptureChargeRequest request);

        /// <summary>
        ///     Captura uma cobrança com regras de split.
        ///     <para>Referência: https://docs.pagar.me/reference/capturar-cobrança-com-split-1.md</para>
        /// </summary>
        /// <param name="chargeId">Identificador da cobrança</param>
        /// <param name="request">Dados para captura com split</param>
        /// <returns>Dados da cobrança capturada</returns>
        Task<PmChargeResponse?> CaptureChargeWithSplitAsync(string chargeId, PmCaptureChargeSplitRequest request);

        /// <summary>
        ///     Edita o cartão de crédito de uma cobrança com status "pending".
        ///     <para>Referência: https://docs.pagar.me/reference/editar-cartão-de-cobrança.md</para>
        /// </summary>
        /// <param name="chargeId">Identificador da cobrança</param>
        /// <param name="request">Dados do novo cartão</param>
        /// <returns>Dados da cobrança atualizada</returns>
        Task<PmChargeResponse?> UpdateChargeCardAsync(string chargeId, PmUpdateChargeCardRequest request);

        /// <summary>
        ///     Edita a data de vencimento de uma cobrança com status "pending".
        ///     <para>Referência: https://docs.pagar.me/reference/editar-data-de-vencimento-da-cobrança.md</para>
        /// </summary>
        /// <param name="chargeId">Identificador da cobrança</param>
        /// <param name="request">Nova data de vencimento</param>
        /// <returns>Dados da cobrança atualizada</returns>
        Task<PmChargeResponse?> UpdateChargeDueDateAsync(string chargeId, PmUpdateChargeDueDateRequest request);

        /// <summary>
        ///     Edita o método de pagamento de uma cobrança com status "pending".
        ///     <para>Referência: https://docs.pagar.me/reference/editar-método-de-pagamento.md</para>
        /// </summary>
        /// <param name="chargeId">Identificador da cobrança</param>
        /// <param name="request">Novo método de pagamento</param>
        /// <returns>Dados da cobrança atualizada</returns>
        Task<PmChargeResponse?> UpdateChargePaymentMethodAsync(string chargeId,
            PmUpdateChargePaymentMethodRequest request);

        /// <summary>
        ///     Cancela uma cobrança.
        ///     <para>Referência: https://docs.pagar.me/reference/cancelar-cobrança.md</para>
        /// </summary>
        /// <param name="chargeId">Identificador da cobrança</param>
        /// <param name="amount">Valor opcional para cancelamento parcial (centavos)</param>
        /// <returns>Dados da cobrança cancelada</returns>
        Task<PmChargeResponse?> CancelChargeAsync(string chargeId, int? amount = null);

        /// <summary>
        ///     Cancela uma cobrança com regras de split.
        ///     <para>Referência: https://docs.pagar.me/reference/cancelar-cobrança-com-split-1.md</para>
        /// </summary>
        /// <param name="chargeId">Identificador da cobrança</param>
        /// <param name="request">Dados para cancelamento com split</param>
        /// <returns>Dados da cobrança cancelada</returns>
        Task<PmChargeResponse?> CancelChargeWithSplitAsync(string chargeId, PmCancelChargeSplitRequest request);

        /// <summary>
        ///     Retenta uma cobrança com falha manualmente.
        ///     <para>Referência: https://docs.pagar.me/reference/retentar-uma-cobrança-manualmente.md</para>
        /// </summary>
        /// <param name="chargeId">Identificador da cobrança</param>
        /// <returns>Dados da cobrança após retentativa</returns>
        Task<PmChargeResponse?> RetryChargeAsync(string chargeId);

        /// <summary>
        ///     Confirma o recebimento de uma cobrança em dinheiro (cash).
        ///     <para>Referência: https://docs.pagar.me/reference/confirmar-cobrança-cash.md</para>
        /// </summary>
        /// <param name="chargeId">Identificador da cobrança</param>
        /// <returns>Dados da cobrança confirmada</returns>
        Task<PmChargeResponse?> ConfirmCashChargeAsync(string chargeId);
    }
}