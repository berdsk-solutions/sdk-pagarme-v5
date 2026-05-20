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
        /// <summary>
        ///     Inicializa uma nova instância do cliente PagarMe v5.
        ///     <para>
        ///         <see href="https://docs.pagar.me/reference/autenticação-2">Documentação Oficial PagarMe</see>
        ///     </para>
        /// </summary>
        /// <remarks>
        ///     <b>Atenção:</b> Para evitar <b>Sockets Exhaustion</b> (esgotamento de portas), evite criar
        ///     múltiplas instâncias de <see cref="PagarMeClient" /> ou <see cref="HttpClient" /> manualmente.
        ///     É altamente recomendado que o <see cref="HttpClient" /> seja injetado via Dependency Injection
        ///     ou reutilizado como uma instância estática (Singleton).
        /// </remarks>
        /// <param name="apiKey">Sua Secret Key da PagarMe.</param>
        /// <param name="baseUrl">URL base da API (ex: <c>https://api.pagar.me/core/v5/</c>).</param>
        /// <param name="httpClient">Instância opcional de <see cref="HttpClient" /> a ser reutilizada.</param>
        /// <param name="paymentLinkBaseUrl">
        ///     URL base alternativa exclusiva para os endpoints de Payment Link (ex:
        ///     <c>https://sdx-api.pagar.me/core/v5</c> em sandbox). Necessário porque a Pagar.me utiliza
        ///     hosts distintos entre produção e desenvolvimento para esses endpoints, e o
        ///     <see cref="HttpClient.BaseAddress" /> já está configurado com a URL principal da API.
        ///     Se for <c>null</c>, o <see cref="PmPaymentLinkService" /> usa o <c>BaseAddress</c> padrão.
        /// </param>
        public PagarMeClient(string apiKey, string baseUrl, HttpClient? httpClient = null,
            string? paymentLinkBaseUrl = null)
        {
            var pmPaymentLinkBaseUrl = paymentLinkBaseUrl;
            var pmHttpClient = httpClient ?? new HttpClient();

            if (pmHttpClient.BaseAddress == null)
                pmHttpClient.BaseAddress = new Uri(baseUrl);

            var authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{apiKey}:"));
            pmHttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

            Customer = new PmCustomerService(pmHttpClient);
            CardBin = new PmBinService(pmHttpClient);
            Order = new PmOrderService(pmHttpClient);
            Charge = new PmChargeService(pmHttpClient);
            PaymentLink = new PmPaymentLinkService(pmHttpClient, pmPaymentLinkBaseUrl);
            Plan = new PmPlanService(pmHttpClient);
            Subscription = new PmSubscriptionService(pmHttpClient);
            Recipient = new PmRecipientService(pmHttpClient);
            SellerInterface = new PmSellerInterfaceService(pmHttpClient);
            Webhook = new PmWebhookService(pmHttpClient);
            Dispute = new PmDisputeService(pmHttpClient);
            Settlement = new PmSettlementService(pmHttpClient);
            Transfer = new PmTransferService(pmHttpClient);
        }

        /// <summary>Serviço de clientes (customers): criação, consulta, atualização, cartões, endereços e telefones.</summary>
        public IPmCustomerService Customer { get; }

        /// <summary>Serviço de consulta de BIN (Bank Identification Number) de cartões.</summary>
        public IPmBinService CardBin { get; }

        /// <summary>Serviço de pedidos (orders): criação, consulta, captura e cancelamento.</summary>
        public IPmOrderService Order { get; }

        /// <summary>Serviço de cobranças (charges): captura, cancelamento, estorno e consulta.</summary>
        public IPmChargeService Charge { get; }

        /// <summary>Serviço de Payment Links (links de pagamento) — pode usar host distinto via <c>paymentLinkBaseUrl</c>.</summary>
        public IPmPaymentLinkService PaymentLink { get; }

        /// <summary>Serviço de planos (plans) usados em assinaturas recorrentes.</summary>
        public IPmPlanService Plan { get; }

        /// <summary>Serviço de assinaturas (subscriptions): criação, atualização, itens, descontos e incrementos.</summary>
        public IPmSubscriptionService Subscription { get; }

        /// <summary>Serviço de recebedores (recipients): cadastro, contas bancárias e configurações de saque.</summary>
        public IPmRecipientService Recipient { get; }

        /// <summary>Serviço da Seller Interface (gestão de sellers no split de pagamento).</summary>
        public IPmSellerInterfaceService SellerInterface { get; }

        /// <summary>Serviço de webhooks: cadastro, listagem e reenvio de eventos.</summary>
        public IPmWebhookService Webhook { get; }

        /// <summary>Serviço de disputas (chargebacks/disputes) entre comprador e estabelecimento.</summary>
        public IPmDisputeService Dispute { get; }

        /// <summary>Serviço de liquidações (settlements) — extratos e movimentações de saldo.</summary>
        public IPmSettlementService Settlement { get; }

        /// <summary>Serviço de transferências (transfers) de saldo para contas bancárias dos recebedores.</summary>
        public IPmTransferService Transfer { get; }
    }
}