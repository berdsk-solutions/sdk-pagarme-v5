using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos
{
    /// <summary>
    ///     Requisição para criação de token de cartão.
    ///     <see href="https://docs.pagar.me/reference/criar-token-cartão-1">Documentação Oficial PagarMe</see>
    /// </summary>
    public class PmCreateCardTokenRequest
    {
        /// <summary>
        ///     Tipo do cartão. Geralmente "card".
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = "card";

        /// <summary>
        ///     Informações do cartão a ser tokenizado.
        /// </summary>
        [JsonPropertyName("card")]
        public PmCardTokenDetailsRequest Card { get; set; }
    }
}