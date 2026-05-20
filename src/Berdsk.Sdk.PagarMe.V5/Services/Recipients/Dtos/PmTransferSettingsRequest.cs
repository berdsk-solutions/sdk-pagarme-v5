using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    public class PmTransferSettingsRequest
    {
        [JsonPropertyName("transfer_enabled")] public bool? TransferEnabled { get; set; }

        [JsonPropertyName("transfer_interval")]
        public string TransferInterval { get; set; }

        [JsonPropertyName("transfer_day")] public int? TransferDay { get; set; }
    }
}


