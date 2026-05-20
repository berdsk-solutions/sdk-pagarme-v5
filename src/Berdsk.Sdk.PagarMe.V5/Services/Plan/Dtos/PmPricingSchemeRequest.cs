using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos
{
    /// <summary>
    ///     Esquema de precificação do item ou do plano.
    /// </summary>
    public class PmPricingSchemeRequest
    {
        /// <summary>
        ///     Esquema de precificação do item. Valores possíveis: unit, package, volume e tier. Valor default: unit
        /// </summary>
        [JsonPropertyName("scheme_type")]
        public string SchemeType { get; set; } = "unit";

        /// <summary>
        ///     Valor do item. Este atributo está disponível para o scheme_type : Unit
        /// </summary>
        [JsonPropertyName("price")]
        public int? Price { get; set; }

        /// <summary>
        ///     Valor mínimo a ser cobrado.
        /// </summary>
        [JsonPropertyName("mininum_price")]
        public int? MinimumPrice { get; set; }

        /// <summary>
        ///     Intervalo de preços. Este atributo está disponível para os scheme_type : package, volume e tier.
        /// </summary>
        [JsonPropertyName("price_brackets")]
        public List<PmPriceBracketRequest>? PriceBrackets { get; set; }
    }
}