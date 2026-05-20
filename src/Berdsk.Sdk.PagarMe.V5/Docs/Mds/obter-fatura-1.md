# Obter fatura

AtravÃ©s do identificador da fatura (`invoice_id`) Ã© possÃ­vel recuperar as informaÃ§Ã£o da fatura.

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
    "/invoices/{invoice_id}": {
      "get": {
        "summary": "Obter fatura",
        "description": "AtravÃ©s do identificador da fatura (`invoice_id`) Ã© possÃ­vel recuperar as informaÃ§Ã£o da fatura.",
        "operationId": "obter-fatura-1",
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
        "responses": {
          "200": {
            "description": "200",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"id\": \"in_qBY5VvpuEACaw5bg\",\n    \"code\": \"O5D5FRSQ9O\",\n    \"url\": \"/invoices/in_qBY5VvpuEACaw5bg\",\n    \"amount\": 1490,\n    \"total_discounts\" :1000,\n    \"total_increments\" :1000,\n    \"status\": \"paid\",\n    \"payment_method\": \"credit_card\",\n    \"due_at\": \"2017-04-19T00:00:00Z\",\n    \"created_at\": \"2017-04-19T17:35:15Z\",\n    \"items\": [\n        {\n            \"name\": \"Nome - teste\",\n            \"amount\": 1490,\n            \"quantity\": 1,\n            \"description\": \"Premium\"\n        }\n    ],\n    \"customer\": {\n        \"id\": \"cus_mnG9AbHZmSYQRWM7\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"38acb30a-99d9-4b12-a0aa-7305c7dd81f2@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2017-04-19T17:35:05Z\",\n        \"updated_at\": \"2017-04-19T17:35:05Z\"\n    },\n    \"subscription\": {\n        \"id\": \"sub_OGE4Q1Miy1fd4B3z\",\n        \"code\": \"R7P3FNU489\",\n        \"start_at\": \"2017-04-19T00:00:00Z\",\n        \"interval\": \"month\",\n        \"interval_count\": 1,\n        \"billing_type\": \"postpaid\",\n        \"next_billing_at\": \"2017-05-19T00:00:00Z\",\n        \"payment_method\": \"credit_card\",\n        \"currency\": \"BRL\",\n        \"statement_descriptor\": \"Spotify\",\n        \"installments\": 1,\n        \"status\": \"active\",\n        \"created_at\": \"2017-04-19T17:35:06Z\",\n        \"updated_at\": \"2017-04-19T17:35:06Z\"\n    },\n    \"cycle\": {\n        \"id\": \"cycle_5JB1vZBZimCXvaRp\",\n        \"start_at\": \"2017-04-19T00:00:00Z\",\n        \"end_at\": \"2017-05-18T23:59:59Z\",\n        \"billing_at\": \"2017-05-19T00:00:00Z\"\n    },\n    \"charge\": {\n        \"id\": \"ch_OGWebzPtDCOQex2r\",\n        \"code\": \"R7P3FNU489-01\",\n        \"gateway_id\": \"729154b2-1a94-45e0-bce8-1f6966725ee5\",\n        \"amount\": 1490,\n        \"status\": \"paid\",\n        \"currency\": \"BRL\",\n        \"payment_method\": \"credit_card\",\n        \"due_at\": \"2017-04-19T00:00:00Z\",\n        \"paid_at\": \"2017-04-19T17:35:16Z\",\n        \"created_at\": \"2017-04-19T17:35:15Z\",\n        \"updated_at\": \"2017-04-19T17:35:15Z\",\n        \"last_transaction\": {\n            \"id\": \"tran_EBlMxnTRmfrg0joK\",\n            \"transaction_type\": \"credit_card\",\n            \"funding_source\": \"prepaid\",\n            \"gateway_id\": \"02bf6173-0e19-4060-836e-626c81f02749\",\n            \"amount\": 1490,\n            \"status\": \"captured\",\n            \"success\": true,\n            \"installments\": 1,\n            \"statement_descriptor\": \"Spotify\",\n            \"acquirer_name\": \"simulator\",\n            \"acquirer_affiliation_code\": \"12345\",\n            \"acquirer_tid\": \"12869\",\n            \"acquirer_nsu\": \"680036\",\n            \"acquirer_auth_code\": \"637781\",\n            \"acquirer_message\": \"Simulator|TransaÃ§Ã£o de simulaÃ§Ã£o autorizada com sucesso\",\n            \"acquirer_return_code\": \"0\",\n            \"operation_type\": \"auth_and_capture\",\n            \"card\": {\n                \"id\": \"card_x8PBA3TppSDWjrgd\",\n                \"first_six_digits\": \"542501\",\n                \"last_four_digits\": \"8229\",\n                \"brand\": \"Amex\",\n                \"holder_name\": \"Tony Stark\",\n                \"exp_month\": 1,\n                \"exp_year\": 2018,\n                \"status\": \"active\",\n                \"created_at\": \"2017-04-19T17:35:05Z\",\n                \"updated_at\": \"2017-04-19T17:35:05Z\",\n                \"billing_address\": {\n                    \"line_1\": \"10880, Malibu Point, Malibu Central\",\n                    \"zip_code\": \"90265\",\n                    \"city\": \"Malibu\",\n                    \"state\": \"CA\",\n                    \"country\": \"US\"\n                },\n                \"type\": \"credit\"\n            },\n            \"created_at\": \"2017-04-19T17:35:15Z\",\n            \"updated_at\": \"2017-04-19T17:35:15Z\",\n            \"gateway_response\": {\n                \"code\": \"201\"\n            }\n        }\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "in_qBY5VvpuEACaw5bg"
                    },
                    "code": {
                      "type": "string",
                      "example": "O5D5FRSQ9O"
                    },
                    "url": {
                      "type": "string",
                      "example": "/invoices/in_qBY5VvpuEACaw5bg"
                    },
                    "amount": {
                      "type": "integer",
                      "example": 1490,
                      "default": 0
                    },
                    "total_discounts": {
                      "type": "integer",
                      "example": 1000,
                      "default": 0
                    },
                    "total_increments": {
                      "type": "integer",
                      "example": 1000,
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
                      "example": "2017-04-19T00:00:00Z"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-19T17:35:15Z"
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
                          "example": "cus_mnG9AbHZmSYQRWM7"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "38acb30a-99d9-4b12-a0aa-7305c7dd81f2@avengers.com"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-04-19T17:35:05Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-19T17:35:05Z"
                        }
                      }
                    },
                    "subscription": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "sub_OGE4Q1Miy1fd4B3z"
                        },
                        "code": {
                          "type": "string",
                          "example": "R7P3FNU489"
                        },
                        "start_at": {
                          "type": "string",
                          "example": "2017-04-19T00:00:00Z"
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
                          "example": "2017-05-19T00:00:00Z"
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
                          "example": "2017-04-19T17:35:06Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-19T17:35:06Z"
                        }
                      }
                    },
                    "cycle": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cycle_5JB1vZBZimCXvaRp"
                        },
                        "start_at": {
                          "type": "string",
                          "example": "2017-04-19T00:00:00Z"
                        },
                        "end_at": {
                          "type": "string",
                          "example": "2017-05-18T23:59:59Z"
                        },
                        "billing_at": {
                          "type": "string",
                          "example": "2017-05-19T00:00:00Z"
                        }
                      }
                    },
                    "charge": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "ch_OGWebzPtDCOQex2r"
                        },
                        "code": {
                          "type": "string",
                          "example": "R7P3FNU489-01"
                        },
                        "gateway_id": {
                          "type": "string",
                          "example": "729154b2-1a94-45e0-bce8-1f6966725ee5"
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
                          "example": "2017-04-19T00:00:00Z"
                        },
                        "paid_at": {
                          "type": "string",
                          "example": "2017-04-19T17:35:16Z"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-04-19T17:35:15Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-19T17:35:15Z"
                        },
                        "last_transaction": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "tran_EBlMxnTRmfrg0joK"
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
                              "example": "02bf6173-0e19-4060-836e-626c81f02749"
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
                              "example": "12869"
                            },
                            "acquirer_nsu": {
                              "type": "string",
                              "example": "680036"
                            },
                            "acquirer_auth_code": {
                              "type": "string",
                              "example": "637781"
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
                                  "example": "card_x8PBA3TppSDWjrgd"
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
                                  "example": "2017-04-19T17:35:05Z"
                                },
                                "updated_at": {
                                  "type": "string",
                                  "example": "2017-04-19T17:35:05Z"
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
                              "example": "2017-04-19T17:35:15Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2017-04-19T17:35:15Z"
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