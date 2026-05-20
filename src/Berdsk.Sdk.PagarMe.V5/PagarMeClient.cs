using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Berdsk.Sdk.PagarMe.V5.Services.CardBin;
using Berdsk.Sdk.PagarMe.V5.Services.Charge;
using Berdsk.Sdk.PagarMe.V5.Services.Customer;
using Berdsk.Sdk.PagarMe.V5.Services.Disputes;
using Berdsk.Sdk.PagarMe.V5.Services.Order;
using Berdsk.Sdk.PagarMe.V5.Services.PaymentLink;
using Berdsk.Sdk.PagarMe.V5.Services.Plan;
using Berdsk.Sdk.PagarMe.V5.Services.Recipients;
using Berdsk.Sdk.PagarMe.V5.Services.SellerInterface;
using Berdsk.Sdk.PagarMe.V5.Services.Settlements;
using Berdsk.Sdk.PagarMe.V5.Services.Subscription;
using Berdsk.Sdk.PagarMe.V5.Services.Transfers;
using Berdsk.Sdk.PagarMe.V5.Services.Webhooks;

namespace Berdsk.Sdk.PagarMe.V5
{
    public class PagarMeClient
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;
        private readonly string? _paymentLinkBaseUrl;

        /// <summary>
        ///     Inicializa uma nova instância do cliente PagarMe v5.
        ///     <para>Referência de Autenticação: https://docs.pagar.me/reference/autenticação-2.md</para>
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <b>Atenção:</b> Para evitar <b>Sockets Exhaustion</b> (esgotamento de portas), evite criar
        ///         múltiplas instâncias de <see cref="PagarMeClient" /> ou <see cref="HttpClient" /> manualmente.
        ///         É altamente recomendado que o <see cref="HttpClient" /> seja injetado via Dependency Injection
        ///         ou reutilizado como uma instância estática (Singleton).
        ///     </para>
        /// </remarks>
        /// <param name="apiKey">Sua Secret Key da PagarMe</param>
        /// <param name="baseUrl">URL base da API (ex: https://api.pagar.me/core/v5/)</param>
        /// <param name="httpClient">Instância opcional de HttpClient</param>
        /// <param name="paymentLinkBaseUrl">
        ///     URL base alternativa exclusiva para os endpoints de Payment Link (ex:
        ///     <c>https://sdx-api.pagar.me/core/v5</c> em sandbox). Necessário porque a Pagar.me utiliza
        ///     hosts distintos entre produção e desenvolvimento para esses endpoints, e o
        ///     <see cref="HttpClient.BaseAddress"/> já está configurado com a URL principal da API.
        ///     Se for <c>null</c>, o <see cref="PmPaymentLinkService"/> usa o <c>BaseAddress</c> padrão.
        /// </param>
        public PagarMeClient(string apiKey, string baseUrl, HttpClient? httpClient = null,
            string? paymentLinkBaseUrl = null)
        {
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            _paymentLinkBaseUrl = paymentLinkBaseUrl;

            _httpClient = httpClient ?? new HttpClient();

            if (_httpClient.BaseAddress == null)
                _httpClient.BaseAddress = new Uri(baseUrl);

            var authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_apiKey}:"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

            Customer = new PmCustomerService(_httpClient);
            CardBin = new PmBinService(_httpClient);
            Order = new PmOrderService(_httpClient);
            Charge = new PmChargeService(_httpClient);
            PaymentLink = new PmPaymentLinkService(_httpClient, _paymentLinkBaseUrl);
            Plan = new PmPlanService(_httpClient);
            Subscription = new PmSubscriptionService(_httpClient);
            Recipient = new PmRecipientService(_httpClient);
            SellerInterface = new PmSellerInterfaceService(_httpClient);
            Webhook = new PmWebhookService(_httpClient);
            Dispute = new PmDisputeService(_httpClient);
            Settlement = new PmSettlementService(_httpClient);
            Transfer = new PmTransferService(_httpClient);
        }

        // Sub-services expostos como propriedades
        public IPmCustomerService Customer { get; }
        public IPmBinService CardBin { get; }
        public IPmOrderService Order { get; }
        public IPmChargeService Charge { get; }
        public IPmPaymentLinkService PaymentLink { get; }
        public IPmPlanService Plan { get; }
        public IPmSubscriptionService Subscription { get; }
        public IPmRecipientService Recipient { get; }
        public IPmSellerInterfaceService SellerInterface { get; }
        public IPmWebhookService Webhook { get; }
        public IPmDisputeService Dispute { get; }
        public IPmSettlementService Settlement { get; }
        public IPmTransferService Transfer { get; }
    }
}
