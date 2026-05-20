using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Configurações do carrinho de compras do link.
    /// </summary>
    public class PmPaymentLinkCartSettingsRequest
    {
        /// <summary>
        ///     Itens do carrinho. (Usado quando type é "order")
        /// </summary>
        [JsonPropertyName("items")]
        public List<PmPaymentLinkItemRequest>? Items { get; set; }

        /// <summary>
        ///     Recorrências do carrinho. (Usado quando type é "subscription")
        /// </summary>
        [JsonPropertyName("recurrences")]
        public List<PmPaymentLinkRecurrenceRequest>? Recurrences { get; set; }
    }
}