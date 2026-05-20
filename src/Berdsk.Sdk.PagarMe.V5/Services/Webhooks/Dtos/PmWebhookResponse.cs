using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Webhooks.Dtos
{
    /// <summary>
    ///     Representa um webhook enviado pelo Pagar.me.
    /// </summary>
    public class PmWebhookResponse
    {
        /// <summary>
        ///     Identificador único do webhook.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     URL para a qual o webhook foi enviado.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        ///     Conta associada ao webhook.
        /// </summary>
        [JsonPropertyName("account")]
        public PmWebhookAccountResponse Account { get; set; }

        /// <summary>
        ///     Evento que disparou o webhook.
        /// </summary>
        [JsonPropertyName("event")]
        public string Event { get; set; }

        /// <summary>
        ///     Status do envio do webhook.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Número de tentativas de envio (ex: "3/3").
        /// </summary>
        [JsonPropertyName("attempts")]
        public string Attempts { get; set; }

        /// <summary>
        ///     Data da última tentativa de envio.
        /// </summary>
        [JsonPropertyName("last_attempt")]
        public string LastAttempt { get; set; }

        /// <summary>
        ///     Data de criação do webhook.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        ///     Código de status HTTP retornado pelo servidor de destino.
        /// </summary>
        [JsonPropertyName("response_status")]
        public int ResponseStatus { get; set; }

        /// <summary>
        ///     Resposta bruta retornada pelo servidor de destino.
        /// </summary>
        [JsonPropertyName("response_raw")]
        public string ResponseRaw { get; set; }

        /// <summary>
        ///     Dados do recurso associado ao evento. O conteúdo varia conforme o tipo de evento.
        /// </summary>
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }
}


