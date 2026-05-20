using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientBalance.Dtos
{
    /// <summary>
    ///     Resposta do saldo do recebedor.
    ///     <para>Referência: https://docs.pagar.me/reference/obter-saldo.md</para>
    /// </summary>
    public class PmRecipientBalanceResponse
    {
        [JsonPropertyName("currency")] public string Currency { get; set; }

        [JsonPropertyName("available_amount")] public long AvailableAmount { get; set; }

        [JsonPropertyName("waiting_funds_amount")]
        public long WaitingFundsAmount { get; set; }

        [JsonPropertyName("transferred_amount")]
        public long TransferredAmount { get; set; }

        [JsonPropertyName("recipient")] public PmRecipientBalanceRecipientResponse Recipient { get; set; }
    }
}