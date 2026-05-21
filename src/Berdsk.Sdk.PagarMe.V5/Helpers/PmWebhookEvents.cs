namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    ///     Helper estático com os nomes (string) de todos os eventos de webhook suportados pela API PagarMe v5.
    ///     <para>
    ///         Use estas constantes em vez de digitar a string do evento manualmente, evitando erros de digitação
    ///         ao comparar o campo <c>type</c> do payload recebido no webhook.
    ///     </para>
    ///     <para>
    ///         <see href="https://docs.pagar.me/reference/eventos-de-webhook-1">Documentação Oficial PagarMe</see>
    ///     </para>
    /// </summary>
    public static class PmWebhookEvents
    {
        // ===== Customer =====

        /// <summary>Ocorre sempre que um comprador é criado.</summary>
        public static string CustomerCreated { get; set; } = "customer.created";

        /// <summary>Ocorre sempre que um comprador é atualizado.</summary>
        public static string CustomerUpdated { get; set; } = "customer.updated";

        // ===== Card =====

        /// <summary>Ocorre sempre que um cartão é criado.</summary>
        public static string CardCreated { get; set; } = "card.created";

        /// <summary>Ocorre sempre que um cartão é atualizado.</summary>
        public static string CardUpdated { get; set; } = "card.updated";

        /// <summary>Ocorre sempre que um cartão é excluído.</summary>
        public static string CardDeleted { get; set; } = "card.deleted";

        /// <summary>Ocorre sempre que um cartão expira a data de validade.</summary>
        public static string CardExpired { get; set; } = "card.expired";

        // ===== Address =====

        /// <summary>Ocorre sempre que um endereço é criado.</summary>
        public static string AddressCreated { get; set; } = "address.created";

        /// <summary>Ocorre sempre que um endereço é atualizado.</summary>
        public static string AddressUpdated { get; set; } = "address.updated";

        /// <summary>Ocorre sempre que um endereço é excluído.</summary>
        public static string AddressDeleted { get; set; } = "address.deleted";

        // ===== Plan =====

        /// <summary>Ocorre sempre que um plano é criado.</summary>
        public static string PlanCreated { get; set; } = "plan.created";

        /// <summary>Ocorre sempre que um plano é atualizado.</summary>
        public static string PlanUpdated { get; set; } = "plan.updated";

        /// <summary>Ocorre sempre que um plano é excluído.</summary>
        public static string PlanDeleted { get; set; } = "plan.deleted";

        // ===== Plan Item =====

        /// <summary>Ocorre sempre que um item de plano é criado.</summary>
        public static string PlanItemCreated { get; set; } = "plan_item.created";

        /// <summary>Ocorre sempre que um item de plano é atualizado.</summary>
        public static string PlanItemUpdated { get; set; } = "plan_item.updated";

        /// <summary>Ocorre sempre que um item de plano é excluído.</summary>
        public static string PlanItemDeleted { get; set; } = "plan_item.deleted";

        // ===== Subscription =====

        /// <summary>Ocorre sempre que uma assinatura é criada.</summary>
        public static string SubscriptionCreated { get; set; } = "subscription.created";

        /// <summary>Ocorre sempre que a assinatura é cancelada.</summary>
        public static string SubscriptionCanceled { get; set; } = "subscription.canceled";

        // ===== Subscription Item =====

        /// <summary>Ocorre sempre que um item de assinatura é criado.</summary>
        public static string SubscriptionItemCreated { get; set; } = "subscription_item.created";

        /// <summary>Ocorre sempre que um item de assinatura é atualizado.</summary>
        public static string SubscriptionItemUpdated { get; set; } = "subscription_item.updated";

        /// <summary>Ocorre sempre que um item de assinatura é excluído.</summary>
        public static string SubscriptionItemDeleted { get; set; } = "subscription_item.deleted";

        // ===== Discount =====

        /// <summary>Ocorre sempre que um desconto é criado.</summary>
        public static string DiscountCreated { get; set; } = "discount.created";

        /// <summary>Ocorre sempre que um desconto é excluído.</summary>
        public static string DiscountDeleted { get; set; } = "discount.deleted";

        // ===== Increment =====

        /// <summary>Ocorre sempre que um incremento é criado.</summary>
        public static string IncrementCreated { get; set; } = "increment.created";

        /// <summary>Ocorre sempre que um incremento é excluído.</summary>
        public static string IncrementDeleted { get; set; } = "increment.deleted";

        // ===== Order =====

        /// <summary>Ocorre sempre que um pedido é pago.</summary>
        public static string OrderPaid { get; set; } = "order.paid";

        /// <summary>Ocorre sempre que o pagamento de um pedido falha.</summary>
        public static string OrderPaymentFailed { get; set; } = "order.payment_failed";

        /// <summary>Ocorre sempre que um pedido é criado.</summary>
        public static string OrderCreated { get; set; } = "order.created";

        /// <summary>Ocorre sempre que um pedido é cancelado.</summary>
        public static string OrderCanceled { get; set; } = "order.canceled";

        /// <summary>Ocorre sempre que um pedido é fechado.</summary>
        public static string OrderClosed { get; set; } = "order.closed";

        /// <summary>Ocorre sempre que um pedido é atualizado.</summary>
        public static string OrderUpdated { get; set; } = "order.updated";

        // ===== Order Item =====

        /// <summary>Ocorre sempre que um item do pedido é criado.</summary>
        public static string OrderItemCreated { get; set; } = "order_item.created";

        /// <summary>Ocorre sempre que um item do pedido é atualizado.</summary>
        public static string OrderItemUpdated { get; set; } = "order_item.updated";

        /// <summary>Ocorre sempre que um item do pedido é excluído.</summary>
        public static string OrderItemDeleted { get; set; } = "order_item.deleted";

        // ===== Invoice =====

        /// <summary>Ocorre sempre que uma fatura é criada.</summary>
        public static string InvoiceCreated { get; set; } = "invoice.created";

        /// <summary>Ocorre sempre que uma fatura é atualizada.</summary>
        public static string InvoiceUpdated { get; set; } = "invoice.updated";

        /// <summary>Ocorre sempre que uma fatura é paga.</summary>
        public static string InvoicePaid { get; set; } = "invoice.paid";

        /// <summary>Ocorre sempre que o pagamento de uma fatura falha.</summary>
        public static string InvoicePaymentFailed { get; set; } = "invoice.payment_failed";

        /// <summary>Ocorre sempre que uma fatura é cancelada.</summary>
        public static string InvoiceCanceled { get; set; } = "invoice.canceled";

        // ===== Charge =====

        /// <summary>Ocorre sempre que uma cobrança é criada.</summary>
        public static string ChargeCreated { get; set; } = "charge.created";

        /// <summary>Ocorre sempre que uma cobrança é atualizada.</summary>
        public static string ChargeUpdated { get; set; } = "charge.updated";

        /// <summary>Ocorre sempre que uma cobrança é paga.</summary>
        public static string ChargePaid { get; set; } = "charge.paid";

        /// <summary>Ocorre sempre que o pagamento de uma cobrança falha.</summary>
        public static string ChargePaymentFailed { get; set; } = "charge.payment_failed";

        /// <summary>Ocorre sempre que uma cobrança é estornada.</summary>
        public static string ChargeRefunded { get; set; } = "charge.refunded";

        /// <summary>Ocorre sempre que uma cobrança é pendente.</summary>
        public static string ChargePending { get; set; } = "charge.pending";

        /// <summary>Ocorre sempre que uma cobrança ainda está sendo processada.</summary>
        public static string ChargeProcessing { get; set; } = "charge.processing";

        /// <summary>Ocorre sempre que uma cobrança foi paga a menos.</summary>
        public static string ChargeUnderpaid { get; set; } = "charge.underpaid";

        /// <summary>Ocorre sempre que uma cobrança foi paga a mais.</summary>
        public static string ChargeOverpaid { get; set; } = "charge.overpaid";

        /// <summary>Ocorre sempre que uma cobrança foi parcialmente cancelada.</summary>
        public static string ChargePartialCanceled { get; set; } = "charge.partial_canceled";

        /// <summary>Ocorre sempre que uma cobrança sofre chargeback.</summary>
        public static string ChargeChargedback { get; set; } = "charge.chargedback";

        /// <summary>Ocorre quando um pedido no antifraude é aprovado.</summary>
        public static string ChargeAntifraudApproved { get; set; } = "charge.antifraud_approved";

        /// <summary>Ocorre quando um pedido no antifraude é reprovado.</summary>
        public static string ChargeAntifraudReproved { get; set; } = "charge.antifraud_reproved";

        /// <summary>Ocorre quando um pedido no antifraude é marcado para análise manual.</summary>
        public static string ChargeAntifraudManual { get; set; } = "charge.antifraud_manual";

        /// <summary>Ocorre quando um pedido está pendente de envio para a análise do serviço de antifraude.</summary>
        public static string ChargeAntifraudPending { get; set; } = "charge.antifraud_pending";

        // ===== Usage =====

        /// <summary>Ocorre sempre que o uso de um item no período é criado.</summary>
        public static string UsageCreated { get; set; } = "usage.created";

        /// <summary>Ocorre sempre que o uso de um item no período é excluído.</summary>
        public static string UsageDeleted { get; set; } = "usage.deleted";

        // ===== Recipient =====

        /// <summary>Ocorre sempre que um recebedor é criado.</summary>
        public static string RecipientCreated { get; set; } = "recipient.created";

        /// <summary>Ocorre sempre que um recebedor é excluído.</summary>
        public static string RecipientDeleted { get; set; } = "recipient.deleted";

        /// <summary>Ocorre sempre que um recebedor é atualizado.</summary>
        public static string RecipientUpdated { get; set; } = "recipient.updated";

        // ===== Bank Account =====

        /// <summary>Ocorre sempre que uma conta bancária é criada.</summary>
        public static string BankAccountCreated { get; set; } = "bank_account.created";

        /// <summary>Ocorre sempre que uma conta bancária é atualizada.</summary>
        public static string BankAccountUpdated { get; set; } = "bank_account.updated";

        /// <summary>Ocorre sempre que uma conta bancária é excluída.</summary>
        public static string BankAccountDeleted { get; set; } = "bank_account.deleted";

        // ===== Checkout =====

        /// <summary>Ocorre quando um checkout é criado.</summary>
        public static string CheckoutCreated { get; set; } = "checkout.created";

        /// <summary>Ocorre quando um checkout é cancelado.</summary>
        public static string CheckoutCanceled { get; set; } = "checkout.canceled";

        /// <summary>Ocorre quando um checkout é fechado.</summary>
        public static string CheckoutClosed { get; set; } = "checkout.closed";
    }
}