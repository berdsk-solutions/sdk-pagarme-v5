using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionCycle.Dtos
{
    /// <summary>
    ///     Resposta de um ciclo de assinatura.
    /// </summary>
    public class PmSubscriptionCycleResponse
    {
        /// <summary>
        ///     Identificador do ciclo.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Data de cobrança do ciclo.
        /// </summary>
        [JsonPropertyName("billing_at")]
        public DateTime? BillingAt { get; set; }

        /// <summary>
        ///     Número do ciclo na assinatura.
        /// </summary>
        [JsonPropertyName("cycle")]
        public int Cycle { get; set; }

        /// <summary>
        ///     Data de início do ciclo.
        /// </summary>
        [JsonPropertyName("start_at")]
        public DateTime? StartAt { get; set; }

        /// <summary>
        ///     Data de fim do ciclo.
        /// </summary>
        [JsonPropertyName("end_at")]
        public DateTime? EndAt { get; set; }

        /// <summary>
        ///     Duração do ciclo em segundos.
        /// </summary>
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        /// <summary>
        ///     Data de criação do ciclo.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     Data de atualização do ciclo.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        ///     Status do ciclo (ex: billed, pending).
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}


