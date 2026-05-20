# Retornando pagamentos por recebedor

Retorna um Array contendo objetos de pagamentos (settlements) de um recebedor ordenados a partir da data de criaÃ§Ã£o colocando os mais recentes no topo.

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
    "/recipients/:recipientId/settlements": {
      "get": {
        "summary": "Retornando pagamentos por recebedor",
        "description": "Retorna um Array contendo objetos de pagamentos (settlements) de um recebedor ordenados a partir da data de criaÃ§Ã£o colocando os mais recentes no topo.",
        "operationId": "retornando-pagamentos-por-recebedor",
        "parameters": [
          {
            "name": "recipient_id",
            "in": "path",
            "description": "ID do recebedor",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "payment_date_start",
            "in": "query",
            "description": "InÃ­cio da data de pagamento (inclusivo). Data no formato YYYY-MM-DD",
            "required": true,
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "payment_date_end",
            "in": "query",
            "description": "Fim da data de pagamento (inclusivo). Data no formato YYYY-MM-DD",
            "required": true,
            "schema": {
              "type": "string"
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
                    "value": "{}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {}
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