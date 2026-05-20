# Listar assinaturas

Este recurso permite listar as assinaturas. Pode ser utilizados alguns parâmetros como filtro da listagem.

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
    "/subscriptions": {
      "get": {
        "summary": "Listar assinaturas",
        "description": "Este recurso permite listar as assinaturas. Pode ser utilizados alguns parâmetros como filtro da listagem.",
        "operationId": "listar-assinaturas-1",
        "parameters": [
          {
            "name": "status",
            "in": "query",
            "description": "Status da assinatura.<br>Valores possÃ­veis: **active**, **canceled** ou **future**",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "code",
            "in": "query",
            "description": "CÃ³digo da assinatura no sistema da loja. MÃ¡x.: 52 caracteres",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "billing_type",
            "in": "query",
            "description": "Tipo de cobranÃ§a.<br>Valores possÃ­veis: **prepaid**, **postpaid **ou **exact_day**.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "customer_id",
            "in": "query",
            "description": "CÃ³digo do cliente. [Saiba mais sobre clientes](https://docs.pagar.me/reference/clientes-1).",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "plan_id",
            "in": "query",
            "description": "CÃ³digo do plano.<br>Formato: `plan_XXXXXXXXXXXXXXXX`.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "card_id",
            "in": "query",
            "description": "CÃ³digo do cartÃ£o.<br>Formato: `card_XXXXXXXXXXXXXXXX`.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "next_billing_since",
            "in": "query",
            "description": "Data de inÃ­cio da prÃ³xima data de cobranÃ§a.",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "next_billing_until",
            "in": "query",
            "description": "Data final de prÃ³xima data de cobranÃ§a.",
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
            "description": "PÃ¡gina atual",
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
                    "value": "{\n  \"data\": [\n    {\n      \"id\": \"sub_05jkdIfGYPfN26mI\",\n      \"payment_method\": \"credit_card\",\n      \"currency\": \"BRL\",\n      \"interval\": \"month\",\n      \"gateway_affiliation_id\": \"C56A4180-65AA-42EC-A945-5FD21DEC0538\",\n      \"boleto_due_days\": 5,\n      \"minimum_price\": 10000,\n      \"interval_count\": 3,\n      \"billing_type\": \"prepaid\",\n      \"current_cycle\": {\n        \"start_at\": \"2016-07-19T00:00:00Z\",\n        \"end_at\": \"2016-10-18T23:59:59Z\"\n      },\n      \"next_billing_at\": \"2016-10-19T00:00:00Z\",\n      \"installments\": 3,\n      \"customer\": {\n        \"id\": \"cus_017228NmffGbA3d4\",\n        \"name\": \"Luke Skywalker\",\n        \"email\": \"lskywalker@r2d2.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2016-07-12T18:25:40Z\",\n        \"updated_at\": \"2016-07-12T18:25:40Z\"\n      },\n      \"credit_card\": {\n        \"id\": \"card_Mome2meGz4PDNQbX\",\n        \"holder_name\": \"Luke Skywalker\",\n        \"masked_number\": \"402400******4251\",\n        \"exp_month\": 6,\n        \"exp_year\": 17,\n        \"expired\": false,\n        \"status\": \"active\",\n        \"created_at\": \"2016-07-12T18:25:40Z\",\n        \"update_at\": \"2016-07-12T18:25:40Z\",\n        \"billing_address\": {\n          \"line_1\": \"10880, Malibu Point, Malibu Central\",\n          \"zip_code\": \"90265\",\n          \"city\": \"Malibu\",\n          \"state\": \"CA\",\n          \"country\": \"US\"\n        }\n      },\n      \"discounts\": [\n        {\n          \"id\": \"si_k2zpBDMsOs0fDfHe\",\n          \"cycles\": 3,\n          \"value\": 10,\n          \"discount_type\": \"percentage\",\n          \"created_at\": \"2016-07-12T18:25:40Z\"\n        }\n      ],\n      \"increments\": [\n        {\n          \"id\": \"inc_IYzpxgjsOs0fDIoP\",\n          \"cycles\": 2,\n          \"value\": 20,\n          \"discount_type\": \"percentage\",\n          \"created_at\": \"2016-07-12T18:25:40Z\"\n        }\n      ],\n      \"items\": [\n        {\n          \"id\": \"si_B6555Riyq9lj6klS\",\n          \"description\": \"MusculaÃ§Ã£o\",\n          \"quantity\": 1,\n          \"pricing_scheme\": {\n            \"price\": 18990,\n            \"scheme_type\": \"unit\"\n          },\n          \"status\": \"active\",\n          \"created_at\": \"2016-07-12T18:25:40Z\",\n          \"updated_at\": \"2016-07-12T18:25:40Z\"\n        }\n      ],\n      \"status\": \"active\",\n      \"created_at\": \"2016-07-12T18:25:40Z\",\n      \"updated_at\": \"2016-07-12T18:25:40Z\",\n      \"metadata\": {\n        \"id\": \"my_subscription_id\"\n      }\n    }\n  ],\n  \"paging\": {\n    \"total_items\": 1,\n    \"current_page\": 1,\n    \"total_pages\": 1\n  }\n}"
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
                            "example": "sub_05jkdIfGYPfN26mI"
                          },
                          "payment_method": {
                            "type": "string",
                            "example": "credit_card"
                          },
                          "currency": {
                            "type": "string",
                            "example": "BRL"
                          },
                          "interval": {
                            "type": "string",
                            "example": "month"
                          },
                          "gateway_affiliation_id": {
                            "type": "string",
                            "example": "C56A4180-65AA-42EC-A945-5FD21DEC0538"
                          },
                          "boleto_due_days": {
                            "type": "integer",
                            "example": 5,
                            "default": 0
                          },
                          "minimum_price": {
                            "type": "integer",
                            "example": 10000,
                            "default": 0
                          },
                          "interval_count": {
                            "type": "integer",
                            "example": 3,
                            "default": 0
                          },
                          "billing_type": {
                            "type": "string",
                            "example": "prepaid"
                          },
                          "current_cycle": {
                            "type": "object",
                            "properties": {
                              "start_at": {
                                "type": "string",
                                "example": "2016-07-19T00:00:00Z"
                              },
                              "end_at": {
                                "type": "string",
                                "example": "2016-10-18T23:59:59Z"
                              }
                            }
                          },
                          "next_billing_at": {
                            "type": "string",
                            "example": "2016-10-19T00:00:00Z"
                          },
                          "installments": {
                            "type": "integer",
                            "example": 3,
                            "default": 0
                          },
                          "customer": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "cus_017228NmffGbA3d4"
                              },
                              "name": {
                                "type": "string",
                                "example": "Luke Skywalker"
                              },
                              "email": {
                                "type": "string",
                                "example": "lskywalker@r2d2.com"
                              },
                              "delinquent": {
                                "type": "boolean",
                                "example": false,
                                "default": true
                              },
                              "created_at": {
                                "type": "string",
                                "example": "2016-07-12T18:25:40Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2016-07-12T18:25:40Z"
                              }
                            }
                          },
                          "credit_card": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "card_Mome2meGz4PDNQbX"
                              },
                              "holder_name": {
                                "type": "string",
                                "example": "Luke Skywalker"
                              },
                              "masked_number": {
                                "type": "string",
                                "example": "402400******4251"
                              },
                              "exp_month": {
                                "type": "integer",
                                "example": 6,
                                "default": 0
                              },
                              "exp_year": {
                                "type": "integer",
                                "example": 17,
                                "default": 0
                              },
                              "expired": {
                                "type": "boolean",
                                "example": false,
                                "default": true
                              },
                              "status": {
                                "type": "string",
                                "example": "active"
                              },
                              "created_at": {
                                "type": "string",
                                "example": "2016-07-12T18:25:40Z"
                              },
                              "update_at": {
                                "type": "string",
                                "example": "2016-07-12T18:25:40Z"
                              },
                              "billing_address": {
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
                              }
                            }
                          },
                          "discounts": {
                            "type": "array",
                            "items": {
                              "type": "object",
                              "properties": {
                                "id": {
                                  "type": "string",
                                  "example": "si_k2zpBDMsOs0fDfHe"
                                },
                                "cycles": {
                                  "type": "integer",
                                  "example": 3,
                                  "default": 0
                                },
                                "value": {
                                  "type": "integer",
                                  "example": 10,
                                  "default": 0
                                },
                                "discount_type": {
                                  "type": "string",
                                  "example": "percentage"
                                },
                                "created_at": {
                                  "type": "string",
                                  "example": "2016-07-12T18:25:40Z"
                                }
                              }
                            }
                          },
                          "increments": {
                            "type": "array",
                            "items": {
                              "type": "object",
                              "properties": {
                                "id": {
                                  "type": "string",
                                  "example": "inc_IYzpxgjsOs0fDIoP"
                                },
                                "cycles": {
                                  "type": "integer",
                                  "example": 2,
                                  "default": 0
                                },
                                "value": {
                                  "type": "integer",
                                  "example": 20,
                                  "default": 0
                                },
                                "discount_type": {
                                  "type": "string",
                                  "example": "percentage"
                                },
                                "created_at": {
                                  "type": "string",
                                  "example": "2016-07-12T18:25:40Z"
                                }
                              }
                            }
                          },
                          "items": {
                            "type": "array",
                            "items": {
                              "type": "object",
                              "properties": {
                                "id": {
                                  "type": "string",
                                  "example": "si_B6555Riyq9lj6klS"
                                },
                                "description": {
                                  "type": "string",
                                  "example": "MusculaÃ§Ã£o"
                                },
                                "quantity": {
                                  "type": "integer",
                                  "example": 1,
                                  "default": 0
                                },
                                "pricing_scheme": {
                                  "type": "object",
                                  "properties": {
                                    "price": {
                                      "type": "integer",
                                      "example": 18990,
                                      "default": 0
                                    },
                                    "scheme_type": {
                                      "type": "string",
                                      "example": "unit"
                                    }
                                  }
                                },
                                "status": {
                                  "type": "string",
                                  "example": "active"
                                },
                                "created_at": {
                                  "type": "string",
                                  "example": "2016-07-12T18:25:40Z"
                                },
                                "updated_at": {
                                  "type": "string",
                                  "example": "2016-07-12T18:25:40Z"
                                }
                              }
                            }
                          },
                          "status": {
                            "type": "string",
                            "example": "active"
                          },
                          "created_at": {
                            "type": "string",
                            "example": "2016-07-12T18:25:40Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2016-07-12T18:25:40Z"
                          },
                          "metadata": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "my_subscription_id"
                              }
                            }
                          }
                        }
                      }
                    },
                    "paging": {
                      "type": "object",
                      "properties": {
                        "total_items": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
                        },
                        "current_page": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
                        },
                        "total_pages": {
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