using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientAnticipationService.Dtos
{
    /// <summary>
    ///     Requisição para atualizar as configurações de antecipação automática.
    /// </summary>
    public class PmUpdateAutomaticAnticipationSettingsRequest
    {
        /// <summary>
        ///     Indica se a antecipação automática está habilitada.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///     Tipo de antecipação automática. Valores possíveis: full ou constant.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///     Percentual do volume a ser antecipado (0 a 100).
        /// </summary>
        [JsonPropertyName("volume_percentage")]
        public int? VolumePercentage { get; set; }

        /// <summary>
        ///     Delay da antecipação automática em dias.
        /// </summary>
        [JsonPropertyName("delay")]
        public int? Delay { get; set; }
    }
}


