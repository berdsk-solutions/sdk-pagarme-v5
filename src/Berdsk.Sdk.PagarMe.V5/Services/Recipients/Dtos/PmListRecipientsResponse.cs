using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    /// <summary>
    ///     Resposta com a listagem de recebedores.
    ///     <para>Referência: https://docs.pagar.me/reference/listar-recebedores-1.md</para>
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


