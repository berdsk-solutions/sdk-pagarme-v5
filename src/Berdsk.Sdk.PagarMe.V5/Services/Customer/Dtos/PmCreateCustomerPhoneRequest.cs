using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos
{
    /// <summary>
    ///     Requisição para criação de telefone do cliente
    /// </summary>
    public class PmCreateCustomerPhoneRequest
    {
        /// <summary>
        ///     Código do País (Apenas numérico).
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     Código da área (Apenas numérico).
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        ///     Número do telefone (Apenas numérico).
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}