using System.Text.Json.Serialization;
using System.Collections.Generic;
using Berdsk.Sdk.PagarMe.V5.Services.Common.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionSplit.Dtos
{
    /// <summary>
    ///     Resposta das regras de split de uma assinatura.
    /// </summary>
    public class PmSubscriptionSplitResponse
    {
        [JsonPropertyName("enabled")] public bool Enabled { get; set; }

        [JsonPropertyName("rules")] public List<PmSplitRequest> Rules { get; set; } = new List<PmSplitRequest>();
    }
}


