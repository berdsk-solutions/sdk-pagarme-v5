# Obter saldo

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
    "/recipients/{recipient_id}/balance": {
      "get": {
        "summary": "Obter saldo",
        "description": "",
        "operationId": "obter-saldo",
        "parameters": [
          {
            "name": "recipient_id",
            "in": "path",
            "description": "Identificador do recebedor",
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
                    "value": "{\n    \"currency\": \"BRL\",\n    \"available_amount\": 0,\n    \"waiting_funds_amount\": 0,\n    \"transferred_amount\": 0,\n    \"recipient\": {\n        \"id\": \"rp_pVZR1qZi64F9bR5e\",\n        \"name\": \"First recipient\",\n        \"email\": \"first_recipient@pagar.me\",\n        \"document\": \"12728994706\",\n        \"description\": \"DescriÃ§Ã£o do recebedor 1\",\n        \"type\": \"individual\",\n        \"status\": \"active\",\n        \"created_at\": \"2020-10-08T21:35:26Z\",\n        \"updated_at\": \"2020-10-17T18:54:06Z\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "currency": {
                      "type": "string",
                      "example": "BRL"
                    },
                    "available_amount": {
                      "type": "integer",
                      "example": 0,
                      "default": 0
                    },
                    "waiting_funds_amount": {
                      "type": "integer",
                      "example": 0,
                      "default": 0
                    },
                    "transferred_amount": {
                      "type": "integer",
                      "example": 0,
                      "default": 0
                    },
                    "recipient": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "rp_pVZR1qZi64F9bR5e"
                        },
                        "name": {
                          "type": "string",
                          "example": "First recipient"
                        },
                        "email": {
                          "type": "string",
                          "example": "first_recipient@pagar.me"
                        },
                        "document": {
                          "type": "string",
                          "example": "12728994706"
                        },
                        "description": {
                          "type": "string",
                          "example": "DescriÃ§Ã£o do recebedor 1"
                        },
                        "type": {
                          "type": "string",
                          "example": "individual"
                        },
                        "status": {
                          "type": "string",
                          "example": "active"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2020-10-08T21:35:26Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2020-10-17T18:54:06Z"
                        }
                      }
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