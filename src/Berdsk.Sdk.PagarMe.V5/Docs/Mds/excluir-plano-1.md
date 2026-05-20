# Excluir plano

Com o verbo HTTP DELETE, atravÃ©s do identificador do plano (`plan_id`) Ã© possÃ­vel excluir um plano.

> ðŸ“˜ Planos com assinaturas em curso
>
> A exclusÃ£o de um plano **nÃ£o afeta** assinaturas correntes de clientes que porventura sejam oriundas do plano
> excluÃ­do, apenas **impede a criaÃ§Ã£o de novas assinaturas** do plano excluÃ­do.

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
    "/plans/{plan_id}": {
      "delete": {
        "summary": "Excluir plano",
        "description": "Com o verbo HTTP DELETE, atravÃ©s do identificador do plano (`plan_id`) Ã© possÃ­vel excluir um plano.",
        "operationId": "excluir-plano-1",
        "parameters": [
          {
            "name": "plan_id",
            "in": "path",
            "description": "CÃ³digo do plano",
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
                    "value": "{\n  \"id\": \"plan_21r4CTG0ux77Qv13\",\n  \"name\": \"Plano Gold\",\n  \"description\": \"Esse plano oferece acesso aos programas de musculaÃ§Ã£o e todos os equipamentos e atividades coletivas terrestres.\",\n  \"url\": \"/plan_21r4CTG0ux77Qv13/academia/plano-silver\",\n  \"minimum_price\": 10000,\n  \"currency\": \"BRL\",\n  \"interval\": \"month\",\n  \"interval_count\": 3,\n  \"billing_type\": \"prepaid\",\n  \"installments\": 3,\n  \"statement_descriptor\": \"SILVER\",\n  \"status\": \"deleted\",\n  \"created_at\": \"2016-07-12T18:25:40Z\",\n  \"updated_at\": \"2016-07-12T18:25:40Z\",\n  \"deleted_at\": \"2016-07-15T13:41:02Z\",\n  \"items\": [\n    {\n      \"id\": \"pi_3j1EG9ousipHjcUL\",\n      \"name\": \"MusculaÃ§Ã£o\",\n      \"status\": \"active\",\n      \"created_at\": \"2016-07-12T18:25:40Z\",\n      \"updated_at\": \"2016-07-12T18:25:40Z\",\n      \"pricing_scheme\": {\n        \"price\": 18990,\n      \t\"scheme_type\": \"unit\"\n      }\n    },\n    {\n      \"id\": \"pi_6ggvuaJNS2LVq1i6\",\n      \"name\": \"MatrÃ­cula\",\n      \"cycles\": 1,\n      \"status\": \"active\",\n      \"created_at\": \"2016-07-12T18:25:40Z\",\n      \"updated_at\": \"2016-07-12T18:25:40Z\",\n      \"pricing_scheme\": {\n        \"price\": 5990,\n        \"scheme_type\": \"unit\"\n      }\n    }\n  ],\n  \"metadata\": {\n    \"id\": \"my_plan_id\"\n  }\n}"
                  }
                },
                "schema": {
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
                    "description": {
                      "type": "string",
                      "example": "Esse plano oferece acesso aos programas de musculaÃ§Ã£o e todos os equipamentos e atividades coletivas terrestres."
                    },
                    "url": {
                      "type": "string",
                      "example": "/plan_21r4CTG0ux77Qv13/academia/plano-silver"
                    },
                    "minimum_price": {
                      "type": "integer",
                      "example": 10000,
                      "default": 0
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
                    "statement_descriptor": {
                      "type": "string",
                      "example": "SILVER"
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
                    "items": {
                      "type": "array",
                      "items": {
                        "type": "object",
                        "properties": {
                          "id": {
                            "type": "string",
                            "example": "pi_3j1EG9ousipHjcUL"
                          },
                          "name": {
                            "type": "string",
                            "example": "MusculaÃ§Ã£o"
                          },
                          "status": {
                            "type": "string",
                            "example": "active"
                          },
                          "created_at": {
                            "type": "string",
                            "example": "2016-07-12T18:25:40Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2016-07-12T18:25:40Z"
                          },
                          "pricing_scheme": {
                            "type": "object",
                            "properties": {
                              "price": {
                                "type": "integer",
                                "example": 18990,
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