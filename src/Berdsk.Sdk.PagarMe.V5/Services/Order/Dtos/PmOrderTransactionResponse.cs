using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Resposta de transação da cobrança
    /// </summary>
    public class PmOrderTransactionResponse
    {
        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("transaction_type")] public string TransactionType { get; set; }

        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("success")] public bool Success { get; set; }

        [JsonPropertyName("amount")] public int Amount { get; set; }

        [JsonPropertyName("gateway_id")] public string GatewayId { get; set; }

        [JsonPropertyName("gateway_response")] public PmOrderGatewayResponse? GatewayResponse { get; set; }

        [JsonPropertyName("qr_code")] public string? QrCode { get; set; }

        [JsonPropertyName("qr_code_url")] public string? QrCodeUrl { get; set; }

        [JsonPropertyName("expires_at")] public DateTime? ExpiresAt { get; set; }
    }
}


