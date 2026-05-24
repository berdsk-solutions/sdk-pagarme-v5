# Berdsk.Sdk.PagarMe.V5

<div align="center">
    <img src="Resources/berdsk-brand.png" alt="Berdsk" width="200"/>
    <br/>
    <img src="Resources/logo-pagarme.png" alt="PagarMe" width="300"/>
</div>

A **Berdsk.Sdk.PagarMe.V5** é uma biblioteca .NET não oficial, desenvolvida pela **Berdsk**, para facilitar a integração
com a API v5 da [Pagar.me](https://pagar.me/).

Este SDK fornece uma interface moderna, tipada e assíncrona para gerenciar pagamentos, clientes, assinaturas e muito
mais, seguindo as melhores práticas do ecossistema .NET.

---

## 🚀 Recursos

- 💳 **Pagamentos:** Suporte completo a Cartão de Crédito, Débito, Boleto e Pix.
- 👥 **Clientes & Endereços:** Gestão completa de base de clientes e seus endereços.
- 🔄 **Assinaturas:** Criação de planos e gestão de cobranças recorrentes.
- 🔗 **Links de Pagamento:** Geração de links para checkout rápido.
- 🎯 **Split de Pagamento:** Suporte a múltiplos recebedores.
- 💰 **Cobranças (Charges):** Gestão detalhada de cobranças, estornos e consultas.
- 🏦 **Recebedores (Recipients):** Criação e gestão de recebedores e antecipações.
- 💸 **Transferências:** Movimentação de saldo entre contas e recebedores.
- 📉 **Liquidações (Settlements):** Acompanhamento de depósitos e conciliação.
- ⚖️ **Disputas:** Gerenciamento de chargebacks e contestações.
- ⚓ **Webhooks:** Facilidade para processar notificações da API.
- 🛡️ **Tipagem Forte:** DTOs precisos para todas as requisições e respostas.
- ⚙️ **Interface do Vendedor:** Gestão de sub-contas e configurações de seller.
- 🤖 **IA-Friendly:** Documentação otimizada para treinamento e uso com LLMs.

---

## 📚 Documentação (IA-Friendly)

O grande diferencial deste SDK é a sua **Jornada de Documentação Otimizada para IAs**. Criamos um conjunto de guias que ensinam não apenas "como usar", mas "como ensinar" IAs (como GitHub Copilot, ChatGPT, Claude e Cursor) a gerar o melhor código possível para o seu projeto.

### 🧭 Navegação Rápida
- **[00. Comece Aqui (O Ponto de Partida)](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/00-comece-aqui.md)**
- [01. Configuração do PagarMeClient](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/01-pagarme-client.md)
- [02. Clientes e Cartões](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/02-customer.md)
- [03. Pedidos e Pagamentos](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/03-order.md)
- [04. Gestão de Cobranças (Charges)](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/04-charge.md)
- [05. Assinaturas e Recorrência](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/05-subscription.md)
- [06. Gestão de Planos](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/06-plan.md)
- [07. Link de Pagamento](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/07-payment-link.md)
- [08. Recebedores (Recipients)](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/08-recipient.md)
- [09. Interface de Seller](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/09-seller-interface.md)
- [10. Webhooks e Notificações](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/10-webhook.md)
- [11. Consulta de BIN](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/11-card-bin.md)
- [12. Transferências e Saques](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/12-transfer.md)
- [13. Liquidações e Extratos](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/13-settlement.md)
- [14. Gestão de Disputas](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/14-dispute.md)
- [15. Helpers e Constantes](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/15-helpers.md)
- [16. Tratamento de Exceções](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/16-exceptions.md)

---

## 📦 Instalação

Instale o pacote via NuGet:

```bash
dotnet add package Berdsk.Sdk.PagarMe.V5
```

---

## 🛠️ Como Usar

Para um aprendizado profundo e exemplos detalhados de cada serviço, recomendamos a leitura do nosso **[Guia de Início Rápido](./src/Berdsk.Sdk.PagarMe.V5/Docs/Sdk/00-comece-aqui.md)**.

---

## 🧪 Testes de Integração

O projeto conta com uma suíte de testes de integração localizados em `tests/Berdsk.Sdk.PagarMe.V5.Tests.Integration`.

### Como executar os testes

1. **Configurar a Secret Key:**
   Os testes buscam a chave de API através de variáveis de ambiente.

   **No Windows (PowerShell):**
   ```powershell
   $env:PAGARME_SECRET_KEY = "SUA_SECRET_KEY_AQUI"
   ```

   **No Linux/macOS:**
   ```bash
   export PAGARME_SECRET_KEY="SUA_SECRET_KEY_AQUI"
   ```

2. **Executar:**
   ```bash
   dotnet test
   ```

---

## 🤝 Contribuição

Contribuições são muito bem-vindas! Para contribuir, siga estas diretrizes:

1. Faça um **Fork** do projeto.
2. Crie uma branch a partir da branch `develop` (ex: `git checkout -b feature/minha-nova-funcionalidade`).
3. Envie suas alterações via **Pull Request** para a branch `develop`.

Para reportar bugs, sugestões ou dúvidas, por favor utilize
as [Issues](https://github.com/berdsk/sdk-pagarme-v5/issues).

---

## ⚠️ Disclaimer & Status do Projeto

Este SDK está em desenvolvimento ativo.

- **Cobertura de Testes:** Embora os fluxos principais (Clientes, Pedidos, Pix, Cartão) estejam cobertos por testes de
  integração, algumas partes do SDK ainda carecem de validação automatizada completa.
- **Contribua:** Sinta-se à vontade para relatar problemas, sugerir melhorias ou enviar PRs para aumentar a cobertura de
  testes.
- **Uso em Produção:** Recomendamos realizar testes exaustivos em ambiente de Sandbox antes de utilizar em produção.

---

## 📄 Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).

---

## 🏢 Sobre a Berdsk

A **Berdsk** foca em criar soluções tecnológicas eficientes e SDKs de alta qualidade para o ecossistema .NET.

Visite nosso site: [berdsk.com.br](https://berdsk.com.br)

---

> **Aviso:** Esta é uma biblioteca independente e não possui vínculo oficial com a Pagar.me (Stone Co.). Todos os
> direitos da marca Pagar.me pertencem aos seus respectivos proprietários.