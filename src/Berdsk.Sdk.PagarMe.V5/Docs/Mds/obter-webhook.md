# Obter webhook

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
    "/hooks/{hook_id}": {
      "get": {
        "summary": "Obter webhook",
        "description": "",
        "operationId": "obter-webhook",
        "parameters": [
          {
            "name": "hook_id",
            "in": "path",
            "description": "CÃ³digo do webhook.",
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
                    "value": "{\n  \"id\": \"hook_98kmOL1sMfnZqoPL\",\n  \"url\": \"https://70cfee17.ngrok.io/notifications/payment\",\n  \"account\": {\n    \"id\": \"acc_jZkdN857et650oNv\",\n    \"name\": \"Lojinha\"\n  },\n  \"event\": \"order.paid\",\n  \"status\": \"failed\",\n  \"attempts\": \"3/3\",\n  \"last_attempt\": \"2017-03-24T21:32:07Z\",\n  \"created_at\": \"2017-03-24T21:21:59Z\",\n  \"response_status\": 404,\n  \"response_raw\": \"Tunnel 70cfee17.ngrok.io not found\",\n  \"data\": {\n    \"id\": \"or_e36l73IwgF7MlJwx\",\n    \"code\": \"ER30H4MU4N\",\n    \"amount\": 199,\n    \"currency\": \"BRL\",\n    \"closed\": true,\n    \"items\": [\n      {\n        \"id\": \"oi_NqW9Rb2LTbsqRa3n\",\n        \"description\": \"FLIP Payment\",\n        \"amount\": 199,\n        \"quantity\": 1,\n        \"status\": \"active\",\n        \"created_at\": \"2017-03-24T21:21:58Z\",\n        \"updated_at\": \"2017-03-24T21:21:58Z\"\n      }\n    ],\n    \"customer\": {\n      \"id\": \"cus_le6ZqXjiBSEOWdoA\",\n      \"name\": \"Matheus Moreira\",\n      \"email\": \"mmoreira@pagar.me\",\n      \"delinquent\": false,\n      \"created_at\": \"2016-11-25T23:45:04Z\",\n      \"updated_at\": \"2016-12-26T21:34:45Z\"\n    },\n    \"status\": \"paid\",\n    \"created_at\": \"2017-03-24T21:21:58Z\",\n    \"updated_at\": \"2017-03-24T21:21:59Z\",\n    \"closed_at\": \"2017-03-24T21:21:59Z\",\n    \"charge\": {\n      \"id\": \"ch_56YNm9akt4i6mKQ8\",\n      \"code\": \"ER30H4MU4N\",\n      \"gateway_id\": \"b21c20f8-21e1-4f56-ac1c-34425c9e9dc9\",\n      \"amount\": 199,\n      \"status\": \"paid\",\n      \"currency\": \"BRL\",\n      \"payment_method\": \"credit_card\",\n      \"funding_source\": \"prepaid\",\n      \"due_at\": \"2017-03-24T00:00:00Z\",\n      \"paid_at\": \"2017-03-24T21:21:59Z\",\n      \"created_at\": \"2017-03-24T21:21:58Z\",\n      \"updated_at\": \"2017-03-24T21:21:58Z\",\n      \"customer\": {\n        \"id\": \"cus_le6ZqXjiBSEOWdoA\",\n        \"name\": \"Matheus Moreira\",\n        \"email\": \"mmoreira@pagar.me\",\n        \"delinquent\": false,\n        \"created_at\": \"2016-11-25T23:45:04Z\",\n        \"updated_at\": \"2016-12-26T21:34:45Z\"\n      },\n      \"last_transaction\": {\n        \"id\": \"tran_MpnYkMXhOBTb7Ze8\",\n        \"transaction_type\": \"credit_card\",\n        \"gateway_id\": \"9ac7ee2c-02a1-4b19-9f7e-168739a0427b\",\n        \"amount\": 199,\n        \"status\": \"captured\",\n        \"success\": true,\n        \"installments\": 1,\n        \"acquirer_name\": \"simulator\",\n        \"acquirer_affiliation_code\": \"1235\",\n        \"acquirer_tid\": \"266699\",\n        \"acquirer_nsu\": \"848780\",\n        \"acquirer_auth_code\": \"1234\",\n        \"acquirer_message\": \"Simulator|TransaÃ§Ã£o de simulaÃ§Ã£o autorizada com sucesso\",\n        \"acquirer_return_code\": \"0\",\n        \"operation_type\": \"auth_and_capture\",\n        \"credit_card\": {\n          \"id\": \"card_yB3ma9rS8HW7mnA9\",\n          \"first_six_digits\": \"342793\",\n          \"last_four_digits\": \"8229\",\n          \"brand\": \"Amex\",\n          \"holder_name\": \"Tony Stark\",\n          \"exp_month\": 1,\n          \"exp_year\": 2018,\n          \"status\": \"active\",\n          \"created_at\": \"2016-11-29T21:14:07Z\",\n          \"updated_at\": \"2016-11-29T21:14:07Z\",\n          \"billing_address\": {\n            \"zip_code\": \"90265\",\n            \"city\": \"Malibu\",\n            \"state\": \"CA\",\n            \"country\": \"US\",\n            \"line_1\": \"10880, Malibu Point, Malibu Central\"\n          }\n        },\n        \"created_at\": \"2017-03-24T21:21:58Z\",\n        \"updated_at\": \"2017-03-24T21:21:58Z\"\n      }\n    },\n    \"charges\": [\n      {\n        \"id\": \"ch_56YNm9akt4i6mKQ8\",\n        \"code\": \"ER30H4MU4N\",\n        \"gateway_id\": \"b21c20f8-21e1-4f56-ac1c-34425c9e9dc9\",\n        \"amount\": 199,\n        \"status\": \"paid\",\n        \"currency\": \"BRL\",\n        \"payment_method\": \"credit_card\",\n        \"due_at\": \"2017-03-24T00:00:00Z\",\n        \"paid_at\": \"2017-03-24T21:21:59Z\",\n        \"created_at\": \"2017-03-24T21:21:58Z\",\n        \"updated_at\": \"2017-03-24T21:21:58Z\",\n        \"customer\": {\n          \"id\": \"cus_le6ZqXjiBSEOWdoA\",\n          \"name\": \"Matheus Moreira\",\n          \"email\": \"mmoreira@pagar.me\",\n          \"delinquent\": false,\n          \"created_at\": \"2016-11-25T23:45:04Z\",\n          \"updated_at\": \"2016-12-26T21:34:45Z\"\n        },\n        \"last_transaction\": {\n          \"id\": \"tran_MpnYkMXhOBTb7Ze8\",\n          \"transaction_type\": \"credit_card\",\n          \"gateway_id\": \"9ac7ee2c-02a1-4b19-9f7e-168739a0427b\",\n          \"amount\": 199,\n          \"status\": \"captured\",\n          \"success\": true,\n          \"installments\": 1,\n          \"acquirer_name\": \"simulator\",\n          \"acquirer_affiliation_code\": \"12345\",\n          \"acquirer_tid\": \"266699\",\n          \"acquirer_nsu\": \"848780\",\n          \"acquirer_auth_code\": \"12345\",\n          \"acquirer_message\": \"Simulator|TransaÃ§Ã£o de simulaÃ§Ã£o autorizada com sucesso\",\n          \"acquirer_return_code\": \"0\",\n          \"operation_type\": \"auth_and_capture\",\n          \"credit_card\": {\n            \"id\": \"card_yB3ma9rS8HW7mnA9\",\n            \"last_four_digits\": \"8229\",\n            \"brand\": \"Amex\",\n            \"holder_name\": \"Tony Stark\",\n            \"exp_month\": 1,\n            \"exp_year\": 2018,\n            \"status\": \"active\",\n            \"created_at\": \"2016-11-29T21:14:07Z\",\n            \"updated_at\": \"2016-11-29T21:14:07Z\",\n            \"billing_address\": {\n              \"zip_code\": \"90265\",\n              \"city\": \"Malibu\",\n              \"state\": \"CA\",\n              \"country\": \"US\",\n              \"line_1\": \"10880, Malibu Point, Malibu Central\"\n            }\n          },\n          \"created_at\": \"2017-03-24T21:21:58Z\",\n          \"updated_at\": \"2017-03-24T21:21:58Z\"\n        }\n      }\n    ]\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "hook_98kmOL1sMfnZqoPL"
                    },
                    "url": {
                      "type": "string",
                      "example": "https://70cfee17.ngrok.io/notifications/payment"
                    },
                    "account": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "acc_jZkdN857et650oNv"
                        },
                        "name": {
                          "type": "string",
                          "example": "Lojinha"
                        }
                      }
                    },
                    "event": {
                      "type": "string",
                      "example": "order.paid"
                    },
                    "status": {
                      "type": "string",
                      "example": "failed"
                    },
                    "attempts": {
                      "type": "string",
                      "example": "3/3"
                    },
                    "last_attempt": {
                      "type": "string",
                      "example": "2017-03-24T21:32:07Z"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-03-24T21:21:59Z"
                    },
                    "response_status": {
                      "type": "integer",
                      "example": 404,
                      "default": 0
                    },
                    "response_raw": {
                      "type": "string",
                      "example": "Tunnel 70cfee17.ngrok.io not found"
                    },
                    "data": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "or_e36l73IwgF7MlJwx"
                        },
                        "code": {
                          "type": "string",
                          "example": "ER30H4MU4N"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 199,
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
                                "example": "oi_NqW9Rb2LTbsqRa3n"
                              },
                              "description": {
                                "type": "string",
                                "example": "FLIP Payment"
                              },
                              "amount": {
                                "type": "integer",
                                "example": 199,
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
                                "example": "2017-03-24T21:21:58Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2017-03-24T21:21:58Z"
                              }
                            }
                          }
                        },
                        "customer": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "cus_le6ZqXjiBSEOWdoA"
                            },
                            "name": {
                              "type": "string",
                              "example": "Matheus Moreira"
                            },
                            "email": {
                              "type": "string",
                              "example": "mmoreira@pagar.me"
                            },
                            "delinquent": {
                              "type": "boolean",
                              "example": false,
                              "default": true
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2016-11-25T23:45:04Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2016-12-26T21:34:45Z"
                            }
                          }
                        },
                        "status": {
                          "type": "string",
                          "example": "paid"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-03-24T21:21:58Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-03-24T21:21:59Z"
                        },
                        "closed_at": {
                          "type": "string",
                          "example": "2017-03-24T21:21:59Z"
                        },
                        "charge": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "ch_56YNm9akt4i6mKQ8"
                            },
                            "code": {
                              "type": "string",
                              "example": "ER30H4MU4N"
                            },
                            "gateway_id": {
                              "type": "string",
                              "example": "b21c20f8-21e1-4f56-ac1c-34425c9e9dc9"
                            },
                            "amount": {
                              "type": "integer",
                              "example": 199,
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
                            "funding_source": {
                              "type": "string",
                              "example": "prepaid"
                            },
                            "due_at": {
                              "type": "string",
                              "example": "2017-03-24T00:00:00Z"
                            },
                            "paid_at": {
                              "type": "string",
                              "example": "2017-03-24T21:21:59Z"
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2017-03-24T21:21:58Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2017-03-24T21:21:58Z"
                            },
                            "customer": {
                              "type": "object",
                              "properties": {
                                "id": {
                                  "type": "string",
                                  "example": "cus_le6ZqXjiBSEOWdoA"
                                },
                                "name": {
                                  "type": "string",
                                  "example": "Matheus Moreira"
                                },
                                "email": {
                                  "type": "string",
                                  "example": "mmoreira@pagar.me"
                                },
                                "delinquent": {
                                  "type": "boolean",
                                  "example": false,
                                  "default": true
                                },
                                "created_at": {
                                  "type": "string",
                                  "example": "2016-11-25T23:45:04Z"
                                },
                                "updated_at": {
                                  "type": "string",
                                  "example": "2016-12-26T21:34:45Z"
                                }
                              }
                            },
                            "last_transaction": {
                              "type": "object",
                              "properties": {
                                "id": {
                                  "type": "string",
                                  "example": "tran_MpnYkMXhOBTb7Ze8"
                                },
                                "transaction_type": {
                                  "type": "string",
                                  "example": "credit_card"
                                },
                                "gateway_id": {
                                  "type": "string",
                                  "example": "9ac7ee2c-02a1-4b19-9f7e-168739a0427b"
                                },
                                "amount": {
                                  "type": "integer",
                                  "example": 199,
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
                                "acquirer_name": {
                                  "type": "string",
                                  "example": "simulator"
                                },
                                "acquirer_affiliation_code": {
                                  "type": "string",
                                  "example": "1235"
                                },
                                "acquirer_tid": {
                                  "type": "string",
                                  "example": "266699"
                                },
                                "acquirer_nsu": {
                                  "type": "string",
                                  "example": "848780"
                                },
                                "acquirer_auth_code": {
                                  "type": "string",
                                  "example": "1234"
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
                                      "example": "card_yB3ma9rS8HW7mnA9"
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
                                      "example": "2016-11-29T21:14:07Z"
                                    },
                                    "updated_at": {
                                      "type": "string",
                                      "example": "2016-11-29T21:14:07Z"
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
                                  "example": "2017-03-24T21:21:58Z"
                                },
                                "updated_at": {
                                  "type": "string",
                                  "example": "2017-03-24T21:21:58Z"
                                }
                              }
                            }
                          }
                        },
                        "charges": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "ch_56YNm9akt4i6mKQ8"
                              },
                              "code": {
                                "type": "string",
                                "example": "ER30H4MU4N"
                              },
                              "gateway_id": {
                                "type": "string",
                                "example": "b21c20f8-21e1-4f56-ac1c-34425c9e9dc9"
                              },
                              "amount": {
                                "type": "integer",
                                "example": 199,
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
                                "example": "2017-03-24T00:00:00Z"
                              },
                              "paid_at": {
                                "type": "string",
                                "example": "2017-03-24T21:21:59Z"
                              },
                              "created_at": {
                                "type": "string",
                                "example": "2017-03-24T21:21:58Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2017-03-24T21:21:58Z"
                              },
                              "customer": {
                                "type": "object",
                                "properties": {
                                  "id": {
                                    "type": "string",
                                    "example": "cus_le6ZqXjiBSEOWdoA"
                                  },
                                  "name": {
                                    "type": "string",
                                    "example": "Matheus Moreira"
                                  },
                                  "email": {
                                    "type": "string",
                                    "example": "mmoreira@pagar.me"
                                  },
                                  "delinquent": {
                                    "type": "boolean",
                                    "example": false,
                                    "default": true
                                  },
                                  "created_at": {
                                    "type": "string",
                                    "example": "2016-11-25T23:45:04Z"
                                  },
                                  "updated_at": {
                                    "type": "string",
                                    "example": "2016-12-26T21:34:45Z"
                                  }
                                }
                              },
                              "last_transaction": {
                                "type": "object",
                                "properties": {
                                  "id": {
                                    "type": "string",
                                    "example": "tran_MpnYkMXhOBTb7Ze8"
                                  },
                                  "transaction_type": {
                                    "type": "string",
                                    "example": "credit_card"
                                  },
                                  "gateway_id": {
                                    "type": "string",
                                    "example": "9ac7ee2c-02a1-4b19-9f7e-168739a0427b"
                                  },
                                  "amount": {
                                    "type": "integer",
                                    "example": 199,
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
                                    "example": "266699"
                                  },
                                  "acquirer_nsu": {
                                    "type": "string",
                                    "example": "848780"
                                  },
                                  "acquirer_auth_code": {
                                    "type": "string",
                                    "example": "12345"
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
                                        "example": "card_yB3ma9rS8HW7mnA9"
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
                                        "example": "2016-11-29T21:14:07Z"
                                      },
                                      "updated_at": {
                                        "type": "string",
                                        "example": "2016-11-29T21:14:07Z"
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
                                    "example": "2017-03-24T21:21:58Z"
                                  },
                                  "updated_at": {
                                    "type": "string",
                                    "example": "2017-03-24T21:21:58Z"
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