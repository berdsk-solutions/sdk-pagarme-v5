# Berdsk.Sdk.PagarMe.V5

<div align="center">
    <img src="Resources/berdsk-brand.png" alt="Berdsk" width="200"/>
    <br/>
    <img src="Resources/logo-pagarme.png" alt="PagarMe" width="300"/>
</div>

A **Berdsk.Sdk.PagarMe.V5** é uma biblioteca .NET não oficial, desenvolvida pela **Berdsk**, para facilitar a integração com a API v5 da [Pagar.me](https://pagar.me/).

Este SDK fornece uma interface moderna, tipada e assíncrona para gerenciar pagamentos, clientes, assinaturas e muito mais, seguindo as melhores práticas do ecossistema .NET.

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

O `PagarMeClient` centraliza todos os serviços da API. É recomendado utilizá-lo como Singleton ou via Injeção de Dependência para reaproveitar o `HttpClient`.

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

## 🧪 Testes de Integração

O projeto conta com uma suíte de testes de integração localizados em `tests/Berdsk.Sdk.PagarMe.V5.Tests.Integration`.

### Como executar os testes

1.  **Configurar a Secret Key:**
    Crie um arquivo `appsettings.test.json` na raiz do projeto de testes:
    ```json
    {
      "PagarMe": {
        "SecretKey": "sua_secret_key_aqui",
        "BaseUrl": "https://api.pagar.me/core/v5/"
      }
    }
    ```

2.  **Executar:**
    ```bash
    dotnet test
    ```

---

## 🤝 Contribuição

Contribuições são muito bem-vindas! Para contribuir, siga estas diretrizes:

1.  Faça um **Fork** do projeto.
2.  Crie uma branch a partir da branch `develop` (ex: `git checkout -b feature/minha-nova-funcionalidade`).
3.  Envie suas alterações via **Pull Request** para a branch `develop`.

Para reportar bugs, sugestões ou dúvidas, por favor utilize as [Issues](https://github.com/berdsk/sdk-pagarme-v5/issues).

---

## ⚠️ Disclaimer & Status do Projeto

Este SDK está em desenvolvimento ativo. 

- **Cobertura de Testes:** Embora os fluxos principais (Clientes, Pedidos, Pix, Cartão) estejam cobertos por testes de integração, algumas partes do SDK ainda carecem de validação automatizada completa.
- **Contribua:** Sinta-se à vontade para relatar problemas, sugerir melhorias ou enviar PRs para aumentar a cobertura de testes.
- **Uso em Produção:** Recomendamos realizar testes exaustivos em ambiente de Sandbox antes de utilizar em produção.

---

## 📄 Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).

---

## 🏢 Sobre a Berdsk

A **Berdsk** foca em criar soluções tecnológicas eficientes e SDKs de alta qualidade para o ecossistema .NET.

Visite nosso site: [berdsk.com.br](https://berdsk.com.br)

---

> **Aviso:** Esta é uma biblioteca independente e não possui vínculo oficial com a Pagar.me (Stone Co.). Todos os direitos da marca Pagar.me pertencem aos seus respectivos proprietários.