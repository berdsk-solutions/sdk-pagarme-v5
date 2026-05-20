using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItem.Dtos
{
    /// <summary>
    ///     Requisição para criação de item de assinatura.
    /// </summary>
    public class PmCreateSubscriptionItemRequestDto
    {
        /// <summary>
        ///     Descrição do item.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Esquema de precificação.
        /// </summary>
        [JsonPropertyName("pricing_scheme")]
        public PmPricingSchemeRequest PricingScheme { get; set; }

        /// <summary>
        ///     ID do item do plano (opcional).
        /// </summary>
        [JsonPropertyName("plan_item_id")]
        public string? PlanItemId { get; set; }

        /// <summary>
        ///     Quantidade.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        ///     Nome.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Número de ciclos.
        /// </summary>
        [JsonPropertyName("cycles")]
        public int? Cycles { get; set; }
    }
}