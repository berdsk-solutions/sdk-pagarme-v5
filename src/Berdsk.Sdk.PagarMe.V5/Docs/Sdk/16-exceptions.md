---
tags: [erros, excecoes, tratamento-de-erros, depuracao, validacao]
---
# Exceptions: Tratamento de Erros e Exceções

O SDK utiliza um sistema de exceções tipadas para facilitar a identificação e o tratamento de erros retornados pela API Pagar.me. Todas as exceções específicas herdam da classe base `PagarMeException`.

## Hierarquia de Exceções

| Exceção | Código HTTP | Causa Provável |
| :--- | :--- | :--- |
| `PmBadRequestException` | 400 | Requisição malformada ou erro de sintaxe. |
| `PmUnauthorizedException` | 401 | Chave de API inválida ou ausente. |
| `PmForbiddenException` | 403 | Sem permissão para acessar o recurso. |
| `PmNotFoundException` | 404 | Recurso (Pedido, Cliente, etc) não encontrado. |
| `PmPreconditionFailedException` | 412 | Erro em pré-condições (ex: idempotência). |
| `PmValidationException` | 422 | Erros de validação nos dados enviados. |
| `PmTooManyRequestsException` | 429 | Limite de requisições (Rate Limit) atingido. |
| `PmInternalServerErrorException` | 500 | Erro interno nos servidores da Pagar.me. |
| `PagarMeException` | Outros | Exceção genérica para códigos não mapeados. |

---

## Estrutura da Resposta de Erro (`PmErrorResponse`)

Ao capturar uma `PagarMeException`, você tem acesso a detalhes preciosos através da propriedade `ErrorResponse`:

- **`Message`**: Uma descrição textual do erro.
- **`Errors`**: Um dicionário (`Dictionary<string, string[]>`) contendo falhas específicas de campos (muito comum em `PmValidationException`).
- **`GatewayResponse`**: Detalhes técnicos caso o erro tenha ocorrido na comunicação com o banco ou adquirente.

---

## Exemplos de Uso

### 1. Tratamento Genérico de Erros
Ideal para logs e respostas rápidas ao usuário.

```csharp
using Berdsk.Sdk.PagarMe.V5.Exceptions;

try 
{
    var customer = await client.Customer.GetCustomerAsync("cus_invalid_id");
}
catch (PagarMeException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
    Console.WriteLine($"Status HTTP: {ex.StatusCode}");
    
    if (!string.IsNullOrEmpty(ex.RawBody))
    {
        Console.WriteLine($"Conteúdo Bruto: {ex.RawBody}");
    }
}
```

### 2. Tratamento Detalhado de Validação
Essencial para formulários e interfaces que precisam mostrar erros por campo.

```csharp
try
{
    var request = new PmCreateCustomerRequest { /* dados incompletos */ };
    await client.Customer.CreateCustomerAsync(request);
}
catch (PmValidationException ex)
{
    Console.WriteLine($"Falha de Validação: {ex.Message}");

    if (ex.ErrorResponse?.Errors != null)
    {
        foreach (var error in ex.ErrorResponse.Errors)
        {
            string field = error.Key;
            string[] messages = error.Value;
            Console.WriteLine($"Campo [{field}]: {string.Join(", ", messages)}");
        }
    }
}
```

### 3. Captura Específica por Código
Útil para fluxos de negócio que variam conforme o erro (ex: retentativas em 429 ou 500).

```csharp
try
{
    await client.Order.CreateOrderAsync(orderRequest);
}
catch (PmTooManyRequestsException)
{
    // Aguardar e tentar novamente
}
catch (PmValidationException ex)
{
    // Corrigir dados e avisar usuário
}
catch (PagarMeException ex)
{
    // Erro inesperado
}
```

---

## Dicas para IAs ao lidar com Exceptions:

1. **Sempre use Try-Catch:** Ao sugerir código de integração, envolva as chamadas de serviço em blocos `try-catch` usando `PagarMeException` ou exceções mais específicas.
2. **Exiba os Detalhes de Validação:** Em cenários de criação (`Create`), a IA deve mostrar como iterar sobre `ex.ErrorResponse.Errors` para ajudar o desenvolvedor a depurar o que falta no DTO.
3. **Idempotência e 412:** Alertar que erros 412 (`PmPreconditionFailedException`) geralmente ocorrem quando uma `idempotencyKey` é reutilizada com dados diferentes.
4. **Logs de RawBody:** Recomende o uso de `ex.RawBody` para logs de suporte, pois ele contém a resposta exata da API antes de qualquer processamento do SDK.
5. **Namespace:** Lembre-se do `using Berdsk.Sdk.PagarMe.V5.Exceptions;`.

---

[Anterior: Helpers](./15-helpers.md) | [Início](./00-comece-aqui.md)
