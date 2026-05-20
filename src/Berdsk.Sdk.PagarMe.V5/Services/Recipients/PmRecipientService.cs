using System.Threading.Tasks;
using System.Net.Http;
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
    ///     Serviço para gerenciamento de recebedores na Pagar.me v5.
    /// </summary>
    public class PmRecipientService : PmBaseService, IPmRecipientService
    {
        public PmRecipientService(HttpClient httpClient) : base(httpClient)
        {
            Transfers = new PmRecipientTransferService(httpClient);
            BankAccounts = new PmRecipientBankAccountService(httpClient);
            Balances = new PmRecipientBalanceService(httpClient);
            Anticipations = new PmRecipientAnticipationService(httpClient);
            Payables = new PmPayablesService(httpClient);
            BalanceOperations = new PmBalanceOperationsService(httpClient);
            Settlements = new PmSettlementService(httpClient);
        }

        /// <inheritdoc />
        public IPmRecipientTransferService Transfers { get; }

        /// <inheritdoc />
        public IPmRecipientBankAccountService BankAccounts { get; }

        /// <inheritdoc />
        public IPmRecipientBalanceService Balances { get; }

        /// <inheritdoc />
        public IPmRecipientAnticipationService Anticipations { get; }

        /// <inheritdoc />
        public IPmPayablesService Payables { get; }

        /// <inheritdoc />
        public IPmBalanceOperationsService BalanceOperations { get; }

        /// <inheritdoc />
        public IPmSettlementService Settlements { get; }

        /// <inheritdoc />
        public async Task<PmRecipientResponse?> CreateRecipientAsync(PmCreateRecipientRequest request)
        {
            return await PostAsync<PmRecipientResponse, PmCreateRecipientRequest>(PmEndpoints.Recipients.Base, request);
        }

        /// <inheritdoc />
        public async Task<PmRecipientResponse?> CreateRecipientLinkAsync(PmCreateRecipientRequest request)
        {
            return await PostAsync<PmRecipientResponse, PmCreateRecipientRequest>(PmEndpoints.Recipients.Base, request);
        }

        /// <inheritdoc />
        public async Task<PmRecipientResponse?> GetRecipientAsync(string recipientId)
        {
            var url = string.Format(PmEndpoints.Recipients.Get, recipientId);
            return await GetAsync<PmRecipientResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmListRecipientsResponse?> ListRecipientsAsync(int page = 1, int size = 10)
        {
            var url = $"{PmEndpoints.Recipients.Base}?page={page}&size={size}";
            return await GetAsync<PmListRecipientsResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmRecipientResponse?> UpdateRecipientAsync(string recipientId, PmUpdateRecipientRequest request)
        {
            var url = string.Format(PmEndpoints.Recipients.Update, recipientId);
            return await PutAsync<PmRecipientResponse, PmUpdateRecipientRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmRecipientResponse?> UpdateRecipientCodeAsync(string recipientId,
            PmUpdateRecipientCodeRequest request)
        {
            var url = string.Format(PmEndpoints.Recipients.UpdateCode, recipientId);
            return await PatchAsync<PmRecipientResponse, PmUpdateRecipientCodeRequest>(url, request);
        }
    }
}



