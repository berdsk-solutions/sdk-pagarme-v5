using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos
{
    /// <summary>
    ///     Resposta de listagem de planos.
    /// </summary>
    public class PmListPlansResponse
    {
        /// <summary>
        ///     Lista de planos.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmPlanResponse> Data { get; set; } = new List<PmPlanResponse>();

        /// <summary>
        ///     Informações de paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}