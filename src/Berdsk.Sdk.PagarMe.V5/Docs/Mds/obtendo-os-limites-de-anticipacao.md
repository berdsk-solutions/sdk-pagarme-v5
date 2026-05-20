# Obtendo os limites de antecipaÃ§Ã£o

Retorna os limites mÃ¡ximos e mÃ­nimos de antecipaÃ§Ã£o que um recebedor pode fazer.

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
    "/recipients/{recipient_id}/bulk_anticipations/limits": {
      "get": {
        "summary": "Obtendo os limites de antecipaÃ§Ã£o",
        "description": "Retorna os limites mÃ¡ximos e mÃ­nimos de antecipaÃ§Ã£o que um recebedor pode fazer.",
        "operationId": "obtendo-os-limites-de-antecipaÃ§Ã£o",
        "parameters": [
          {
            "name": "recipient_id",
            "in": "path",
            "description": "Identificador do recebedor",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "payment_date",
            "in": "query",
            "description": "Data de pagamento desejada para a antecipaÃ§Ã£o, ou seja, data em que vocÃª deseja que o dinheiro esteja em sua conta Pagar.me disponÃ­vel para saque",
            "required": true,
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "timeframe",
            "in": "query",
            "description": "Define o perÃ­odo de onde os recebÃ­veis serÃ£o escolhidos. start define recebÃ­veis prÃ³ximos, perto de serem pagos, e end define recebÃ­veis longes, no final de todos recebÃ­veis que vocÃª possui para receber",
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "200",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"maximum\": {\n        \"amount\": 0,\n        \"anticipation_fee\": 0,\n        \"fee\": 0,\n        \"fraud_coverage_fee\": 0\n    },\n    \"minimum\": {\n        \"amount\": 0,\n        \"anticipation_fee\": 0,\n        \"fee\": 0,\n        \"fraud_coverage_fee\": 0\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "maximum": {
                      "type": "object",
                      "properties": {
                        "amount": {
                          "type": "integer",
                          "example": 0,
                          "default": 0
                        },
                        "anticipation_fee": {
                          "type": "integer",
                          "example": 0,
                          "default": 0
                        },
                        "fee": {
                          "type": "integer",
                          "example": 0,
                          "default": 0
                        },
                        "fraud_coverage_fee": {
                          "type": "integer",
                          "example": 0,
                          "default": 0
                        }
                      }
                    },
                    "minimum": {
                      "type": "object",
                      "properties": {
                        "amount": {
                          "type": "integer",
                          "example": 0,
                          "default": 0
                        },
                        "anticipation_fee": {
                          "type": "integer",
                          "example": 0,
                          "default": 0
                        },
                        "fee": {
                          "type": "integer",
                          "example": 0,
                          "default": 0
                        },
                        "fraud_coverage_fee": {
                          "type": "integer",
                          "example": 0,
                          "default": 0
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
                    "value": "{ \"errors\": [{ \"type\": \"not_found_error\", \"message\": \"Recipient nÃ£o encontrado.\" }] }"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "errors": {
                      "type": "array",
                      "items": {
                        "type": "object",
                        "properties": {
                          "type": {
                            "type": "string",
                            "example": "not_found_error"
                          },
                          "message": {
                            "type": "string",
                            "example": "Recipient nÃ£o encontrado."
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