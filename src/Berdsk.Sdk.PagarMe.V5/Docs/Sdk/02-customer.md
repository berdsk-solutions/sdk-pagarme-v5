---
tags: [clientes, enderecos, cartoes, carteira, tokenizacao]
---
# Serviço de Clientes (.Customer)

O serviço `.Customer` permite gerenciar o ciclo de vida completo dos compradores na sua plataforma. Ele é fundamental para armazenar dados de faturamento, endereços de entrega e cartões para uso futuro (One-Click Buy ou Assinaturas).

## Métodos Disponíveis

### Serviço Principal: `.Customer`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `CreateCustomerAsync` | Cadastra um novo cliente na plataforma. | `PmCreateCustomerRequest` | `PmCustomerResponse` |
| `GetCustomerAsync` | Obtém os detalhes de um cliente específico. | `customerId` (string) | `PmCustomerResponse` |
| `UpdateCustomerAsync` | Atualiza dados básicos de um cliente. | `customerId`, `PmUpdateCustomerRequest` | `PmCustomerResponse` |
| `ListCustomersAsync` | Lista clientes com filtros de nome, email, documento, etc. | Filtros opcionais | `PmListCustomersResponse` |

### Sub-serviço: `.Customer.Addresses`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `ListAddressesAsync` | Lista todos os endereços de um cliente. | `customerId` (string) | `PmListAddressesResponse` |
| `CreateAddressAsync` | Adiciona um novo endereço ao cliente. | `customerId`, `PmCreateAddressRequest` | `PmAddressResponse` |
| `GetAddressAsync` | Obtém detalhes de um endereço específico. | `customerId`, `addressId` | `PmAddressResponse` |
| `UpdateAddressAsync` | Atualiza um endereço existente. | `customerId`, `addrId`, `PmUpdateAddressRequest` | `PmAddressResponse` |
| `DeleteAddressAsync` | Remove um endereço do cliente. | `customerId`, `addressId` | `PmAddressResponse` |

### Sub-serviço: `.Customer.Cards`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `ListCardsAsync` | Lista cartões salvos na carteira do cliente. | `customerId` (string) | `PmListCardsResponse` |
| `CreateCardAsync` | Salva um novo cartão (via Token ou dados brutos). | `customerId`, `PmCreateCardRequest` | `PmCardResponse` |
| `GetCardAsync` | Obtém detalhes de um cartão salvo. | `customerId`, `cardId` | `PmCardResponse` |
| `UpdateCardAsync` | Atualiza dados de um cartão. | `customerId`, `cardId`, `PmUpdateCardRequest` | `PmCardResponse` |
| `DeleteCardAsync` | Remove um cartão da carteira do cliente. | `customerId`, `cardId` | `PmCardResponse` |
| `RenewCardAsync` | Renova um cartão (Card Updater manual). | `customerId`, `cardId` | `PmCardResponse` |
| `CreateCardTokenAsync` | Gera um token seguro para um cartão. | `publicKey`, `PmCreateCardTokenRequest` | `PmCardTokenResponse` |

---

## Exemplos de Uso

## Fluxo Principal: Criar um Cliente

Permite cadastrar um novo cliente. Você pode enviar dados básicos ou um payload completo com endereço e telefones.

- **DTO de Entrada:** `PmCreateCustomerRequest`
- **DTO de Saída:** `PmCustomerResponse`

### Exemplo: Criação Completa (Recomendado para IAs)

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

var request = new PmCreateCustomerRequest
{
    Name = "Tony Stark",
    Email = "tony@starkindustries.com",
    Document = "12345678909",
    DocumentType = "CPF",
    Type = "individual", // individual ou company
    Gender = "male",
    Birthdate = "05/29/1970",
    Code = "USER-001", // Seu ID interno
    
    // Endereço (opcional na criação)
    Address = new PmCreateCustomerAddressRequest
    {
        Country = "BR",
        State = "NY",
        City = "New York",
        ZipCode = "12345678",
        Line1 = "10880, Malibu Point, California",
        Line2 = "Stark Mansion"
    },
    
    // Telefones (opcional na criação)
    Phones = new PmCreateCustomerPhonesRequest
    {
        MobilePhone = new PmCreateCustomerPhoneRequest
        {
            CountryCode = "55",
            AreaCode = "11",
            Number = "999999999"
        }
    },
    
    Metadata = new Dictionary<string, string>
    {
        { "ai_integration", "true" },
        { "priority", "high" }
    }
};

