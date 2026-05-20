using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos
{
    /// <summary>
    ///     Item da assinatura para criação.
    /// </summary>
    public class PmCreateSubscriptionItemRequest
    {
        /// <summary>
        ///     Descrição do item.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Quantidade.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        ///     Esquema de precificação.
        /// </summary>
        [JsonPropertyName("pricing_scheme")]
        public PmPricingSchemeRequest PricingScheme { get; set; }

        /// <summary>
        ///     Código de referência do item no seu sistema.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        ///     Nome do item.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Número de ciclos que o item será cobrado.
        /// </summary>
        [JsonPropertyName("cycles")]
        public int? Cycles { get; set; }
    }
}