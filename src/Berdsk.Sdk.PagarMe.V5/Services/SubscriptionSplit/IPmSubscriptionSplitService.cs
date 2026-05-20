using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionSplit.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SubscriptionSplit
{
    /// <summary>
    ///     Interface para o serviço de split de assinaturas.
    /// </summary>
    public interface IPmSubscriptionSplitService
    {
        /// <summary>
        ///     Obtém as regras de split de uma assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/editar-ativação-ou-regras-do-split.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <returns>Regras de split da assinatura</returns>
        Task<PmSubscriptionSplitResponse?> GetSubscriptionSplitAsync(string subscriptionId);

        /// <summary>
        ///     Edita as regras de split de uma assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/editar-ativação-ou-regras-do-split.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="request">Novas regras de split</param>
        /// <returns>Regras de split atualizadas</returns>
        Task<PmSubscriptionSplitResponse?> UpdateSubscriptionSplitAsync(string subscriptionId,
            PmUpdateSubscriptionSplitRequest request);
    }
}