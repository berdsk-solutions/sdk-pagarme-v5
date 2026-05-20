using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Charge.Dtos
{
    /// <summary>
    ///     Requisição para editar o cartão de uma cobrança
    /// </summary>
    public class PmUpdateChargeCardRequest
    {
        /// <summary>
        ///     Dados do novo cartão
        /// </summary>
        [JsonPropertyName("card")]
        public PmCreateCardRequest Card { get; set; }

        /// <summary>
        ///     ID do cartão já salvo
        /// </summary>
        [JsonPropertyName("card_id")]
        public string? CardId { get; set; }
    }
}


