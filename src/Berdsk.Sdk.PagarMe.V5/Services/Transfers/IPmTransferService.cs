using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Transfers.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Transfers
{
    /// <summary>
    ///     Interface para o serviço de transferências.
    /// </summary>
    public interface IPmTransferService
    {
        /// <summary>
        ///     Realiza uma transferência para uma conta bancária previamente criada ou para um recebedor.
        ///     <see href="https://docs.pagar.me/reference/criando-uma-transferência">Documentação Oficial PagarMe</see>
        /// </summary>
        Task<PmTransferResponse?> CreateTransferAsync(PmCreateTransferRequest request, string? idempotencyKey = null);

        /// <summary>
        ///     Retorna os dados de todas as transferências previamente realizadas.
        ///     <see href="https://docs.pagar.me/reference/retornando-transferências">Documentação Oficial PagarMe</see>
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
        ///     <see href="https://docs.pagar.me/reference/retornando-uma-transferência">Documentação Oficial PagarMe</see>
        /// </summary>
        Task<PmTransferResponse?> GetTransferAsync(string transferId);

        /// <summary>
        ///     Cancela uma transferência que ainda não foi processada (status pending_transfer).
        ///     <see href="https://docs.pagar.me/reference/cancelando-uma-transferência">Documentação Oficial PagarMe</see>
        /// </summary>
        Task<PmTransferResponse?> CancelTransferAsync(string transferId);

        /// <summary>
        ///     Retorna o comprovante de uma transferência realizada com sucesso (status transferred).
        ///     <see href="https://docs.pagar.me/reference/retornando-o-comprovante-de-uma-transferência">
        ///         Documentação Oficial
        ///         PagarMe
        ///     </see>
        /// </summary>
        Task<object?> GetTransferReceiptAsync(string transferId);
    }
}