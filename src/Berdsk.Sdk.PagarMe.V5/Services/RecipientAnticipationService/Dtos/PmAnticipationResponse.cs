using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientAnticipationService.Dtos
{
    /// <summary>
    ///     Resposta de uma antecipação.
    /// </summary>
    public class PmAnticipationResponse
    {
        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("amount")] public long Amount { get; set; }

        [JsonPropertyName("fee")] public long Fee { get; set; }

        [JsonPropertyName("anticipation_fee")] public long AnticipationFee { get; set; }

        [JsonPropertyName("fraud_coverage_fee")] public long FraudCoverageFee { get; set; }

        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("automatic_transfer")] public bool AutomaticTransfer { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }

        [JsonPropertyName("timeframe")] public string Timeframe { get; set; }

        [JsonPropertyName("payment_date")] public DateTime? PaymentDate { get; set; }

        [JsonPropertyName("created_at")] public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")] public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("anticipation_tax")] public double? AnticipationTax { get; set; }
    }
}


