using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos
{
    /// <summary>
    ///     Requisição para atualização de metadados do plano.
    /// </summary>
    public class PmUpdatePlanMetadataRequest
    {
        /// <summary>
        ///     Novos metadados.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}