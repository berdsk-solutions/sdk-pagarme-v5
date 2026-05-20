using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItem.Dtos
{
    /// <summary>
    ///     Requisição para atualização de item de assinatura.
    /// </summary>
    public class PmUpdateSubscriptionItemRequest
    {
        /// <summary>
        ///     Descrição.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///     Status.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///     Esquema de precificação.
        /// </summary>
        [JsonPropertyName("pricing_scheme")]
        public PmPricingSchemeRequest? PricingScheme { get; set; }

        /// <summary>
        ///     Nome.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Ciclos.
        /// </summary>
        [JsonPropertyName("cycles")]
        public int? Cycles { get; set; }

        /// <summary>
        ///     Quantidade.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
    }
}