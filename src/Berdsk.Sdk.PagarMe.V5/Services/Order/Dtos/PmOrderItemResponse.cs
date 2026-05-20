using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Resposta de item do pedido
    /// </summary>
    public class PmOrderItemResponse
    {
        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("description")] public string Description { get; set; }

        [JsonPropertyName("amount")] public int Amount { get; set; }

        [JsonPropertyName("quantity")] public int Quantity { get; set; }

        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("created_at")] public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")] public DateTime UpdatedAt { get; set; }
    }
}


