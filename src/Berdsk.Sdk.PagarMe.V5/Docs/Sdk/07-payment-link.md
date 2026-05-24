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

### 1. Criando um Link de Pagamento Completo
Este exemplo demonstra a criação de um link com configurações detalhadas para Cartão, Pix e Boleto, além de vincular um cliente existente.

- **DTO de Entrada:** `PmCreatePaymentLinkRequest`
- **DTO de Saída:** `PmPaymentLinkResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos;
using Berdsk.Sdk.PagarMe.V5.Helpers;

var request = new PmCreatePaymentLinkRequest
{
    Name = "Venda Curso de C# Avançado",
    OrderCode = "PED-998877",
    Type = "order",
    ExpiresIn = 120, // Expira em 120 minutos (2 horas)
    
    // Vincula a um cliente existente (opcional)
    CustomerSettings = new PmPaymentLinkCustomerSettingsRequest
    {
        CustomerId = "cus_xxxxxxxxxxxxxxxx"
    },

    PaymentSettings = new PmPaymentLinkPaymentSettingsRequest
    {
        AcceptedPaymentMethods = new List<string> 
        { 
            PmPaymentMethod.CreditCard, 
            PmPaymentMethod.Pix,
            PmPaymentMethod.Boleto
        },

        // Configurações de Cartão de Crédito
        CreditCardSettings = new PmPaymentLinkCreditCardSettingsRequest
        {
            OperationType = "auth_and_capture",
            InstallmentsSetup = new PmPaymentLinkInstallmentsSetupRequest
            {
                MaxInstallments = 12,      // Até 12x
                FreeInstallments = 2,     // 2 primeiras sem juros
                InterestRate = 1.5m,      // 1.5% de juros ao mês
                InterestType = "simple",  // Juros simples
                Amount = 1000             // Parcela mínima de R$ 10,00
            }
        },

        // Configurações de Pix
        PixSettings = new PmPaymentLinkPixSettingsRequest
        {
            ExpiresIn = 3600, // Pix expira em 1 hora após gerado
            AdditionalInformation = new List<PmPaymentLinkPixAdditionalInformationRequest>
            {
                new() { Name = "Produto", Value = "Curso C#" },
                new() { Name = "Unidade", Value = "Matriz" }
            }
        },

        // Configurações de Boleto
        BoletoSettings = new PmPaymentLinkBoletoSettingsRequest
        {
            Instructions = "Pagar até o vencimento. Não aceitar após 5 dias.",
            DueIn = 5,             // Vence em 5 dias
            Discount = 500,        // R$ 5,00 de desconto
            // DiscountPercentage = 5.0 // Ou 5% de desconto
        }
    },

    CartSettings = new PmPaymentLinkCartSettingsRequest
    {
        Items = new List<PmPaymentLinkItemRequest>
        {
            new()
            {
                Amount = 15000, // R$ 150,00
                Name = "Curso C# Avançado",
                DefaultQuantity = 1,
                Description = "Acesso vitalício ao curso"
            }
        }
    }
};

var paymentLink = await client.PaymentLink.CreatePaymentLinkAsync(request);
Console.WriteLine($"URL do Checkout: {paymentLink.Url}");
```

### 2. Listagem de Links com Filtro
Exemplo de como buscar todos os links que estão ativos.

```csharp
using Berdsk.Sdk.PagarMe.V5.Helpers;

var activeLinks = await client.PaymentLink.ListPaymentLinksAsync(
    status: PmPaymentLinkStatus.Active,
    page: 1,
    size: 10
);

foreach (var link in activeLinks.Data)
{
    Console.WriteLine($"ID: {link.Id} - URL: {link.Url}");
}
```

### 3. Cancelando um Link
Se um produto esgotar ou a promoção acabar, você pode cancelar o link imediatamente.

```csharp
var canceledLink = await client.PaymentLink.CancelPaymentLinkAsync("pl_xxxxxxxxxxxxxxxx");
Console.WriteLine($"Status atual: {canceledLink.Status}"); // Deve retornar 'canceled'
```

---

## Detalhamento das Configurações

### Pix Settings (`PixSettings`)
Permite customizar o tempo de vida do QR Code e adicionar campos de informação adicionais.

| Propriedade | Tipo | Descrição |
| :--- | :--- | :--- |
| `ExpiresIn` | `int?` | Prazo de vencimento em segundos para o QR Code gerado. |
| `AdditionalInformation` | `List` | Lista de chave/valor para informações extras no checkout Pix. |

### Boleto Settings (`BoletoSettings`)
Controla as regras de vencimento, instruções bancárias e descontos para pagamentos via boleto.

| Propriedade | Tipo | Descrição |
| :--- | :--- | :--- |
| `Instructions` | `string` | Instruções do boleto (Max 255 caracteres). |
| `DueIn` | `int?` | Dias para o vencimento a partir da geração do boleto. |
| `DueAt` | `string` | Data fixa de vencimento (ISO 8601). |
| `Discount` | `int?` | Valor fixo de desconto em centavos. |
| `DiscountPercentage` | `double?` | Valor de desconto em porcentagem. |

### Credit Card Settings (`CreditCardSettings`)
Define como o cartão será processado e quais as regras de parcelamento oferecidas no checkout.

| Propriedade | Tipo | Descrição |
| :--- | :--- | :--- |
| `OperationType` | `string` | `auth_and_capture` (padrão) ou `auth_only`. |
| `InstallmentsSetup` | `Object` | Objeto `PmPaymentLinkInstallmentsSetupRequest` para juros e parcelas. |

---

## Dicas para IAs ao utilizar .PaymentLink:

1. **URL de Checkout:** O campo mais importante na resposta é o `paymentLink.Url`. É esta URL que deve ser redirecionada ou enviada ao cliente final.
2. **Settings Mutuamente Exclusivos:** Em `BoletoSettings`, não envie `DueIn` e `DueAt` simultaneamente. O mesmo vale para `Discount` e `DiscountPercentage`.
3. **Expiração do Link vs. Expiração do Método:**
    - `ExpiresIn` no nível raiz é a expiração da **URL do Link** (em minutos).
    - `ExpiresIn` dentro de `PixSettings` é a expiração do **QR Code** (em segundos) após ser gerado.
4. **Parcelamento:** Ao configurar `InstallmentsSetup`, certifique-se de que o `Amount` (parcela mínima) não torne o parcelamento impossível para o valor total do carrinho.
5. **Checkout One-Click:** Se você passar um `CustomerId` em `CustomerSettings`, a PagarMe pode oferecer cartões salvos para o cliente, facilitando a conversão.
6. **Uso de Helpers:** Sempre utilize `PmPaymentLinkStatus` para comparar estados e `PmPaymentMethod` para definir os métodos aceitos.

---

[Anterior: Planos](./06-plan.md) | [Início](./00-comece-aqui.md) | [Próximo: Recebedores](./08-recipient.md)
