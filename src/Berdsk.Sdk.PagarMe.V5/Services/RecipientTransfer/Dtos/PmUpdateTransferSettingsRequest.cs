using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientTransfer.Dtos
{
    /// <summary>
    ///     Requisição para atualizar as informações de transferência do recebedor.
    ///     <see href="https://docs.pagar.me/reference/atualizar-informaç%C3%B5es-de-transferência-1">
    ///         Documentação Oficial
    ///         PagarMe
    ///     </see>
    /// </summary>
    public class PmUpdateTransferSettingsRequest
    {
        /// <summary>
        ///     Indica se a transferência automática está habilitada.
        /// </summary>
        [JsonPropertyName("transfer_enabled")]
        public bool? TransferEnabled { get; set; }

        /// <summary>
        ///     Intervalo de transferência: "daily", "weekly" ou "monthly".
        /// </summary>
        [JsonPropertyName("transfer_interval")]
        public string TransferInterval { get; set; }

        /// <summary>
        ///     Dia para realização da transferência.
        /// </summary>
        [JsonPropertyName("transfer_day")]
        public int? TransferDay { get; set; }
    }
}