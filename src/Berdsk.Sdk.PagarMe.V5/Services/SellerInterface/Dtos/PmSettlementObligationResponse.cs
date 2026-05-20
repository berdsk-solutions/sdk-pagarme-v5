using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos
{
    /// <summary>
    ///     Representa um efeito de contrato (obrigação de liquidação).
    /// </summary>
    public class PmSettlementObligationResponse
    {
        /// <summary>
        ///     Data esperada de liquidação.
        /// </summary>
        [JsonPropertyName("expected_settlement_date")]
        public string ExpectedSettlementDate { get; set; }

        /// <summary>
        ///     Documento do originador do recebível.
        /// </summary>
        [JsonPropertyName("original_asset_holder")]
        public string OriginalAssetHolder { get; set; }

        /// <summary>
        ///     Lista de obrigações de liquidação detalhadas.
        /// </summary>
        [JsonPropertyName("settlement_obligations")]
        public List<PmSettlementObligationItemResponse> SettlementObligations { get; set; } =
            new List<PmSettlementObligationItemResponse>();
    }
}