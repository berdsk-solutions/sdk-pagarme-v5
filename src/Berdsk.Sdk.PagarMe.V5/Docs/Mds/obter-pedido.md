# Obter pedido

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
    "/orders/{order_id}": {
      "get": {
        "summary": "Obter pedido",
        "description": "",
        "operationId": "obter-pedido",
        "parameters": [
          {
            "name": "order_id",
            "in": "path",
            "description": "CÃ³digo identificador do pedido no sistema da loja. Max: 52 caracteres.",
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
                    "value": "{\n  \"id\": \"or_28dN9w7CLU79kDjL\",\n  \"code\": \"62LVFN7I4R\",\n  \"amount\": 2990,\n  \"currency\": \"BRL\",\n  \"closed\": true,\n  \"items\": [\n    {\n      \"id\": \"oi_d478RMAS3bC74PrL\",\n      \"description\": \"Chaveiro do Tesseract\",\n      \"amount\": 2990,\n      \"quantity\": 1,\n      \"status\": \"active\",\n      \"created_at\": \"2017-04-19T16:01:09Z\",\n      \"updated_at\": \"2017-04-19T16:01:09Z\"\n    }\n  ],\n  \"customer\": {\n    \"id\": \"cus_eaEXlZvhBfeGlDOm\",\n    \"name\": \"Tony Stark\",\n    \"email\": \"f1492621-4f39-45f7-adfb-82a373a0a85c@avengers.com\",\n    \"delinquent\": false,\n    \"created_at\": \"2017-04-19T16:01:09Z\",\n    \"updated_at\": \"2017-04-19T16:01:09Z\"\n  },\n  \"status\": \"paid\",\n  \"created_at\": \"2017-04-19T16:01:09Z\",\n  \"updated_at\": \"2017-04-19T16:01:11Z\",\n  \"closed_at\": \"2017-04-19T16:01:11Z\",\n  \"charges\": [\n    {\n      \"id\": \"ch_gmnW101c9YTvQVLB\",\n      \"code\": \"62LVFN7I4R\",\n      \"gateway_id\": \"ef5e977b-93d2-485a-b15d-36e5eb3d8cf5\",\n      \"amount\": 2990,\n      \"status\": \"paid\",\n      \"currency\": \"BRL\",\n      \"payment_method\": \"credit_card\",\n      \"paid_at\": \"2017-04-19T16:01:11Z\",\n      \"created_at\": \"2017-04-19T16:01:09Z\",\n      \"updated_at\": \"2017-04-19T16:01:09Z\",\n      \"customer\": {\n        \"id\": \"cus_eaEXlZvhBfeGlDOm\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"f1492621-4f39-45f7-adfb-82a373a0a85c@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2017-04-19T16:01:09Z\",\n        \"updated_at\": \"2017-04-19T16:01:09Z\"\n      },\n      \"last_transaction\": {\n        \"id\": \"tran_3RYbBQjcnEcwrGp0\",\n        \"transaction_type\": \"credit_card\",\n        \"funding_source\": \"prepaid\",\n        \"gateway_id\": \"ddab707d-72ba-49f9-b356-f0b9ebfa3039\",\n        \"amount\": 2990,\n        \"status\": \"captured\",\n        \"success\": true,\n        \"installments\": 1,\n        \"statement_descriptor\": \"AVENGERS\",\n        \"acquirer_name\": \"simulator\",\n        \"acquirer_affiliation_code\": \"12345\",\n        \"acquirer_tid\": \"431837\",\n        \"acquirer_nsu\": \"512784\",\n        \"acquirer_auth_code\": \"233215\",\n        \"acquirer_message\": \"Simulator|TransaÃ§Ã£o de simulaÃ§Ã£o autorizada com sucesso\",\n        \"acquirer_return_code\": \"0\",\n        \"operation_type\": \"auth_and_capture\",\n        \"card\": {\n          \"id\": \"card_6xk9deAu2I2MdPzJ\",\n          \"first_six_digits\": \"402400\",\n          \"last_four_digits\": \"8229\",\n          \"brand\": \"Amex\",\n          \"holder_name\": \"Tony Stark\",\n          \"exp_month\": 1,\n          \"exp_year\": 2018,\n          \"status\": \"active\",\n          \"created_at\": \"2017-04-19T16:01:09Z\",\n          \"updated_at\": \"2017-04-19T16:01:09Z\",\n          \"billing_address\": {\n            \"zip_code\": \"90265\",\n            \"city\": \"Malibu\",\n            \"state\": \"CA\",\n            \"country\": \"US\",\n            \"line_1\": \"10880, Malibu Point, Malibu Central\"\n          },\n          \"type\": \"credit\"\n        },\n        \"created_at\": \"2017-04-19T16:01:09Z\",\n        \"updated_at\": \"2017-04-19T16:01:09Z\",\n        \"gateway_response\": {\n          \"code\": \"201\"\n        }\n      }\n    }\n  ]\n}"
                  },
                  "OK - Network Token": {
                    "value": "{\n    \"id\": \"or_5aEYRKmIwvTqpgoQ\",\n    \"code\": \"Y387TKKF3L\",\n    \"amount\": 2990,\n    \"currency\": \"BRL\",\n    \"closed\": true,\n    \"items\": [\n        {\n            \"id\": \"oi_gBLrzX1u3pHQMoEM\",\n            \"type\": \"product\",\n            \"description\": \"Chaveiro do Tesseract\",\n            \"amount\": 2990,\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2023-03-17T14:20:27Z\",\n            \"updated_at\": \"2023-03-17T14:20:27Z\"\n        }\n    ],\n    \"customer\": {\n        \"id\": \"cus_K1oa3LKTZSlW6O7d\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"avengerstark@ligadajustica.com.br\",\n        \"delinquent\": false,\n        \"created_at\": \"2023-03-17T14:19:22Z\",\n        \"updated_at\": \"2023-03-17T14:19:22Z\",\n        \"phones\": {}\n    },\n    \"status\": \"paid\",\n    \"created_at\": \"2023-03-17T14:20:27Z\",\n    \"updated_at\": \"2023-03-17T14:20:28Z\",\n    \"closed_at\": \"2023-03-17T14:20:27Z\",\n    \"charges\": [\n        {\n            \"id\": \"ch_Ljvke06fdSErl62x\",\n            \"code\": \"Y387TKKF3L\",\n            \"amount\": 2990,\n            \"paid_amount\": 2990,\n            \"status\": \"paid\",\n            \"currency\": \"BRL\",\n            \"payment_method\": \"credit_card\",\n            \"paid_at\": \"2023-03-17T14:20:28Z\",\n            \"created_at\": \"2023-03-17T14:20:28Z\",\n            \"updated_at\": \"2023-03-17T14:20:28Z\",\n            \"customer\": {\n                \"id\": \"cus_K1oa3LKTZSlW6O7d\",\n                \"name\": \"Tony Stark\",\n                \"email\": \"avengerstark@ligadajustica.com.br\",\n                \"delinquent\": false,\n                \"created_at\": \"2023-03-17T14:19:22Z\",\n                \"updated_at\": \"2023-03-17T14:19:22Z\",\n                \"phones\": {}\n            },\n            \"last_transaction\": {\n                \"operation_key\": \"409945098\",\n                \"id\": \"tran_xbEM0pRmUASgBYAq\",\n                \"transaction_type\": \"credit_card\",\n                \"gateway_id\": \"95e3e8f1-c5fc-4d62-8f0b-80bdc66d3e42\",\n                \"amount\": 2990,\n                \"status\": \"captured\",\n                \"success\": true,\n                \"installments\": 1,\n                \"installment_type\": \"merchant\",\n                \"statement_descriptor\": \"AVENGERS\",\n                \"acquirer_name\": \"simulator\",\n                \"acquirer_tid\": \"894247649\",\n                \"acquirer_nsu\": \"49640\",\n                \"acquirer_auth_code\": \"169\",\n                \"acquirer_message\": \"TransaÃ§Ã£o capturada com sucesso\",\n                \"acquirer_return_code\": \"00\",\n                \"entry_mode\": \"ecommerce\",\n                \"operation_type\": \"auth_and_capture\",\n                \"card\": {\n                    \"id\": \"card_DwER6M8Cl9hPKAOb\",\n                    \"first_six_digits\": \"400000\",\n                    \"last_four_digits\": \"0010\",\n                    \"brand\": \"Visa\",\n                    \"holder_name\": \"Homelander\",\n                    \"exp_month\": 12,\n                    \"exp_year\": 2025,\n                    \"status\": \"active\",\n                    \"type\": \"credit\",\n                    \"created_at\": \"2023-03-17T14:19:43Z\",\n                    \"updated_at\": \"2023-03-17T14:19:43Z\",\n                    \"billing_address\": {\n                        \"zip_code\": \"90265\",\n                        \"city\": \"Malibu\",\n                        \"state\": \"CA\",\n                        \"country\": \"US\",\n                        \"line_1\": \"10880, Malibu Point, Malibu Central\"\n                    },\n                    \"network_token\": {\n                        \"token_unique_reference\": \"9cb80642-e3b6-4b30-b233-c54a4857cbf0\",\n                        \"status\": \"active\"\n                    }\n                },\n                \"payment_type\": \"Token\",\n                \"created_at\": \"2023-03-17T14:20:28Z\",\n                \"updated_at\": \"2023-03-17T14:20:28Z\",\n                \"gateway_response\": {\n                    \"code\": \"200\",\n                    \"errors\": []\n                },\n                \"antifraud_response\": {},\n                \"metadata\": {}\n            }\n        }\n    ],\n    \"checkouts\": []\n}"
                  }
                },
                "schema": {
                  "oneOf": [
                    {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "or_28dN9w7CLU79kDjL"
                        },
                        "code": {
                          "type": "string",
                          "example": "62LVFN7I4R"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 2990,
                          "default": 0
                        },
                        "currency": {
                          "type": "string",
                          "example": "BRL"
                        },
                        "closed": {
                          "type": "boolean",
                          "example": true,
                          "default": true
                        },
                        "items": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "oi_d478RMAS3bC74PrL"
                              },
                              "description": {
                                "type": "string",
                                "example": "Chaveiro do Tesseract"
                              },
                              "amount": {
                                "type": "integer",
                                "example": 2990,
                                "default": 0
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
                                "example": "2017-04-19T16:01:09Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2017-04-19T16:01:09Z"
                              }
                            }
                          }
                        },
                        "customer": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "cus_eaEXlZvhBfeGlDOm"
                            },
                            "name": {
                              "type": "string",
                              "example": "Tony Stark"
                            },
                            "email": {
                              "type": "string",
                              "example": "f1492621-4f39-45f7-adfb-82a373a0a85c@avengers.com"
                            },
                            "delinquent": {
                              "type": "boolean",
                              "example": false,
                              "default": true
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2017-04-19T16:01:09Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2017-04-19T16:01:09Z"
                            }
                          }
                        },
                        "status": {
                          "type": "string",
                          "example": "paid"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-04-19T16:01:09Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-19T16:01:11Z"
                        },
                        "closed_at": {
                          "type": "string",
                          "example": "2017-04-19T16:01:11Z"
                        },
                        "charges": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "ch_gmnW101c9YTvQVLB"
                              },
                              "code": {
                                "type": "string",
                                "example": "62LVFN7I4R"
                              },
                              "gateway_id": {
                                "type": "string",
                                "example": "ef5e977b-93d2-485a-b15d-36e5eb3d8cf5"
                              },
                              "amount": {
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
                                "example": "2017-04-19T16:01:11Z"
                              },
                              "created_at": {
                                "type": "string",
                                "example": "2017-04-19T16:01:09Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2017-04-19T16:01:09Z"
                              },
                              "customer": {
                                "type": "object",
                                "properties": {
                                  "id": {
                                    "type": "string",
                                    "example": "cus_eaEXlZvhBfeGlDOm"
                                  },
                                  "name": {
                                    "type": "string",
                                    "example": "Tony Stark"
                                  },
                                  "email": {
                                    "type": "string",
                                    "example": "f1492621-4f39-45f7-adfb-82a373a0a85c@avengers.com"
                                  },
                                  "delinquent": {
                                    "type": "boolean",
                                    "example": false,
                                    "default": true
                                  },
                                  "created_at": {
                                    "type": "string",
                                    "example": "2017-04-19T16:01:09Z"
                                  },
                                  "updated_at": {
                                    "type": "string",
                                    "example": "2017-04-19T16:01:09Z"
                                  }
                                }
                              },
                              "last_transaction": {
                                "type": "object",
                                "properties": {
                                  "id": {
                                    "type": "string",
                                    "example": "tran_3RYbBQjcnEcwrGp0"
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
                                    "example": "ddab707d-72ba-49f9-b356-f0b9ebfa3039"
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
                                  "statement_descriptor": {
                                    "type": "string",
                                    "example": "AVENGERS"
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
                                    "example": "431837"
                                  },
                                  "acquirer_nsu": {
                                    "type": "string",
                                    "example": "512784"
                                  },
                                  "acquirer_auth_code": {
                                    "type": "string",
                                    "example": "233215"
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
                                        "example": "card_6xk9deAu2I2MdPzJ"
                                      },
                                      "first_six_digits": {
                                        "type": "string",
                                        "example": "402400"
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
                                        "example": "2017-04-19T16:01:09Z"
                                      },
                                      "updated_at": {
                                        "type": "string",
                                        "example": "2017-04-19T16:01:09Z"
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
                                      "type": {
                                        "type": "string",
                                        "example": "credit"
                                      }
                                    }
                                  },
                                  "created_at": {
                                    "type": "string",
                                    "example": "2017-04-19T16:01:09Z"
                                  },
                                  "updated_at": {
                                    "type": "string",
                                    "example": "2017-04-19T16:01:09Z"
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
                    },
                    {
                      "title": "OK - Network Token",
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
                        "currency": {
                          "type": "string",
                          "example": "BRL"
                        },
                        "closed": {
                          "type": "boolean",
                          "example": true,
                          "default": true
                        },
                        "items": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "oi_gBLrzX1u3pHQMoEM"
                              },
                              "type": {
                                "type": "string",
                                "example": "product"
                              },
                              "description": {
                                "type": "string",
                                "example": "Chaveiro do Tesseract"
                              },
                              "amount": {
                                "type": "integer",
                                "example": 2990,
                                "default": 0
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
                                "example": "2023-03-17T14:20:27Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2023-03-17T14:20:27Z"
                              }
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
                        "status": {
                          "type": "string",
                          "example": "paid"
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
                        "charges": {
                          "type": "array",
                          "items": {
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
                        },
                        "checkouts": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {}
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
                    "value": "{\n    \"message\": \"Order not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Order not found."
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