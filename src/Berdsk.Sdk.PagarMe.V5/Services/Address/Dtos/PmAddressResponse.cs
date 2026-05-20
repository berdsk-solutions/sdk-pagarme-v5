using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Address.Dtos
{
    /// <summary>
    ///     Resposta de endereço
    /// </summary>
    public class PmAddressResponse
    {
        /// <summary>
        ///     Identificador do endereço
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Linha 1 do endereço
        /// </summary>
        [JsonPropertyName("line_1")]
        public string Line1 { get; set; }

        /// <summary>
        ///     Linha 2 do endereço
        /// </summary>
        [JsonPropertyName("line_2")]
        public string? Line2 { get; set; }

        /// <summary>
        ///     CEP
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

        /// <summary>
        ///     Cliente associado ao endereço
        /// </summary>
        [JsonPropertyName("customer")]
        public PmCustomerResponse? Customer { get; set; }

        /// <summary>
        ///     Metadados
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}