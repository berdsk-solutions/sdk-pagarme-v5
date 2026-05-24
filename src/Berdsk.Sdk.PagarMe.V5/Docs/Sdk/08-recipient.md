---
tags: [marketplace, recebedores, split-de-pagamento, saldo, saques]
---
# .Recipient: Recebedores

O serviço `.Recipient` é fundamental para operações de Marketplace e Split de Pagamento. Ele permite gerenciar as entidades que receberão os valores das transações, suas contas bancárias, regras de transferência automática (saque) e antecipação de recebíveis.

## Métodos Disponíveis

### Serviço Principal: `.Recipient`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `CreateRecipientAsync` | Cria um novo recebedor. | `PmCreateRecipientRequest` | `PmRecipientResponse` |
| `GetRecipientAsync` | Obtém os detalhes de um recebedor. | `id` (string) | `PmRecipientResponse` |
| `ListRecipientsAsync` | Lista os recebedores da conta. | Filtros de paginação | `PmListRecipientsResponse` |
| `UpdateRecipientAsync` | Atualiza dados cadastrais do recebedor. | `PmUpdateRecipientRequest` | `PmRecipientResponse` |
| `UpdateRecipientCodeAsync` | Atualiza o código de referência externa. | `PmUpdateRecipientCodeRequest` | `PmRecipientResponse` |
| `CreateRecipientLinkAsync` | Cria um link para o recebedor preencher dados. | `PmCreateRecipientRequest` | `PmRecipientResponse` |

### Sub-serviços do Recebedor

#### Contas Bancárias (`.Recipient.BankAccounts`)
| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `UpdateBankAccountAsync` | Atualiza a conta bancária padrão. | `PmUpdateRecipientBankAccountRequest` | `PmRecipientResponse` |

#### Saldo e Extrato (`.Recipient.Balances` / `.Recipient.BalanceOperations`)
| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `GetBalanceAsync` | Consulta o saldo atual (disponível/esperado). | `recipientId` | `PmRecipientBalanceResponse` |
| `ListBalanceOperationsAsync` | Lista histórico de movimentações. | Filtros opcionais | `PmListBalanceOperationsResponse` |
| `GetBalanceOperationAsync` | Obtém detalhes de uma movimentação. | `id` (string) | `PmBalanceOperationResponse` |

#### Transferências/Saques (`.Recipient.Transfers`)
| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `UpdateTransferSettingsAsync` | Altera regras de saque automático. | `PmUpdateTransferSettingsRequest` | `PmRecipientResponse` |

#### Antecipações (`.Recipient.Anticipations`)
| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `CreateAnticipationAsync` | Solicita uma antecipação de recebíveis. | `PmCreateAnticipationRequest` | `PmAnticipationResponse` |
| `SimulateAnticipationAsync` | Simula taxas e valores de antecipação. | `PmSimulateAnticipationRequest` | `PmAnticipationSimulationResponse` |
| `GetAnticipationLimitsAsync` | Consulta limites disponíveis para antecipar. | Filtros de data | `PmAnticipationLimitsResponse` |
| `ListAnticipationsAsync` | Lista solicitações de antecipação. | Filtros opcionais | `List<PmAnticipationResponse>` |
| `CancelAnticipationAsync` | Cancela uma antecipação pendente. | `id` (string) | `PmAnticipationResponse` |
| `UpdateAutomaticAnticipationSettingsAsync` | Configura antecipação automática. | `PmUpdateAutomaticAnticipationSettingsRequest` | `PmAnticipationSettingsResponse` |

#### Recebíveis e Liquidações (`.Recipient.Payables` / `.Recipient.Settlements`)
| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `ListPayablesAsync` | Lista os futuros recebíveis do recebedor. | Filtros avançados | `PmListPayablesResponse` |
| `ListSettlementsAsync` | Lista liquidações (pagamentos efetuados). | Filtros de data | `PmListSettlementsResponse` |
| `GetSettlementAsync` | Obtém detalhes de uma liquidação específica. | `id` (string) | `PmSettlementResponse` |

---

