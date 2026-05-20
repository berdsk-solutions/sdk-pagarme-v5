using System.Text.Json.Serialization;
using System;
using Berdsk.Sdk.PagarMe.V5.Services.Charge.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionInvoice.Dtos
{
    /// <summary>
    ///     Resposta de uma fatura de assinatura.
    /// </summary>
    public class PmSubscriptionInvoiceResponse
    {
        /// <summary>
        ///     Identificador da fatura.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Código de referência da fatura.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        ///     URL da fatura.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        ///     Valor total da fatura em centavos.
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        ///     Status da fatura (paid, pending, canceled).
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Data de vencimento.
        /// </summary>
        [JsonPropertyName("due_at")]
        public DateTime? DueAt { get; set; }

        /// <summary>
        ///     Data de criação.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     Cobrança associada à fatura.
        /// </summary>
        [JsonPropertyName("charge")]
        public PmChargeResponse? Charge { get; set; }
    }
}


