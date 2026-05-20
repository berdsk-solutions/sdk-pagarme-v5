using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Settlements.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Settlements
{
    /// <summary>
    /// Interface para o serviço de liquidações (Settlements).
    /// </summary>
    public interface IPmSettlementService
    {
        /// <summary>
        ///     Lista os pagamentos (Settlements) de um recebedor.
        ///     <para>Referência: https://docs.pagar.me/reference/retornando-pagamentos</para>
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
        ///     <para>Referência: https://docs.pagar.me/reference/retornando-pagamentos-por-recebedor</para>
        /// </summary>
        Task<PmListSettlementsResponse?> ListRecipientSettlementsAsync(string recipientId, string paymentDateStart, string paymentDateEnd);

        /// <summary>
        ///     Obtém um pagamento específico pelo ID.
        ///     <para>Referência: https://docs.pagar.me/reference/retornando-um-pagamento</para>
        /// </summary>
        Task<PmSettlementResponse?> GetSettlementAsync(string settlementId);
    }
}


