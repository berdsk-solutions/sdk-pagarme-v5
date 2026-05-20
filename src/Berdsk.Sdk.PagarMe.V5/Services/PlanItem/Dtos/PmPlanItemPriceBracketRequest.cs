using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.PlanItem.Dtos
{
    /// <summary>
    ///     Faixa de preço para item de plano.
    /// </summary>
    public class PmPlanItemPriceBracketRequest
    {
        /// <summary>
        ///     Quantidade inicial da faixa.
        /// </summary>
        [JsonPropertyName("start_quantity")]
        public int StartQuantity { get; set; }

        /// <summary>
        ///     Quantidade final da faixa.
        /// </summary>
        [JsonPropertyName("end_quantity")]
        public int? EndQuantity { get; set; }

        /// <summary>
        ///     Preço unitário para a faixa.
        /// </summary>
        [JsonPropertyName("price")]
        public int Price { get; set; }
    }
}