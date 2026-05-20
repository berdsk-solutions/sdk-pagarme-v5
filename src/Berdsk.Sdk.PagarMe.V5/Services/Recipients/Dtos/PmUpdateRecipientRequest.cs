using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    /// <summary>
    ///     Requisição para editar um recebedor.
    ///     <see href="https://docs.pagar.me/reference/editar-recebedor-1">Documentação Oficial PagarMe</see>
    /// </summary>
    public class PmUpdateRecipientRequest
    {
        /// <summary>
        ///     Nome do recebedor.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     E-mail do recebedor.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        ///     Descrição do recebedor.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Tipo do recebedor.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Status do recebedor.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Metadados.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}