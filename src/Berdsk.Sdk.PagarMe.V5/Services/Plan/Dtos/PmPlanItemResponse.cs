using System;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos
{
    /// <summary>
    ///     Resposta de item do plano.
    /// </summary>
    public class PmPlanItemResponse
    {
        /// <summary>
        ///     Identificador do item.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Nome do item.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Descrição do item.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///     Status do item.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Data de criação.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     Data de atualização.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        ///     Quantidade.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        ///     Ciclos.
        /// </summary>
        [JsonPropertyName("cycles")]
        public int? Cycles { get; set; }

        /// <summary>
        ///     Esquema de precificação.
        /// </summary>
        [JsonPropertyName("pricing_scheme")]
        public PmPricingSchemeResponse? PricingScheme { get; set; }
    }
}