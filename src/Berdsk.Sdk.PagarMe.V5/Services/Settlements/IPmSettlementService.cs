using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Settlements.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Settlements
{
    /// <summary>
    ///     Interface para o serviço de liquidações (Settlements).
    /// </summary>
    public interface IPmSettlementService
    {
        /// <summary>
        ///     Lista os pagamentos (Settlements) de um recebedor.
        ///     <see href="https://docs.pagar.me/reference/retornando-pagamentos">Documentação Oficial PagarMe</see>
        /// </summary>
        Task<PmListSettlementsResponse?> ListSettlementsAsync(
            string paymentDateStart,
            string paymentDateEnd,
            string? liquidationArrangementId = null,
            int? page = null,
            int? limit = null,
            bool? getIspb = null,
            string? settlementId = null,
            string? externalEnginePaymentId = null,
            string? order = null);

        /// <summary>
        ///     Lista os pagamentos (Settlements) de um recebedor específico.
        ///     <see href="https://docs.pagar.me/reference/retornando-pagamentos-por-recebedor">Documentação Oficial PagarMe</see>
        /// </summary>
        Task<PmListSettlementsResponse?> ListRecipientSettlementsAsync(string recipientId, string paymentDateStart,
            string paymentDateEnd);

        /// <summary>
        ///     Obtém um pagamento específico pelo ID.
        ///     <see href="https://docs.pagar.me/reference/retornando-um-pagamento">Documentação Oficial PagarMe</see>
        /// </summary>
        Task<PmSettlementResponse?> GetSettlementAsync(string settlementId);
    }
}