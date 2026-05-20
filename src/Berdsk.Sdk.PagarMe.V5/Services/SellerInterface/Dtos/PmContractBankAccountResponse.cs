using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos
{
    /// <summary>
    ///     Representa uma conta bancária vinculada a um contrato.
    /// </summary>
    public class PmContractBankAccountResponse
    {
        /// <summary>
        ///     Agência.
        /// </summary>
        [JsonPropertyName("branch")]
        public string Branch { get; set; }

        /// <summary>
        ///     Conta.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        ///     Dígito da conta.
        /// </summary>
        [JsonPropertyName("account_digit")]
        public string AccountDigit { get; set; }

        /// <summary>
        ///     Tipo de conta.
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        ///     ISPB do banco.
        /// </summary>
        [JsonPropertyName("ispb")]
        public string Ispb { get; set; }

        /// <summary>
        ///     Tipo de documento.
        /// </summary>
        [JsonPropertyName("document_type")]
        public string DocumentType { get; set; }

        /// <summary>
        ///     Número do documento.
        /// </summary>
        [JsonPropertyName("document_number")]
        public string DocumentNumber { get; set; }
    }
}


