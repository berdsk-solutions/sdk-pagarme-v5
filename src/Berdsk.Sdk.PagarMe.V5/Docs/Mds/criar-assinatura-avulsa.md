# Criar assinatura avulsa

Fornecemos a possibilidade de criaÃ§Ã£o de uma assinatura (`subscription`) sem a necessidade de criaÃ§Ã£o de um plano (
`plan`).

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
      "post": {
        "summary": "Criar assinatura de plano",
        "description": "Fornecemos a possibilidade de criaÃ§Ã£o de uma assinatura (`subscription`) a partir de plano (`plan`).",
        "operationId": "criar-assinatura-de-plano-1",
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "required": [
                  "plan_id",
                  "payment_method",
                  "customer_id",
                  "customer",
                  "card"
                ],
                "properties": {
                  "code": {
                    "type": "string",
                    "description": "CÃ³digo da assinatura no sistema da loja. MÃ¡x.: 52 caracteres"
                  },
                  "plan_id": {
                    "type": "string",
                    "description": "CÃ³digo do plano.<br>Formato: `plan_XXXXXXXXXXXXXXXX`"
                  },
                  "payment_method": {
                    "type": "string",
                    "description": "Meio de pagamento.<br>Valores possÃ­veis: **credit_card**, **boleto** e **debit_card** ."
                  },
                  "start_at": {
                    "type": "string",
                    "description": "Data de inÃ­cio da assinatura.<br>Se nÃ£o for informada, a assinatura serÃ¡ iniciada **imediatamente**.",
                    "format": "date"
                  },
                  "customer_id": {
                    "type": "string",
                    "description": "CÃ³digo do cliente.<br>**ObrigatÃ³rio** caso o `customer` nÃ£o seja informado. [Saiba mais sobre clientes](https://docs.pagar.me/reference/clientes-1)."
                  },
                  "customer": {
                    "type": "object",
                    "description": "Dados do cliente.<br>**ObrigatÃ³rio** caso o `customer_id` nÃ£o seja informado. [Saiba mais sobre clientes](https://docs.pagar.me/reference/clientes-1).",
                    "required": [
                      "name"
                    ],
                    "properties": {
                      "name": {
                        "type": "string",
                        "description": "Nome do cliente. Max: 64 caracteres."
                      },
                      "type": {
                        "type": "string",
                        "description": "Tipo de cliente. Valores possÃ­veis: individual (pessoa fÃ­sica) ou company (pessoa jurÃ­dica). ObrigatÃ³rio, caso o document seja enviado."
                      },
                      "email": {
                        "type": "string",
                        "description": "E-mail do cliente. Max: 64 caracteres."
                      },
                      "code": {
                        "type": "string",
                        "description": "CÃ³digo de referÃªncia do cliente no sistema da loja. Max: 52 caracteres."
                      },
                      "document": {
                        "type": "string",
                        "description": "CPF, CNPJ ou PASSAPORTE do cliente. Max: 16 caracteres para CPF e CNPJ e Max: 50 caracteres para PASSAPORTE."
                      },
                      "document_type": {
                        "type": "string",
                        "description": "Tipo de documento. Valores possÃ­veis: \"CPF\", \"CNPJ\" ou \"PASSPORT\"."
                      },
                      "gender": {
                        "type": "string",
                        "description": "Sexo do cliente . Valores possÃ­veis: male ou female."
                      },
                      "address": {
                        "type": "object",
                        "description": "EndereÃ§o do cliente.",
                        "properties": {
                          "country": {
                            "type": "string",
                            "description": "PaÃ­s (CÃ³digo do paÃ­s no formato ISO 3166-1 alpha-2)(2 digitos)"
                          },
                          "state": {
                            "type": "string",
                            "description": "Estado (CÃ³digo do estado no formato ISO 3166-2)."
                          },
                          "city": {
                            "type": "string",
                            "description": "Cidade."
                          },
                          "zip_code": {
                            "type": "string",
                            "description": "CÃ³digo Postal (CEP) (Apenas numÃ©rico)."
                          },
                          "line_1": {
                            "type": "string",
                            "description": "Dados principais do endereÃ§o. Neste campo deve ser informado NÃºmero, Rua, Bairro, nesta ordem e separados por vÃ­rgula."
                          },
                          "line_2": {
                            "type": "string",
                            "description": "Dados complementares do endereÃ§o. Neste campo pode ser informado complemento, referÃªncias."
                          }
                        }
                      },
                      "phones": {
                        "type": "object",
                        "description": "Telefone residencial do cliente.",
                        "properties": {
                          "home_phone": {
                            "type": "object",
                            "description": "Telefone residencial do cliente.",
                            "properties": {
                              "country_code": {
                                "type": "string",
                                "description": "CÃ³digo do PaÃ­s (Apenas numÃ©rico)."
                              },
                              "area_code": {
                                "type": "string",
                                "description": "CÃ³digo da Ã¡rea (Apenas numÃ©rico)."
                              },
                              "number": {
                                "type": "string",
                                "description": "NÃºmero do telefone (Apenas numÃ©rico)."
                              }
                            }
                          },
                          "mobile_phone": {
                            "type": "object",
                            "description": "Telefone celular do cliente.",
                            "properties": {
                              "country_code": {
                                "type": "string",
                                "description": "CÃ³digo do PaÃ­s (Apenas numÃ©rico)."
                              },
                              "area_code": {
                                "type": "string",
                                "description": "CÃ³digo da Ã¡rea (Apenas numÃ©rico)."
                              },
                              "number": {
                                "type": "string",
                                "description": "NÃºmero do telefone (Apenas numÃ©rico)."
                              }
                            }
                          }
                        }
                      },
                      "birthdate": {
                        "type": "string",
                        "description": "Data de nascimento do cliente.",
                        "format": "date"
                      },
                      "metadata": {
                        "type": "string",
                        "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre o cliente."
                      }
                    }
                  },
                  "card": {
                    "type": "object",
                    "description": "CartÃ£o que serÃ¡ utilizado na assinatura. <br>**- card_id** Ã© o cÃ³digo do cartÃ£o do cliente.<br>**- card_token** Ã© token do cartÃ£o gerado pelo checkout transparente. <br> Ã‰ **obrigatÃ³rio** o envio de uma dessas identificações, caso o **payment_method** seja credit_card ou debit_card.<br>[Saiba mais sobre cartÃµes](https://docs.pagar.me/reference/cart%C3%B5es-1).",
                    "required": [
                      "number",
                      "holder_name",
                      "exp_month",
                      "exp_year"
                    ],
                    "properties": {
                      "number": {
                        "type": "string",
                        "description": "NÃºmero do cartÃ£o. Entre 13 e 19 caracteres"
                      },
                      "holder_name": {
                        "type": "string",
                        "description": "Nome do portador como estÃ¡ impresso no cartÃ£o. MÃ¡ximo de 64 caracteres (Caracteres especiais e nÃºmeros nÃ£o sÃ£o aceitos)"
                      },
                      "holder_document": {
                        "type": "string",
                        "description": "CPF ou CNPJ do portador do cartÃ£o. ObrigatÃ³rio caso o tipo do cartÃ£o seja voucher (bandeiras VR ou Pluxee)."
                      },
                      "exp_month": {
                        "type": "integer",
                        "description": "MÃªs de validade do cartÃ£o. Valor entre 1 e 12 (inclusive)",
                        "format": "int32"
                      },
                      "exp_year": {
                        "type": "integer",
                        "description": "Ano de validade do cartÃ£o. Formatos yy ou yyyy. Ex: 23 ou 2023.",
                        "format": "int32"
                      },
                      "cvv": {
                        "type": "string",
                        "description": "CÃ³digo de seguranÃ§a do cartÃ£o. O campo aceita 4 ou 3 caracteres, variando por bandeira."
                      },
                      "brand": {
                        "type": "string",
                        "description": "(Opcional) Bandeira do cartÃ£o. Para cartÃµes de crÃ©dito, temos como valores possÃ­veis: Elo, Mastercard, Visa, Amex, ou Hipercard. Para voucher, temos como valores possÃ­veis: Alelo, Ticket, VR ou Pluxee."
                      },
                      "label": {
                        "type": "string",
                        "description": "Indica a label do cartÃ£o"
                      },
                      "billing_address_id": {
                        "type": "string",
                        "description": "CÃ³digo do endereÃ§o de cobranÃ§a. Max: 36 caracteres.<>Opcional, pode ser utilizado no lugar do billing_address."
                      },
                      "billing_address": {
                        "type": "object",
                        "properties": {
                          "line_1": {
                            "type": "string",
                            "description": "Linha 1 do endereÃ§o. (NÃºmero, Rua, e Bairro - Nesta ordem e separados por vÃ­rgula) Max: 256 caracteres."
                          },
                          "line_2": {
                            "type": "string",
                            "description": "Linha 2 do endereÃ§o. (Complemento - Andar, Sala, Apto). Max: 128 caracteres."
                          },
                          "zip_code": {
                            "type": "string",
                            "description": "CEP. Max: 16 caracteres."
                          },
                          "city": {
                            "type": "string",
                            "description": "Cidade. Max: 64 caracteres."
                          },
                          "state": {
                            "type": "string",
                            "description": "CÃ³digo do estado no formato ISO 3166-2."
                          },
                          "country": {
                            "type": "string",
                            "description": "CÃ³digo do paÃ­s no formato ISO 3166-1 alpha-2."
                          }
                        }
                      }
                    }
                  },
                  "installments": {
                    "type": "integer",
                    "description": "Quantidade de parcelas.<br>O nÃºmero de parcelas deverÃ¡ ser 1 em recorrÃªncias.",
                    "default": 1,
                    "format": "int32"
                  },
                  "discounts": {
                    "type": "array",
                    "description": "Descontos.",
                    "items": {
                      "properties": {
                        "cycles": {
                          "type": "string",
                          "description": "NÃºmero de vezes que o desconto serÃ¡ aplicado."
                        },
                        "value": {
                          "type": "string",
                          "description": "Valor do desconto."
                        },
                        "discount_type": {
                          "type": "string",
                          "description": "Tipo do desconto. Valores possÃ­veis: flat ou percentage. Valor padrÃ£o: percentage."
                        }
                      },
                      "type": "object"
                    }
                  },
                  "increments": {
                    "type": "array",
                    "description": "Incrementos",
                    "items": {
                      "properties": {
                        "value": {
                          "type": "integer",
                          "description": "Valor do incremento.",
                          "format": "int32"
                        },
                        "cycles": {
                          "type": "string",
                          "description": "NÃºmero de vezes que o incremento serÃ¡ aplicado."
                        },
                        "increment_type": {
                          "type": "string",
                          "description": "Tipo do incremento. Valores possÃ­veis: flat ou percentage. Valor padrÃ£o: percentage."
                        }
                      },
                      "type": "object"
                    }
                  },
                  "boleto_due_days": {
                    "type": "integer",
                    "description": "Dias para expiraÃ§Ã£o do boleto. (Caso nÃ£o seja passado, serÃ¡ pego um valor padrÃ£o das configurações da loja)",
                    "format": "int32"
                  },
                  "metadata": {
                    "type": "string",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre a assinatura.<br>[Saiba mais sobre metadata](https://docs.pagar.me/reference/metadata-1)."
                  }
                }
              },
              "examples": {
                "JSON (with credit card)": {
                  "value": {
                    "plan_id": "plan_21r4CTG0ux77Qv13",
                    "payment_method": "credit_card",
                    "boleto_due_days": 5,
                    "customer": {
                      "name": "Tony Stark",
                      "email": "tonystark@avengers.com"
                    },
                    "card": {
                      "holder_name": "Tony Stark",
                      "number": "4532464862385322",
                      "exp_month": 1,
                      "exp_year": 30,
                      "cvv": "903",
                      "billing_address": {
                        "line_1": "375, Av. General Justo, Centro",
                        "line_2": "8Âº andar",
                        "zip_code": "20021130",
                        "city": "Rio de Janeiro",
                        "state": "RJ",
                        "country": "BR"
                      }
                    },
                    "discounts": [
                      {
                        "cycles": 3,
                        "value": 10,
                        "discount_type": "percentage"
                      }
                    ],
                    "increments": [
                      {
                        "cycles": 2,
                        "value": 20,
                        "discount_type": "percentage"
                      }
                    ],
                    "metadata": {
                      "id": "my_subscription_id"
                    }
                  }
                },
                "JSON (with boleto)": {
                  "value": {
                    "plan_id": "plan_21r4CTG0ux77Qv13",
                    "customer": {
                      "name": "Tony Stark",
                      "email": "tonystark@avengers.com"
                    },
                    "payment_method": "boleto"
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
                  "OK (with credit card)": {
                    "value": "{\n    \"id\": \"sub_05jkdIfGYPfN26mI\",\n    \"payment_method\": \"credit_card\",\n    \"currency\": \"BRL\",\n    \"interval\": \"month\",\n    \"interval_count\": 3,\n    \"billing_type\": \"prepaid\",\n    \"boleto_due_days\":5,\n    \"current_cycle\": {\n        \"start_at\": \"2016-07-19T00:00:00Z\",\n        \"end_at\": \"2016-10-18T23:59:59Z\"\n    },\n    \"next_billing_at\": \"2016-10-19T00:00:00Z\",\n    \"installments\": 3,\n    \"customer\": {\n        \"id\": \"cus_017228NmffGbA3d4\",\n        \"name\": \"Luke Skywalker\",\n        \"email\": \"lskywalker@r2d2.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2016-07-12T18:25:40Z\",\n        \"updated_at\": \"2016-07-12T18:25:40Z\",\n    },\n    \"card\": {\n        \"id\": \"card_Mome2meGz4PDNQbX\",\n        \"holder_name\": \"Luke Skywalker\",\n        \"masked_number\": \"453246******5322\",\n        \"exp_month\": 1,\n        \"exp_year\": 30,\n        \"expired\": false,\n        \"status\": \"active\",\n        \"created_at\": \"2016-07-12T18:25:40Z\",\n        \"update_at\": \"2016-07-12T18:25:40Z\",\n        \"billing_address\": {\n            \"id\": \"addr_Mome2meGz4PDNQbX\",\n            \"line_1\": \"375, Av. General Justo, Centro\",\n            \"line_2\": \"8Âº andar\",\n            \"zip_code\": \"20021130\",\n            \"city\": \"Rio de Janeiro\",\n            \"state\": \"RJ\",\n            \"country\": \"BR\",\n            \"status\": \"active\",\n            \"created_at\": \"2016-07-12T18:25:40Z\",\n            \"updated_at\": \"2016-07-12T18:25:40Z\"\n        }\n    },\n    \"plan\": {\n        \"id\": \"plan_21r4CTG0ux77Qv13\",\n        \"name\": \"Plano Gold\",\n        \"url\": \"/plan_21r4CTG0ux77Qv13/academia/plano-gold\",\n        \"currency\": \"BRL\",\n        \"interval\": \"month\",\n        \"minimum_price\": 10000,\n        \"interval_count\": 3,\n        \"billing_type\": \"prepaid\",\n        \"installments\": 3,\n        \"status\": \"active\",\n        \"created_at\": \"2016-07-12T18:25:40Z\",\n        \"updated_at\": \"2016-07-12T18:25:40Z\",\n        \"metadata\": {\n            \"id\": \"my_plan_id\"\n        }\n    },\n    \"discounts\": [\n        {\n            \"id\": \"si_k2zpBDMsOs0fDfHe\",\n            \"cycles\": 3,\n            \"value\": 10,\n            \"discount_type\": \"percentage\",\n            \"created_at\": \"2016-07-12T18:25:40Z\"\n        }\n    ],\n    \"increments\": [\n        {\n            \"cycles\": 2,\n            \"value\": 20,\n            \"discount_type\": \"percentage\"\n        }\n     ],\n    \"items\": [\n        {\n            \"id\": \"si_B6555Riyq9lj6klS\",\n            \"description\": \"MusculaÃ§Ã£o\",\n            \"quantity\": 1,\n            \"pricing_scheme\": {\n                \"price\": 18990\n            },\n            \"status\": \"active\",\n            \"created_at\": \"2016-07-12T18:25:40Z\",\n            \"updated_at\": \"2016-07-12T18:25:40Z\",\n        },\n        {\n            \"id\": \"si_lFjtC2xYGttulJpn\",\n            \"description\": \"MatrÃ­cula\",\n            \"quantity\": 1,\n            \"cycles\": 1,\n            \"pricing_scheme\": {\n                \"price\": 5990\n            },\n            \"status\": \"active\",\n            \"created_at\": \"2016-07-12T18:25:40Z\",\n            \"updated_at\": \"2016-07-12T18:25:40Z\",\n        }\n    ],\n    \"status\": \"active\",\n    \"created_at\": \"2016-07-12T18:25:40Z\",\n    \"updated_at\": \"2016-07-12T18:25:40Z\",\n    \"metadata\": {\n        \"id\": \"my_subscription_id\"\n    }\n}"
                  },
                  "OK (with boleto)": {
                    "value": "{\n    \"id\": \"sub_bpYjMr9f8sA6QJNg\",\n    \"code\": \"XPLMBV9U10\",\n    \"start_at\": \"2018-04-04T00:00:00Z\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"billing_type\": \"postpaid\",\n    \"current_cycle\": {\n        \"id\": \"cycle_j6WnJ7ei1hW68bXo\",\n        \"start_at\": \"2018-04-04T00:00:00Z\",\n        \"end_at\": \"2018-05-03T23:59:59Z\",\n        \"billing_at\": \"2018-05-04T00:00:00Z\"\n    },\n    \"next_billing_at\": \"2018-05-04T00:00:00Z\",\n    \"payment_method\": \"boleto\",\n    \"currency\": \"BRL\",\n    \"statement_descriptor\": \"Spotify\",\n    \"installments\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2018-04-04T21:36:13Z\",\n    \"updated_at\": \"2018-04-04T21:36:13Z\",\n    \"customer\": {\n        \"id\": \"cus_qr2AgDGiOhr61Y5L\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"cc25e912-197c-4626-a85d-8c0597e9b157@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2018-04-04T21:36:13Z\",\n        \"updated_at\": \"2018-04-04T21:36:13Z\",\n        \"phones\": {}\n    },\n    \"plan\": {\n        \"id\": \"plan_85AK5eF15feLKM4J\",\n        \"name\": \"Premium\",\n        \"description\": \"VÃ¡ de Premium. E seja feliz!\",\n        \"url\": \"/plans/plan_85AK5eF15feLKM4J/pagarme-teste/premium\",\n        \"statement_descriptor\": \"Spotify\",\n        \"interval\": \"month\",\n        \"interval_count\": 1,\n        \"billing_type\": \"postpaid\",\n        \"payment_methods\": [\n            \"boleto\",\n            \"credit_card\"\n        ],\n        \"installments\": [\n            1\n        ],\n        \"status\": \"active\",\n        \"currency\": \"BRL\",\n        \"created_at\": \"2018-04-04T21:36:09Z\",\n        \"updated_at\": \"2018-04-04T21:36:09Z\"\n    },\n    \"items\": [\n        {\n            \"id\": \"si_xGw3AeYiaTJ639A6\",\n            \"name\": \"Name - Premium\",\n            \"description\": \"Test - Description\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2018-04-04T21:36:13Z\",\n            \"updated_at\": \"2018-04-04T21:36:13Z\",\n            \"pricing_scheme\": {\n                \"price\": 1490,\n                \"scheme_type\": \"unit\"\n            }\n        }\n    ]\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "sub_bpYjMr9f8sA6QJNg"
                    },
                    "code": {
                      "type": "string",
                      "example": "XPLMBV9U10"
                    },
                    "start_at": {
                      "type": "string",
                      "example": "2018-04-04T00:00:00Z"
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
                    "current_cycle": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cycle_j6WnJ7ei1hW68bXo"
                        },
                        "start_at": {
                          "type": "string",
                          "example": "2018-04-04T00:00:00Z"
                        },
                        "end_at": {
                          "type": "string",
                          "example": "2018-05-03T23:59:59Z"
                        },
                        "billing_at": {
                          "type": "string",
                          "example": "2018-05-04T00:00:00Z"
                        }
                      }
                    },
                    "next_billing_at": {
                      "type": "string",
                      "example": "2018-05-04T00:00:00Z"
                    },
                    "payment_method": {
                      "type": "string",
                      "example": "boleto"
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
                      "example": "2018-04-04T21:36:13Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2018-04-04T21:36:13Z"
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_qr2AgDGiOhr61Y5L"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "cc25e912-197c-4626-a85d-8c0597e9b157@avengers.com"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2018-04-04T21:36:13Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-04-04T21:36:13Z"
                        },
                        "phones": {
                          "type": "object",
                          "properties": {}
                        }
                      }
                    },
                    "plan": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "plan_85AK5eF15feLKM4J"
                        },
                        "name": {
                          "type": "string",
                          "example": "Premium"
                        },
                        "description": {
                          "type": "string",
                          "example": "VÃ¡ de Premium. E seja feliz!"
                        },
                        "url": {
                          "type": "string",
                          "example": "/plans/plan_85AK5eF15feLKM4J/pagarme-teste/premium"
                        },
                        "statement_descriptor": {
                          "type": "string",
                          "example": "Spotify"
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
                        "payment_methods": {
                          "type": "array",
                          "items": {
                            "type": "string",
                            "example": "boleto"
                          }
                        },
                        "installments": {
                          "type": "array",
                          "items": {
                            "type": "integer",
                            "example": 1,
                            "default": 0
                          }
                        },
                        "status": {
                          "type": "string",
                          "example": "active"
                        },
                        "currency": {
                          "type": "string",
                          "example": "BRL"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2018-04-04T21:36:09Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-04-04T21:36:09Z"
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
                            "example": "si_xGw3AeYiaTJ639A6"
                          },
                          "name": {
                            "type": "string",
                            "example": "Name - Premium"
                          },
                          "description": {
                            "type": "string",
                            "example": "Test - Description"
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
                            "example": "2018-04-04T21:36:13Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2018-04-04T21:36:13Z"
                          },
                          "pricing_scheme": {
                            "type": "object",
                            "properties": {
                              "price": {
                                "type": "integer",
                                "example": 1490,
                                "default": 0
                              },
                              "scheme_type": {
                                "type": "string",
                                "example": "unit"
                              }
                            }
                          }
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
        "deprecated": false,
        "x-readme": {
          "code-samples": [
            {
              "language": "csharp",
              "code": "using System.Collections.Generic;\nusing System.Web.Mvc;\nusing MundiAPI.PCL;\nusing MundiAPI.PCL.Models;\n\nnamespace MundipaggTest.Controllers {\n\n    public class HomeController : Controller {\n\n        public ActionResult Index () {\n\n            // Secret key fornecida pela Mundipagg\n            string basicAuthUserName = \"SUA_CHAVE_SECRETA\";\n            // Senha em branco. Passando apenas a secret key\n            string basicAuthPassword = \"\";\n\n            var client = new MundiAPIClient (basicAuthUserName, basicAuthPassword);\n\n            string planId = \"plan_21r4CTG0ux77Qv13\";\n\n            var billinAddress = new CreateAddressRequest {\n                Line1 = \"375, Av. General Justo, Centro\",\n                Line2 = \"8Âº andar\",\n                ZipCode = \"20021130\",\n                City = \"Rio de Janeiro\",\n                State = \"RJ\",\n                Country = \"BR\"\n            };\n\n            var card = new CreateCardRequest {\n                HolderName = \"Tony Stark\",\n                Number = \"4532464862385322\",\n                ExpMonth = 1,\n                ExpYear = 30,\n                Cvv = \"903\",\n                BillingAddress = billinAddress\n            };\n\n            var discounts = new List<CreateDiscountRequest> {\n                new CreateDiscountRequest {\n                Cycles = 3,\n                Value = 10,\n                DiscountType = \"percentage\"\n                }\n            };\n\n            var metadata = new Dictionary<string, string> ();\n            metadata.Add (\"id\", \"my_subscription_id\");\n\n            var request = new CreateSubscriptionRequest {\n                PlanId = planId,\n                PaymentMethod = \"credit_card\",\n                Currency = \"BRL\",\n                Interval = \"month\",\n                IntervalCount = 3,\n                BillingType = \"prepaid\",\n                Installments = 3,\n                Customer = new CreateCustomerRequest {\n                Name = \"Tony Stark\",\n                Email = \"tonystark@avengers.com\"\n                },\n                Card = card,\n                Discounts = discounts,\n                Metadata = metadata\n            };\n\n            var response = client.Subscriptions.CreateSubscription (request);\n\n            return View ();\n        }\n    }\n}",
              "name": "SDK C#"
            }
          ],
          "samples-languages": [
            "csharp"
          ]
        }
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