using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Disputes.Dtos
{
    /// <summary>
    ///     Representa um valor monetário em uma disputa.
    /// </summary>
    public class PmDisputeAmountResponse
    {
        /// <summary>
        ///     Valor monetário formatado (ex: "150.47").
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        ///     Código da moeda (ex: "BRL").
        /// </summary>
        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }
    }
}