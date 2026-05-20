using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Requisição para criação de pedido
    /// </summary>
    public class PmCreateOrderRequest
    {
        /// <summary>
        ///     Código identificador do pedido no sistema da loja. Max: 52 caracteres.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        ///     Itens do pedido.
        /// </summary>
        [JsonPropertyName("items")]
        public List<PmOrderItemRequest> Items { get; set; } = new List<PmOrderItemRequest>();

        /// <summary>
        ///     Código do cliente.
        /// </summary>
        [JsonPropertyName("customer_id")]
        public string? CustomerId { get; set; }

        /// <summary>
        ///     Dados do cliente. Obrigatório caso o customer_id não seja informado.
        /// </summary>
        [JsonPropertyName("customer")]
        public PmCreateCustomerRequest? Customer { get; set; }

        /// <summary>
        ///     Dados para entrega.
        /// </summary>
        [JsonPropertyName("shipping")]
        public PmOrderShippingRequest? Shipping { get; set; }

        /// <summary>
        ///     Lista de dados de pagamento.
        /// </summary>
        [JsonPropertyName("payments")]
        public List<PmOrderPaymentRequest> Payments { get; set; } = new List<PmOrderPaymentRequest>();

        /// <summary>
        ///     Informa se o pedido será criado aberto ou fechado
        /// </summary>
        [JsonPropertyName("closed")]
        public bool Closed { get; set; } = true;

        /// <summary>
        ///     Objeto chave/valor utilizado para armazenar informações adicionais sobre o pedido.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}