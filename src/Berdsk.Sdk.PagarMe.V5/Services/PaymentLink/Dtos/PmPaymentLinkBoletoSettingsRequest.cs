using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Configurações de boleto para link de pagamento.
    /// </summary>
    public class PmPaymentLinkBoletoSettingsRequest
    {
        /// <summary>
        ///     Instruções do boleto. Máximo 255 caracteres.
        /// </summary>
        [JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///     Define quantidade de tempo para expiração do boleto a partir do momento que o mesmo é gerado. Valor em dias. Não deverá ser enviado caso o campo "due_at" seja definido.
        /// </summary>
        [JsonPropertyName("due_in")]
        public int? DueIn { get; set; }

        /// <summary>
        ///     Define a data de expiração do boleto gerado. Formato ISO 8601. Não deverá ser enviado caso o campo "due_in" seja definido.
        /// </summary>
        [JsonPropertyName("due_at")]
        public string? DueAt { get; set; }

        /// <summary>
        ///     Valor de desconto a ser aplicado ao boleto, em centavos. Não deve ser enviado caso o campo "discount_percentage" seja definido.
        /// </summary>
        [JsonPropertyName("discount")]
        public int? Discount { get; set; }

        /// <summary>
        ///     Valor de desconto a ser aplicado ao boleto, em porcentagem. Não deve ser enviado caso o campo "discount" seja definido.
        /// </summary>
        [JsonPropertyName("discount_percentage")]
        public double? DiscountPercentage { get; set; }
    }
}