var customer = await client.Customer.CreateCustomerAsync(request);
Console.WriteLine($"Cliente criado com ID: {customer.Id}");
```

---

## Sub-Serviços: Endereços e Cartões

O serviço de clientes possui "sub-serviços" acessíveis via propriedades para gerenciar itens secundários do cliente.

### 1. Gerenciamento de Endereços (`.Customer.Addresses`)
Utilizado quando um cliente possui múltiplos endereços ou deseja atualizar o endereço padrão.

#### Listar Endereços
Recupera todos os endereços vinculados a um cliente.

- **DTO de Entrada:** `string customerId`
- **DTO de Saída:** `PmListAddressesResponse`

```csharp
var addresses = await client.Customer.Addresses.ListAddressesAsync("cus_xxx");
```

#### Criar Novo Endereço
Adiciona um novo endereço à lista do cliente.

- **DTO de Entrada:** `PmCreateAddressRequest`
- **DTO de Saída:** `PmAddressResponse`

```csharp
var addressRequest = new PmCreateAddressRequest 
{ 
    Line1 = "100, Rua das Flores, Centro",
    ZipCode = "01234567",
    City = "São Paulo",
    State = "SP",
    Country = "BR"
};
var newAddress = await client.Customer.Addresses.CreateAddressAsync("cus_xxx", addressRequest);
```

#### Outras Operações de Endereço
- **Obter:** `await client.Customer.Addresses.GetAddressAsync("cus_xxx", "addr_xxx")` (Saída: `PmAddressResponse`)
- **Atualizar:** `await client.Customer.Addresses.UpdateAddressAsync("cus_xxx", "addr_xxx", new PmUpdateAddressRequest { ... })` (Saída: `PmAddressResponse`)
- **Excluir:** `await client.Customer.Addresses.DeleteAddressAsync("cus_xxx", "addr_xxx")` (Saída: `PmAddressResponse`)

### 2. Carteira de Cartões (`.Customer.Cards`)
Permite salvar cartões de crédito para que o cliente não precise digitar os dados em todas as compras.

> [!WARNING]
> **PCI Compliance:** Trafegar dados sensíveis de cartões (número, CVV) pelo seu servidor backend exige certificação **PCI DSS**. Para evitar essa complexidade e garantir a segurança, o fluxo recomendado é gerar um **Token de Cartão** no seu frontend (usando PagarMe.js ou SDKs Mobile) e enviar apenas o token para o seu backend.

#### Exemplo: Criar cartão utilizando TOKEN (Recomendado)
Este é o método mais seguro, onde os dados sensíveis nunca tocam o seu servidor.

- **DTO de Entrada:** `PmCreateCardRequest`
- **DTO de Saída:** `PmCardResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos;

var cardRequest = new PmCreateCardRequest
{
    Token = "card_xxxxxxxxxxxxxxxx", // Token gerado no frontend (PagarMe.js)
    
    // Opcional: Você pode vincular um endereço de cobrança ao cartão
    BillingAddress = new PmCreateCustomerAddressRequest
    {
        Line1 = "10880, Malibu Point, California",
        ZipCode = "12345678",
        City = "New York",
        State = "NY",
        Country = "BR"
    }
};

