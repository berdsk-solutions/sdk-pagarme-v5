# Editar item

Com o verbo _HTTP PUT_, atravÃ©s dos identificadores do item (`subscription_item_id`) e da assinatura (`subscription_id`)
associada Ã© possÃ­vel atualizar os dados do item da assinatura.

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
      "put": {
        "summary": "Editar item",
        "description": "Com o verbo _HTTP PUT_, atravÃ©s dos identificadores do item (`subscription_item_id`) e da assinatura (`subscription_id`) associada Ã© possÃ­vel atualizar os dados do item da assinatura.",
        "operationId": "editar-item",
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
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "required": [
                  "quantity"
                ],
                "properties": {
                  "name": {
                    "type": "string",
                    "description": "Nome do item da assinatura."
                  },
                  "description": {
                    "type": "string",
                    "description": "DescriÃ§Ã£o do item.<br>Max: 256 caracteres.<br>**ObrigatÃ³rio** caso o  `plan_item_id` nÃ£o seja informado."
                  },
                  "cycle": {
                    "type": "integer",
                    "description": "Indica quantas vezes o item serÃ¡ cobrado. <br>Caso nÃ£o seja informado, o item serÃ¡ cobrado atÃ© que seja excluÃ­do o desativado.",
                    "format": "int32"
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
                  },
                  "quantity": {
                    "type": "integer",
                    "description": "Quantidade de itens.<br>**ObrigatÃ³rio** caso  **pricing_scheme.scheme_type** seja **unit**.",
                    "format": "int32"
                  },
                  "pricing_scheme": {
                    "type": "object",
                    "description": "Esquema de precificaÃ§Ã£o.<br>[Saiba mais sobre precificaÃ§Ã£o](https://docs.pagar.me/reference/precifica%C3%A7%C3%A3o)",
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
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "name": "Nome - teste",
                    "description": "Telefone",
                    "cycles": 3,
                    "quantity": 1,
                    "pricing_scheme": {
                      "price": 99
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
                    "value": "{\n  \"id\": \"si_mARl1OvTYcA3pG49\",\n  \"description\": \"Telefone\",\n  \"cycles\": 3,\n  \"quantity\": 1,\n  \"status\": \"active\",\n  \"created_at\": \"2017-04-04T18:56:44Z\",\n  \"updated_at\": \"2017-04-04T18:57:48Z\",\n  \"pricing_scheme\": {\n    \"price\": 99,\n    \"scheme_type\": \"unit\"\n  },\n  \"subscription\": {\n    \"id\": \"sub_o0Jw4WYCMuPNqzGr\",\n    \"code\": \"09NFPLBZY0\",\n    \"start_at\": \"2017-04-04T00:00:00Z\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"billing_type\": \"postpaid\",\n    \"next_billing_at\": \"2017-05-04T00:00:00Z\",\n    \"payment_method\": \"credit_card\",\n    \"currency\": \"BRL\",\n    \"statement_descriptor\": \"Spotify\",\n    \"installments\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2017-04-04T18:21:17\",\n    \"updated_at\": \"2017-04-04T18:21:17\"\n  }\n}"
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
                    "status": {
                      "type": "string",
                      "example": "active"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-04T18:56:44Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-04-04T18:57:48Z"
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
                          "example": "2017-04-04T18:21:17"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-04T18:21:17"
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