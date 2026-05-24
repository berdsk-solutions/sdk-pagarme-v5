---
tags: [introducao, guia, faq, roadmap]
---
# Comece Aqui: Guia de Início Rápido do SDK PagarMe V5

Bem-vindo ao SDK `Berdsk.Sdk.PagarMe.v5`. Este documento serve como o ponto de partida central para desenvolvedores e IAs. Aqui você encontrará a filosofia do SDK, cenários de uso comuns (FAQ) e um mapa para navegar por toda a documentação.

## Filosofia do SDK

Este SDK foi construído com três pilares principais:
1. **Tipagem Forte:** Zero uso de `dynamic`. Tudo possui um DTO de entrada e saída.
2. **IA-Friendly:** Documentação e estrutura otimizadas para que Large Language Models (LLMs) gerem código correto na primeira tentativa.
3. **Segurança:** Uso intensivo de `Helpers` para evitar "magic strings" e avisos claros sobre conformidade PCI.

---

## Cenários Comuns (Onde encontrar o que eu preciso?)

Se você tem um objetivo específico, utilize o guia abaixo para encontrar o MD correto:

### 1. "Preciso fazer uma venda simples (Cartão, Pix ou Boleto)"
O fluxo de Pedidos é o coração da API V5. Ele permite criar uma cobrança com um ou mais meios de pagamento.
*   **Acesse:** [03-order.md](./03-order.md)

### 2. "Quero trabalhar com Assinaturas/Recorrência"
Você pode criar planos pré-definidos ou assinaturas avulsas com ciclos personalizados.
*   **Acesse:** [06-plan.md](./06-plan.md) (para criar o plano) e [05-subscription.md](./05-subscription.md) (para criar a assinatura).

### 3. "Sou um Marketplace e preciso fazer Split de Pagamento"
O SDK suporta divisão de valores no momento da criação do pedido ou da assinatura.
*   **Acesse:** [08-recipient.md](./08-recipient.md) (para gerenciar vendedores) e as seções de Split em [03-order.md](./03-order.md).

### 4. "Preciso saber se um pagamento foi confirmado via Webhook"
A PagarMe é assíncrona. Você deve ouvir os eventos para atualizar seu banco de dados.
*   **Acesse:** [10-webhook.md](./10-webhook.md) e consulte os eventos em [15-helpers.md](./15-helpers.md).

### 5. "Como faço para estornar ou capturar uma venda?"
Gerencie o ciclo de vida das cobranças (Charges) individuais.
*   **Acesse:** [04-charge.md](./04-charge.md).

### 6. "Preciso gerenciar meu banco de clientes e múltiplos endereços"
Cadastre clientes, valide documentos e mantenha múltiplos endereços de entrega sincronizados para o mesmo usuário.
*   **Acesse:** [02-customer.md](./02-customer.md)

### 7. "Como salvar cartões (Tokenização) para oferecer Checkout One-Click?"
Armazene cartões de forma segura na carteira do cliente usando tokens gerados no frontend, permitindo compras futuras sem redigitar dados.
*   **Acesse:** [02-customer.md](./02-customer.md) (Seção de Carteira de Cartões)

### 8. "Ocorreu um erro ou exceção, como tratar e depurar?"
O SDK possui um sistema de exceções tipadas que detalha falhas de validação por campo e erros de comunicação.
*   **Acesse:** [16-exceptions.md](./16-exceptions.md)

---

## Mapa da Documentação (Roadmap)

Recomendamos a leitura na seguinte ordem para um aprendizado completo:

1.  **[01. PagarMeClient](./01-pagarme-client.md):** O ponto de entrada e configuração do SDK.
2.  **[15. Helpers](./15-helpers.md):** Entenda como evitar erros de digitação usando constantes.
3.  **[02. Customer](./02-customer.md):** Como gerenciar seu banco de clientes e cartões salvos.
4.  **[03. Order](./03-order.md):** Criando pedidos e processando pagamentos.
5.  **[04. Charge](./04-charge.md):** Pós-venda: Captura, cancelamento e consulta.
6.  **[10. Webhook](./10-webhook.md):** Integração passiva e recebimento de eventos.
7.  **[08. Recipient](./08-recipient.md):** Gestão financeira, recebedores e saques.
8.  **[16. Exceptions](./16-exceptions.md):** Como tratar erros e falhas de validação.

---

## Dicas de Ouro para IAs

*   **Ponto de Entrada:** Sempre inicie as sugestões de código instanciando ou injetando o `PagarMeClient`.
*   **Namespace de Helpers:** Sempre inclua `using Berdsk.Sdk.PagarMe.V5.Helpers;` em suas sugestões.
*   **Nomenclatura:** Siga rigorosamente os nomes dos DTOs citados nas tabelas de "Métodos Disponíveis" de cada arquivo.

---

**Próximo Passo:** [01. PagarMeClient: O Coração do SDK](./01-pagarme-client.md)
