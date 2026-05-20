using System.Collections.Generic;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.PlanItem.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.PlanItem
{
    /// <summary>
    /// Interface para o serviço de itens de plano.
    /// </summary>
    public interface IPmPlanItemService
    {
        /// <summary>
        ///     Inclui um item em um plano.
        ///     <para>Referência: https://docs.pagar.me/reference/incluir-item-2.md</para>
        /// </summary>
        /// <param name="planId">Identificador do plano</param>
        /// <param name="request">Dados do item</param>
        /// <returns>Dados do item criado</returns>
        Task<PmPlanItemResponse?> CreatePlanItemAsync(string planId, PmCreatePlanItemRequest request);

        /// <summary>
        ///     Obtém os dados de um item específico de um plano.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-item-1.md</para>
        /// </summary>
        /// <param name="planId">Identificador do plano</param>
        /// <param name="planItemId">Identificador do item do plano</param>
        /// <returns>Dados do item</returns>
        Task<PmPlanItemResponse?> GetPlanItemAsync(string planId, string planItemId);

        /// <summary>
        ///     Lista os itens de um plano.
        ///     <para>Referência: https://docs.pagar.me/reference/listar-itens-1.md</para>
        /// </summary>
        /// <param name="planId">Identificador do plano</param>
        /// <returns>Lista de itens do plano</returns>
        Task<List<PmPlanItemResponse>?> ListPlanItemsAsync(string planId);

        /// <summary>
        ///     Edita um item de um plano.
        ///     <para>Referência: https://docs.pagar.me/reference/editar-item-1.md</para>
        /// </summary>
        /// <param name="planId">Identificador do plano</param>
        /// <param name="planItemId">Identificador do item do plano</param>
        /// <param name="request">Dados para atualização</param>
        /// <returns>Dados do item atualizado</returns>
        Task<PmPlanItemResponse?> UpdatePlanItemAsync(string planId, string planItemId, PmUpdatePlanItemRequest request);

        /// <summary>
        ///     Remove um item de um plano.
        ///     <para>Referência: https://docs.pagar.me/reference/remover-item-1.md</para>
        /// </summary>
        /// <param name="planId">Identificador do plano</param>
        /// <param name="planItemId">Identificador do item do plano</param>
        /// <returns>Dados do item removido</returns>
        Task<PmPlanItemResponse?> DeletePlanItemAsync(string planId, string planItemId);
    }
}


