using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Common.Dtos
{
    /// <summary>
    ///     Regra de divisão de pagamento (Split).
    /// </summary>
    public class PmSplitRequest
    {
        /// <summary>
        ///     Valor destinado ao recebedor.
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        ///     Código do recebedor. Formato: rp_XXXXXXXXXXXXXXXX.
        /// </summary>
        [JsonPropertyName("recipient_id")]
        public string RecipientId { get; set; }

        /// <summary>
        ///     Tipo de divisão. Os valores possíveis são flat ou percentage.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Informações da responsabilidade do recebedor na transação.
        /// </summary>
        [JsonPropertyName("options")]
        public PmSplitOptionsRequest? Options { get; set; }
    }
}


