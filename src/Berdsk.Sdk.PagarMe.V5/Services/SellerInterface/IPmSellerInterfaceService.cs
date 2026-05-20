using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface
{
    /// <summary>
    ///     Interface para o serviço de Interface Eletrônica para Sellers (Res. 264/349).
    /// </summary>
    public interface IPmSellerInterfaceService
    {
        /// <summary>
        ///     Retorna as Unidades de Recebíveis (URs) de um recebedor.
        ///     <para>Referência: https://docs.pagar.me/reference/retornando-urs-de-um-recebedor-v5.md</para>
        /// </summary>
        /// <param name="recipientId">Identificador do recebedor</param>
        /// <param name="startDate">Dia inicial da consulta de agenda</param>
        /// <param name="endDate">Dia final da consulta de agenda</param>
        /// <returns>Lista de Unidades de Recebíveis</returns>
        Task<List<PmReceivableUnitResponse>?> ListReceivableUnitsAsync(string recipientId, DateTime startDate,
            DateTime endDate);

        /// <summary>
        ///     Retorna os efeitos de contratos (obrigações de liquidação).
        ///     <para>Referência: https://docs.pagar.me/reference/retornando-efeitos-de-contratos-v5.md</para>
        /// </summary>
        /// <param name="expectedSettlementDateSince">Data inicial da consulta</param>
        /// <param name="expectedSettlementDateUntil">Data final da consulta</param>
        /// <param name="recipientId">ID de recebedor desejado</param>
        /// <param name="page">Página desejada da consulta</param>
        /// <param name="size">Quantidade de efeitos retornados</param>
        /// <returns>Lista de efeitos de contratos e informações de paginação</returns>
        Task<PmListSettlementObligationsResponse?> ListSettlementObligationsAsync(
            DateTime expectedSettlementDateSince,
            DateTime expectedSettlementDateUntil,
            string? recipientId = null,
            int? page = null,
            int? size = null);

        /// <summary>
        ///     Retorna os contratos de um recebedor.
        ///     <para>Referência: https://docs.pagar.me/reference/retornando-efeitos-de-contratos-copy.md</para>
        /// </summary>
        /// <param name="recipientId">ID de recebedor desejado</param>
        /// <param name="expectedSettlementDateSince">Data inicial da consulta</param>
        /// <param name="expectedSettlementDateUntil">Data final da consulta</param>
        /// <returns>Lista de contratos</returns>
        Task<List<PmContractResponse>?> ListContractsAsync(string recipientId, DateTime expectedSettlementDateSince,
            DateTime expectedSettlementDateUntil);

        /// <summary>
        ///     Retorna as contestações de contratos.
        ///     <para>Referência: https://docs.pagar.me/reference/retornando-contestações.md</para>
        /// </summary>
        /// <param name="contractKey">Chave Identificadora do contrato</param>
        /// <param name="page">Paginação</param>
        /// <param name="size">Quantidade de Itens (Contestações) a serem retornados</param>
        /// <param name="id">Chave Identificadora da Contestação</param>
        /// <param name="originalAssetHolderDocument">Documento do originador da UR</param>
        /// <param name="status">Status da Contestação</param>
        /// <param name="createdAt">Data de Abertura da Contestação</param>
        /// <returns>Lista de contestações e informações de paginação</returns>
        Task<PmListContestationsResponse?> ListContestationsAsync(
            string contractKey,
            int? page = null,
            int? size = null,
            string? id = null,
            string? originalAssetHolderDocument = null,
            string? status = null,
            DateTime? createdAt = null);

        /// <summary>
        ///     Cria uma nova contestação de contrato.
        ///     <para>Referência: https://docs.pagar.me/reference/contestando-um-contrato-v5.md</para>
        /// </summary>
        /// <param name="request">Dados da contestação</param>
        Task CreateContestationAsync(PmCreateContestationRequest request);
    }
}