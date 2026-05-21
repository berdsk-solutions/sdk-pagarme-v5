using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    /// <summary>
    ///     Resposta com a listagem de recebedores.
    ///     <see href="https://docs.pagar.me/reference/listar-recebedores-1">Documentação Oficial PagarMe</see>
    /// </summary>
    public class PmListRecipientsResponse
    {
        /// <summary>
        ///     Lista de recebedores.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PmRecipientResponse> Data { get; set; }

        /// <summary>
        ///     Objeto de paginação.
        /// </summary>
        [JsonPropertyName("paging")]
        public PmPaging Paging { get; set; }
    }
}