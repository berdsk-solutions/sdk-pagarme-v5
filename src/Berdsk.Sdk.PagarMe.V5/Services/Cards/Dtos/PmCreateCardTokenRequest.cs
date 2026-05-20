using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos
{
    /// <summary>
    ///     Requisição para criação de token de cartão.
    ///     <para>Referência: https://docs.pagar.me/reference/criar-token-cartão-1.md</para>
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


