---
tags: [link-de-pagamento, checkout-pagarme, venda-rapida]
---
# .PaymentLink: Link de Pagamento

O serviço `.PaymentLink` permite gerar URLs seguras hospedadas pela PagarMe para que seus clientes realizem pagamentos sem que você precise implementar um checkout completo no seu site ou aplicativo. É a forma mais rápida de começar a vender, suportando Cartão de Crédito, Pix e Boleto.

## Métodos Disponíveis

### Serviço Principal: `.PaymentLink`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `CreatePaymentLinkAsync` | Cria um novo link de pagamento (Ordem ou Assinatura). | `PmCreatePaymentLinkRequest` | `PmPaymentLinkResponse` |
| `GetPaymentLinkAsync` | Obtém os detalhes de um link específico. | `id` (string) | `PmPaymentLinkResponse` |
| `ListPaymentLinksAsync` | Lista os links criados com filtros de status e paginação. | Filtros opcionais | `PmListPaymentLinksResponse` |
| `ActivatePaymentLinkAsync` | Ativa um link que foi criado com o status `building`. | `id` (string) | `PmPaymentLinkResponse` |
| `CancelPaymentLinkAsync` | Inativa/Cancela um link de pagamento ativo. | `id` (string) | `PmPaymentLinkResponse` |

---

## Exemplos de Uso

### 1. Criando um Link de Pagamento Simples
Este exemplo cria um link para venda de um produto ("Camiseta") aceitando Cartão de Crédito e Pix.

- **DTO de Entrada:** `PmCreatePaymentLinkRequest`
- **DTO de Saída:** `PmPaymentLinkResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos;
using Berdsk.Sdk.PagarMe.V5.Helpers;

var request = new PmCreatePaymentLinkRequest
{
    Name = "Venda Camiseta Oficial",
    OrderCode = "PED-12345",
    Type = "order", // Tipo 'order' para vendas únicas
    PaymentSettings = new PmPaymentLinkPaymentSettingsRequest
    {
        AcceptedPaymentMethods = new List<string> 
        { 
            PmPaymentMethod.CreditCard, 
            PmPaymentMethod.Pix 
        },
        CreditCardSettings = new PmPaymentLinkCreditCardSettingsRequest
        {
            InstallmentsSetup = new List<PmPaymentLinkInstallmentsSetupRequest>
            {
                new() { Installments = 1, Number = 1 }, // À vista
                new() { Installments = 2, Number = 2 }  // 2x
            }
        }
    },
    CartSettings = new PmPaymentLinkCartSettingsRequest
    {
        Items = new List<PmPaymentLinkItemRequest>
        {
            new()
            {
                Amount = 5000, // R$ 50,00
                Name = "Camiseta Preta G",
                DefaultQuantity = 1,
                Description = "Camiseta 100% Algodão"
            }
        }
    }
};

var paymentLink = await client.PaymentLink.CreatePaymentLinkAsync(request);

// A URL que você deve enviar ao cliente:
Console.WriteLine($"Link gerado: {paymentLink.Url}");
```

### 2. Listagem de Links com Filtro
Exemplo de como buscar todos os links que estão ativos.

- **DTO de Saída:** `PmListPaymentLinksResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Helpers;

var activeLinks = await client.PaymentLink.ListPaymentLinksAsync(
    status: PmPaymentLinkStatus.Active,
    page: 1,
    size: 10
);

foreach (var link in activeLinks.Data)
{
    Console.WriteLine($"ID: {link.Id} - Nome: {link.Name} - URL: {link.Url}");
}
```

### 3. Cancelando um Link
Se um produto esgotar ou a promoção acabar, você pode cancelar o link imediatamente.

- **DTO de Saída:** `PmPaymentLinkResponse`

```csharp
var canceledLink = await client.PaymentLink.CancelPaymentLinkAsync("pl_xxxxxxxxxxxxxxxx");

if (canceledLink.Status == PmPaymentLinkStatus.Canceled)
{
    Console.WriteLine("Link desativado com sucesso.");
}
```

---

## Dicas para IAs ao utilizar .PaymentLink:

1. **URL de Checkout:** O campo mais importante na resposta é o `paymentLink.Url`. É esta URL que deve ser redirecionada ou enviada ao cliente final.
2. **Ambiente de Sandbox:** A PagarMe utiliza um host diferente para links em Sandbox. Ao instanciar o `PagarMeClient`, você pode passar o `paymentLinkBaseUrl` (veja o guia 01-pagarme-client).
3. **Expiração:** Você pode controlar por quanto tempo o link fica disponível usando as propriedades `ExpiresAt` ou `ExpiresIn` (em minutos).
4. **Limitação de Uso:** Use `MaxSessions` para limitar quantas vezes o link pode ser acessado e `MaxPaidSessions` para limitar quantos pagamentos bem-sucedidos ele pode gerar (útil para estoques limitados).
5. **Tipos de Link:** Existem dois tipos principais (`Type`):
    - `order`: Para vendas de produtos/serviços únicos (usa `CartSettings.Items`).
    - `subscription`: Para criação de assinaturas recorrentes (usa `CartSettings.Recurrences`).
6. **Uso de Helpers:** Sempre utilize `PmPaymentLinkStatus` para comparar estados e `PmPaymentMethod` para definir os métodos aceitos, garantindo que as strings estejam corretas.

---

[Anterior: Planos](./06-plan.md) | [Início](./00-comece-aqui.md) | [Próximo: Recebedores](./08-recipient.md)
