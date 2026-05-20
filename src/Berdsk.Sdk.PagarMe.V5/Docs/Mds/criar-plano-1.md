# Criar plano

Este recurso possibilita a criaÃ§Ã£o de um `plan` que poderÃ¡ ser utilizado futuramente para a criaÃ§Ã£o de uma assinatura.
Para mais detalhes consulte a [pagina principal do objeto](https://docs.pagar.me/reference/planos-1).

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
      "post": {
        "summary": "Criar plano",
        "description": "Este recurso possibilita a criaÃ§Ã£o de um `plan` que poderÃ¡ ser utilizado futuramente para a criaÃ§Ã£o de uma assinatura. Para mais detalhes consulte a [pagina principal do objeto](https://docs.pagar.me/reference/planos-1).",
        "operationId": "criar-plano-1",
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "required": [
                  "name"
                ],
                "properties": {
                  "name": {
                    "type": "string",
                    "description": "Nome do plano. Max: 64 caracteres."
                  },
                  "description": {
                    "type": "string",
                    "description": "DescriÃ§Ã£o do plano."
                  },
                  "shippable": {
                    "type": "boolean",
                    "description": "Indica se o plano oferece entrega."
                  },
                  "payment_methods": {
                    "type": "array",
                    "description": "Meios de pagamento disponÃ­veis para assinaturas criadas a partir do plano. <br>Valores possÃ­veis: **credit_card**, **boleto** ou **debit_card**. Caso nenhum seja informado, o Ãºnico meio de pagamento disponÃ­vel por padrÃ£o serÃ¡ **credit_card**",
                    "items": {
                      "type": "string"
                    }
                  },
                  "installments": {
                    "type": "array",
                    "description": "Opções de parcelamento disponÃ­veis para assinaturas criadas a partir do plano.<br>Caso nÃ£o seja informado, o plano irÃ¡ disponibilizar apenas assinaturas com pagamentos Ã  vista. O nÃºmero de parcelas deverÃ¡ ser 1 em recorrÃªncias.",
                    "items": {
                      "type": "integer",
                      "format": "int32"
                    }
                  },
                  "minimum_price": {
                    "type": "integer",
                    "description": "Valor mÃ­nimo em centavos da fatura.",
                    "format": "int32"
                  },
                  "statement_descriptor": {
                    "type": "string",
                    "description": "Texto exibido na fatura do cartÃ£o. <br>SerÃ¡ aplicado para assinaturas de cartÃ£o de crÃ©dito criadas a partir do plano. Max: 13 caracteres."
                  },
                  "currency": {
                    "type": "string",
                    "description": "Moeda. Valores possÃ­veis: **BRL**."
                  },
                  "interval": {
                    "type": "string",
                    "description": "FrequÃªncia da recorrÃªncia. Valores possÃ­veis: **day**,**week**, **month** ou **year**.",
                    "default": "month"
                  },
                  "interval_count": {
                    "type": "integer",
                    "description": "NÃºmero de intervalos de acordo com a propriedade **interval** entre cada cobranÃ§a da assinatura. <br>Ex.: plano mensal = **interval_count** (1) e **interval** (month) <br> plano trimestral = **interval_count** (3) e **interval** (month) <br> plano semestral = **interval_count** (6) e** interval** (month)",
                    "default": 1,
                    "format": "int32"
                  },
                  "trial_period_days": {
                    "type": "integer",
                    "description": "Dias de teste. A assinatura serÃ¡ iniciada apÃ³s o tÃ©rmino deste perÃ­odo.",
                    "format": "int32"
                  },
                  "billing_type": {
                    "type": "string",
                    "description": "Tipo de cobranÃ§a. Valores possÃ­veis: **prepaid**, **postpaid **ou **exact_day**."
                  },
                  "billing_days": {
                    "type": "array",
                    "description": "Dias disponÃ­veis para cobranÃ§a das assinaturas criadas a partir do plano. Deve ser maior ou igual a 1 e menor ou igual a 28. **ObrigatÃ³rio**, caso o **billing_type** seja igual a **exact_day**.",
                    "items": {
                      "type": "integer",
                      "format": "int32"
                    }
                  },
                  "items": {
                    "type": "array",
                    "description": "Itens do plano. [Saiba mais sobre um itens do plano](https://docs.pagar.me/reference/item-do-plano-1)",
                    "items": {
                      "properties": {
                        "description": {
                          "type": "string",
                          "description": "DescriÃ§Ã£o de itens."
                        },
                        "quantity": {
                          "type": "string",
                          "description": "Quantidade de itens."
                        },
                        "pricing_scheme": {
                          "type": "object",
                          "description": "Esquema de precificaÃ§Ã£o do item.",
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
                        "cycles": {
                          "type": "string",
                          "description": "Indica quantas vezes o item serÃ¡ cobrado."
                        }
                      },
                      "type": "object"
                    }
                  },
                  "metadata": {
                    "type": "string",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre o plano.<br>[Saiba mais sobre metadata](https://docs.pagar.me/reference/metadata-1)"
                  },
                  "pricing_scheme": {
                    "type": "object",
                    "description": "Esquema de precificaÃ§Ã£o.<br>ObrigatÃ³rio na ausÃªncia de **items**.",
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
                  "quantity": {
                    "type": "integer",
                    "description": "Quantidade para o **pricing_scheme**.<br>ObrigatÃ³rio quando o **pricing_scheme.scheme_type** for igual a **unit**.",
                    "default": null,
                    "format": "int32"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "name": "Plano Gold",
                    "currency": "BRL",
                    "interval": "month",
                    "interval_count": 3,
                    "billing_type": "prepaid",
                    "minimum_price": 10000,
                    "installments": [
                      3
                    ],
                    "payment_methods": [
                      "credit_card",
                      "boleto"
                    ],
                    "items": [
                      {
                        "name": "MusculaÃ§Ã£o",
                        "quantity": 1,
                        "pricing_scheme": {
                          "price": 18990
                        }
                      },
                      {
                        "name": "MatrÃ­cula",
                        "cycles": 1,
                        "quantity": 1,
                        "pricing_scheme": {
                          "price": 5990
                        }
                      }
                    ],
                    "metadata": {
                      "id": "my_plan_id"
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
                    "value": "{\n    \"id\": \"plan_0z5Jd4dFk3t9Jo4m\",\n    \"name\": \"Plano Gold\",\n    \"url\": \"plans/plan_0z5Jd4dFk3t9Jo4m/simu/plano-gold\",\n    \"minimum_price\": 10000,\n    \"interval\": \"month\",\n    \"interval_count\": 3,\n    \"billing_type\": \"prepaid\",\n    \"payment_methods\": [\n        \"credit_card\",\n        \"boleto\"\n    ],\n    \"installments\": [\n        3\n    ],\n    \"status\": \"active\",\n    \"status_reason\": \"null\"\n    \"currency\": \"BRL\",\n    \"created_at\": \"2019-01-22T17:24:02Z\",\n    \"updated_at\": \"2019-01-22T17:24:02Z\",\n    \"items\": [\n        {\n            \"id\": \"pi_d97LMgRCmOFdWREe\",\n            \"name\": \"MusculaÃ§Ã£o\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2019-01-22T17:24:02Z\",\n            \"updated_at\": \"2019-01-22T17:24:02Z\",\n            \"pricing_scheme\": {\n                \"price\": 18990,\n                \"scheme_type\": \"unit\"\n            }\n        },\n        {\n            \"id\": \"pi_2rXolMkFxRILvw1M\",\n            \"name\": \"MatrÃ­cula\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"cycles\": 1,\n            \"created_at\": \"2019-01-22T17:24:02Z\",\n            \"updated_at\": \"2019-01-22T17:24:02Z\",\n            \"pricing_scheme\": {\n                \"price\": 5990,\n                \"scheme_type\": \"unit\"\n            }\n        }\n    ],\n    \"metadata\": {\n        \"id\": \"my_plan_id\"\n    }\n}"
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
                    "value": "{\n    \"message\": \"The request is invalid.\",\n    \"errors\": {\n        \"plan.name\": [\n            \"The name field is required.\"\n        ]\n    },\n    \"request\": {\n        \"payment_methods\": [\n            \"credit_card\"\n        ],\n        \"installments\": [\n            3\n        ],\n        \"minimum_price\": 10000,\n        \"currency\": \"BRL\",\n        \"interval\": \"month\",\n        \"interval_count\": 3,\n        \"billing_type\": \"prepaid\",\n        \"items\": [\n            {\n                \"name\": \"MusculaÃ§Ã£o\",\n                \"quantity\": 1,\n                \"pricing_scheme\": {\n                    \"price\": 18990,\n                    \"scheme_type\": \"unit\"\n                }\n            },\n            {\n                \"name\": \"MatrÃ­cula\",\n                \"quantity\": 1,\n                \"cycles\": 1,\n                \"pricing_scheme\": {\n                    \"price\": 5990,\n                    \"scheme_type\": \"unit\"\n                }\n            }\n        ],\n        \"metadata\": {\n            \"id\": \"my_plan_id\"\n        }\n    }\n}"
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
                        "plan.name": {
                          "type": "array",
                          "items": {
                            "type": "string",
                            "example": "The name field is required."
                          }
                        }
                      }
                    },
                    "request": {
                      "type": "object",
                      "properties": {
                        "payment_methods": {
                          "type": "array",
                          "items": {
                            "type": "string",
                            "example": "credit_card"
                          }
                        },
                        "installments": {
                          "type": "array",
                          "items": {
                            "type": "integer",
                            "example": 3,
                            "default": 0
                          }
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
                        "items": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "name": {
                                "type": "string",
                                "example": "MusculaÃ§Ã£o"
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