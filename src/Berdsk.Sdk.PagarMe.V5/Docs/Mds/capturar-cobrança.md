# Capturar cobranÃ§a

Rota para capturar uma cobranÃ§a com split, definindo a regra de split e os recebedor que irÃ£o participar da divisÃ£o dos
pagamentos.

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
    "/charges/{charge_id}/capture": {
      "post": {
        "summary": "Capturar cobranÃ§a com split",
        "description": "Rota para capturar uma cobranÃ§a com split, definindo a regra de split e os recebedor que irÃ£o participar da divisÃ£o dos pagamentos.",
        "operationId": "capturar-cobranÃ§a-com-split-1",
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
                    "description": "Valor a ser capturado. Caso nÃ£o seja informado, serÃ¡ considerado o valor total da cobranÃ§a.",
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
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "amount": 100,
                    "split": [
                      {
                        "amount": 50,
                        "recipient_id": "rp_5yGwpMGckBHVYmb6",
                        "type": "percentage",
                        "options": {
                          "charge_processing_fee": true,
                          "charge_remainder_fee": true,
                          "liable": true
                        }
                      },
                      {
                        "amount": 50,
                        "type": "percentage",
                        "recipient_id": "rp_yLnAyVpHbQIqZxwO",
                        "options": {
                          "charge_processing_fee": false,
                          "charge_remainder_fee": false,
                          "liable": false
                        }
                      }
                    ]
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
                    "value": "{\n    \"id\": \"ch_WOoyJ6u3kUzGyj46\",\n    \"code\": \"G11LT7MHVL\",\n    \"gateway_id\": \"3910377\",\n    \"amount\": 100,\n    \"paid_amount\": 100,\n    \"status\": \"paid\",\n    \"currency\": \"BRL\",\n    \"payment_method\": \"credit_card\",\n    \"paid_at\": \"2018-07-11T17:08:54Z\",\n    \"canceled_at\": \"2018-07-11T17:09:04Z\",\n    \"created_at\": \"2018-07-11T17:08:52Z\",\n    \"updated_at\": \"2018-07-11T17:09:04Z\",\n    \"customer\": {\n        \"id\": \"cus_OXr6LKGhwruEE1mj\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"89d47975-5fb2-4452-8044-7c3be5718d53@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2018-07-11T17:08:51Z\",\n        \"updated_at\": \"2018-07-11T17:08:51Z\",\n        \"phones\": {}\n    },\n    \"last_transaction\": {\n        \"id\": \"tran_p6yAVj8S8szqAB4d\",\n        \"transaction_type\": \"credit_card\",\n        \"gateway_id\": \"3910377\",\n        \"amount\": 100,\n        \"status\": \"captured\",\n        \"success\": true,\n        \"acquirer_name\": \"pagarme\",\n        \"acquirer_tid\": \"3910377\",\n        \"acquirer_nsu\": \"3910377\",\n        \"acquirer_return_code\": \"0000\",\n        \"operation_type\": \"cancel\",\n        \"card\": {\n            \"id\": \"card_Rp2BADgtNmSpY5oW\",\n            \"first_six_digits\": \"401118\",\n            \"last_four_digits\": \"5580\",\n            \"brand\": \"Visa\",\n            \"holder_name\": \"Tony Stark\",\n            \"exp_month\": 1,\n            \"exp_year\": 2020,\n            \"status\": \"active\",\n            \"type\": \"credit\",\n            \"created_at\": \"2018-07-11T17:08:52Z\",\n            \"updated_at\": \"2018-07-11T17:08:52Z\"\n        },\n        \"created_at\": \"2018-07-11T17:09:00Z\",\n        \"updated_at\": \"2018-07-11T17:09:00Z\",\n        \"gateway_response\": {\n            \"code\": \"200\"\n        },\n        \"split\": [\n      {\n        \"id\": \"sr_R2qmlNaViJiLQAwg\",\n        \"type\": \"percentage\",\n        \"gateway_id\": \"sr_ck5gvkaia0061q36dfxqmrh1j\",\n        \"amount\": 50,\n        \"recipient\": {\n          \"id\": \"rp_5yGwpMGckBHVYmb6\",\n          \"name\": \"First recipient\",\n          \"email\": \"first_recipient@pagar.me\",\n          \"document\": \"12728994706\",\n          \"description\": \"DescriÃ§Ã£o do recebedor 1\",\n          \"type\": \"individual\",\n          \"status\": \"active\",\n          \"created_at\": \"2020-01-02T20:23:14Z\",\n          \"updated_at\": \"2020-01-02T20:23:14Z\"\n        },\n        \"options\": {\n          \"liable\": true,\n          \"charge_processing_fee\": true,\n          \"charge_remainder_fee\": true\n        }\n      },\n      {\n        \"id\": \"sr_yrkGYXw0ijuaxAX8\",\n        \"type\": \"percentage\",\n        \"gateway_id\": \"sr_ck5gvkaia0062q36dioccqnec\",\n        \"amount\": 50,\n        \"recipient\": {\n          \"id\": \"rp_yLnAyVpHbQIqZxwO\",\n          \"name\": \"Second recipient\",\n          \"email\": \"second_recipient@pagar.me\",\n          \"document\": \"15313587000166\",\n          \"description\": \"DescriÃ§Ã£o do recebedor 2\",\n          \"type\": \"company\",\n          \"status\": \"active\",\n          \"created_at\": \"2020-01-02T20:23:17Z\",\n          \"updated_at\": \"2020-01-02T20:23:17Z\"\n        },\n        \"options\": {\n          \"liable\": false,\n          \"charge_processing_fee\": false,\n          \"charge_remainder_fee\": false\n        }\n      }\n    ]\n    },\n    \"metadata\": {\n        \"code\": \"123\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "ch_WOoyJ6u3kUzGyj46"
                    },
                    "code": {
                      "type": "string",
                      "example": "G11LT7MHVL"
                    },
                    "gateway_id": {
                      "type": "string",
                      "example": "3910377"
                    },
                    "amount": {
                      "type": "integer",
                      "example": 100,
                      "default": 0
                    },
                    "paid_amount": {
                      "type": "integer",
                      "example": 100,
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
                      "example": "2018-07-11T17:08:54Z"
                    },
                    "canceled_at": {
                      "type": "string",
                      "example": "2018-07-11T17:09:04Z"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2018-07-11T17:08:52Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2018-07-11T17:09:04Z"
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_OXr6LKGhwruEE1mj"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "89d47975-5fb2-4452-8044-7c3be5718d53@avengers.com"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2018-07-11T17:08:51Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-07-11T17:08:51Z"
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
                          "example": "tran_p6yAVj8S8szqAB4d"
                        },
                        "transaction_type": {
                          "type": "string",
                          "example": "credit_card"
                        },
                        "gateway_id": {
                          "type": "string",
                          "example": "3910377"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 100,
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
                        "acquirer_name": {
                          "type": "string",
                          "example": "pagarme"
                        },
                        "acquirer_tid": {
                          "type": "string",
                          "example": "3910377"
                        },
                        "acquirer_nsu": {
                          "type": "string",
                          "example": "3910377"
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
                              "example": "card_Rp2BADgtNmSpY5oW"
                            },
                            "first_six_digits": {
                              "type": "string",
                              "example": "401118"
                            },
                            "last_four_digits": {
                              "type": "string",
                              "example": "5580"
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
                              "example": "2018-07-11T17:08:52Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2018-07-11T17:08:52Z"
                            }
                          }
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2018-07-11T17:09:00Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-07-11T17:09:00Z"
                        },
                        "gateway_response": {
                          "type": "object",
                          "properties": {
                            "code": {
                              "type": "string",
                              "example": "200"
                            }
                          }
                        },
                        "split": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "sr_R2qmlNaViJiLQAwg"
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
                                "example": 50,
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