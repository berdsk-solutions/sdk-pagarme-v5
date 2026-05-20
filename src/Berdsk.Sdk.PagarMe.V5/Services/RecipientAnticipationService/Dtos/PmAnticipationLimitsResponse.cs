using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientAnticipationService.Dtos
{
    /// <summary>
    ///     Resposta dos limites de antecipação.
    /// </summary>
    public class PmAnticipationLimitsResponse
    {
        [JsonPropertyName("maximum")] public PmAnticipationLimitValueResponse Maximum { get; set; }

        [JsonPropertyName("minimum")] public PmAnticipationLimitValueResponse Minimum { get; set; }
    }
}