## Exemplos de Uso

### 1. Criando um Recebedor (Marketplace)
Exemplo de cadastro de um recebedor pessoa física com conta bancária e regras de transferência.

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos;
using Berdsk.Sdk.PagarMe.V5.Helpers;

var request = new PmCreateRecipientRequest
{
    Name = "João Silva Mercearia",
    Email = "joao@email.com",
    Description = "Vendedor de Alimentos",
    Document = "12345678909",
    Type = "individual", // individual ou corporation
    DefaultBankAccount = new PmCreateBankAccountRequest
    {
        HolderName = "João Silva",
        HolderDocument = "12345678909",
        HolderType = "individual",
        Bank = "341", // Itaú
        BranchNumber = "1234",
        BranchCheckDigit = "5",
        AccountNumber = "12345",
        AccountCheckDigit = "6",
        Type = "checking" // checking ou savings
    },
    TransferSettings = new PmTransferSettingsRequest
    {
        TransferEnabled = true,
        TransferInterval = "daily", // daily, weekly, monthly
    }
};

var recipient = await client.Recipient.CreateRecipientAsync(request);
Console.WriteLine($"Recebedor criado: {recipient.Id} Status: {recipient.Status}");
```

### 2. Consultando Saldo de um Recebedor
Útil para exibir ao vendedor quanto ele tem disponível para saque.

```csharp
var balance = await client.Recipient.Balances.GetBalanceAsync("rp_xxxxxxxxxxxx");

Console.WriteLine($"Disponível: {balance.AvailableAmount}");
Console.WriteLine($"A receber (esperado): {balance.WaitingFundsAmount}");
Console.WriteLine($"Transferido: {balance.TransferredAmount}");
```

### 3. Atualizando Conta Bancária
Sempre que o recebedor desejar alterar onde recebe os valores.

```csharp
var updateBankRequest = new PmUpdateRecipientBankAccountRequest
{
    BankAccount = new PmCreateBankAccountRequest
    {
        Bank = "001", // Banco do Brasil
        BranchNumber = "9999",
        AccountNumber = "88888",
        AccountCheckDigit = "1",
        HolderName = "João Silva",
        HolderDocument = "12345678909",
        HolderType = "individual",
        Type = "checking"
    }
};

var updatedRecipient = await client.Recipient.BankAccounts.UpdateBankAccountAsync(
    "rp_xxxxxxxxxxxx", 
    updateBankRequest
);
```

### 4. Listagem de Recebedores (Filtros)
Exemplo de como buscar recebedores específicos usando filtros de paginação e status.

- **DTO de Saída:** `PmListRecipientsResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Helpers;

var response = await client.Recipient.ListRecipientsAsync(
    page: 1,
    size: 10
);

foreach (var recipient in response.Data)
{
    Console.WriteLine($"ID: {recipient.Id} | Nome: {recipient.Name} | Status: {recipient.Status}");
}
```

### 5. Extrato de Movimentações (Balance Operations)
Consulte o histórico de entradas e saídas do saldo do recebedor.

- **DTO de Saída:** `PmListBalanceOperationsResponse`

```csharp
var operations = await client.Recipient.BalanceOperations.ListBalanceOperationsAsync(
    recipientId: "rp_xxxxxxxxxxxx",
    page: 1,
    size: 20
);

foreach (var op in operations.Data)
{
    Console.WriteLine($"Data: {op.CreatedAt} | Tipo: {op.Type} | Valor: {op.Amount}");
}
```

### 6. Antecipação de Recebíveis (Simulação e Solicitação)
Fluxo completo para antecipar valores que seriam pagos no futuro.

- **DTOs Entrada:** `PmSimulateAnticipationRequest` e `PmCreateAnticipationRequest`

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.RecipientAnticipationService.Dtos;

string recipientId = "rp_xxxxxxxxxxxx";

// 1. Simular Antecipação
var simRequest = new PmSimulateAnticipationRequest
{
    RequestedAmount = 100000, // R$ 1.000,00
    PaymentDate = DateTime.Now.AddDays(1),
    Timeframe = "start" // start ou end
};

var simulation = await client.Recipient.Anticipations.SimulateAnticipationAsync(recipientId, simRequest);
Console.WriteLine($"Valor Líquido Simulado: {simulation.Amount}");

// 2. Solicitar Antecipação (se a simulação for satisfatória)
var createRequest = new PmCreateAnticipationRequest
{
    RequestedAmount = 100000,
    PaymentDate = DateTime.Now.AddDays(1),
    Timeframe = "start",
    AutomaticTransfer = true
};

var anticipation = await client.Recipient.Anticipations.CreateAnticipationAsync(recipientId, createRequest);
Console.WriteLine($"Antecipação Criada: {anticipation.Id} Status: {anticipation.Status}");
```

