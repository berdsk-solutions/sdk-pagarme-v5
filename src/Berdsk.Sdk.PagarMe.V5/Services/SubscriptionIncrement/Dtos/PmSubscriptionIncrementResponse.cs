using System.Text.Json.Serialization;
using System;
using Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionIncrement.Dtos
{
    /// <summary>
    ///     Resposta de um incremento de assinatura.
    /// </summary>
    public class PmSubscriptionIncrementResponse
    {
        /// <summary>
        ///     Identificador do incremento.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Valor do incremento.
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }

        /// <summary>
        ///     Tipo do incremento.
        /// </summary>
        [JsonPropertyName("increment_type")]
        public string IncrementType { get; set; }

        /// <summary>
        ///     Status do incremento.
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
        ///     Descrição do incremento.
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


