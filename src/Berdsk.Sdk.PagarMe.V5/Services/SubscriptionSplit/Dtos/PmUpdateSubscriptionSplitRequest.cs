using System.Text.Json.Serialization;
using System.Collections.Generic;
using Berdsk.Sdk.PagarMe.V5.Services.Common.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionSplit.Dtos
{
    /// <summary>
    ///     Requisição para editar as regras de split de uma assinatura.
    /// </summary>
    public class PmUpdateSubscriptionSplitRequest
    {
        /// <summary>
        ///     Indica se o split está ativo.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        ///     Regras de divisão do pagamento.
        /// </summary>
        [JsonPropertyName("rules")]
        public List<PmSplitRequest> Rules { get; set; } = new List<PmSplitRequest>();
    }
}


