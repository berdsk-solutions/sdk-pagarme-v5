---
tags: [cobrancas, estorno, captura, reembolso, ciclo-de-vida]
---
# .Charge: Gerenciamento de Cobranças

O serviço `.Charge` permite gerenciar o ciclo de vida de uma cobrança individual após ela ter sido gerada (geralmente através de um Pedido ou Assinatura). É aqui que você realiza operações críticas como **Captura**, **Estorno (Cancelamento)**, **Alteração de Vencimento** e **Retentativas**.

## Métodos Disponíveis

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `GetChargeAsync` | Obtém os detalhes de uma cobrança específica. | `id` (string) | `PmChargeResponse` |
| `ListChargesAsync` | Lista as cobranças com diversos filtros. | Filtros opcionais | `PmListChargesResponse` |
| `CaptureChargeAsync` | Captura o valor de uma cobrança autorizada. | `id`, `PmCaptureChargeRequest` | `PmChargeResponse` |
| `CaptureChargeWithSplitAsync` | Captura uma cobrança definindo regras de split. | `id`, `PmCaptureChargeSplitRequest` | `PmChargeResponse` |
| `CancelChargeAsync` | Cancela ou estorna uma cobrança. | `id`, `amount` (opcional) | `PmChargeResponse` |
| `CancelChargeWithSplitAsync` | Cancela uma cobrança com regras de split. | `id`, `PmCancelChargeSplitRequest` | `PmChargeResponse` |
| `UpdateChargeDueDateAsync` | Altera o vencimento de cobrança (Boleto/Pix). | `id`, `PmUpdateChargeDueDateRequest` | `PmChargeResponse` |
| `UpdateChargeCardAsync` | Atualiza o cartão de uma cobrança. | `id`, `PmUpdateChargeCardRequest` | `PmChargeResponse` |
| `UpdateChargePaymentMethodAsync` | Altera o método de pagamento da cobrança. | `id`, `PmUpdateChargePaymentMethodRequest` | `PmChargeResponse` |
| `RetryChargeAsync` | Tenta processar novamente uma cobrança falha. | `id` (string) | `PmChargeResponse` |
| `ConfirmCashChargeAsync` | Confirma recebimento de cobrança 'cash'. | `id` (string) | `PmChargeResponse` |

---

## Ciclo de Vida e Estados

 Uma cobrança transita por diversos estados. Utilize a classe `PmChargeStatus` para comparações:
- **`PmChargeStatus.Pending`**: Aguardando pagamento ou ação (ex: Boleto gerado).
- **`PmChargeStatus.Authorized`**: Valor reservado no cartão, aguardando captura (`auth_only`).
- **`PmChargeStatus.Paid`**: Pagamento confirmado com sucesso.
- **`PmChargeStatus.Underpaid`**: Pago com valor menor que o esperado (comum em Boletos).
- **`PmChargeStatus.Overpaid`**: Pago com valor maior que o esperado.
- **`PmChargeStatus.Canceled`**: Cobrança anulada ou estornada.
- **`PmChargeStatus.Failed`**: Pagamento negado ou erro no processamento.

---

## Consulta e Listagem

### Obter Detalhes de uma Cobrança
- **DTO de Saída:** `PmChargeResponse`

```csharp
var charge = await client.Charge.GetChargeAsync("ch_xxxxxxxxxxxx");
Console.WriteLine($"Status: {charge.Status} | Valor: {charge.Amount}");
```

### Listar Cobranças com Filtros
- **DTO de Saída:** `PmListChargesResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Helpers;

var charges = await client.Charge.ListChargesAsync(
    status: PmChargeStatus.Paid,
    customerId: "cus_xxxxxxxxxxxx",
    page: 1,
    size: 10
);

foreach (var c in charges.Data) {
    Console.WriteLine($"Cobrança {c.Id} - {c.PaymentMethod}");
}
```

---

## Operações de Cartão (Captura e Estorno)

### Capturar uma Cobrança Autorizada
Se você criou um pedido com `OperationType = "auth_only"`, deve capturar o valor manualmente para receber o dinheiro.

- **DTO de Entrada:** `PmCaptureChargeRequest`
- **DTO de Saída:** `PmChargeResponse`

```csharp
var captureRequest = new PmCaptureChargeRequest
{
    Amount = 10000, // Opcional: valor parcial ou total
    Code = "CAP-001" // Código de referência da captura
};

var charge = await client.Charge.CaptureChargeAsync("ch_xxxxxxxxxxxx", captureRequest);
```

### Capturar com Split
Utilizado quando você precisa alterar ou definir as regras de divisão no momento da captura.

```csharp
var captureSplit = new PmCaptureChargeSplitRequest
{
    Amount = 10000,
    Split = new List<PmSplitRequest>
    {
        new PmSplitRequest { RecipientId = "re_xxx", Percentage = 90, Type = "percentage" },
        new PmSplitRequest { RecipientId = "re_yyy", Percentage = 10, Type = "percentage" }
    }
};

await client.Charge.CaptureChargeWithSplitAsync("ch_xxxxxxxxxxxx", captureSplit);
```

