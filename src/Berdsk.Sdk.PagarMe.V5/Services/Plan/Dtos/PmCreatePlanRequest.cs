using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos
{
    /// <summary>
    ///     Requisição para criação de plano.
    /// </summary>
    public class PmCreatePlanRequest
    {
        /// <summary>
        ///     Nome do plano. Max: 64 caracteres.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Descrição do plano.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///     Indica se o plano oferece entrega.
        /// </summary>
        [JsonPropertyName("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        ///     Meios de pagamento disponíveis. Valores possíveis: credit_card, boleto ou debit_card.
        /// </summary>
        [JsonPropertyName("payment_methods")]
        public List<string>? PaymentMethods { get; set; }

        /// <summary>
        ///     Opções de parcelamento disponíveis.
        /// </summary>
        [JsonPropertyName("installments")]
        public List<int>? Installments { get; set; }

        /// <summary>
        ///     Valor mínimo em centavos da fatura.
        /// </summary>
        [JsonPropertyName("minimum_price")]
        public int? MinimumPrice { get; set; }

        /// <summary>
        ///     Texto exibido na fatura do cartão. Max: 13 caracteres.
        /// </summary>
        [JsonPropertyName("statement_descriptor")]
        public string? StatementDescriptor { get; set; }

        /// <summary>
        ///     Moeda. Valores possíveis: BRL.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; } = "BRL";

        /// <summary>
        ///     Frequência da recorrência. Valores possíveis: day, week, month ou year.
        /// </summary>
        [JsonPropertyName("interval")]
        public string Interval { get; set; } = "month";

        /// <summary>
        ///     Número de intervalos entre cada cobrança da assinatura.
        /// </summary>
        [JsonPropertyName("interval_count")]
        public int IntervalCount { get; set; } = 1;

        /// <summary>
        ///     Dias de teste.
        /// </summary>
        [JsonPropertyName("trial_period_days")]
        public int? TrialPeriodDays { get; set; }

        /// <summary>
        ///     Tipo de cobrança. Valores possíveis: prepaid, postpaid ou exact_day.
        /// </summary>
        [JsonPropertyName("billing_type")]
        public string BillingType { get; set; } = "prepaid";

        /// <summary>
        ///     Dias disponíveis para cobrança das assinaturas. Obrigatório caso billing_type seja exact_day.
        /// </summary>
        [JsonPropertyName("billing_days")]
        public List<int>? BillingDays { get; set; }

        /// <summary>
        ///     Itens do plano.
        /// </summary>
        [JsonPropertyName("items")]
        public List<PmCreatePlanItemRequest>? Items { get; set; }

        /// <summary>
        ///     Esquema de precificação. Obrigatório na ausência de items.
        /// </summary>
        [JsonPropertyName("pricing_scheme")]
        public PmPricingSchemeRequest? PricingScheme { get; set; }

        /// <summary>
        ///     Metadados
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}