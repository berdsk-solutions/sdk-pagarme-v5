using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Exceptions
{
    /// <summary>
    ///     Representa um erro individual do gateway.
    /// </summary>
    public class PmGatewayError
    {
        /// <summary>
        ///     Mensagem de erro do gateway.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
