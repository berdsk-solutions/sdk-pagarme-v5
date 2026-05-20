using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos
{
    /// <summary>
    ///     Requisição para criação de cliente
    /// </summary>
    public class PmCreateCustomerRequest
    {
        /// <summary>
        ///     Nome do cliente. Max: 64 caracteres.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     E-mail do cliente. Max: 64 caracteres
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        ///     Código de referência do cliente no sistema da loja. Max: 52 caracteres
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        ///     CPF, CNPJ ou PASSPORT do cliente. Max: 16 caracteres para CPF e CNPJ e Max: 50 caracteres para PASSPORT
        /// </summary>
        [JsonPropertyName("document")]
        public string Document { get; set; }

        /// <summary>
        ///     Tipo de documento. Valores possíveis: CPF, CNPJ ou PASSPORT.
        /// </summary>
        [JsonPropertyName("document_type")]
        public string? DocumentType { get; set; }

        /// <summary>
        ///     Tipo de cliente. Valores possíveis: **individual** (pessoa física) ou **company** (pessoa jurídica). Obrigatório,
        ///     caso o document seja enviado.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = "individual";

        /// <summary>
        ///     Sexo do cliente . Valores possíveis: male ou female
        /// </summary>
        [JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        ///     Endereço do cliente.
        /// </summary>
        [JsonPropertyName("address")]
        public PmCreateCustomerAddressRequest? Address { get; set; }

        /// <summary>
        ///     Telefones do cliente. Saiba mais sobre o telefones: https://docs.pagar.me/reference#telefones-1
        /// </summary>
        [JsonPropertyName("phones")]
        public PmCreateCustomerPhonesRequest? Phones { get; set; }

        /// <summary>
        ///     Data de nascimento do cliente. Formato mm/dd/aaa
        /// </summary>
        [JsonPropertyName("birthdate")]
        public string? Birthdate { get; set; }

        /// <summary>
        ///     Objeto chave/valor utilizado para armazenar informações adicionais sobre o cliente. Saiba mais sobre metadata:
        ///     <see href="https://docs.pagar.me/reference/metadata-1">Documentação Oficial PagarMe</see>
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}