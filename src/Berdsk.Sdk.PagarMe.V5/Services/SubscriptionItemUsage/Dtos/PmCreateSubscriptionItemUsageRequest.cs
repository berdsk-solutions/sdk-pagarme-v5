using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItemUsage.Dtos
{
    /// <summary>
    ///     Requisição para registrar o uso de um item de assinatura.
    /// </summary>
    public class PmCreateSubscriptionItemUsageRequest
    {
        /// <summary>
        ///     Quantidade utilizada.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        ///     Descrição do uso.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Data em que o uso ocorreu.
        /// </summary>
        [JsonPropertyName("used_at")]
        public DateTime? UsedAt { get; set; }
    }
}


