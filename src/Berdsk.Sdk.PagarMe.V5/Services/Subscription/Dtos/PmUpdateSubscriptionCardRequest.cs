using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos
{
    /// <summary>
    ///     Requisição para atualização de cartão da assinatura.
    /// </summary>
    public class PmUpdateSubscriptionCardRequest
    {
        /// <summary>
        ///     Dados do novo cartão.
        /// </summary>
        [JsonPropertyName("card")]
        public PmCreateCardRequest? Card { get; set; }

        /// <summary>
        ///     ID do cartão já cadastrado.
        /// </summary>
        [JsonPropertyName("card_id")]
        public string? CardId { get; set; }
    }
}


