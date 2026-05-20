# Berdsk.Sdk.PagarMe.V5

SDK .NET para integração com a API Pagar.me v5.

## Testes de Integração

O projeto conta com uma suíte de testes de integração localizados em `tests/Berdsk.Sdk.PagarMe.V5.Tests.Integration`.

### Como executar os testes

1.  **Configurar a Secret Key:**
    Os testes buscam a chave de API através de um arquivo `appsettings.test.json`.
     
    **Via appsettings.test.json:**
    Crie o arquivo na raiz do projeto de testes:
    ```json
    {
      "PagarMe": {
        "SecretKey": "sua_secret_key_aqui",
        "BaseUrl": "https://api.pagar.me/core/v5/"
      }
    }
    ```

2.  **Executar os testes:**
    ```bash
    dotnet test
    ```

### Estrutura dos Testes
- **1:** Testes independentes (Clientes, Consulta de BIN).
- **2:** Testes com dependência de cliente (Endereços, Cartões).
- **3:** Testes transacionais (Pedidos, Cobranças).
- **Tratamento de Erros:** Validação de exceções customizadas (ex: `PmValidationException`).