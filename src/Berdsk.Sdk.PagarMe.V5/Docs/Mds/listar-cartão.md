# Listar cartÃ£o

Este recurso permite a recuperaÃ§Ã£o da **Wallet** contendo todos os cartÃµes do cliente atravÃ©s do seu identificador (
`customer_id`).

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
    "/customers/{customer_id}/cards": {
      "get": {
        "summary": "Listar cartÃ£o",
        "description": "Este recurso permite a recuperaÃ§Ã£o da **Wallet** contendo todos os cartÃµes do cliente atravÃ©s do seu identificador (`customer_id`).",
        "operationId": "listar-cartÃ£o",
        "parameters": [
          {
            "name": "customer_id",
            "in": "path",
            "description": "CÃ³digo do cliente. Formato: `cus_XXXXXXXXXXXXXXXX`.",
            "schema": {
              "type": "string"
            },
            "required": true
          }
        ],
        "responses": {
          "200": {
            "description": "200",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n  \"data\": [\n    {\n      \"id\": \"card_onv508NKF3uy98lx\",\n      \"first_six_digits\": \"542501\",\n      \"last_four_digits\": \"8229\",\n      \"brand\": \"Amex\",\n      \"holder_name\": \"Tony Stark\",\n      \"exp_month\": 1,\n      \"exp_year\": 2030,\n      \"status\": \"active\",\n      \"created_at\": \"2017-03-28T22:09:43Z\",\n      \"updated_at\": \"2017-03-28T22:09:43Z\",\n      \"billing_address\": {\n        \"line_1\": \"10880, Malibu Point, Malibu Central\",\n        \"zip_code\": \"90265\",\n        \"city\": \"Malibu\",\n        \"state\": \"CA\",\n        \"country\": \"US\",\n      }\n    }, \n    {\n      \"id\": \"card_k8HDT5sof8CS53KS\",\n      \"first_six_digits\": \"411193\",\n      \"last_four_digits\": \"6203\",\n      \"brand\": \"Visa\",\n      \"holder_name\": \"Tony Stark\",\n      \"exp_month\": 1,\n      \"exp_year\": 2030,\n      \"status\": \"active\",\n      \"created_at\": \"2017-03-29T22:09:43Z\",\n      \"updated_at\": \"2017-03-29T22:09:43Z\",\n      \"billing_address\": {\n        \"line_1\": \"10880, Malibu Point, Malibu Central\",\n        \"zip_code\": \"90265\",\n        \"city\": \"Malibu\",\n        \"state\": \"CA\",\n        \"country\": \"US\",\n      }\n    }\n  ],\n  \"paging\": {\n    \"total\": 2\n  }\n}"
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
                    "value": "{\n    \"message\": \"Card not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Card not found."
                    }
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