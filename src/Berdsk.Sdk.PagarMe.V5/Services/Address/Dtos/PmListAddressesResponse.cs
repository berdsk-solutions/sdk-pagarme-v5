using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Address.Dtos
{
    /// <summary>
    ///     Resposta de listagem de endereços
    /// </summary>
    public class PmListAddressesResponse
    {
        /// <summary>
        ///     Lista de endereços
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmAddressResponse> Data { get; set; } = new List<PmAddressResponse>();

        /// <summary>
        ///     Informações de paginação
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}