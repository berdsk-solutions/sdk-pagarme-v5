using System;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.PlanItem.Dtos
{
    /// <summary>
    ///     Resposta de um item de plano.
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
        public string Name { get; set; }

        /// <summary>
        ///     Número de ciclos durante o qual o item será cobrado.
        /// </summary>
        [JsonPropertyName("cycles")]
        public int? Cycles { get; set; }

        /// <summary>
        ///     Status do item.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Quantidade de itens.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

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
        ///     Descrição do item.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///     Configurações de preço.
        /// </summary>
        [JsonPropertyName("pricing_scheme")]
        public PmPlanItemPricingSchemeResponse? PricingScheme { get; set; }

        /// <summary>
        ///     Dados do plano ao qual o item pertence.
        /// </summary>
        [JsonPropertyName("plan")]
        public PmPlanResponse? Plan { get; set; }
    }
}