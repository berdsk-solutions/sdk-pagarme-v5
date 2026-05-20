# Criar fatura

Este recurso cria uma fatura (`invoice`) de acordo com o identificador do ciclo a ser cobrado (`cycle_id`) de um
determinada assinatura (`subscription_id`).

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
    "/subscriptions/{subscription_id}/cycles/{cycle_id}/pay": {
      "post": {
        "summary": "Criar fatura",
        "description": "Este recurso cria uma fatura (`invoice`) de acordo com o identificador do ciclo a ser cobrado (`cycle_id`) de um determinada assinatura (`subscription_id`).",
        "operationId": "criar-fatura-1",
        "parameters": [
          {
            "name": "subscription_id",
            "in": "path",
            "description": "CÃ³digo da assinatura.<br>Formato: `sub_XXXXXXXXXXXXXXXX`.",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "cycle_id",
            "in": "path",
            "description": "CÃ³digo do ciclo.<br>Formato: `cycle_XXXXXXXXXXXXXXXX`.",
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
                  "metadata": {
                    "type": "string",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre a fatura. [Saiba mais sobre metadata](https://docs.pagar.me/reference/metadata-1)"
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
                    "value": "{\n    \"id\": \"in_6d2BVXnaUdT8DOkL\",\n    \"code\": \"59QDSPB5NP\",\n    \"url\": \"/invoices/in_6d2BVXnaUdT8DOkL\",\n    \"amount\": 1490,\n    \"status\": \"paid\",\n    \"payment_method\": \"credit_card\",\n    \"due_at\": \"2017-04-04T00:00:00Z\",\n    \"created_at\": \"2017-04-04T15:10:35Z\",\n    \"items\": [\n        {\n            \"name\": \"Nome - teste\",\n            \"amount\": 1490,\n            \"quantity\": 1,\n            \"description\": \"Bola\"\n        }\n    ],\n    \"customer\": {\n        \"id\": \"cus_J4wRXJ0U6ytZrpAx\",\n        \"name\": \"Tony Star8k\",\n        \"email\": \"tstark@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2016-09-28T21:04:37Z\",\n        \"updated_at\": \"2017-04-04T15:08:20Z\"\n    },\n    \"subscription\": {\n        \"id\": \"sub_KrmEXBxHVIRAJxDG\",\n        \"code\": \"KERZFJ6TQZ\",\n        \"start_at\": \"2017-04-04T00:00:00Z\",\n        \"interval\": \"month\",\n        \"interval_count\": 1,\n        \"billing_type\": \"postpaid\",\n        \"next_billing_at\": \"2017-05-04T00:00:00Z\",\n        \"payment_method\": \"credit_card\",\n        \"currency\": \"BRL\",\n        \"statement_descriptor\": \"Spotify\",\n        \"installments\": 1,\n        \"status\": \"active\",\n        \"created_at\": \"2017-04-04T15:10:01Z\",\n        \"updated_at\": \"2017-04-04T15:10:01Z\"\n    },\n    \"cycle\": {\n        \"id\": \"cycle_WE1ZYoX7uEfbRar4\",\n        \"start_at\": \"2017-04-04T00:00:00Z\",\n        \"end_at\": \"2017-05-03T23:59:59\",\n        \"billing_at\": \"2017-05-04T00:00:00Z\"\n    },\n    \"charge\": {\n        \"id\": \"ch_x75JLo9SRFnEo6jY\",\n        \"code\": \"KERZFJ6TQZ-01\",\n        \"gateway_id\": \"477bcafc-194b-4aa9-bb18-6fc621e49c22\",\n        \"amount\": 1490,\n        \"status\": \"paid\",\n        \"currency\": \"BRL\",\n        \"payment_method\": \"credit_card\",\n        \"due_at\": \"2017-04-04T00:00:00Z\",\n        \"paid_at\": \"2017-04-04T15:10:46Z\",\n        \"created_at\": \"2017-04-04T15:10:35Z\",\n        \"updated_at\": \"2017-04-04T15:10:35Z\",\n        \"last_transaction\": {\n            \"id\": \"tran_mnVqmLOfJGhzWKzW\",\n            \"transaction_type\": \"credit_card\",\n            \"funding_source\": \"prepaid\",\n            \"gateway_id\": \"da859279-6251-4721-9909-4d8a1142f098\",\n            \"amount\": 1490,\n            \"status\": \"captured\",\n            \"success\": true,\n            \"installments\": 1,\n            \"statement_descriptor\": \"Spotify\",\n            \"acquirer_name\": \"simulator\",\n            \"acquirer_affiliation_code\": \"12345\",\n            \"acquirer_tid\": \"704735\",\n            \"acquirer_nsu\": \"999048\",\n            \"acquirer_auth_code\": \"468669\",\n            \"acquirer_message\": \"Simulator|TransaÃ§Ã£o de simulaÃ§Ã£o autorizada com sucesso\",\n            \"acquirer_return_code\": \"0\",\n            \"operation_type\": \"auth_and_capture\",\n            \"credit_card\": {\n                \"id\": \"card_pEYq7rDbFeiW8V6k\",\n                \"first_six_digits\": \"542501\",\n                \"last_four_digits\": \"8229\",\n                \"brand\": \"Amex\",\n                \"holder_name\": \"Tony Stark\",\n                \"exp_month\": 1,\n                \"exp_year\": 2018,\n                \"status\": \"active\",\n                \"created_at\": \"2016-11-16T17:02:39Z\",\n                \"updated_at\": \"2016-12-29T12:03:24Z\",\n                \"billing_address\": {\n                    \"line_1\": \"10880, Malibu Point, Malibu Central\",\n                    \"zip_code\": \"90265\",\n                    \"city\": \"Malibu\",\n                    \"state\": \"CA\",\n                    \"country\": \"US\"\n                }\n            },\n            \"created_at\": \"2017-04-04T15:10:35Z\",\n            \"updated_at\": \"2017-04-04T15:10:35Z\"\n        }\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "in_6d2BVXnaUdT8DOkL"
                    },
                    "code": {
                      "type": "string",
                      "example": "59QDSPB5NP"
                    },
                    "url": {
                      "type": "string",
                      "example": "/invoices/in_6d2BVXnaUdT8DOkL"
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
                      "example": "2017-04-04T15:10:35Z"
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
                          "example": "sub_KrmEXBxHVIRAJxDG"
                        },
                        "code": {
                          "type": "string",
                          "example": "KERZFJ6TQZ"
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
                          "example": "2017-04-04T15:10:01Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-04T15:10:01Z"
                        }
                      }
                    },
                    "cycle": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cycle_WE1ZYoX7uEfbRar4"
                        },
                        "start_at": {
                          "type": "string",
                          "example": "2017-04-04T00:00:00Z"
                        },
                        "end_at": {
                          "type": "string",
                          "example": "2017-05-03T23:59:59"
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
                          "example": "ch_x75JLo9SRFnEo6jY"
                        },
                        "code": {
                          "type": "string",
                          "example": "KERZFJ6TQZ-01"
                        },
                        "gateway_id": {
                          "type": "string",
                          "example": "477bcafc-194b-4aa9-bb18-6fc621e49c22"
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
                          "example": "2017-04-04T15:10:46Z"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-04-04T15:10:35Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-04T15:10:35Z"
                        },
                        "last_transaction": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "tran_mnVqmLOfJGhzWKzW"
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
                              "example": "da859279-6251-4721-9909-4d8a1142f098"
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
                              "example": "12345"
                            },
                            "acquirer_tid": {
                              "type": "string",
                              "example": "704735"
                            },
                            "acquirer_nsu": {
                              "type": "string",
                              "example": "999048"
                            },
                            "acquirer_auth_code": {
                              "type": "string",
                              "example": "468669"
                            },
                            "acquirer_message": {
                              "type": "string",
                              "example": "Simulator|TransaÃ§Ã£o de simulaÃ§Ã£o autorizada com sucesso"
                            },
                            "acquirer_return_code": {
                              "type": "string",
                              "example": "0"
                            },
                            "operation_type": {
                              "type": "string",
                              "example": "auth_and_capture"
                            },
                            "credit_card": {
                              "type": "object",
                              "properties": {
                                "id": {
                                  "type": "string",
                                  "example": "card_pEYq7rDbFeiW8V6k"
                                },
                                "first_six_digits": {
                                  "type": "string",
                                  "example": "542501"
                                },
                                "last_four_digits": {
                                  "type": "string",
                                  "example": "8229"
                                },
                                "brand": {
                                  "type": "string",
                                  "example": "Amex"
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
                                  "example": 2018,
                                  "default": 0
                                },
                                "status": {
                                  "type": "string",
                                  "example": "active"
                                },
                                "created_at": {
                                  "type": "string",
                                  "example": "2016-11-16T17:02:39Z"
                                },
                                "updated_at": {
                                  "type": "string",
                                  "example": "2016-12-29T12:03:24Z"
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
                            "created_at": {
                              "type": "string",
                              "example": "2017-04-04T15:10:35Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2017-04-04T15:10:35Z"
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
          "412": {
            "description": "412",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n  \"message\": \"This cycle has been billed.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "This cycle has been billed."
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