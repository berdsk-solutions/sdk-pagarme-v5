# Confirmar cobranÃ§a (cash)

Para a confirmaÃ§Ã£o de cobranÃ§as com meio de pagamento `cash` com o status `pending`.

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
    "/charges/{charge_id}/confirm-payment": {
      "post": {
        "summary": "Confirmar cobranÃ§a (cash)",
        "description": "Para a confirmaÃ§Ã£o de cobranÃ§as com meio de pagamento `cash` com o status `pending`.",
        "operationId": "confirmar-cobranÃ§a-cash",
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
                    "description": "Valor a ser confirmado. Caso nÃ£o seja informado, serÃ¡ considerado o valor total da cobranÃ§a",
                    "format": "int32"
                  },
                  "code": {
                    "type": "string",
                    "description": "CÃ³digo da cobranÃ§a no sistema da loja. IrÃ¡ atualizar o valor informado na criaÃ§Ã£o da cobranÃ§a. Max: 52 caracteres"
                  },
                  "description": {
                    "type": "string",
                    "description": "DescriÃ§Ã£o"
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
                    "value": "{\n  \"id\": \"ch_7YBoBPWCVKS3QdyM\",\n  \"code\": \"WZQS3LHEKW\",\n  \"gateway_id\": \"42c243c4-0b52-49f3-ba92-e8661ebc7916\",\n  \"amount\": 1490,\n  \"status\": \"paid\",\n  \"currency\": \"BRL\",\n  \"payment_method\": \"credit_card\",\n  \"due_at\": \"2017-04-04T00:00:00\",\n  \"paid_at\": \"2017-04-04T20:06:14\",\n  \"created_at\": \"2017-04-04T20:05:39\",\n  \"updated_at\": \"2017-04-04T20:06:14\",\n  \"customer\": {\n    \"id\": \"cus_aEkwKv0SmNHMR931\",\n    \"name\": \"Luke Skywalker\",\n    \"email\": \"lskywalker@r2d2.com\",\n    \"delinquent\": false,\n    \"created_at\": \"2017-04-04T19:41:31\",\n    \"updated_at\": \"2017-04-04T19:41:31\"\n  },\n  \"last_transaction\": {\n    \"id\": \"tran_9KYq34mcDfOnXg1Z\",\n    \"transaction_type\": \"credit_card\",\n    \"gateway_id\": \"d8033a7c-2d31-4840-8870-8a71bd16cacc\",\n    \"amount\": 1490,\n    \"status\": \"captured\",\n    \"success\": true,\n    \"installments\": 1,\n    \"statement_descriptor\": \"Spotify\",\n    \"acquirer_name\": \"simulator\",\n    \"acquirer_affiliation_code\": \"MUNDI\",\n    \"acquirer_tid\": \"856202\",\n    \"acquirer_nsu\": \"503081\",\n    \"acquirer_auth_code\": \"405205\",\n    \"operation_type\": \"capture\",\n    \"credit_card\": {\n      \"id\": \"card_2bKzdEGsYYFkymqG\",\n      \"first_six_digits\": \"542501\",\n      \"last_four_digits\": \"5322\",\n      \"brand\": \"Visa\",\n      \"holder_name\": \"Luke Skywalker\",\n      \"exp_month\": 5,\n      \"exp_year\": 2017,\n      \"status\": \"active\",\n      \"created_at\": \"2017-04-04T19:41:31\",\n      \"updated_at\": \"2017-04-04T19:41:31\",\n      \"billing_address\": {\n        \"zip_code\": \"90265\",\n        \"city\": \"Malibu\",\n        \"state\": \"CA\",\n        \"country\": \"US\",\n         \"line_1\": \"10880, Malibu Point, Malibu Central\"\n      }\n    },\n    \"created_at\": \"2017-04-04T20:06:14\",\n    \"updated_at\": \"2017-04-04T20:06:14\"\n  },\n  \"metadata\": {\n    \"id\": \"my_charge_id\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "ch_7YBoBPWCVKS3QdyM"
                    },
                    "code": {
                      "type": "string",
                      "example": "WZQS3LHEKW"
                    },
                    "gateway_id": {
                      "type": "string",
                      "example": "42c243c4-0b52-49f3-ba92-e8661ebc7916"
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
                      "example": "2017-04-04T00:00:00"
                    },
                    "paid_at": {
                      "type": "string",
                      "example": "2017-04-04T20:06:14"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-04T20:05:39"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-04-04T20:06:14"
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_aEkwKv0SmNHMR931"
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
                          "example": "2017-04-04T19:41:31"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-04T19:41:31"
                        }
                      }
                    },
                    "last_transaction": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "tran_9KYq34mcDfOnXg1Z"
                        },
                        "transaction_type": {
                          "type": "string",
                          "example": "credit_card"
                        },
                        "gateway_id": {
                          "type": "string",
                          "example": "d8033a7c-2d31-4840-8870-8a71bd16cacc"
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
                          "example": "Spotify"
                        },
                        "acquirer_name": {
                          "type": "string",
                          "example": "simulator"
                        },
                        "acquirer_affiliation_code": {
                          "type": "string",
                          "example": "MUNDI"
                        },
                        "acquirer_tid": {
                          "type": "string",
                          "example": "856202"
                        },
                        "acquirer_nsu": {
                          "type": "string",
                          "example": "503081"
                        },
                        "acquirer_auth_code": {
                          "type": "string",
                          "example": "405205"
                        },
                        "operation_type": {
                          "type": "string",
                          "example": "capture"
                        },
                        "credit_card": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "card_2bKzdEGsYYFkymqG"
                            },
                            "first_six_digits": {
                              "type": "string",
                              "example": "542501"
                            },
                            "last_four_digits": {
                              "type": "string",
                              "example": "5322"
                            },
                            "brand": {
                              "type": "string",
                              "example": "Visa"
                            },
                            "holder_name": {
                              "type": "string",
                              "example": "Luke Skywalker"
                            },
                            "exp_month": {
                              "type": "integer",
                              "example": 5,
                              "default": 0
                            },
                            "exp_year": {
                              "type": "integer",
                              "example": 2017,
                              "default": 0
                            },
                            "status": {
                              "type": "string",
                              "example": "active"
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2017-04-04T19:41:31"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2017-04-04T19:41:31"
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
                          "example": "2017-04-04T20:06:14"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-04T20:06:14"
                        }
                      }
                    },
                    "metadata": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "my_charge_id"
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
                    "value": "{\n  \"message\": \"This charge can not be captured.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "This charge can not be captured."
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