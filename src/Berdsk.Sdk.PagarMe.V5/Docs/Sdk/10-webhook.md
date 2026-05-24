---
tags: [notificacoes, eventos, automacao, seguranca]
---
# .Webhook: Webhooks e Notificações

O serviço `.Webhook` permite que você gerencie o histórico de notificações enviadas pela PagarMe para os seus endpoints. Através dele, você pode consultar se um evento foi entregue com sucesso, verificar a resposta do seu servidor e solicitar o reenvio (retry) de notificações que falharam.

## Métodos Disponíveis

### Serviço Principal: `.Webhook`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `ListWebhooksAsync` | Lista o histórico de envios de webhooks. | Filtros (status, evento, data) | `PmListWebhooksResponse` |
| `GetWebhookAsync` | Obtém os detalhes de um envio específico. | `id` (string) | `PmWebhookResponse` |
| `RetryWebhookAsync` | Solicita o reenvio manual de um webhook. | `id` (string) | `object` (sucesso) |

---

## Exemplos de Uso

### 1. Listando Webhooks com Falha
Útil para monitorar se o seu servidor está perdendo notificações e entender o motivo.

- **DTO de Saída:** `PmListWebhooksResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Helpers;

// Listar webhooks que falharam no envio nas últimas 24 horas
var response = await client.Webhook.ListWebhooksAsync(
    status: PmWebhookDeliveryStatus.Failed,
    createdSince: DateTime.Now.AddDays(-1)
);

foreach (var hook in response.Data)
{
    Console.WriteLine($"ID: {hook.Id} | Evento: {hook.Event} | Tentativas: {hook.Attempts}");
    Console.WriteLine($"Última Resposta HTTP: {hook.ResponseStatus}");
}
```

### 2. Obtendo Detalhes e Resposta do Servidor
Permite ver exatamente o que o seu servidor respondeu (Body e Status Code) para uma notificação específica.

- **DTO de Saída:** `PmWebhookResponse`

```csharp
var hook = await client.Webhook.GetWebhookAsync("hk_xxxxxxxxxxxx");

Console.WriteLine($"URL de Destino: {hook.Url}");
Console.WriteLine($"Evento: {hook.Event}");
Console.WriteLine($"Resposta do seu Servidor: {hook.ResponseRaw}");
```

### 3. Solicitando Reenvio (Retry)
Se o seu servidor estava fora do ar ou corrigiu um erro, você pode pedir para a PagarMe enviar a notificação novamente.

```csharp
string webhookId = "hk_xxxxxxxxxxxx";

await client.Webhook.RetryWebhookAsync(webhookId);

Console.WriteLine("Solicitação de reenvio enviada com sucesso.");
```

---

## Dicas para IAs ao utilizar .Webhook:

1. **Hooks vs Webhooks:** Na PagarMe V5, o endpoint configurado no Dashboard é o "Hook". O registro de cada tentativa de envio de um evento para esse endpoint é o "Webhook".
2. **Idempotência:** Sempre utilize o ID do recurso (ex: `order.id` ou `charge.id`) dentro do `data` do webhook para garantir que você não processe a mesma transação duas vezes, caso receba o mesmo evento repetido.
3. **Segurança:** Recomenda-se validar se o webhook partiu realmente da PagarMe verificando o IP de origem ou utilizando chaves de autenticação customizadas no Header (se configurado no Hook).
4. **Eventos (PmWebhookEvents):** Utilize o helper `PmWebhookEvents` para comparar o tipo de evento recebido no seu endpoint.
    - Exemplo: `if (payload.Type == PmWebhookEvents.OrderPaid) { ... }`
5. **Status de Entrega (PmWebhookDeliveryStatus):** Utilize este helper para filtrar a listagem por `Sent`, `Failed` ou `Pending`.
6. **Payload Dinâmico:** O campo `Data` no `PmWebhookResponse` é um `object` porque seu conteúdo muda drasticamente dependendo do evento (pode ser um Customer, Order, Charge, etc.). Ao processar o webhook recebido no seu servidor, faça o cast para o DTO correspondente.

---

[Anterior: Seller Interface](./09-seller-interface.md) | [Início](./00-comece-aqui.md) | [Próximo: Consulta BIN](./11-card-bin.md)
