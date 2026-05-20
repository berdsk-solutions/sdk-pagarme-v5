# Cancelar cobranÃ§a

> ðŸš§ CANCELAMENTO DE BOLETO
>
> Para clientes gateway, o cancelamento de uma cobranÃ§a de boleto nÃ£o gera um estorno financeiro para o cliente final. O
> cancelamento sÃ³ modifica o status da charge na API para registro do integrador.
>
> Para clientes PSP, o estorno de boleto funciona como uma transferÃªncia bancÃ¡ria, portanto Ã© necessÃ¡rio enviar os dados
> bancÃ¡rios do seu cliente na requisiÃ§Ã£o. Ressaltamos que o estorno deve ser realizado para o mesmo documento o qual a
> venda foi realizada.

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
    "/charges/{charge_id}.": {
      "delete": {
        "summary": "Cancelar cobranÃ§a",
        "description": "",
        "operationId": "cancelar-cobranÃ§a",
        "parameters": [
          {
            "name": "charge_id",
            "in": "path",
            "description": "CÃ³digo da cobranÃ§a.",
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
                "properties": {
                  "amount": {
                    "type": "integer",
                    "description": "Valor a ser cancelado. Caso nÃ£o seja informado, serÃ¡ considerado o valor total da cobranÃ§a.",
                    "format": "int32"
                  },
                  "bank_account": {
                    "type": "object",
                    "description": "Dados da conta bancÃ¡ria do comprador. Somente utilizado para estorno de boleto, onde Ã© um parÃ¢metro obrigatÃ³rio.",
                    "required": [
                      "holder_name",
                      "holder_type",
                      "holder_document",
                      "bank",
                      "branch_number",
                      "account_number",
                      "account_check_digit",
                      "type"
                    ],
                    "properties": {
                      "holder_name": {
                        "type": "string",
                        "description": "Nome do titular da conta."
                      },
                      "holder_type": {
                        "type": "string",
                        "description": "Tipo de titular. Valores possÃ­veis sÃ£o **individual** (pessoa fÃ­sica) ou **company** (pessoa jurÃ­dica)."
                      },
                      "holder_document": {
                        "type": "string",
                        "description": "NÃºmero do documento do titular da conta. Deve ser igual ao documento do recebedor."
                      },
                      "bank": {
                        "type": "string",
                        "description": "CÃ³digo do banco."
                      },
                      "branch_number": {
                        "type": "string",
                        "description": "NÃºmero da agÃªncia."
                      },
                      "branch_check_digit": {
                        "type": "string",
                        "description": "CÃ³digo verificador da agÃªncia."
                      },
                      "account_number": {
                        "type": "string",
                        "description": "NÃºmero da conta. MÃ¡ximo 13 caracteres numÃ©ricos."
                      },
                      "account_check_digit": {
                        "type": "string",
                        "description": "CÃ³digo verificador da conta."
                      },
                      "type": {
                        "type": "string",
                        "description": "Tipo da conta. Valores possÃ­veis sÃ£o **checking** (conta corrente) ou **savings** (conta poupanÃ§a)."
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
                  "Estorno de cartÃ£o de crÃ©dito": {
                    "value": "{\n    \"id\": \"ch_B4rpRdfBxsVv0NQo\",\n    \"code\": \"98ZZUL0F8Z\",\n    \"amount\": 1490,\n    \"paid_amount\": 1490,\n    \"canceled_amount\": 1490,\n    \"status\": \"canceled\",\n    \"currency\": \"BRL\",\n    \"payment_method\": \"credit_card\",\n    \"paid_at\": \"2019-01-22T14:40:47Z\",\n    \"canceled_at\": \"2019-01-22T14:48:06Z\",\n    \"created_at\": \"2019-01-22T14:39:35Z\",\n    \"updated_at\": \"2019-01-22T14:48:06Z\",\n    \"customer\": {\n        \"id\": \"cus_PYwJvWgOTmiqvW8m\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"toinhodalua@nasa.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2019-01-18T11:50:37Z\",\n        \"updated_at\": \"2019-01-18T15:46:38Z\",\n        \"phones\": {}\n    },\n    \"last_transaction\": {\n        \"id\": \"tran_3oR7lMpfEha2LYGn\",\n        \"transaction_type\": \"credit_card\",\n        \"funding_source\": \"prepaid\",\n        \"amount\": 1490,\n        \"status\": \"refunded\",\n        \"success\": true,\n        \"installments\": 1,\n        \"statement_descriptor\": \"AVENGERS\",\n        \"acquirer_tid\": \"d2b3e1ab-1b24-4d66-93c8-b304776cd782\",\n        \"acquirer_nsu\": \"15044\",\n        \"acquirer_auth_code\": \"743\",\n        \"acquirer_message\": \"TransaÃ§Ã£o capturada com sucesso\",\n        \"acquirer_return_code\": \"00\",\n        \"operation_type\": \"cancel\",\n        \"card\": {\n            \"id\": \"card_jdK2O53TqfnxwRDY\",\n            \"first_six_digits\": \"400000\",\n            \"last_four_digits\": \"0010\",\n            \"brand\": \"Visa\",\n            \"holder_name\": \"Tony Stark\",\n            \"exp_month\": 1,\n            \"exp_year\": 2030,\n            \"status\": \"active\",\n            \"type\": \"credit\",\n            \"created_at\": \"2019-01-18T12:25:41Z\",\n            \"updated_at\": \"2019-01-22T14:39:01Z\",\n            \"billing_address\": {\n                \"zip_code\": \"90265\",\n                \"city\": \"Malibu\",\n                \"state\": \"CA\",\n                \"country\": \"US\",\n                \"line_1\": \"10880, Malibu Point, Malibu Central\"\n            }\n        },\n        \"created_at\": \"2019-01-22T14:48:06Z\",\n        \"updated_at\": \"2019-01-22T14:48:06Z\",\n        \"gateway_response\": {\n            \"code\": \"200\",\n            \"errors\": []\n        }\n    },\n    \"metadata\": {\n        \"code\": \"123\"\n    }\n}"
                  },
                  "Estorno de boleto": {
                    "value": "{\n    \"id\": \"ch_YBEgkbYfmiW20mNL\",\n    \"code\": \"1K9RBZ8AE1\",\n    \"gateway_id\": \"23883236\",\n    \"amount\": 2990,\n    \"paid_amount\": 2990,\n    \"status\": \"processing\",\n    \"currency\": \"BRL\",\n    \"payment_method\": \"boleto\",\n    \"paid_at\": \"2023-07-03T16:23:58Z\",\n    \"created_at\": \"2023-07-03T16:23:29Z\",\n    \"updated_at\": \"2023-07-03T16:24:44Z\",\n    \"order\": {\n        \"id\": \"or_0oqY4JWizohEwWZ8\",\n        \"code\": \"1K9RBZ8AE1\",\n        \"amount\": 2990,\n        \"closed\": true,\n        \"created_at\": \"2023-07-03T16:23:29Z\",\n        \"updated_at\": \"2023-07-03T16:24:44Z\",\n        \"closed_at\": \"2023-07-03T16:23:29Z\",\n        \"currency\": \"BRL\",\n        \"status\": \"pending\",\n        \"customer_id\": \"cus_7g1QJ2AidijyRlLW\"\n    },\n    \"customer\": {\n        \"id\": \"cus_7g1QJ2AidijyRlLW\",\n        \"name\": \"Claudio Jose Sergio Viana\",\n        \"email\": \"claudio_viana@valeguinchos.com.br\",\n        \"code\": \"1234\",\n        \"document\": \"29704428685\",\n        \"type\": \"individual\",\n        \"delinquent\": false,\n        \"address\": {\n            \"id\": \"addr_mkL43lNfMfkaqgl2\",\n            \"line_1\": \"375, Av. General Justo, Centro\",\n            \"line_2\": \"8Âº andar\",\n            \"zip_code\": \"20021130\",\n            \"city\": \"Rio de Janeiro\",\n            \"state\": \"RJ\",\n            \"country\": \"BR\",\n            \"status\": \"active\",\n            \"created_at\": \"2022-06-15T19:40:04Z\",\n            \"updated_at\": \"2022-08-17T18:48:12Z\"\n        },\n        \"created_at\": \"2022-06-15T19:40:04Z\",\n        \"updated_at\": \"2022-08-17T18:48:12Z\",\n        \"phones\": {\n            \"home_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            }\n        }\n    },\n    \"last_transaction\": {\n        \"id\": \"tran_yvwnO9hJpT7GPB2e\",\n        \"transaction_type\": \"boleto\",\n        \"gateway_id\": \"23883236\",\n        \"amount\": 2990,\n        \"status\": \"pending_refund\",\n        \"success\": true,\n        \"paid_amount\": 2990,\n        \"paid_at\": \"2023-07-03T16:23:58Z\",\n        \"url\": \"https://pagar.me\",\n        \"pdf\": \"https://pagar.me?format=pdf\",\n        \"line\": \"1234 5678\",\n        \"barcode\": \"https://api.pagar.me/core/v5/transactions/tran_yBx3l2ysW9CAGwqa/barcode\",\n        \"qr_code\": \"https://api.pagar.me/core/v5/transactions/tran_yBx3l2ysW9CAGwqa/qrcode\",\n        \"nosso_numero\": \"23883236\",\n        \"type\": \"DM\",\n        \"bank\": \"198\",\n        \"document_number\": \"23883236\",\n        \"instructions\": \"Pagar\",\n        \"due_at\": \"2025-02-20T23:59:59Z\",\n        \"created_at\": \"2023-07-03T16:24:43Z\",\n        \"updated_at\": \"2023-07-03T16:24:43Z\",\n        \"gateway_response\": {\n            \"errors\": [\n                {}\n            ]\n        },\n        \"antifraud_response\": {},\n        \"metadata\": {}\n    }\n}"
                  }
                },
                "schema": {
                  "oneOf": [
                    {
                      "title": "Estorno de cartÃ£o de crÃ©dito",
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "ch_B4rpRdfBxsVv0NQo"
                        },
                        "code": {
                          "type": "string",
                          "example": "98ZZUL0F8Z"
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
                        "canceled_amount": {
                          "type": "integer",
                          "example": 1490,
                          "default": 0
                        },
                        "status": {
                          "type": "string",
                          "example": "canceled"
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
                          "example": "2019-01-22T14:40:47Z"
                        },
                        "canceled_at": {
                          "type": "string",
                          "example": "2019-01-22T14:48:06Z"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2019-01-22T14:39:35Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2019-01-22T14:48:06Z"
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
                              "example": "tran_3oR7lMpfEha2LYGn"
                            },
                            "transaction_type": {
                              "type": "string",
                              "example": "credit_card"
                            },
                            "funding_source": {
                              "type": "string",
                              "example": "prepaid"
                            },
                            "amount": {
                              "type": "integer",
                              "example": 1490,
                              "default": 0
                            },
                            "status": {
                              "type": "string",
                              "example": "refunded"
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
                              "example": "d2b3e1ab-1b24-4d66-93c8-b304776cd782"
                            },
                            "acquirer_nsu": {
                              "type": "string",
                              "example": "15044"
                            },
                            "acquirer_auth_code": {
                              "type": "string",
                              "example": "743"
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
                              "example": "cancel"
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
                              "example": "2019-01-22T14:48:06Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2019-01-22T14:48:06Z"
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
                    },
                    {
                      "title": "Estorno de boleto",
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "ch_YBEgkbYfmiW20mNL"
                        },
                        "code": {
                          "type": "string",
                          "example": "1K9RBZ8AE1"
                        },
                        "gateway_id": {
                          "type": "string",
                          "example": "23883236"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 2990,
                          "default": 0
                        },
                        "paid_amount": {
                          "type": "integer",
                          "example": 2990,
                          "default": 0
                        },
                        "status": {
                          "type": "string",
                          "example": "processing"
                        },
                        "currency": {
                          "type": "string",
                          "example": "BRL"
                        },
                        "payment_method": {
                          "type": "string",
                          "example": "boleto"
                        },
                        "paid_at": {
                          "type": "string",
                          "example": "2023-07-03T16:23:58Z"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2023-07-03T16:23:29Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2023-07-03T16:24:44Z"
                        },
                        "order": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "or_0oqY4JWizohEwWZ8"
                            },
                            "code": {
                              "type": "string",
                              "example": "1K9RBZ8AE1"
                            },
                            "amount": {
                              "type": "integer",
                              "example": 2990,
                              "default": 0
                            },
                            "closed": {
                              "type": "boolean",
                              "example": true,
                              "default": true
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2023-07-03T16:23:29Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2023-07-03T16:24:44Z"
                            },
                            "closed_at": {
                              "type": "string",
                              "example": "2023-07-03T16:23:29Z"
                            },
                            "currency": {
                              "type": "string",
                              "example": "BRL"
                            },
                            "status": {
                              "type": "string",
                              "example": "pending"
                            },
                            "customer_id": {
                              "type": "string",
                              "example": "cus_7g1QJ2AidijyRlLW"
                            }
                          }
                        },
                        "customer": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "cus_7g1QJ2AidijyRlLW"
                            },
                            "name": {
                              "type": "string",
                              "example": "Claudio Jose Sergio Viana"
                            },
                            "email": {
                              "type": "string",
                              "example": "claudio_viana@valeguinchos.com.br"
                            },
                            "code": {
                              "type": "string",
                              "example": "1234"
                            },
                            "document": {
                              "type": "string",
                              "example": "29704428685"
                            },
                            "type": {
                              "type": "string",
                              "example": "individual"
                            },
                            "delinquent": {
                              "type": "boolean",
                              "example": false,
                              "default": true
                            },
                            "address": {
                              "type": "object",
                              "properties": {
                                "id": {
                                  "type": "string",
                                  "example": "addr_mkL43lNfMfkaqgl2"
                                },
                                "line_1": {
                                  "type": "string",
                                  "example": "375, Av. General Justo, Centro"
                                },
                                "line_2": {
                                  "type": "string",
                                  "example": "8Âº andar"
                                },
                                "zip_code": {
                                  "type": "string",
                                  "example": "20021130"
                                },
                                "city": {
                                  "type": "string",
                                  "example": "Rio de Janeiro"
                                },
                                "state": {
                                  "type": "string",
                                  "example": "RJ"
                                },
                                "country": {
                                  "type": "string",
                                  "example": "BR"
                                },
                                "status": {
                                  "type": "string",
                                  "example": "active"
                                },
                                "created_at": {
                                  "type": "string",
                                  "example": "2022-06-15T19:40:04Z"
                                },
                                "updated_at": {
                                  "type": "string",
                                  "example": "2022-08-17T18:48:12Z"
                                }
                              }
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2022-06-15T19:40:04Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2022-08-17T18:48:12Z"
                            },
                            "phones": {
                              "type": "object",
                              "properties": {
                                "home_phone": {
                                  "type": "object",
                                  "properties": {
                                    "country_code": {
                                      "type": "string",
                                      "example": "55"
                                    },
                                    "number": {
                                      "type": "string",
                                      "example": "000000000"
                                    },
                                    "area_code": {
                                      "type": "string",
                                      "example": "21"
                                    }
                                  }
                                }
                              }
                            }
                          }
                        },
                        "last_transaction": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "tran_yvwnO9hJpT7GPB2e"
                            },
                            "transaction_type": {
                              "type": "string",
                              "example": "boleto"
                            },
                            "gateway_id": {
                              "type": "string",
                              "example": "23883236"
                            },
                            "amount": {
                              "type": "integer",
                              "example": 2990,
                              "default": 0
                            },
                            "status": {
                              "type": "string",
                              "example": "pending_refund"
                            },
                            "success": {
                              "type": "boolean",
                              "example": true,
                              "default": true
                            },
                            "paid_amount": {
                              "type": "integer",
                              "example": 2990,
                              "default": 0
                            },
                            "paid_at": {
                              "type": "string",
                              "example": "2023-07-03T16:23:58Z"
                            },
                            "url": {
                              "type": "string",
                              "example": "https://pagar.me"
                            },
                            "pdf": {
                              "type": "string",
                              "example": "https://pagar.me?format=pdf"
                            },
                            "line": {
                              "type": "string",
                              "example": "1234 5678"
                            },
                            "barcode": {
                              "type": "string",
                              "example": "https://api.pagar.me/core/v5/transactions/tran_yBx3l2ysW9CAGwqa/barcode"
                            },
                            "qr_code": {
                              "type": "string",
                              "example": "https://api.pagar.me/core/v5/transactions/tran_yBx3l2ysW9CAGwqa/qrcode"
                            },
                            "nosso_numero": {
                              "type": "string",
                              "example": "23883236"
                            },
                            "type": {
                              "type": "string",
                              "example": "DM"
                            },
                            "bank": {
                              "type": "string",
                              "example": "198"
                            },
                            "document_number": {
                              "type": "string",
                              "example": "23883236"
                            },
                            "instructions": {
                              "type": "string",
                              "example": "Pagar"
                            },
                            "due_at": {
                              "type": "string",
                              "example": "2025-02-20T23:59:59Z"
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2023-07-03T16:24:43Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2023-07-03T16:24:43Z"
                            },
                            "gateway_response": {
                              "type": "object",
                              "properties": {
                                "errors": {
                                  "type": "array",
                                  "items": {
                                    "type": "object",
                                    "properties": {}
                                  }
                                }
                              }
                            },
                            "antifraud_response": {
                              "type": "object",
                              "properties": {}
                            },
                            "metadata": {
                              "type": "object",
                              "properties": {}
                            }
                          }
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