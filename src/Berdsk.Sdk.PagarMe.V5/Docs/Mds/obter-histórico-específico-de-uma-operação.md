# Obter histÃ³rico especÃ­fico de uma operaÃ§Ã£o

Retorna uma operaÃ§Ã£o especÃ­fica ocorrida no saldo da sua conta.

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
    "/balance/operations/{balance_operation_id}": {
      "get": {
        "summary": "Obter histÃ³rico especÃ­fico de uma operaÃ§Ã£o",
        "description": "Retorna uma operaÃ§Ã£o especÃ­fica ocorrida no saldo da sua conta.",
        "operationId": "obter-histÃ³rico-especÃ­fico-de-uma-operaÃ§Ã£o",
        "parameters": [
          {
            "name": "balance_operation_id",
            "in": "path",
            "description": "ID da operaÃ§Ã£o desejada",
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
                    "value": "{\n    \"id\": 2155314409,\n    \"status\": \"available\",\n    \"balance_amount\": 0,\n    \"type\": \"payable\",\n    \"amount\": -8990,\n    \"fee\": 0,\n    \"created_at\": \"2023-06-27T20:59:20Z\",\n    \"movement_object\": {\n        \"fee\": 0,\n        \"anticipation_fee\": 0,\n        \"fraud_coverage_fee\": 0,\n        \"recipient_id\": \"re_cjlnpqrq0006vn56e1nig0tcv\",\n        \"originator_model\": \"refund\",\n        \"originator_model_id\": \"rf_cljertfyx1z1301m52an4poij\",\n        \"payment_date \": \"2023-06-27T03:00:00Z\",\n        \"payment_method\": \"pix\",\n        \"object\": \"payable\",\n        \"id\": \"4304143066\",\n        \"status\": \"paid\",\n        \"amount\": -8990,\n        \"created_at\": \"2023-06-27T20:59:20Z\",\n        \"type\": \"refund\",\n        \"gateway_id\": \"23795495\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "integer",
                      "example": 2155314409,
                      "default": 0
                    },
                    "status": {
                      "type": "string",
                      "example": "available"
                    },
                    "balance_amount": {
                      "type": "integer",
                      "example": 0,
                      "default": 0
                    },
                    "type": {
                      "type": "string",
                      "example": "payable"
                    },
                    "amount": {
                      "type": "integer",
                      "example": -8990,
                      "default": 0
                    },
                    "fee": {
                      "type": "integer",
                      "example": 0,
                      "default": 0
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2023-06-27T20:59:20Z"
                    },
                    "movement_object": {
                      "type": "object",
                      "properties": {
                        "fee": {
                          "type": "integer",
                          "example": 0,
                          "default": 0
                        },
                        "anticipation_fee": {
                          "type": "integer",
                          "example": 0,
                          "default": 0
                        },
                        "fraud_coverage_fee": {
                          "type": "integer",
                          "example": 0,
                          "default": 0
                        },
                        "recipient_id": {
                          "type": "string",
                          "example": "re_cjlnpqrq0006vn56e1nig0tcv"
                        },
                        "originator_model": {
                          "type": "string",
                          "example": "refund"
                        },
                        "originator_model_id": {
                          "type": "string",
                          "example": "rf_cljertfyx1z1301m52an4poij"
                        },
                        "payment_date ": {
                          "type": "string",
                          "example": "2023-06-27T03:00:00Z"
                        },
                        "payment_method": {
                          "type": "string",
                          "example": "pix"
                        },
                        "object": {
                          "type": "string",
                          "example": "payable"
                        },
                        "id": {
                          "type": "string",
                          "example": "4304143066"
                        },
                        "status": {
                          "type": "string",
                          "example": "paid"
                        },
                        "amount": {
                          "type": "integer",
                          "example": -8990,
                          "default": 0
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2023-06-27T20:59:20Z"
                        },
                        "type": {
                          "type": "string",
                          "example": "refund"
                        },
                        "gateway_id": {
                          "type": "string",
                          "example": "23795495"
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
                    "value": "{}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {}
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