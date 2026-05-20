using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Resposta de listagem de links de pagamento.
    /// </summary>
    public class PmListPaymentLinksResponse
    {
        /// <summary>
        ///     Lista de links de pagamento.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmPaymentLinkResponse> Data { get; set; } = new List<PmPaymentLinkResponse>();

        /// <summary>
        ///     Informações de paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}