using System.Text.Json.Serialization;
using System.Collections.Generic;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItem.Dtos
{
    /// <summary>
    ///     Resposta de listagem de itens de assinatura.
    /// </summary>
    public class PmListSubscriptionItemsResponse
    {
        /// <summary>
        ///     Dados dos itens.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmSubscriptionItemResponse> Data { get; set; } = new List<PmSubscriptionItemResponse>();

        /// <summary>
        ///     Paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}


