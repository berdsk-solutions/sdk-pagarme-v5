using System.Collections.Generic;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionInvoice.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionInvoice
{
    /// <summary>
    /// Interface para o serviço de faturas de assinatura.
    /// </summary>
    public interface IPmSubscriptionInvoiceService
    {
        /// <summary>
        ///     Lista as faturas de uma assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/listar-faturas-de-uma-assinatura-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="page">Número da página</param>
        /// <param name="size">Quantidade de registros por página</param>
        /// <returns>Lista de faturas</returns>
        Task<PmListSubscriptionInvoicesResponse?> ListSubscriptionInvoicesAsync(string subscriptionId, int? page = null, int? size = null);

        /// <summary>
        ///     Obtém os dados de uma fatura específica.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-fatura-1.md</para>
        /// </summary>
        /// <param name="invoiceId">Identificador da fatura</param>
        /// <returns>Dados da fatura</returns>
        Task<PmSubscriptionInvoiceResponse?> GetSubscriptionInvoiceAsync(string invoiceId);

        /// <summary>
        ///     Cria uma fatura de acordo com o identificador do ciclo a ser cobrado.
        ///     <para>Referência: https://docs.pagar.me/reference/criar-fatura-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="cycleId">Identificador do ciclo</param>
        /// <param name="metadata">Metadados opcionais</param>
        /// <returns>Dados da fatura criada</returns>
        Task<PmSubscriptionInvoiceResponse?> CreateInvoiceAsync(string subscriptionId, string cycleId, Dictionary<string, string>? metadata = null);

        /// <summary>
        ///     Lista todas as faturas do sistema com filtros opcionais.
        ///     <para>Referência: https://docs.pagar.me/reference/listar-faturas-1.md</para>
        /// </summary>
        Task<PmListSubscriptionInvoicesResponse?> ListAllInvoicesAsync(string? status = null, int? page = null, int? size = null);
    }
}


