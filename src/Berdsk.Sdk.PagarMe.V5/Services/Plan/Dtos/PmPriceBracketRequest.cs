using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos
{
    /// <summary>
    ///     Intervalo de preços para esquemas complexos.
    /// </summary>
    public class PmPriceBracketRequest
    {
        /// <summary>
        ///     Valor que define a quantidade inicial de unidades do intervalo.
        /// </summary>
        [JsonPropertyName("start_quantity")]
        public int StartQuantity { get; set; }

        /// <summary>
        ///     Valor que define a quantidade final de unidades do intervalo.
        /// </summary>
        [JsonPropertyName("end_quantity")]
        public int? EndQuantity { get; set; }

        /// <summary>
        ///     Valor para cálculo do preço por unidade que exceder o intervalo.
        /// </summary>
        [JsonPropertyName("overage_price")]
        public int? OveragePrice { get; set; }

        /// <summary>
        ///     Valor para cálculo do preço dentro do intervalo.
        /// </summary>
        [JsonPropertyName("price")]
        public int? Price { get; set; }
    }
}