### 7. Gestão de Recebíveis (Payables)
Veja detalhadamente os valores que o recebedor tem a receber por transação.

- **DTO de Saída:** `PmListPayablesResponse`

```csharp
var payables = await client.Recipient.Payables.ListPayablesAsync(
    recipientId: "rp_xxxxxxxxxxxx",
    status: "paid", // paid, pending, waiting_funds, etc.
    page: 1,
    size: 50
);

foreach (var item in payables.Data)
{
    Console.WriteLine($"Vencimento: {item.PaymentDate} | Valor: {item.Amount} | Status: {item.Status}");
}
```

### 8. Configuração de Saque Automático
Altera se o dinheiro deve cair na conta bancária automaticamente ou ficar acumulado.

- **DTO de Entrada:** `PmUpdateTransferSettingsRequest`

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.RecipientTransfer.Dtos;

var settingsRequest = new PmUpdateTransferSettingsRequest
{
    TransferEnabled = true,
    TransferInterval = "weekly", // daily, weekly, monthly
    TransferDay = 5 // Quinta-feira (se semanal) ou Dia 5 (se mensal)
};

var recipient = await client.Recipient.Transfers.UpdateTransferSettingsAsync(
    "rp_xxxxxxxxxxxx", 
    settingsRequest
);
```

### 9. Criando Link de Auto-credenciamento (Self-boarding)
Gere um link para que o seu vendedor/recebedor preencha os próprios dados bancários e documentos com segurança.

- **DTO de Saída:** `PmRecipientResponse` (conterá o `RegisterInformationUrl`)

```csharp
var request = new PmCreateRecipientRequest
{
    Name = "Nova Loja Parceira",
    Email = "parceiro@email.com",
    Type = "individual"
};

var response = await client.Recipient.CreateRecipientLinkAsync(request);

// Envie esta URL para o parceiro completar o cadastro
Console.WriteLine($"URL de Cadastro: {response.RegisterInformationUrl}");
```

---

## Dicas para IAs ao utilizar .Recipient:

1. **Split de Pagamento:** Para usar split, você precisa primeiro do `recipient.Id`. Informe este ID no objeto `Split` ao criar um Pedido ou Cobrança.
2. **Ciclo de Vida do Saldo:**
    - `waiting_funds`: Valores de vendas recentes que ainda não atingiram o prazo de liquidação (D+X).
    - `available`: Valores prontos para serem transferidos para a conta bancária.
3. **Antecipação:** Nem todos os recebedores têm permissão para antecipar. Use `GetAnticipationLimitsAsync` para verificar se há valor disponível antes de tentar criar uma antecipação.
4. **Transferências:** Se `TransferEnabled` for `false`, o saldo ficará acumulado na conta PagarMe até que seja habilitado ou solicitado manualmente.
5. **IDs de Referência:** Use o campo `Code` (via `UpdateRecipientCodeAsync`) para atrelar o ID do vendedor no seu sistema ao ID da PagarMe, facilitando a conciliação.
6. **Helpers:** Utilize `PmRecipientStatus` para verificar se o recebedor está `Active`, `Registration`, `Affiliation` ou `Suspended`.

---

[Anterior: Link de Pagamento](./07-payment-link.md) | [Início](./00-comece-aqui.md) | [Próximo: Seller Interface](./09-seller-interface.md)
