# Cancelar assinatura

Com o verbo HTTP DELETE, atravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel cancelar a assinatura.

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
    "/subscriptions/{subscription_id}": {
      "delete": {
        "summary": "Cancelar assinatura",
        "description": "Com o verbo HTTP DELETE, atravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel cancelar a assinatura.",
        "operationId": "cancelar-assinatura-1",
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
                  "cancel_pending_invoices": {
                    "type": "boolean",
                    "description": "Parâmetro que define se as cobranÃ§as e faturas pendentes dentro de uma assinatura serÃ£o canceladas automaticamente com a execuÃ§Ã£o do cancelamento da assinatura",
                    "default": true
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
                    "value": "{\n    \"id\": \"sub_WeEMlp2FXFMjVq3Q\",\n    \"code\": \"8YNU49TD4Z\",\n    \"start_at\": \"2018-04-05T00:00:00Z\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"billing_type\": \"postpaid\",\n    \"boleto_due_days\":5,\n    \"current_cycle\": {\n        \"id\": \"cycle_6ow0JqhD5sJmMJPl\",\n        \"start_at\": \"2018-04-05T00:00:00Z\",\n        \"end_at\": \"2018-05-04T23:59:59Z\",\n        \"billing_at\": \"2018-04-05T00:00:00Z\"\n    },\n    \"setup\": {\n        \"id\": \"or_0Wd7bYRMSmSYy8qz\",\n        \"description\": \"InscriÃ§Ã£o\",\n        \"amount\": 9990,\n        \"status\": \"paid\"\n    },\n    \"next_billing_at\": \"2018-04-05T00:00:00Z\",\n    \"payment_method\": \"boleto\",\n    \"currency\": \"BRL\",\n    \"statement_descriptor\": \"Spotify\",\n    \"installments\": 1,\n    \"status\": \"canceled\",\n    \"created_at\": \"2018-04-05T03:20:16Z\",\n    \"updated_at\": \"2018-04-05T12:14:06Z\",\n    \"canceled_at\": \"2018-04-05T12:14:06Z\",\n    \"customer\": {\n        \"id\": \"cus_px3yqRSlRsVqawgj\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"ef61ded5-9e60-40c7-89cd-a3b6e70515e8@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2018-04-05T03:20:15Z\",\n        \"updated_at\": \"2018-04-05T03:20:15Z\",\n        \"phones\": {}\n    },\n    \"plan\": {\n        \"id\": \"plan_dxVldzsgzu9rpe8v\",\n        \"name\": \"Premium\",\n        \"description\": \"VÃ¡ de Premium. E seja feliz!\",\n        \"url\": \"/plans/plan_dxVldzsgzu9rpe8v/vodafone-teste/premium\",\n        \"statement_descriptor\": \"Spotify\",\n        \"interval\": \"month\",\n        \"interval_count\": 1,\n        \"billing_type\": \"postpaid\",\n        \"payment_methods\": [\n            \"boleto\",\n            \"credit_card\"\n        ],\n        \"installments\": [\n            1\n        ],\n        \"status\": \"active\",\n        \"currency\": \"BRL\",\n        \"created_at\": \"2018-04-04T22:17:16Z\",\n        \"updated_at\": \"2018-04-04T22:17:16Z\"\n    },\n    \"items\": [\n        {\n            \"id\": \"si_5LPVYR1c7WuJd06l\",\n            \"name\": \"Name - Premium\",\n            \"description\": \"Test - Description\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2018-04-05T03:20:16Z\",\n            \"updated_at\": \"2018-04-05T03:20:16Z\",\n            \"pricing_scheme\": {\n                \"price\": 1490,\n                \"scheme_type\": \"unit\"\n            }\n        }\n    ]\n}"
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
                    "boleto_due_days": {
                      "type": "integer",
                      "example": 5,
                      "default": 0
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
                          "example": "2018-04-05T00:00:00Z"
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
                      "example": "2018-04-05T00:00:00Z"
                    },
                    "payment_method": {
                      "type": "string",
                      "example": "boleto"
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
                      "example": "canceled"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2018-04-05T03:20:16Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2018-04-05T12:14:06Z"
                    },
                    "canceled_at": {
                      "type": "string",
                      "example": "2018-04-05T12:14:06Z"
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