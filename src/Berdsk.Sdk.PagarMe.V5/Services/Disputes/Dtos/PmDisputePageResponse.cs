using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Disputes.Dtos
{
    /// <summary>
    ///     Informações de paginação para disputas.
    /// </summary>
    public class PmDisputePageResponse
    {
        /// <summary>
        ///     Identificador para o início da próxima página.
        /// </summary>
        [JsonPropertyName("forwardCursor")]
        public string ForwardCursor { get; set; }
    }
}