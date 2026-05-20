using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Resposta de configurações de pagamento do link.
    /// </summary>
    public class PmPaymentLinkPaymentSettingsResponse
    {
        /// <summary>
        ///     Meios de pagamento aceitos.
        /// </summary>
        [JsonPropertyName("accepted_payment_methods")]
        public List<string> AcceptedPaymentMethods { get; set; }

        /// <summary>
        ///     Configurações de cartão de crédito.
        /// </summary>
        [JsonPropertyName("credit_card_settings")]
        public PmPaymentLinkCreditCardSettingsResponse? CreditCardSettings { get; set; }
    }
}