# Editar metadados do plano

Com o verbo _HTTP PATCH_, atravÃ©s do identificador do plano (`plan_id`) Ã© possÃ­vel atualizar o objeto `metadata` do
plano.

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
    "/plans/{plan_id}/metadata": {
      "patch": {
        "summary": "Editar metadados do plano",
        "description": "Com o verbo _HTTP PATCH_, atravÃ©s do identificador do plano (`plan_id`) Ã© possÃ­vel atualizar o objeto `metadata` do plano.",
        "operationId": "editar-metadados-do-plano-1",
        "parameters": [
          {
            "name": "plan_id",
            "in": "path",
            "description": "CÃ³digo do plano.<br>Formato: `plan_XXXXXXXXXXXXXXXX`.",
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
                    "type": "object",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre o plano.",
                    "properties": {}
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
                    "value": "{\n    \"id\": \"plan_jEJWD1qF2Xf92eKv\",\n    \"name\": \"Premium\",\n    \"description\": \"VÃ¡ de Premium. E seja feliz!\",\n    \"url\": \"/plans/plan_jEJWD1qF2Xf92eKv/pagarme-teste/premium\",\n    \"statement_descriptor\": \"Spotify\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"minimum_price\": 10000,\n    \"billing_type\": \"postpaid\",\n    \"payment_methods\": [\n        \"boleto\",\n        \"credit_card\"\n    ],\n    \"installments\": [\n        1\n    ],\n    \"status\": \"active\",\n    \"currency\": \"BRL\",\n    \"created_at\": \"2017-08-10T21:27:08Z\",\n    \"updated_at\": \"2017-08-10T21:33:24Z\",\n    \"items\": [\n        {\n            \"id\": \"pi_JDG10BpS1sKwboXk\",\n            \"name\": \"Premium\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2017-08-10T21:27:08Z\",\n            \"updated_at\": \"2017-08-10T21:27:08Z\",\n            \"pricing_scheme\": {\n                \"price\": 1490,\n                \"scheme_type\": \"unit\"\n            }\n        }\n    ],\n    \"metadata\": {\n        \"code\": \"1234\",\n        \"company\": \"Avengers\"\n    }\n}"
                  }
                },
                "schema": {
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
                    "minimum_price": {
                      "type": "integer",
                      "example": 10000,
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
                      "example": "2017-08-10T21:33:24Z"
                    },
                    "items": {
                      "type": "array",
                      "items": {
                        "type": "object",
                        "properties": {
                          "id": {
                            "type": "string",
                            "example": "pi_JDG10BpS1sKwboXk"
                          },
                          "name": {
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
                            "example": "2017-08-10T21:27:08Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2017-08-10T21:27:08Z"
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
                    "value": "{\n    \"message\": \"Plan not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Plan not found."
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