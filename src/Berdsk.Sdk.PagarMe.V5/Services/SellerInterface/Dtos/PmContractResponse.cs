using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos
{
    /// <summary>
    ///     Representa um contrato de seller.
    /// </summary>
    public class PmContractResponse
    {
        /// <summary>
        ///     Chave do contrato.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        ///     Tipo de contrato.
        /// </summary>
        [JsonPropertyName("contract_type")]
        public string ContractType { get; set; }

        /// <summary>
        ///     Data da criação.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        ///     Indica se o contrato está cancelado.
        /// </summary>
        [JsonPropertyName("is_canceled")]
        public bool IsCanceled { get; set; }

        /// <summary>
        ///     Documento do credor.
        /// </summary>
        [JsonPropertyName("contract_holder")]
        public string ContractHolder { get; set; }

        /// <summary>
        ///     Lista de contas bancárias (domicílio bancário).
        /// </summary>
        [JsonPropertyName("bank_accounts")]
        public List<PmContractBankAccountResponse> BankAccounts { get; set; } = new List<PmContractBankAccountResponse>();

        /// <summary>
        ///     Registradora do credor.
        /// </summary>
        [JsonPropertyName("trade_repository")]
        public string TradeRepository { get; set; }
    }
}


