# Remover item

Com o verbo _HTTP DELETE_, atravÃ©s dos identificadores do item (`subscription_item_id`) e da assinatura (
`subscription_id`) associada Ã© possÃ­vel remover um item da assinatura.

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
    "/subscriptions/{subscription_id}/items/{item_id}": {
      "delete": {
        "summary": "Remover item",
        "description": "Com o verbo _HTTP DELETE_, atravÃ©s dos identificadores do item (`subscription_item_id`) e da assinatura (`subscription_id`) associada Ã© possÃ­vel remover um item da assinatura.",
        "operationId": "remover-item",
        "parameters": [
          {
            "name": "subscription_id",
            "in": "path",
            "description": "CÃ³digo da assinatura.<br>Formato: `sub_XXXXXXXXXXXXXXXX`.",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "item_id",
            "in": "path",
            "description": "CÃ³digo do item da assinatura.<br>Formato: `si_XXXXXXXXXXXXXXXX`.",
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
                    "value": "{\n  \"id\": \"si_mARl1OvTYcA3pG49\",\n  \"description\": \"Telefone\",\n  \"cycles\": 3,\n  \"quantity\": 1,\n  \"name\":\"Nome - teste\",\n  \"status\": \"deleted\",\n  \"created_at\": \"2017-04-04T18:56:44Z\",\n  \"updated_at\": \"2017-04-04T18:57:48Z\",\n  \"deleted_at\": \"2017-04-04T19:00:44Z\",\n  \"pricing_scheme\": {\n    \"price\": 99,\n    \"scheme_type\": \"unit\"\n  },\n  \"subscription\": {\n    \"id\": \"sub_o0Jw4WYCMuPNqzGr\",\n    \"code\": \"09NFPLBZY0\",\n    \"start_at\": \"2017-04-04T00:00:00Z\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"billing_type\": \"postpaid\",\n    \"next_billing_at\": \"2017-05-04T00:00:00Z\",\n    \"payment_method\": \"credit_card\",\n    \"currency\": \"BRL\",\n    \"statement_descriptor\": \"Spotify\",\n    \"installments\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2017-04-04T18:21:17Z\",\n    \"updated_at\": \"2017-04-04T18:21:17Z\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "si_mARl1OvTYcA3pG49"
                    },
                    "description": {
                      "type": "string",
                      "example": "Telefone"
                    },
                    "cycles": {
                      "type": "integer",
                      "example": 3,
                      "default": 0
                    },
                    "quantity": {
                      "type": "integer",
                      "example": 1,
                      "default": 0
                    },
                    "name": {
                      "type": "string",
                      "example": "Nome - teste"
                    },
                    "status": {
                      "type": "string",
                      "example": "deleted"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-04T18:56:44Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-04-04T18:57:48Z"
                    },
                    "deleted_at": {
                      "type": "string",
                      "example": "2017-04-04T19:00:44Z"
                    },
                    "pricing_scheme": {
                      "type": "object",
                      "properties": {
                        "price": {
                          "type": "integer",
                          "example": 99,
                          "default": 0
                        },
                        "scheme_type": {
                          "type": "string",
                          "example": "unit"
                        }
                      }
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