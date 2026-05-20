using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos
{
    /// <summary>
    ///     Resposta de assinatura.
    /// </summary>
    public class PmSubscriptionResponse
    {
        /// <summary>
        ///     Identificador da assinatura.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Código de referência.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        ///     Data de início.
        /// </summary>
        [JsonPropertyName("start_at")]
        public DateTime? StartAt { get; set; }

        /// <summary>
        ///     Intervalo.
        /// </summary>
        [JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        ///     Contagem de intervalos.
        /// </summary>
        [JsonPropertyName("interval_count")]
        public int IntervalCount { get; set; }

        /// <summary>
        ///     Dia de cobrança.
        /// </summary>
        [JsonPropertyName("billing_day")]
        public int? BillingDay { get; set; }

        /// <summary>
        ///     Tipo de cobrança.
        /// </summary>
        [JsonPropertyName("billing_type")]
        public string BillingType { get; set; }

        /// <summary>
        ///     Meio de pagamento.
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        ///     Status.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Moeda.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        ///     Parcelas.
        /// </summary>
        [JsonPropertyName("installments")]
        public int? Installments { get; set; }

        /// <summary>
        ///     Descritor da fatura.
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
        ///     Cliente.
        /// </summary>
        [JsonPropertyName("customer")]
        public PmCustomerResponse? Customer { get; set; }

        /// <summary>
        ///     Cartão.
        /// </summary>
        [JsonPropertyName("card")]
        public PmCardResponse? Card { get; set; }

        /// <summary>
        ///     Plano.
        /// </summary>
        [JsonPropertyName("plan")]
        public PmPlanResponse? Plan { get; set; }

        /// <summary>
        ///     Itens da assinatura.
        /// </summary>
        [JsonPropertyName("items")]
        public List<PmSubscriptionItemResponse> Items { get; set; } = new List<PmSubscriptionItemResponse>();

        /// <summary>
        ///     Metadados.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        ///     Próxima cobrança.
        /// </summary>
        [JsonPropertyName("next_billing_at")]
        public DateTime? NextBillingAt { get; set; }

        /// <summary>
        ///     Faturamento manual.
        /// </summary>
        [JsonPropertyName("manual_billing")]
        public bool ManualBilling { get; set; }
    }
}