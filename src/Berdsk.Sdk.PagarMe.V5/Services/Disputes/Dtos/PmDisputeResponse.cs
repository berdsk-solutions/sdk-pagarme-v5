using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Disputes.Dtos
{
    /// <summary>
    ///     Representa os detalhes de uma disputa de chargeback.
    /// </summary>
    public class PmDisputeResponse
    {
        /// <summary>
        ///     ID único da disputa.
        /// </summary>
        [JsonPropertyName("disputeId")]
        public long DisputeId { get; set; }

        /// <summary>
        ///     ID da transação associada Ã  disputa.
        /// </summary>
        [JsonPropertyName("transactionId")]
        public long TransactionId { get; set; }

        /// <summary>
        ///     Data da criação da disputa.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }

        /// <summary>
        ///     Data da última atualização da disputa.
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public string UpdatedAt { get; set; }

        /// <summary>
        ///     Data limite para o envio de evidências por parte do lojista.
        /// </summary>
        [JsonPropertyName("responseDeadline")]
        public string ResponseDeadline { get; set; }

        /// <summary>
        ///     Valor do chargeback.
        /// </summary>
        [JsonPropertyName("chargebackAmount")]
        public PmDisputeAmountResponse ChargebackAmount { get; set; }

        /// <summary>
        ///     Valor debitado do lojista.
        /// </summary>
        [JsonPropertyName("debitedAmount")]
        public PmDisputeAmountResponse DebitedAmount { get; set; }

        /// <summary>
        ///     Status atual da disputa.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Motivo do pedido de chargeback.
        /// </summary>
        [JsonPropertyName("reason")]
        public PmDisputeReasonResponse Reason { get; set; }

        /// <summary>
        ///     Estágio do ciclo de chargeback.
        /// </summary>
        [JsonPropertyName("stage")]
        public string Stage { get; set; }

        /// <summary>
        ///     Bandeira do cartão.
        /// </summary>
        [JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        ///     Instituição onde a transação foi processada.
        /// </summary>
        [JsonPropertyName("institution")]
        public string Institution { get; set; }

        /// <summary>
        ///     Lista de eventos relacionados Ã  disputa.
        /// </summary>
        [JsonPropertyName("events")]
        public List<PmDisputeEventResponse> Events { get; set; }
    }
}