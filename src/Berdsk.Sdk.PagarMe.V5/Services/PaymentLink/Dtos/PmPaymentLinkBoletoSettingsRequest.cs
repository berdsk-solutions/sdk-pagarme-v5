using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Configurações de boleto para link de pagamento.
    /// </summary>
    public class PmPaymentLinkBoletoSettingsRequest
    {
        /// <summary>
        ///     Instruções do boleto. Max: 256 caracteres.
        /// </summary>
        [JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///     Prazo de vencimento em dias.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }
    }
}


