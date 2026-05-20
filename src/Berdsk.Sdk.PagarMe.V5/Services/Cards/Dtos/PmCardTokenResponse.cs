using System;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos
{
    /// <summary>
    ///     Resposta de criação de token de cartão.
    ///     <para>Referência: https://docs.pagar.me/reference/criar-token-cartão-1.md</para>
    /// </summary>
    public class PmCardTokenResponse
    {
        /// <summary>
        ///     Identificador do token.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Tipo do token (Ex: card).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Data de criação.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     Data de expiração do token.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        ///     Detalhes resumidos do cartão tokenizado.
        /// </summary>
        [JsonPropertyName("card")]
        public PmCardTokenDetailsResponse Card { get; set; }
    }
}