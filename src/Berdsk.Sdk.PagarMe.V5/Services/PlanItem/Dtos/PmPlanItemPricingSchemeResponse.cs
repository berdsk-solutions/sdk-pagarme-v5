using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.PlanItem.Dtos
{
    /// <summary>
    ///     Resposta das configurações de preço para item de plano.
    /// </summary>
    public class PmPlanItemPricingSchemeResponse
    {
        /// <summary>
        ///     Identificador do esquema de preço.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Tipo de precificação.
        /// </summary>
        [JsonPropertyName("scheme_type")]
        public string SchemeType { get; set; }

        /// <summary>
        ///     Preço unitário em centavos.
        /// </summary>
        [JsonPropertyName("price")]
        public int? Price { get; set; }

        /// <summary>
        ///     Preços por faixas.
        /// </summary>
        [JsonPropertyName("price_brackets")]
        public List<PmPlanItemPriceBracketResponse>? PriceBrackets { get; set; }
    }
}