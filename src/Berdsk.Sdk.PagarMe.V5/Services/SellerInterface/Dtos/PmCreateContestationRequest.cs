using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos
{
    /// <summary>
    ///     Requisição para criar uma contestação de contrato.
    /// </summary>
    public class PmCreateContestationRequest
    {
        /// <summary>
        ///     Autor da contestação.
        /// </summary>
        [JsonPropertyName("author")]
        public PmContestationAuthorRequest Author { get; set; }

        /// <summary>
        ///     Seller originador do recebível.
        /// </summary>
        [JsonPropertyName("original_asset_holder")]
        public PmContestationAssetHolderRequest OriginalAssetHolder { get; set; }

        /// <summary>
        ///     Credor (Asset Holder).
        /// </summary>
        [JsonPropertyName("contested")]
        public PmContestationAssetHolderRequest Contested { get; set; }

        /// <summary>
        ///     Contrato alvo.
        /// </summary>
        [JsonPropertyName("target")]
        public PmContestationTargetRequest Target { get; set; }

        /// <summary>
        ///     Código do motivo da contestação.
        /// </summary>
        [JsonPropertyName("reason_code")]
        public string ReasonCode { get; set; }
    }
}