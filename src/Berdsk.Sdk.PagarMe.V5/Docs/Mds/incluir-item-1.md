# Incluir item

AtravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel incluir itens na assinatura do cliente.

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
      "post": {
        "summary": "Incluir item",
        "description": "AtravÃ©s do identificador da assinatura (`subscription_id`) Ã© possÃ­vel incluir itens na assinatura do cliente.",
        "operationId": "incluir-item-1",
        "parameters": [
          {
            "name": "subscription_id",
            "in": "path",
            "description": "CÃ³digo da assinatura.<br>Formato: `sub_XXXXXXXXXXXXXXXX`.",
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
                  "description",
                  "pricing_scheme",
                  "quantity"
                ],
                "properties": {
                  "plan_item_id": {
                    "type": "string",
                    "description": "CÃ³digo do item do plano.<br>Max: 36 caracteres."
                  },
                  "description": {
                    "type": "string",
                    "description": "DescriÃ§Ã£o do item.<br>Max: 256 caracteres.<br>**ObrigatÃ³rio** caso o  `plan_item_id` nÃ£o seja informado."
                  },
                  "cycles": {
                    "type": "integer",
                    "description": "Indica quantas vezes o item serÃ¡ cobrado. <br>Caso nÃ£o seja informado, o item serÃ¡ cobrado atÃ© que seja excluÃ­do o desativado.",
                    "format": "int32"
                  },
                  "pricing_scheme": {
                    "type": "object",
                    "description": "Esquema de precificaÃ§Ã£o.<br>[Saiba mais sobre precificaÃ§Ã£o](https://docs.pagar.me/reference/precifica%C3%A7%C3%A3o).",
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
                  "discounts": {
                    "type": "array",
                    "description": "Descontos do item.<br>[Saiba mais sobre desconto](https://docs.pagar.me/reference/desconto-1)",
                    "items": {
                      "properties": {
                        "cycles": {
                          "type": "string",
                          "description": "NÃºmero de vezes que o desconto serÃ¡ aplicado."
                        },
                        "value": {
                          "type": "string",
                          "description": "Valor do desconto."
                        },
                        "discount_type": {
                          "type": "string",
                          "description": "Tipo do desconto. Valores possÃ­veis: flat ou percentage. Valor padrÃ£o: percentage."
                        }
                      },
                      "type": "object"
                    }
                  },
                  "quantity": {
                    "type": "integer",
                    "description": "Quantidade de itens.<br>**ObrigatÃ³rio** caso **pricing_scheme.scheme_type** seja **unit**",
                    "format": "int32"
                  },
                  "name": {
                    "type": "string",
                    "description": "Nome do item da assinatura."
                  },
                  "increments": {
                    "type": "array",
                    "description": "Incrementos do item.<br>[Saiba mais sobre desconto](https://docs.pagar.me/reference/incremento-1)",
                    "items": {
                      "properties": {
                        "value": {
                          "type": "integer",
                          "description": "Valor do incremento.",
                          "format": "int32"
                        },
                        "cycles": {
                          "type": "string",
                          "description": "NÃºmero de vezes que o incremento serÃ¡ aplicado."
                        },
                        "increment_type": {
                          "type": "string",
                          "description": "Tipo do incremento. Valores possÃ­veis: flat ou percentage. Valor padrÃ£o: percentage."
                        }
                      },
                      "type": "object"
                    }
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "description": "Celular",
                    "cycles": 1,
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
                    "value": "{\n    \"id\": \"si_WQEmvEEfGigkL0Zx\",\n    \"description\": \"Celular\",\n    \"cycles\": 1,\n    \"quantity\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2017-07-28T21:00:26Z\",\n    \"updated_at\": \"2017-07-28T21:00:26Z\",\n    \"pricing_scheme\": {\n        \"price\": 99,\n        \"scheme_type\": \"unit\"\n    },\n    \"subscription\": {\n        \"id\": \"sub_z4ogwpZfdKCnGj9m\",\n        \"code\": \"3670A7IQWL\",\n        \"start_at\": \"2017-07-28T00:00:00Z\",\n        \"interval\": \"month\",\n        \"interval_count\": 3,\n        \"billing_type\": \"prepaid\",\n        \"next_billing_at\": \"2017-10-28T00:00:00Z\",\n        \"payment_method\": \"credit_card\",\n        \"currency\": \"BRL\",\n        \"installments\": 3,\n        \"status\": \"active\",\n        \"created_at\": \"2017-07-28T20:59:18Z\",\n        \"updated_at\": \"2017-07-28T20:59:18Z\",\n        \"metadata\": {\n            \"id\": \"my_subscription_id\"\n        }\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "si_WQEmvEEfGigkL0Zx"
                    },
                    "description": {
                      "type": "string",
                      "example": "Celular"
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
                      "example": "2017-07-28T21:00:26Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-07-28T21:00:26Z"
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
                          "example": "sub_z4ogwpZfdKCnGj9m"
                        },
                        "code": {
                          "type": "string",
                          "example": "3670A7IQWL"
                        },
                        "start_at": {
                          "type": "string",
                          "example": "2017-07-28T00:00:00Z"
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
                        "next_billing_at": {
                          "type": "string",
                          "example": "2017-10-28T00:00:00Z"
                        },
                        "payment_method": {
                          "type": "string",
                          "example": "credit_card"
                        },
                        "currency": {
                          "type": "string",
                          "example": "BRL"
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
                          "example": "2017-07-28T20:59:18Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-07-28T20:59:18Z"
                        },
                        "metadata": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "my_subscription_id"
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