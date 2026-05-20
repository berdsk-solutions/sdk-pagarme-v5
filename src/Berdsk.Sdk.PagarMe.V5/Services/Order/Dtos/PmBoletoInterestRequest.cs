using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    public class PmBoletoInterestRequest
    {
        [JsonPropertyName("days")] public int? Days { get; set; }
        [JsonPropertyName("type")] public string? Type { get; set; }
        [JsonPropertyName("amount")] public decimal? Amount { get; set; }
    }
}