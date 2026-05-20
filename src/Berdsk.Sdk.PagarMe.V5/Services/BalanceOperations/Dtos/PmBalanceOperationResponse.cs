using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.BalanceOperations.Dtos
{
    /// <summary>
    ///     Representa uma operação de saldo (Balance Operation) no Pagar.me.
    /// </summary>
    public class PmBalanceOperationResponse
    {
        [JsonPropertyName("id")] public long Id { get; set; }

        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("balance_amount")] public long BalanceAmount { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }

        [JsonPropertyName("amount")] public long Amount { get; set; }

        [JsonPropertyName("fee")] public long Fee { get; set; }

        [JsonPropertyName("created_at")] public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("movement_object")] public PmBalanceOperationMovementResponse MovementObject { get; set; }
    }
}


