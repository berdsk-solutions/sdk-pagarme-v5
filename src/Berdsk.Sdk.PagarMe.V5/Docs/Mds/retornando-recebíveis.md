# Obter recebÃ­veis

Retorna os recebÃ­veis da sua loja.

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
    "/payables": {
      "get": {
        "summary": "Obter recebÃ­veis",
        "description": "Retorna os recebÃ­veis da sua loja.",
        "operationId": "retornando-recebÃ­veis",
        "parameters": [
          {
            "name": "created_since",
            "in": "query",
            "description": "Filtro pela data de criaÃ§Ã£o do payable, como data de partida",
            "schema": {
              "type": "string",
              "format": "date",
              "default": "2025-12-01T13:06:21Z"
            }
          },
          {
            "name": "created_until",
            "in": "query",
            "description": "Filtro pela data de criaÃ§Ã£o do payable, como data limite",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "status",
            "in": "query",
            "description": "Filtro pelo status do recebÃ­vel. `paid` ou `waiting_funds`",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "payment_date_since",
            "in": "query",
            "description": "Filtro pela data de pagamento do recebÃ­vel, como data de partida",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "payment_date_until",
            "in": "query",
            "description": "Filtro pela data de pagamento do recebÃ­vel, como data limite",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "type",
            "in": "query",
            "description": "Filtro pelo type do recebÃ­vel. Pode ser `chargeback`, `refund`, `chargeback_refund` ou `credit`",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "updated_since",
            "in": "query",
            "description": "Filtro pela data de atualizaÃ§Ã£o do recebÃ­vel, como data de partida",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "updated_until",
            "in": "query",
            "description": "Filtro pela data de atualizaÃ§Ã£o do recebÃ­vel, como data limite",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "charge_id",
            "in": "query",
            "description": "Filtro pelo cÃ³digo da cobranÃ§a",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "recipient_id",
            "in": "query",
            "description": "Filtro pelo cÃ³digo do recebedor",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "split_id",
            "in": "query",
            "description": "Filtro pelo identificador da regra de split",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "id",
            "in": "query",
            "description": "Filtro pelo identificador do recebÃ­vel",
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
                  "CobranÃ§as pÃ³s 01/07/23": {
                    "value": "{\n    \"data\": [\n        {\n            \"id\": 4304241393,\n            \"status\": \"waiting_funds\",\n            \"amount\": 3090,\n            \"fee\": 155,\n            \"anticipation_fee\": 0,\n            \"fraud_coverage_fee\": 0,\n            \"installment\": 1,\n            \"gateway_id\": 23879573,\n            \"charge_id\": \"ch_xj9w8g8CEdhOX0BM\",\n            \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n            \"payment_date\": \"2023-08-03T03:00:00Z\",\n            \"type\": \"credit\",\n            \"payment_method\": \"credit_card\",\n            \"accrual_at\": \"2023-07-03T13:06:21Z\",\n            \"created_at\": \"2023-07-03T13:06:22Z\"\n        },\n        {\n            \"id\": 4304239592,\n            \"status\": \"waiting_funds\",\n            \"amount\": 3798,\n            \"fee\": 190,\n            \"anticipation_fee\": 0,\n            \"fraud_coverage_fee\": 0,\n            \"installment\": 2,\n            \"gateway_id\": 23876873,\n            \"charge_id\": \"ch_mz7LoQhYpidoJO5B\",\n            \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n            \"payment_date\": \"2023-09-04T03:00:00Z\",\n            \"type\": \"credit\",\n            \"payment_method\": \"credit_card\",\n            \"accrual_at\": \"2023-07-03T05:34:28Z\",\n            \"created_at\": \"2023-07-03T05:34:35Z\"\n        },\n        {\n            \"id\": 4304239591,\n            \"status\": \"waiting_funds\",\n            \"amount\": 3798,\n            \"fee\": 190,\n            \"anticipation_fee\": 0,\n            \"fraud_coverage_fee\": 0,\n            \"installment\": 3,\n            \"gateway_id\": 23876873,\n            \"charge_id\": \"ch_mz7LoQhYpidoJO5B\",\n            \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n            \"payment_date\": \"2023-10-03T03:00:00Z\",\n            \"type\": \"credit\",\n            \"payment_method\": \"credit_card\",\n            \"accrual_at\": \"2023-07-03T05:34:28Z\",\n            \"created_at\": \"2023-07-03T05:34:35Z\"\n        },\n        {\n            \"id\": 4304239590,\n            \"status\": \"waiting_funds\",\n            \"amount\": 3798,\n            \"fee\": 190,\n            \"anticipation_fee\": 0,\n            \"fraud_coverage_fee\": 0,\n            \"installment\": 4,\n            \"gateway_id\": 23876873,\n            \"charge_id\": \"ch_mz7LoQhYpidoJO5B\",\n            \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n            \"payment_date\": \"2023-11-01T03:00:00Z\",\n            \"type\": \"credit\",\n            \"payment_method\": \"credit_card\",\n            \"accrual_at\": \"2023-07-03T05:34:28Z\",\n            \"created_at\": \"2023-07-03T05:34:35Z\"\n        },\n        {\n            \"id\": 4304239589,\n            \"status\": \"waiting_funds\",\n            \"amount\": 3798,\n            \"fee\": 190,\n            \"anticipation_fee\": 0,\n            \"fraud_coverage_fee\": 0,\n            \"installment\": 5,\n            \"gateway_id\": 23876873,\n            \"charge_id\": \"ch_mz7LoQhYpidoJO5B\",\n            \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n            \"payment_date\": \"2023-12-01T03:00:00Z\",\n            \"type\": \"credit\",\n            \"payment_method\": \"credit_card\",\n            \"accrual_at\": \"2023-07-03T05:34:28Z\",\n            \"created_at\": \"2023-07-03T05:34:35Z\"\n        }\n    ],\n    \"paging\": {}\n}"
                  },
                  "CobranÃ§as prÃ© 01/07/23": {
                    "value": "{\n    \"data\": [\n        {\n            \"id\": 4304198148,\n            \"status\": \"waiting_funds\",\n            \"amount\": 927,\n            \"fee\": 0,\n            \"anticipation_fee\": 0,\n            \"fraud_coverage_fee\": 0,\n            \"installment\": 1,\n            \"gateway_id\": 23833759,\n            \"split_id\": \"sr_cljh854vb03tf019thoelps6p\",\n            \"recipient_id\": \"re_clfj3jwyj051k019tyakiduuc\",\n            \"payment_date\": \"2023-08-01T03:00:00Z\",\n            \"type\": \"credit\",\n            \"payment_method\": \"credit_card\",\n            \"accrual_at\": \"2023-06-29T14:11:52Z\",\n            \"created_at\": \"2023-06-29T14:11:56Z\"\n        },\n        {\n            \"id\": 4304198147,\n            \"status\": \"waiting_funds\",\n            \"amount\": 2163,\n            \"fee\": 155,\n            \"anticipation_fee\": 0,\n            \"fraud_coverage_fee\": 0,\n            \"installment\": 1,\n            \"gateway_id\": 23833759,\n            \"split_id\": \"sr_cljh854vb03te019tkteg20h9\",\n            \"recipient_id\": \"rp_9zD2AbZURUkA83bR\",\n            \"payment_date\": \"2023-08-01T03:00:00Z\",\n            \"type\": \"credit\",\n            \"payment_method\": \"credit_card\",\n            \"accrual_at\": \"2023-06-29T14:11:52Z\",\n            \"created_at\": \"2023-06-29T14:11:56Z\"\n        },\n        {\n            \"id\": 4304196046,\n            \"status\": \"waiting_funds\",\n            \"amount\": 3798,\n            \"fee\": 190,\n            \"anticipation_fee\": 0,\n            \"fraud_coverage_fee\": 0,\n            \"installment\": 2,\n            \"gateway_id\": 23828771,\n            \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n            \"payment_date\": \"2023-08-29T03:00:00Z\",\n            \"type\": \"credit\",\n            \"payment_method\": \"credit_card\",\n            \"accrual_at\": \"2023-06-29T04:04:33Z\",\n            \"created_at\": \"2023-06-29T04:04:37Z\"\n        },\n        {\n            \"id\": 4304196045,\n            \"status\": \"waiting_funds\",\n            \"amount\": 3798,\n            \"fee\": 190,\n            \"anticipation_fee\": 0,\n            \"fraud_coverage_fee\": 0,\n            \"installment\": 3,\n            \"gateway_id\": 23828771,\n            \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n            \"payment_date\": \"2023-09-28T03:00:00Z\",\n            \"type\": \"credit\",\n            \"payment_method\": \"credit_card\",\n            \"accrual_at\": \"2023-06-29T04:04:33Z\",\n            \"created_at\": \"2023-06-29T04:04:37Z\"\n        },\n        {\n            \"id\": 4304196044,\n            \"status\": \"waiting_funds\",\n            \"amount\": 3798,\n            \"fee\": 190,\n            \"anticipation_fee\": 0,\n            \"fraud_coverage_fee\": 0,\n            \"installment\": 4,\n            \"gateway_id\": 23828771,\n            \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n            \"payment_date\": \"2023-10-30T03:00:00Z\",\n            \"type\": \"credit\",\n            \"payment_method\": \"credit_card\",\n            \"accrual_at\": \"2023-06-29T04:04:33Z\",\n            \"created_at\": \"2023-06-29T04:04:37Z\"\n        }\n    ],\n    \"paging\": {}\n}"
                  }
                },
                "schema": {
                  "oneOf": [
                    {
                      "title": "CobranÃ§as pÃ³s 01/07/23",
                      "type": "object",
                      "properties": {
                        "data": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "integer",
                                "example": 4304241393,
                                "default": 0
                              },
                              "status": {
                                "type": "string",
                                "example": "waiting_funds"
                              },
                              "amount": {
                                "type": "integer",
                                "example": 3090,
                                "default": 0
                              },
                              "fee": {
                                "type": "integer",
                                "example": 155,
                                "default": 0
                              },
                              "anticipation_fee": {
                                "type": "integer",
                                "example": 0,
                                "default": 0
                              },
                              "installment": {
                                "type": "integer",
                                "example": 1,
                                "default": 0
                              },
                              "charge_id": {
                                "type": "string",
                                "example": "ch_xj9w8g8CEdhOX0BM"
                              },
                              "recipient_id": {
                                "type": "string",
                                "example": "re_cjlnpqrq0006vn56e1nig0tcv"
                              },
                              "payment_date": {
                                "type": "string",
                                "example": "2023-08-03T03:00:00Z"
                              },
                              "type": {
                                "type": "string",
                                "example": "credit"
                              },
                              "payment_method": {
                                "type": "string",
                                "example": "credit_card"
                              },
                              "accrual_at": {
                                "type": "string",
                                "example": "2023-07-03T13:06:21Z"
                              },
                              "created_at": {
                                "type": "string",
                                "example": "2023-07-03T13:06:22Z"
                              }
                            }
                          }
                        },
                        "paging": {
                          "type": "object",
                          "properties": {}
                        }
                      }
                    },
                    {
                      "title": "CobranÃ§as prÃ© 01/07/23",
                      "type": "object",
                      "properties": {
                        "data": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "integer",
                                "example": 4304198148,
                                "default": 0
                              },
                              "status": {
                                "type": "string",
                                "example": "waiting_funds"
                              },
                              "amount": {
                                "type": "integer",
                                "example": 927,
                                "default": 0
                              },
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
                              "installment": {
                                "type": "integer",
                                "example": 1,
                                "default": 0
                              },
                              "gateway_id": {
                                "type": "integer",
                                "example": 23833759,
                                "default": 0
                              },
                              "split_id": {
                                "type": "string",
                                "example": "sr_cljh854vb03tf019thoelps6p"
                              },
                              "recipient_id": {
                                "type": "string",
                                "example": "re_clfj3jwyj051k019tyakiduuc"
                              },
                              "payment_date": {
                                "type": "string",
                                "example": "2023-08-01T03:00:00Z"
                              },
                              "type": {
                                "type": "string",
                                "example": "credit"
                              },
                              "payment_method": {
                                "type": "string",
                                "example": "credit_card"
                              },
                              "accrual_at": {
                                "type": "string",
                                "example": "2023-06-29T14:11:52Z"
                              },
                              "created_at": {
                                "type": "string",
                                "example": "2023-06-29T14:11:56Z"
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
                  ]
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