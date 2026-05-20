using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Charge.Dtos
{
    /// <summary>
    ///     Requisição para capturar uma cobrança
    /// </summary>
    public class PmCaptureChargeRequest
    {
        /// <summary>
        ///     Valor a ser capturado em centavos. Se não enviado, captura o valor total.
        /// </summary>
        [JsonPropertyName("amount")]
        public int? Amount { get; set; }

        /// <summary>
        ///     Código de referência da captura
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }
    }
}