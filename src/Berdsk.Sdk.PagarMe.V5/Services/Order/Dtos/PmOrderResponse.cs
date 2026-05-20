using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Resposta de pedido
    /// </summary>
    public class PmOrderResponse
    {
        /// <summary>
        ///     Identificador do pedido
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Código identificador do pedido no sistema da loja
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        ///     Valor total do pedido em centavos
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        ///     Valor pago do pedido em centavos
        /// </summary>
        [JsonPropertyName("paid_amount")]
        public int PaidAmount { get; set; }

        /// <summary>
        ///     Status do pedido (pending, paid, canceled, failed)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Moeda (BRL)
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        ///     Informa se o pedido está fechado
        /// </summary>
        [JsonPropertyName("closed")]
        public bool Closed { get; set; }

        /// <summary>
        ///     Itens do pedido
        /// </summary>
        [JsonPropertyName("items")]
        public List<PmOrderItemResponse> Items { get; set; } = new List<PmOrderItemResponse>();

        /// <summary>
        ///     Dados do cliente
        /// </summary>
        [JsonPropertyName("customer")]
        public PmCustomerResponse? Customer { get; set; }

        /// <summary>
        ///     Cobranças do pedido
        /// </summary>
        [JsonPropertyName("charges")]
        public List<PmOrderChargeResponse> Charges { get; set; } = new List<PmOrderChargeResponse>();

        /// <summary>
        ///     Data de criação
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     Data de atualização
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        ///     Data de fechamento
        /// </summary>
        [JsonPropertyName("closed_at")]
        public DateTime? ClosedAt { get; set; }
    }
}