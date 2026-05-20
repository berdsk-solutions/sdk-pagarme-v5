using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos
{
    /// <summary>
    ///     Requisição para atualização de metadados da assinatura.
    /// </summary>
    public class PmUpdateSubscriptionMetadataRequest
    {
        /// <summary>
        ///     Novos metadados.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}


