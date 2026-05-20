# Obter incremento

AtravÃ©s dos identificadores da assinatura (`subscription_id`) e do incremento associado (`incremento_id`) Ã© possÃ­vel
recuperar as informações do incremento.

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
    "/subscriptions/{subscription_id}/increments/{increment_id}": {
      "get": {
        "summary": "Obter incremento",
        "description": "AtravÃ©s dos identificadores da assinatura (`subscription_id`) e do incremento associado (`incremento_id`) Ã© possÃ­vel recuperar as informações do incremento.",
        "operationId": "obter-incremento-1",
        "parameters": [
          {
            "name": "subscription_id",
            "in": "path",
            "description": "CÃ³digo da assinatura.<br>Formato `sub_XXXXXXXXXXXXXXXX`",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "increment_id",
            "in": "path",
            "description": "CÃ³digo do incremento. <br>Formato: `dis_XXXXXXXXXXXXXXXX`",
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
                    "value": "{\n  \"id\": \"inc_IYzpxgjsOs0fDIoP\",\n  \"value\": 10,\n  \"increment_type\": \"percentage\",\n  \"status\": \"active\",\n  \"created_at\": \"2017-04-04T18:36:43Z\",\n  \"subscription\": {\n    \"id\": \"sub_o0Jw4WYCMuPNqzGr\",\n    \"code\": \"09NFPLBZY0\",\n    \"start_at\": \"2017-04-04T00:00:00Z\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"billing_type\": \"postpaid\",\n    \"next_billing_at\": \"2017-05-04T00:00:00Z\",\n    \"payment_method\": \"credit_card\",\n    \"currency\": \"BRL\",\n    \"statement_descriptor\": \"Spotify\",\n    \"installments\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2017-04-04T18:21:17Z\",\n    \"updated_at\": \"2017-04-04T18:21:17Z\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "inc_IYzpxgjsOs0fDIoP"
                    },
                    "value": {
                      "type": "integer",
                      "example": 10,
                      "default": 0
                    },
                    "increment_type": {
                      "type": "string",
                      "example": "percentage"
                    },
                    "status": {
                      "type": "string",
                      "example": "active"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-04T18:36:43Z"
                    },
                    "subscription": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "sub_o0Jw4WYCMuPNqzGr"
                        },
                        "code": {
                          "type": "string",
                          "example": "09NFPLBZY0"
                        },
                        "start_at": {
                          "type": "string",
                          "example": "2017-04-04T00:00:00Z"
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
                        "next_billing_at": {
                          "type": "string",
                          "example": "2017-05-04T00:00:00Z"
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
                          "example": "2017-04-04T18:21:17Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-04T18:21:17Z"
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
                    "value": "{\n  \"message\": \"Increment not found.\"\n}"
                  }
                },
                "schema": {
                  "oneOf": [
                    {
                      "type": "object",
                      "properties": {
                        "message": {
                          "type": "string",
                          "example": "Subscription not found."
                        }
                      }
                    },
                    {
                      "type": "object",
                      "properties": {
                        "message": {
                          "type": "string",
                          "example": "Increment not found."
                        }
                      }
                    }
                  ]
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