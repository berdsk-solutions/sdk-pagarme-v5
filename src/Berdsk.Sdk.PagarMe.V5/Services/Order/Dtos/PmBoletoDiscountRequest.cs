using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    public class PmBoletoDiscountRequest
    {
        [JsonPropertyName("type")] public string? Type { get; set; }
        [JsonPropertyName("rules")] public List<PmBoletoDiscountRuleRequest>? Rules { get; set; }
    }
}