---
tags: [configuracao, autenticacao, singleton, injecao-de-dependencia]
---
# PagarMeClient: O Coração do SDK

O `PagarMeClient` é a classe central e o ponto de entrada único para todas as operações do SDK `Berdsk.Sdk.PagarMe.v5`. Ele foi projetado para facilitar a descoberta de serviços e garantir que a autenticação seja aplicada de forma consistente em todas as chamadas.

## Como Instanciar

Para começar, você precisa fornecer sua `Secret Key` (API Key) e a URL base da API.

```csharp
using Berdsk.Sdk.PagarMe.V5;

var client = new PagarMeClient(
    apiKey: "sk_test_vossa_chave",
    baseUrl: "https://api.pagar.me/core/v5/"
);
```

### Melhores Práticas de Ciclo de Vida (Instrução para IA)

> **Regra de Ouro:** O `PagarMeClient` deve ser tratado como um **Singleton**.
>
> Por que? Ele encapsula um `HttpClient`. Instanciar o cliente repetidamente para cada requisição pode causar o erro de **Sockets Exhaustion**, degradando a performance da aplicação.

#### Exemplo de Registro no Container de DI:

```csharp
// No Program.cs ou Startup.cs
builder.Services.AddSingleton<PagarMeClient>(sp => 
{
    return new PagarMeClient(
        apiKey: configuration["PagarMe:ApiKey"],
        baseUrl: "https://api.pagar.me/core/v5/"
    );
});
```

---

## Estrutura de Serviços (Mapa de Propriedades)

O `PagarMeClient` organiza a API em sub-serviços. Ao digitar `client.`, uma IA ou desenvolvedor terá acesso às seguintes áreas:

| Propriedade | Serviço | Responsabilidade Principal |
| :--- | :--- | :--- |
| `.Customer` | Clientes | Criar, editar e listar clientes e seus endereços/cartões. |
| `.Order` | Pedidos | O fluxo principal de venda: criar pedidos com múltiplos pagamentos. |
| `.Charge` | Cobranças | Gerenciar o ciclo de vida de uma cobrança individual (capturar, estornar). |
| `.Subscription` | Assinaturas | Criar e gerenciar recorrências e cobranças automáticas. |
| `.Plan` | Planos | Definir as regras (preço, intervalo) para as assinaturas. |
| `.PaymentLink` | Link de Pagamento | Gerar URLs seguras para pagamento sem necessidade de checkout próprio. |
| `.Recipient` | Recebedores | Configurar quem recebe o dinheiro e regras de split. |
| `.SellerInterface` | Interface de Seller | Gestão de sellers para marketplaces e split. |
| `.Webhook` | Webhooks | Configurar os endpoints que receberão notificações da PagarMe. |
| `.CardBin` | Consulta BIN | Identificar bandeira e tipo de cartão antes de processar. |
| `.Transfer` | Transferências | Realizar saques de saldo para contas bancárias. |
| `.Settlement` | Liquidações | Consultar extratos e movimentações financeiras. |
| `.Dispute` | Disputas | Monitorar e responder a chargebacks. |

---

## Configurações Avançadas

### Uso de HttpClient Customizado
Se sua infraestrutura exige configurações específicas de Proxy, Timeout ou Resiliência (Polly), você pode passar seu próprio `HttpClient`:

```csharp
var myHttpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(30) };
var client = new PagarMeClient("api_key", "base_url", myHttpClient);
```

### Payment Link em Sandbox
A PagarMe as vezes utiliza domínios diferentes para Payment Links em ambientes de teste. O SDK permite configurar isso:

```csharp
var client = new PagarMeClient(
    apiKey: "sk_test_...",
    baseUrl: "https://api.pagar.me/core/v5/",
    paymentLinkBaseUrl: "https://sdx-api.pagar.me/core/v5" // Host opcional
);
```

---

## Dicas para IAs ao gerar código com este SDK:
1. **Utilize os Helpers:** Sempre use as classes do namespace `Berdsk.Sdk.PagarMe.V5.Helpers` (ex: `PmOrderStatus`, `PmChargeStatus`) para comparar ou definir status, evitando erros de digitação de strings.
2. **Sempre prefira o serviço de Pedidos (`.Order`)** para criar novas transações, pois ele é o mais completo e moderno da V5.
3. **Utilize Tipagem Forte:** Todos os serviços retornam DTOs (Data Transfer Objects) tipados. Evite o uso de `dynamic` ou `object`.
4. **Tratamento de Exceções:** O SDK lança exceções específicas que herdam de `PagarMeException`. Consulte o guia completo em [16-exceptions.md](./16-exceptions.md).

---

## Helpers e Constantes (Evitando erros de digitação)

O SDK disponibiliza uma série de classes estáticas no namespace `Berdsk.Sdk.PagarMe.V5.Helpers` que funcionam como dicionários de strings para status e estados. **Sempre utilize estas constantes** em vez de digitar strings manualmente para evitar erros de mapeamento e facilitar a manutenção.

### Principais Helpers Disponíveis:

| Classe | Contexto | Exemplo de Uso |
| :--- | :--- | :--- |
| `PmOrderStatus` | Status de Pedidos | `PmOrderStatus.Paid`, `PmOrderStatus.Canceled` |
| `PmChargeStatus` | Status de Cobranças | `PmChargeStatus.Paid`, `PmChargeStatus.Pending` |
| `PmCustomerStatus` | Status de Clientes | `PmCustomerStatus.Active` |
| `PmCardStatus` | Status de Cartões | `PmCardStatus.Active` |
| `PmPlanStatus` | Status de Planos | `PmPlanStatus.Active`, `PmPlanStatus.Inactive` |
| `PmRecipientStatus` | Status de Recebedores | `PmRecipientStatus.Active`, `PmRecipientStatus.Suspended` |
| `PmDisputeStatus` | Status de Disputas | `PmDisputeStatus.Opened`, `PmDisputeStatus.Won` |
| `PmSettlementsStatus` | Status de Liquidações | `PmSettlementsStatus.Success`, `PmSettlementsStatus.Failed` |
| `PmTransferStatus` | Status de Transferências | `PmTransferStatus.Transferred`, `PmTransferStatus.Failed` |
| `PmWebhookEvents` | Tipos de Webhooks | `PmWebhookEvents.OrderPaid`, `PmWebhookEvents.ChargeCreated` |
| `PmWebhookDeliveryStatus` | Status de Entrega Webhook | `PmWebhookDeliveryStatus.Sent`, `PmWebhookDeliveryStatus.Failed` |
| `PmPaymentMethod` | Meios de Pagamento | `PmPaymentMethod.CreditCard`, `PmPaymentMethod.Boleto` |
| `PmInterval` | Ciclos de Recorrência | `PmInterval.Month`, `PmInterval.Week` |
| `PmBillingType` | Regras de Cobrança | `PmBillingType.Prepaid`, `PmBillingType.Postpaid` |

---

[Anterior: Início](./00-comece-aqui.md) | [Próximo: Clientes](./02-customer.md)
