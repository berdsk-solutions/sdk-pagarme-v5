using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos
{
    /// <summary>
    ///     Telefones do cliente (Resposta)
    /// </summary>
    public class PmCustomerPhonesResponse
    {
        /// <summary>
        ///     Telefone fixo
        /// </summary>
        [JsonPropertyName("home_phone")]
        public PmCustomerPhoneResponse? HomePhone { get; set; }

        /// <summary>
        ///     Telefone celular
        /// </summary>
        [JsonPropertyName("mobile_phone")]
        public PmCustomerPhoneResponse? MobilePhone { get; set; }
    }
}


