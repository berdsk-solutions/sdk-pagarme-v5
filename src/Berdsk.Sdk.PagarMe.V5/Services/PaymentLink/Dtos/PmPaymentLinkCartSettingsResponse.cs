using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Resposta de configurações do carrinho do link.
    /// </summary>
    public class PmPaymentLinkCartSettingsResponse
    {
        /// <summary>
        ///     Itens do carrinho.
        /// </summary>
        [JsonPropertyName("items")]
        public List<PmPaymentLinkItemResponse>? Items { get; set; }

        /// <summary>
        ///     Custo total dos itens.
        /// </summary>
        [JsonPropertyName("items_total_cost")]
        public int ItemsTotalCost { get; set; }

        /// <summary>
        ///     Custo total.
        /// </summary>
        [JsonPropertyName("total_cost")]
        public int TotalCost { get; set; }

        /// <summary>
        ///     Custo de frete.
        /// </summary>
        [JsonPropertyName("shipping_cost")]
        public int ShippingCost { get; set; }
    }
}


