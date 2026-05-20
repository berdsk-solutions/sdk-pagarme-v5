# Listar incrementos

Este recurso permite listar os incrementos associados a uma assinatura.

> ðŸ“˜ PaginaÃ§Ã£o
>
> Este recurso utiliza **paginaÃ§Ã£o** para manipulaÃ§Ã£o da listagem
> resultante. [Saiba mais sobre paginaÃ§Ã£o](https://docs.pagar.me/v5/reference#pagina%C3%A7%C3%A3o).

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
    "/subscriptions/{subscription_id}/increments": {
      "get": {
        "summary": "Listar incrementos",
        "description": "Este recurso permite listar os incrementos associados a uma assinatura.",
        "operationId": "listar-incrementos",
        "parameters": [
          {
            "name": "subscription_id",
            "in": "path",
            "description": "CÃ³digo da assinatura.<br>Formato `sub_XXXXXXXXXXXXXXXX`",
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
                    "value": "{\n    \"data\": [\n        {\n            \"id\": \"inc_IYzpxgjsOs0fDIoP\",\n            \"value\": 20,\n            \"increment_type\": \"percentage\",\n            \"status\": \"active\",\n            \"created_at\": \"2018-03-15T19:49:29Z\",\n            \"subscription\": {\n                \"id\": \"sub_Yo2VQVyeSWHKmN5k\",\n                \"code\": \"Z8OXUJI3M5\",\n                \"start_at\": \"2018-03-15T00:00:00Z\",\n                \"interval\": \"month\",\n                \"interval_count\": 1,\n                \"billing_type\": \"prepaid\",\n                \"next_billing_at\": \"2018-04-15T00:00:00Z\",\n                \"payment_method\": \"credit_card\",\n                \"currency\": \"BRL\",\n                \"installments\": 1,\n                \"status\": \"active\",\n                \"created_at\": \"2018-03-15T19:49:05Z\",\n                \"updated_at\": \"2018-03-15T19:49:05Z\"\n            }\n        },\n        {\n            \"id\": \"inc_kyzpJFssOs0fIoUx\",\n            \"value\": 10,\n            \"increment_type\": \"percentage\",\n            \"status\": \"active\",\n            \"created_at\": \"2018-03-15T19:49:25Z\",\n            \"subscription\": {\n                \"id\": \"sub_Yo2VQVyeSWHKmN5k\",\n                \"code\": \"Z8OXUJI3M5\",\n                \"start_at\": \"2018-03-15T00:00:00Z\",\n                \"interval\": \"month\",\n                \"interval_count\": 1,\n                \"billing_type\": \"prepaid\",\n                \"next_billing_at\": \"2018-04-15T00:00:00Z\",\n                \"payment_method\": \"credit_card\",\n                \"currency\": \"BRL\",\n                \"installments\": 1,\n                \"status\": \"active\",\n                \"created_at\": \"2018-03-15T19:49:05Z\",\n                \"updated_at\": \"2018-03-15T19:49:05Z\"\n            }\n        }\n    ],\n    \"paging\": {\n        \"total\": 2\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "data": {
                      "type": "array",
                      "items": {
                        "type": "object",
                        "properties": {
                          "id": {
                            "type": "string",
                            "example": "inc_IYzpxgjsOs0fDIoP"
                          },
                          "value": {
                            "type": "integer",
                            "example": 20,
                            "default": 0
                          },
                          "increment_type": {
                            "type": "string",
                            "example": "percentage"
                          },
                          "status": {
                            "type": "string",
                            "example": "active"
                          },
                          "created_at": {
                            "type": "string",
                            "example": "2018-03-15T19:49:29Z"
                          },
                          "subscription": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "sub_Yo2VQVyeSWHKmN5k"
                              },
                              "code": {
                                "type": "string",
                                "example": "Z8OXUJI3M5"
                              },
                              "start_at": {
                                "type": "string",
                                "example": "2018-03-15T00:00:00Z"
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
                                "example": "prepaid"
                              },
                              "next_billing_at": {
                                "type": "string",
                                "example": "2018-04-15T00:00:00Z"
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
                                "example": "2018-03-15T19:49:05Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2018-03-15T19:49:05Z"
                              }
                            }
                          }
                        }
                      }
                    },
                    "paging": {
                      "type": "object",
                      "properties": {
                        "total": {
                          "type": "integer",
                          "example": 2,
                          "default": 0
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
                    "value": "{\n  \"message\": \"Subscription not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Subscription not found."
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