# Listar itens de uma assinatura

Este recurso permite listar as assinaturas. Pode ser utilizados alguns parÃ¢metros como filtro da listagem.

> ðŸ“˜ PaginaÃ§Ã£o
>
> Este recurso utiliza **paginaÃ§Ã£o** para manipulaÃ§Ã£o da listagem
> resultante. [Saiba mais sobre paginaÃ§Ã£o](https://docs.pagar.me/reference/pagina%C3%A7%C3%A3o-1).

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
    "/subscriptions/{subscription_id}/items": {
      "get": {
        "summary": "Listar itens de uma assinatura",
        "description": "Este recurso permite listar as assinaturas. Pode ser utilizados alguns parÃ¢metros como filtro da listagem.",
        "operationId": "listar-Ã­tens-de-uma-assinatura",
        "parameters": [
          {
            "name": "subscription_id",
            "in": "path",
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
                "properties": {
                  "status": {
                    "type": "string",
                    "description": "Status da assinatura.<br>Valores possÃ­veis: **active**, **deleted*"
                  },
                  "name": {
                    "type": "string",
                    "description": "Nome do item da assinatura."
                  },
                  "description": {
                    "type": "string",
                    "description": "DescriÃ§Ã£o do item."
                  },
                  "cycle": {
                    "type": "integer",
                    "description": "Indica quantas vezes o item serÃ¡ cobrado. <br>Caso nÃ£o seja informado, o item serÃ¡ cobrado atÃ© que seja excluÃ­do o desativado.",
                    "format": "int32"
                  },
                  "created_since": {
                    "type": "string",
                    "description": "Data de inÃ­cio do item  de criaÃ§Ã£o a ser listado.",
                    "format": "date"
                  },
                  "created_until": {
                    "type": "string",
                    "description": "Data final do item de criaÃ§Ã£o a ser listado.",
                    "format": "date-time"
                  },
                  "page": {
                    "type": "integer",
                    "description": "PÃ¡gina atual",
                    "default": 1,
                    "format": "int32"
                  },
                  "size": {
                    "type": "integer",
                    "description": "Quantidade de itens por pÃ¡gina.",
                    "default": 10,
                    "format": "int32"
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
                    "value": "{\n    \"data\": [\n        {\n            \"id\": \"si_ZqbrJQ6udHLolQ5W\",\n            \"description\": \"iPhone APP\",\n            \"cycles\": 1,\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2018-05-25T19:23:13Z\",\n            \"updated_at\": \"2018-05-25T19:23:13Z\",\n            \"pricing_scheme\": {\n                \"price\": 99,\n                \"scheme_type\": \"unit\"\n            }\n        },\n        {\n            \"id\": \"si_aXJ02LRtgH6Rq5Z3\",\n            \"name\": \"Silver\",\n            \"description\": \"Com anuncios\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2018-05-25T19:23:06Z\",\n            \"updated_at\": \"2018-05-25T19:23:06Z\",\n            \"pricing_scheme\": {\n                \"price\": 2000,\n                \"scheme_type\": \"unit\"\n            },\n            \"increments\": [\n                {\n                    \"id\": \"inc_vl89g83tGWI084xJ\",\n                    \"value\": 20,\n                    \"increment_type\": \"percentage\",\n                    \"status\": \"active\",\n                    \"created_at\": \"2018-05-25T19:23:06Z\"\n                }\n            ]\n        },\n        {\n            \"id\": \"si_3n7EdJAi4xflMqAm\",\n            \"name\": \"Premium\",\n            \"description\": \"Sem anuncios\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2018-05-25T19:23:06Z\",\n            \"updated_at\": \"2018-05-25T19:23:06Z\",\n            \"pricing_scheme\": {\n                \"price\": 1490,\n                \"scheme_type\": \"unit\"\n            },\n            \"discounts\": [\n                {\n                    \"id\": \"dis_pVokdVbCGFWx0lxd\",\n                    \"value\": 10,\n                    \"discount_type\": \"percentage\",\n                    \"description\": \"Desconto 10% Item Sem Anuncios\",\n                    \"status\": \"active\",\n                    \"created_at\": \"2018-05-25T19:23:06Z\"\n                }\n            ],\n            \"increments\": [\n                {\n                    \"id\": \"inc_vxkVopbf8irZ85B7\",\n                    \"value\": 20,\n                    \"increment_type\": \"percentage\",\n                    \"description\": \"Incremento 20% Item Sem Anuncios\",\n                    \"status\": \"active\",\n                    \"created_at\": \"2018-05-25T19:23:06Z\"\n                }\n            ]\n        }\n    ],\n    \"paging\": {\n        \"total\": 3\n    }\n}"
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
                            "example": "si_ZqbrJQ6udHLolQ5W"
                          },
                          "description": {
                            "type": "string",
                            "example": "iPhone APP"
                          },
                          "cycles": {
                            "type": "integer",
                            "example": 1,
                            "default": 0
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
                            "example": "2018-05-25T19:23:13Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2018-05-25T19:23:13Z"
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
                          }
                        }
                      }
                    },
                    "paging": {
                      "type": "object",
                      "properties": {
                        "total": {
                          "type": "integer",
                          "example": 3,
                          "default": 0
                        }
                      }
                    }
                  }
                }
              }
            }
          },
          "422": {
            "description": "422",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n  \"message\": \"The request is invalid.\",\n  \"errors\": {\n    \"item.cycles\": [\n      \"The field cycles must be greater than or equal to 1\"\n    ]\n  },\n  \"request\": {\n    \"description\": \"Celular\",\n    \"cycles\": 0,\n    \"quantity\": 1,\n    \"pricing_scheme\": {\n      \"price\": 99,\n      \"scheme_type\": \"unit\"\n    }\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "The request is invalid."
                    },
                    "errors": {
                      "type": "object",
                      "properties": {
                        "item.cycles": {
                          "type": "array",
                          "items": {
                            "type": "string",
                            "example": "The field cycles must be greater than or equal to 1"
                          }
                        }
                      }
                    },
                    "request": {
                      "type": "object",
                      "properties": {
                        "description": {
                          "type": "string",
                          "example": "Celular"
                        },
                        "cycles": {
                          "type": "integer",
                          "example": 0,
                          "default": 0
                        },
                        "quantity": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
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