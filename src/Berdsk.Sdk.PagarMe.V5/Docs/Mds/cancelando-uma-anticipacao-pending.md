# Cancelando uma antecipaÃ§Ã£o pending

Cancela uma antecipaÃ§Ã£o com status pending. Enquanto a antecipaÃ§Ã£o foi criada e o Pagar.me ainda nÃ£o a confirmou, vocÃª pode cancelar a antecipaÃ§Ã£o a qualquer momento.

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
    "/recipients/{recipient_id}/bulk_anticipations/{bulk_anticipation_id}/cancel": {
      "post": {
        "summary": "Cancelando uma antecipaÃ§Ã£o pending",
        "description": "Cancela uma antecipaÃ§Ã£o com status pending. Enquanto a antecipaÃ§Ã£o foi criada e o Pagar.me ainda nÃ£o a confirmou, vocÃª pode cancelar a antecipaÃ§Ã£o a qualquer momento.",
        "operationId": "cancelando-uma-antecipaÃ§Ã£o-pending",
        "parameters": [
          {
            "name": "recipient_id",
            "in": "path",
            "description": "ID de recebedor desejado",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "bulk_anticipation_id",
            "in": "path",
            "description": "ID da antecipaÃ§Ã£o desejada",
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
                    "value": "{\n  \"id\": \"ba_123456789\",\n  \"status\": \"canceled\",\n  \"amount\": 100000,\n  \"fee\": 5000,\n  \"fraud_coverage_fee\": 0,\n  \"anticipation_fee\": 3000,\n  \"automatic_transfer\": false,\n  \"type\": \"spot\",\n  \"timeframe\": \"start\",\n  \"payment_date\": \"2025-08-20T00:00:00.000Z\",\n  \"created_at\": \"2025-08-19T14:23:00.000Z\",\n  \"updated_at\": \"2025-08-20T10:15:00.000Z\",\n  \"anticipation_tax\": 0.018\n}"
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
                      "example": "canceled"
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
                    "anticipation_tax": {
                      "type": "number",
                      "example": 0.018,
                      "default": 0
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
                    "value": "{ \"errors\": [{ \"type\": \"invalid_parameter_error\", \"parameter_name\": \"id\", \"message\": \"ID invÃ¡lido.\" }] }"
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
                            "example": "id"
                          },
                          "message": {
                            "type": "string",
                            "example": "ID invÃ¡lido."
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