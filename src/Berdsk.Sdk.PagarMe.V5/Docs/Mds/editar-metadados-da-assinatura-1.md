# Editar metadados da assinatura

Com o verbo _HTTP PATCH_, atravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel atualizar o objeto
`metadata` da assinatura.

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
    "/subscriptions/{subscription_id}/metadata": {
      "patch": {
        "summary": "Editar metadados da assinatura",
        "description": "Com o verbo _HTTP PATCH_, atravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel atualizar o objeto `metadata` da assinatura.",
        "operationId": "editar-metadados-da-assinatura-1",
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
                "required": [
                  "metadata"
                ],
                "properties": {
                  "metadata": {
                    "type": "string",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre a assinatura.<br>[Saiba mais sobre metadata](https://docs.pagar.me/reference/metadata-1)"
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
                    "value": "{\n    \"id\": \"sub_yOkq7oI03S7Wq741\",\n    \"code\": \"V9OMHENIK6\",\n    \"start_at\": \"2017-08-10T00:00:00Z\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"billing_type\": \"postpaid\",\n    \"gateway_affiliation_id\": \"C56A4180-65AA-42EC-A945-5FD21DEC0538\",\n    \"boleto_due_days\":5,\n    \"minimum_price\": 10000,\n    \"current_cycle\": {\n        \"id\": \"cycle_Z82JyBgSM2iwe4Lp\",\n        \"start_at\": \"2017-08-10T00:00:00Z\",\n        \"end_at\": \"2017-09-09T23:59:59Z\",\n        \"billing_at\": \"2017-09-10T00:00:00Z\"\n    },\n    \"setup\": {\n        \"id\": \"or_8e0l1KGFZgIpzNVG\",\n        \"description\": \"InscriÃ§Ã£o\",\n        \"amount\": 9990,\n        \"status\": \"paid\"\n    },\n    \"next_billing_at\": \"2017-09-10T00:00:00Z\",\n    \"payment_method\": \"credit_card\",\n    \"currency\": \"BRL\",\n    \"statement_descriptor\": \"Spotify\",\n    \"installments\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2017-08-10T21:27:13Z\",\n    \"updated_at\": \"2017-08-10T21:27:29Z\",\n    \"customer\": {\n        \"id\": \"cus_4jEgBpgfbIe6vnqy\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"f95783c1-c288-4dfb-9e1f-c3b9a4d55a7b@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2017-08-10T21:27:11Z\",\n        \"updated_at\": \"2017-08-10T21:27:11Z\",\n        \"phones\": {}\n    },\n    \"card\": {\n        \"id\": \"card_bQzW0GMfnAsry6KM\",\n        \"first_six_digits\": \"342793\",\n        \"last_four_digits\": \"8229\",\n        \"brand\": \"Amex\",\n        \"holder_name\": \"Tony Stark\",\n        \"exp_month\": 1,\n        \"exp_year\": 2018,\n        \"status\": \"active\",\n        \"created_at\": \"2017-08-10T21:27:12Z\",\n        \"updated_at\": \"2017-08-10T21:27:12Z\",\n        \"billing_address\": {\n            \"line_1\": \"10880, Malibu Point, Malibu Central\",\n            \"zip_code\": \"90265\",\n            \"city\": \"Malibu\",\n            \"state\": \"CA\",\n            \"country\": \"US\"\n        },\n        \"type\": \"credit\"\n    },\n    \"plan\": {\n        \"id\": \"plan_jEJWD1qF2Xf92eKv\",\n        \"name\": \"Premium\",\n        \"description\": \"VÃ¡ de Premium. E seja feliz!\",\n        \"url\": \"/plans/plan_jEJWD1qF2Xf92eKv/pagarme-teste/premium\",\n        \"statement_descriptor\": \"Spotify\",\n        \"interval\": \"month\",\n        \"interval_count\": 1,\n        \"billing_type\": \"postpaid\",\n        \"payment_methods\": [\n            \"boleto\",\n            \"credit_card\"\n        ],\n        \"installments\": [\n            1\n        ],\n        \"status\": \"active\",\n        \"currency\": \"BRL\",\n        \"created_at\": \"2017-08-10T21:27:08Z\",\n        \"updated_at\": \"2017-08-10T21:27:08Z\"\n    },\n    \"items\": [\n        {\n            \"id\": \"si_ZY8Vrapsnu9QjMde\",\n            \"description\": \"Premium\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2017-08-10T21:27:14Z\",\n            \"updated_at\": \"2017-08-10T21:27:14Z\",\n            \"pricing_scheme\": {\n                \"price\": 1490,\n                \"scheme_type\": \"unit\"\n            }\n        }\n    ],\n    \"metadata\": {\n        \"code\": \"1234\",\n        \"company\": \"Avengers\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "sub_yOkq7oI03S7Wq741"
                    },
                    "code": {
                      "type": "string",
                      "example": "V9OMHENIK6"
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
                    "gateway_affiliation_id": {
                      "type": "string",
                      "example": "C56A4180-65AA-42EC-A945-5FD21DEC0538"
                    },
                    "boleto_due_days": {
                      "type": "integer",
                      "example": 5,
                      "default": 0
                    },
                    "minimum_price": {
                      "type": "integer",
                      "example": 10000,
                      "default": 0
                    },
                    "current_cycle": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cycle_Z82JyBgSM2iwe4Lp"
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
                    "setup": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "or_8e0l1KGFZgIpzNVG"
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
                      "example": "2017-08-10T21:27:13Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-08-10T21:27:29Z"
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_4jEgBpgfbIe6vnqy"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "f95783c1-c288-4dfb-9e1f-c3b9a4d55a7b@avengers.com"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-08-10T21:27:11Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-08-10T21:27:11Z"
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
                          "example": "card_bQzW0GMfnAsry6KM"
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
                          "example": "2017-08-10T21:27:12Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-08-10T21:27:12Z"
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
                    "plan": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "plan_jEJWD1qF2Xf92eKv"
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
                          "example": "/plans/plan_jEJWD1qF2Xf92eKv/pagarme-teste/premium"
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
                          "example": "2017-08-10T21:27:08Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-08-10T21:27:08Z"
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
                            "example": "si_ZY8Vrapsnu9QjMde"
                          },
                          "description": {
                            "type": "string",
                            "example": "Premium"
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
                            "example": "2017-08-10T21:27:14Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2017-08-10T21:27:14Z"
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