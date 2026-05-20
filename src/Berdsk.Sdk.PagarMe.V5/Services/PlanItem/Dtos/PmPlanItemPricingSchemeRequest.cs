using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.PlanItem.Dtos
{
    /// <summary>
    ///     Configurações de preço para item de plano.
    /// </summary>
    public class PmPlanItemPricingSchemeRequest
    {
        /// <summary>
        ///     Tipo de precificação (unit, package, volume, tier).
        /// </summary>
        [JsonPropertyName("scheme_type")]
        public string SchemeType { get; set; }

        /// <summary>
        ///     Preço unitário em centavos.
        /// </summary>
        [JsonPropertyName("price")]
        public int? Price { get; set; }

        /// <summary>
        ///     Preços por faixas (quando scheme_type for tier ou volume).
        /// </summary>
        [JsonPropertyName("price_brackets")]
        public List<PmPlanItemPriceBracketRequest>? PriceBrackets { get; set; }
    }
}