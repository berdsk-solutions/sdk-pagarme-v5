using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.Settlements.Dtos
{
    /// <summary>
    ///     Resposta de um pagamento (Settlement).
    ///     <para>Referência: https://docs.pagar.me/reference/objeto-settlements</para>
    /// </summary>
    public class PmSettlementResponse
    {
        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("amount")] public long Amount { get; set; }

        [JsonPropertyName("product")] public string Product { get; set; }

        [JsonPropertyName("card_brand")] public string CardBrand { get; set; }

        [JsonPropertyName("payment_date")] public DateTime PaymentDate { get; set; }

        [JsonPropertyName("recipient_id")] public string RecipientId { get; set; }

        [JsonPropertyName("document_type")] public string DocumentType { get; set; }

        [JsonPropertyName("contract_obligation_id")] public string ContractObligationId { get; set; }

        [JsonPropertyName("liquidation_arrangement_id")] public string LiquidationArrangementId { get; set; }

        [JsonPropertyName("liquidation_type")] public string LiquidationType { get; set; }

        [JsonPropertyName("contract_key")] public string ContractKey { get; set; }

        [JsonPropertyName("liquidation_engine")] public string LiquidationEngine { get; set; }

        [JsonPropertyName("external_engine_payment_id")] public string ExternalEnginePaymentId { get; set; }

        [JsonPropertyName("funding_account_id")] public string FundingAccountId { get; set; }

        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("ispb")] public string Ispb { get; set; }

        [JsonPropertyName("target_account")] public PmSettlementTargetAccountResponse TargetAccount { get; set; }
    }
}


