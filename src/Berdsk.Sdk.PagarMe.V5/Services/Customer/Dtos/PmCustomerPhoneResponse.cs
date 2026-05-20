using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos
{
    /// <summary>
    ///     Resposta de telefone do cliente
    /// </summary>
    public class PmCustomerPhoneResponse
    {
        /// <summary>
        ///     Código do país
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     DDD
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        ///     Número do telefone
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}