using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos
{
    /// <summary>
    ///     Requisição para atualização do preço mínimo da assinatura.
    /// </summary>
    public class PmUpdateSubscriptionMinimumPriceRequest
    {
        /// <summary>
        ///     Novo preço mínimo.
        /// </summary>
        [JsonPropertyName("minimum_price")]
        public int? MinimumPrice { get; set; }
    }
}


