using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink
{
    /// <summary>
    ///     Interface do serviço de Links de Pagamento da Pagar.me.
    ///     Observação: a Pagar.me utiliza URLs distintas para Links de Pagamento entre os ambientes
    ///     de produção (<c>https://api.pagar.me/core/v5</c>) e desenvolvimento/sandbox
    ///     (<c>https://sdx-api.pagar.me/core/v5</c>). Como o <see cref="HttpClient.BaseAddress" />
    ///     do <c>PagarMeClient</c> já é configurado com a URL de produção, este serviço aceita uma
    ///     <c>baseUrl</c> alternativa no construtor para sobrescrever o destino em todas as chamadas.
    /// </summary>
    public interface IPmPaymentLinkService
    {
        /// <summary>
        ///     Cria um novo link de pagamento.
        ///     <see href="https://docs.pagar.me/reference/criar-link">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="request">Dados para criação do link</param>
        /// <returns>Dados do link criado</returns>
        Task<PmPaymentLinkResponse?> CreatePaymentLinkAsync(PmCreatePaymentLinkRequest request);

        /// <summary>
        ///     Obtém os dados de um link de pagamento específico.
        ///     <see href="https://docs.pagar.me/reference/obter-link">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="paymentLinkId">Identificador do link (pl_xxxxxxxxxxxxxxxx)</param>
        /// <returns>Dados do link de pagamento</returns>
        Task<PmPaymentLinkResponse?> GetPaymentLinkAsync(string paymentLinkId);

        /// <summary>
        ///     Lista os links de pagamento com filtros opcionais.
        ///     <see href="https://docs.pagar.me/reference/obter-links.md">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="status">Filtro por status (active, canceled, building)</param>
        /// <param name="page">Número da página</param>
        /// <param name="size">Quantidade de registros por página</param>
        /// <returns>Lista de links de pagamento</returns>
        Task<PmListPaymentLinksResponse?> ListPaymentLinksAsync(string? status = null, int? page = null,
            int? size = null);

        /// <summary>
        ///     Ativa um link de pagamento que foi criado com status 'building'.
        ///     <see href="https://docs.pagar.me/reference/ativar-link-de-pagamento-em-construção.md">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="paymentLinkId">Identificador do link</param>
        /// <returns>Dados do link atualizado</returns>
        Task<PmPaymentLinkResponse?> ActivatePaymentLinkAsync(string paymentLinkId);

        /// <summary>
        ///     Cancela um link de pagamento.
        ///     <see href="https://docs.pagar.me/reference/cancelar-um-link-de-pagamento.md">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="paymentLinkId">Identificador do link</param>
        /// <returns>Dados do link cancelado</returns>
        Task<PmPaymentLinkResponse?> CancelPaymentLinkAsync(string paymentLinkId);
    }
}