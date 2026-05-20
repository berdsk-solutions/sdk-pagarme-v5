# Retornando pagamentos

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
    "/settlements": {
      "get": {
        "summary": "Retornando pagamentos",
        "description": "Retorna um Array contendo objetos de pagamentos (settlements) de um recebedor ordenados a partir da data de criaÃ§Ã£o colocando os mais recentes no topo.",
        "operationId": "retornando-pagamentos",
        "parameters": [
          {
            "name": "payment_date_start",
            "in": "query",
            "description": "InÃ­cio da data de pagamento. Data no formato YYYY-MM-DD",
            "required": true,
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "payment_date_end",
            "in": "query",
            "description": "Fim da data de pagamento. Data no formato YYYY-MM-DD",
            "required": true,
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "liquidation_arrangement_id",
            "in": "query",
            "description": "ID da LiquidationArrangement",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "page",
            "in": "query",
            "description": "NÃºmero da pÃ¡gina",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          },
          {
            "name": "limit",
            "in": "query",
            "description": "Limite de itens por pÃ¡gina. Valor mÃ¡ximo = 2000",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          },
          {
            "name": "get_ispb",
            "in": "query",
            "description": "Se retorna ou nÃ£o os dados de ISPB das Settlements",
            "schema": {
              "type": "boolean"
            }
          },
          {
            "name": "liquidation_arrangement_id",
            "in": "query",
            "description": "ID da LiquidationArrangement para filtrar",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "settlement_id",
            "in": "query",
            "description": "ID da Settlement para usar como base. O ID da LiquidationArrangement desta Settlement serÃ¡ utilizado como filtro.  Sobrescreve o parâmetro liquidation_arrangement_id",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "external_engine_payment_id",
            "in": "query",
            "description": "ID do motor de liquidaÃ§Ã£o utilizado internamente",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "order",
            "in": "query",
            "description": "Ordernar pela criaÃ§Ã£o da Settlement crescente ou decrescente. String asc ou desc",
            "schema": {
              "type": "string",
              "default": "desc"
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