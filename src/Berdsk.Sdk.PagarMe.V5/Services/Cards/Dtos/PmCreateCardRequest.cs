using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos
{
    /// <summary>
    ///     Requisição para criação de cartão.
    ///     <para>Referência: https://docs.pagar.me/reference/criar-cartão.md</para>
    /// </summary>
    public class PmCreateCardRequest
    {
        /// <summary>
        ///     Número do cartão. Entre 13 e 19 caracteres.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        ///     Nome do portador como está impresso no cartão. Máximo de 64 caracteres (Caracteres especiais e números não são
        ///     aceitos).
        /// </summary>
        [JsonPropertyName("holder_name")]
        public string HolderName { get; set; }

        /// <summary>
        ///     CPF ou CNPJ do portador do cartão. Obrigatório caso o tipo do cartão seja voucher (bandeiras VR ou Pluxee).
        /// </summary>
        [JsonPropertyName("holder_document")]
        public string? HolderDocument { get; set; }

        /// <summary>
        ///     Mês de validade do cartão. Valor entre 1 e 12 (inclusive).
        /// </summary>
        [JsonPropertyName("exp_month")]
        public int ExpMonth { get; set; }

        /// <summary>
        ///     Ano de validade do cartão. Formatos yy ou yyyy. Ex: 23 ou 2023.
        /// </summary>
        [JsonPropertyName("exp_year")]
        public int ExpYear { get; set; }

        /// <summary>
        ///     Código de segurança do cartão. O campo aceita 4 ou 3 caracteres, variando por bandeira.
        /// </summary>
        [JsonPropertyName("cvv")]
        public string Cvv { get; set; }

        /// <summary>
        ///     Bandeira do cartão. Para cartões de crédito, temos como valores possíveis: elo, mastercard, visa, amex, jcb, aura,
        ///     hipercard, diners, unionpay ou discover.
        /// </summary>
        [JsonPropertyName("brand")]
        public string? Brand { get; set; }

        /// <summary>
        ///     Indica a label do cartão.
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        ///     Código do endereço de cobrança. Max: 36 caracteres. Opcional, pode ser utilizado no lugar do billing_address.
        /// </summary>
        [JsonPropertyName("billing_address_id")]
        public string? BillingAddressId { get; set; }

        /// <summary>
        ///     Endereço de cobrança.
        /// </summary>
        [JsonPropertyName("billing_address")]
        public PmCreateCustomerAddressRequest? BillingAddress { get; set; }

        /// <summary>
        ///     Objeto com opções para a criação do cartão. Um exemplo de opção que pode ser adicionada ao cartão é o verify_card :
        ///     true, que informa que haverá uma validação do cartão antes da utilização (Zero Dollar Auth).
        /// </summary>
        [JsonPropertyName("options")]
        public PmCreateCardOptionsRequest? Options { get; set; }

        /// <summary>
        ///     Objeto chave/valor utilizado para armazenar informações adicionais sobre o cartão.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        ///     Pode ser enviado no lugar dos dados do cartão, caso este já tenha sido tokenizado previamente.
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; }
    }
}