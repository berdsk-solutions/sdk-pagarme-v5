using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Item do carrinho no link de pagamento.
    /// </summary>
    public class PmPaymentLinkItemRequest
    {
        /// <summary>
        ///     Valor do item em centavos.
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        ///     Nome do item. Max: 64 caracteres.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Descrição do item. Max: 256 caracteres.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///     Quantidade padrão.
        /// </summary>
        [JsonPropertyName("default_quantity")]
        public int DefaultQuantity { get; set; } = 1;

        /// <summary>
        ///     Código de referência do item.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }
    }
}