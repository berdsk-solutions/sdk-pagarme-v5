using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    public class PmTransferSettingsResponse
    {
        [JsonPropertyName("transfer_enabled")] public bool? TransferEnabled { get; set; }

        [JsonPropertyName("transfer_interval")]
        public string TransferInterval { get; set; }

        [JsonPropertyName("transfer_day")] public int? TransferDay { get; set; }
    }
}