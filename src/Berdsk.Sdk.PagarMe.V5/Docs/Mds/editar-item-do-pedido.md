# Editar item do pedido

Quando um pedido estÃ¡ **aberto**, vocÃª pode editar os itens dele.

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
    "/orders/{order_id}/items/{item_id}": {
      "put": {
        "summary": "Editar item do pedido",
        "description": "Quando um pedido estÃ¡ **aberto**, vocÃª pode editar os itens dele.",
        "operationId": "editar-item-do-pedido",
        "parameters": [
          {
            "name": "order_id",
            "in": "path",
            "description": "CÃ³digo do pedido",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "item_id",
            "in": "path",
            "description": "CÃ³digo do item do pedido",
            "schema": {
              "type": "string"
            },
            "required": true
          }
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "required": [
                  "amount",
                  "description",
                  "quantity"
                ],
                "properties": {
                  "amount": {
                    "type": "integer",
                    "description": "Valor do item.",
                    "format": "int32"
                  },
                  "description": {
                    "type": "string",
                    "description": "DescriÃ§Ã£o do item. Max: 256 caracteres."
                  },
                  "quantity": {
                    "type": "integer",
                    "description": "Quantidade de itens.",
                    "format": "int32"
                  },
                  "category": {
                    "type": "string",
                    "description": "Categoria do item. Max: 64 caracteres."
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "amount": 1090,
                    "description": "Ãgua com gÃ¡s",
                    "quantity": 2
                  }
                }
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "200",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n  \"id\": \"oi_AQKqAnGhQGsYd1b6\",\n  \"description\": \"Ãgua com gÃ¡s\",\n  \"amount\": 1090,\n  \"quantity\": 2,\n  \"status\": \"active\",\n  \"created_at\": \"2017-04-05T03:55:48\",\n  \"updated_at\": \"2017-04-05T05:05:14\",\n  \"order\": {\n    \"id\": \"or_5OKyl9fNwIKDzjWJ\",\n    \"code\": \"7P03S0FOQN\",\n    \"amount\": 6260,\n    \"currency\": \"BRL\",\n    \"closed\": false,\n    \"status\": \"pending\",\n    \"created_at\": \"2017-04-05T03:54:42\",\n    \"updated_at\": \"2017-04-05T03:54:42\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "oi_AQKqAnGhQGsYd1b6"
                    },
                    "description": {
                      "type": "string",
                      "example": "Ãgua com gÃ¡s"
                    },
                    "amount": {
                      "type": "integer",
                      "example": 1090,
                      "default": 0
                    },
                    "quantity": {
                      "type": "integer",
                      "example": 2,
                      "default": 0
                    },
                    "status": {
                      "type": "string",
                      "example": "active"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-05T03:55:48"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-04-05T05:05:14"
                    },
                    "order": {
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
                        "amount": {
                          "type": "integer",
                          "example": 6260,
                          "default": 0
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