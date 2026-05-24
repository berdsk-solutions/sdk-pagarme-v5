---
tags: [planos, configuracao-recorrente, mensalidade, anualidade]
---
# Gestão de Planos (.Plan)

O serviço de Planos permite que você defina regras de cobrança (preço, intervalo, meios de pagamento) que podem ser reutilizadas por múltiplas assinaturas. Ao utilizar um plano, você garante que todos os assinantes vinculados a ele sigam as mesmas condições comerciais.

## Métodos Disponíveis

### Serviço Principal: `.Plan`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `CreatePlanAsync` | Cria um novo plano de recorrência. | `PmCreatePlanRequest` | `PmPlanResponse` |
| `GetPlanAsync` | Obtém os detalhes de um plano específico. | `planId` (string) | `PmPlanResponse` |
| `UpdatePlanAsync` | Atualiza dados básicos de um plano existente. | `planId`, `PmUpdatePlanRequest` | `PmPlanResponse` |
| `DeletePlanAsync` | Remove um plano (soft delete). | `planId` (string) | `PmPlanResponse` |
| `ListPlansAsync` | Lista planos com filtros de nome e status. | Filtros opcionais | `PmListPlansResponse` |
| `UpdatePlanMetadataAsync` | Atualiza apenas os metadados do plano. | `planId`, `Dictionary` | `PmPlanResponse` |

### Sub-serviço: `.Plan.Items`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `CreatePlanItemAsync` | Adiciona um item fixo a um plano. | `planId`, `PmCreatePlanItemRequest`| `PmPlanItemResponse` |
| `GetPlanItemAsync` | Obtém detalhes de um item do plano. | `planId`, `planItemId` | `PmPlanItemResponse` |
| `ListPlanItemsAsync` | Lista todos os itens de um plano. | `planId` (string) | `List<PmPlanItemResponse>` |
| `UpdatePlanItemAsync` | Edita regras de um item do plano. | `planId`, `planItemId`, `Request` | `PmPlanItemResponse` |
| `DeletePlanItemAsync` | Remove um item do plano. | `planId`, `planItemId` | `PmPlanItemResponse` |

---

## Exemplos de Uso

### 1. Criando um Plano Simples
Um plano pode ter um esquema de precificação global (`PricingScheme`) ou ser composto por múltiplos itens.

```csharp
using Berdsk.Sdk.PagarMe.V5.Helpers;
using Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos;

var planRequest = new PmCreatePlanRequest
{
    Name = "Plano Premium Mensal",
    Description = "Acesso total à plataforma",
    StatementDescriptor = "PREMIUM_CLUB",
    Interval = PmInterval.Month,
    IntervalCount = 1,
    PaymentMethods = new List<string> { PmPaymentMethod.CreditCard, PmPaymentMethod.Boleto },
    BillingType = PmBillingType.Prepaid,
    PricingScheme = new PmPricingSchemeRequest
    {
        Price = 9990 // R$ 99,90
    }
};

var plan = await client.Plan.CreatePlanAsync(planRequest);
```

### 2. Criando um Plano com Múltiplos Itens
Útil para planos que possuem taxas de adesão ou serviços adicionais fixos.

```csharp
var planRequest = new PmCreatePlanRequest
{
    Name = "Plano Business",
    Interval = PmInterval.Month,
    IntervalCount = 1,
    Items = new List<PmCreatePlanItemRequest>
    {
        new PmCreatePlanItemRequest
        {
            Name = "Mensalidade Base",
            Quantity = 1,
            PricingScheme = new PmPricingSchemeRequest { Price = 15000 }
        },
        new PmCreatePlanItemRequest
        {
            Name = "Taxa de Suporte",
            Quantity = 1,
            PricingScheme = new PmPricingSchemeRequest { Price = 2000 }
        }
    }
};

var plan = await client.Plan.CreatePlanAsync(planRequest);
```

### 3. Listando Planos com Filtros
Utilize os helpers para garantir que os filtros de status estejam corretos.

```csharp
using Berdsk.Sdk.PagarMe.V5.Helpers;

var plans = await client.Plan.ListPlansAsync(
    name: "Premium",
    status: PmPlanStatus.Active,
    page: 1,
    size: 10
);

foreach (var item in plans.Data)
{
    Console.WriteLine($"Plano: {item.Name} - ID: {item.Id}");
}
```

### 4. Gerenciando Itens de um Plano Existente
Você pode adicionar novos itens a um plano mesmo após sua criação.

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.Plan.Dtos;

var newItem = new PmCreatePlanItemRequest
{
    Name = "Add-on de Armazenamento",
    Description = "10GB extras",
    PricingScheme = new PmPricingSchemeRequest { Price = 1500 }
};

var planItem = await client.Plan.Items.CreatePlanItemAsync("plan_xxxxxxxxxxxx", newItem);
```

---

## Dicas para IAs ao utilizar .Plan:

1. **Plano vs Assinatura Avulsa:** Se o valor ou o intervalo muda para cada cliente, não crie um plano. Utilize a criação de assinatura avulsa (sem `PlanId`) no serviço `.Subscription`.
2. **Uso de Helpers:** Sempre utilize `PmInterval`, `PmBillingType`, `PmPaymentMethod` e `PmPlanStatus` para configurar e filtrar planos.
3. **Statement Descriptor:** Oriente o desenvolvedor que o nome na fatura do cartão (`StatementDescriptor`) tem limite de 13 caracteres na maioria das operadoras.
4. **Moeda:** O padrão é `BRL`. Caso precise de outras moedas, verifique a disponibilidade na documentação da PagarMe, mas o SDK já inicializa como "BRL".
5. **Trial Period:** Você pode definir `TrialPeriodDays` no plano. As assinaturas vinculadas a este plano herdarão esse período de teste gratuito automaticamente.
6. **Billing Type 'Exact Day':** Ao usar `PmBillingType.ExactDay`, é obrigatório informar a lista `BillingDays` (ex: `new List<int> { 5, 10, 15 }`) para definir as datas de vencimento permitidas.

---

[Anterior: Assinaturas](./05-subscription.md) | [Início](./00-comece-aqui.md) | [Próximo: Link de Pagamento](./07-payment-link.md)
