# Criando uma antecipaÃ§Ã£o

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
    "/recipients/{recipient_id}/bulk_anticipations": {
      "post": {
        "summary": "Criando uma antecipaÃ§Ã£o",
        "description": "",
        "operationId": "criando-uma-antecipaÃ§Ã£o",
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "required": [
                  "payment_date",
                  "timeframe",
                  "requested_amount"
                ],
                "properties": {
                  "payment_date": {
                    "type": "string",
                    "description": "Data de pagamento da antecipaÃ§Ã£o. Data no formato ISO 8601"
                  },
                  "timeframe": {
                    "type": "string",
                    "description": "Define o perÃ­odo de onde os recebÃ­veis serÃ£o escolhidos. start define recebÃ­veis prÃ³ximos, perto de serem pagos, e end define recebÃ­veis longes, no final de todos recebÃ­veis que vocÃª possui para receber. String `start` ou `end`"
                  },
                  "requested_amount": {
                    "type": "integer",
                    "description": "Valor lÃ­quido, em centavos, que vocÃª deseja receber de antecipaÃ§Ã£o",
                    "format": "int32"
                  },
                  "automatic_transfer": {
                    "type": "boolean",
                    "description": "Define se o valor da antecipaÃ§Ã£o serÃ¡ transferido automaticamente para a conta bancÃ¡ria do recebedor",
                    "default": false
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
                    "value": "{\n    \"id\": \"ba_123456789\",\n    \"status\": \"approved\",\n    \"amount\": 100000,\n    \"fee\": 5000,\n    \"fraud_coverage_fee\": 0,\n    \"anticipation_fee\": 3000,\n    \"automatic_transfer\": false,\n    \"type\": \"spot\",\n    \"timeframe\": \"start\",\n    \"payment_date\": \"2025-08-20T00:00:00.000Z\",\n    \"created_at\": \"2025-08-19T14:23:00.000Z\",\n    \"updated_at\": \"2025-08-20T10:15:00.000Z\",\n    \"anticipation_tax\": null\n  }"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "ba_123456789"
                    },
                    "status": {
                      "type": "string",
                      "example": "approved"
                    },
                    "amount": {
                      "type": "integer",
                      "example": 100000,
                      "default": 0
                    },
                    "fee": {
                      "type": "integer",
                      "example": 5000,
                      "default": 0
                    },
                    "fraud_coverage_fee": {
                      "type": "integer",
                      "example": 0,
                      "default": 0
                    },
                    "anticipation_fee": {
                      "type": "integer",
                      "example": 3000,
                      "default": 0
                    },
                    "automatic_transfer": {
                      "type": "boolean",
                      "example": false,
                      "default": true
                    },
                    "type": {
                      "type": "string",
                      "example": "spot"
                    },
                    "timeframe": {
                      "type": "string",
                      "example": "start"
                    },
                    "payment_date": {
                      "type": "string",
                      "example": "2025-08-20T00:00:00.000Z"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2025-08-19T14:23:00.000Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2025-08-20T10:15:00.000Z"
                    },
                    "anticipation_tax": {}
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
                    "value": "{ \"errors\": [{ \"type\": \"invalid_parameter_error\", \"parameter_name\": \"payment_date\", \"message\": \"A data de pagamento deve ser um dia Ãºtil.\" }] }"
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
                            "example": "invalid_parameter_error"
                          },
                          "parameter_name": {
                            "type": "string",
                            "example": "payment_date"
                          },
                          "message": {
                            "type": "string",
                            "example": "A data de pagamento deve ser um dia Ãºtil."
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