using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Resposta do gateway
    /// </summary>
    public class PmOrderGatewayResponse
    {
        [JsonPropertyName("code")] public string Code { get; set; }

        [JsonPropertyName("errors")] public List<PmOrderGatewayErrorResponse>? Errors { get; set; }
    }
}