using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionIncrement.Dtos
{
    /// <summary>
    ///     Requisição para incluir um incremento em uma assinatura.
    /// </summary>
    public class PmCreateSubscriptionIncrementRequest
    {
        /// <summary>
        ///     Valor do incremento. (Em centavos se for flat, ou valor inteiro se for percentage).
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }

        /// <summary>
        ///     Tipo do incremento. Valores possíveis: flat (valor fixo) ou percentage (percentual).
        /// </summary>
        [JsonPropertyName("increment_type")]
        public string IncrementType { get; set; }

        /// <summary>
        ///     Código do item da assinatura.
        /// </summary>
        [JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        ///     Número de ciclos que o incremento será aplicado. Caso não seja enviado, o incremento será vitalício.
        /// </summary>
        [JsonPropertyName("cycles")]
        public int? Cycles { get; set; }

        /// <summary>
        ///     Descrição do incremento.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}


