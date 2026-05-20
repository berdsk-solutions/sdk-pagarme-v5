# Desativar faturamento manual

ConfiguraÃ§Ã£o da assinatura que indica se o faturamento serÃ¡ feito de forma `manual` ou `automÃ¡tica`.
`Caso esteja desativada`, as faturas serÃ£o geradas automaticamente pelo nosso sistema.

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
    "/subscriptions/{subscription_id}/manual-billing": {
      "delete": {
        "summary": "Desativar faturamento manual",
        "description": "ConfiguraÃ§Ã£o da assinatura que indica se o faturamento serÃ¡ feito de forma `manual` ou `automÃ¡tica`.\n`Caso esteja desativada`, as faturas serÃ£o geradas automaticamente pelo nosso sistema.",
        "operationId": "desativar-faturamento-manual-1",
        "parameters": [
          {
            "name": "subscription_id",
            "in": "path",
            "description": "CÃ³digo da assinatura.<br>Formato: `sub_XXXXXXXXXXXXXXXX`.",
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
                    "value": "{\n    \"id\": \"sub_kpWeWOBcOcpqe8jg\",\n    \"code\": \"PX7ECLF6Y3\",\n    \"start_at\": \"2019-05-07T00:00:00Z\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"billing_type\": \"postpaid\",\n    \"next_billing_at\": \"2019-06-07T00:00:00Z\",\n    \"payment_method\": \"credit_card\",\n    \"currency\": \"BRL\",\n    \"installments\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2019-05-07T21:32:28Z\",\n    \"updated_at\": \"2019-05-07T21:32:38Z\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "sub_kpWeWOBcOcpqe8jg"
                    },
                    "code": {
                      "type": "string",
                      "example": "PX7ECLF6Y3"
                    },
                    "start_at": {
                      "type": "string",
                      "example": "2019-05-07T00:00:00Z"
                    },
                    "interval": {
                      "type": "string",
                      "example": "month"
                    },
                    "interval_count": {
                      "type": "integer",
                      "example": 1,
                      "default": 0
                    },
                    "billing_type": {
                      "type": "string",
                      "example": "postpaid"
                    },
                    "next_billing_at": {
                      "type": "string",
                      "example": "2019-06-07T00:00:00Z"
                    },
                    "payment_method": {
                      "type": "string",
                      "example": "credit_card"
                    },
                    "currency": {
                      "type": "string",
                      "example": "BRL"
                    },
                    "installments": {
                      "type": "integer",
                      "example": 1,
                      "default": 0
                    },
                    "status": {
                      "type": "string",
                      "example": "active"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2019-05-07T21:32:28Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2019-05-07T21:32:38Z"
                    }
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