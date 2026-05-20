using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Resposta de parcela no link de pagamento.
    /// </summary>
    public class PmPaymentLinkInstallmentResponse
    {
        /// <summary>
        ///     Número da parcela.
        /// </summary>
        [JsonPropertyName("number")]
        public int Number { get; set; }

        /// <summary>
        ///     Valor total da parcela em centavos.
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}


