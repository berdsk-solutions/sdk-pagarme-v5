using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos
{
    /// <summary>
    ///     Resposta de intervalo de preços.
    /// </summary>
    public class PmPriceBracketResponse
    {
        /// <summary>
        ///     Quantidade inicial.
        /// </summary>
        [JsonPropertyName("start_quantity")]
        public int StartQuantity { get; set; }

        /// <summary>
        ///     Quantidade final.
        /// </summary>
        [JsonPropertyName("end_quantity")]
        public int? EndQuantity { get; set; }

        /// <summary>
        ///     Preço excedente.
        /// </summary>
        [JsonPropertyName("overage_price")]
        public int? OveragePrice { get; set; }

        /// <summary>
        ///     Preço.
        /// </summary>
        [JsonPropertyName("price")]
        public int? Price { get; set; }
    }
}