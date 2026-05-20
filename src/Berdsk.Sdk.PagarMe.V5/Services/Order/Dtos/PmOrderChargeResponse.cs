using System;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Resposta de cobrança do pedido
    /// </summary>
    public class PmOrderChargeResponse
    {
        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("code")] public string Code { get; set; }

        [JsonPropertyName("gateway_id")] public string GatewayId { get; set; }

        [JsonPropertyName("amount")] public int Amount { get; set; }

        [JsonPropertyName("paid_amount")] public int PaidAmount { get; set; }

        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("payment_method")] public string PaymentMethod { get; set; }

        [JsonPropertyName("paid_at")] public DateTime? PaidAt { get; set; }

        [JsonPropertyName("created_at")] public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")] public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("last_transaction")] public PmOrderTransactionResponse? LastTransaction { get; set; }
    }
}