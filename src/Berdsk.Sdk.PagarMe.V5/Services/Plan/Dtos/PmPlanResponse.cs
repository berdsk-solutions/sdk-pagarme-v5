using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos
{
    /// <summary>
    ///     Resposta de plano.
    /// </summary>
    public class PmPlanResponse
    {
        /// <summary>
        ///     Identificador do plano.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Nome do plano.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Descrição do plano.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///     URL do plano.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        ///     Moeda.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        ///     Frequência da recorrência.
        /// </summary>
        [JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        ///     Número de intervalos entre cobranças.
        /// </summary>
        [JsonPropertyName("interval_count")]
        public int IntervalCount { get; set; }

        /// <summary>
        ///     Tipo de cobrança.
        /// </summary>
        [JsonPropertyName("billing_type")]
        public string BillingType { get; set; }

        /// <summary>
        ///     Opções de parcelamento.
        /// </summary>
        [JsonPropertyName("installments")]
        public List<int>? Installments { get; set; }

        /// <summary>
        ///     Status do plano.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Valor mínimo da fatura.
        /// </summary>
        [JsonPropertyName("minimum_price")]
        public int? MinimumPrice { get; set; }

        /// <summary>
        ///     Texto exibido na fatura do cartão.
        /// </summary>
        [JsonPropertyName("statement_descriptor")]
        public string? StatementDescriptor { get; set; }

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
        ///     Data de deleção.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        ///     Itens do plano.
        /// </summary>
        [JsonPropertyName("items")]
        public List<PmPlanItemResponse>? Items { get; set; }

        /// <summary>
        ///     Metadados
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}