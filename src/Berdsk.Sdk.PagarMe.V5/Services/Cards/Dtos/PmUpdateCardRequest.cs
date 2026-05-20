using System.Text.Json.Serialization;
using System.Collections.Generic;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos
{
    /// <summary>
    ///     Requisição para edição de cartão.
    ///     <para>Referência: https://docs.pagar.me/reference/editar-cartão.md</para>
    /// </summary>
    public class PmUpdateCardRequest
    {
        /// <summary>
        ///     Nome do portador como está impresso no cartão. Máximo de 64 caracteres.
        /// </summary>
        [JsonPropertyName("holder_name")]
        public string? HolderName { get; set; }

        /// <summary>
        ///     Mês de validade do cartão.
        /// </summary>
        [JsonPropertyName("exp_month")]
        public int? ExpMonth { get; set; }

        /// <summary>
        ///     Ano de validade do cartão.
        /// </summary>
        [JsonPropertyName("exp_year")]
        public int? ExpYear { get; set; }

        /// <summary>
        ///     Código do endereço de cobrança.
        /// </summary>
        [JsonPropertyName("billing_address_id")]
        public string? BillingAddressId { get; set; }

        /// <summary>
        ///     Objeto com endereço de cobrança.
        /// </summary>
        [JsonPropertyName("billing_address")]
        public PmCreateCustomerAddressRequest? BillingAddress { get; set; }

        /// <summary>
        ///     Objeto chave/valor utilizado para armazenar informações adicionais sobre o cartão.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        ///     Nome que descreve o cartão.
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; }
    }
}


