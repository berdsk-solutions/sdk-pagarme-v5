using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos
{
    /// <summary>
    ///     Detalhes do cartão na resposta do token.
    /// </summary>
    public class PmCardTokenDetailsResponse
    {
        /// <summary>
        ///     Quatro últimos dígitos.
        /// </summary>
        [JsonPropertyName("last_four_digits")]
        public string LastFourDigits { get; set; }

        /// <summary>
        ///     Nome do portador.
        /// </summary>
        [JsonPropertyName("holder_name")]
        public string HolderName { get; set; }

        /// <summary>
        ///     Mês de validade.
        /// </summary>
        [JsonPropertyName("exp_month")]
        public int ExpMonth { get; set; }

        /// <summary>
        ///     Ano de validade.
        /// </summary>
        [JsonPropertyName("exp_year")]
        public int ExpYear { get; set; }

        /// <summary>
        ///     Bandeira.
        /// </summary>
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        ///     Label.
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; }
    }
}