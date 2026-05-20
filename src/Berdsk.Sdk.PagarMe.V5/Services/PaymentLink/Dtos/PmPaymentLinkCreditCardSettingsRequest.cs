using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Configurações de cartão de crédito para link de pagamento.
    /// </summary>
    public class PmPaymentLinkCreditCardSettingsRequest
    {
        /// <summary>
        ///     Tipo de operação. Valores possíveis: "auth_only", "auth_and_capture".
        /// </summary>
        [JsonPropertyName("operation_type")]
        public string OperationType { get; set; } = "auth_and_capture";

        /// <summary>
        ///     Configurações de parcelamento.
        /// </summary>
        [JsonPropertyName("installments_setup")]
        public PmPaymentLinkInstallmentsSetupRequest? InstallmentsSetup { get; set; }
    }
}


