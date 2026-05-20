using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Informações adicionais do Pix para link de pagamento.
    /// </summary>
    public class PmPaymentLinkPixAdditionalInformationRequest
    {
        /// <summary>
        ///     Nome do campo.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Valor do campo.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}