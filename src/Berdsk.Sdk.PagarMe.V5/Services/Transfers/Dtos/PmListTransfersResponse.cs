using System.Text.Json.Serialization;
using System.Collections.Generic;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Transfers.Dtos
{
    /// <summary>
    ///     Resposta de listagem de transferências.
    /// </summary>
    public class PmListTransfersResponse
    {
        [JsonPropertyName("data")] public List<PmTransferResponse> Data { get; set; }

        [JsonPropertyName("paging")] public PmPagingResponse Paging { get; set; }
    }
}


