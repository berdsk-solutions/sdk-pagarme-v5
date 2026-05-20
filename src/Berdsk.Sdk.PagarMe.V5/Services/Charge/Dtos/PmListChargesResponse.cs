using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Charge.Dtos
{
    /// <summary>
    ///     Resposta de listagem de cobranças
    /// </summary>
    public class PmListChargesResponse
    {
        /// <summary>
        ///     Lista de cobranças
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmChargeResponse> Data { get; set; } = new List<PmChargeResponse>();

        /// <summary>
        ///     Informações de paginação
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}