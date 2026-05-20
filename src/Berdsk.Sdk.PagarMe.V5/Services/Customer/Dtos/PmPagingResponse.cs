using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos
{
    /// <summary>
    ///     Informações de paginação da API PagarMe
    /// </summary>
    public class PmPagingResponse
    {
        /// <summary>
        ///     Total de registros
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        ///     URL para a próxima página
        /// </summary>
        [JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        ///     URL para a página anterior
        /// </summary>
        [JsonPropertyName("previous")]
        public string? Previous { get; set; }
    }
}


