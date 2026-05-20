# Remover todos os itens

Quando um pedido estÃ¡ **aberto**, vocÃª pode remover todos os itens dele.

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
    "/orders/{order_id}/items": {
      "delete": {
        "summary": "Remover todos os itens",
        "description": "Quando um pedido estÃ¡ **aberto**, vocÃª pode remover todos os itens dele.",
        "operationId": "remover-todos-os-itens",
        "parameters": [
          {
            "name": "order_id",
            "in": "path",
            "description": "CÃ³digo do pedido.",
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
                    "value": "{\n  \"id\": \"or_5OKyl9fNwIKDzjWJ\",\n  \"code\": \"7P03S0FOQN\",\n  \"currency\": \"BRL\",\n  \"closed\": false,\n  \"customer\": {\n    \"id\": \"cus_oWQOPg5tJF8ml0ny\",\n    \"name\": \"Tony Stark\",\n    \"email\": \"9fb571fc-79c3-4293-aafd-61fd8afa6c38@avengers.com\",\n    \"delinquent\": false,\n    \"created_at\": \"2017-04-05T03:54:42\",\n    \"updated_at\": \"2017-04-05T03:54:42\"\n  },\n  \"status\": \"pending\",\n  \"created_at\": \"2017-04-05T03:54:42\",\n  \"updated_at\": \"2017-04-05T03:54:42\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "or_5OKyl9fNwIKDzjWJ"
                    },
                    "code": {
                      "type": "string",
                      "example": "7P03S0FOQN"
                    },
                    "currency": {
                      "type": "string",
                      "example": "BRL"
                    },
                    "closed": {
                      "type": "boolean",
                      "example": false,
                      "default": true
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_oWQOPg5tJF8ml0ny"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "9fb571fc-79c3-4293-aafd-61fd8afa6c38@avengers.com"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-04-05T03:54:42"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-05T03:54:42"
                        }
                      }
                    },
                    "status": {
                      "type": "string",
                      "example": "pending"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-05T03:54:42"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-04-05T03:54:42"
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
                    "value": "{\n    \"message\": \"Order not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Order not found."
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