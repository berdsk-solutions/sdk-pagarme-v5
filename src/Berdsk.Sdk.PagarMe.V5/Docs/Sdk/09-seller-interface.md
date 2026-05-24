---
tags: [transparencia, seller, recebiveis, contestacao, resolucao-264]
---
# .SellerInterface: Interface Eletrônica para Sellers

O serviço `.SellerInterface` é projetado para atender às normas da Resolução BCB nº 264 e 349, permitindo que Sellers e Marketplaces gerenciem suas Unidades de Recebíveis (URs), visualizem efeitos de contratos (como travas bancárias e cessões) e realizem contestações de registros.

## Métodos Disponíveis

### Serviço Principal: `.SellerInterface`

| Método | Descrição | DTO Entrada | DTO Saída |
| :--- | :--- | :--- | :--- |
| `ListReceivableUnitsAsync` | Retorna as Unidades de Recebíveis (URs) de um recebedor. | `recipientId`, `startDate`, `endDate` | `List<PmReceivableUnitResponse>` |
| `ListSettlementObligationsAsync` | Retorna os efeitos de contratos (obrigações de liquidação). | Filtros de data e paginação | `PmListSettlementObligationsResponse` |
| `ListContractsAsync` | Retorna os contratos (ônus e gravames) de um recebedor. | `recipientId`, datas | `List<PmContractResponse>` |
| `ListContestationsAsync` | Lista as contestações de contratos realizadas. | Filtros avançados | `PmListContestationsResponse` |
| `CreateContestationAsync` | Cria uma nova contestação de contrato. | `PmCreateContestationRequest` | `Task` (void) |

---

## Exemplos de Uso

### 1. Consultando Unidades de Recebíveis (URs)
As URs representam os direitos creditórios que o seller possui. Este método permite visualizar a agenda de recebíveis detalhada.

- **DTO de Saída:** `List<PmReceivableUnitResponse>`

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos;

string recipientId = "rp_xxxxxxxxxxxx";
DateTime start = DateTime.Now;
DateTime end = DateTime.Now.AddMonths(1);

var urs = await client.SellerInterface.ListReceivableUnitsAsync(recipientId, start, end);

foreach (var ur in urs)
{
    Console.WriteLine($"Data Pagamento: {ur.PaymentDate} | Valor Líquido: {ur.Amount}");
    Console.WriteLine($"Bandeira: {ur.CardBrand} | Método: {ur.PaymentMethod}");
}
```

### 2. Listando Obrigações de Liquidação (Efeitos de Contrato)
Utilizado para identificar se existem travas bancárias ou garantias aplicadas sobre os recebíveis do seller.

- **DTO de Saída:** `PmListSettlementObligationsResponse`

```csharp
var obligations = await client.SellerInterface.ListSettlementObligationsAsync(
    expectedSettlementDateSince: DateTime.Now,
    expectedSettlementDateUntil: DateTime.Now.AddDays(7),
    recipientId: "rp_xxxxxxxxxxxx"
);

foreach (var item in obligations.Data)
{
    Console.WriteLine($"Data: {item.ExpectedSettlementDate} | Titular: {item.OriginalAssetHolder}");
    foreach (var detail in item.SettlementObligations)
    {
        Console.WriteLine($" - Valor Efeito: {detail.EffectAmount} | Tipo: {detail.ContractType}");
    }
}
```

### 3. Visualizando Contratos de Seller
Retorna os contratos registrados que afetam a agenda de recebíveis.

- **DTO de Saída:** `List<PmContractResponse>`

```csharp
var contracts = await client.SellerInterface.ListContractsAsync(
    recipientId: "rp_xxxxxxxxxxxx",
    expectedSettlementDateSince: DateTime.Now,
    expectedSettlementDateUntil: DateTime.Now.AddMonths(3)
);

foreach (var contract in contracts)
{
    Console.WriteLine($"Chave: {contract.Key} | Tipo: {contract.ContractType}");
    Console.WriteLine($"Cancelado: {contract.IsCanceled} | Registradora: {contract.TradeRepository}");
}
```

### 4. Criando uma Contestação de Contrato
Permite que o seller conteste um registro de contrato que considere indevido.

- **DTO de Entrada:** `PmCreateContestationRequest`

```csharp
using Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos;

var request = new PmCreateContestationRequest
{
    ReasonCode = "1", // Exemplo: Valor divergente
    Author = new PmContestationAuthorRequest 
    { 
        Email = "financeiro@suaempresa.com",
        UserAgent = "SuaEmpresa Marketplace" 
    },
    OriginalAssetHolder = new PmContestationAssetHolderRequest 
    { 
        Name = "Seller XPTO",
        Document = "12345678000199" 
    },
    Contested = new PmContestationAssetHolderRequest 
    { 
        Name = "Banco ABC",
        Document = "98765432000100" 
    },
    Target = new PmContestationTargetRequest
    {
        Key = "ct_xxxxxxxxxxxx",
        Type = "Contract"
    }
};

await client.SellerInterface.CreateContestationAsync(request);
Console.WriteLine("Contestação enviada com sucesso.");
```

---

## Dicas para IAs ao utilizar .SellerInterface:

1. **Conformidade (Res. 264):** Este serviço é altamente regulado. Os dados retornados são essenciais para conciliação bancária em cenários de antecipação externa e travas.
2. **Unidades de Recebíveis (UR):** Uma UR é a combinação de `Arranjo de Pagamento` + `Instituição Domicílio` + `Data de Liquidação`.
3. **Efeitos de Contrato:** São as "travas". Se um seller tomou crédito em um banco usando seus recebíveis PagarMe como garantia, o contrato aparecerá aqui.
4. **ReasonCode na Contestação:** Os códigos de motivo são definidos pelas registradoras (ex: CERC, TAG). Certifique-se de usar o código correto conforme a documentação da registradora.
5. **Tipagem de Datas:** Note que os métodos de listagem utilizam `DateTime` nativo do C# para filtros, mas os DTOs de resposta podem retornar datas como `string`.
6. **Ausência de Helper de Status:** Diferente de outros serviços, os status aqui são frequentemente definidos pelas registradoras. Caso precise comparar status de contestação, prefira usar `PmDisputeStatus` se os valores forem compatíveis (ex: `opened`, `closed`).

---

[Anterior: Recebedores](./08-recipient.md) | [Início](./00-comece-aqui.md) | [Próximo: Webhooks](./10-webhook.md)
