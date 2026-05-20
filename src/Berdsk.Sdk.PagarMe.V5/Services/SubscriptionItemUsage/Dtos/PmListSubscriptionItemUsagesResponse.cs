using System.Text.Json.Serialization;
using System.Collections.Generic;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItemUsage.Dtos
{
    /// <summary>
    ///     Resposta de listagem de usos de um item de assinatura.
    /// </summary>
    public class PmListSubscriptionItemUsagesResponse
    {
        /// <summary>
        ///     Lista de usos.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmSubscriptionItemUsageResponse> Data { get; set; } = new List<PmSubscriptionItemUsageResponse>();

        /// <summary>
        ///     Informações de paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}


