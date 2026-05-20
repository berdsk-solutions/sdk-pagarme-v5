# Editar item

Com o verbo _HTTP PUT_, atravÃ©s dos identificadores do item (`plan_item_id`) e do plano (`plan_id`) associado Ã© possÃ­vel
atualizar os dados do item do plano.

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
      "put": {
        "summary": "Editar item",
        "description": "Com o verbo _HTTP PUT_, atravÃ©s dos identificadores do item (`plan_item_id`) e do plano (`plan_id`) associado Ã© possÃ­vel atualizar os dados do item do plano.",
        "operationId": "editar-item-1",
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
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "required": [
                  "name",
                  "pricing_scheme",
                  "status"
                ],
                "properties": {
                  "name": {
                    "type": "string",
                    "description": "Nome do item. <br>Max.: 64 caracteres."
                  },
                  "description": {
                    "type": "string",
                    "description": "DescriÃ§Ã£o do item. <br>Max.: 256 caracteres."
                  },
                  "quantity": {
                    "type": "integer",
                    "description": "Quantidade de itens. <br>**ObrigatÃ³rio**, caso o pricing_scheme.type for igual a **unit**.",
                    "format": "int32"
                  },
                  "cycles": {
                    "type": "integer",
                    "description": "NÃºmero de ciclos durante o qual o item serÃ¡ cobrado. Ex: Um item com `cycles` = 1 representa que um item serÃ¡ cobrado apenas uma vez.<br>Caso nÃ£o seja informado, o item serÃ¡ cobrado atÃ© que seja desativado.",
                    "format": "int32"
                  },
                  "pricing_scheme": {
                    "type": "object",
                    "description": "Esquema de precificaÃ§Ã£o. <br>[Saiba mais sobre precificaÃ§Ã£o](https://docs.pagar.me/reference/precifica%C3%A7%C3%A3o).",
                    "required": [
                      "scheme_type"
                    ],
                    "properties": {
                      "scheme_type": {
                        "type": "string",
                        "description": "Esquema de precificaÃ§Ã£o do item. Valores possÃ­veis: **unit**, **package**, **volume** e **tier**. Valor default: unit",
                        "default": "Unit"
                      },
                      "price": {
                        "type": "integer",
                        "description": "Valor do item. Este atributo estÃ¡ disponÃ­vel para o scheme_type : **Unit**",
                        "format": "int32"
                      },
                      "mininum_price": {
                        "type": "integer",
                        "description": "Valor mÃ­nimo a ser cobrado.",
                        "format": "int32"
                      },
                      "price_brackets": {
                        "type": "array",
                        "description": "Intervalo de preÃ§os. Este atributo estÃ¡ disponÃ­vel para os scheme_type : **package**, **volume** e **tier**.",
                        "items": {
                          "properties": {
                            "start_quantity": {
                              "type": "integer",
                              "description": "Valor que define a quantidade inicial de unidades do intervalo.",
                              "format": "int32"
                            },
                            "end_quantity": {
                              "type": "integer",
                              "description": "Valor que define a quantidade final de unidades do intervalo.",
                              "format": "int32"
                            },
                            "overage_price": {
                              "type": "integer",
                              "description": "Valor para cÃ¡lculo do preÃ§o por unidade que exceder o intervalo.",
                              "format": "int32"
                            },
                            "price": {
                              "type": "integer",
                              "description": "Valor para cÃ¡lculo do preÃ§o dentro do intervalo. OBS: o preÃ§o a ser cobrado do cliente serÃ¡ calculado de acordo com a quantidade e o scheme_type",
                              "format": "int32"
                            }
                          },
                          "type": "object"
                        }
                      }
                    }
                  },
                  "status": {
                    "type": "string",
                    "description": "Valores possÃ­veis: **active** ou **inactive**"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "name": "AvaliaÃ§Ã£o fÃ­sica",
                    "description": "AvaliaÃ§Ã£o + Exame mÃ©dico",
                    "quantity": 1,
                    "cycles": 1,
                    "pricing_scheme": {
                      "price": 9990,
                      "scheme_type": "unit"
                    }
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
                    "value": "{\n  \"id\": \"pi_eBTaVnXD8Zhb8glr\",\n  \"name\": \"AvaliaÃ§Ã£o fÃ­sica\",\n  \"description\": \"AvaliaÃ§Ã£o + Exame mÃ©dico\",\n  \"cycles\": 1,\n  \"status\": \"active\",\n  \"created_at\": \"2016-07-12T18:25:40Z\",\n  \"updated_at\": \"2016-07-12T18:25:40Z\",\n  \"pricing_scheme\": {\n    \"price\": 9990,\n    \"scheme_type\": \"unit\"\n  },\n  \"plan\": {\n    \"id\": \"plan_21r4CTG0ux77Qv13\",\n    \"name\": \"Plano Gold\",\n    \"url\": \"/plan_21r4CTG0ux77Qv13/academia/plano-gold\",\n    \"currency\": \"BRL\",\n    \"interval\": \"month\",\n    \"interval_count\": 3,\n    \"billing_type\": \"prepaid\",\n    \"installments\": 3,\n    \"status\": \"active\",\n    \"created_at\": \"2016-07-12T17:25:40Z\",\n    \"updated_at\": \"2016-07-12T17:25:40Z\",\n    \"metadata\": {\n      \"id\": \"my_plan_id\"\n    }\n  }\n}"
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