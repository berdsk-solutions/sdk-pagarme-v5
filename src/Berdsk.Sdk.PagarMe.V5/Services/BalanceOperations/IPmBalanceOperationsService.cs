using System;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.BalanceOperations.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.BalanceOperations
{
    /// <summary>
    ///     Interface para o serviço de operações de saldo (Balance Operations).
    /// </summary>
    public interface IPmBalanceOperationsService
    {
        /// <summary>
        ///     Obtém o histórico das operações de saldo com filtros opcionais.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-histórico-das-operações.md</para>
        /// </summary>
        /// <param name="createdSince">Filtro pela data de criação da operação de saldo, como data de partida</param>
        /// <param name="createdUntil">Filtro pela data de criação da operação de saldo, como data limite</param>
        /// <param name="status">Estado do saldo da conta. Valores possíveis: waiting_funds, available e transferred</param>
        /// <param name="recipientId">ID de recebedor desejado</param>
        /// <param name="page">Filtro pela página de retorno</param>
        /// <param name="size">Filtro pela quantidade de objetos retornados. Deve ser menor ou igual a 1000</param>
        /// <returns>Lista de operações de saldo e informações de paginação</returns>
        Task<PmListBalanceOperationsResponse?> ListBalanceOperationsAsync(
            DateTime? createdSince = null,
            DateTime? createdUntil = null,
            string? status = null,
            string? recipientId = null,
            int? page = null,
            int? size = null);

        /// <summary>
        ///     Obtém os detalhes de uma operação de saldo específica.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-histórico-específico-de-uma-operação.md</para>
        /// </summary>
        /// <param name="balanceOperationId">Identificador da operação de saldo</param>
        /// <returns>Dados da operação de saldo ou null se não encontrada</returns>
        Task<PmBalanceOperationResponse?> GetBalanceOperationAsync(string balanceOperationId);
    }
}