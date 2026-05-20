using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos
{
    /// <summary>
    ///     Requisição para atualização de meio de pagamento da assinatura.
    /// </summary>
    public class PmUpdateSubscriptionPaymentMethodRequest
    {
        /// <summary>
        ///     Novo meio de pagamento.
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        ///     Dados do cartão (se necessário).
        /// </summary>
        [JsonPropertyName("card")]
        public PmCreateCardRequest? Card { get; set; }

        /// <summary>
        ///     ID do cartão (se necessário).
        /// </summary>
        [JsonPropertyName("card_id")]
        public string? CardId { get; set; }
    }
}


