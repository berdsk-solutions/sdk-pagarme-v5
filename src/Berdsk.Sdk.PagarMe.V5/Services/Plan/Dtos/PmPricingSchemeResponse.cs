using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos
{
    /// <summary>
    ///     Resposta do esquema de precificação.
    /// </summary>
    public class PmPricingSchemeResponse
    {
        /// <summary>
        ///     Identificador do esquema.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///     Preço.
        /// </summary>
        [JsonPropertyName("price")]
        public int? Price { get; set; }

        /// <summary>
        ///     Tipo de esquema.
        /// </summary>
        [JsonPropertyName("scheme_type")]
        public string SchemeType { get; set; }

        /// <summary>
        ///     Preço mínimo.
        /// </summary>
        [JsonPropertyName("minimum_price")]
        public int? MinimumPrice { get; set; }

        /// <summary>
        ///     Intervalo de preços.
        /// </summary>
        [JsonPropertyName("price_brackets")]
        public List<PmPriceBracketResponse>? PriceBrackets { get; set; }
    }
}