using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionIncrement.Dtos
{
    /// <summary>
    ///     Resposta de listagem de incrementos.
    /// </summary>
    public class PmListSubscriptionIncrementsResponse
    {
        /// <summary>
        ///     Lista de incrementos.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmSubscriptionIncrementResponse> Data { get; set; } = new List<PmSubscriptionIncrementResponse>();

        /// <summary>
        ///     Informações de paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}