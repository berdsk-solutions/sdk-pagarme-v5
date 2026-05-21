using System.Collections.Generic;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.PlanItem;

namespace Berdsk.Sdk.PagarMe.V5.Services.Plan
{
    /// <summary>
    ///     Interface para o serviço de planos.
    /// </summary>
    public interface IPmPlanService
    {
        /// <summary>
        ///     Serviço de itens do plano.
        /// </summary>
        IPmPlanItemService Items { get; }

        /// <summary>
        ///     Cria um novo plano.
        ///     <see href="https://docs.pagar.me/reference/criar-plano-1">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="request">Dados do plano</param>
        /// <returns>Dados do plano criado</returns>
        Task<PmPlanResponse?> CreatePlanAsync(PmCreatePlanRequest request);

        /// <summary>
        ///     Obtém os dados de um plano específico.
        ///     <see href="https://docs.pagar.me/reference/obter-plano-1">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="planId">Identificador do plano (plan_xxxxxxxxxxxxxxxx)</param>
        /// <returns>Dados do plano</returns>
        Task<PmPlanResponse?> GetPlanAsync(string planId);

        /// <summary>
        ///     Atualiza os dados de um plano existente.
        ///     <see href="https://docs.pagar.me/reference/editar-plano-1">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="planId">Identificador do plano</param>
        /// <param name="request">Dados para atualização</param>
        /// <returns>Dados do plano atualizado</returns>
        Task<PmPlanResponse?> UpdatePlanAsync(string planId, PmUpdatePlanRequest request);

        /// <summary>
        ///     Exclui um plano.
        ///     <see href="https://docs.pagar.me/reference/excluir-plano-1">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="planId">Identificador do plano</param>
        /// <returns>Dados do plano excluído</returns>
        Task<PmPlanResponse?> DeletePlanAsync(string planId);

        /// <summary>
        ///     Lista os planos cadastrados com filtros opcionais.
        ///     <see href="https://docs.pagar.me/reference/listar-planos-1">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="name">Filtro por nome</param>
        /// <param name="status">Filtro por status</param>
        /// <param name="page">número da página</param>
        /// <param name="size">Quantidade de registros por página</param>
        /// <returns>Lista de planos</returns>
        Task<PmListPlansResponse?> ListPlansAsync(string? name = null, string? status = null, int? page = null,
            int? size = null);

        /// <summary>
        ///     Atualiza os metadados de um plano.
        ///     <see href="https://docs.pagar.me/reference/editar-metadados-do-plano-1">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="planId">Identificador do plano</param>
        /// <param name="metadata">Novos metadados</param>
        /// <returns>Dados do plano atualizado</returns>
        Task<PmPlanResponse?> UpdatePlanMetadataAsync(string planId, Dictionary<string, string> metadata);
    }
}