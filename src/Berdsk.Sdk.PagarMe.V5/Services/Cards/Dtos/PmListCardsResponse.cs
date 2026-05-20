using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos
{
    /// <summary>
    ///     Resposta de listagem de cartões.
    ///     <para>Referência: https://docs.pagar.me/reference/listar-cartão.md</para>
    /// </summary>
    public class PmListCardsResponse
    {
        /// <summary>
        ///     Lista de cartões.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmCardResponse> Data { get; set; } = new List<PmCardResponse>();

        /// <summary>
        ///     Informações de paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPagingResponse Paging { get; set; }
    }
}