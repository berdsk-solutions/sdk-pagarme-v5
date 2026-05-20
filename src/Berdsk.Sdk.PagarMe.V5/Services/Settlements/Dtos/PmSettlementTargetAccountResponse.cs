using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Settlements.Dtos
{
    public class PmSettlementTargetAccountResponse
    {
        [JsonPropertyName("ispb")] public string Ispb { get; set; }
    }
}