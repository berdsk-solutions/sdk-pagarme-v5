using System.Text.Json.Serialization;
using System.Collections.Generic;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos
{
    /// <summary>
    ///     Resposta de listagem de contestações.
    /// </summary>
    public class PmListContestationsResponse
    {
        /// <summary>
        ///     Lista de contestações.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmContestationResponse> Data { get; set; } = new List<PmContestationResponse>();

        /// <summary>
        ///     Informações de paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}


