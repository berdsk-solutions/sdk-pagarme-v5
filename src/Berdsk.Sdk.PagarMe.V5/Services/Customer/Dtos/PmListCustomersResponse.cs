using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos
{
    /// <summary>
    ///     Resposta de listagem de clientes
    /// </summary>
    public class PmListCustomersResponse
    {
        /// <summary>
        ///     Lista de clientes
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmCustomerResponse> Data { get; set; } = new List<PmCustomerResponse>();

        /// <summary>
        ///     Informações de paginação
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}