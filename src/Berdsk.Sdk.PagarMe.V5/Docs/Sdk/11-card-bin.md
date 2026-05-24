---
tags: [bin, validacao-de-cartao, seguranca, checkout]
---
# .CardBin: Consulta de BIN de Cartão

O serviço `.CardBin` permite consultar informações detalhadas sobre um cartão a partir dos seus primeiros 6 dígitos (BIN - Bank Identification Number). Essa funcionalidade é essencial para identificar a bandeira do cartão, validar o tamanho do CVV e aplicar máscaras de exibição no checkout antes mesmo de processar o pagamento.

## Métodos Disponíveis

### Serviço Principal: `.CardBin`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `GetBinAsync` | Obtém informações da bandeira e configurações do cartão. | `bin` (string) | `PmBinResponse` |

---

## Exemplos de Uso

### 1. Consultando informações de um Cartão
Este exemplo mostra como identificar a bandeira e o tamanho do CVV esperado para um cartão.

- **DTO de Saída:** `PmBinResponse`

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.CardBin.Dtos;

// Primeiros 6 dígitos do cartão
string bin = "411111";

var response = await client.CardBin.GetBinAsync(bin);

if (response != null)
{
    Console.WriteLine($"Bandeira: {response.BrandName}"); // Ex: Visa
    Console.WriteLine($"Código da Bandeira: {response.Brand}"); // Ex: visa
    Console.WriteLine($"Tamanho do CVV: {response.Cvv}"); // Ex: 3
    Console.WriteLine($"Máscara: {response.Mask}"); // Ex: #### #### #### ####
    
    Console.WriteLine("Comprimentos suportados:");
    foreach (var length in response.Lenghts)
    {
        Console.WriteLine($"- {length} dígitos");
    }
}
```

---

## Dicas para IAs ao utilizar .CardBin:

1. **Validação Antecipada:** Recomende o uso deste serviço no frontend (via backend) para ajustar a interface do usuário dinamicamente (ex: mostrar o ícone da bandeira correta) assim que o usuário digita os primeiros 6 dígitos.
2. **Segurança (PCI DSS):** Reforce que consultar o BIN não exige conformidade PCI DSS total, desde que apenas os 6 primeiros dígitos sejam trafegados. Nunca armazene ou trafegue o número completo do cartão sem as devidas certificações.
3. **Propriedade `Lenghts`:** Note que o DTO utiliza a grafia `Lenghts` (com 'h' antes do 't'), seguindo o padrão da API da PagarMe V5.
4. **Tratamento de Nulos:** O método `GetBinAsync` pode retornar `null` se o BIN não for encontrado ou for inválido. Sempre verifique a resposta antes de acessar as propriedades.
5. **Diferenciação de Bandeiras:** Utilize o campo `Brand` para lógica de programação (ex: `if (bin.Brand == "visa")`) e `BrandName` para exibição ao usuário final.

---

[Anterior: Webhooks](./10-webhook.md) | [Início](./00-comece-aqui.md) | [Próximo: Transferências](./12-transfer.md)
