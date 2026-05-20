using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos
{
    /// <summary>
    ///     Detalhes do cartão para tokenização.
    /// </summary>
    public class PmCardTokenDetailsRequest
    {
        /// <summary>
        ///     Número do cartão. Entre 13 e 19 caracteres.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        ///     Nome do portador como está impresso no cartão. Máximo de 64 caracteres.
        /// </summary>
        [JsonPropertyName("holder_name")]
        public string HolderName { get; set; }

        /// <summary>
        ///     CPF ou CNPJ do portador do cartão. Obrigatório para voucher.
        /// </summary>
        [JsonPropertyName("holder_document")]
        public string? HolderDocument { get; set; }

        /// <summary>
        ///     Mês de validade do cartão. 1 a 12.
        /// </summary>
        [JsonPropertyName("exp_month")]
        public int ExpMonth { get; set; }

        /// <summary>
        ///     Ano de validade do cartão. yy ou yyyy.
        /// </summary>
        [JsonPropertyName("exp_year")]
        public int ExpYear { get; set; }

        /// <summary>
        ///     Código de segurança.
        /// </summary>
        [JsonPropertyName("cvv")]
        public string Cvv { get; set; }

        /// <summary>
        ///     Bandeira do cartão.
        /// </summary>
        [JsonPropertyName("brand")]
        public string? Brand { get; set; }

        /// <summary>
        ///     Label do cartão.
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; }
    }
}