using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientAnticipationService.Dtos
{
    /// <summary>
    ///     Resposta de uma simulação de antecipação.
    /// </summary>
    public class PmAnticipationSimulationResponse
    {
        [JsonPropertyName("amount")] public long Amount { get; set; }

        [JsonPropertyName("fee")] public long Fee { get; set; }

        [JsonPropertyName("fraudCoverageFee")] public long FraudCoverageFee { get; set; }

        [JsonPropertyName("anticipationAmount")] public long AnticipationAmount { get; set; }

        [JsonPropertyName("anticipationFee")] public long AnticipationFee { get; set; }

        [JsonPropertyName("timeframe")] public string Timeframe { get; set; }

        [JsonPropertyName("paymentDate")] public DateTime? PaymentDate { get; set; }

        [JsonPropertyName("startIntervalDate")] public DateTime? StartIntervalDate { get; set; }

        [JsonPropertyName("endIntervalDate")] public DateTime? EndIntervalDate { get; set; }
    }
}


