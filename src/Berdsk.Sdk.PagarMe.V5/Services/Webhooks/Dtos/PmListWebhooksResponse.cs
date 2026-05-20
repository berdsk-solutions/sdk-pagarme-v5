using System.Text.Json.Serialization;
using System.Collections.Generic;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Webhooks.Dtos
{
    /// <summary>
    ///     Resposta de listagem de webhooks.
    /// </summary>
    public class PmListWebhooksResponse
    {
        /// <summary>
        ///     Lista de webhooks.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmWebhookResponse> Data { get; set; } = new List<PmWebhookResponse>();

        /// <summary>
        ///     Informações de paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}


