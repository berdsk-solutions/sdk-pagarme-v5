using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos
{
    /// <summary>
    ///     Requisição para criação de endereço do cliente
    /// </summary>
    public class PmCreateCustomerAddressRequest
    {
        /// <summary>
        ///     País (Código do país no formato ISO 3166-1 alpha-2)(2 digitos)
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; } = "BR";

        /// <summary>
        ///     Estado (Código do estado no formato ISO 3166-2).
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        ///     Cidade.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        ///     Código Postal (CEP) (Apenas numérico).
        /// </summary>
        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }

        /// <summary>
        ///     Dados principais do endereço. Neste campo deve ser informado Número, Rua, Bairro, nesta ordem e separados por
        ///     vírgula.
        /// </summary>
        [JsonPropertyName("line_1")]
        public string? Line1 { get; set; }

        /// <summary>
        ///     Dados complementares do endereço. Neste campo pode ser informado complemento, referências.
        /// </summary>
        [JsonPropertyName("line_2")]
        public string? Line2 { get; set; }
    }
}


