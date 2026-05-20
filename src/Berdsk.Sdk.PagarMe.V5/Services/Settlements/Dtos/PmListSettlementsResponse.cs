using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Settlements.Dtos
{
    /// <summary>
    ///     Resposta de listagem de pagamentos.
    /// </summary>
    public class PmListSettlementsResponse
    {
        [JsonPropertyName("data")] public List<PmSettlementResponse> Data { get; set; }

        [JsonPropertyName("paging")] public PmPagingResponse Paging { get; set; }
    }
}