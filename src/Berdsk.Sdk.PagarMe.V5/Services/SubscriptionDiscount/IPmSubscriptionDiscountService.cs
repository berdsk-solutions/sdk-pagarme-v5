using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionDiscount.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionDiscount
{
    /// <summary>
    ///     Interface para o serviço de descontos de assinatura.
    /// </summary>
    public interface IPmSubscriptionDiscountService
    {
        /// <summary>
        ///     Inclui um desconto em uma assinatura.
        ///     <see href="https://docs.pagar.me/reference/incluir-desconto-1.md">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="request">Dados do desconto</param>
        /// <returns>Dados do desconto criado</returns>
        Task<PmSubscriptionDiscountResponse?> CreateSubscriptionDiscountAsync(string subscriptionId,
            PmCreateSubscriptionDiscountRequest request);

        /// <summary>
        ///     Obtém os dados de um desconto específico de uma assinatura.
        ///     <see href="https://docs.pagar.me/reference/obter-desconto-1.md">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="discountId">Identificador do desconto</param>
        /// <returns>Dados do desconto</returns>
        Task<PmSubscriptionDiscountResponse?> GetSubscriptionDiscountAsync(string subscriptionId, string discountId);

        /// <summary>
        ///     Lista os descontos de uma assinatura.
        ///     <see href="https://docs.pagar.me/reference/listar-descontos-2.md">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="page">Número da página</param>
        /// <param name="size">Quantidade de registros por página</param>
        /// <returns>Lista de descontos</returns>
        Task<PmListSubscriptionDiscountsResponse?> ListSubscriptionDiscountsAsync(string subscriptionId,
            int? page = null, int? size = null);

        /// <summary>
        ///     Remove um desconto de uma assinatura.
        ///     <see href="https://docs.pagar.me/reference/remover-desconto-1.md">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="discountId">Identificador do desconto</param>
        /// <returns>Dados do desconto removido</returns>
        Task<PmSubscriptionDiscountResponse?> DeleteSubscriptionDiscountAsync(string subscriptionId, string discountId);
    }
}