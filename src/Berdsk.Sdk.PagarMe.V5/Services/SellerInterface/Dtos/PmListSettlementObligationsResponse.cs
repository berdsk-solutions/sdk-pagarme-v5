using System.Text.Json.Serialization;
using System.Collections.Generic;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos
{
    /// <summary>
    ///     Resposta de listagem de efeitos de contratos.
    /// </summary>
    public class PmListSettlementObligationsResponse
    {
        /// <summary>
        ///     Lista de efeitos de contratos.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmSettlementObligationResponse> Data { get; set; } = new List<PmSettlementObligationResponse>();

        /// <summary>
        ///     Informações de paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}


