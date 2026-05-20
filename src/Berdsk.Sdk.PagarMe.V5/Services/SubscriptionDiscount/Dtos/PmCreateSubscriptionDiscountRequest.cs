using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionDiscount.Dtos
{
    /// <summary>
    ///     Requisição para incluir um desconto em uma assinatura.
    /// </summary>
    public class PmCreateSubscriptionDiscountRequest
    {
        /// <summary>
        ///     Valor do desconto. (Em centavos se for flat, ou valor inteiro se for percentage).
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }

        /// <summary>
        ///     Tipo do desconto. Valores possíveis: flat (valor fixo) ou percentage (percentual).
        /// </summary>
        [JsonPropertyName("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        ///     Código do item da assinatura.
        /// </summary>
        [JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        ///     Número de ciclos que o desconto será aplicado. Caso não seja enviado, o desconto será vitalício.
        /// </summary>
        [JsonPropertyName("cycles")]
        public int? Cycles { get; set; }

        /// <summary>
        ///     Descrição do desconto.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}


