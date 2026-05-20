using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos
{
    /// <summary>
    ///     Resposta de listagem de assinaturas.
    /// </summary>
    public class PmListSubscriptionsResponse
    {
        /// <summary>
        ///     Lista de assinaturas.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmSubscriptionResponse> Data { get; set; } = new List<PmSubscriptionResponse>();

        /// <summary>
        ///     Informações de paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}