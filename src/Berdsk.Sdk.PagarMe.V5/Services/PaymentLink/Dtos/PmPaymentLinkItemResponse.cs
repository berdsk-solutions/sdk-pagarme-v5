using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Resposta de item do carrinho no link de pagamento.
    /// </summary>
    public class PmPaymentLinkItemResponse
    {
        /// <summary>
        ///     Valor do item em centavos.
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        ///     Nome do item.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Quantidade padrão.
        /// </summary>
        [JsonPropertyName("default_quantity")]
        public int DefaultQuantity { get; set; }

        /// <summary>
        ///     Descrição do item.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}


