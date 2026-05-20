using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos
{
    /// <summary>
    ///     Resposta de cliente
    /// </summary>
    public class PmCustomerResponse
    {
        /// <summary>
        ///     Identificador do cliente
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Nome do cliente
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Email do cliente
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        ///     Código de referência do cliente no seu sistema
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        ///     Documento do cliente (CPF ou CNPJ)
        /// </summary>
        [JsonPropertyName("document")]
        public string Document { get; set; }

        /// <summary>
        ///     Tipo de cliente (individual ou company)
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Tipo de documento (CPF ou CNPJ)
        /// </summary>
        [JsonPropertyName("document_type")]
        public string? DocumentType { get; set; }

        /// <summary>
        ///     Gênero (male ou female)
        /// </summary>
        [JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        ///     Indica se o cliente está inadimplente
        /// </summary>
        [JsonPropertyName("delinquent")]
        public bool Delinquent { get; set; }

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
        ///     Data de nascimento
        /// </summary>
        [JsonPropertyName("birthdate")]
        public string? Birthdate { get; set; }

        /// <summary>
        ///     Telefones do cliente
        /// </summary>
        [JsonPropertyName("phones")]
        public PmCustomerPhonesResponse? Phones { get; set; }

        /// <summary>
        ///     Endereço do cliente
        /// </summary>
        [JsonPropertyName("address")]
        public PmCustomerAddressResponse? Address { get; set; }

        /// <summary>
        ///     Status do cliente
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///     Metadados
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}


