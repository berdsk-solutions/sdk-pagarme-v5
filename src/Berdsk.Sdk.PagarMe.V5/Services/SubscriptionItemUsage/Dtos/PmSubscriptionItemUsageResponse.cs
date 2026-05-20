using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItemUsage.Dtos
{
    /// <summary>
    ///     Resposta do registro de uso de um item de assinatura.
    /// </summary>
    public class PmSubscriptionItemUsageResponse
    {
        /// <summary>
        ///     Identificador do uso.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

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
        public DateTime UsedAt { get; set; }

        /// <summary>
        ///     Data de criação do registro.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     Status do uso.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Data de exclusão do registro, se aplicável.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public DateTime? DeletedAt { get; set; }
    }
}


