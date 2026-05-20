using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink
{
    /// <summary>
    ///     Serviço de Links de Pagamento da Pagar.me.
    ///     <para>
    ///         Observação: a Pagar.me utiliza URLs distintas para Links de Pagamento entre os ambientes
    ///         de produção (<c>https://api.pagar.me/core/v5</c>) e desenvolvimento/sandbox
    ///         (<c>https://sdx-api.pagar.me/core/v5</c>). Como o <see cref="HttpClient.BaseAddress" />
    ///         do <c>PagarMeClient</c> já é configurado com a URL de produção, este serviço aceita uma
    ///         <c>baseUrl</c> alternativa no construtor para sobrescrever o destino em todas as chamadas.
    ///     </para>
    /// </summary>
    /// <inheritdoc />
    public class PmPaymentLinkService : PmBaseService, IPmPaymentLinkService
    {
        private readonly string? _baseUrlOverride;

        /// <summary>
        ///     Inicializa o serviço de Payment Links.
        /// </summary>
        /// <param name="httpClient">HttpClient já configurado pelo <c>PagarMeClient</c>.</param>
        /// <param name="baseUrlOverride">
        ///     URL base alternativa para os endpoints de Payment Link (ex: <c>https://sdx-api.pagar.me/core/v5</c>
        ///     para sandbox). Quando informada, sobrescreve o <c>BaseAddress</c> do HttpClient apenas para este serviço.
        ///     Se for <c>null</c>, utiliza o <c>BaseAddress</c> padrão (produção).
        /// </param>
        public PmPaymentLinkService(HttpClient httpClient, string? baseUrlOverride = null) : base(httpClient)
        {
            _baseUrlOverride = baseUrlOverride;
        }

        /// <inheritdoc />
        public async Task<PmPaymentLinkResponse?> CreatePaymentLinkAsync(PmCreatePaymentLinkRequest request)
        {
            return await PostAsync<PmPaymentLinkResponse, PmCreatePaymentLinkRequest>(
                BuildUrl(PmEndpoints.PaymentLinks.Base), request);
        }

        /// <inheritdoc />
        public async Task<PmPaymentLinkResponse?> GetPaymentLinkAsync(string paymentLinkId)
        {
            return await GetAsync<PmPaymentLinkResponse>(
                BuildUrl(string.Format(PmEndpoints.PaymentLinks.Get, paymentLinkId)));
        }

        /// <inheritdoc />
        public async Task<PmListPaymentLinksResponse?> ListPaymentLinksAsync(string? status = null, int? page = null,
            int? size = null)
        {
            var queryParameters = new List<string>();
            if (!string.IsNullOrEmpty(status)) queryParameters.Add($"status={Uri.EscapeDataString(status)}");
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            var url = BuildUrl(PmEndpoints.PaymentLinks.Base);
            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListPaymentLinksResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmPaymentLinkResponse?> ActivatePaymentLinkAsync(string paymentLinkId)
        {
            var url = BuildUrl(string.Format(PmEndpoints.PaymentLinks.Get, paymentLinkId));
            return await PatchAsync<PmPaymentLinkResponse, object>(url, new { status = "active" });
        }

        /// <inheritdoc />
        public async Task<PmPaymentLinkResponse?> CancelPaymentLinkAsync(string paymentLinkId)
        {
            var url = BuildUrl(string.Format(PmEndpoints.PaymentLinks.Cancel, paymentLinkId));
            return await DeleteAsync<PmPaymentLinkResponse>(url);
        }

        /// <summary>
        ///     Monta a URL final, utilizando a baseUrl alternativa (caso configurada no construtor).
        /// </summary>
        private string BuildUrl(string relativeUrl)
        {
            return string.IsNullOrWhiteSpace(_baseUrlOverride)
                ? relativeUrl
                : $"{_baseUrlOverride.TrimEnd('/')}/{relativeUrl.TrimStart('/')}";
        }
    }
}