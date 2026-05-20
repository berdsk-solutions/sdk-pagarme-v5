using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Webhooks.Dtos
{
    /// <summary>
    ///     Representa a conta associada ao webhook.
    /// </summary>
    public class PmWebhookAccountResponse
    {
        /// <summary>
        ///     Identificador da conta.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Nome da conta.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}


