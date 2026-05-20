# Incluir item

Quando um pedido estÃ¡ **aberto**, vocÃª pode incluir itens nele.

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
      "post": {
        "summary": "Incluir item",
        "description": "Quando um pedido estÃ¡ **aberto**, vocÃª pode incluir itens nele.",
        "operationId": "incluir-item",
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
                  "code": {
                    "type": "string",
                    "description": "CÃ³digo do item no sistema da loja. Max: 52 caracteres. ObrigatÃ³rio para transações de split"
                  },
                  "description": {
                    "type": "string",
                    "description": "DescriÃ§Ã£o do item. Max: 256 caracteres."
                  },
                  "quantity": {
                    "type": "string",
                    "description": "Quantidade de itens."
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
                    "description": "Caneca Zero Grau",
                    "quantity": 1,
                    "seller": {
                      "document": "26224451990",
                      "name": "Stark Industries",
                      "code": "STRK_01",
                      "description": "Changing the world for a better future.",
                      "address": {
                        "line_1": "10880, Malibu Point, Malibu Central",
                        "zip_code": "90265",
                        "city": "Malibu",
                        "state": "CA",
                        "country": "US"
                      }
                    }
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
                    "value": "{\n  \"id\": \"oi_ZD2lNDKcORty1pzw\",\n  \"description\": \"Caneca Zero Grau\",\n  \"amount\": 1090,\n  \"quantity\": 1,\n  \"status\": \"active\",\n  \"created_at\": \"2017-10-05T20:24:38Z\",\n  \"updated_at\": \"2017-10-05T20:24:38Z\",\n  \"order\": {\n    \"id\": \"or_oO7vgpeh1rF4DX3A\",\n    \"code\": \"7W86TKXIO1\",\n    \"amount\": 5170,\n    \"currency\": \"BRL\",\n    \"closed\": false,\n    \"status\": \"pending\",\n    \"created_at\": \"2017-10-05T19:41:29Z\",\n    \"updated_at\": \"2017-10-05T19:41:29Z\"\n  },\n  \"seller\": {\n    \"id\": \"sl_jY3D2MziacQnR01W\",\n    \"name\": \"Stark Industries\",\n    \"code\": \"STRK_01\",\n    \"document\": \"26224451990\",\n    \"description\": \"Changing the world for a better future.\",\n    \"status\": \"active\",\n    \"created_at\": \"2017-10-05T20:24:38Z\",\n    \"updated_at\": \"2017-10-05T20:24:38Z\",\n    \"address\": {\n      \"line_1\": \"10880, Malibu Point, Malibu Central\",\n      \"zip_code\": \"90265\",\n      \"city\": \"Malibu\",\n      \"state\": \"CA\",\n      \"country\": \"US\"\n    },\n    \"metadata\": {}\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "oi_ZD2lNDKcORty1pzw"
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
                      "example": "active"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-10-05T20:24:38Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-10-05T20:24:38Z"
                    },
                    "order": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "or_oO7vgpeh1rF4DX3A"
                        },
                        "code": {
                          "type": "string",
                          "example": "7W86TKXIO1"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 5170,
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
                          "example": "2017-10-05T19:41:29Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-10-05T19:41:29Z"
                        }
                      }
                    },
                    "seller": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "sl_jY3D2MziacQnR01W"
                        },
                        "name": {
                          "type": "string",
                          "example": "Stark Industries"
                        },
                        "code": {
                          "type": "string",
                          "example": "STRK_01"
                        },
                        "document": {
                          "type": "string",
                          "example": "26224451990"
                        },
                        "description": {
                          "type": "string",
                          "example": "Changing the world for a better future."
                        },
                        "status": {
                          "type": "string",
                          "example": "active"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-10-05T20:24:38Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-10-05T20:24:38Z"
                        },
                        "address": {
                          "type": "object",
                          "properties": {
                            "line_1": {
                              "type": "string",
                              "example": "10880, Malibu Point, Malibu Central"
                            },
                            "zip_code": {
                              "type": "string",
                              "example": "90265"
                            },
                            "city": {
                              "type": "string",
                              "example": "Malibu"
                            },
                            "state": {
                              "type": "string",
                              "example": "CA"
                            },
                            "country": {
                              "type": "string",
                              "example": "US"
                            }
                          }
                        },
                        "metadata": {
                          "type": "object",
                          "properties": {}
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