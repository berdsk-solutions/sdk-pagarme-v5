using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.BalanceOperations;
using Berdsk.Sdk.PagarMe.V5.Services.Payables;
using Berdsk.Sdk.PagarMe.V5.Services.RecipientAnticipationService;
using Berdsk.Sdk.PagarMe.V5.Services.RecipientBalance;
using Berdsk.Sdk.PagarMe.V5.Services.RecipientBankAccount;
using Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.RecipientTransfer;
using Berdsk.Sdk.PagarMe.V5.Services.Settlements;

namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients
{
    /// <summary>
    /// Interface para o serviço de gerenciamento de recebedores na Pagar.me v5.
    /// </summary>
    public interface IPmRecipientService
    {
        /// <summary>
        /// Serviço de transferências do recebedor.
        /// </summary>
        IPmRecipientTransferService Transfers { get; }

        /// <summary>
        /// Serviço de contas bancárias do recebedor.
        /// </summary>
        IPmRecipientBankAccountService BankAccounts { get; }

        /// <summary>
        /// Serviço de consulta de saldo do recebedor.
        /// </summary>
        IPmRecipientBalanceService Balances { get; }

        /// <summary>
        /// Serviço de antecipações do recebedor.
        /// </summary>
        IPmRecipientAnticipationService Anticipations { get; }

        /// <summary>
        /// Serviço de recebíveis do recebedor.
        /// </summary>
        IPmPayablesService Payables { get; }

        /// <summary>
        /// Serviço de operações de saldo do recebedor.
        /// </summary>
        IPmBalanceOperationsService BalanceOperations { get; }

        /// <summary>
        /// Serviço de liquidações do recebedor.
        /// </summary>
        IPmSettlementService Settlements { get; }

        /// <summary>
        ///     Rota para criar um recebedor, definindo os dados do recebedor, transferência e qual a conta bancária que será
        ///     utilizada para envio dos pagamentos.
        ///     <para>Referência: https://docs.pagar.me/reference/criar-recebedor-1.md</para>
        /// </summary>
        Task<PmRecipientResponse?> CreateRecipientAsync(PmCreateRecipientRequest request);

        /// <summary>
        ///     Rota para criar um link de recebedor.
        ///     <para>Referência: https://docs.pagar.me/reference/criar-link-recebedor.md</para>
        /// </summary>
        Task<PmRecipientResponse?> CreateRecipientLinkAsync(PmCreateRecipientRequest request);

        /// <summary>
        ///     Rota para obter os dados de um recebedor através do seu ID.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-recebedor-1.md</para>
        /// </summary>
        Task<PmRecipientResponse?> GetRecipientAsync(string recipientId);

        /// <summary>
        ///     Rota para listar todos os recebedores da sua conta.
        ///     <para>Referência: https://docs.pagar.me/reference/listar-recebedores-1.md</para>
        /// </summary>
        Task<PmListRecipientsResponse?> ListRecipientsAsync(int page = 1, int size = 10);

        /// <summary>
        ///     Rota para editar os dados de um recebedor.
        ///     <para>Referência: https://docs.pagar.me/reference/editar-recebedor-1.md</para>
        /// </summary>
        Task<PmRecipientResponse?> UpdateRecipientAsync(string recipientId, PmUpdateRecipientRequest request);

        /// <summary>
        ///     Rota para atualizar o código de referência externa (code) de um recebedor.
        ///     <para>Referência: https://docs.pagar.me/reference/atualizar-code-de-recebedor.md</para>
        /// </summary>
        Task<PmRecipientResponse?> UpdateRecipientCodeAsync(string recipientId, PmUpdateRecipientCodeRequest request);
    }
}


