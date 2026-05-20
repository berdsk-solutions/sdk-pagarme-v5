using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientAnticipationService.Dtos
{
    public class PmAnticipationLimitValueResponse
    {
        [JsonPropertyName("amount")] public long Amount { get; set; }

        [JsonPropertyName("anticipation_fee")] public long AnticipationFee { get; set; }

        [JsonPropertyName("fee")] public long Fee { get; set; }

        [JsonPropertyName("fraud_coverage_fee")] public long FraudCoverageFee { get; set; }
    }
}