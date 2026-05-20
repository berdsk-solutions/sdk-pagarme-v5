# Remover item

Com o verbo _HTTP DELETE_, atravÃ©s dos identificadores do item (`plan_item_id`) e do plano (`plan_id`) associado Ã©
possÃ­vel remover um item do plano.

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
    "/plans/{plan_id}/items/{item_id}": {
      "delete": {
        "summary": "Remover item",
        "description": "Com o verbo _HTTP DELETE_, atravÃ©s dos identificadores do item (`plan_item_id`) e do plano (`plan_id`) associado Ã© possÃ­vel remover um item do plano.",
        "operationId": "remover-item-1",
        "parameters": [
          {
            "name": "plan_id",
            "in": "path",
            "description": "CÃ³digo do plano.<br>Formato: `plan_XXXXXXXXXXXXXXXX`",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "item_id",
            "in": "path",
            "description": "CÃ³digo do item do plano. <br>Formato: `pi_XXXXXXXXXXXXXXXX`",
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
                    "value": "{\n  \"id\": \"pi_eBTaVnXD8Zhb8glr\",\n  \"name\": \"AvaliaÃ§Ã£o fÃ­sica\",\n  \"description\": \"AvaliaÃ§Ã£o + Exame mÃ©dico\",\n  \"cycles\": 1,\n  \"status\": \"deleted\",\n  \"created_at\": \"2016-07-12T18:25:40Z\",\n  \"updated_at\": \"2016-07-12T18:25:40Z\",\n  \"deleted_at\": \"2016-07-15T13:41:02Z\",\n  \"pricing_scheme\": {\n    \"price\": 9990,\n    \"scheme_type\": \"unit\"\n  },\n  \"plan\": {\n    \"id\": \"plan_21r4CTG0ux77Qv13\",\n    \"name\": \"Plano Gold\",\n    \"url\": \"/plan_21r4CTG0ux77Qv13/academia/plano-gold\",\n    \"currency\": \"BRL\",\n    \"interval\": \"month\",\n    \"interval_count\": 3,\n    \"billing_type\": \"prepaid\",\n    \"installments\": 3,\n    \"status\": \"active\",\n    \"created_at\": \"2016-07-12T17:25:40Z\",\n    \"updated_at\": \"2016-07-12T17:25:40Z\",\n    \"metadata\": {\n      \"id\": \"my_plan_id\"\n    }\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "pi_eBTaVnXD8Zhb8glr"
                    },
                    "name": {
                      "type": "string",
                      "example": "AvaliaÃ§Ã£o fÃ­sica"
                    },
                    "description": {
                      "type": "string",
                      "example": "AvaliaÃ§Ã£o + Exame mÃ©dico"
                    },
                    "cycles": {
                      "type": "integer",
                      "example": 1,
                      "default": 0
                    },
                    "status": {
                      "type": "string",
                      "example": "deleted"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2016-07-12T18:25:40Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2016-07-12T18:25:40Z"
                    },
                    "deleted_at": {
                      "type": "string",
                      "example": "2016-07-15T13:41:02Z"
                    },
                    "pricing_scheme": {
                      "type": "object",
                      "properties": {
                        "price": {
                          "type": "integer",
                          "example": 9990,
                          "default": 0
                        },
                        "scheme_type": {
                          "type": "string",
                          "example": "unit"
                        }
                      }
                    },
                    "plan": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "plan_21r4CTG0ux77Qv13"
                        },
                        "name": {
                          "type": "string",
                          "example": "Plano Gold"
                        },
                        "url": {
                          "type": "string",
                          "example": "/plan_21r4CTG0ux77Qv13/academia/plano-gold"
                        },
                        "currency": {
                          "type": "string",
                          "example": "BRL"
                        },
                        "interval": {
                          "type": "string",
                          "example": "month"
                        },
                        "interval_count": {
                          "type": "integer",
                          "example": 3,
                          "default": 0
                        },
                        "billing_type": {
                          "type": "string",
                          "example": "prepaid"
                        },
                        "installments": {
                          "type": "integer",
                          "example": 3,
                          "default": 0
                        },
                        "status": {
                          "type": "string",
                          "example": "active"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2016-07-12T17:25:40Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2016-07-12T17:25:40Z"
                        },
                        "metadata": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "my_plan_id"
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
                    "value": "{\n    \"message\": \"Item not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Item not found."
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