var card = await client.Customer.Cards.CreateCardAsync("cus_xxx", cardRequest);
Console.WriteLine($"Cartão {card.LastFourDigits} salvo com sucesso!");
```

#### Exemplo: Criar cartão com dados brutos (Requer PCI Compliance)
Utilize este método **apenas** se sua infraestrutura possuir certificação PCI DSS.

- **DTO de Entrada:** `PmCreateCardRequest`
- **DTO de Saída:** `PmCardResponse`

```csharp
var card = await client.Customer.Cards.CreateCardAsync("cus_xxx", new PmCreateCardRequest
{
    Number = "1234123412341234",
    HolderName = "TONY STARK",
    ExpMonth = 12,
    ExpYear = 2030,
    Cvv = "123",
    BillingAddress = new PmCreateCustomerAddressRequest { ... }
});
```

#### Outras Operações de Cartão
- **Listar:** `await client.Customer.Cards.ListCardsAsync("cus_xxx")` (Saída: `PmListCardsResponse`)
- **Obter:** `await client.Customer.Cards.GetCardAsync("cus_xxx", "card_xxx")` (Saída: `PmCardResponse`)
- **Excluir:** `await client.Customer.Cards.DeleteCardAsync("cus_xxx", "card_xxx")` (Saída: `PmCardResponse`)

## Outras Operações de Cliente

### Obter Detalhes de um Cliente
Recupera todos os dados de um cliente específico pelo seu identificador único.

- **DTO de Entrada:** `string customerId`
- **DTO de Saída:** `PmCustomerResponse`

```csharp
var customer = await client.Customer.GetCustomerAsync("cus_xxxxxxxxxxxx");
Console.WriteLine($"Nome: {customer.Name} | Email: {customer.Email}");
```

### Atualizar um Cliente
Permite editar informações como nome, email e metadados.

- **DTO de Entrada:** `PmUpdateCustomerRequest`
- **DTO de Saída:** `PmCustomerResponse`

```csharp
var updateRequest = new PmUpdateCustomerRequest
{
    Name = "Tony Stark (Updated)",
    Email = "ironman@starkindustries.com",
    Metadata = new Dictionary<string, string> { { "updated_at", DateTime.Now.ToString() } }
};

var updatedCustomer = await client.Customer.UpdateCustomerAsync("cus_xxx", updateRequest);
```

### Listar Clientes (Busca com Filtros)
Permite buscar clientes cadastrados utilizando diversos critérios.

- **DTO de Entrada:** Parâmetros opcionais (`name`, `email`, `document`, etc.)
- **DTO de Saída:** `PmListCustomersResponse`

```csharp
// Busca por documento (CPF/CNPJ)
var customers = await client.Customer.ListCustomersAsync(document: "12345678909");

// Listagem paginada
var pagedResult = await client.Customer.ListCustomersAsync(page: 1, size: 10);

foreach (var item in pagedResult.Data)
{
    // Exemplo de uso de Helper para comparar status
    if (item.Status == PmCustomerStatus.Active)
    {
        Console.WriteLine($"- {item.Name} ({item.Id}) está Ativo");
    }
}
```

---

## Dicas para IAs ao utilizar .Customer:

1. **Persistência do ID:** Sempre armazene o `customer.Id` (ex: `cus_56v9Xq7IOfA8m1p2`) no seu banco de dados local. Ele será necessário para criar Pedidos ou Assinaturas vinculadas a este cliente.
2. **Documentação e Tipagem:** O campo `Type` aceita apenas `"individual"` ou `"company"`. Se for `"individual"`, o `Document` deve ser um CPF. Se `"company"`, um CNPJ.
3. **Padrão de Endereço:** O campo `Line1` na PagarMe v5 segue o padrão `Número, Rua, Bairro` separados por vírgula. IAs devem garantir que o input do usuário seja formatado corretamente antes de enviar.
4. **Sub-serviços vs Criação Direta:** Você pode criar endereços e telefones dentro do `PmCreateCustomerRequest`, mas Cartões (`Cards`) geralmente são criados separadamente após a criação do cliente ou através do fluxo de `Order`.
5. **Segurança e Tokens (PCI Compliance):** IAs devem sempre priorizar e sugerir o uso de `Token` para criação de cartões. O envio de dados brutos (`Number`, `Cvv`) no backend é uma prática de alto risco que exige certificação PCI DSS. Sempre valide se o token está sendo gerado no frontend.
6. **Uso de Helpers:** Utilize `PmCustomerStatus`, `PmCardStatus` e `PmAddressStatus` para comparar estados de retorno, evitando erros de digitação com strings manuais.
7. **BillingAddressId:** Na criação de cartões, você pode usar `BillingAddressId` para associar o cartão a um endereço que o cliente já possui cadastrado, em vez de enviar o objeto `BillingAddress` completo.

---

[Anterior: PagarMeClient](./01-pagarme-client.md) | [Início](./00-comece-aqui.md) | [Próximo: Pedidos](./03-order.md)
