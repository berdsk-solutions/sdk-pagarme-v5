using System.Text.Json.Serialization;
using System.Collections.Generic;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionCycle.Dtos
{
    /// <summary>
    ///     Resposta de listagem de ciclos.
    /// </summary>
    public class PmListSubscriptionCyclesResponse
    {
        /// <summary>
        ///     Lista de ciclos.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmSubscriptionCycleResponse> Data { get; set; } = new List<PmSubscriptionCycleResponse>();

        /// <summary>
        ///     Informações de paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}


