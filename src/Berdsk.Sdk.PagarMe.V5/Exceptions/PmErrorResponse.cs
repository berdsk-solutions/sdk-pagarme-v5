using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Exceptions
{
    /// <summary>
    ///     Representa a resposta de erro da API Pagar.me.
    /// </summary>
    public class PmErrorResponse
    {
        /// <summary>
        ///     Mensagem geral do erro.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        /// <summary>
        ///     Dicionário de erros de validação, onde a chave é o campo e o valor é uma lista de mensagens de erro.
        /// </summary>
        [JsonPropertyName("errors")]
        public Dictionary<string, string[]>? Errors { get; set; }

        /// <summary>
        ///     Detalhes da resposta do gateway (comum em integrações PSP).
        /// </summary>
        [JsonPropertyName("gateway_response")]
        public PmGatewayResponse? GatewayResponse { get; set; }
    }
}
