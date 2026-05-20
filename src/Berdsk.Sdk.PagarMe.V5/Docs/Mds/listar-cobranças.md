# Listar cobranÃ§as

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
    "/charges": {
      "get": {
        "summary": "Listar cobranÃ§as",
        "description": "",
        "operationId": "listar-cobranÃ§as",
        "parameters": [
          {
            "name": "code",
            "in": "query",
            "description": "CÃ³digo de referÃªncia da cobranÃ§a no sistema da loja",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "status",
            "in": "query",
            "description": "Status da cobranÃ§a. Valores possÃ­veis: **pending**, **paid**, **canceled**, **processing**, **failed**, **overpaid** ou **underpaid**",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "payment_method",
            "in": "query",
            "description": "Meio de pagamento. Valores possÃ­veis: **credit_card**, **boleto**, **bank_transfer**, **safetypay** ou **voucher**",
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
            "name": "order_id",
            "in": "query",
            "description": "CÃ³digo do pedido.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "created_since",
            "in": "query",
            "description": "Data de inÃ­cio do perÃ­odo de criaÃ§Ã£o a ser listado.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "created_until",
            "in": "query",
            "description": "Data de final do perÃ­odo de criaÃ§Ã£o a ser listado.",
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
                    "value": "{\n  \"data\": [\n    {\n      \"id\": \"ch_NLJjZ99IoHXKgk38\",\n      \"code\": \"N1OJFMGA0M\",\n      \"amount\": 1490,\n      \"paid_amount\": 1490,\n      \"status\": \"paid\",\n      \"currency\": \"BRL\",\n      \"payment_method\": \"credit_card\",\n      \"paid_at\": \"2019-01-22T14:49:45Z\",\n      \"created_at\": \"2019-01-22T14:49:44Z\",\n      \"updated_at\": \"2019-01-22T14:49:44Z\",\n      \"customer\": {\n        \"id\": \"cus_PYwJvWgOTmiqvW8m\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"toinhodalua@nasa.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2019-01-18T11:50:37Z\",\n        \"updated_at\": \"2019-01-18T15:46:38Z\",\n        \"phones\": {}\n      },\n      \"last_transaction\": {\n        \"id\": \"tran_DvedVaeSWLfKDwXj\",\n        \"transaction_type\": \"credit_card\",\n        \"funding_source\": \"prepaid\",\n        \"gateway_id\": \"775844a3-5c04-4ad2-a8d7-86cdcb42e8e7\",\n        \"amount\": 1490,\n        \"status\": \"captured\",\n        \"success\": true,\n        \"installments\": 1,\n        \"statement_descriptor\": \"AVENGERS\",\n        \"acquirer_tid\": \"30e4f16b-5cf9-4173-aa0b-756cbbd5af35\",\n        \"acquirer_nsu\": \"30e4f16b-5cf9-4173-aa0b-756cbbd5af35\",\n        \"acquirer_auth_code\": \"859\",\n        \"acquirer_message\": \"TransaÃ§Ã£o capturada com sucesso\",\n        \"acquirer_return_code\": \"00\",\n        \"operation_type\": \"auth_and_capture\",\n        \"card\": {\n          \"id\": \"card_jdK2O53TqfnxwRDY\",\n          \"first_six_digits\": \"400000\",\n          \"last_four_digits\": \"0010\",\n          \"brand\": \"Visa\",\n          \"holder_name\": \"Tony Stark\",\n          \"exp_month\": 1,\n          \"exp_year\": 2030,\n          \"status\": \"active\",\n          \"type\": \"credit\",\n          \"created_at\": \"2019-01-18T12:25:41Z\",\n          \"updated_at\": \"2019-01-22T14:39:01Z\",\n          \"billing_address\": {\n            \"zip_code\": \"90265\",\n            \"city\": \"Malibu\",\n            \"state\": \"CA\",\n            \"country\": \"US\",\n            \"line_1\": \"10880, Malibu Point, Malibu Central\"\n          }\n        },\n        \"created_at\": \"2019-01-22T14:49:44Z\",\n        \"updated_at\": \"2019-01-22T14:49:44Z\",\n        \"gateway_response\": {\n          \"code\": \"200\",\n          \"errors\": []\n        }\n      },\n      \"metadata\": {\n        \"code\": \"123\"\n      }\n    },\n    {\n      \"id\": \"ch_Vm6ewLmiY1cK4XQP\",\n      \"code\": \"M5JLAW0I6R\",\n      \"amount\": 1490,\n      \"paid_amount\": 1490,\n      \"status\": \"paid\",\n      \"currency\": \"BRL\",\n      \"payment_method\": \"credit_card\",\n      \"paid_at\": \"2019-01-22T14:49:41Z\",\n      \"created_at\": \"2019-01-22T14:49:40Z\",\n      \"updated_at\": \"2019-01-22T14:49:40Z\",\n      \"customer\": {\n        \"id\": \"cus_PYwJvWgOTmiqvW8m\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"toinhodalua@nasa.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2019-01-18T11:50:37Z\",\n        \"updated_at\": \"2019-01-18T15:46:38Z\",\n        \"phones\": {}\n      },\n      \"last_transaction\": {\n        \"id\": \"tran_N9ZaxANIVdHz1JPY\",\n        \"transaction_type\": \"credit_card\",\n        \"funding_source\": \"credit\",\n        \"gateway_id\": \"b4fe6901-7cb3-4e10-b1c5-5d606281c030\",\n        \"amount\": 1490,\n        \"status\": \"captured\",\n        \"success\": true,\n        \"installments\": 1,\n        \"statement_descriptor\": \"AVENGERS\",\n        \"acquirer_tid\": \"2117421a-bb5f-4181-83db-31f2b06d78e8\",\n        \"acquirer_nsu\": \"2117421a-bb5f-4181-83db-31f2b06d78e8\",\n        \"acquirer_auth_code\": \"481\",\n        \"acquirer_message\": \"TransaÃ§Ã£o capturada com sucesso\",\n        \"acquirer_return_code\": \"00\",\n        \"operation_type\": \"auth_and_capture\",\n        \"card\": {\n          \"id\": \"card_jdK2O53TqfnxwRDY\",\n          \"first_six_digits\": \"400000\",\n          \"last_four_digits\": \"0010\",\n          \"brand\": \"Visa\",\n          \"holder_name\": \"Tony Stark\",\n          \"exp_month\": 1,\n          \"exp_year\": 2020,\n          \"status\": \"active\",\n          \"type\": \"credit\",\n          \"created_at\": \"2019-01-18T12:25:41Z\",\n          \"updated_at\": \"2019-01-22T14:39:01Z\",\n          \"billing_address\": {\n            \"zip_code\": \"90265\",\n            \"city\": \"Malibu\",\n            \"state\": \"CA\",\n            \"country\": \"US\",\n            \"line_1\": \"10880, Malibu Point, Malibu Central\"\n          }\n        },\n        \"created_at\": \"2019-01-22T14:49:41Z\",\n        \"updated_at\": \"2019-01-22T14:49:41Z\",\n        \"gateway_response\": {\n          \"code\": \"200\",\n          \"errors\": []\n        }\n      },\n      \"metadata\": {\n        \"code\": \"123\"\n      }\n    }\n  ],\n  \"paging\": {\n    \"total\": 80,\n    \"next\": \"https://api.pagar.me/core/v1/charges?page=2&size=2\"\n  }\n}"
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
                            "example": "ch_NLJjZ99IoHXKgk38"
                          },
                          "code": {
                            "type": "string",
                            "example": "N1OJFMGA0M"
                          },
                          "amount": {
                            "type": "integer",
                            "example": 1490,
                            "default": 0
                          },
                          "paid_amount": {
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
                          "paid_at": {
                            "type": "string",
                            "example": "2019-01-22T14:49:45Z"
                          },
                          "created_at": {
                            "type": "string",
                            "example": "2019-01-22T14:49:44Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2019-01-22T14:49:44Z"
                          },
                          "customer": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "cus_PYwJvWgOTmiqvW8m"
                              },
                              "name": {
                                "type": "string",
                                "example": "Tony Stark"
                              },
                              "email": {
                                "type": "string",
                                "example": "toinhodalua@nasa.com"
                              },
                              "delinquent": {
                                "type": "boolean",
                                "example": false,
                                "default": true
                              },
                              "created_at": {
                                "type": "string",
                                "example": "2019-01-18T11:50:37Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2019-01-18T15:46:38Z"
                              },
                              "phones": {
                                "type": "object",
                                "properties": {}
                              }
                            }
                          },
                          "last_transaction": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "tran_DvedVaeSWLfKDwXj"
                              },
                              "transaction_type": {
                                "type": "string",
                                "example": "credit_card"
                              },
                              "funding_source": {
                                "type": "string",
                                "example": "prepaid"
                              },
                              "gateway_id": {
                                "type": "string",
                                "example": "775844a3-5c04-4ad2-a8d7-86cdcb42e8e7"
                              },
                              "amount": {
                                "type": "integer",
                                "example": 1490,
                                "default": 0
                              },
                              "status": {
                                "type": "string",
                                "example": "captured"
                              },
                              "success": {
                                "type": "boolean",
                                "example": true,
                                "default": true
                              },
                              "installments": {
                                "type": "integer",
                                "example": 1,
                                "default": 0
                              },
                              "statement_descriptor": {
                                "type": "string",
                                "example": "AVENGERS"
                              },
                              "acquirer_tid": {
                                "type": "string",
                                "example": "30e4f16b-5cf9-4173-aa0b-756cbbd5af35"
                              },
                              "acquirer_nsu": {
                                "type": "string",
                                "example": "30e4f16b-5cf9-4173-aa0b-756cbbd5af35"
                              },
                              "acquirer_auth_code": {
                                "type": "string",
                                "example": "859"
                              },
                              "acquirer_message": {
                                "type": "string",
                                "example": "TransaÃ§Ã£o capturada com sucesso"
                              },
                              "acquirer_return_code": {
                                "type": "string",
                                "example": "00"
                              },
                              "operation_type": {
                                "type": "string",
                                "example": "auth_and_capture"
                              },
                              "card": {
                                "type": "object",
                                "properties": {
                                  "id": {
                                    "type": "string",
                                    "example": "card_jdK2O53TqfnxwRDY"
                                  },
                                  "first_six_digits": {
                                    "type": "string",
                                    "example": "400000"
                                  },
                                  "last_four_digits": {
                                    "type": "string",
                                    "example": "0010"
                                  },
                                  "brand": {
                                    "type": "string",
                                    "example": "Visa"
                                  },
                                  "holder_name": {
                                    "type": "string",
                                    "example": "Tony Stark"
                                  },
                                  "exp_month": {
                                    "type": "integer",
                                    "example": 1,
                                    "default": 0
                                  },
                                  "exp_year": {
                                    "type": "integer",
                                    "example": 2030,
                                    "default": 0
                                  },
                                  "status": {
                                    "type": "string",
                                    "example": "active"
                                  },
                                  "type": {
                                    "type": "string",
                                    "example": "credit"
                                  },
                                  "created_at": {
                                    "type": "string",
                                    "example": "2019-01-18T12:25:41Z"
                                  },
                                  "updated_at": {
                                    "type": "string",
                                    "example": "2019-01-22T14:39:01Z"
                                  },
                                  "billing_address": {
                                    "type": "object",
                                    "properties": {
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
                                      },
                                      "line_1": {
                                        "type": "string",
                                        "example": "10880, Malibu Point, Malibu Central"
                                      }
                                    }
                                  }
                                }
                              },
                              "created_at": {
                                "type": "string",
                                "example": "2019-01-22T14:49:44Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2019-01-22T14:49:44Z"
                              },
                              "gateway_response": {
                                "type": "object",
                                "properties": {
                                  "code": {
                                    "type": "string",
                                    "example": "200"
                                  },
                                  "errors": {
                                    "type": "array",
                                    "items": {
                                      "type": "object",
                                      "properties": {}
                                    }
                                  }
                                }
                              }
                            }
                          },
                          "metadata": {
                            "type": "object",
                            "properties": {
                              "code": {
                                "type": "string",
                                "example": "123"
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
                          "example": 80,
                          "default": 0
                        },
                        "next": {
                          "type": "string",
                          "example": "https://api.pagar.me/core/v1/charges?page=2&size=2"
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