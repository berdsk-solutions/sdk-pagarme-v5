using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Dados sobre o pagamento com boleto
    /// </summary>
    public class PmOrderBoletoRequest
    {
        [JsonPropertyName("bank")] public string? Bank { get; set; }

        [JsonPropertyName("instructions")] public string? Instructions { get; set; }

        [JsonPropertyName("due_at")] public string? DueAt { get; set; }

        [JsonPropertyName("nosso_numero")] public string? NossoNumero { get; set; }

        [JsonPropertyName("type")] public string? Type { get; set; }

        [JsonPropertyName("document_number")] public string? DocumentNumber { get; set; }

        [JsonPropertyName("statement_descriptor")] public string? StatementDescriptor { get; set; }

        [JsonPropertyName("interest")] public PmBoletoInterestRequest? Interest { get; set; }

        [JsonPropertyName("fine")] public PmBoletoFineRequest? Fine { get; set; }

        [JsonPropertyName("discount")] public PmBoletoDiscountRequest? Discount { get; set; }

        [JsonPropertyName("metadata")] public Dictionary<string, string>? Metadata { get; set; }
    }
}


