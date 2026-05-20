using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Item do pedido
    /// </summary>
    public class PmOrderItemRequest
    {
        /// <summary>
        ///     Valor unitário. Obrigatoriamente maior que zero. Em centavos.
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        ///     Descrição do item.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Quantidade de itens.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        ///     Código do item no sistema da loja.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}