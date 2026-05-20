using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos
{
    /// <summary>
    ///     Opções para a criação do cartão.
    /// </summary>
    public class PmCreateCardOptionsRequest
    {
        /// <summary>
        ///     Informa que haverá uma validação do cartão antes da utilização (Zero Dollar Auth).
        /// </summary>
        [JsonPropertyName("verify_card")]
        public bool? VerifyCard { get; set; }
    }
}


