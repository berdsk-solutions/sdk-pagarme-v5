---
tags: [assinaturas, recorrencia, fatura, cobranca-automatica]
---
# .Subscription: Gestão de Assinaturas e Recorrência

O serviço `.Subscription` é um dos módulos mais robustos do SDK, permitindo a criação de cobranças recorrentes automáticas. Ele suporta tanto assinaturas baseadas em **Planos** pré-definidos quanto assinaturas **Avulsas** (on-the-fly), com suporte a múltiplos itens, faturamento por uso (metered billing) e split de pagamento.

## Métodos Disponíveis

### Serviço Principal: `.Subscription`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `CreateSubscriptionAsync` | Cria uma nova assinatura. | `PmCreateSubscriptionRequest` | `PmSubscriptionResponse` |
| `GetSubscriptionAsync` | Obtém detalhes de uma assinatura. | `id` (string) | `PmSubscriptionResponse` |
| `ListSubscriptionsAsync` | Lista assinaturas com filtros. | Filtros opcionais | `PmListSubscriptionsResponse` |
| `CancelSubscriptionAsync` | Cancela uma assinatura ativa. | `id`, `cancelPendingInvoices` | `PmSubscriptionResponse` |
| `UpdateSubscriptionCardAsync` | Atualiza o cartão da assinatura. | `id`, `PmUpdateSubscriptionCardRequest`| `PmSubscriptionResponse` |
| `UpdateSubscriptionPaymentMethodAsync`| Altera o meio de pagamento. | `id`, `PmUpdateSubscriptionPaymentMethodRequest`| `PmSubscriptionResponse` |
| `UpdateSubscriptionMetadataAsync` | Atualiza metadados da assinatura. | `id`, `Dictionary` | `PmSubscriptionResponse` |
| `UpdateSubscriptionStartAtAsync` | Altera a data de início. | `id`, `DateTime` | `PmSubscriptionResponse` |
| `UpdateSubscriptionMinimumPriceAsync` | Define o preço mínimo por ciclo. | `id`, `minimumPrice` (int?) | `PmSubscriptionResponse` |
| `SetManualBillingAsync` | Ativa/Desativa faturamento manual. | `id`, `enabled` (bool) | `bool` |

### Sub-serviços de Assinatura

#### 1. Itens (`.Subscription.Items`)
| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `CreateSubscriptionItemAsync` | Adiciona um item à assinatura. | `subId`, `PmCreateSubscriptionItemRequestDto` | `PmSubscriptionItemResponse` |
| `GetSubscriptionItemAsync` | Obtém detalhes de um item. | `subId`, `itemId` | `PmSubscriptionItemResponse` |
| `ListSubscriptionItemsAsync` | Lista todos os itens da assinatura. | `subId` (string) | `PmListSubscriptionItemsResponse` |
| `UpdateSubscriptionItemAsync` | Altera preço/quantidade de um item. | `subId`, `itemId`, `PmUpdateSubscriptionItemRequest` | `PmSubscriptionItemResponse` |
| `DeleteSubscriptionItemAsync` | Remove um item da assinatura. | `subId`, `itemId` | `PmSubscriptionItemResponse` |

#### 2. Ciclos e Renovação (`.Subscription.Cycles`)
| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `ListSubscriptionCyclesAsync` | Lista o histórico de ciclos. | `subId` (string) | `PmListSubscriptionCyclesResponse` |
| `GetSubscriptionCycleAsync` | Obtém detalhes de um ciclo. | `subId`, `cycleId` | `PmSubscriptionCycleResponse` |
| `RenewSubscriptionCycleAsync` | Força renovação imediata do ciclo. | `subId` (string) | `PmSubscriptionCycleResponse` |

#### 3. Descontos e Acréscimos (`.Subscription.Discounts` / `.Subscription.Increments`)
| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `CreateSubscriptionDiscountAsync` | Aplica um desconto à assinatura. | `subId`, `PmCreateSubscriptionDiscountRequest` | `PmSubscriptionDiscountResponse` |
| `ListSubscriptionDiscountsAsync` | Lista descontos da assinatura. | `subId` (string) | `PmListSubscriptionDiscountsResponse` |
| `DeleteSubscriptionDiscountAsync` | Remove um desconto. | `subId`, `discountId` | `PmSubscriptionDiscountResponse` |
| `CreateSubscriptionIncrementAsync` | Aplica um acréscimo à assinatura. | `subId`, `PmCreateSubscriptionIncrementRequest` | `PmSubscriptionIncrementResponse` |
| `ListSubscriptionIncrementsAsync` | Lista acréscimos da assinatura. | `subId` (string) | `PmListSubscriptionIncrementsResponse` |
| `DeleteSubscriptionIncrementAsync` | Remove um acréscimo. | `subId`, `incrementId` | `PmSubscriptionIncrementResponse` |

