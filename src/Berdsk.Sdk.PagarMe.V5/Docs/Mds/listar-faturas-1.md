# Listar faturas

Este recurso permite listar os descontos associados a uma assinatura. Pode ser utilizados alguns parÃ¢metros como filtro
da listagem.

> ðŸ“˜ PaginaÃ§Ã£o
>
> Este recurso utiliza **paginaÃ§Ã£o** para manipulaÃ§Ã£o da listagem
> resultante. [Saiba mais sobre paginaÃ§Ã£o](https://docs.pagar.me/reference/pagina%C3%A7%C3%A3o-1).

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
    "/invoices": {
      "get": {
        "summary": "Listar faturas",
        "description": "Este recurso permite listar os descontos associados a uma assinatura.  Pode ser utilizados alguns parÃ¢metros como filtro da listagem.",
        "operationId": "listar-faturas-1",
        "parameters": [
          {
            "name": "status",
            "in": "query",
            "description": "Status das faturas. Valores possÃ­veis: **pending**, **paid**, **canceled**, **scheduled** ou **failed**",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "customer_id",
            "in": "query",
            "description": "CÃ³digo do cliente.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "subscription_id",
            "in": "query",
            "description": "CÃ³digo da fatura.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "due_since",
            "in": "query",
            "description": "Data de inÃ­cio do perÃ­odo de vencimento a ser listado.",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "due_until",
            "in": "query",
            "description": "Data final do perÃ­odo de vencimento a ser listado.",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "created_since",
            "in": "query",
            "description": "Data de inÃ­cio do perÃ­odo de criaÃ§Ã£o a ser listado.",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "created_until",
            "in": "query",
            "description": "Data final do perÃ­odo de criaÃ§Ã£o a ser listado.",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "page",
            "in": "query",
            "description": "PÃ¡gina atual.",
            "schema": {
              "type": "integer",
              "format": "int32",
              "default": 1
            }
          },
          {
            "name": "size",
            "in": "query",
            "description": "Quantidade de itens por pÃ¡gina.",
            "schema": {
              "type": "integer",
              "format": "int32",
              "default": 10
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
                    "value": "{\n  \"data\": [\n    {\n      \"id\": \"in_DnQj6J8iWhEg0MrK\",\n      \"code\": \"0E6RC91AE1\",\n      \"url\": \"/invoices/in_DnQj6J8iWhEg0MrK\",\n      \"amount\": 1490,\n      \"status\": \"paid\",\n      \"payment_method\": \"credit_card\",\n      \"due_at\": \"2017-04-04T00:00:00Z\",\n      \"created_at\": \"2017-04-04T15:54:46Z\",\n      \"items\": [\n        {\n          \"name\":\"Nome - teste\",\n          \"amount\": 1490,\n          \"quantity\": 1,\n          \"description\": \"Bola\"\n        }\n      ],\n      \"customer\": {\n        \"id\": \"cus_J4wRXJ0U6ytZrpAx\",\n        \"name\": \"Tony Star8k\",\n        \"email\": \"tstark@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2016-09-28T21:04:37Z\",\n        \"updated_at\": \"2017-04-04T15:08:20Z\"\n      },\n      \"subscription\": {\n        \"id\": \"sub_49O5RwPh5sl0wyqM\",\n        \"code\": \"G2X5F99FXX\",\n        \"start_at\": \"2017-04-04T00:00:00Z\",\n        \"interval\": \"month\",\n        \"interval_count\": 1,\n        \"billing_type\": \"postpaid\",\n        \"next_billing_at\": \"2017-05-04T00:00:00Z\",\n        \"payment_method\": \"credit_card\",\n        \"currency\": \"BRL\",\n        \"statement_descriptor\": \"Spotify\",\n        \"installments\": 1,\n        \"status\": \"active\",\n        \"created_at\": \"2017-04-04T15:54:19Z\",\n        \"updated_at\": \"2017-04-04T15:54:19Z\"\n      },\n      \"cycle\": {\n        \"id\": \"cycle_O6vXjrvUbecMjpgq\",\n        \"start_at\": \"2017-04-04T00:00:00Z\",\n        \"end_at\": \"2017-05-03T23:59:59Z\",\n        \"billing_at\": \"2017-05-04T00:00:00Z\"\n      },\n      \"charge\": {\n        \"id\": \"ch_1DaVYVQCds28rOm3\",\n        \"code\": \"G2X5F99FXX-01\",\n        \"gateway_id\": \"1e3a21f7-ad65-4ad0-a68c-3eb37e8115c9\",\n        \"amount\": 1490,\n        \"status\": \"paid\",\n        \"currency\": \"BRL\",\n        \"payment_method\": \"credit_card\",\n        \"due_at\": \"2017-04-04T00:00:00Z\",\n        \"paid_at\": \"2017-04-04T15:54:49Z\",\n        \"created_at\": \"2017-04-04T15:54:46Z\",\n        \"updated_at\": \"2017-04-04T15:54:46Z\"\n      }\n    }\n  ],\n  \"paging\": {\n    \"total\": 1\n  }\n}"
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
                            "example": "in_DnQj6J8iWhEg0MrK"
                          },
                          "code": {
                            "type": "string",
                            "example": "0E6RC91AE1"
                          },
                          "url": {
                            "type": "string",
                            "example": "/invoices/in_DnQj6J8iWhEg0MrK"
                          },
                          "amount": {
                            "type": "integer",
                            "example": 1490,
                            "default": 0
                          },
                          "status": {
                            "type": "string",
                            "example": "paid"
                          },
                          "payment_method": {
                            "type": "string",
                            "example": "credit_card"
                          },
                          "due_at": {
                            "type": "string",
                            "example": "2017-04-04T00:00:00Z"
                          },
                          "created_at": {
                            "type": "string",
                            "example": "2017-04-04T15:54:46Z"
                          },
                          "items": {
                            "type": "array",
                            "items": {
                              "type": "object",
                              "properties": {
                                "name": {
                                  "type": "string",
                                  "example": "Nome - teste"
                                },
                                "amount": {
                                  "type": "integer",
                                  "example": 1490,
                                  "default": 0
                                },
                                "quantity": {
                                  "type": "integer",
                                  "example": 1,
                                  "default": 0
                                },
                                "description": {
                                  "type": "string",
                                  "example": "Bola"
                                }
                              }
                            }
                          },
                          "customer": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "cus_J4wRXJ0U6ytZrpAx"
                              },
                              "name": {
                                "type": "string",
                                "example": "Tony Star8k"
                              },
                              "email": {
                                "type": "string",
                                "example": "tstark@avengers.com"
                              },
                              "delinquent": {
                                "type": "boolean",
                                "example": false,
                                "default": true
                              },
                              "created_at": {
                                "type": "string",
                                "example": "2016-09-28T21:04:37Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2017-04-04T15:08:20Z"
                              }
                            }
                          },
                          "subscription": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "sub_49O5RwPh5sl0wyqM"
                              },
                              "code": {
                                "type": "string",
                                "example": "G2X5F99FXX"
                              },
                              "start_at": {
                                "type": "string",
                                "example": "2017-04-04T00:00:00Z"
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
                                "example": "postpaid"
                              },
                              "next_billing_at": {
                                "type": "string",
                                "example": "2017-05-04T00:00:00Z"
                              },
                              "payment_method": {
                                "type": "string",
                                "example": "credit_card"
                              },
                              "currency": {
                                "type": "string",
                                "example": "BRL"
                              },
                              "statement_descriptor": {
                                "type": "string",
                                "example": "Spotify"
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
                                "example": "2017-04-04T15:54:19Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2017-04-04T15:54:19Z"
                              }
                            }
                          },
                          "cycle": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "cycle_O6vXjrvUbecMjpgq"
                              },
                              "start_at": {
                                "type": "string",
                                "example": "2017-04-04T00:00:00Z"
                              },
                              "end_at": {
                                "type": "string",
                                "example": "2017-05-03T23:59:59Z"
                              },
                              "billing_at": {
                                "type": "string",
                                "example": "2017-05-04T00:00:00Z"
                              }
                            }
                          },
                          "charge": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "ch_1DaVYVQCds28rOm3"
                              },
                              "code": {
                                "type": "string",
                                "example": "G2X5F99FXX-01"
                              },
                              "gateway_id": {
                                "type": "string",
                                "example": "1e3a21f7-ad65-4ad0-a68c-3eb37e8115c9"
                              },
                              "amount": {
                                "type": "integer",
                                "example": 1490,
                                "default": 0
                              },
                              "status": {
                                "type": "string",
                                "example": "paid"
                              },
                              "currency": {
                                "type": "string",
                                "example": "BRL"
                              },
                              "payment_method": {
                                "type": "string",
                                "example": "credit_card"
                              },
                              "due_at": {
                                "type": "string",
                                "example": "2017-04-04T00:00:00Z"
                              },
                              "paid_at": {
                                "type": "string",
                                "example": "2017-04-04T15:54:49Z"
                              },
                              "created_at": {
                                "type": "string",
                                "example": "2017-04-04T15:54:46Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2017-04-04T15:54:46Z"
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
                          "example": 1,
                          "default": 0
                        }
                      }
                    }
                  }
                }
              }
            }
          },
          "401": {
            "description": "401",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"message\": \"Authorization has been denied for this request.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Authorization has been denied for this request."
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