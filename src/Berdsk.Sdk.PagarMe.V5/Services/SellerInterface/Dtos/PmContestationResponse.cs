using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos
{
    /// <summary>
    ///     Representa uma contestação de contrato.
    /// </summary>
    public class PmContestationResponse
    {
        /// <summary>
        ///     Chave Identificadora da Contestação.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Status da Contestação.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Documento contestado.
        /// </summary>
        [JsonPropertyName("contested_document")]
        public string ContestedDocument { get; set; }

        /// <summary>
        ///     Documento do originador da UR.
        /// </summary>
        [JsonPropertyName("original_asset_holder_document")]
        public string OriginalAssetHolderDocument { get; set; }

        /// <summary>
        ///     Código do motivo da contestação.
        /// </summary>
        [JsonPropertyName("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        ///     Chave Identificadora do contrato.
        /// </summary>
        [JsonPropertyName("contract_key")]
        public string ContractKey { get; set; }

        /// <summary>
        ///     Data de Abertura da Contestação.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        ///     Descrição do motivo da contestação.
        /// </summary>
        [JsonPropertyName("reason_description")]
        public string ReasonDescription { get; set; }

        /// <summary>
        ///     Descrição adicional.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Pular contrato.
        /// </summary>
        [JsonPropertyName("skip_contract")]
        public bool SkipContract { get; set; }
    }
}


