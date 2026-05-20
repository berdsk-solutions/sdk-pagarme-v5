using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientBankAccount.Dtos
{
    /// <summary>
    ///     Requisição para atualizar a conta bancária padrão de um recebedor.
    ///     <para>Referência: https://docs.pagar.me/reference/atualizar-conta-bancária-do-recebedor-1.md</para>
    /// </summary>
    public class PmUpdateRecipientBankAccountRequest
    {
        /// <summary>
        ///     Dados da conta bancária.
        /// </summary>
        [JsonPropertyName("bank_account")]
        public PmCreateBankAccountRequest BankAccount { get; set; }
    }
}


