using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Disputes.Dtos
{
    /// <summary>
    ///     Representa um evento no ciclo de vida de uma disputa.
    /// </summary>
    public class PmDisputeEventResponse
    {
        /// <summary>
        ///     Tipo do evento relacionado à disputa.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Data da criação do evento.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    }
}


