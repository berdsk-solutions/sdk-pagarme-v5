---
tags: [vendas, pagamentos, checkout, pix, boleto, cartao-de-credito, split]
---
# Serviço de Pedidos (.Order)

O serviço `.Order` é o motor principal de vendas do SDK `Berdsk.Sdk.PagarMe.v5`. Na PagarMe V5, um Pedido funciona como um contêiner que agrupa itens, dados do cliente e um ou mais métodos de pagamento. É através dele que você processa transações de Cartão de Crédito, Pix ou Boleto.

## Métodos Disponíveis

### Serviço Principal: `.Order`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `CreateOrderAsync` | Cria um pedido e processa os pagamentos. | `PmCreateOrderRequest` | `PmOrderResponse` |
| `GetOrderAsync` | Consulta o estado atual de um pedido. | `orderId` (string) | `PmOrderResponse` |
| `ListOrdersAsync` | Lista o histórico de pedidos com filtros. | Filtros opcionais | `PmListOrdersResponse` |
| `CloseOrderAsync` | Finaliza um pedido aberto. | `orderId` (string) | `PmOrderResponse` |
| `AddChargeAsync` | Adiciona uma cobrança a um pedido aberto. | `orderId`, `PmOrderPaymentRequest` | `PmOrderChargeResponse` |

### Sub-serviço: Itens do Pedido (`.Order.Items`)

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `CreateOrderItemAsync` | Adiciona um item a um pedido aberto. | `orderId`, `PmCreateOrderItemRequest` | `PmOrderItemResponse` |
| `GetOrderItemAsync` | Obtém detalhes de um item do pedido. | `orderId`, `itemId` | `PmOrderItemResponse` |
| `UpdateOrderItemAsync` | Atualiza um item em um pedido aberto. | `orderId`, `itemId`, `PmUpdateOrderItemRequest` | `PmOrderItemResponse` |
| `DeleteOrderItemAsync` | Remove um item de um pedido aberto. | `orderId`, `itemId` | `PmOrderItemResponse` |
| `DeleteAllOrderItemsAsync` | Remove todos os itens de um pedido aberto. | `orderId` (string) | `List<PmOrderItemResponse>` |

---

## Exemplos de Uso

## Formas de Pagamento

O SDK suporta múltiplos meios de pagamento. Para cada item na lista `Payments`, você deve especificar o `PaymentMethod` e preencher o objeto correspondente.

### 1. Cartão de Crédito

Ideal para pagamentos à vista ou parcelados.

- **DTO de Entrada:** `PmOrderCreditCardRequest`
- **DTO de Saída:** `PmOrderResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Helpers;
using Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos;

var orderRequest = new PmCreateOrderRequest
{
    Code = "PEDIDO-12345",
    Closed = true,
    Items = new List<PmOrderItemRequest> { /* ... */ },
    CustomerId = "cus_xxxxxxxxxxxx",
    Payments = new List<PmOrderPaymentRequest>
    {
        new PmOrderPaymentRequest
        {
            PaymentMethod = PmPaymentMethod.CreditCard,
            CreditCard = new PmOrderCreditCardRequest
            {
                Installments = 1,
                StatementDescriptor = "STARK_INDUSTRIES",
                CardId = "card_xxxxxxxxxxxx" // Ou CardToken / Card (dados brutos)
            }
        }
    }
};

var order = await client.Order.CreateOrderAsync(orderRequest);
```

#### Exemplo: Pagamento Parcelado

Para realizar uma venda parcelada, basta definir o número de parcelas desejado na propriedade `Installments`.

```csharp
var installmentOrderRequest = new PmCreateOrderRequest
{
    Code = "PEDIDO-PARCELADO-001",
    Items = new List<PmOrderItemRequest> 
    { 
        new PmOrderItemRequest { Amount = 12000, Description = "Produto Caro", Quantity = 1, Code = "P1" } 
    },
    CustomerId = "cus_xxxxxxxxxxxx",
    Payments = new List<PmOrderPaymentRequest>
    {
        new PmOrderPaymentRequest
        {
            PaymentMethod = PmPaymentMethod.CreditCard,
            CreditCard = new PmOrderCreditCardRequest
            {
                Installments = 10, // Parcelado em 10x de R$ 12,00
                StatementDescriptor = "MINHA_LOJA_PARC",
                CardId = "card_xxxxxxxxxxxx"
            }
        }
    }
};

var order = await client.Order.CreateOrderAsync(installmentOrderRequest);
```

### 2. Pix

Gera um QR Code e uma chave copia-e-cola para pagamento instantâneo.

- **DTO de Entrada:** `PmOrderPixRequest`
- **DTO de Saída:** `PmOrderChargeResponse` (ver `LastTransaction.QrCode`)

```csharp
var pixRequest = new PmCreateOrderRequest
{
    Code = "PEDIDO-PIX-99",
    Items = new List<PmOrderItemRequest> { /* ... */ },
    CustomerId = "cus_xxx",
    Payments = new List<PmOrderPaymentRequest>
    {
        new PmOrderPaymentRequest
        {
            PaymentMethod = PmPaymentMethod.Pix,
            Pix = new PmOrderPixRequest
            {
                ExpiresIn = 3600 // Expira em 1 hora
            }
        }
    }
};

var order = await client.Order.CreateOrderAsync(pixRequest);
var pixData = order.Charges.First().LastTransaction;
Console.WriteLine($"QR Code: {pixData.QrCode}");
```

