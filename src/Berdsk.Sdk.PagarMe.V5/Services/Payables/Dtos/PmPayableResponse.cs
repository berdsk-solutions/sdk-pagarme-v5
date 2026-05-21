using System;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Payables.Dtos
{
    /// <summary>
    ///     Representa um recebível (payable) no Pagar.me.
    ///     <see href="https://docs.pagar.me/reference/retornando-recebíveis">Documentação Oficial PagarMe</see>
    /// </summary>
    public class PmPayableResponse
    {
        [JsonPropertyName("id")] public long Id { get; set; }

        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("amount")] public long Amount { get; set; }

        [JsonPropertyName("fee")] public long Fee { get; set; }

        [JsonPropertyName("anticipation_fee")] public long AnticipationFee { get; set; }

        [JsonPropertyName("fraud_coverage_fee")]
        public long? FraudCoverageFee { get; set; }

        [JsonPropertyName("installment")] public int Installment { get; set; }

        [JsonPropertyName("gateway_id")] public long? GatewayId { get; set; }

        [JsonPropertyName("charge_id")] public string ChargeId { get; set; }

        [JsonPropertyName("split_id")] public string SplitId { get; set; }

        [JsonPropertyName("recipient_id")] public string RecipientId { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }

        [JsonPropertyName("payment_method")] public string PaymentMethod { get; set; }

        [JsonPropertyName("payment_date")] public DateTime? PaymentDate { get; set; }

        [JsonPropertyName("accrual_at")] public DateTime? AccrualAt { get; set; }

        [JsonPropertyName("created_at")] public DateTime? CreatedAt { get; set; }
    }
}