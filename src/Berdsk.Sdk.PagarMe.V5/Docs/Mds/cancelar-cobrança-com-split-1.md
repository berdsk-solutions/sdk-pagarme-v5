# Cancelar cobranÃ§a com split

Rota para cancelar uma cobranÃ§a com split, definindo a regra de split e os recebedor que irÃ£o participar da divisÃ£o dos
pagamentos.

> ðŸ“˜ Cancelamento de uma cobranÃ§a com split
>
> Apenas cobranÃ§as capturadas com Split podem ser canceladas com regras de Split.\
> O envio de novas regras de Split, diferentes das regras enviadas na autorizaÃ§Ã£o/captura de uma cobranÃ§a irÃ£o
> sobrescrever as regras enviadas na autorizaÃ§Ã£o.

> ðŸš§ Cancelamento parcial
>
> O envio das regras de split no cancelamento parcial de cobranÃ§as realizadas com split Ã© fundamental, do contrÃ¡rio, as
> regras definas na autorizaÃ§Ã£o/captura da cobranÃ§a serÃ£o aplicadas de forma automÃ¡tica ao cancelamento.

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
    "/charges/{charge_id}": {
      "delete": {
        "summary": "Cancelar cobranÃ§a com split",
        "description": "Rota para cancelar uma cobranÃ§a com split, definindo a regra de split e os recebedor que irÃ£o participar da divisÃ£o dos pagamentos.",
        "operationId": "cancelar-cobranÃ§a-com-split-1",
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
                  "split": {
                    "type": "array",
                    "description": "Lista de regras de split.",
                    "items": {
                      "properties": {
                        "amount": {
                          "type": "integer",
                          "description": "Valor destinado ao recebedor.",
                          "format": "int32"
                        },
                        "recipient_id": {
                          "type": "string",
                          "description": "CÃ³digo do recebedor. Formato: rp_XXXXXXXXXXXXXXXX."
                        },
                        "type": {
                          "type": "string",
                          "description": "Tipo de divisÃ£o. Os valores possÃ­veis sÃ£o flat ou percentage."
                        },
                        "options": {
                          "type": "object",
                          "description": "Informações da responsabilidade do recebedor na transaÃ§Ã£o.",
                          "properties": {
                            "charge_processing_fee": {
                              "type": "boolean",
                              "description": "Indica se o recebedor vinculado Ã  regra serÃ¡ cobrado pelas taxas da transaÃ§Ã£o"
                            },
                            "charge_remainder_fee": {
                              "type": "boolean",
                              "description": "Indica se o recebedor vinculado Ã  regra irÃ¡ receber o restante dos recebÃ­veis apÃ³s uma divisÃ£o"
                            },
                            "liable": {
                              "type": "boolean",
                              "description": "Indica se o recebedor Ã© responsÃ¡vel pela transaÃ§Ã£o em caso de chargeback."
                            }
                          }
                        }
                      },
                      "type": "object"
                    }
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
                  "Result": {
                    "value": "{\n  \"id\": \"ch_bz6VONxuriWqXY0l\",\n  \"code\": \"Q7KA3GIZDV\",\n  \"gateway_id\": \"7628472\",\n  \"amount\": 200,\n  \"paid_amount\": 200,\n  \"canceled_amount\": 200,\n  \"status\": \"canceled\",\n  \"currency\": \"BRL\",\n  \"payment_method\": \"credit_card\",\n  \"paid_at\": \"2020-01-16T15:14:27Z\",\n  \"canceled_at\": \"2020-01-16T16:03:49Z\",\n  \"created_at\": \"2020-01-16T15:14:21Z\",\n  \"updated_at\": \"2020-01-16T16:03:49Z\",\n  \"order\": {\n    \"id\": \"or_5QXWzjpHRfpw04Dv\",\n    \"code\": \"Q7KA3GIZDV\",\n    \"amount\": 200,\n    \"closed\": true,\n    \"created_at\": \"2020-01-16T15:14:21Z\",\n    \"updated_at\": \"2020-01-16T16:03:49Z\",\n    \"closed_at\": \"2020-01-16T15:14:21Z\",\n    \"currency\": \"BRL\",\n    \"status\": \"canceled\",\n    \"customer_id\": \"cus_nmEG47zTJu88gd6R\"\n  },\n  \"customer\": {\n    \"id\": \"cus_nmEG47zTJu88gd6R\",\n    \"name\": \"Tony Stark\",\n    \"email\": \"1ad6b8d7-28f7-48ee-80c4-71b087aa7d0a@avengers.com\",\n    \"document\": \"93095135270\",\n    \"type\": \"individual\",\n    \"delinquent\": false,\n    \"address\": {\n      \"id\": \"addr_w9Nn7z3c3pu8XMQZ\",\n      \"line_1\": \"375, Av. General Justo, Centro\",\n      \"line_2\": \"8Âº andar\",\n      \"street\": \"Av. General Justo\",\n      \"number\": \"375\",\n      \"complement\": \"8Âº andar\",\n      \"zip_code\": \"70070300\",\n      \"neighborhood\": \"Centro\",\n      \"city\": \"Rio de Janeiro\",\n      \"state\": \"RJ\",\n      \"country\": \"BR\",\n      \"status\": \"active\",\n      \"created_at\": \"2020-01-02T20:23:10Z\",\n      \"updated_at\": \"2020-01-02T20:23:10Z\"\n    },\n    \"created_at\": \"2020-01-02T20:23:10Z\",\n    \"updated_at\": \"2020-01-02T20:23:10Z\",\n    \"phones\": {\n      \"home_phone\": {\n        \"country_code\": \"55\",\n        \"number\": \"000000000\",\n        \"area_code\": \"21\"\n      },\n      \"mobile_phone\": {\n        \"country_code\": \"55\",\n        \"number\": \"000000000\",\n        \"area_code\": \"21\"\n      }\n    },\n    \"metadata\": {\n      \"company\": \"Avengers\"\n    }\n  },\n  \"last_transaction\": {\n    \"id\": \"tran_NMloP9hkEhEDRjem\",\n    \"transaction_type\": \"credit_card\",\n    \"gateway_id\": \"7628472\",\n    \"amount\": 100,\n    \"status\": \"refunded\",\n    \"success\": true,\n    \"installments\": 1,\n    \"statement_descriptor\": \"AVENGERS\",\n    \"acquirer_name\": \"pagarme\",\n    \"acquirer_tid\": \"7628472\",\n    \"acquirer_nsu\": \"7628472\",\n    \"acquirer_return_code\": \"0000\",\n    \"operation_type\": \"cancel\",\n    \"card\": {\n      \"id\": \"card_mYGN6wf9aUao5Vrp\",\n      \"first_six_digits\": \"400000\",\n      \"last_four_digits\": \"0010\",\n      \"brand\": \"Visa\",\n      \"holder_name\": \"Tony Stark\",\n      \"exp_month\": 1,\n      \"exp_year\": 2023,\n      \"status\": \"active\",\n      \"type\": \"credit\",\n      \"created_at\": \"2020-01-02T20:23:12Z\",\n      \"updated_at\": \"2020-01-02T20:23:12Z\",\n      \"billing_address\": {\n        \"street\": \"Malibu Point\",\n        \"number\": \"10880\",\n        \"zip_code\": \"90265\",\n        \"neighborhood\": \"Central Malibu\",\n        \"city\": \"Malibu\",\n        \"state\": \"CA\",\n        \"country\": \"US\",\n        \"line_1\": \"10880, Malibu Point, Central Malibu\"\n      }\n    },\n    \"created_at\": \"2020-01-16T16:03:49Z\",\n    \"updated_at\": \"2020-01-16T16:03:49Z\",\n    \"gateway_response\": {\n      \"code\": \"200\",\n      \"errors\": []\n    },\n    \"antifraud_response\": {},\n    \"split\": [\n      {\n        \"id\": \"sr_bZwklpPh5ASw2k9n\",\n        \"type\": \"percentage\",\n        \"gateway_id\": \"sr_ck5gvkaia0061q36dfxqmrh1j\",\n        \"amount\": 80,\n        \"recipient\": {\n          \"id\": \"rp_5yGwpMGckBHVYmb6\",\n          \"name\": \"First recipient\",\n          \"email\": \"first_recipient@pagar.me\",\n          \"document\": \"12728994706\",\n          \"description\": \"DescriÃ§Ã£o do recebedor 1\",\n          \"type\": \"individual\",\n          \"status\": \"active\",\n          \"created_at\": \"2020-01-02T20:23:14Z\",\n          \"updated_at\": \"2020-01-02T20:23:14Z\"\n        },\n        \"options\": {\n          \"liable\": true,\n          \"charge_processing_fee\": true,\n          \"charge_remainder_fee\": true\n        }\n      },\n      {\n        \"id\": \"sr_6wk7eD6f8EfoKJEP\",\n        \"type\": \"percentage\",\n        \"gateway_id\": \"sr_ck5gvkaia0062q36dioccqnec\",\n        \"amount\": 20,\n        \"recipient\": {\n          \"id\": \"rp_yLnAyVpHbQIqZxwO\",\n          \"name\": \"Second recipient\",\n          \"email\": \"second_recipient@pagar.me\",\n          \"document\": \"15313587000166\",\n          \"description\": \"DescriÃ§Ã£o do recebedor 2\",\n          \"type\": \"company\",\n          \"status\": \"active\",\n          \"created_at\": \"2020-01-02T20:23:17Z\",\n          \"updated_at\": \"2020-01-02T20:23:17Z\"\n        },\n        \"options\": {\n          \"liable\": false,\n          \"charge_processing_fee\": false,\n          \"charge_remainder_fee\": false\n        }\n      },\n      {\n        \"id\": \"sr_2rd784Rt0FyPO3QK\",\n        \"type\": \"percentage\",\n        \"gateway_id\": \"sr_ck5gvkaia0061q36dfxqmrh1j\",\n        \"amount\": 80,\n        \"recipient\": {\n          \"id\": \"rp_5yGwpMGckBHVYmb6\",\n          \"name\": \"First recipient\",\n          \"email\": \"first_recipient@pagar.me\",\n          \"document\": \"12728994706\",\n          \"description\": \"DescriÃ§Ã£o do recebedor 1\",\n          \"type\": \"individual\",\n          \"status\": \"active\",\n          \"created_at\": \"2020-01-02T20:23:14Z\",\n          \"updated_at\": \"2020-01-02T20:23:14Z\"\n        },\n        \"options\": {\n          \"liable\": true,\n          \"charge_processing_fee\": true,\n          \"charge_remainder_fee\": true\n        }\n      },\n      {\n        \"id\": \"sr_mpQWr6ZvfEiXrxNL\",\n        \"type\": \"percentage\",\n        \"gateway_id\": \"sr_ck5gvkaia0062q36dioccqnec\",\n        \"amount\": 20,\n        \"recipient\": {\n          \"id\": \"rp_yLnAyVpHbQIqZxwO\",\n          \"name\": \"Second recipient\",\n          \"email\": \"second_recipient@pagar.me\",\n          \"document\": \"15313587000166\",\n          \"description\": \"DescriÃ§Ã£o do recebedor 2\",\n          \"type\": \"company\",\n          \"status\": \"active\",\n          \"created_at\": \"2020-01-02T20:23:17Z\",\n          \"updated_at\": \"2020-01-02T20:23:17Z\"\n        },\n        \"options\": {\n          \"liable\": false,\n          \"charge_processing_fee\": false,\n          \"charge_remainder_fee\": false\n        }\n      }\n    ],\n    \"metadata\": {}\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "ch_bz6VONxuriWqXY0l"
                    },
                    "code": {
                      "type": "string",
                      "example": "Q7KA3GIZDV"
                    },
                    "gateway_id": {
                      "type": "string",
                      "example": "7628472"
                    },
                    "amount": {
                      "type": "integer",
                      "example": 200,
                      "default": 0
                    },
                    "paid_amount": {
                      "type": "integer",
                      "example": 200,
                      "default": 0
                    },
                    "canceled_amount": {
                      "type": "integer",
                      "example": 200,
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
                      "example": "2020-01-16T15:14:27Z"
                    },
                    "canceled_at": {
                      "type": "string",
                      "example": "2020-01-16T16:03:49Z"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2020-01-16T15:14:21Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2020-01-16T16:03:49Z"
                    },
                    "order": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "or_5QXWzjpHRfpw04Dv"
                        },
                        "code": {
                          "type": "string",
                          "example": "Q7KA3GIZDV"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 200,
                          "default": 0
                        },
                        "closed": {
                          "type": "boolean",
                          "example": true,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2020-01-16T15:14:21Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2020-01-16T16:03:49Z"
                        },
                        "closed_at": {
                          "type": "string",
                          "example": "2020-01-16T15:14:21Z"
                        },
                        "currency": {
                          "type": "string",
                          "example": "BRL"
                        },
                        "status": {
                          "type": "string",
                          "example": "canceled"
                        },
                        "customer_id": {
                          "type": "string",
                          "example": "cus_nmEG47zTJu88gd6R"
                        }
                      }
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_nmEG47zTJu88gd6R"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "1ad6b8d7-28f7-48ee-80c4-71b087aa7d0a@avengers.com"
                        },
                        "document": {
                          "type": "string",
                          "example": "93095135270"
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
                              "example": "addr_w9Nn7z3c3pu8XMQZ"
                            },
                            "line_1": {
                              "type": "string",
                              "example": "375, Av. General Justo, Centro"
                            },
                            "line_2": {
                              "type": "string",
                              "example": "8Âº andar"
                            },
                            "street": {
                              "type": "string",
                              "example": "Av. General Justo"
                            },
                            "number": {
                              "type": "string",
                              "example": "375"
                            },
                            "complement": {
                              "type": "string",
                              "example": "8Âº andar"
                            },
                            "zip_code": {
                              "type": "string",
                              "example": "70070300"
                            },
                            "neighborhood": {
                              "type": "string",
                              "example": "Centro"
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
                              "example": "2020-01-02T20:23:10Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2020-01-02T20:23:10Z"
                            }
                          }
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2020-01-02T20:23:10Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2020-01-02T20:23:10Z"
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
                            },
                            "mobile_phone": {
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
                        },
                        "metadata": {
                          "type": "object",
                          "properties": {
                            "company": {
                              "type": "string",
                              "example": "Avengers"
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
                          "example": "tran_NMloP9hkEhEDRjem"
                        },
                        "transaction_type": {
                          "type": "string",
                          "example": "credit_card"
                        },
                        "gateway_id": {
                          "type": "string",
                          "example": "7628472"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 100,
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
                        "acquirer_name": {
                          "type": "string",
                          "example": "pagarme"
                        },
                        "acquirer_tid": {
                          "type": "string",
                          "example": "7628472"
                        },
                        "acquirer_nsu": {
                          "type": "string",
                          "example": "7628472"
                        },
                        "acquirer_return_code": {
                          "type": "string",
                          "example": "0000"
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
                              "example": "card_mYGN6wf9aUao5Vrp"
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
                              "example": 2023,
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
                              "example": "2020-01-02T20:23:12Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2020-01-02T20:23:12Z"
                            },
                            "billing_address": {
                              "type": "object",
                              "properties": {
                                "street": {
                                  "type": "string",
                                  "example": "Malibu Point"
                                },
                                "number": {
                                  "type": "string",
                                  "example": "10880"
                                },
                                "zip_code": {
                                  "type": "string",
                                  "example": "90265"
                                },
                                "neighborhood": {
                                  "type": "string",
                                  "example": "Central Malibu"
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
                                  "example": "10880, Malibu Point, Central Malibu"
                                }
                              }
                            }
                          }
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2020-01-16T16:03:49Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2020-01-16T16:03:49Z"
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
                        },
                        "antifraud_response": {
                          "type": "object",
                          "properties": {}
                        },
                        "split": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "sr_bZwklpPh5ASw2k9n"
                              },
                              "type": {
                                "type": "string",
                                "example": "percentage"
                              },
                              "gateway_id": {
                                "type": "string",
                                "example": "sr_ck5gvkaia0061q36dfxqmrh1j"
                              },
                              "amount": {
                                "type": "integer",
                                "example": 80,
                                "default": 0
                              },
                              "recipient": {
                                "type": "object",
                                "properties": {
                                  "id": {
                                    "type": "string",
                                    "example": "rp_5yGwpMGckBHVYmb6"
                                  },
                                  "name": {
                                    "type": "string",
                                    "example": "First recipient"
                                  },
                                  "email": {
                                    "type": "string",
                                    "example": "first_recipient@pagar.me"
                                  },
                                  "document": {
                                    "type": "string",
                                    "example": "12728994706"
                                  },
                                  "description": {
                                    "type": "string",
                                    "example": "DescriÃ§Ã£o do recebedor 1"
                                  },
                                  "type": {
                                    "type": "string",
                                    "example": "individual"
                                  },
                                  "status": {
                                    "type": "string",
                                    "example": "active"
                                  },
                                  "created_at": {
                                    "type": "string",
                                    "example": "2020-01-02T20:23:14Z"
                                  },
                                  "updated_at": {
                                    "type": "string",
                                    "example": "2020-01-02T20:23:14Z"
                                  }
                                }
                              },
                              "options": {
                                "type": "object",
                                "properties": {
                                  "liable": {
                                    "type": "boolean",
                                    "example": true,
                                    "default": true
                                  },
                                  "charge_processing_fee": {
                                    "type": "boolean",
                                    "example": true,
                                    "default": true
                                  },
                                  "charge_remainder_fee": {
                                    "type": "boolean",
                                    "example": true,
                                    "default": true
                                  }
                                }
                              }
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