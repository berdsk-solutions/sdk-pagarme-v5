# Renovar ciclo

AtravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel renovar o ciclo de uma assinatura. A utilizaÃ§Ã£o do
mÃ©todo irÃ¡ sempre renovar o ciclo Ã  frente. Para Listar os ciclos de uma assinatura,
acesse [Listar Ciclos](https://docs.pagar.me/reference/listar-ciclos-1).

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
    "/subscriptions/{subscription_id}/cycles": {
      "post": {
        "summary": "Renovar ciclo",
        "description": "AtravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel renovar o ciclo de uma assinatura. A utilizaÃ§Ã£o do mÃ©todo irÃ¡ sempre renovar o ciclo Ã  frente. Para Listar os ciclos de uma assinatura, acesse [Listar Ciclos](https://docs.pagar.me/reference/listar-ciclos-1).",
        "operationId": "renovar-ciclo-1",
        "parameters": [
          {
            "name": "subscription_id",
            "in": "path",
            "description": "CÃ³digo da assinatura.",
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
                    "value": "{\n    \"id\": \"cycle_Qal5a0LCpphoDpnR\",\n    \"billing_at\": \"2019-04-30T00:00:00Z\",\n    \"cycle\": 1,\n    \"start_at\": \"2019-04-30T00:00:00Z\",\n    \"end_at\": \"2019-07-29T23:59:59Z\",\n    \"duration\": 7862399,\n    \"created_at\": \"2019-04-30T18:09:32Z\",\n    \"updated_at\": \"2019-04-30T18:12:20Z\",\n    \"status\": \"billed\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "cycle_Qal5a0LCpphoDpnR"
                    },
                    "billing_at": {
                      "type": "string",
                      "example": "2019-04-30T00:00:00Z"
                    },
                    "cycle": {
                      "type": "integer",
                      "example": 1,
                      "default": 0
                    },
                    "start_at": {
                      "type": "string",
                      "example": "2019-04-30T00:00:00Z"
                    },
                    "end_at": {
                      "type": "string",
                      "example": "2019-07-29T23:59:59Z"
                    },
                    "duration": {
                      "type": "integer",
                      "example": 7862399,
                      "default": 0
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2019-04-30T18:09:32Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2019-04-30T18:12:20Z"
                    },
                    "status": {
                      "type": "string",
                      "example": "billed"
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