using System.Text.Json.Serialization;
using System;
using Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos
{
    /// <summary>
    ///     Resposta de item da assinatura.
    /// </summary>
    public class PmSubscriptionItemResponse
    {
        /// <summary>
        ///     Identificador do item.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Nome.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Descrição.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Status.
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
        public int Quantity { get; set; }

        /// <summary>
        ///     Esquema de precificação.
        /// </summary>
        [JsonPropertyName("pricing_scheme")]
        public PmPricingSchemeResponse PricingScheme { get; set; }

        /// <summary>
        ///     Ciclos.
        /// </summary>
        [JsonPropertyName("cycles")]
        public int? Cycles { get; set; }

        /// <summary>
        ///     Código.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }
    }
}


