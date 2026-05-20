using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.BalanceOperations.Dtos
{
    /// <summary>
    ///     Resposta de listagem de operações de saldo.
    /// </summary>
    public class PmListBalanceOperationsResponse
    {
        [JsonPropertyName("data")]
        public List<PmBalanceOperationResponse> Data { get; set; } = new List<PmBalanceOperationResponse>();

        [JsonPropertyName("paging")] public PmPagingResponse Paging { get; set; }
    }
}