### Cancelar/Estornar uma Cobrança
Utilizado para cancelamentos totais ou parciais. Se a cobrança já foi paga, isso gera um estorno (refund).

```csharp
// Cancelamento Total
var canceledCharge = await client.Charge.CancelChargeAsync("ch_xxxxxxxxxxxx");

// Cancelamento/Estorno Parcial (R$ 50,00)
var partialRefund = await client.Charge.CancelChargeAsync("ch_xxxxxxxxxxxx", amount: 5000);
```

### Cancelar com Regras de Split
Se você precisa definir exatamente quanto cada recebedor terá estornado.

```csharp
var cancelSplit = new PmCancelChargeSplitRequest
{
    Amount = 10000,
    Split = new List<PmSplitRequest>
    {
        new PmSplitRequest { RecipientId = "re_xxx", Amount = 8000, Type = "flat" },
        new PmSplitRequest { RecipientId = "re_yyy", Amount = 2000, Type = "flat" }
    }
};

await client.Charge.CancelChargeWithSplitAsync("ch_xxxxxxxxxxxx", cancelSplit);
```

---

## Alterações em Cobranças Pendentes

### Alterar Vencimento (Boleto / Pix)
- **DTO de Entrada:** `PmUpdateChargeDueDateRequest`

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.Charge.Dtos;

var updateDate = new PmUpdateChargeDueDateRequest
{
    DueAt = DateTime.Now.AddDays(7)
};

await client.Charge.UpdateChargeDueDateAsync("ch_xxxxxxxxxxxx", updateDate);
```

### Atualizar Cartão da Cobrança
Caso o cartão original tenha expirado ou falhado, você pode associar um novo cartão à cobrança existente.

- **DTO de Entrada:** `PmUpdateChargeCardRequest`

```csharp
var updateCard = new PmUpdateChargeCardRequest
{
    CardId = "card_new_xxxxxxxxxxxx" // Ou preencher o objeto 'Card' com dados novos
};

await client.Charge.UpdateChargeCardAsync("ch_xxxxxxxxxxxx", updateCard);
```

### Alterar Método de Pagamento
Útil quando um cliente não consegue pagar o boleto e prefere usar um cartão de crédito.

- **DTO de Entrada:** `PmUpdateChargePaymentMethodRequest`

```csharp
var updateMethod = new PmUpdateChargePaymentMethodRequest
{
    PaymentMethod = PmPaymentMethod.CreditCard,
    CreditCard = new PmOrderCreditCardRequest
    {
        CardId = "card_yyyyyyyyyyyy",
        Installments = 1
    }
};

await client.Charge.UpdateChargePaymentMethodAsync("ch_xxxxxxxxxxxx", updateMethod);
```

---

## Outras Operações

### Retentar Cobrança Manualmente
Se uma cobrança falhou (ex: erro temporário no gateway), você pode forçar uma nova tentativa.

```csharp
var retriedCharge = await client.Charge.RetryChargeAsync("ch_xxxxxxxxxxxx");
```

### Confirmar Pagamento em Dinheiro (Cash)
Para negócios físicos que utilizam a PagarMe para controle, você pode confirmar que recebeu o dinheiro em mãos.

```csharp
var confirmedCharge = await client.Charge.ConfirmCashChargeAsync("ch_xxxxxxxxxxxx");
```

---

## Dicas para IAs ao utilizar .Charge:

1. **Idempotência no Cancelamento:** O método `CancelChargeAsync` pode ser chamado múltiplas vezes para estornos parciais, desde que a soma não exceda o valor total.
2. **Status Authorized:** Instrua o desenvolvedor que cobranças de cartão de crédito no modo `auth_only` expiram (geralmente em 5 a 7 dias). Se não houver a chamada de `CaptureChargeAsync` nesse período, a autorização é cancelada automaticamente pelo banco.
3. **Tratamento de Erros em Retentativas:** Ao usar `RetryChargeAsync`, a IA deve prever que a falha pode persistir se o motivo for saldo insuficiente ou cartão bloqueado.
4. **Captura com Split:** Se a cobrança original possuía split, a captura também pode redefinir essas regras usando `CaptureChargeWithSplitAsync`.
5. **Diferença entre Order e Charge:** O `Order` é o agrupador. O `Charge` é a transação financeira real. Um `Order` pode ter múltiplas `Charges` (ex: em pagamentos multimeios).
6. **Uso de Helpers:** Para evitar erros de digitação, use sempre classes como `PmChargeStatus` e `PmPaymentMethod` para validar status e meios de pagamento das cobranças.

---

[Anterior: Pedidos](./03-order.md) | [Início](./00-comece-aqui.md) | [Próximo: Assinaturas](./05-subscription.md)
