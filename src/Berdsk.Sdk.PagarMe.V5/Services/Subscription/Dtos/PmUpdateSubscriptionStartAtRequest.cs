using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos
{
    /// <summary>
    ///     Requisição para atualização de data de início da assinatura.
    /// </summary>
    public class PmUpdateSubscriptionStartAtRequest
    {
        /// <summary>
        ///     Nova data de início.
        /// </summary>
        [JsonPropertyName("start_at")]
        public DateTime StartAt { get; set; }
    }
}


