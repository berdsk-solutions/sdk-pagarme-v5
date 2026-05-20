using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos
{
    /// <summary>
    ///     Requisição para criação de assinatura (avulsa ou de plano).
    /// </summary>
    public class PmCreateSubscriptionRequest
    {
        /// <summary>
        ///     Código do plano. Obrigatório se não enviar os itens da assinatura.
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string? PlanId { get; set; }

        /// <summary>
        ///     Meio de pagamento. Valores possíveis: credit_card, boleto, pix, debit_card.
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        ///     Dados do cliente.
        /// </summary>
        [JsonPropertyName("customer")]
        public PmCreateCustomerRequest? Customer { get; set; }

        /// <summary>
        ///     ID do cliente já cadastrado.
        /// </summary>
        [JsonPropertyName("customer_id")]
        public string? CustomerId { get; set; }

        /// <summary>
        ///     Dados do cartão de crédito.
        /// </summary>
        [JsonPropertyName("card")]
        public PmCreateCardRequest? Card { get; set; }

        /// <summary>
        ///     ID do cartão já cadastrado.
        /// </summary>
        [JsonPropertyName("card_id")]
        public string? CardId { get; set; }

        /// <summary>
        ///     Código do cartão (token).
        /// </summary>
        [JsonPropertyName("card_token")]
        public string? CardToken { get; set; }

        /// <summary>
        ///     Itens da assinatura.
        /// </summary>
        [JsonPropertyName("items")]
        public List<PmCreateSubscriptionItemRequest>? Items { get; set; }

        /// <summary>
        ///     Dia de cobrança (1 a 28).
        /// </summary>
        [JsonPropertyName("billing_day")]
        public int? BillingDay { get; set; }

        /// <summary>
        ///     Tipo de cobrança. Valores possíveis: prepaid, postpaid, exact_day.
        /// </summary>
        [JsonPropertyName("billing_type")]
        public string? BillingType { get; set; }

        /// <summary>
        ///     Opções de parcelamento.
        /// </summary>
        [JsonPropertyName("installments")]
        public int? Installments { get; set; }

        /// <summary>
        ///     Texto exibido na fatura do cartão.
        /// </summary>
        [JsonPropertyName("statement_descriptor")]
        public string? StatementDescriptor { get; set; }

        /// <summary>
        ///     Moeda. Padrão BRL.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; } = "BRL";

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
        ///     Metadados.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        ///     ID do endereço de cobrança já cadastrado.
        /// </summary>
        [JsonPropertyName("billing_address_id")]
        public string? BillingAddressId { get; set; }

        /// <summary>
        ///     Endereço de cobrança.
        /// </summary>
        [JsonPropertyName("billing_address")]
        public PmCreateCustomerAddressRequest? BillingAddress { get; set; }

        /// <summary>
        ///     ID do endereço de entrega.
        /// </summary>
        [JsonPropertyName("shipping_address_id")]
        public string? ShippingAddressId { get; set; }

        /// <summary>
        ///     Endereço de entrega.
        /// </summary>
        [JsonPropertyName("shipping_address")]
        public PmCreateCustomerAddressRequest? ShippingAddress { get; set; }

        /// <summary>
        ///     Indica se a fatura deve ser paga manualmente.
        /// </summary>
        [JsonPropertyName("manual_billing")]
        public bool? ManualBilling { get; set; }
    }
}