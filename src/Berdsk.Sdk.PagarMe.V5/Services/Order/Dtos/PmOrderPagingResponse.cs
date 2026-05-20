using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Informações de paginação da listagem de pedidos
    /// </summary>
    public class PmOrderPagingResponse
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