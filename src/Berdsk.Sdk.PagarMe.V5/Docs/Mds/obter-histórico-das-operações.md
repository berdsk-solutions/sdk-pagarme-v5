# Obter histÃ³rico das operações

Com esta rota Ã© possÃ­vel verificar os movimentos ocorridos no saldo da sua conta.

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
    "/balance/operations": {
      "get": {
        "summary": "Obter histÃ³rico das operações",
        "description": "Com esta rota Ã© possÃ­vel verificar os movimentos ocorridos no saldo da sua conta.",
        "operationId": "obter-histÃ³rico-das-operaÃ§Ãµes",
        "parameters": [
          {
            "name": "created_since",
            "in": "query",
            "description": "Filtro pela data de criaÃ§Ã£o da operaÃ§Ã£o de saldo, como data de partida",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "created_until",
            "in": "query",
            "description": "Filtro pela data de criaÃ§Ã£o da operaÃ§Ã£o de saldo, como data limite",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "status",
            "in": "query",
            "description": "Estado do saldo da conta. Valores possÃ­veis: `waiting_funds`, `available` e `transferred`, sendo o default  `available`",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "recipient_id",
            "in": "query",
            "description": "ID de recebedor desejado",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "size",
            "in": "query",
            "description": "Filtro pela quantidade de objetos retornados. Deve ser menor ou igual a 1000",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          },
          {
            "name": "page",
            "in": "query",
            "description": "Filtro pela pÃ¡gina de retorno",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "200",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"data\": [\n        {\n            \"id\": 2155314409,\n            \"status\": \"available\",\n            \"balance_amount\": 0,\n            \"type\": \"payable\",\n            \"amount\": -8990,\n            \"fee\": 0,\n            \"created_at\": \"2023-06-27T20:59:20Z\",\n            \"movement_object\": {\n                \"fee\": 0,\n                \"anticipation_fee\": 0,\n                \"fraud_coverage_fee\": 0,\n                \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n                \"originator_model\": \"refund\",\n                \"originator_model_id\": \"rf_cljertfyx1z1301m52an4poij\",\n                \"payment_date \": \"2023-06-27T03:00:00Z\",\n                \"payment_method\": \"pix\",\n                \"object\": \"payable\",\n                \"id\": \"4304143066\",\n                \"status\": \"paid\",\n                \"amount\": -8990,\n                \"created_at\": \"2023-06-27T20:59:20Z\",\n                \"type\": \"refund\",\n                \"gateway_id\": \"23795495\"\n            }\n        },\n        {\n            \"id\": 2155314405,\n            \"status\": \"available\",\n            \"balance_amount\": 0,\n            \"type\": \"payable\",\n            \"amount\": 8990,\n            \"fee\": 107,\n            \"created_at\": \"2023-06-27T20:57:26Z\",\n            \"movement_object\": {\n                \"fee\": 107,\n                \"anticipation_fee\": 0,\n                \"fraud_coverage_fee\": 0,\n                \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n                \"payment_date \": \"2023-06-27T03:00:00Z\",\n                \"payment_method\": \"pix\",\n                \"object\": \"payable\",\n                \"id\": \"4304143062\",\n                \"status\": \"paid\",\n                \"amount\": 8990,\n                \"created_at\": \"2023-06-27T20:57:26Z\",\n                \"type\": \"credit\",\n                \"gateway_id\": \"23795495\"\n            }\n        },\n        {\n            \"id\": 2155309256,\n            \"status\": \"available\",\n            \"balance_amount\": 0,\n            \"type\": \"payable\",\n            \"amount\": -8990,\n            \"fee\": 0,\n            \"created_at\": \"2023-06-27T19:59:47Z\",\n            \"movement_object\": {\n                \"fee\": 0,\n                \"anticipation_fee\": 0,\n                \"fraud_coverage_fee\": 0,\n                \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n                \"originator_model\": \"refund\",\n                \"originator_model_id\": \"rf_cljepoveh085601m54lfrq07q\",\n                \"payment_date \": \"2023-06-27T03:00:00Z\",\n                \"payment_method\": \"pix\",\n                \"object\": \"payable\",\n                \"id\": \"4304137920\",\n                \"status\": \"paid\",\n                \"amount\": -8990,\n                \"created_at\": \"2023-06-27T19:59:47Z\",\n                \"type\": \"refund\",\n                \"gateway_id\": \"23793734\"\n            }\n        },\n        {\n            \"id\": 2155309241,\n            \"status\": \"available\",\n            \"balance_amount\": 0,\n            \"type\": \"payable\",\n            \"amount\": 8990,\n            \"fee\": 107,\n            \"created_at\": \"2023-06-27T19:59:13Z\",\n            \"movement_object\": {\n                \"fee\": 107,\n                \"anticipation_fee\": 0,\n                \"fraud_coverage_fee\": 0,\n                \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n                \"payment_date \": \"2023-06-27T03:00:00Z\",\n                \"payment_method\": \"pix\",\n                \"object\": \"payable\",\n                \"id\": \"4304137905\",\n                \"status\": \"paid\",\n                \"amount\": 8990,\n                \"created_at\": \"2023-06-27T19:59:13Z\",\n                \"type\": \"credit\",\n                \"gateway_id\": \"23793734\"\n            }\n        },\n        {\n            \"id\": 2155309084,\n            \"status\": \"available\",\n            \"balance_amount\": 0,\n            \"type\": \"payable\",\n            \"amount\": -8990,\n            \"fee\": 0,\n            \"created_at\": \"2023-06-27T19:54:12Z\",\n            \"movement_object\": {\n                \"fee\": 0,\n                \"anticipation_fee\": 0,\n                \"fraud_coverage_fee\": 0,\n                \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n                \"originator_model\": \"refund\",\n                \"originator_model_id\": \"rf_cljephore028a01m556g5fcl3\",\n                \"payment_date \": \"2023-06-27T03:00:00Z\",\n                \"payment_method\": \"pix\",\n                \"object\": \"payable\",\n                \"id\": \"4304137806\",\n                \"status\": \"paid\",\n                \"amount\": -8990,\n                \"created_at\": \"2023-06-27T19:54:12Z\",\n                \"type\": \"refund\",\n                \"gateway_id\": \"23793595\"\n            }\n        }\n    ],\n    \"paging\": {}\n}"
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
                            "type": "integer",
                            "example": 2155314409,
                            "default": 0
                          },
                          "status": {
                            "type": "string",
                            "example": "available"
                          },
                          "balance_amount": {
                            "type": "integer",
                            "example": 0,
                            "default": 0
                          },
                          "type": {
                            "type": "string",
                            "example": "payable"
                          },
                          "amount": {
                            "type": "integer",
                            "example": -8990,
                            "default": 0
                          },
                          "fee": {
                            "type": "integer",
                            "example": 0,
                            "default": 0
                          },
                          "created_at": {
                            "type": "string",
                            "example": "2023-06-27T20:59:20Z"
                          },
                          "movement_object": {
                            "type": "object",
                            "properties": {
                              "fee": {
                                "type": "integer",
                                "example": 0,
                                "default": 0
                              },
                              "anticipation_fee": {
                                "type": "integer",
                                "example": 0,
                                "default": 0
                              },
                              "fraud_coverage_fee": {
                                "type": "integer",
                                "example": 0,
                                "default": 0
                              },
                              "recipient_id": {
                                "type": "string",
                                "example": "re_cjlnpqrq0006vn56e1nig0tcv"
                              },
                              "originator_model": {
                                "type": "string",
                                "example": "refund"
                              },
                              "originator_model_id": {
                                "type": "string",
                                "example": "rf_cljertfyx1z1301m52an4poij"
                              },
                              "payment_date ": {
                                "type": "string",
                                "example": "2023-06-27T03:00:00Z"
                              },
                              "payment_method": {
                                "type": "string",
                                "example": "pix"
                              },
                              "object": {
                                "type": "string",
                                "example": "payable"
                              },
                              "id": {
                                "type": "string",
                                "example": "4304143066"
                              },
                              "status": {
                                "type": "string",
                                "example": "paid"
                              },
                              "amount": {
                                "type": "integer",
                                "example": -8990,
                                "default": 0
                              },
                              "created_at": {
                                "type": "string",
                                "example": "2023-06-27T20:59:20Z"
                              },
                              "type": {
                                "type": "string",
                                "example": "refund"
                              },
                              "gateway_id": {
                                "type": "string",
                                "example": "23795495"
                              }
                            }
                          }
                        }
                      }
                    },
                    "paging": {
                      "type": "object",
                      "properties": {}
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