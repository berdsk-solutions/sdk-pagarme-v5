using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Configurações de parcelamento para link de pagamento.
    /// </summary>
    public class PmPaymentLinkInstallmentsSetupRequest
    {
        /// <summary>
        ///     Quantidade máxima de parcelas.
        /// </summary>
        [JsonPropertyName("max_installments")]
        public int MaxInstallments { get; set; }

        /// <summary>
        ///     Valor mínimo de cada parcela.
        /// </summary>
        [JsonPropertyName("amount")]
        public int? Amount { get; set; }

        /// <summary>
        ///     Tipo de juros. Valores possíveis: "simple", "compound".
        /// </summary>
        [JsonPropertyName("interest_type")]
        public string? InterestType { get; set; }

        /// <summary>
        ///     Taxa de juros.
        /// </summary>
        [JsonPropertyName("interest_rate")]
        public decimal? InterestRate { get; set; }

        /// <summary>
        ///     Quantidade de parcelas sem juros.
        /// </summary>
        [JsonPropertyName("free_installments")]
        public int? FreeInstallments { get; set; }
    }
}


