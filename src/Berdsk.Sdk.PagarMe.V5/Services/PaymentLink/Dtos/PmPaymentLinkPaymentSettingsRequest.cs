using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Configurações de pagamento do link.
    /// </summary>
    public class PmPaymentLinkPaymentSettingsRequest
    {
        /// <summary>
        ///     Meios de pagamento aceitos. Valores possíveis: "credit_card", "boleto", "pix", "debit_card", "voucher".
        /// </summary>
        [JsonPropertyName("accepted_payment_methods")]
        public List<string> AcceptedPaymentMethods { get; set; } = new List<string>();

        /// <summary>
        ///     Configurações de cartão de crédito.
        /// </summary>
        [JsonPropertyName("credit_card_settings")]
        public PmPaymentLinkCreditCardSettingsRequest? CreditCardSettings { get; set; }

        /// <summary>
        ///     Configurações de boleto.
        /// </summary>
        [JsonPropertyName("boleto_settings")]
        public PmPaymentLinkBoletoSettingsRequest? BoletoSettings { get; set; }

        /// <summary>
        ///     Configurações de Pix.
        /// </summary>
        [JsonPropertyName("pix_settings")]
        public PmPaymentLinkPixSettingsRequest? PixSettings { get; set; }
    }
}


