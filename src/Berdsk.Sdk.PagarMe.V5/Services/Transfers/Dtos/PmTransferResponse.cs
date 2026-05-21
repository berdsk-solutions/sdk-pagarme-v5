using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Transfers.Dtos
{
    /// <summary>
    ///     Resposta de uma transferência.
    ///     <see href="https://docs.pagar.me/reference/objeto-transferência">Documentação Oficial PagarMe</see>
    /// </summary>
    public class PmTransferResponse
    {
        [JsonPropertyName("object")] public string Object { get; set; }

        [JsonPropertyName("id")] public long Id { get; set; }

        [JsonPropertyName("amount")] public long Amount { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }

        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("fee")] public long Fee { get; set; }

        [JsonPropertyName("funding_date")] public DateTime? FundingDate { get; set; }

        [JsonPropertyName("funding_estimated_date")]
        public DateTime? FundingEstimatedDate { get; set; }

        [JsonPropertyName("transaction_id")] public long? TransactionId { get; set; }

        [JsonPropertyName("date_created")] public DateTime DateCreated { get; set; }

        [JsonPropertyName("bank_account")] public PmBankAccountResponse BankAccount { get; set; }

        [JsonPropertyName("metadata")] public Dictionary<string, string> Metadata { get; set; }

        [JsonPropertyName("source_type")] public string SourceType { get; set; }

        [JsonPropertyName("source_id")] public string SourceId { get; set; }

        [JsonPropertyName("target_type")] public string TargetType { get; set; }

        [JsonPropertyName("target_id")] public string TargetId { get; set; }

        [JsonPropertyName("bank_response")] public string BankResponse { get; set; }
    }
}