# Obter item do pedido

Obter um item especifico dentro de um pedido especifico.

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
      "get": {
        "summary": "Obter item do pedido",
        "description": "Obter um item especifico dentro de um pedido especifico.",
        "operationId": "obter-item-do-pedido",
        "parameters": [
          {
            "name": "order_id",
            "in": "path",
            "description": "CÃ³digo do pedido.",
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
                    "value": "{\n    \"id\": \"oi_gJ4RZVujNFDVRwpn\",\n    \"description\": \"Chaveiro do Tesseract\",\n    \"amount\": 2990,\n    \"quantity\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2017-12-18T16:49:43Z\",\n    \"updated_at\": \"2017-12-18T16:49:43Z\",\n    \"order\": {\n        \"id\": \"or_WpJzPeCwQtlYrEGO\",\n        \"code\": \"ELVRSL8S7Z\",\n        \"amount\": 2990,\n        \"currency\": \"BRL\",\n        \"closed\": true,\n        \"status\": \"paid\",\n        \"created_at\": \"2017-12-18T16:49:43Z\",\n        \"updated_at\": \"2017-12-18T16:49:44Z\",\n        \"closed_at\": \"2017-12-18T16:49:44Z\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "oi_gJ4RZVujNFDVRwpn"
                    },
                    "description": {
                      "type": "string",
                      "example": "Chaveiro do Tesseract"
                    },
                    "amount": {
                      "type": "integer",
                      "example": 2990,
                      "default": 0
                    },
                    "quantity": {
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
                      "example": "2017-12-18T16:49:43Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-12-18T16:49:43Z"
                    },
                    "order": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "or_WpJzPeCwQtlYrEGO"
                        },
                        "code": {
                          "type": "string",
                          "example": "ELVRSL8S7Z"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 2990,
                          "default": 0
                        },
                        "currency": {
                          "type": "string",
                          "example": "BRL"
                        },
                        "closed": {
                          "type": "boolean",
                          "example": true,
                          "default": true
                        },
                        "status": {
                          "type": "string",
                          "example": "paid"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-12-18T16:49:43Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-12-18T16:49:44Z"
                        },
                        "closed_at": {
                          "type": "string",
                          "example": "2017-12-18T16:49:44Z"
                        }
                      }
                    }
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
                    "value": "{\n    \"message\": \"Order not found.\"\n}"
                  }
                },
                "schema": {
                  "oneOf": [
                    {
                      "type": "object",
                      "properties": {
                        "message": {
                          "type": "string",
                          "example": "Item not found."
                        }
                      }
                    },
                    {
                      "type": "object",
                      "properties": {
                        "message": {
                          "type": "string",
                          "example": "Order not found."
                        }
                      }
                    }
                  ]
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