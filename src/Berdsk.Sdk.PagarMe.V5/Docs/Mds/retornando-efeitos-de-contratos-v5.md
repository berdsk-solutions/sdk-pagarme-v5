# Retornando Efeitos de Contratos

# OpenAPI definition

```json
{
  "openapi": "3.1.0",
  "info": {
    "title": "pagarme-api-register-v5",
    "version": "5"
  },
  "servers": [
    {
      "url": "https://api.pagar.me/register/v5"
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
    "/settlement-obligations": {
      "get": {
        "summary": "Retornando Efeitos de Contratos",
        "description": "",
        "operationId": "retornando-efeitos-de-contratos-v5",
        "parameters": [
          {
            "name": "size",
            "in": "query",
            "description": "Quantidade de efeitos retornados",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "expected_settlement_date_since",
            "in": "query",
            "description": "Data inicial da consulta",
            "required": true,
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "expected_settlement_date_until",
            "in": "query",
            "description": "Data final da consulta",
            "required": true,
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "page",
            "in": "query",
            "description": "PÃ¡gina desejada da consulta",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "recipient_id",
            "in": "query",
            "description": "ID de recebedor desejado",
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
                    "value": "{\n  data: [\n\t\t{\n\t\t\t\"expected_settlement_date\": \"string\",\n\t\t\t\"original_asset_holder\": \"string\",\n\t\t\t\"settlement_obligations\": [\n\t\t\t\t{\n\t\t\t\t\t\"payment_scheme\": \"string\",\n\t\t\t\t\t\"total_amount\": integer,\n\t\t\t\t\t\"uncommitted_amount\": integer,\n\t\t\t\t\t\"expected_settlement_date\": \"string\",\n\t\t\t\t\t\"contract_Key\": \"string\",\n\t\t\t\t\t\"contract_holder\": \"string\",\n\t\t\t\t\t\"effect_priority\": integer,\n\t\t\t\t\t\"contract_type\": \"string\",\n\t\t\t\t\t\"division_method\": \"string\",\n\t\t\t\t\t\"effect_amount\": integer,\n\t\t\t\t\t\"committed_effect_amount\": integer\n\t\t\t\t}\n\t\t\t]\n\t\t}\n\t],\n\t\"paging\": {\n\t\t\"total\": 11,\n\t\t\"previous\": \"https://api.pagar.me/register/v5/settlement-obligations?page=1&size=10\",\n\t\t\"next\": \"https://api.pagar.me/register/v5/settlement-obligations?page=3&size=10\"\n\t}\n}"
                  }
                }
              }
            }
          },
          "204": {
            "description": "204",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n  message: \"No content\"\n}"
                  }
                }
              }
            }
          },
          "404": {
            "description": "404",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n  message: \"recipient not found\"\n}"
                  }
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