# Editar metadados da fatura

Com o verbo _HTTP PATCH_, atravÃ©s do identificador da fatura (`invoice_id`) Ã© possÃ­vel atualizar o objeto `metadata` da
fatura.

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
    "/invoices/{invoice_id}/metadata": {
      "patch": {
        "summary": "Editar metadados da fatura",
        "description": "Com o verbo _HTTP PATCH_, atravÃ©s do identificador da fatura (`invoice_id`) Ã© possÃ­vel atualizar o objeto `metadata` da fatura.",
        "operationId": "editar-metadados-da-fatura-1",
        "parameters": [
          {
            "name": "invoice_id",
            "in": "path",
            "description": "CÃ³digo da fatura.<br>Formato: `in_XXXXXXXXXXXXXXXX`.",
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
                "required": [
                  "metadata"
                ],
                "properties": {
                  "metadata": {
                    "type": "string",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre a fatura.<br>[Saiba mais sobre metadata](https://docs.pagar.me/reference/metadata-1)"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "metadata": {
                      "code": "1234",
                      "company": "Avengers"
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
                    "value": "{\n    \"id\": \"in_l9JGwX1MsNS3g614\",\n    \"code\": \"X8J8HG6HR3\",\n    \"url\": \"/invoices/in_l9JGwX1MsNS3g614\",\n    \"amount\": 1490,\n    \"status\": \"paid\",\n    \"payment_method\": \"credit_card\",\n    \"due_at\": \"2017-08-10T00:00:00Z\",\n    \"created_at\": \"2017-08-10T16:02:40Z\",\n    \"items\": [\n        {\n            \"name\": \"Nome - teste\",\n            \"amount\": 1490,\n            \"quantity\": 1,\n            \"description\": \"Premium\"\n        }\n    ],\n    \"customer\": {\n        \"id\": \"cus_2j4vnqJseriZOM0G\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"ce7bd9d7-a959-4f64-8070-896c2d968c9a@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2017-08-10T16:02:28Z\",\n        \"updated_at\": \"2017-08-10T16:02:28Z\",\n        \"phones\": {}\n    },\n    \"subscription\": {\n        \"id\": \"sub_Rg80VjCmxt4N0Oma\",\n        \"code\": \"R66DU1I4PR\",\n        \"start_at\": \"2017-08-10T00:00:00Z\",\n        \"interval\": \"month\",\n        \"interval_count\": 1,\n        \"billing_type\": \"postpaid\",\n        \"next_billing_at\": \"2017-09-10T00:00:00Z\",\n        \"payment_method\": \"credit_card\",\n        \"currency\": \"BRL\",\n        \"statement_descriptor\": \"Spotify\",\n        \"installments\": 1,\n        \"status\": \"active\",\n        \"created_at\": \"2017-08-10T16:02:30Z\",\n        \"updated_at\": \"2017-08-10T16:02:30Z\"\n    },\n    \"cycle\": {\n        \"id\": \"cycle_zObQAYfOqUnMQMkB\",\n        \"start_at\": \"2017-08-10T00:00:00Z\",\n        \"end_at\": \"2017-09-09T23:59:59Z\",\n        \"billing_at\": \"2017-09-10T00:00:00Z\"\n    },\n    \"charge\": {\n        \"id\": \"ch_Wl2YRDrSOFq1Ax4r\",\n        \"code\": \"R66DU1I4PR-01\",\n        \"gateway_id\": \"798d388b-3e92-4ad1-a0be-893a2391c7fa\",\n        \"amount\": 1490,\n        \"paid_amount\": 1490,\n        \"status\": \"paid\",\n        \"currency\": \"BRL\",\n        \"payment_method\": \"credit_card\",\n        \"due_at\": \"2017-08-10T00:00:00Z\",\n        \"paid_at\": \"2017-08-10T16:02:41Z\",\n        \"created_at\": \"2017-08-10T16:02:40Z\",\n        \"updated_at\": \"2017-08-10T16:02:40Z\",\n        \"last_transaction\": {\n            \"id\": \"tran_x7lNYXuPLS1np4n1\",\n            \"transaction_type\": \"credit_card\",\n            \"funding_source\": \"prepaid\",\n            \"gateway_id\": \"a4f98f29-c720-4682-985e-f18234160be1\",\n            \"amount\": 1490,\n            \"status\": \"captured\",\n            \"success\": true,\n            \"installments\": 1,\n            \"statement_descriptor\": \"Spotify\",\n            \"acquirer_name\": \"simulator\",\n            \"acquirer_affiliation_code\": \"TesteMaroto\",\n            \"acquirer_tid\": \"21407\",\n            \"acquirer_nsu\": \"743230\",\n            \"acquirer_auth_code\": \"214846\",\n            \"acquirer_message\": \"Simulator|TransaÃ§Ã£o de simulaÃ§Ã£o autorizada com sucesso\",\n            \"acquirer_return_code\": \"0\",\n            \"operation_type\": \"auth_and_capture\",\n            \"card\": {\n                \"id\": \"card_brVjYG5uZSrNARPg\",\n                \"first_six_digits\": \"342793\",\n                \"last_four_digits\": \"8229\",\n                \"brand\": \"Amex\",\n                \"holder_name\": \"Tony Stark\",\n                \"exp_month\": 1,\n                \"exp_year\": 2018,\n                \"status\": \"active\",\n                \"created_at\": \"2017-08-10T16:02:28Z\",\n                \"updated_at\": \"2017-08-10T16:02:28Z\",\n                \"billing_address\": {\n                    \"line_1\": \"10880, Malibu Point, Malibu Central\",\n                    \"zip_code\": \"90265\",\n                    \"city\": \"Malibu\",\n                    \"state\": \"CA\",\n                    \"country\": \"US\"\n                },\n                \"type\": \"credit\"\n            },\n            \"created_at\": \"2017-08-10T16:02:40Z\",\n            \"updated_at\": \"2017-08-10T16:02:40Z\",\n            \"gateway_response\": {\n                \"code\": \"201\"\n            }\n        }\n    },\n    \"metadata\": {\n        \"code\": \"1234\",\n        \"company\": \"Avengers\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "in_l9JGwX1MsNS3g614"
                    },
                    "code": {
                      "type": "string",
                      "example": "X8J8HG6HR3"
                    },
                    "url": {
                      "type": "string",
                      "example": "/invoices/in_l9JGwX1MsNS3g614"
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
                      "example": "2017-08-10T00:00:00Z"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-08-10T16:02:40Z"
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
                            "example": "Premium"
                          }
                        }
                      }
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_2j4vnqJseriZOM0G"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "ce7bd9d7-a959-4f64-8070-896c2d968c9a@avengers.com"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-08-10T16:02:28Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-08-10T16:02:28Z"
                        },
                        "phones": {
                          "type": "object",
                          "properties": {}
                        }
                      }
                    },
                    "subscription": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "sub_Rg80VjCmxt4N0Oma"
                        },
                        "code": {
                          "type": "string",
                          "example": "R66DU1I4PR"
                        },
                        "start_at": {
                          "type": "string",
                          "example": "2017-08-10T00:00:00Z"
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
                          "example": "2017-09-10T00:00:00Z"
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
                          "example": "2017-08-10T16:02:30Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-08-10T16:02:30Z"
                        }
                      }
                    },
                    "cycle": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cycle_zObQAYfOqUnMQMkB"
                        },
                        "start_at": {
                          "type": "string",
                          "example": "2017-08-10T00:00:00Z"
                        },
                        "end_at": {
                          "type": "string",
                          "example": "2017-09-09T23:59:59Z"
                        },
                        "billing_at": {
                          "type": "string",
                          "example": "2017-09-10T00:00:00Z"
                        }
                      }
                    },
                    "charge": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "ch_Wl2YRDrSOFq1Ax4r"
                        },
                        "code": {
                          "type": "string",
                          "example": "R66DU1I4PR-01"
                        },
                        "gateway_id": {
                          "type": "string",
                          "example": "798d388b-3e92-4ad1-a0be-893a2391c7fa"
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
                        "due_at": {
                          "type": "string",
                          "example": "2017-08-10T00:00:00Z"
                        },
                        "paid_at": {
                          "type": "string",
                          "example": "2017-08-10T16:02:41Z"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-08-10T16:02:40Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-08-10T16:02:40Z"
                        },
                        "last_transaction": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "tran_x7lNYXuPLS1np4n1"
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
                              "example": "a4f98f29-c720-4682-985e-f18234160be1"
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
                              "example": "TesteMaroto"
                            },
                            "acquirer_tid": {
                              "type": "string",
                              "example": "21407"
                            },
                            "acquirer_nsu": {
                              "type": "string",
                              "example": "743230"
                            },
                            "acquirer_auth_code": {
                              "type": "string",
                              "example": "214846"
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
                            "card": {
                              "type": "object",
                              "properties": {
                                "id": {
                                  "type": "string",
                                  "example": "card_brVjYG5uZSrNARPg"
                                },
                                "first_six_digits": {
                                  "type": "string",
                                  "example": "342793"
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
                                  "example": "2017-08-10T16:02:28Z"
                                },
                                "updated_at": {
                                  "type": "string",
                                  "example": "2017-08-10T16:02:28Z"
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
                                },
                                "type": {
                                  "type": "string",
                                  "example": "credit"
                                }
                              }
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2017-08-10T16:02:40Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2017-08-10T16:02:40Z"
                            },
                            "gateway_response": {
                              "type": "object",
                              "properties": {
                                "code": {
                                  "type": "string",
                                  "example": "201"
                                }
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
                          "example": "1234"
                        },
                        "company": {
                          "type": "string",
                          "example": "Avengers"
                        }
                      }
                    }
                  }
                }
              }
            }
          },
          "404": {
            "description": "404",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"message\": \"Invoice not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Invoice not found."
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