using System.Text.Json.Serialization;
using System.Collections.Generic;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Payables.Dtos
{
    /// <summary>
    ///     Resposta de listagem de recebíveis
    /// </summary>
    public class PmListPayablesResponse
    {
        /// <summary>
        ///     Lista de recebíveis
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmPayableResponse> Data { get; set; } = new List<PmPayableResponse>();

        /// <summary>
        ///     Informações de paginação
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}


