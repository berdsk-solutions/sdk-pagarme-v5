# Editar data de inÃ­cio da assinatura

Com o verbo _HTTP PATCH_, atravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel atualizar a data de
inÃ­cio da assinatura.

> ðŸ“˜ Restrições de mudanÃ§a de data
>
> 1 - NÃ£o Ã© possÃ­vel atualizar a data de inÃ­cio da assinatura para o dia anterior ao dia atual.
>
> 2 - NÃ£o Ã© possÃ­vel atualizar a data de inÃ­cio de uma assinatura que jÃ¡ comeÃ§ou

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
    "/subscriptions/{subscription_id}/start-at": {
      "patch": {
        "summary": "Editar data de inÃ­cio da assinatura",
        "description": "Com o verbo _HTTP PATCH_, atravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel atualizar a data de inÃ­cio da assinatura.",
        "operationId": "editar-data-de-inÃ­cio-da-assinatura-1",
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
                  "start_at"
                ],
                "properties": {
                  "start_at": {
                    "type": "string",
                    "description": "Data de inÃ­cio da assinatura.",
                    "format": "date"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "start_at": "2019-01-01"
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
                    "value": "{\n    \"id\": \"sub_lmxK4k0hPfJ5z58w\",\n    \"code\": \"9X8HROC4E0\",\n    \"start_at\": \"2019-01-01T00:00:00Z\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"billing_type\": \"prepaid\",\n    \"gateway_affiliation_id\": \"C56A4180-65AA-42EC-A945-5FD21DEC0538\",\n    \"boleto_due_days\":5,\n    \"minimum_price\": 10000,\n    \"next_billing_at\": \"2019-01-01T00:00:00Z\",\n    \"payment_method\": \"credit_card\",\n    \"currency\": \"BRL\",\n    \"statement_descriptor\": \"Spotify\",\n    \"installments\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2018-04-03T19:04:24Z\",\n    \"updated_at\": \"2018-04-03T19:04:24Z\",\n    \"customer\": {\n        \"id\": \"cus_J4wRXJ0U6ytZrpOx\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"tstark@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2016-09-28T21:04:37Z\",\n        \"updated_at\": \"2017-03-22T19:06:14Z\"\n    },\n    \"card\": {\n        \"id\": \"card_pEYq7rDbFeiW8V6k\",\n        \"last_four_digits\": \"8229\",\n        \"brand\": \"Amex\",\n        \"holder_name\": \"Tony Stark\",\n        \"exp_month\": 1,\n        \"exp_year\": 2018,\n        \"status\": \"active\",\n        \"created_at\": \"2016-11-16T17:02:39Z\",\n        \"updated_at\": \"2016-12-29T12:03:24Z\",\n        \"billing_address\": {\n            \"line_1\": \"10880, Malibu Point, Malibu Central\",\n            \"zip_code\": \"90265\",\n            \"city\": \"Malibu\",\n            \"state\": \"CA\",\n            \"country\": \"US\"\n        }\n    },\n    \"plan\": {\n        \"id\": \"plan_pzrg5YhjyiqBgDw3\",\n        \"name\": \"Plano Premium\",\n        \"description\": \"VÃ¡ de Premium. E seja feliz!\",\n        \"url\": \"/plans/plan_pzrg5YhjyiqBgDw3/pagarme-teste/plano-premium\",\n        \"statement_descriptor\": \"Spotify\",\n        \"interval\": \"month\",\n        \"interval_count\": 1,\n        \"billing_type\": \"prepaid\",\n        \"payment_methods\": [\n            \"credit_card\"\n        ],\n        \"installments\": [\n            1\n        ],\n        \"status\": \"active\",\n        \"currency\": \"BRL\",\n        \"created_at\": \"2017-04-03T19:04:05Z\",\n        \"updated_at\": \"2017-04-03T19:04:05Z\"\n    },\n    \"items\": [\n        {\n            \"id\": \"si_K1Mj03JPSWFwxan4\",\n            \"description\": \"Bola\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2017-04-03T19:04:24Z\",\n            \"updated_at\": \"2017-04-03T19:04:24Z\",\n            \"pricing_scheme\": {\n                \"price\": 1490,\n                \"scheme_type\": \"unit\"\n            }\n        }\n    ]\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "sub_lmxK4k0hPfJ5z58w"
                    },
                    "code": {
                      "type": "string",
                      "example": "9X8HROC4E0"
                    },
                    "start_at": {
                      "type": "string",
                      "example": "2019-01-01T00:00:00Z"
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
                      "example": "prepaid"
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
                    "next_billing_at": {
                      "type": "string",
                      "example": "2019-01-01T00:00:00Z"
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
                      "example": "2018-04-03T19:04:24Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2018-04-03T19:04:24Z"
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_J4wRXJ0U6ytZrpOx"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
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
                          "example": "2017-03-22T19:06:14Z"
                        }
                      }
                    },
                    "card": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "card_pEYq7rDbFeiW8V6k"
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
                    "plan": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "plan_pzrg5YhjyiqBgDw3"
                        },
                        "name": {
                          "type": "string",
                          "example": "Plano Premium"
                        },
                        "description": {
                          "type": "string",
                          "example": "VÃ¡ de Premium. E seja feliz!"
                        },
                        "url": {
                          "type": "string",
                          "example": "/plans/plan_pzrg5YhjyiqBgDw3/pagarme-teste/plano-premium"
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
                          "example": "prepaid"
                        },
                        "payment_methods": {
                          "type": "array",
                          "items": {
                            "type": "string",
                            "example": "credit_card"
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
                          "example": "2017-04-03T19:04:05Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-03T19:04:05Z"
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
                            "example": "si_K1Mj03JPSWFwxan4"
                          },
                          "description": {
                            "type": "string",
                            "example": "Bola"
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
                            "example": "2017-04-03T19:04:24Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2017-04-03T19:04:24Z"
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
                    "value": "{\n    \"message\": \"The request is invalid.\",\n    \"errors\": {\n        \"next_billing_at\": [\n            \"The next_billing_at field is invalid.\"\n        ]\n    },\n    \"request\": {}\n}"
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
                        "next_billing_at": {
                          "type": "array",
                          "items": {
                            "type": "string",
                            "example": "The next_billing_at field is invalid."
                          }
                        }
                      }
                    },
                    "request": {
                      "type": "object",
                      "properties": {}
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