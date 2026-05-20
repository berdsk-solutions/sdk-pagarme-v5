using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Resposta de configurações de cartão de crédito do link.
    /// </summary>
    public class PmPaymentLinkCreditCardSettingsResponse
    {
        /// <summary>
        ///     Tipo de operação.
        /// </summary>
        [JsonPropertyName("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        ///     Parcelas calculadas.
        /// </summary>
        [JsonPropertyName("installments")]
        public List<PmPaymentLinkInstallmentResponse>? Installments { get; set; }
    }
}


