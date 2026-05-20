using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    /// <summary>
    ///     Resposta com os detalhes de um recebedor.
    ///     <para>Referência: https://docs.pagar.me/reference/obter-recebedor-1.md</para>
    /// </summary>
    public class PmRecipientResponse
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

        [JsonPropertyName("deleted_at")] public DateTime? DeletedAt { get; set; }

        [JsonPropertyName("code")] public string Code { get; set; }

        [JsonPropertyName("default_bank_account")]
        public PmBankAccountResponse DefaultBankAccount { get; set; }

        [JsonPropertyName("transfer_settings")]
        public PmTransferSettingsResponse TransferSettings { get; set; }

        [JsonPropertyName("automatic_anticipation_settings")]
        public PmAnticipationSettingsResponse AutomaticAnticipationSettings { get; set; }

        [JsonPropertyName("register_information")]
        public PmRegisterInformationResponse RegisterInformation { get; set; }

        [JsonPropertyName("metadata")] public Dictionary<string, string> Metadata { get; set; }
    }
}