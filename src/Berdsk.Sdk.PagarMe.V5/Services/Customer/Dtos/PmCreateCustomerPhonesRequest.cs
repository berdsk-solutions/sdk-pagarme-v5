using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos
{
    /// <summary>
    ///     Telefones do cliente. Saiba mais sobre o telefones: https://docs.pagar.me/reference#telefones-1
    /// </summary>
    public class PmCreateCustomerPhonesRequest
    {
        /// <summary>
        ///     Telefone residencial do cliente.
        /// </summary>
        [JsonPropertyName("home_phone")]
        public PmCreateCustomerPhoneRequest? HomePhone { get; set; }

        /// <summary>
        ///     Telefone celular do cliente.
        /// </summary>
        [JsonPropertyName("mobile_phone")]
        public PmCreateCustomerPhoneRequest? MobilePhone { get; set; }
    }
}


