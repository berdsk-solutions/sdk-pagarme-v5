using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Exceptions
{
    /// <summary>
    ///     Detalhes da resposta do gateway.
    /// </summary>
    public class PmGatewayResponse
    {
        /// <summary>
        ///     Código retornado pelo gateway.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        ///     Lista de erros retornados pelo gateway.
        /// </summary>
        [JsonPropertyName("errors")]
        public PmGatewayError[]? Errors { get; set; }
    }
}
