using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Configurações de Pix para link de pagamento.
    /// </summary>
    public class PmPaymentLinkPixSettingsRequest
    {
        /// <summary>
        ///     Prazo de vencimento em segundos.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        ///     Informações adicionais do Pix.
        /// </summary>
        [JsonPropertyName("additional_information")]
        public List<PmPaymentLinkPixAdditionalInformationRequest>? AdditionalInformation { get; set; }
    }
}