### 3. Boleto

Gera um boleto bancário com suporte a juros, multa e descontos.

- **DTO de Entrada:** `PmOrderBoletoRequest`
- **DTO de Saída:** `PmOrderResponse`

```csharp
var boletoRequest = new PmCreateOrderRequest
{
    Code = "PEDIDO-BOL-456",
    CustomerId = "cus_xxx",
    Items = new List<PmOrderItemRequest> { /* ... */ },
    Payments = new List<PmOrderPaymentRequest>
    {
        new PmOrderPaymentRequest
        {
            PaymentMethod = PmPaymentMethod.Boleto,
            Boleto = new PmOrderBoletoRequest
            {
                Bank = "033", // Santander
                Instructions = "Não aceitar após o vencimento",
                DueAt = DateTime.Now.AddDays(5).ToString("yyyy-MM-dd"),
                Interest = new PmBoletoInterestRequest
                {
                    Type = "percentage",
                    Amount = 1.0m, // 1% de juros ao mês
                    Days = 1
                },
                Fine = new PmBoletoFineRequest
                {
                    Type = "flat",
                    Amount = 500, // R$ 5,00 de multa
                    Days = 1
                }
            }
        }
    }
};

var order = await client.Order.CreateOrderAsync(boletoRequest);
```

### 4. Cartão de Débito

Utilizado para pagamentos à vista com débito em conta.

- **DTO de Entrada:** `PmOrderDebitCardRequest`
- **DTO de Saída:** `PmOrderResponse`

```csharp
var debitRequest = new PmCreateOrderRequest
{
    Code = "PEDIDO-DEB-789",
    CustomerId = "cus_xxx",
    Items = new List<PmOrderItemRequest> { /* ... */ },
    Payments = new List<PmOrderPaymentRequest>
    {
        new PmOrderPaymentRequest
        {
            PaymentMethod = PmPaymentMethod.DebitCard,
            DebitCard = new PmOrderDebitCardRequest
            {
                StatementDescriptor = "MINHA_LOJA",
                CardId = "card_xxxxxxxxxxxx"
            }
        }
    }
};

var order = await client.Order.CreateOrderAsync(debitRequest);
```

---

## Pagamentos Multimeios

O SDK permite combinar diferentes formas de pagamento em um único pedido. Ao fazer isso, você deve obrigatoriamente informar o campo `Amount` em cada objeto de pagamento.

```csharp
var multiPaymentRequest = new PmCreateOrderRequest
{
    Code = "PEDIDO-MIX-001",
    Items = new List<PmOrderItemRequest> 
    { 
        new PmOrderItemRequest { Amount = 15000, Description = "Item Combo", Quantity = 1, Code = "C1" } 
    },
    CustomerId = "cus_xxx",
    Payments = new List<PmOrderPaymentRequest>
    {
        // R$ 100,00 no Cartão de Crédito
        new PmOrderPaymentRequest
        {
            PaymentMethod = PmPaymentMethod.CreditCard,
            Amount = 10000, 
            CreditCard = new PmOrderCreditCardRequest { CardId = "card_xxx", Installments = 1 }
        },
        // R$ 50,00 no Pix
        new PmOrderPaymentRequest
        {
            PaymentMethod = PmPaymentMethod.Pix,
            Amount = 5000,
            Pix = new PmOrderPixRequest { ExpiresIn = 3600 }
        }
    }
};

var order = await client.Order.CreateOrderAsync(multiPaymentRequest);
```

---

## Split de Pagamento

Você pode dividir o valor do pedido entre o marketplace e um ou mais recebedores (Sellers). O split é definido dentro de cada objeto de pagamento.

- **DTO de Entrada:** `List<PmSplitRequest>`
- **DTO de Saída:** `PmOrderResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.Common.Dtos;

var splitRequest = new PmCreateOrderRequest
{
    Items = new List<PmOrderItemRequest> { /* ... */ },
    CustomerId = "cus_xxx",
    Payments = new List<PmOrderPaymentRequest>
    {
        new PmOrderPaymentRequest
        {
            PaymentMethod = PmPaymentMethod.CreditCard,
            CreditCard = new PmOrderCreditCardRequest { /* ... */ },
            Split = new List<PmSplitRequest>
            {
                new PmSplitRequest
                {
                    Type = "percentage",
                    Percentage = 80, // 80% para o marketplace (recebedor padrão)
                    RecipientId = "re_xxxxxxxxxxxx" 
                },
                new PmSplitRequest
                {
                    Type = "percentage",
                    Percentage = 20, // 20% para o seller
                    RecipientId = "re_yyyyyyyyyyyy"
                }
            }
        }
    }
};
```

---

## Exemplos: Consultar e Listar Pedidos

- **DTO de Saída:** `PmOrderResponse` (Get) ou `PmListOrdersResponse` (List)

