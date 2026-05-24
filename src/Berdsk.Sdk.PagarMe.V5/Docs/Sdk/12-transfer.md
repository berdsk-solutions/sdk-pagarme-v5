---
tags: [transferencias, saques, movimentacao-financeira, recebedores]
---
# .Transfer: Transferências e Saques

O serviço `.Transfer` é utilizado para movimentar o saldo disponível de um recebedor para sua conta bancária associada ou para realizar transferências entre recebedores. Ele gerencia o ciclo de vida do saque, desde a solicitação até a confirmação do depósito.

## Métodos Disponíveis

### Serviço Principal: `.Transfer`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `CreateTransferAsync` | Solicita uma nova transferência de saldo. | `PmCreateTransferRequest` | `PmTransferResponse` |
| `ListTransfersAsync` | Lista as transferências realizadas com filtros. | Filtros (recipient, id, data, etc) | `PmListTransfersResponse` |
| `GetTransferAsync` | Obtém detalhes de uma transferência específica. | `id` (string) | `PmTransferResponse` |
| `CancelTransferAsync` | Cancela uma transferência pendente. | `id` (string) | `PmTransferResponse` |
| `GetTransferReceiptAsync` | Obtém o comprovante de uma transferência realizada. | `id` (string) | `object` (Comprovante) |

---

## Exemplos de Uso

### 1. Criando uma Transferência (Saque)
Inicia um pedido de saque do saldo acumulado no Dashboard para a conta bancária do recebedor.

- **DTO de Entrada:** `PmCreateTransferRequest`
- **DTO de Saída:** `PmTransferResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.Transfers.Dtos;

var request = new PmCreateTransferRequest
{
    Amount = 50000, // R$ 500,00 (em centavos)
    RecipientId = "rp_xxxxxxxxxxxx", // ID do recebedor que deseja sacar
    Metadata = new Dictionary<string, string> 
    { 
        { "id_interno", "saque_001" } 
    }
};

var transfer = await client.Transfer.CreateTransferAsync(request);

Console.WriteLine($"Transferência Criada: {transfer.Id}");
Console.WriteLine($"Status: {transfer.Status}");
Console.WriteLine($"Data estimada de depósito: {transfer.FundingEstimatedDate}");
```

### 2. Listando Transferências com Filtros
Busca transferências específicas, por exemplo, de um recebedor ou por valor.

- **DTO de Saída:** `PmListTransfersResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Helpers;

var response = await client.Transfer.ListTransfersAsync(
    recipientId: "rp_xxxxxxxxxxxx",
    count: 10
);

foreach (var item in response.Data)
{
    Console.WriteLine($"ID: {item.Id} | Valor: {item.Amount} | Status: {item.Status}");
    
    if (item.Status == PmTransferStatus.Failed)
    {
        Console.WriteLine($"Erro do Banco: {item.BankResponse}");
    }
}
```

### 3. Cancelando uma Transferência Pendente
Se uma transferência ainda estiver no estado `pending`, ela pode ser cancelada.

```csharp
string transferId = "123456789"; // Note que IDs de transferência são long/string numérica

var canceledTransfer = await client.Transfer.CancelTransferAsync(transferId);

if (canceledTransfer.Status == PmTransferStatus.Canceled)
{
    Console.WriteLine("Saque cancelado com sucesso.");
}
```

### 4. Obtendo Comprovante
Para transferências com status `transferred`, você pode obter os dados do comprovante.

```csharp
var receipt = await client.Transfer.GetTransferReceiptAsync("123456789");

// O retorno é dinâmico (object) representando o JSON do comprovante bancário
Console.WriteLine(receipt.ToString());
```

---

## Dicas para IAs ao utilizar .Transfer:

1. **IDs Numéricos:** Diferente de `Orders` (or_) ou `Customers` (cus_), as transferências na API V5 frequentemente utilizam IDs numéricos puros (tipo `long`). O SDK aceita como `string` nos métodos de busca para manter a consistência.
2. **Status da Transferência (PmTransferStatus):** Utilize o helper para monitorar o ciclo de vida: `pending` -> `processing` -> `transferred` ou `failed`.
3. **Saldo Disponível:** Antes de criar uma transferência, lembre-se que o recebedor precisa ter saldo **disponível** (Available) suficiente. Saldo **a receber** (Waiting Funds) não pode ser sacado.
4. **Banco e Conta:** O destino da transferência é a conta bancária padrão configurada no `Recipient`. Se precisar alterar o destino, você deve atualizar o recebedor antes de solicitar a transferência.
5. **Idempotência:** O método `CreateTransferAsync` aceita uma `idempotencyKey`. Use-a para evitar transferências duplicadas em caso de retentativas de rede.

---

[Anterior: Consulta BIN](./11-card-bin.md) | [Início](./00-comece-aqui.md) | [Próximo: Liquidações](./13-settlement.md)
