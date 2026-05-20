# Retentar uma cobranÃ§a manualmente

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
    "/charges/{charge_id}/retry": {
      "post": {
        "summary": "Retentar uma cobranÃ§a manualmente",
        "description": "",
        "operationId": "retentar-uma-cobranÃ§a-manualmente",
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
                    "value": "{\n  \"id\": \"ch_exRAY21fvNFVD9EX\",\n  \"code\": \"8M2OT2SRX8\",\n  \"gateway_id\": \"c5d71b01-174e-453f-8563-fd089cf7b39b\",\n  \"amount\": 14900000,\n  \"status\": \"failed\",\n  \"currency\": \"BRL\",\n  \"payment_method\": \"credit_card\",\n  \"due_at\": \"2017-04-04T00:00:00\",\n  \"created_at\": \"2017-04-04T22:29:33\",\n  \"updated_at\": \"2017-04-04T22:29:54\",\n  \"customer\": {\n    \"id\": \"cus_aEkwKv0SmNHMR931\",\n    \"name\": \"Luke Skywalker\",\n    \"email\": \"lskywalker@r2d2.com\",\n    \"delinquent\": false,\n    \"created_at\": \"2017-04-04T19:41:31\",\n    \"updated_at\": \"2017-04-04T19:41:31\"\n  },\n  \"last_transaction\": {\n    \"id\": \"tran_dZm79oYT0ckRlw1o\",\n    \"transaction_type\": \"credit_card\",\n    \"funding_source\": \"prepaid\",\n    \"gateway_id\": \"f3c316f7-3f6c-47bc-ac03-da01e51444aa\",\n    \"amount\": 14900000,\n    \"status\": \"not_authorized\",\n    \"success\": false,\n    \"installments\": 1,\n    \"statement_descriptor\": \"Spotify\",\n    \"acquirer_name\": \"simulator\",\n    \"acquirer_affiliation_code\": \"MUNDI\",\n    \"acquirer_tid\": \"\",\n    \"acquirer_nsu\": \"\",\n    \"acquirer_auth_code\": \"\",\n    \"acquirer_message\": \"Simulator|TransaÃ§Ã£o de simulaÃ§Ã£o nÃ£o autorizada\",\n    \"acquirer_return_code\": \"1\",\n    \"operation_type\": \"auth_only\",\n    \"credit_card\": {\n      \"id\": \"card_2bKzdEGsYYFkymqG\",\n      \"first_six_digits\": \"542501\",\n      \"last_four_digits\": \"5322\",\n      \"brand\": \"Visa\",\n      \"holder_name\": \"Luke Skywalker\",\n      \"exp_month\": 5,\n      \"exp_year\": 2030,\n      \"status\": \"active\",\n      \"created_at\": \"2017-04-04T19:41:31\",\n      \"updated_at\": \"2017-04-04T19:41:31\",\n      \"billing_address\": {\n        \"zip_code\": \"90265\",\n        \"city\": \"Malibu\",\n        \"state\": \"CA\",\n        \"country\": \"US\",\n         \"line_1\": \"10880, Malibu Point, Malibu Central\"\n      }\n    },\n    \"created_at\": \"2017-04-04T22:29:33\",\n    \"updated_at\": \"2017-04-04T22:29:33\"\n  },\n  \"metadata\": {\n    \"id\": \"my_charge_id\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "ch_exRAY21fvNFVD9EX"
                    },
                    "code": {
                      "type": "string",
                      "example": "8M2OT2SRX8"
                    },
                    "gateway_id": {
                      "type": "string",
                      "example": "c5d71b01-174e-453f-8563-fd089cf7b39b"
                    },
                    "amount": {
                      "type": "integer",
                      "example": 14900000,
                      "default": 0
                    },
                    "status": {
                      "type": "string",
                      "example": "failed"
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
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-04T22:29:33"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-04-04T22:29:54"
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
                          "example": "tran_dZm79oYT0ckRlw1o"
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
                          "example": "f3c316f7-3f6c-47bc-ac03-da01e51444aa"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 14900000,
                          "default": 0
                        },
                        "status": {
                          "type": "string",
                          "example": "not_authorized"
                        },
                        "success": {
                          "type": "boolean",
                          "example": false,
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
                          "example": ""
                        },
                        "acquirer_nsu": {
                          "type": "string",
                          "example": ""
                        },
                        "acquirer_auth_code": {
                          "type": "string",
                          "example": ""
                        },
                        "acquirer_message": {
                          "type": "string",
                          "example": "Simulator|TransaÃ§Ã£o de simulaÃ§Ã£o nÃ£o autorizada"
                        },
                        "acquirer_return_code": {
                          "type": "string",
                          "example": "1"
                        },
                        "operation_type": {
                          "type": "string",
                          "example": "auth_only"
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
                              "example": 2030,
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
                          "example": "2017-04-04T22:29:33"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-04T22:29:33"
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