using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    /// <summary>
    ///     Requisição para atualizar o código de referência externa de um recebedor.
    ///     <see href="https://docs.pagar.me/reference/atualizar-code-de-recebedor">Documentação Oficial PagarMe</see>
    /// </summary>
    public class PmUpdateRecipientCodeRequest
    {
        /// <summary>
        ///     Novo código de referência externa.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}