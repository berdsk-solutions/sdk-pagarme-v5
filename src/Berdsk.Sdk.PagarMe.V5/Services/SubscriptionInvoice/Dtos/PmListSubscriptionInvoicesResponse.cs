using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionInvoice.Dtos
{
    /// <summary>
    ///     Resposta de listagem de faturas.
    /// </summary>
    public class PmListSubscriptionInvoicesResponse
    {
        /// <summary>
        ///     Lista de faturas.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmSubscriptionInvoiceResponse> Data { get; set; } = new List<PmSubscriptionInvoiceResponse>();

        /// <summary>
        ///     Informações de paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}