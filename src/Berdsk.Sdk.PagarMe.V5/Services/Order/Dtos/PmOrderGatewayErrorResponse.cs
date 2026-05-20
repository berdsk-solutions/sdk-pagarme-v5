using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Resposta de erro do gateway
    /// </summary>
    public class PmOrderGatewayErrorResponse
    {
        [JsonPropertyName("message")] public string Message { get; set; }

        [JsonPropertyName("code")] public string Code { get; set; }
    }
}


