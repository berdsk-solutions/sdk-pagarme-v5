using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    public class PmAnticipationSettingsRequest
    {
        [JsonPropertyName("enabled")] public bool? Enabled { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }

        [JsonPropertyName("volume_percentage")]
        public int? VolumePercentage { get; set; }

        [JsonPropertyName("delay")] public int? Delay { get; set; }
    }
}


