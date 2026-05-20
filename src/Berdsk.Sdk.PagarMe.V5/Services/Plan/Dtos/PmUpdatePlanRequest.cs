using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos
{
    /// <summary>
    ///     Requisição para atualização de plano.
    /// </summary>
    public class PmUpdatePlanRequest
    {
        /// <summary>
        ///     Nome do plano.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Descrição do plano.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///     Opções de parcelamento.
        /// </summary>
        [JsonPropertyName("installments")]
        public List<int>? Installments { get; set; }

        /// <summary>
        ///     Texto exibido na fatura do cartão.
        /// </summary>
        [JsonPropertyName("statement_descriptor")]
        public string? StatementDescriptor { get; set; }

        /// <summary>
        ///     Moeda.
        /// </summary>
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        /// <summary>
        ///     Frequência da recorrência.
        /// </summary>
        [JsonPropertyName("interval")]
        public string? Interval { get; set; }

        /// <summary>
        ///     Número de intervalos entre cobranças.
        /// </summary>
        [JsonPropertyName("interval_count")]
        public int? IntervalCount { get; set; }

        /// <summary>
        ///     Meios de pagamento disponíveis.
        /// </summary>
        [JsonPropertyName("payment_methods")]
        public List<string>? PaymentMethods { get; set; }

        /// <summary>
        ///     Tipo de cobrança.
        /// </summary>
        [JsonPropertyName("billing_type")]
        public string? BillingType { get; set; }

        /// <summary>
        ///     Status do plano.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///     Indica se o plano oferece entrega.
        /// </summary>
        [JsonPropertyName("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        ///     Dias disponíveis para cobrança das assinaturas.
        /// </summary>
        [JsonPropertyName("billing_days")]
        public List<int>? BillingDays { get; set; }

        /// <summary>
        ///     Metadados.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        ///     Valor mínimo em centavos da fatura.
        /// </summary>
        [JsonPropertyName("minimum_price")]
        public int? MinimumPrice { get; set; }
    }
}