#### 4. Faturas (`.Subscription.Invoices`)
| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `GetInvoiceAsync` | Obtém detalhes de uma fatura. | `invoiceId` (string) | `PmSubscriptionInvoiceResponse` |
| `ListSubscriptionInvoicesAsync` | Lista faturas de uma assinatura. | `subId` (string) | `PmListSubscriptionInvoicesResponse` |
| `CreateInvoiceAsync` | Gera fatura de um ciclo específico. | `subId`, `cycleId` | `PmSubscriptionInvoiceResponse` |

#### 5. Uso de Itens (`.Subscription.ItemUsage`)
| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `CreateUsageAsync` | Registra consumo (metered billing). | `subId`, `itemId`, `PmCreateSubscriptionItemUsageRequest` | `PmSubscriptionItemUsageResponse` |
| `ListUsagesAsync` | Lista registros de uso de um item. | `subId`, `itemId` | `PmListSubscriptionItemUsagesResponse` |
| `DeleteUsageAsync` | Remove um registro de uso. | `subId`, `itemId`, `usageId` | `PmSubscriptionItemUsageResponse` |

#### 6. Split de Assinaturas (`.Subscription.Splits`)
| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `GetSubscriptionSplitAsync` | Obtém regras de split da assinatura. | `subId` (string) | `PmSubscriptionSplitResponse` |
| `UpdateSubscriptionSplitAsync` | Atualiza regras de split. | `subId`, `PmUpdateSubscriptionSplitRequest` | `PmSubscriptionSplitResponse` |

---

## Exemplos de Uso

## Criando uma Assinatura

Existem duas formas principais de criar uma assinatura: vinculada a um Plano ou de forma Avulsa.

### 1. Assinatura de Plano
Utiliza as regras (preço, intervalo, itens) já configuradas em um Plano.

- **DTO de Entrada:** `PmCreateSubscriptionRequest`
- **DTO de Saída:** `PmSubscriptionResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Helpers;
using Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos;

var subRequest = new PmCreateSubscriptionRequest
{
    PlanId = "plan_xxxxxxxxxxxx", // ID do plano pré-configurado
    PaymentMethod = PmPaymentMethod.CreditCard,
    CustomerId = "cus_xxxxxxxxxxxx",
    CardId = "card_xxxxxxxxxxxx"
};

var subscription = await client.Subscription.CreateSubscriptionAsync(subRequest);
```

### 2. Assinatura Avulsa (Customizada)
Você define os itens, intervalo e regras no momento da criação, sem depender de um plano.

```csharp
var subRequest = new PmCreateSubscriptionRequest
{
    PaymentMethod = PmPaymentMethod.CreditCard,
    CustomerId = "cus_xxxxxxxxxxxx",
    CardToken = "token_xxxxxxxxxxxx",
    Interval = PmInterval.Month,
    IntervalCount = 1,
    BillingType = PmBillingType.Prepaid,
    Items = new List<PmCreateSubscriptionItemRequest>
    {
        new PmCreateSubscriptionItemRequest
        {
            Description = "Mensalidade Premium",
            Quantity = 1,
            PricingScheme = new PmPricingSchemeRequest
            {
                Price = 9990 // R$ 99,90
            }
        }
    }
};

var subscription = await client.Subscription.CreateSubscriptionAsync(subRequest);
```

### 3. Assinatura com Boleto
Ao utilizar boleto, a cada renovação de ciclo será gerada uma nova fatura com um boleto para pagamento. É altamente recomendável enviar o endereço de cobrança. Você pode enviar o objeto completo (`BillingAddress`) ou o ID de um endereço já cadastrado para o cliente (`BillingAddressId`).

