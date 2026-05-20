# Editar meio de pagamento da assinatura

Com o verbo HTTP PATCH, atravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel atualizar o meio de
pagamento da assinatura.

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
    "/subscriptions/{subscription_id}/payment-method": {
      "patch": {
        "summary": "Editar meio de pagamento da assinatura",
        "description": "Com o verbo HTTP PATCH, atravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel atualizar o meio de pagamento da assinatura.",
        "operationId": "editar-meio-de-pagamento-da-assinatura",
        "parameters": [
          {
            "name": "subscription_id",
            "in": "path",
            "description": "CÃ³digo da assinatura.<br>Formato: `sub_XXXXXXXXXXXXXXXX`.",
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
                  "payment_method": {
                    "type": "string",
                    "description": "Meio de pagamento.<br>Valores possÃ­veis: **credit_card**, **boleto**, **cash** ou **debit_card** . Deve-se adicionar o meio de pagamento apÃ³s o objeto \"payment_method\""
                  },
                  "card": {
                    "type": "object",
                    "description": "Dados do novo cartÃ£o. <br>**ObrigatÃ³rio** , caso o `payment_method` escolhido seja `credit_card` e o `card_id` e o `card_token` nÃ£o sejam informados.",
                    "properties": {}
                  },
                  "card_id": {
                    "type": "string",
                    "description": "CÃ³digo do novo cartÃ£o.<br>**ObrigatÃ³rio** , caso o `payment_method` escolhido seja `credit_card` e o objeto `card` e o `card_token` nÃ£o sejam informados."
                  },
                  "card_token": {
                    "type": "string",
                    "description": "Token do novo cartÃ£o. <br>**ObrigatÃ³rio** , caso o `payment_method` escolhido seja `credit_card` e o `card_id` e o `card` nÃ£o sejam informados.<br>[Saiba mais token de cartÃ£o](https://docs.pagar.me/reference/criar-token-cart%C3%A3o-1)"
                  }
                }
              },
              "examples": {
                "JSON (to boleto)": {
                  "value": {
                    "payment_method": "boleto"
                  }
                },
                "JSON (to credit card by Id)": {
                  "value": {
                    "payment_method": "credit_card",
                    "card_id": "card_PoDev5OCEEUjRJXp"
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
                  "OK (to boleto)": {
                    "value": "{\n  \"id\": \"sub_05jkdIfGYPfN26mI\",\n  \"payment_method\": \"boleto\",\n  \"currency\": \"BRL\",\n  \"interval\": \"month\",\n  \"interval_count\": 3,\n  \"billing_type\": \"prepaid\",\n  \"gateway_affiliation_id\":\"C56A4180-65AA-42EC-A945-5FD21DEC0538\",\n  \"boleto_due_days\":5,\n  \"minimum_price\": 10000,\n  \"current_period\": {\n    \"start_at\": \"2016-07-19T00:00:00Z\",\n    \"end_at\": \"2016-10-18T23:59:59Z\"\n  },\n  \"next_billing_at\": \"2016-10-19T00:00:00Z\",\n  \"installments\": 3,\n  \"customer\": {\n    \"id\": \"cus_017228NmffGbA3d4\",\n    \"name\": \"Luke Skywalker\",\n    \"email\": \"lskywalker@r2d2.com\",\n    \"delinquent\": false,\n    \"created_at\": \"2016-07-12T18:25:40Z\",\n    \"updated_at\": \"2016-07-12T18:25:40Z\",\n  },\n  \"discounts\": [\n    {\n      \"id\": \"si_k2zpBDMsOs0fDfHe\",\n      \"cycles\": 3,\n      \"value\": 10,\n      \"discount_type\": \"percentage\",\n      \"created_at\": \"2016-07-12T18:25:40Z\"\n    }\n  ],\n  \"increments\": [\n    {\n      \"id\": \"inc_IYzpxgjsOs0fDIoP\",\n      \"cycles\": 2,\n      \"value\": 20,\n      \"discount_type\": \"percentage\",\n      \"created_at\": \"2016-07-12T18:25:40Z\"\n    }\n  ],\n  \"items\": [\n    {\n      \"id\": \"si_B6555Riyq9lj6klS\",\n      \"description\": \"MusculaÃ§Ã£o\",\n      \"quantity\": 1,\n      \"pricing_scheme\": {\n        \"price\": 18990,\n        \"scheme_type\": \"unit\"\n      },\n      \"status\": \"active\",\n      \"created_at\": \"2016-07-12T18:25:40Z\",\n      \"updated_at\": \"2016-07-12T18:25:40Z\",\n    },\n    {\n      \"id\": \"si_lFjtC2xYGttulJpn\",\n      \"description\": \"MatrÃ­cula\",\n      \"quantity\": 1,\n      \"cycles\": 1,\n      \"pricing_scheme\": {\n        \"price\": 5990,\n        \"scheme_type\": \"unit\"\n      },\n      \"status\": \"active\",\n      \"created_at\": \"2016-07-12T18:25:40Z\",\n      \"updated_at\": \"2016-07-12T18:25:40Z\",\n    }\n  ],\n  \"status\": \"active\",\n  \"created_at\": \"2016-07-12T18:25:40Z\",\n  \"updated_at\": \"2016-07-12T18:25:40Z\",\n  \"metadata\": {\n    \"id\": \"my_subscription_id\"\n  }\n}"
                  },
                  "OK (to credit card by Id)": {
                    "value": "{\n    \"id\": \"sub_WeEMlp2FXFMjVq3Q\",\n    \"code\": \"8YNU49TD4Z\",\n    \"start_at\": \"2018-04-05T00:00:00Z\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"billing_type\": \"postpaid\",\n    \"current_cycle\": {\n        \"id\": \"cycle_6ow0JqhD5sJmMJPl\",\n        \"start_at\": \"2018-04-05T00:00:00Z\",\n        \"end_at\": \"2018-05-04T23:59:59Z\",\n        \"billing_at\": \"2018-05-05T00:00:00Z\"\n    },\n    \"setup\": {\n        \"id\": \"or_0Wd7bYRMSmSYy8qz\",\n        \"description\": \"InscriÃ§Ã£o\",\n        \"amount\": 9990,\n        \"status\": \"paid\"\n    },\n    \"next_billing_at\": \"2018-05-05T00:00:00Z\",\n    \"payment_method\": \"credit_card\",\n    \"currency\": \"BRL\",\n    \"statement_descriptor\": \"Spotify\",\n    \"installments\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2018-04-05T03:20:16Z\",\n    \"updated_at\": \"2018-04-05T03:20:16Z\",\n    \"customer\": {\n        \"id\": \"cus_px3yqRSlRsVqawgj\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"ef61ded5-9e60-40c7-89cd-a3b6e70515e8@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2018-04-05T03:20:15Z\",\n        \"updated_at\": \"2018-04-05T03:20:15Z\",\n        \"phones\": {}\n    },\n    \"card\": {\n        \"id\": \"card_PoDev5OCEEUjRJXp\",\n        \"first_six_digits\": \"542501\",\n        \"last_four_digits\": \"7793\",\n        \"brand\": \"Mastercard\",\n        \"holder_name\": \"Tony Stark\",\n        \"exp_month\": 1,\n        \"exp_year\": 2022,\n        \"status\": \"active\",\n        \"created_at\": \"2018-04-05T04:05:02Z\",\n        \"updated_at\": \"2018-04-05T04:05:02Z\",\n        \"billing_address\": {\n            \"street\": \"Malibu Point\",\n            \"number\": \"10880\",\n            \"zip_code\": \"90265\",\n            \"neighborhood\": \"Central Malibu\",\n            \"city\": \"Malibu\",\n            \"state\": \"CA\",\n            \"country\": \"US\",\n            \"line_1\": \"10880, Malibu Point, Central Malibu\"\n        },\n        \"type\": \"credit\"\n    },\n    \"plan\": {\n        \"id\": \"plan_dxVldzsgzu9rpe8v\",\n        \"name\": \"Premium\",\n        \"description\": \"VÃ¡ de Premium. E seja feliz!\",\n        \"url\": \"/plans/plan_dxVldzsgzu9rpe8v/vodafone-teste/premium\",\n        \"statement_descriptor\": \"Spotify\",\n        \"interval\": \"month\",\n        \"interval_count\": 1,\n        \"billing_type\": \"postpaid\",\n        \"payment_methods\": [\n            \"boleto\",\n            \"credit_card\"\n        ],\n        \"installments\": [\n            1\n        ],\n        \"status\": \"active\",\n        \"currency\": \"BRL\",\n        \"created_at\": \"2018-04-04T22:17:16Z\",\n        \"updated_at\": \"2018-04-04T22:17:16Z\"\n    },\n    \"items\": [\n        {\n            \"id\": \"si_5LPVYR1c7WuJd06l\",\n            \"name\": \"Name - Premium\",\n            \"description\": \"Test - Description\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2018-04-05T03:20:16Z\",\n            \"updated_at\": \"2018-04-05T03:20:16Z\",\n            \"pricing_scheme\": {\n                \"price\": 1490,\n                \"scheme_type\": \"unit\"\n            }\n        }\n    ]\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "sub_WeEMlp2FXFMjVq3Q"
                    },
                    "code": {
                      "type": "string",
                      "example": "8YNU49TD4Z"
                    },
                    "start_at": {
                      "type": "string",
                      "example": "2018-04-05T00:00:00Z"
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
                    "current_cycle": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cycle_6ow0JqhD5sJmMJPl"
                        },
                        "start_at": {
                          "type": "string",
                          "example": "2018-04-05T00:00:00Z"
                        },
                        "end_at": {
                          "type": "string",
                          "example": "2018-05-04T23:59:59Z"
                        },
                        "billing_at": {
                          "type": "string",
                          "example": "2018-05-05T00:00:00Z"
                        }
                      }
                    },
                    "setup": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "or_0Wd7bYRMSmSYy8qz"
                        },
                        "description": {
                          "type": "string",
                          "example": "InscriÃ§Ã£o"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 9990,
                          "default": 0
                        },
                        "status": {
                          "type": "string",
                          "example": "paid"
                        }
                      }
                    },
                    "next_billing_at": {
                      "type": "string",
                      "example": "2018-05-05T00:00:00Z"
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
                      "example": "2018-04-05T03:20:16Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2018-04-05T03:20:16Z"
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_px3yqRSlRsVqawgj"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "ef61ded5-9e60-40c7-89cd-a3b6e70515e8@avengers.com"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2018-04-05T03:20:15Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-04-05T03:20:15Z"
                        },
                        "phones": {
                          "type": "object",
                          "properties": {}
                        }
                      }
                    },
                    "card": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "card_PoDev5OCEEUjRJXp"
                        },
                        "first_six_digits": {
                          "type": "string",
                          "example": "542501"
                        },
                        "last_four_digits": {
                          "type": "string",
                          "example": "7793"
                        },
                        "brand": {
                          "type": "string",
                          "example": "Mastercard"
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
                          "example": 2022,
                          "default": 0
                        },
                        "status": {
                          "type": "string",
                          "example": "active"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2018-04-05T04:05:02Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-04-05T04:05:02Z"
                        },
                        "billing_address": {
                          "type": "object",
                          "properties": {
                            "street": {
                              "type": "string",
                              "example": "Malibu Point"
                            },
                            "number": {
                              "type": "string",
                              "example": "10880"
                            },
                            "zip_code": {
                              "type": "string",
                              "example": "90265"
                            },
                            "neighborhood": {
                              "type": "string",
                              "example": "Central Malibu"
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
                              "example": "10880, Malibu Point, Central Malibu"
                            }
                          }
                        },
                        "type": {
                          "type": "string",
                          "example": "credit"
                        }
                      }
                    },
                    "plan": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "plan_dxVldzsgzu9rpe8v"
                        },
                        "name": {
                          "type": "string",
                          "example": "Premium"
                        },
                        "description": {
                          "type": "string",
                          "example": "VÃ¡ de Premium. E seja feliz!"
                        },
                        "url": {
                          "type": "string",
                          "example": "/plans/plan_dxVldzsgzu9rpe8v/vodafone-teste/premium"
                        },
                        "statement_descriptor": {
                          "type": "string",
                          "example": "Spotify"
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
                        "payment_methods": {
                          "type": "array",
                          "items": {
                            "type": "string",
                            "example": "boleto"
                          }
                        },
                        "installments": {
                          "type": "array",
                          "items": {
                            "type": "integer",
                            "example": 1,
                            "default": 0
                          }
                        },
                        "status": {
                          "type": "string",
                          "example": "active"
                        },
                        "currency": {
                          "type": "string",
                          "example": "BRL"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2018-04-04T22:17:16Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-04-04T22:17:16Z"
                        }
                      }
                    },
                    "items": {
                      "type": "array",
                      "items": {
                        "type": "object",
                        "properties": {
                          "id": {
                            "type": "string",
                            "example": "si_5LPVYR1c7WuJd06l"
                          },
                          "name": {
                            "type": "string",
                            "example": "Name - Premium"
                          },
                          "description": {
                            "type": "string",
                            "example": "Test - Description"
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
                            "example": "2018-04-05T03:20:16Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2018-04-05T03:20:16Z"
                          },
                          "pricing_scheme": {
                            "type": "object",
                            "properties": {
                              "price": {
                                "type": "integer",
                                "example": 1490,
                                "default": 0
                              },
                              "scheme_type": {
                                "type": "string",
                                "example": "unit"
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
                    "value": "{\n    \"message\": \"Subscription not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Subscription not found."
                    }
                  }
                }
              }
            }
          },
          "422": {
            "description": "422",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"message\": \"The request is invalid.\",\n    \"errors\": {\n        \"\": [\n            \"The card_id, card_token or card field is required.\"\n        ]\n    },\n    \"request\": {\n        \"payment_method\": \"credit_card\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "The request is invalid."
                    },
                    "errors": {
                      "type": "object",
                      "properties": {
                        "": {
                          "type": "array",
                          "items": {
                            "type": "string",
                            "example": "The card_id, card_token or card field is required."
                          }
                        }
                      }
                    },
                    "request": {
                      "type": "object",
                      "properties": {
                        "payment_method": {
                          "type": "string",
                          "example": "credit_card"
                        }
                      }
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