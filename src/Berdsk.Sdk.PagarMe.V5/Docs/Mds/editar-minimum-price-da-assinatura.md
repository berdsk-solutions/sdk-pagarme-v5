# Editar preÃ§o mÃ­nimo da assinatura

Com o verbo HTTP PATCH, atravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel atualizar o minimum price
da assinatura.

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
    "/subscriptions/{subscription_id}/minimum_price": {
      "patch": {
        "summary": "Editar preÃ§o mÃ­nimo da assinatura",
        "description": "Com o verbo HTTP PATCH, atravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel atualizar o minimum price da assinatura.",
        "operationId": "editar-minimum-price-da-assinatura",
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
                  "minimum_price": {
                    "type": "integer",
                    "description": "Valor mÃ­nimo da assinatura em centavos.",
                    "format": "int32"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "minimum_price": "100"
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
                    "value": "{\n    \"id\": \"sub_JrvX5MpS6Niq9wzL\",\n    \"code\": \"6NXQF71FJD\",\n    \"start_at\": \"2022-03-10T00:00:00Z\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"billing_type\": \"prepaid\",\n    \"current_cycle\": {\n        \"id\": \"cycle_g6ek64cdmtE6JqVj\",\n        \"start_at\": \"2022-03-10T00:00:00Z\",\n        \"end_at\": \"2022-04-09T23:59:59Z\",\n        \"billing_at\": \"2022-03-10T00:00:00Z\",\n        \"status\": \"billed\",\n        \"cycle\": 1\n    },\n    \"next_billing_at\": \"2022-04-10T00:00:00Z\",\n    \"payment_method\": \"boleto\",\n    \"currency\": \"BRL\",\n    \"installments\": 1,\n    \"minimum_price\": 100,\n    \"status\": \"active\",\n    \"boleto_due_days\": 20,\n    \"created_at\": \"2022-03-10T19:42:17Z\",\n    \"updated_at\": \"2022-03-10T19:42:56Z\",\n    \"customer\": {\n        \"id\": \"cus_EbKg5vdUK9hJ0MVX\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"98724a80-19ef-4208-bee4-739c138eb85f@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2022-03-10T19:42:17Z\",\n        \"updated_at\": \"2022-03-10T19:42:17Z\",\n        \"phones\": {}\n    },\n    \"items\": [\n        {\n            \"id\": \"si_ZO5pLyltRf80ml6B\",\n            \"name\": \"Premium\",\n            \"description\": \"Sem anuncios\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2022-03-10T19:42:17Z\",\n            \"updated_at\": \"2022-03-10T19:42:17Z\",\n            \"pricing_scheme\": {\n                \"price\": 1490,\n                \"scheme_type\": \"unit\"\n            }\n        },\n        {\n            \"id\": \"si_yNo8g7TadToJ8bPa\",\n            \"name\": \"Silver\",\n            \"description\": \"Com anuncios\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2022-03-10T19:42:17Z\",\n            \"updated_at\": \"2022-03-10T19:42:17Z\",\n            \"pricing_scheme\": {\n                \"price\": 2000,\n                \"scheme_type\": \"unit\"\n            }\n        }\n    ]\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "sub_JrvX5MpS6Niq9wzL"
                    },
                    "code": {
                      "type": "string",
                      "example": "6NXQF71FJD"
                    },
                    "start_at": {
                      "type": "string",
                      "example": "2022-03-10T00:00:00Z"
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
                    "current_cycle": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cycle_g6ek64cdmtE6JqVj"
                        },
                        "start_at": {
                          "type": "string",
                          "example": "2022-03-10T00:00:00Z"
                        },
                        "end_at": {
                          "type": "string",
                          "example": "2022-04-09T23:59:59Z"
                        },
                        "billing_at": {
                          "type": "string",
                          "example": "2022-03-10T00:00:00Z"
                        },
                        "status": {
                          "type": "string",
                          "example": "billed"
                        },
                        "cycle": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
                        }
                      }
                    },
                    "next_billing_at": {
                      "type": "string",
                      "example": "2022-04-10T00:00:00Z"
                    },
                    "payment_method": {
                      "type": "string",
                      "example": "boleto"
                    },
                    "currency": {
                      "type": "string",
                      "example": "BRL"
                    },
                    "installments": {
                      "type": "integer",
                      "example": 1,
                      "default": 0
                    },
                    "minimum_price": {
                      "type": "integer",
                      "example": 100,
                      "default": 0
                    },
                    "status": {
                      "type": "string",
                      "example": "active"
                    },
                    "boleto_due_days": {
                      "type": "integer",
                      "example": 20,
                      "default": 0
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2022-03-10T19:42:17Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2022-03-10T19:42:56Z"
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_EbKg5vdUK9hJ0MVX"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "98724a80-19ef-4208-bee4-739c138eb85f@avengers.com"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2022-03-10T19:42:17Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2022-03-10T19:42:17Z"
                        },
                        "phones": {
                          "type": "object",
                          "properties": {}
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
                            "example": "si_ZO5pLyltRf80ml6B"
                          },
                          "name": {
                            "type": "string",
                            "example": "Premium"
                          },
                          "description": {
                            "type": "string",
                            "example": "Sem anuncios"
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
                            "example": "2022-03-10T19:42:17Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2022-03-10T19:42:17Z"
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