using System;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionDiscount.Dtos
{
    /// <summary>
    ///     Resposta de um desconto de assinatura.
    /// </summary>
    public class PmSubscriptionDiscountResponse
    {
        /// <summary>
        ///     Identificador do desconto.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Valor do desconto.
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }

        /// <summary>
        ///     Tipo do desconto.
        /// </summary>
        [JsonPropertyName("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        ///     Status do desconto.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Data de criação.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     Quantidade de ciclos.
        /// </summary>
        [JsonPropertyName("cycles")]
        public int? Cycles { get; set; }

        /// <summary>
        ///     Descrição do desconto.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///     Dados da assinatura associada.
        /// </summary>
        [JsonPropertyName("subscription")]
        public PmSubscriptionResponse? Subscription { get; set; }
    }
}