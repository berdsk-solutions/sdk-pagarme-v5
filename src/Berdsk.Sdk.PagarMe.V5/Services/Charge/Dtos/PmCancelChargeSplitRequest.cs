using System.Text.Json.Serialization;
using System.Collections.Generic;
using Berdsk.Sdk.PagarMe.V5.Services.Common.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Charge.Dtos
{
    /// <summary>
    ///     Requisição para cancelar uma cobrança com split.
    /// </summary>
    public class PmCancelChargeSplitRequest
    {
        /// <summary>
        ///     Valor a ser cancelado. Caso não seja informado, será considerado o valor total da cobrança.
        /// </summary>
        [JsonPropertyName("amount")]
        public int? Amount { get; set; }

        /// <summary>
        ///     Lista de regras de split.
        /// </summary>
        [JsonPropertyName("split")]
        public List<PmSplitRequest> Split { get; set; } = new List<PmSplitRequest>();

        /// <summary>
        ///     Dados da conta bancária do comprador. Somente utilizado para estorno de boleto.
        /// </summary>
        [JsonPropertyName("bank_account")]
        public PmSplitBankAccountRequest? BankAccount { get; set; }
    }
}


