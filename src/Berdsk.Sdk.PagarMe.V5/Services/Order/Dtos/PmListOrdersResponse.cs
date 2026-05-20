using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Resposta de listagem de pedidos
    /// </summary>
    public class PmListOrdersResponse
    {
        /// <summary>
        ///     Lista de pedidos
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmOrderResponse> Data { get; set; } = new List<PmOrderResponse>();

        /// <summary>
        ///     Informações de paginação
        /// </summary>
        [JsonPropertyName("paging")]
        public PmOrderPagingResponse Paging { get; set; }
    }
}


