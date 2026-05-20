using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Disputes.Dtos
{
    /// <summary>
    ///     Representa o motivo de uma disputa.
    /// </summary>
    public class PmDisputeReasonResponse
    {
        /// <summary>
        ///     Código do motivo do chargeback.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        ///     Descrição do motivo do chargeback.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}