using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.CardBin.Dtos
{
    /// <summary>
    ///     Resposta com informações do BIN do cartão
    /// </summary>
    public class PmBinResponse
    {
        /// <summary>
        ///     Bandeira do cartão
        /// </summary>
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        ///     Nome da bandeira
        /// </summary>
        [JsonPropertyName("brandName")]
        public string BrandName { get; set; }

        /// <summary>
        ///     Gaps na máscara do cartão
        /// </summary>
        [JsonPropertyName("gaps")]
        public List<int> Gaps { get; set; } = new List<int>();

        /// <summary>
        ///     Comprimentos possíveis do cartão
        /// </summary>
        [JsonPropertyName("lenghts")]
        public List<int> Lenghts { get; set; } = new List<int>();

        /// <summary>
        ///     Máscara do cartão
        /// </summary>
        [JsonPropertyName("mask")]
        public string Mask { get; set; }

        /// <summary>
        ///     Input do cartão
        /// </summary>
        [JsonPropertyName("input")]
        public string Input { get; set; }

        /// <summary>
        ///     Tamanho do CVV
        /// </summary>
        [JsonPropertyName("cvv")]
        public int Cvv { get; set; }
    }
}