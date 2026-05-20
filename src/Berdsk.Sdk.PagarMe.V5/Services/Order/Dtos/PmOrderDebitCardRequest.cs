using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Dados sobre o pagamento com cartão de débito
    /// </summary>
    public class PmOrderDebitCardRequest
    {
        [JsonPropertyName("statement_descriptor")]
        public string? StatementDescriptor { get; set; }

        [JsonPropertyName("card")] public PmOrderCardRequest? Card { get; set; }

        [JsonPropertyName("card_id")] public string? CardId { get; set; }

        [JsonPropertyName("card_token")] public string? CardToken { get; set; }
    }
}


