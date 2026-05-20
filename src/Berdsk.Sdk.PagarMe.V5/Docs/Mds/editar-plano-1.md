# Editar plano

Com o verbo HTTP PUT, atravÃ©s do identificador do plano (`plan_id`)  Ã© possÃ­vel atualizar os dados do plano.

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
      "put": {
        "summary": "Editar plano",
        "description": "Com o verbo HTTP PUT, atravÃ©s do identificador do plano (`plan_id`)  Ã© possÃ­vel atualizar os dados do plano.",
        "operationId": "editar-plano-1",
        "parameters": [
          {
            "name": "plan_id",
            "in": "path",
            "description": "CÃ³digo do plano.<br>Formato: `plan_XXXXXXXXXXXXXXXX`.",
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
                  "status",
                  "currency",
                  "interval",
                  "interval_count"
                ],
                "properties": {
                  "name": {
                    "type": "string",
                    "description": "Nome do plano. Max: 64 caracteres."
                  },
                  "status": {
                    "type": "string",
                    "description": "Status do plano. Valores possÃ­veis: **active** ou **inactive**"
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
                    "description": "Opções de parcelamento disponÃ­veis para assinaturas criadas a partir do plano.<br>Caso nÃ£o seja informado, o plano irÃ¡ disponibilizar apenas assinaturas com pagamentos Ã  vista.",
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
                    "description": "Texto exibido na fatura do cartÃ£o. <br>SerÃ¡ aplicado para assinaturas de cartÃ£o de crÃ©dito criadas a partir do plano."
                  },
                  "currency": {
                    "type": "string",
                    "description": "Moeda. Valores possÃ­veis: **BRL**,  **ARS**,  **BOB**,  **CLP**,  **COP **,  **MXN**,  **PYG**,  **USD **,  **UYU** e **EUR**."
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
                    "description": "Itens do plano. [Saiba mais sobre um itens do plano](https://docs.pagar.me/reference/item-do-plano-1)"
                  },
                  "metadata": {
                    "type": "string",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre o plano.<br>[Saiba mais sobre metadata](https://docs.pagar.me/reference/metadata-1)"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "name": "Plano Silver",
                    "description": "Esse plano oferece acesso aos programas de musculaÃ§Ã£o e todos os equipamentos e atividades coletivas terrestres.",
                    "currency": "BRL",
                    "interval": "month",
                    "interval_count": 3,
                    "billing_type": "prepaid",
                    "statement_descriptor": "SILVER",
                    "minimum_price": 10000,
                    "status": "active",
                    "payment_methods": [
                      "credit_card"
                    ]
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
                    "value": "{\n  \"id\": \"plan_21r4CTG0ux77Qv13\",\n  \"name\": \"Plano Gold\",\n  \"description\": \"Esse plano oferece acesso aos programas de musculaÃ§Ã£o e todos os equipamentos e atividades coletivas terrestres.\",\n  \"url\": \"/plan_21r4CTG0ux77Qv13/academia/plano-silver\",\n  \"currency\": \"BRL\",\n  \"interval\": \"month\",\n  \"interval_count\": 3,\n  \"billing_type\": \"prepaid\",\n  \"installments\": 3,\n  \"statement_descriptor\": \"SILVER\",\n  \"status\": \"active\",\n  \"created_at\": \"2016-07-12T18:25:40Z\",\n  \"updated_at\": \"2016-07-12T18:25:40Z\",\n  \"minimum_price\": 10000,\n  \"items\": [\n    {\n      \"id\": \"pi_3j1EG9ousipHjcUL\",\n      \"name\": \"MusculaÃ§Ã£o\",\n      \"status\": \"active\",\n      \"created_at\": \"2016-07-12T18:25:40Z\",\n      \"updated_at\": \"2016-07-12T18:25:40Z\",\n      \"pricing_scheme\": {\n        \"price\": 18990,\n      \t\"scheme_type\": \"unit\"\n      }\n    },\n    {\n      \"id\": \"pi_6ggvuaJNS2LVq1i6\",\n      \"name\": \"MatrÃ­cula\",\n      \"cycles\": 1,\n      \"status\": \"active\",\n      \"created_at\": \"2016-07-12T18:25:40Z\",\n      \"updated_at\": \"2016-07-12T18:25:40Z\",\n      \"pricing_scheme\": {\n        \"price\": 5990,\n        \"scheme_type\": \"unit\"\n      }\n    }\n  ],\n  \"metadata\": {\n    \"id\": \"my_plan_id\"\n  }\n}"
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
                    "minimum_price": {
                      "type": "integer",
                      "example": 10000,
                      "default": 0
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