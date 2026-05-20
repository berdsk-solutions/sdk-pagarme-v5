using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.OrderItem.Dtos
{
    /// <summary>
    ///     Requisição para editar um item do pedido
    /// </summary>
    public class PmUpdateOrderItemRequest
    {
        /// <summary>
        ///     Valor unitário em centavos
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        ///     Descrição do item
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Quantidade
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        ///     Categoria do item
        /// </summary>
        [JsonPropertyName("category")]
        public string? Category { get; set; }
    }
}