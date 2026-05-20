using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Configurações de cliente para link de pagamento.
    /// </summary>
    public class PmPaymentLinkCustomerSettingsRequest
    {
        /// <summary>
        ///     Identificador do cliente existente.
        /// </summary>
        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }
    }
}


