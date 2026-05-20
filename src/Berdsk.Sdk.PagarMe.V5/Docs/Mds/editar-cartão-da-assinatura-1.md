# Editar cartÃ£o da assinatura

Com o verbo _HTTP PATCH_, atravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel atualizar o cartÃ£o
utilizado para pagamento da assinatura.

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
    "/subscriptions/{subscription_id}/card": {
      "patch": {
        "summary": "Editar cartÃ£o da assinatura",
        "description": "Com o verbo _HTTP PATCH_, atravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel atualizar o cartÃ£o utilizado para pagamento da assinatura.",
        "operationId": "editar-cartÃ£o-da-assinatura-1",
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
                  "card_id": {
                    "type": "string",
                    "description": "CÃ³digo do cartÃ£o.<br>Formato: `card_XXXXXXXXXXXXXXXX`."
                  },
                  "card": {
                    "type": "string",
                    "description": "Dados do novo cartÃ£o.[Saiba mais sobre cartÃµes](https://docs.pagar.me/reference/cart%C3%B5es-1)"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "card": {
                      "number": "4532912167490007",
                      "holder_name": "Tony Stark",
                      "exp_month": 6,
                      "exp_year": 30,
                      "cvv": "474",
                      "billing_address": {
                        "line_1": "375, Av. General Justo, Centro",
                        "line_2": "8Âº andar",
                        "zip_code": "20021130",
                        "city": "Rio de Janeiro",
                        "state": "RJ",
                        "country": "BR"
                      }
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
                    "value": "{\n    \"id\": \"sub_WeEMlp2FXFMjVq3Q\",\n    \"code\": \"8YNU49TD4Z\",\n    \"start_at\": \"2018-04-05T00:00:00Z\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"billing_type\": \"postpaid\",\n    \"boleto_due_days\":5,\n    \"current_cycle\": {\n        \"id\": \"cycle_6ow0JqhD5sJmMJPl\",\n        \"start_at\": \"2018-04-05T00:00:00Z\",\n        \"end_at\": \"2018-05-04T23:59:59Z\",\n        \"billing_at\": \"2018-05-05T00:00:00Z\"\n    },\n    \"setup\": {\n        \"id\": \"or_0Wd7bYRMSmSYy8qz\",\n        \"description\": \"InscriÃ§Ã£o\",\n        \"amount\": 9990,\n        \"status\": \"paid\"\n    },\n    \"next_billing_at\": \"2018-05-05T00:00:00Z\",\n    \"payment_method\": \"credit_card\",\n    \"currency\": \"BRL\",\n    \"statement_descriptor\": \"Spotify\",\n    \"installments\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2018-04-05T03:20:16Z\",\n    \"updated_at\": \"2018-04-05T03:20:16Z\",\n    \"customer\": {\n        \"id\": \"cus_px3yqRSlRsVqawgj\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"ef61ded5-9e60-40c7-89cd-a3b6e70515e8@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2018-04-05T03:20:15Z\",\n        \"updated_at\": \"2018-04-05T03:20:15Z\",\n        \"phones\": {}\n    },\n    \"card\": {\n        \"id\": \"card_qgoM31jhLidx2nm1\",\n        \"first_six_digits\": \"453291\",\n        \"last_four_digits\": \"0007\",\n        \"brand\": \"Visa\",\n        \"holder_name\": \"Tony Stark\",\n        \"exp_month\": 6,\n        \"exp_year\": 2030,\n        \"status\": \"active\",\n        \"created_at\": \"2018-04-05T03:29:58Z\",\n        \"updated_at\": \"2018-04-05T03:49:28Z\",\n        \"billing_address\": {\n            \"zip_code\": \"20021130\",\n            \"city\": \"Rio de Janeiro\",\n            \"state\": \"RJ\",\n            \"country\": \"BR\",\n            \"line_1\": \"375, Av. General Justo, Centro\",\n            \"line_2\": \"8Âº andar\"\n        },\n        \"type\": \"credit\"\n    },\n    \"plan\": {\n        \"id\": \"plan_dxVldzsgzu9rpe8v\",\n        \"name\": \"Premium\",\n        \"description\": \"VÃ¡ de Premium. E seja feliz!\",\n        \"url\": \"/plans/plan_dxVldzsgzu9rpe8v/vodafone-teste/premium\",\n        \"statement_descriptor\": \"Spotify\",\n        \"interval\": \"month\",\n        \"interval_count\": 1,\n        \"billing_type\": \"postpaid\",\n        \"payment_methods\": [\n            \"boleto\",\n            \"credit_card\"\n        ],\n        \"installments\": [\n            1\n        ],\n        \"status\": \"active\",\n        \"currency\": \"BRL\",\n        \"created_at\": \"2018-04-04T22:17:16Z\",\n        \"updated_at\": \"2018-04-04T22:17:16Z\"\n    },\n    \"items\": [\n        {\n            \"id\": \"si_5LPVYR1c7WuJd06l\",\n            \"name\": \"Name - Premium\",\n            \"description\": \"Test - Description\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2018-04-05T03:20:16Z\",\n            \"updated_at\": \"2018-04-05T03:20:16Z\",\n            \"pricing_scheme\": {\n                \"price\": 1490,\n                \"scheme_type\": \"unit\"\n            }\n        }\n    ]\n}"
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
                          "example": "card_qgoM31jhLidx2nm1"
                        },
                        "first_six_digits": {
                          "type": "string",
                          "example": "453291"
                        },
                        "last_four_digits": {
                          "type": "string",
                          "example": "0007"
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
                          "example": 6,
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
                          "example": "2018-04-05T03:29:58Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-04-05T03:49:28Z"
                        },
                        "billing_address": {
                          "type": "object",
                          "properties": {
                            "zip_code": {
                              "type": "string",
                              "example": "20021130"
                            },
                            "city": {
                              "type": "string",
                              "example": "Rio de Janeiro"
                            },
                            "state": {
                              "type": "string",
                              "example": "RJ"
                            },
                            "country": {
                              "type": "string",
                              "example": "BR"
                            },
                            "line_1": {
                              "type": "string",
                              "example": "375, Av. General Justo, Centro"
                            },
                            "line_2": {
                              "type": "string",
                              "example": "8Âº andar"
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
                    "value": "{\n    \"message\": \"The request is invalid.\",\n    \"errors\": {\n        \"card.number\": [\n            \"The number field is not a valid credit card number.\"\n        ]\n    },\n    \"request\": {\n        \"card\": {\n            \"number\": \"4532912167490008\",\n            \"last_four_digits\": \"0008\",\n            \"brand\": \"Visa\",\n            \"holder_name\": \"Tony Stark\",\n            \"exp_month\": 6,\n            \"exp_year\": 20,\n            \"cvv\": \"474\",\n            \"billing_address\": {\n                \"zip_code\": \"20021130\",\n                \"city\": \"Rio de Janeiro\",\n                \"state\": \"RJ\",\n                \"country\": \"BR\",\n                \"line_1\": \"375, Av. General Justo, Centro\",\n                \"line_2\": \"8Âº andar\",\n                \"globalType\": true\n            },\n            \"options\": {}\n        }\n    }\n}"
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
                        "card.number": {
                          "type": "array",
                          "items": {
                            "type": "string",
                            "example": "The number field is not a valid credit card number."
                          }
                        }
                      }
                    },
                    "request": {
                      "type": "object",
                      "properties": {
                        "card": {
                          "type": "object",
                          "properties": {
                            "number": {
                              "type": "string",
                              "example": "4532912167490008"
                            },
                            "last_four_digits": {
                              "type": "string",
                              "example": "0008"
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
                              "example": 6,
                              "default": 0
                            },
                            "exp_year": {
                              "type": "integer",
                              "example": 20,
                              "default": 0
                            },
                            "cvv": {
                              "type": "string",
                              "example": "474"
                            },
                            "billing_address": {
                              "type": "object",
                              "properties": {
                                "zip_code": {
                                  "type": "string",
                                  "example": "20021130"
                                },
                                "city": {
                                  "type": "string",
                                  "example": "Rio de Janeiro"
                                },
                                "state": {
                                  "type": "string",
                                  "example": "RJ"
                                },
                                "country": {
                                  "type": "string",
                                  "example": "BR"
                                },
                                "line_1": {
                                  "type": "string",
                                  "example": "375, Av. General Justo, Centro"
                                },
                                "line_2": {
                                  "type": "string",
                                  "example": "8Âº andar"
                                },
                                "globalType": {
                                  "type": "boolean",
                                  "example": true,
                                  "default": true
                                }
                              }
                            },
                            "options": {
                              "type": "object",
                              "properties": {}
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