```csharp
// Obter um pedido por ID
var order = await client.Order.GetOrderAsync("or_xxxxxxxxxxxx");

// Listar pedidos com filtros
var orders = await client.Order.ListOrdersAsync(
    status: PmOrderStatus.Paid,
    page: 1,
    size: 10
);

foreach (var item in orders.Data)
{
    Console.WriteLine($"Pedido: {item.Code} | Status: {item.Status}");
}
```

#### Exemplo: Fechar Pedido e Adicionar Cobrança

Útil para pedidos criados com `Closed = false`.

```csharp
// Adicionar uma cobrança de Pix a um pedido aberto
var chargeRequest = new PmOrderPaymentRequest
{
    PaymentMethod = PmPaymentMethod.Pix,
    Amount = 5000,
    Pix = new PmOrderPixRequest { ExpiresIn = 3600 }
};

var charge = await client.Order.AddChargeAsync("or_xxxxxxxxxxxx", chargeRequest);

// Fechar o pedido definitivamente
var closedOrder = await client.Order.CloseOrderAsync("or_xxxxxxxxxxxx");
```

## Sub-Serviço: Itens do Pedido (`.Order.Items`)

Em cenários onde um pedido é criado "aberto" (`Closed = false`), você pode manipular os produtos individualmente antes de realizar o fechamento.

#### Exemplo: Manipulação de Itens

- **DTO de Entrada:** `PmCreateOrderItemRequest` / `PmUpdateOrderItemRequest`
- **DTO de Saída:** `PmOrderItemResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.OrderItem.Dtos;

var orderId = "or_xxxxxxxxxxxx";

// 1. Adicionar Item
var newItem = await client.Order.Items.CreateOrderItemAsync(orderId, new PmCreateOrderItemRequest
{
    Amount = 2500,
    Description = "Item Adicional",
    Quantity = 2,
    Category = "Acessórios"
});

// 2. Obter detalhes de um item
var itemDetails = await client.Order.Items.GetOrderItemAsync(orderId, newItem.Id);

// 3. Atualizar Item
var updatedItem = await client.Order.Items.UpdateOrderItemAsync(orderId, newItem.Id, new PmUpdateOrderItemRequest
{
    Amount = 2000, // Novo preço
    Quantity = 3   // Nova quantidade
});

// 4. Remover Item
await client.Order.Items.DeleteOrderItemAsync(orderId, updatedItem.Id);

// 5. Limpar todos os itens
await client.Order.Items.DeleteAllOrderItemsAsync(orderId);
```

---

## Dicas para IAs ao utilizar .Order:

1. **Centavos por Padrão:** O campo `Amount` em `PmOrderItemRequest` é sempre um inteiro representando centavos (ex: `150` = R$ 1,50). IAs devem alertar o usuário para nunca enviar valores decimais.
2. **Idempotência (Code):** Sempre utilize o campo `Code` para enviar o identificador do pedido do seu sistema local. Isso evita criações duplicadas em caso de falhas de rede.
3. **Verificação de Status:** Após `CreateOrderAsync`, o SDK retorna o objeto do pedido. IAs devem verificar se `order.Status` é `PmOrderStatus.Paid` ou `PmOrderStatus.Pending` antes de confirmar a entrega ao comprador.
4. **Múltiplos Pagamentos:** A PagarMe V5 permite enviar múltiplos objetos no array `Payments` (ex: pagar metade no Pix e metade no Cartão). O SDK suporta isso através da lista `Payments`.
5. **Captura Tardia:** Para cartões de crédito, você pode usar `OperationType = "auth_only"` se desejar apenas reservar o limite do cliente e capturar o dinheiro manualmente depois através do serviço `.Charge`.
6. **Soma dos Pagamentos:** Ao utilizar pagamentos multimeios, a soma dos campos `Amount` dentro da lista `Payments` deve obrigatoriamente ser igual ao valor total calculado para o pedido (soma dos itens).
7. **Configuração de Parcelas:** Ao oferecer parcelamento (`Installments > 1`), as IAs devem orientar o desenvolvedor a verificar as regras de juros e o número máximo de parcelas permitidas diretamente na Dashboard da PagarMe, pois o SDK apenas transmite o valor solicitado.
8. **Pedidos Abertos vs. Fechados:** Se `Closed = true` (padrão no `CreateOrderAsync`), o pagamento é tentado imediatamente. Se `Closed = false`, o pedido fica em estado aberto, permitindo a manipulação de itens via `.Order.Items` antes da tentativa de pagamento através de `AddChargeAsync` ou do fechamento via `CloseOrderAsync`.

9. **Uso de Helpers:** Sempre utilize classes como `PmOrderStatus` e `PmPaymentMethod` para filtrar ou comparar estados e meios de pagamento.
10. **BillingAddressId:** Assim como nas assinaturas, ao realizar pagamentos com Cartão que exigem endereço de cobrança, você pode usar `BillingAddressId` caso o cliente já possua o endereço salvo, evitando o reenvio dos dados.

---

[Anterior: Clientes](./02-customer.md) | [Início](./00-comece-aqui.md) | [Próximo: Cobranças](./04-charge.md)
