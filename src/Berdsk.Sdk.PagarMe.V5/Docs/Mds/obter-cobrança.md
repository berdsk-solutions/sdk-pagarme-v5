# Obter cobranÃ§a

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
      "get": {
        "summary": "Obter cobranÃ§a",
        "description": "",
        "operationId": "obter-cobranÃ§a",
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
        "responses": {
          "200": {
            "description": "200",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"id\": \"ch_6NXoYXyiNfP3A54l\",\n    \"code\": \"ABCDE123\",\n    \"amount\": 1490,\n    \"paid_amount\": 1490,\n    \"status\": \"paid\",\n    \"currency\": \"BRL\",\n    \"payment_method\": \"credit_card\",\n    \"paid_at\": \"2019-01-22T14:31:36Z\",\n    \"created_at\": \"2019-01-22T14:30:12Z\",\n    \"updated_at\": \"2019-01-22T14:31:36Z\",\n    \"customer\": {\n        \"id\": \"cus_PYwJvWgOTmiqvW8m\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"toinhodalua@nasa.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2019-01-18T11:50:37Z\",\n        \"updated_at\": \"2019-01-18T15:46:38Z\",\n        \"phones\": {}\n    },\n    \"last_transaction\": {\n        \"id\": \"tran_QGXDnycJdHKnoVa3\",\n        \"transaction_type\": \"credit_card\",\n        \"funding_source\": \"prepaid\",\n        \"amount\": 1490,\n        \"status\": \"captured\",\n        \"success\": true,\n        \"installments\": 1,\n        \"statement_descriptor\": \"AVENGERS\",\n        \"acquirer_tid\": \"cb42d188-aca6-46f2-a2c9-046cb6342f5d\",\n        \"acquirer_nsu\": \"cb42d188-aca6-46f2-a2c9-046cb6342f5d\",\n        \"acquirer_auth_code\": \"416\",\n        \"acquirer_message\": \"TransaÃ§Ã£o capturada com sucesso\",\n        \"acquirer_return_code\": \"00\",\n        \"operation_type\": \"capture\",\n        \"card\": {\n            \"id\": \"card_jdK2O53TqfnxwRDY\",\n            \"first_six_digits\": \"400000\",\n            \"last_four_digits\": \"0010\",\n            \"brand\": \"Visa\",\n            \"holder_name\": \"Tony Stark\",\n            \"exp_month\": 1,\n            \"exp_year\": 2020,\n            \"status\": \"active\",\n            \"type\": \"credit\",\n            \"created_at\": \"2019-01-18T12:25:41Z\",\n            \"updated_at\": \"2019-01-22T14:30:12Z\"\n        },\n        \"created_at\": \"2019-01-22T14:31:36Z\",\n        \"updated_at\": \"2019-01-22T14:31:36Z\",\n        \"gateway_response\": {\n            \"code\": \"200\",\n            \"errors\": []\n        }\n    },\n    \"metadata\": {\n        \"code\": \"123\"\n    }\n}"
                  },
                  "OK - Network Token": {
                    "value": "{\n    \"id\": \"ch_Ljvke06fdSErl62x\",\n    \"code\": \"Y387TKKF3L\",\n    \"amount\": 2990,\n    \"paid_amount\": 2990,\n    \"status\": \"paid\",\n    \"currency\": \"BRL\",\n    \"payment_method\": \"credit_card\",\n    \"paid_at\": \"2023-03-17T14:20:28Z\",\n    \"created_at\": \"2023-03-17T14:20:28Z\",\n    \"updated_at\": \"2023-03-17T14:20:28Z\",\n    \"order\": {\n        \"id\": \"or_5aEYRKmIwvTqpgoQ\",\n        \"code\": \"Y387TKKF3L\",\n        \"amount\": 2990,\n        \"closed\": true,\n        \"created_at\": \"2023-03-17T14:20:27Z\",\n        \"updated_at\": \"2023-03-17T14:20:28Z\",\n        \"closed_at\": \"2023-03-17T14:20:27Z\",\n        \"currency\": \"BRL\",\n        \"status\": \"paid\",\n        \"customer_id\": \"cus_K1oa3LKTZSlW6O7d\"\n    },\n    \"customer\": {\n        \"id\": \"cus_K1oa3LKTZSlW6O7d\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"avengerstark@ligadajustica.com.br\",\n        \"delinquent\": false,\n        \"created_at\": \"2023-03-17T14:19:22Z\",\n        \"updated_at\": \"2023-03-17T14:19:22Z\",\n        \"phones\": {}\n    },\n    \"last_transaction\": {\n        \"operation_key\": \"409945098\",\n        \"id\": \"tran_xbEM0pRmUASgBYAq\",\n        \"transaction_type\": \"credit_card\",\n        \"gateway_id\": \"95e3e8f1-c5fc-4d62-8f0b-80bdc66d3e42\",\n        \"amount\": 2990,\n        \"status\": \"captured\",\n        \"success\": true,\n        \"installments\": 1,\n        \"installment_type\": \"merchant\",\n        \"statement_descriptor\": \"AVENGERS\",\n        \"acquirer_name\": \"simulator\",\n        \"acquirer_tid\": \"894247649\",\n        \"acquirer_nsu\": \"49640\",\n        \"acquirer_auth_code\": \"169\",\n        \"acquirer_message\": \"TransaÃ§Ã£o capturada com sucesso\",\n        \"acquirer_return_code\": \"00\",\n        \"entry_mode\": \"ecommerce\",\n        \"operation_type\": \"auth_and_capture\",\n        \"card\": {\n            \"id\": \"card_DwER6M8Cl9hPKAOb\",\n            \"first_six_digits\": \"400000\",\n            \"last_four_digits\": \"0010\",\n            \"brand\": \"Visa\",\n            \"holder_name\": \"Homelander\",\n            \"exp_month\": 12,\n            \"exp_year\": 2025,\n            \"status\": \"active\",\n            \"type\": \"credit\",\n            \"created_at\": \"2023-03-17T14:19:43Z\",\n            \"updated_at\": \"2023-03-17T14:19:43Z\",\n            \"billing_address\": {\n                \"zip_code\": \"90265\",\n                \"city\": \"Malibu\",\n                \"state\": \"CA\",\n                \"country\": \"US\",\n                \"line_1\": \"10880, Malibu Point, Malibu Central\"\n            },\n            \"network_token\": {\n                \"token_unique_reference\": \"9cb80642-e3b6-4b30-b233-c54a4857cbf0\",\n                \"status\": \"active\"\n            }\n        },\n        \"payment_type\": \"Token\",\n        \"created_at\": \"2023-03-17T14:20:28Z\",\n        \"updated_at\": \"2023-03-17T14:20:28Z\",\n        \"gateway_response\": {\n            \"code\": \"200\",\n            \"errors\": []\n        },\n        \"antifraud_response\": {},\n        \"metadata\": {}\n    }\n}"
                  }
                },
                "schema": {
                  "oneOf": [
                    {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "ch_6NXoYXyiNfP3A54l"
                        },
                        "code": {
                          "type": "string",
                          "example": "ABCDE123"
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
                          "example": "2019-01-22T14:31:36Z"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2019-01-22T14:30:12Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2019-01-22T14:31:36Z"
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
                              "example": "tran_QGXDnycJdHKnoVa3"
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
                              "example": "cb42d188-aca6-46f2-a2c9-046cb6342f5d"
                            },
                            "acquirer_nsu": {
                              "type": "string",
                              "example": "cb42d188-aca6-46f2-a2c9-046cb6342f5d"
                            },
                            "acquirer_auth_code": {
                              "type": "string",
                              "example": "416"
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
                              "example": "capture"
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
                                  "example": 2020,
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
                                  "example": "2019-01-22T14:30:12Z"
                                }
                              }
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2019-01-22T14:31:36Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2019-01-22T14:31:36Z"
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
                      "title": "OK - Network Token",
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "ch_Ljvke06fdSErl62x"
                        },
                        "code": {
                          "type": "string",
                          "example": "Y387TKKF3L"
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
                          "example": "2023-03-17T14:20:28Z"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2023-03-17T14:20:28Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2023-03-17T14:20:28Z"
                        },
                        "order": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "or_5aEYRKmIwvTqpgoQ"
                            },
                            "code": {
                              "type": "string",
                              "example": "Y387TKKF3L"
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
                              "example": "2023-03-17T14:20:27Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2023-03-17T14:20:28Z"
                            },
                            "closed_at": {
                              "type": "string",
                              "example": "2023-03-17T14:20:27Z"
                            },
                            "currency": {
                              "type": "string",
                              "example": "BRL"
                            },
                            "status": {
                              "type": "string",
                              "example": "paid"
                            },
                            "customer_id": {
                              "type": "string",
                              "example": "cus_K1oa3LKTZSlW6O7d"
                            }
                          }
                        },
                        "customer": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "cus_K1oa3LKTZSlW6O7d"
                            },
                            "name": {
                              "type": "string",
                              "example": "Tony Stark"
                            },
                            "email": {
                              "type": "string",
                              "example": "avengerstark@ligadajustica.com.br"
                            },
                            "delinquent": {
                              "type": "boolean",
                              "example": false,
                              "default": true
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2023-03-17T14:19:22Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2023-03-17T14:19:22Z"
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
                            "operation_key": {
                              "type": "string",
                              "example": "409945098"
                            },
                            "id": {
                              "type": "string",
                              "example": "tran_xbEM0pRmUASgBYAq"
                            },
                            "transaction_type": {
                              "type": "string",
                              "example": "credit_card"
                            },
                            "gateway_id": {
                              "type": "string",
                              "example": "95e3e8f1-c5fc-4d62-8f0b-80bdc66d3e42"
                            },
                            "amount": {
                              "type": "integer",
                              "example": 2990,
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
                            "installment_type": {
                              "type": "string",
                              "example": "merchant"
                            },
                            "statement_descriptor": {
                              "type": "string",
                              "example": "AVENGERS"
                            },
                            "acquirer_name": {
                              "type": "string",
                              "example": "simulator"
                            },
                            "acquirer_tid": {
                              "type": "string",
                              "example": "894247649"
                            },
                            "acquirer_nsu": {
                              "type": "string",
                              "example": "49640"
                            },
                            "acquirer_auth_code": {
                              "type": "string",
                              "example": "169"
                            },
                            "acquirer_message": {
                              "type": "string",
                              "example": "TransaÃ§Ã£o capturada com sucesso"
                            },
                            "acquirer_return_code": {
                              "type": "string",
                              "example": "00"
                            },
                            "entry_mode": {
                              "type": "string",
                              "example": "ecommerce"
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
                                  "example": "card_DwER6M8Cl9hPKAOb"
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
                                  "example": "Homelander"
                                },
                                "exp_month": {
                                  "type": "integer",
                                  "example": 12,
                                  "default": 0
                                },
                                "exp_year": {
                                  "type": "integer",
                                  "example": 2025,
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
                                  "example": "2023-03-17T14:19:43Z"
                                },
                                "updated_at": {
                                  "type": "string",
                                  "example": "2023-03-17T14:19:43Z"
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
                                },
                                "network_token": {
                                  "type": "object",
                                  "properties": {
                                    "token_unique_reference": {
                                      "type": "string",
                                      "example": "9cb80642-e3b6-4b30-b233-c54a4857cbf0"
                                    },
                                    "status": {
                                      "type": "string",
                                      "example": "active"
                                    }
                                  }
                                }
                              }
                            },
                            "payment_type": {
                              "type": "string",
                              "example": "Token"
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2023-03-17T14:20:28Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2023-03-17T14:20:28Z"
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