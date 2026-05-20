using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionCycle;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionDiscount;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionIncrement;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionInvoice;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItem;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItemUsage;
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionSplit;

namespace Berdsk.Sdk.PagarMe.V5.Services.Subscription
{
    /// <summary>
    /// Interface para o serviço de assinaturas.
    /// </summary>
    public interface IPmSubscriptionService
    {
        /// <summary>
        /// Serviço de itens da assinatura.
        /// </summary>
        IPmSubscriptionItemService Items { get; }

        /// <summary>
        /// Serviço de ciclos da assinatura.
        /// </summary>
        IPmSubscriptionCycleService Cycles { get; }

        /// <summary>
        /// Serviço de descontos da assinatura.
        /// </summary>
        IPmSubscriptionDiscountService Discounts { get; }

        /// <summary>
        /// Serviço de acréscimos da assinatura.
        /// </summary>
        IPmSubscriptionIncrementService Increments { get; }

        /// <summary>
        /// Serviço de faturas da assinatura.
        /// </summary>
        IPmSubscriptionInvoiceService Invoices { get; }

        /// <summary>
        /// Serviço de uso de itens da assinatura.
        /// </summary>
        IPmSubscriptionItemUsageService ItemUsage { get; }

        /// <summary>
        /// Serviço de split da assinatura.
        /// </summary>
        IPmSubscriptionSplitService Splits { get; }

        /// <summary>
        ///     Cria uma nova assinatura (avulsa ou de plano).
        ///     <para>Referência: https://docs.pagar.me/reference/criar-assinatura-avulsa.md</para>
        ///     <para>Referência: https://docs.pagar.me/reference/criar-assinatura-de-plano-1.md</para>
        /// </summary>
        /// <param name="request">Dados da assinatura</param>
        /// <returns>Dados da assinatura criada</returns>
        Task<PmSubscriptionResponse?> CreateSubscriptionAsync(PmCreateSubscriptionRequest request);

        /// <summary>
        ///     Obtém os dados de uma assinatura específica.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-assinatura-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura (sub_xxxxxxxxxxxxxxxx)</param>
        /// <returns>Dados da assinatura</returns>
        Task<PmSubscriptionResponse?> GetSubscriptionAsync(string subscriptionId);

        /// <summary>
        ///     Lista as assinaturas com filtros opcionais.
        ///     <para>Referência: https://docs.pagar.me/reference/listar-assinaturas-1.md</para>
        /// </summary>
        /// <param name="code">Filtro por código</param>
        /// <param name="status">Filtro por status</param>
        /// <param name="customerId">Filtro por cliente</param>
        /// <param name="planId">Filtro por plano</param>
        /// <param name="page">número da página</param>
        /// <param name="size">Quantidade de registros por página</param>
        /// <returns>Lista de assinaturas</returns>
        Task<PmListSubscriptionsResponse?> ListSubscriptionsAsync(string? code = null, string? status = null,
            string? customerId = null, string? planId = null, int? page = null, int? size = null);

        /// <summary>
        ///     Cancela uma assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/cancelar-assinatura-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="cancelPendingInvoices">Indica se deve cancelar faturas pendentes</param>
        /// <returns>Dados da assinatura cancelada</returns>
        Task<PmSubscriptionResponse?> CancelSubscriptionAsync(string subscriptionId, bool cancelPendingInvoices = true);

        /// <summary>
        ///     Atualiza o cartão da assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/editar-cartão-da-assinatura-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="request">Dados do novo cartão</param>
        /// <returns>Dados da assinatura atualizada</returns>
        Task<PmSubscriptionResponse?> UpdateSubscriptionCardAsync(string subscriptionId, PmUpdateSubscriptionCardRequest request);

        /// <summary>
        ///     Atualiza os metadados da assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/editar-metadados-da-assinatura-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="metadata">Novos metadados</param>
        /// <returns>Dados da assinatura atualizada</returns>
        Task<PmSubscriptionResponse?> UpdateSubscriptionMetadataAsync(string subscriptionId, Dictionary<string, string> metadata);

        /// <summary>
        ///     Atualiza o meio de pagamento da assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/editar-meio-de-pagamento-da-assinatura.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="request">Novos dados de pagamento</param>
        /// <returns>Dados da assinatura atualizada</returns>
        Task<PmSubscriptionResponse?> UpdateSubscriptionPaymentMethodAsync(string subscriptionId, PmUpdateSubscriptionPaymentMethodRequest request);

        /// <summary>
        ///     Atualiza a data de início da assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/editar-data-de-início-da-assinatura-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="startAt">Nova data de início</param>
        /// <returns>Dados da assinatura atualizada</returns>
        Task<PmSubscriptionResponse?> UpdateSubscriptionStartAtAsync(string subscriptionId, DateTime startAt);

        /// <summary>
        ///     Atualiza o preço mínimo da assinatura.
        ///     <para>Referência: https://docs.pagar.me/reference/editar-minimum-price-da-assinatura.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="minimumPrice">Novo preço mínimo</param>
        /// <returns>Dados da assinatura atualizada</returns>
        Task<PmSubscriptionResponse?> UpdateSubscriptionMinimumPriceAsync(string subscriptionId, int? minimumPrice);

        /// <summary>
        ///     Ativa ou desativa o faturamento manual.
        ///     <para>Referência: https://docs.pagar.me/reference/ativar-faturamento-manual-1.md</para>
        ///     <para>Referência: https://docs.pagar.me/reference/desativar-faturamento-manual-1.md</para>
        /// </summary>
        /// <param name="subscriptionId">Identificador da assinatura</param>
        /// <param name="enabled">True para ativar, False para desativar</param>
        /// <returns>True se atualizado com sucesso</returns>
        Task<bool> SetManualBillingAsync(string subscriptionId, bool enabled);
    }
}


