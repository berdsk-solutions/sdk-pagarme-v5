using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos
{
    /// <summary>
    ///     Itens do plano.
    /// </summary>
    public class PmCreatePlanItemRequest
    {
        /// <summary>
        ///     Nome do item
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Descrição de itens.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///     Quantidade de itens.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        ///     Esquema de precificação do item.
        /// </summary>
        [JsonPropertyName("pricing_scheme")]
        public PmPricingSchemeRequest? PricingScheme { get; set; }

        /// <summary>
        ///     Indica quantas vezes o item será cobrado.
        /// </summary>
        [JsonPropertyName("cycles")]
        public int? Cycles { get; set; }
    }
}