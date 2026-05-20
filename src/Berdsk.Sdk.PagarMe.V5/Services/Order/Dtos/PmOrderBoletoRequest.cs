using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Dados sobre o pagamento com boleto
    /// </summary>
    public class PmOrderBoletoRequest
    {
        [JsonPropertyName("bank")] public string? Bank { get; set; }

        [JsonPropertyName("instructions")] public string? Instructions { get; set; }

        [JsonPropertyName("due_at")] public string? DueAt { get; set; }
    }
}


