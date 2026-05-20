# Retornando URs de um Recebedor

<br />

Na ResoluÃ§Ã£o 264, o Banco Central do Brasil deu origem a Unidade de RecebÃ­veis.

Podemos dizer que a Unidade de RecebÃ­veis Ã© um ativo financeiro, criado a partir do registro em uma Entidade
Registradora e que Ã© composto pela somatÃ³ria de transações de Arranjo de Pagamentos com o mesmo:

* Titular/credor original da transaÃ§Ã£o
* Credenciador ou Subcredenciador
* Arranjo de Pagamentos
* Data de liquidaÃ§Ã£o

Para obter informações detalhadas sobre esses assuntos,
recomendamos [consultar a documentaÃ§Ã£o da TAG](https://docs.taginfraestrutura.com.br/docs/unidade-de-recebiveis-ur), a
registradora do grupo StoneCo. LÃ¡ vocÃª encontrarÃ¡ explicações abrangentes e informações especÃ­ficas sobre esses
conceitos.

| Campo                      | DescriÃ§Ã£o                                                             |
|:---------------------------|:----------------------------------------------------------------------|
| payment\_method            | MÃ©todo de pagamento utilizado na transaÃ§Ã£o.                           |
| card\_brand                | Bandeira do cartÃ£o utilizado na transaÃ§Ã£o.                            |
| amount                     | Valor lÃ­quido recebido apÃ³s a aplicaÃ§Ã£o de taxas e descontos.         |
| chargeback\_amount         | Valor descontado devido a chargebacks (contestaÃ§Ã£o de compra).        |
| chargeback\_refund\_amount | Valor devolvido apÃ³s a contestaÃ§Ã£o de um chargeback ser bem-sucedida. |
| credit\_amount             | Valor bruto total das transações antes da aplicaÃ§Ã£o de taxas.         |
| fee\_amount                | Valor das taxas de operaÃ§Ã£o descontadas das transações.               |
| liquidation\_amount        | Valor jÃ¡ liquidado da Unidade de RecebÃ­veis (UR).                     |
| refund\_amount             | Total de valores estornados aos clientes.                             |
| blocked\_amount            | Valores bloqueados por motivos de seguranÃ§a.                          |
| payment\_date              | Data em que o pagamento sera realizado.                               |

# OpenAPI definition

```json
{
  "openapi": "3.1.0",
  "info": {
    "title": "pagarme-api",
    "version": "5"
  },
  "servers": [
    {
      "url": "https://api.pagar.me/core/v5"
    }
  ],
  "components": {
    "securitySchemes": {
      "sec0": {
        "type": "http",
        "scheme": "basic"
      }
    }
  },
  "security": [
    {
      "sec0": []
    }
  ],
  "paths": {
    "/recipients/:recipient_id/receivable-units": {
      "get": {
        "summary": "Retornando URs de um Recebedor",
        "description": "",
        "operationId": "retornando-urs-de-um-recebedor-v5",
        "parameters": [
          {
            "name": "start_date",
            "in": "query",
            "description": "Dia inicial da consulta de agenda. Deve ser informado em timestamp",
            "required": true,
            "schema": {
              "type": "string",
              "format": "date-time"
            }
          },
          {
            "name": "end_date",
            "in": "query",
            "description": "Dia final da consulta de agenda. Dia inicial da consulta de agenda. Deve ser informado em timestamp",
            "required": true,
            "schema": {
              "type": "string",
              "format": "date-time"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "200",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n  [\n  {\n    \"payment_method\": \"credit_card\",\n    \"card_brand\": \"amex\",\n    \"amount\": 16661,\n    \"chargeback_amount\": -253,\n    \"chargeback_refund_amount\": 952,\n    \"credit_amount\": 16569,\n    \"fee_amount\": -33,\n    \"liquidation_amount\": -376,\n    \"refund_amount\": -382,\n    \"payment_date\": \"2023-09-22\"\n  }\n  ]\n}"
                  }
                }
              }
            }
          },
          "400": {
            "description": "400",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {}
                }
              }
            }
          }
        },
        "deprecated": false
      }
    }
  },
  "x-readme": {
    "headers": [],
    "explorer-enabled": true,
    "proxy-enabled": true
  },
  "x-readme-fauxas": true
}
```