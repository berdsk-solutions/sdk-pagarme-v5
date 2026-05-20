using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos
{
    /// <summary>
    ///     Resposta de endereço do cliente
    /// </summary>
    public class PmCustomerAddressResponse
    {
        /// <summary>
        ///     Identificador do endereço
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Dados principais do endereço
        /// </summary>
        [JsonPropertyName("line_1")]
        public string Line1 { get; set; }

        /// <summary>
        ///     Dados complementares do endereço
        /// </summary>
        [JsonPropertyName("line_2")]
        public string? Line2 { get; set; }

        /// <summary>
        ///     Código Postal (CEP)
        /// </summary>
        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }

        /// <summary>
        ///     Cidade
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        ///     Estado
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        ///     País
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        ///     Status do endereço
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Data de criação
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     Data de atualização
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}


