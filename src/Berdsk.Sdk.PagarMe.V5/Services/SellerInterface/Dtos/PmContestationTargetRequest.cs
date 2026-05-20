using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos
{
    /// <summary>
    ///     Detalhes do contrato alvo da contestação.
    /// </summary>
    public class PmContestationTargetRequest
    {
        /// <summary>
        ///     Chave do contrato obtida no endpoint settlement_obligations.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        ///     Tipo do contrato. Sempre utilizar "Contract".
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = "Contract";
    }
}


