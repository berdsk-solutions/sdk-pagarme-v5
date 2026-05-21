# Berdsk.Sdk.PagarMe.V5

<div align="center">
    <img src="Resources/berdsk-brand.png" alt="Berdsk" width="200"/>
    <br/>
    <img src="Resources/logo-pagarme.png" alt="PagarMe" width="300"/>
</div>

A **Berdsk.Sdk.PagarMe.V5** é uma biblioteca .NET não oficial, desenvolvida pela **Berdsk**, para facilitar a integração
com a API v5 da [Pagar.me](https://pagar.me/).

Este SDK fornece uma interface moderna, tipada e assíncrona para gerenciar pagamentos, clientes, assinaturas e muito
mais, seguindo as melhores práticas do ecossistema .NET.

---

## 🚀 Recursos

- 💳 **Pagamentos:** Suporte completo a Cartão de Crédito, Débito, Boleto e Pix.
- 👥 **Clientes & Endereços:** Gestão completa de base de clientes e seus endereços.
- 🔄 **Assinaturas:** Criação de planos e gestão de cobranças recorrentes.
- 🔗 **Links de Pagamento:** Geração de links para checkout rápido.
- 🎯 **Split de Pagamento:** Suporte a múltiplos recebedores.
- 💰 **Cobranças (Charges):** Gestão detalhada de cobranças, estornos e consultas.
- 🏦 **Recebedores (Recipients):** Criação e gestão de recebedores e antecipações.
- 💸 **Transferências:** Movimentação de saldo entre contas e recebedores.
- 📉 **Liquidações (Settlements):** Acompanhamento de depósitos e conciliação.
- ⚖️ **Disputas:** Gerenciamento de chargebacks e contestações.
- ⚓ **Webhooks:** Facilidade para processar notificações da API.
- 🛡️ **Tipagem Forte:** DTOs precisos para todas as requisições e respostas.
- ⚙️ **Interface do Vendedor:** Gestão de sub-contas e configurações de seller.

---

## 📦 Instalação

Instale o pacote via NuGet:

```bash
dotnet add package Berdsk.Sdk.PagarMe.V5
```

---

## 🛠️ Como Usar

### Inicializando o Cliente

O `PagarMeClient` centraliza todos os serviços da API. É recomendado utilizá-lo como Singleton ou via Injeção de
Dependência para reaproveitar o `HttpClient`.

```csharp
using Berdsk.Sdk.PagarMe.V5;

var client = new PagarMeClient(
    apiKey: "SUA_SECRET_KEY_AQUI",
    baseUrl: "https://api.pagar.me/core/v5/" // Utilize a URL de sandbox para testes
);
```

### Criando um Cliente

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

var customerRequest = new PmCreateCustomerRequest
{
    Name = "Thales Berdsk",
    Email = "contato@berdsk.com.br",
    Type = "individual",
    Document = "00000000000" // CPF ou CNPJ
};

var customer = await client.Customer.CreateCustomerAsync(customerRequest);
Console.WriteLine($"Cliente criado: {customer.Id}");
```

### Criando um Pedido (Pix)

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos;

var orderRequest = new PmCreateOrderRequest
{
    Code = "PEDIDO-001",
    Customer = new PmCreateCustomerRequest { /* ... dados do cliente ... */ },
    Items = new List<PmOrderItemRequest>
    {
        new() { Amount = 1000, Description = "Produto Teste", Quantity = 1 }
    },
    Payments = new List<PmOrderPaymentRequest>
    {
        new()
        {
            PaymentMethod = "pix",
            Pix = new PmOrderPixRequest { ExpiresIn = 3600 }
        }
    }
};

var order = await client.Order.CreateOrderAsync(orderRequest);
Console.WriteLine($"QR Code Pix: {order.Charges[0].LastTransaction.QrCode}");
```

### Gerenciando Assinaturas

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.Subscription.Dtos;

var subRequest = new PmCreateSubscriptionRequest
{
    Code = "SUB-001",
    PaymentMethod = "credit_card",
    Card = new PmCardRequest { /* ... dados do cartão ... */ },
    Customer = new PmCreateCustomerRequest { /* ... */ },
    PlanId = "plan_xxxxxxxxxxxxxxxx"
};

var subscription = await client.Subscription.CreateSubscriptionAsync(subRequest);
```

### Capturando uma Cobrança

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.Charge.Dtos;

var charge = await client.Charge.CaptureChargeAsync("ch_xxxxxxxxxxxxxxxx", new PmCaptureChargeRequest
{
    Amount = 1000 // Valor em centavos
});
```

### Listando Recebedores (Split)

```csharp
var recipients = await client.Recipient.ListRecipientsAsync(page: 1, size: 10);
```

---

## 🧰 Helpers de Status e Eventos

O SDK inclui classes estáticas auxiliares no namespace `Berdsk.Sdk.PagarMe.V5.Helpers` com **constantes tipadas** para
todos os valores de `status` e nomes de eventos de webhook utilizados pela API PagarMe v5. Use estas constantes em vez
de digitar as strings manualmente — assim você evita typos e ganha autocomplete + IntelliSense (com a documentação
oficial PagarMe linkada em cada propriedade).

Exemplo de uso:

```csharp
using Berdsk.Sdk.PagarMe.V5.Helpers;

if (charge.Status == PmChargeStatus.Paid)
{
    // cobrança paga
}

if (webhookEvent.Type == PmWebhookEvents.OrderPaid)
{
    // tratar evento de pedido pago
}
```

### Tabela de Helpers disponíveis

| Helper                        | Descrição                                                                                                                                               |
|-------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------|
| `PmWebhookEvents`             | Nomes de todos os eventos de webhook emitidos pela PagarMe (ex: `customer.created`, `order.paid`, `charge.paid`, `subscription.canceled` etc.).         |
| `PmBoletoStatus`              | Status de uma transação de **boleto** (ex: `generated`, `viewed`, `paid`, `voided`, `with_error`).                                                      |
| `PmCreditCardStatus`          | Status de uma transação de **cartão de crédito** (ex: `authorized_pending_capture`, `captured`, `refunded`, `voided`, `partial_capture`).               |
| `PmDebitCardStatus`           | Status de uma transação de **cartão de débito** (ex: `not_authorized`, `captured`, `refunded`, `failed`).                                               |
| `PmCashStatus`                | Status de uma transação em **dinheiro / cash** (`pending`, `paid`).                                                                                     |
| `PmPixStatus`                 | Status de uma transação **Pix** (ex: `waiting_payment`, `paid`, `refunded`, `with_error`).                                                              |
| `PmSafetyPayStatus`           | Status de uma transação **SafetyPay** (ex: `pending`, `paid`, `overpaid`, `underpaid`).                                                                 |
| `PmChargeStatus`              | Status de uma **cobrança (charge)** (`pending`, `paid`, `canceled`, `processing`, `failed`, `overpaid`, `underpaid`, `chargedback`).                    |
| `PmOrderStatus`               | Status de um **pedido (order)** (`pending`, `paid`, `canceled`, `failed`, `closed`).                                                                    |
| `PmPaymentLinkStatus`         | Status de um **Payment Link** (`active`, `canceled`, `building`).                                                                                       |
| `PmSubscriptionStatus`        | Status de uma **assinatura** (`active`, `canceled`, `future`).                                                                                          |
| `PmSubscriptionInvoiceStatus` | Status de uma **fatura de assinatura** (`pending`, `paid`, `canceled`, `scheduled`, `failed`).                                                          |
| `PmPlanStatus`                | Status de um **plano** ou item de plano (`active`, `inactive`, `deleted`).                                                                              |
| `PmCustomerStatus`            | Status de um **cliente** (`active`, `deleted`).                                                                                                         |
| `PmAddressStatus`             | Status de um **endereço** de cliente (`active`, `deleted`).                                                                                             |
| `PmCardStatus`                | Status de um **cartão salvo** do cliente (`active`, `deleted`, `expired`).                                                                              |
| `PmRecipientStatus`           | Status de um **recebedor (recipient)** (`registration`, `affiliation`, `active`, `refused`, `suspended`, `blocked`, `inactive`).                        |
| `PmBankAccountStatus`         | Status de uma **conta bancária** do recebedor (`active`, `inactive`, `deleted`).                                                                        |
| `PmTransferStatus`            | Status de uma **transferência** de saldo (`pending`, `processing`, `transferred`, `failed`, `canceled`).                                                |
| `PmAnticipationStatus`        | Status de uma **antecipação** de recebíveis (`pending`, `approved`, `refused`, `building`, `processing`, `success`, `failed`).                          |
| `PmBalanceOperationStatus`    | Status de uma **operação de saldo** (`waiting_funds`, `available`, `transferred`).                                                                      |
| `PmPayableStatus`             | Status de um **recebível (payable)** (`paid`, `waiting_funds`, `suspended`, `prepaid`).                                                                 |
| `PmSettlementsStatus`         | Status de uma **liquidação (settlement)** (`failed`, `success`, `pending`).                                                                             |
| `PmWebhookDeliveryStatus`     | Status de **entrega de um webhook** (`pending`, `sent`, `failed`).                                                                                      |
| `PmDisputeStatus`             | Status de uma **disputa / chargeback** (ex: `opened`, `waiting_merchant_response`, `under_analysis`, `accepted`, `contested`, `won`, `lost`, `closed`). |

> 💡 Cada helper traz, no seu XML doc, um link `<see href="...">Documentação Oficial PagarMe</see>` apontando para a
> referência oficial do recurso correspondente.

---

## 🧪 Testes de Integração

O projeto conta com uma suíte de testes de integração localizados em `tests/Berdsk.Sdk.PagarMe.V5.Tests.Integration`.

### Como executar os testes

1. **Configurar a Secret Key:**
   Os testes buscam a chave de API através de variáveis de ambiente.

   **No Windows (PowerShell):**
   ```powershell
   $env:PAGARME_SECRET_KEY = "SUA_SECRET_KEY_AQUI"
   ```

   **No Linux/macOS:**
   ```bash
   export PAGARME_SECRET_KEY="SUA_SECRET_KEY_AQUI"
   ```

2. **Executar:**
   ```bash
   dotnet test
   ```

---

## 🤝 Contribuição

Contribuições são muito bem-vindas! Para contribuir, siga estas diretrizes:

1. Faça um **Fork** do projeto.
2. Crie uma branch a partir da branch `develop` (ex: `git checkout -b feature/minha-nova-funcionalidade`).
3. Envie suas alterações via **Pull Request** para a branch `develop`.

Para reportar bugs, sugestões ou dúvidas, por favor utilize
as [Issues](https://github.com/berdsk/sdk-pagarme-v5/issues).

---

## ⚠️ Disclaimer & Status do Projeto

Este SDK está em desenvolvimento ativo.

- **Cobertura de Testes:** Embora os fluxos principais (Clientes, Pedidos, Pix, Cartão) estejam cobertos por testes de
  integração, algumas partes do SDK ainda carecem de validação automatizada completa.
- **Contribua:** Sinta-se à vontade para relatar problemas, sugerir melhorias ou enviar PRs para aumentar a cobertura de
  testes.
- **Uso em Produção:** Recomendamos realizar testes exaustivos em ambiente de Sandbox antes de utilizar em produção.

---

## 📄 Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).

---

## 🏢 Sobre a Berdsk

A **Berdsk** foca em criar soluções tecnológicas eficientes e SDKs de alta qualidade para o ecossistema .NET.

Visite nosso site: [berdsk.com.br](https://berdsk.com.br)

---

> **Aviso:** Esta é uma biblioteca independente e não possui vínculo oficial com a Pagar.me (Stone Co.). Todos os
> direitos da marca Pagar.me pertencem aos seus respectivos proprietários.