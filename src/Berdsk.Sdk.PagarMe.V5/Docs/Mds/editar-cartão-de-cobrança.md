# Editar cartÃ£o de cobranÃ§a

Esse recurso sÃ³ pode ser chamado quando o cartÃ£o a ser editado teve a transaÃ§Ã£o nÃ£o autorizada.

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
    "/charges/{charge_id}/card": {
      "patch": {
        "summary": "Editar cartÃ£o de cobranÃ§a",
        "description": "Esse recurso sÃ³ pode ser chamado quando o cartÃ£o a ser editado teve a transaÃ§Ã£o nÃ£o autorizada.",
        "operationId": "editar-cartÃ£o-de-cobranÃ§a",
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
                  "update_subscription": {
                    "type": "string",
                    "description": "Indica se o cartÃ£o da assinatura deve ser atualizado",
                    "default": "false"
                  },
                  "card_id": {
                    "type": "string",
                    "description": "CÃ³digo do cartÃ£o."
                  },
                  "card": {
                    "type": "object",
                    "description": "Dados do cartÃ£o. [Saiba mais sobre cartÃµes](https://docs.pagar.me/reference/cart%C3%B5es-1).",
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
                  "card_token": {
                    "type": "string",
                    "description": "Token do cartÃ£o"
                  },
                  "initiated_type": {
                    "type": "string",
                    "description": "Identificador do tipo de transaÃ§Ã£o avulsa. Valores possÃ­veis: `partial_shipment` (Remessa Parcial), `related_or_delayed_charge` (CobranÃ§a Atrasada), `no_show` (Multa) ou `retry` (Retentativa). [Mais detalhes](https://docs.pagar.me/page/mitcit-transa%C3%A7%C3%B5es-card-on-file-mastercard)."
                  },
                  "recurrence_model": {
                    "type": "string",
                    "description": "Identificador do tipo de recorrÃªncia. Valores possÃ­veis: `standing_order` (Ordem Permanente), `instalment` (Parcelamento) ou `subscription` (Assinatura convencional com valor e frequÃªncia fixa). [Mais detalhes](https://docs.pagar.me/page/mitcit-transa%C3%A7%C3%B5es-card-on-file-mastercard)."
                  },
                  "payment_origin": {
                    "type": "object",
                    "description": "Identificador da primeira cobranÃ§a de uma recorrÃªncia. [Mais detalhes](https://docs.pagar.me/docs/api-v5-identificador-de-recorr%C3%AAncia-para-assinaturas-externas).",
                    "properties": {
                      "charge_id": {
                        "type": "string",
                        "description": "Identificador da cobranÃ§a"
                      },
                      "brand_id": {
                        "type": "string",
                        "description": "Identificador da bandeira"
                      }
                    }
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "card": {
                      "number": "4000000000000010",
                      "holder_name": "Tony Stark",
                      "exp_month": 1,
                      "exp_year": 30,
                      "cvv": "3531",
                      "billing_address": {
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
                    "value": "{\n    \"id\": \"ch_B4rpRdfBxsVv0NQo\",\n    \"code\": \"98ZZUL0F8Z\",\n    \"amount\": 1490,\n    \"paid_amount\": 1490,\n    \"status\": \"paid\",\n    \"currency\": \"BRL\",\n    \"payment_method\": \"credit_card\",\n    \"paid_at\": \"2019-01-22T14:40:47Z\",\n    \"created_at\": \"2019-01-22T14:39:35Z\",\n    \"updated_at\": \"2019-01-22T14:40:47Z\",\n    \"customer\": {\n        \"id\": \"cus_PYwJvWgOTmiqvW8m\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"toinhodalua@nasa.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2019-01-18T11:50:37Z\",\n        \"updated_at\": \"2019-01-18T15:46:38Z\",\n        \"phones\": {}\n    },\n    \"last_transaction\": {\n        \"id\": \"tran_jad0jXPhotb2eNkr\",\n        \"transaction_type\": \"credit_card\",\n        \"funding_source\": \"prepaid\",\n        \"gateway_id\": \"6f2db50c-cb32-4211-bd71-3450e4b900f7\",\n        \"amount\": 1490,\n        \"status\": \"captured\",\n        \"success\": true,\n        \"installments\": 1,\n        \"statement_descriptor\": \"AVENGERS\",\n        \"acquirer_tid\": \"d2b3e1ab-1b24-4d66-93c8-b304776cd782\",\n        \"acquirer_nsu\": \"d2b3e1ab-1b24-4d66-93c8-b304776cd782\",\n        \"acquirer_auth_code\": \"743\",\n        \"acquirer_message\": \"TransaÃ§Ã£o capturada com sucesso\",\n        \"acquirer_return_code\": \"00\",\n        \"operation_type\": \"auth_and_capture\",\n        \"card\": {\n            \"id\": \"card_jdK2O53TqfnxwRDY\",\n            \"first_six_digits\": \"400000\",\n            \"last_four_digits\": \"0010\",\n            \"brand\": \"Visa\",\n            \"holder_name\": \"Tony Stark\",\n            \"exp_month\": 1,\n            \"exp_year\": 2030,\n            \"status\": \"active\",\n            \"type\": \"credit\",\n            \"created_at\": \"2019-01-18T12:25:41Z\",\n            \"updated_at\": \"2019-01-22T14:39:01Z\",\n            \"billing_address\": {\n                \"zip_code\": \"90265\",\n                \"city\": \"Malibu\",\n                \"state\": \"CA\",\n                \"country\": \"US\",\n                \"line_1\": \"10880, Malibu Point, Malibu Central\"\n            }\n        },\n        \"created_at\": \"2019-01-22T14:40:47Z\",\n        \"updated_at\": \"2019-01-22T14:40:47Z\",\n        \"gateway_response\": {\n            \"code\": \"200\",\n            \"errors\": []\n        }\n    },\n    \"metadata\": {\n        \"code\": \"123\"\n    }\n}"
                  }
                },
                "schema": {
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
                      "example": "2019-01-22T14:40:47Z"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2019-01-22T14:39:35Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2019-01-22T14:40:47Z"
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
                          "example": "tran_jad0jXPhotb2eNkr"
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
                          "example": "6f2db50c-cb32-4211-bd71-3450e4b900f7"
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
                          "example": "d2b3e1ab-1b24-4d66-93c8-b304776cd782"
                        },
                        "acquirer_nsu": {
                          "type": "string",
                          "example": "d2b3e1ab-1b24-4d66-93c8-b304776cd782"
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
                          "example": "2019-01-22T14:40:47Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2019-01-22T14:40:47Z"
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
              }
            }
          },
          "412": {
            "description": "412",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n  \"message\": \"This charge may not have changed the card.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "This charge may not have changed the card."
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