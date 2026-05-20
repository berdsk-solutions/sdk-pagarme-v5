using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos
{
    /// <summary>
    ///     Resposta de cartão.
    ///     <para>Referência: https://docs.pagar.me/reference/obter-cartão.md</para>
    /// </summary>
    public class PmCardResponse
    {
        /// <summary>
        ///     Identificador do cartão.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Seis primeiros dígitos do cartão.
        /// </summary>
        [JsonPropertyName("first_six_digits")]
        public string FirstSixDigits { get; set; }

        /// <summary>
        ///     Quatro últimos dígitos do cartão.
        /// </summary>
        [JsonPropertyName("last_four_digits")]
        public string LastFourDigits { get; set; }

        /// <summary>
        ///     Bandeira do cartão.
        /// </summary>
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        ///     Nome do portador como está impresso no cartão.
        /// </summary>
        [JsonPropertyName("holder_name")]
        public string HolderName { get; set; }

        /// <summary>
        ///     CPF ou CNPJ do portador do cartão.
        /// </summary>
        [JsonPropertyName("holder_document")]
        public string? HolderDocument { get; set; }

        /// <summary>
        ///     Mês de validade do cartão.
        /// </summary>
        [JsonPropertyName("exp_month")]
        public int ExpMonth { get; set; }

        /// <summary>
        ///     Ano de validade do cartão.
        /// </summary>
        [JsonPropertyName("exp_year")]
        public int ExpYear { get; set; }

        /// <summary>
        ///     Status do cartão (Ex: active).
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Label do cartão.
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        ///     Data de criação.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     Data de atualização.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        ///     Endereço de cobrança.
        /// </summary>
        [JsonPropertyName("billing_address")]
        public PmCustomerAddressResponse? BillingAddress { get; set; }

        /// <summary>
        ///     Dados do cliente associado.
        /// </summary>
        [JsonPropertyName("customer")]
        public PmCustomerResponse? Customer { get; set; }

        /// <summary>
        ///     Tipo do cartão (Ex: credit).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Metadados associados ao cartão.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}


