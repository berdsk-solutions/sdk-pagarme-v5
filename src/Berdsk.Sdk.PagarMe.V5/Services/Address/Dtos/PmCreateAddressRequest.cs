using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Berdsk.Sdk.PagarMe.V5.Services.Address.Dtos
{
    /// <summary>
    ///     Requisição para criação de endereço
    /// </summary>
    public class PmCreateAddressRequest
    {
        /// <summary>
        ///     Linha 1 do endereço. (Número, Rua, e Bairro - Nesta ordem e separados por vírgula) Max: 256 caracteres.
        /// </summary>
        [JsonPropertyName("line_1")]
        public string Line1 { get; set; }

        /// <summary>
        ///     Linha 2 do endereço. (Complemento - Andar, Sala, Apto). Max: 128 caracteres.
        /// </summary>
        [JsonPropertyName("line_2")]
        public string? Line2 { get; set; }

        /// <summary>
        ///     CEP. Max: 16 caracteres. (Apenas numérico)
        /// </summary>
        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }

        /// <summary>
        ///     Cidade. Max: 64 caracteres.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        ///     Código do estado no formato ISO 3166-2.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        ///     Código do país no formato ISO 3166-1 alpha-2.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; } = "BR";

        /// <summary>
        ///     Objeto chave/valor utilizado para armazenar informações adicionais sobre o endereço.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}


