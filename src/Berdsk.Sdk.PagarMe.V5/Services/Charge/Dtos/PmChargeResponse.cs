using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Charge.Dtos
{
    /// <summary>
    ///     Resposta de uma cobrança
    /// </summary>
    public class PmChargeResponse
    {
        /// <summary>
        ///     Identificador da cobrança
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Código de referência da cobrança no seu sistema
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        ///     Gateway ID
        /// </summary>
        [JsonPropertyName("gateway_id")]
        public string? GatewayId { get; set; }

        /// <summary>
        ///     Valor da cobrança em centavos
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        ///     Status da cobrança (pending, paid, canceled, processing, failed, overpaid, underpaid)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Moeda (BRL)
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        ///     Método de pagamento (credit_card, boleto, voucher, debit_card, cash, pix)
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        ///     Data de vencimento
        /// </summary>
        [JsonPropertyName("due_at")]
        public DateTime? DueAt { get; set; }

        /// <summary>
        ///     Data de criação
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     Data de atualização
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        ///     Data do pagamento
        /// </summary>
        [JsonPropertyName("paid_at")]
        public DateTime? PaidAt { get; set; }

        /// <summary>
        ///     Data de cancelamento
        /// </summary>
        [JsonPropertyName("canceled_at")]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        ///     Cliente associado à cobrança
        /// </summary>
        [JsonPropertyName("customer")]
        public PmCustomerResponse? Customer { get; set; }

        /// <summary>
        ///     Última transação da cobrança
        /// </summary>
        [JsonPropertyName("last_transaction")]
        public object? LastTransaction { get; set; }

        /// <summary>
        ///     Metadados
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}