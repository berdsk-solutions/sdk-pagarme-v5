using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Transfers.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Transfers
{
    /// <summary>
    /// Interface para o serviço de transferências.
    /// </summary>
    public interface IPmTransferService
    {
        /// <summary>
        ///     Realiza uma transferência para uma conta bancária previamente criada ou para um recebedor.
        ///     <para>Referência: https://docs.pagar.me/reference/criando-uma-transferência</para>
        /// </summary>
        Task<PmTransferResponse?> CreateTransferAsync(PmCreateTransferRequest request, string? idempotencyKey = null);

        /// <summary>
        ///     Retorna os dados de todas as transferências previamente realizadas.
        ///     <para>Referência: https://docs.pagar.me/reference/retornando-transferências</para>
        /// </summary>
        Task<PmListTransfersResponse?> ListTransfersAsync(
            int? count = null,
            string? cursor = null,
            string? bankAccountId = null,
            long? amount = null,
            string? recipientId = null,
            string? id = null,
            string? dateCreated = null);

        /// <summary>
        ///     Obtém os dados de uma transferência específica pelo ID.
        ///     <para>Referência: https://docs.pagar.me/reference/retornando-uma-transferência</para>
        /// </summary>
        Task<PmTransferResponse?> GetTransferAsync(string transferId);

        /// <summary>
        ///     Cancela uma transferência que ainda não foi processada (status pending_transfer).
        ///     <para>Referência: https://docs.pagar.me/reference/cancelando-uma-transferência</para>
        /// </summary>
        Task<PmTransferResponse?> CancelTransferAsync(string transferId);

        /// <summary>
        ///     Retorna o comprovante de uma transferência realizada com sucesso (status transferred).
        ///     <para>Referência: https://docs.pagar.me/reference/retornando-o-comprovante-de-uma-transferência</para>
        /// </summary>
        Task<object?> GetTransferReceiptAsync(string transferId);
    }
}