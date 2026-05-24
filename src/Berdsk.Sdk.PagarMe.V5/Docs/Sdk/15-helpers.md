---
tags: [constantes, status, enums, seguranca, boas-praticas]
---
# Helpers: Dicionário de Constantes e Status

O SDK disponibiliza um conjunto de classes `Helper` no namespace `Berdsk.Sdk.PagarMe.V5.Helpers`. Essas classes funcionam como enums de strings, centralizando todos os valores possíveis para status, meios de pagamento, intervalos e eventos. O uso de Helpers é altamente recomendado para evitar "magic strings" e reduzir erros de digitação.

## Lista de Helpers Disponíveis

| Classe | Contexto | Exemplo de Valor |
| :--- | :--- | :--- |
| `PmOrderStatus` | Status de Pedidos | `PmOrderStatus.Paid`, `PmOrderStatus.Canceled` |
| `PmChargeStatus` | Status de Cobranças | `PmChargeStatus.Authorized`, `PmChargeStatus.Paid` |
| `PmCustomerStatus` | Status de Clientes | `PmCustomerStatus.Active`, `PmCustomerStatus.Disabled` |
| `PmPaymentMethod` | Meios de Pagamento | `PmPaymentMethod.CreditCard`, `PmPaymentMethod.Pix` |
| `PmInterval` | Ciclos de Assinatura | `PmInterval.Month`, `PmInterval.Year` |
| `PmBillingType` | Tipo de Cobrança | `PmBillingType.Prepaid`, `PmBillingType.Postpaid` |
| `PmSubscriptionStatus` | Status de Assinaturas | `PmSubscriptionStatus.Active`, `PmSubscriptionStatus.Canceled` |
| `PmRecipientStatus` | Status de Recebedores | `PmRecipientStatus.Active`, `PmRecipientStatus.Suspended` |
| `PmDisputeStatus` | Status de Chargebacks | `PmDisputeStatus.Opened`, `PmDisputeStatus.Won` |
| `PmWebhookEvents` | Eventos de Webhook | `PmWebhookEvents.OrderPaid`, `PmWebhookEvents.ChargeFailed` |
| `PmTransferStatus` | Status de Saques | `PmTransferStatus.Transferred`, `PmTransferStatus.Failed` |
| `PmSettlementsStatus` | Status de Liquidações | `PmSettlementsStatus.Success`, `PmSettlementsStatus.Pending` |
| `PmPlanStatus` | Status de Planos | `PmPlanStatus.Active`, `PmPlanStatus.Inactive` |
| `PmCardStatus` | Status de Cartões | `PmCardStatus.Active`, `PmCardStatus.Expired` |
| `PmBoletoStatus` | Status de Boletos | `PmBoletoStatus.Generated`, `PmBoletoStatus.Paid` |
| `PmPixStatus` | Status de Pix | `PmPixStatus.Generated`, `PmPixStatus.Completed` |

---

## Como Utilizar

Para utilizar os Helpers, você deve importar o namespace correspondente e acessar as propriedades estáticas.

### 1. Em Filtros de Busca
Ao listar recursos, use os Helpers para garantir que o filtro de status esteja correto.

```csharp
using Berdsk.Sdk.PagarMe.V5.Helpers;

// Listar apenas pedidos pagos
var orders = await client.Order.ListOrdersAsync(
    status: PmOrderStatus.Paid,
    limit: 10
);
```

### 2. Em Comparações de Lógica
Ao processar uma resposta ou um Webhook, valide o status utilizando as constantes.

```csharp
var charge = await client.Charge.GetChargeAsync("ch_xxxxxxxx");

if (charge.Status == PmChargeStatus.Paid)
{
    Console.WriteLine("O pagamento foi confirmado!");
}
else if (charge.Status == PmChargeStatus.Underpaid)
{
    Console.WriteLine("O valor pago é menor que o esperado.");
}
```

### 3. Na Criação de Recursos (Assinaturas e Pedidos)
Evite digitar o nome do meio de pagamento ou intervalo manualmente.

```csharp
var request = new PmCreateSubscriptionRequest
{
    PaymentMethod = PmPaymentMethod.CreditCard,
    Interval = PmInterval.Month,
    BillingType = PmBillingType.Prepaid,
    // ...
};
```

---

## Tabela de Referência Detalhada (Status Adicionais)

Além dos principais, o SDK cobre estados específicos de cada método de pagamento e sub-serviços:

| Classe | Finalidade |
| :--- | :--- |
| `PmAddressStatus` | Status de endereços (active/inactive). |
| `PmAnticipationStatus` | Status de pedidos de antecipação. |
| `PmBalanceOperationStatus` | Tipos de movimentação no extrato (fee, split, etc). |
| `PmBankAccountStatus` | Status de contas bancárias de recebedores. |
| `PmCashStatus` | Status de pagamentos em dinheiro. |
| `PmCreditCardStatus` | Estados específicos de transação de crédito. |
| `PmDebitCardStatus` | Estados específicos de transação de débito. |
| `PmPayableStatus` | Status de recebíveis (paid, waiting_funds, etc). |
| `PmSubscriptionInvoiceStatus` | Status de faturas de assinatura. |
| `PmWebhookDeliveryStatus` | Status de entrega da notificação (sent, failed). |

---

## Dicas para IAs ao utilizar Helpers:

1. **Nunca use Strings Manuais:** Sempre que uma propriedade de DTO ou parâmetro de método aceitar um status ou tipo, procure o Helper correspondente.
2. **Namespace:** Lembre-se sempre de sugerir o `using Berdsk.Sdk.PagarMe.V5.Helpers;` no topo dos exemplos.
3. **IntelliSense Natural:** Como as classes são estáticas com constantes `string`, elas facilitam a descoberta de valores possíveis para o desenvolvedor e para o treinamento da IA.
4. **Alinhamento com a API:** Os valores contidos nos Helpers (ex: `"paid"`, `"credit_card"`) são exatamente os esperados pela API PagarMe V5. O Helper serve apenas como uma camada de segurança.
5. **Casos Sensíveis:** Note que alguns Helpers possuem nomes muito próximos (ex: `PmChargeStatus` vs `PmCreditCardStatus`). Use `PmChargeStatus` para o status geral da cobrança e `PmCreditCardStatus` para detalhes técnicos da transação.

---

[Anterior: Disputas](./14-dispute.md) | [Início](./00-comece-aqui.md) | [Próximo: Exceptions](./16-exceptions.md)
