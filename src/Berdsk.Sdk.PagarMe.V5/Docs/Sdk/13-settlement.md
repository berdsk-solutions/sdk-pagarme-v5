---
tags: [liquidacoes, extrato, conciliacao, marketplace]
---
# .Settlement: Liquidações e Extratos Financeiros

O serviço `.Settlement` permite consultar o extrato de liquidações financeiras da conta. Uma liquidação (Settlement) representa o pagamento efetivo de um valor para o recebedor, detalhando o produto, a bandeira e a data em que o valor foi (ou será) depositado.

## Métodos Disponíveis

### Serviço Principal: `.Settlement`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `ListSettlementsAsync` | Lista as liquidações globais com filtros avançados. | Filtros (data, arranjo, etc) | `PmListSettlementsResponse` |
| `ListRecipientSettlementsAsync` | Lista as liquidações de um recebedor específico. | `recipientId`, datas | `PmListSettlementsResponse` |
| `GetSettlementAsync` | Obtém os detalhes de uma liquidação específica. | `settlementId` (string) | `PmSettlementResponse` |

---

## Exemplos de Uso

### 1. Listando Liquidações de um Recebedor
Este exemplo mostra como buscar o extrato de pagamentos de um recebedor em um período específico.

- **DTO de Saída:** `PmListSettlementsResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.Settlements.Dtos;

string recipientId = "rp_xxxxxxxxxxxx";
string start = "2023-10-01";
string end = "2023-10-31";

var response = await client.Settlement.ListRecipientSettlementsAsync(recipientId, start, end);

foreach (var item in response.Data)
{
    Console.WriteLine($"ID: {item.Id} | Valor: {item.Amount} | Data: {item.PaymentDate}");
    Console.WriteLine($"Status: {item.Status} | Produto: {item.Product}");
}
```

### 2. Obtendo Detalhes de uma Liquidação
Permite ver informações técnicas da liquidação, como o arranjo de pagamento e o motor de liquidação utilizado.

- **DTO de Saída:** `PmSettlementResponse`

```csharp
var settlement = await client.Settlement.GetSettlementAsync("setl_xxxxxxxxxxxx");

if (settlement != null)
{
    Console.WriteLine($"ID: {settlement.Id}");
    Console.WriteLine($"Valor Líquido: {settlement.Amount}");
    Console.WriteLine($"Bandeira: {settlement.CardBrand}");
    Console.WriteLine($"Banco Destino: {settlement.TargetAccount.Bank}");
}
```

### 3. Listagem Global com Filtros
Busca liquidações em toda a conta, permitindo filtrar por `LiquidationArrangementId` (ID do arranjo).

```csharp
var response = await client.Settlement.ListSettlementsAsync(
    paymentDateStart: "2023-10-01",
    paymentDateEnd: "2023-10-31",
    limit: 50
);
```

---

## Dicas para IAs ao utilizar .Settlement:

1. **Datas como String:** Diferente de outros serviços que usam `DateTime`, os métodos de listagem de liquidação neste SDK aceitam as datas de início e fim como `string` (formato `yyyy-MM-dd`).
2. **Status de Liquidação (PmSettlementsStatus):** Utilize o helper para verificar o estado da liquidação: `PmSettlementsStatus.Success`, `PmSettlementsStatus.Pending` ou `PmSettlementsStatus.Failed`.
3. **Diferença de Recebedor:** Utilize `ListRecipientSettlementsAsync` quando quiser o extrato de um vendedor específico (Marketplace). Use `ListSettlementsAsync` para visão global da conta.
4. **TargetAccount:** O objeto `TargetAccount` dentro da resposta detalha para qual conta bancária aquele valor específico foi liquidado.
5. **IDs de Contrato:** As propriedades `ContractKey` e `ContractObligationId` ajudam a relacionar a liquidação com travas bancárias ou garantias (ônus e gravames) detalhadas no serviço `.SellerInterface`.

---

[Anterior: Transferências](./12-transfer.md) | [Início](./00-comece-aqui.md) | [Próximo: Disputas](./14-dispute.md)
