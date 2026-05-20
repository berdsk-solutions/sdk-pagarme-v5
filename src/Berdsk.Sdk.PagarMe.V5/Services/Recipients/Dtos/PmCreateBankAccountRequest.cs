using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    public class PmCreateBankAccountRequest
    {
        [JsonPropertyName("holder_name")] public string HolderName { get; set; }

        [JsonPropertyName("holder_type")] public string HolderType { get; set; }

        [JsonPropertyName("holder_document")] public string HolderDocument { get; set; }

        [JsonPropertyName("bank")] public string Bank { get; set; }

        [JsonPropertyName("branch_number")] public string BranchNumber { get; set; }

        [JsonPropertyName("branch_check_digit")]
        public string BranchCheckDigit { get; set; }

        [JsonPropertyName("account_number")] public string AccountNumber { get; set; }

        [JsonPropertyName("account_check_digit")]
        public string AccountCheckDigit { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }

        [JsonPropertyName("metadata")] public Dictionary<string, string> Metadata { get; set; }
    }
}


