using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientBalance.Dtos
{
    /// <summary>
    ///     Detalhes do recebedor no retorno do saldo.
    /// </summary>
    public class PmRecipientBalanceRecipientResponse
    {
        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("email")] public string Email { get; set; }

        [JsonPropertyName("document")] public string Document { get; set; }

        [JsonPropertyName("description")] public string Description { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }

        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("created_at")] public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("updated_at")] public DateTime? UpdatedAt { get; set; }
    }
}


