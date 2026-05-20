using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionDiscount.Dtos
{
    /// <summary>
    ///     Resposta de listagem de descontos.
    /// </summary>
    public class PmListSubscriptionDiscountsResponse
    {
        /// <summary>
        ///     Lista de descontos.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmSubscriptionDiscountResponse> Data { get; set; } = new List<PmSubscriptionDiscountResponse>();

        /// <summary>
        ///     Informações de paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}