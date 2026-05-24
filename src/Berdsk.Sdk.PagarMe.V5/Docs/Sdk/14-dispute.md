---
tags: [disputas, chargeback, contestacao, risco]
---
# .Dispute: Gestão de Disputas e Chargebacks

O serviço `.Dispute` permite monitorar e consultar o status de chargebacks e disputas abertas por portadores de cartão. Ele é fundamental para que o lojista tome ciência de contestações de vendas e possa enviar evidências dentro do prazo legal para evitar perdas financeiras.

## Métodos Disponíveis

### Serviço Principal: `.Dispute`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `ListDisputesAsync` | Lista as disputas com filtros de data, status e bandeira. | Filtros avançados | `PmListDisputesResponse` |
| `GetDisputeAsync` | Obtém os detalhes completos de uma disputa específica. | `disputeId` (string) | `PmDisputeResponse` |

---

## Exemplos de Uso

### 1. Listando Disputas Pendentes de Resposta
Neste exemplo, filtramos disputas que aguardam uma ação do lojista (`waiting_merchant_response`).

- **DTO de Saída:** `PmListDisputesResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Helpers;

// Listar disputas que aguardam resposta do estabelecimento
var response = await client.Dispute.ListDisputesAsync(
    status: PmDisputeStatus.WaitingMerchantResponse,
    limit: 10
);

foreach (var dispute in response.Data)
{
    Console.WriteLine($"ID: {dispute.DisputeId} | Transação: {dispute.TransactionId}");
    Console.WriteLine($"Valor: {dispute.ChargebackAmount.Amount} {dispute.ChargebackAmount.Currency}");
    Console.WriteLine($"Prazo Limite: {dispute.ResponseDeadline}");
}
```

### 2. Obtendo Detalhes de uma Disputa e Histórico de Eventos
Permite visualizar o motivo do chargeback e toda a trilha de auditoria (eventos) da disputa.

- **DTO de Saída:** `PmDisputeResponse`

```csharp
var dispute = await client.Dispute.GetDisputeAsync("12345678"); // ID numérico como string

if (dispute != null)
{
    Console.WriteLine($"Status Atual: {dispute.Status}");
    Console.WriteLine($"Bandeira: {dispute.Network}");
    Console.WriteLine($"Motivo: {dispute.Reason.ReasonDescription} (Código: {dispute.Reason.ReasonCode})");

    Console.WriteLine("\nHistórico da Disputa:");
    foreach (var ev in dispute.Events)
    {
        Console.WriteLine($"- {ev.CreatedAt}: {ev.Status}");
    }
}
```

---

## Dicas para IAs ao utilizar .Dispute:

1. **IDs Numéricos:** Assim como em transferências, os IDs de disputa na API V5 são numéricos (tipo `long`). O SDK aceita `string` nos métodos para manter o padrão.
2. **Status da Disputa (PmDisputeStatus):** Utilize este helper para gerenciar o fluxo. Os status mais críticos são `waiting_merchant_response` (ação necessária) e `won` / `lost` (resultado final).
3. **Prazos (ResponseDeadline):** IAs devem sempre alertar o usuário sobre o campo `ResponseDeadline`. Perder este prazo significa a perda automática da disputa (chargeback irreversível).
4. **Fluxo de Leitura:** Note que no SDK atual, o serviço de disputas é focado em **consulta**. O envio de documentos de defesa (evidências) geralmente é realizado via Dashboard ou processos específicos de integração de arquivos, dependendo do modelo de operação.
5. **Webhooks:** Recomende ao usuário configurar webhooks para eventos de disputa (ex: `dispute.created`) para reagir rapidamente a novos chargebacks sem precisar fazer polling na API.

---

[Anterior: Liquidações](./13-settlement.md) | [Início](./00-comece-aqui.md) | [Próximo: Helpers](./15-helpers.md)