#### Exemplo com Endereço Completo:
```csharp
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

var subRequest = new PmCreateSubscriptionRequest
{
    PaymentMethod = PmPaymentMethod.Boleto,
    CustomerId = "cus_xxxxxxxxxxxx",
    Interval = PmInterval.Month,
    IntervalCount = 1,
    BillingType = PmBillingType.Prepaid,
    BillingAddress = new PmCreateCustomerAddressRequest
    {
        Line1 = "123, Rua das Flores, Centro",
        ZipCode = "12345678",
        City = "São Paulo",
        State = "SP",
        Country = "BR"
    },
    Items = new List<PmCreateSubscriptionItemRequest>
    {
        new PmCreateSubscriptionItemRequest
        {
            Description = "Assinatura Mensal",
            Quantity = 1,
            PricingScheme = new PmPricingSchemeRequest { Price = 5000 }
        }
    }
};

var subscription = await client.Subscription.CreateSubscriptionAsync(subRequest);
```

#### Exemplo com ID de Endereço (Recomendado se o cliente já possui endereço):
```csharp
var subRequest = new PmCreateSubscriptionRequest
{
    PaymentMethod = PmPaymentMethod.Boleto,
    CustomerId = "cus_xxxxxxxxxxxx",
    BillingAddressId = "addr_xxxxxxxxxxxx", // ID do endereço já salvo no cliente
    Interval = PmInterval.Month,
    IntervalCount = 1,
    BillingType = PmBillingType.Prepaid,
    Items = new List<PmCreateSubscriptionItemRequest>
    {
        new PmCreateSubscriptionItemRequest
        {
            Description = "Assinatura Mensal",
            Quantity = 1,
            PricingScheme = new PmPricingSchemeRequest { Price = 5000 }
        }
    }
};

var subscription = await client.Subscription.CreateSubscriptionAsync(subRequest);
```

### 4. Assinatura com Pix
Semelhante ao boleto, a cada ciclo uma nova fatura será gerada contendo o QR Code e o código "Copia e Cola" do Pix.

```csharp
var subRequest = new PmCreateSubscriptionRequest
{
    PaymentMethod = PmPaymentMethod.Pix,
    CustomerId = "cus_xxxxxxxxxxxx",
    Interval = PmInterval.Week,
    IntervalCount = 1,
    BillingType = PmBillingType.Prepaid,
    Items = new List<PmCreateSubscriptionItemRequest>
    {
        new PmCreateSubscriptionItemRequest
        {
            Description = "Plano Semanal",
            Quantity = 1,
            PricingScheme = new PmPricingSchemeRequest { Price = 2500 }
        }
    }
};

var subscription = await client.Subscription.CreateSubscriptionAsync(subRequest);
```

---

## Gestão do Ciclo de Vida

### Cancelamento
Ao cancelar, você pode decidir se as faturas que já foram geradas e estão pendentes também devem ser canceladas.

```csharp
// Cancela a assinatura e todas as faturas pendentes
await client.Subscription.CancelSubscriptionAsync("sub_xxxxxxxxxxxx", cancelPendingInvoices: true);
```

### Alterar Meio de Pagamento
Útil quando o cartão do cliente expira ou ele deseja mudar de Cartão para Boleto.

```csharp
var updateRequest = new PmUpdateSubscriptionPaymentMethodRequest
{
    PaymentMethod = PmPaymentMethod.Boleto
};

await client.Subscription.UpdateSubscriptionPaymentMethodAsync("sub_xxxxxxxxxxxx", updateRequest);
```

---

## Sub-Serviços de Assinatura

O serviço de assinaturas é composto por vários sub-módulos para controle granular:

### 1. Itens (`.Subscription.Items`)
Permite adicionar, remover ou atualizar itens em uma assinatura existente.

#### Exemplo: Manipulação de Itens
```csharp
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItem.Dtos;

// Adicionar um item extra à assinatura
var newItem = await client.Subscription.Items.CreateSubscriptionItemAsync("sub_xxx", new PmCreateSubscriptionItemRequestDto
{
    Description = "Serviço Adicional",
    Quantity = 1,
    PricingScheme = new PmPricingSchemeRequest { Price = 2000 }
});

// Atualizar a quantidade de um item
await client.Subscription.Items.UpdateSubscriptionItemAsync("sub_xxx", newItem.Id, new PmUpdateSubscriptionItemRequest
{
    Quantity = 2,
    Status = "active"
});
```

### 2. Ciclos e Renovação (`.Subscription.Cycles`)
Permite consultar o histórico de períodos da assinatura e forçar uma renovação.

```csharp
// Listar ciclos de uma assinatura
var cycles = await client.Subscription.Cycles.ListSubscriptionCyclesAsync("sub_xxxxxxxxxxxx");

// Renovar o ciclo atual imediatamente (gera nova fatura)
var renewedCycle = await client.Subscription.Cycles.RenewSubscriptionCycleAsync("sub_xxxxxxxxxxxx");
```

