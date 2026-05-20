using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Disputes.Dtos
{
    /// <summary>
    ///     Resposta da listagem de disputas.
    /// </summary>
    public class PmListDisputesResponse
    {
        /// <summary>
        ///     Lista de disputas.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmDisputeResponse> Data { get; set; } = new List<PmDisputeResponse>();

        /// <summary>
        ///     Informações de paginação.
        /// </summary>
        [JsonPropertyName("page")]
        public PmDisputePageResponse Page { get; set; }
    }
}