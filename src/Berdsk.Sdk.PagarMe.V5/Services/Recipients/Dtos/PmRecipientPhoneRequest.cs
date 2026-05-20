using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    public class PmRecipientPhoneRequest
    {
        [JsonPropertyName("ddd")] public string Ddd { get; set; }

        [JsonPropertyName("number")] public string Number { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }
    }
}


