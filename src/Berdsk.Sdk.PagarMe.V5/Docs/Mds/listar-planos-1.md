# Listar planos

Este recurso permite listar seus planos. Pode ser utilizados alguns parÃ¢metros como filtro da listagem.

> ðŸ“˜ PaginaÃ§Ã£o
>
> Este recurso utiliza **paginaÃ§Ã£o** para manipulaÃ§Ã£o da listagem
> resultante. [Saiba mais sobre paginaÃ§Ã£o](https://docs.pagar.me/v5/reference#paginaÃ§Ã£o-1).

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
    "/plans": {
      "get": {
        "summary": "Listar planos",
        "description": "Este recurso permite listar seus planos. Pode ser utilizados alguns parÃ¢metros como filtro da listagem.",
        "operationId": "listar-planos-1",
        "parameters": [
          {
            "name": "name",
            "in": "query",
            "description": "Nome do plano.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "status",
            "in": "query",
            "description": "Status do plano.<br>Valores possÃ­veis: **active**, **inactive** ou **deleted**",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "created_since",
            "in": "query",
            "description": "Data de inÃ­cio do perÃ­odo de criaÃ§Ã£o a ser listado.",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "created_until",
            "in": "query",
            "description": "Data final do perÃ­odo de criaÃ§Ã£o a ser listado.",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "page",
            "in": "query",
            "description": "PÃ¡gina atual.",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          },
          {
            "name": "size",
            "in": "query",
            "description": "Quantidade de itens por pÃ¡gina.",
            "schema": {
              "type": "integer",
              "format": "int32"
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
                    "value": "{\n  \"data\": [\n    {\n      \"id\": \"plan_21r4CTG0ux77Qv13\",\n      \"name\": \"Plano Gold\",\n      \"url\": \"/plan_21r4CTG0ux77Qv13/academia/plano-gold\",\n      \"minimum_price\": 10000,\n      \"currency\": \"BRL\",\n      \"interval\": \"month\",\n      \"interval_count\": 3,\n      \"billing_type\": \"prepaid\",\n      \"installments\": 3,\n      \"status\": \"active\",\n      \"created_at\": \"2016-07-12T18:25:40Z\",\n      \"updated_at\": \"2016-07-12T18:25:40Z\",\n      \"items\": [\n        {\n          \"id\": \"pi_3j1EG9ousipHjcUL\",\n          \"name\": \"MusculaÃ§Ã£o\",\n          \"status\": \"active\",\n          \"created_at\": \"2016-07-12T18:25:40Z\",\n          \"updated_at\": \"2016-07-12T18:25:40Z\",\n          \"pricing_scheme\": {\n            \"price\": 18990,\n            \"scheme_type\": \"unit\"\n          }\n        },\n        {\n          \"id\": \"pi_6ggvuaJNS2LVq1i6\",\n          \"name\": \"MatrÃ­cula\",\n          \"cycles\": 1,\n          \"status\": \"active\",\n          \"created_at\": \"2016-07-12T18:25:40Z\",\n          \"updated_at\": \"2016-07-12T18:25:40Z\",\n          \"pricing_scheme\": {\n            \"price\": 5990,\n            \"scheme_type\": \"unit\"\n          }\n        }\n      ],\n      \"metadata\": {\n        \"id\": \"my_plan_id\"\n      }\n    }\n  ],\n  \"paging\": {\n    \"total_items\": 1,\n    \"current_page\": 1,\n    \"total_pages\": 1\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "data": {
                      "type": "array",
                      "items": {
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
                    },
                    "paging": {
                      "type": "object",
                      "properties": {
                        "total_items": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
                        },
                        "current_page": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
                        },
                        "total_pages": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
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