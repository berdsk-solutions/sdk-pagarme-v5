# Deletar item

Quando um pedido estÃ¡ **aberto**, vocÃª pode excluir itens dele.

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
      "delete": {
        "summary": "Deletar item",
        "description": "Quando um pedido estÃ¡ **aberto**, vocÃª pode excluir itens dele.",
        "operationId": "deletar-item",
        "parameters": [
          {
            "name": "order_id",
            "in": "path",
            "description": "CÃ³dido do pedido.",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "item_id",
            "in": "path",
            "description": "CÃ³digo do item do pedido.",
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
                    "value": "{\n  \"id\": \"oi_AQKqAnGhQGsYd1b6\",\n  \"description\": \"Caneca Zero Grau\",\n  \"amount\": 1090,\n  \"quantity\": 2,\n  \"status\": \"deleted\",\n  \"created_at\": \"2017-04-05T03:55:48\",\n  \"updated_at\": \"2017-04-05T05:05:14\",\n  \"deleted_at\": \"2017-04-05T05:30:34\",\n  \"order\": {\n    \"id\": \"or_5OKyl9fNwIKDzjWJ\",\n    \"code\": \"7P03S0FOQN\",\n    \"amount\": 4080,\n    \"currency\": \"BRL\",\n    \"closed\": false,\n    \"status\": \"pending\",\n    \"created_at\": \"2017-04-05T03:54:42\",\n    \"updated_at\": \"2017-04-05T03:54:42\"\n  }\n}"
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
                      "example": "Caneca Zero Grau"
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
                      "example": "deleted"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-05T03:55:48"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-04-05T05:05:14"
                    },
                    "deleted_at": {
                      "type": "string",
                      "example": "2017-04-05T05:30:34"
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
                          "example": 4080,
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
                    "value": "{\n  \"id\": \"oi_ZR3AjrjFwsg2A7bz\",\n  \"description\": \"Caneca Zero Grau\",\n  \"amount\": 1090,\n  \"quantity\": 1,\n  \"status\": \"deleted\",\n  \"created_at\": \"2017-04-05T05:33:29\",\n  \"updated_at\": \"2017-04-05T05:33:29\",\n  \"deleted_at\": \"2017-04-05T05:33:38\",\n  \"order\": {\n    \"id\": \"or_5OKyl9fNwIKDzjWJ\",\n    \"code\": \"7P03S0FOQN\",\n    \"amount\": 4080,\n    \"currency\": \"BRL\",\n    \"closed\": false,\n    \"status\": \"pending\",\n    \"created_at\": \"2017-04-05T03:54:42\",\n    \"updated_at\": \"2017-04-05T03:54:42\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "oi_ZR3AjrjFwsg2A7bz"
                    },
                    "description": {
                      "type": "string",
                      "example": "Caneca Zero Grau"
                    },
                    "amount": {
                      "type": "integer",
                      "example": 1090,
                      "default": 0
                    },
                    "quantity": {
                      "type": "integer",
                      "example": 1,
                      "default": 0
                    },
                    "status": {
                      "type": "string",
                      "example": "deleted"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-05T05:33:29"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-04-05T05:33:29"
                    },
                    "deleted_at": {
                      "type": "string",
                      "example": "2017-04-05T05:33:38"
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
                          "example": 4080,
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