### 3. Descontos e Acréscimos (`.Subscription.Discounts` / `.Subscription.Increments`)
Gestão de ajustes financeiros que podem ser aplicados a um ciclo específico ou por tempo indeterminado.

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionDiscount.Dtos;

// Aplicar um desconto de R$ 10,00 na próxima fatura
await client.Subscription.Discounts.CreateSubscriptionDiscountAsync("sub_xxx", new PmCreateSubscriptionDiscountRequest
{
    Value = 1000,
    DiscountType = "flat",
    Cycles = 1 // Aplicar apenas no próximo ciclo
});
```

### 4. Faturas (`.Subscription.Invoices`)
Acesso às faturas (`in_...`) geradas pela assinatura.

```csharp
// Listar faturas de uma assinatura específica
var invoices = await client.Subscription.Invoices.ListSubscriptionInvoicesAsync("sub_xxxxxxxxxxxx");

// Criar manualmente a fatura de um ciclo específico
await client.Subscription.Invoices.CreateInvoiceAsync("sub_xxx", "cycle_xxx");
```

### 5. Uso de Itens (`.Subscription.ItemUsage`)
Para cobranças baseadas em consumo (metered billing).

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionItemUsage.Dtos;

// Registrar consumo de 15 unidades de um item
await client.Subscription.ItemUsage.CreateUsageAsync("sub_xxx", "si_xxx", new PmCreateSubscriptionItemUsageRequest
{
    Quantity = 15,
    UsedAt = DateTime.Now,
    Description = "Excedente de armazenamento"
});
```

### 6. Split de Assinaturas (`.Subscription.Splits`)
Configura a divisão automática de valores em cada renovação da assinatura.

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.SubscriptionSplit.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.Common.Dtos;

var splitUpdate = new PmUpdateSubscriptionSplitRequest
{
    Enabled = true,
    Rules = new List<PmSplitRequest>
    {
        new PmSplitRequest { RecipientId = "re_xxx", Percentage = 80, Type = "percentage" },
        new PmSplitRequest { RecipientId = "re_yyy", Percentage = 20, Type = "percentage" }
    }
};

await client.Subscription.Splits.UpdateSubscriptionSplitAsync("sub_xxxxxxxxxxxx", splitUpdate);
```

---

## Dicas para IAs ao utilizar .Subscription:

1. **Planos vs Avulsas:** Sempre pergunte ou verifique se o modelo de negócio utiliza Planos (fixos) ou se as assinaturas variam para cada cliente (Avulsas).
2. **Uso de Helpers:** Utilize classes como `PmSubscriptionStatus`, `PmPaymentMethod`, `PmInterval` e `PmBillingType` para comparar ou definir o estado e configurações das assinaturas.
3. **Billing Day:** O `BillingDay` só é respeitado se o `BillingType` for `PmBillingType.ExactDay`. Em assinaturas `PmBillingType.Prepaid`, a cobrança ocorre sempre no início do ciclo.
4. **Ciclo de Vida das Faturas:** Uma assinatura ativa gera faturas. Se a fatura falha, a assinatura pode entrar em estado de inadimplência (dependendo das regras de retentativa configuradas na Dashboard).
5. **Metered Billing:** Para itens cobrados por uso, certifique-se de registrar os consumos via `.Subscription.ItemUsage` antes do fechamento do ciclo para que sejam incluídos na fatura correta.
6. **Split na Assinatura:** O SDK permite configurar regras de split diretamente na assinatura através de `.Subscription.Splits`, garantindo que toda renovação automática já nasça com a divisão de valores aplicada.
7. **Boleto e Pix na Recorrência:** Para meios de pagamento não automáticos (Boleto/Pix), a assinatura permanece com o status `active`, mas a fatura do ciclo nasce como `pending`. É essencial utilizar Webhooks para monitorar o pagamento das faturas (`invoice.paid`) e liberar o serviço ao cliente.
8. **Reutilização de Endereços:** Sempre que o cliente já possuir endereços cadastrados, prefira utilizar o `BillingAddressId` em vez de enviar o objeto `BillingAddress` completo. Isso evita redundância e simplifica a requisição.

---

[Anterior: Cobranças](./04-charge.md) | [Início](./00-comece-aqui.md) | [Próximo: Planos](./06-plan.md)
