using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    public class PmBoletoDiscountRuleRequest
    {
        [JsonPropertyName("limit_date")] public string? LimitDate { get; set; }
        [JsonPropertyName("amount")] public decimal? Amount { get; set; }
    }
}
