using System;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.BalanceOperations.Dtos
{
    /// <summary>
    ///     Representa o objeto de movimento de uma operação de saldo.
    /// </summary>
    public class PmBalanceOperationMovementResponse
    {
        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("amount")] public long Amount { get; set; }

        [JsonPropertyName("fee")] public long Fee { get; set; }

        [JsonPropertyName("anticipation_fee")] public long AnticipationFee { get; set; }

        [JsonPropertyName("fraud_coverage_fee")]
        public long FraudCoverageFee { get; set; }

        [JsonPropertyName("recipient_id")] public string RecipientId { get; set; }

        [JsonPropertyName("originator_model")] public string OriginatorModel { get; set; }

        [JsonPropertyName("originator_model_id")]
        public string OriginatorModelId { get; set; }

        [JsonPropertyName("payment_date")] public DateTime? PaymentDate { get; set; }

        [JsonPropertyName("payment_method")] public string PaymentMethod { get; set; }

        [JsonPropertyName("object")] public string Object { get; set; }

        [JsonPropertyName("created_at")] public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }

        [JsonPropertyName("gateway_id")] public string GatewayId { get; set; }
    }
}