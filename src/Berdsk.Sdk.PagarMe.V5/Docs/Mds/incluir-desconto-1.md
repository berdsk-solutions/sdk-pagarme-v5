# Incluir desconto

Este recurso permite adicionar um desconto, atravÃ©s do identificador da assinatura (`subscription_id`).

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
    "/subscriptions/{subscription_id}/discounts": {
      "post": {
        "summary": "Incluir desconto",
        "description": "Este recurso permite adicionar um desconto, atravÃ©s do identificador da assinatura (`subscription_id`).",
        "operationId": "incluir-desconto-1",
        "parameters": [
          {
            "name": "subscription_id",
            "in": "path",
            "description": "CÃ³digo da assinatura.<br>Formato `sub_XXXXXXXXXXXXXXXX`",
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
                  "value",
                  "discount_type"
                ],
                "properties": {
                  "value": {
                    "type": "string",
                    "description": "Valor do desconto."
                  },
                  "discount_type": {
                    "type": "string",
                    "description": "Tipo do desconto. <br>Valores possÃ­veis: **flat** ou **percentage**. O padrÃ£o Ã© **percentage**"
                  },
                  "cycles": {
                    "type": "string",
                    "description": "Indica quantas vezes o desconto serÃ¡ aplicado. <br>Caso nÃ£o seja informado, o desconto serÃ¡ aplicado atÃ© que o item seja excluÃ­do"
                  },
                  "item_id": {
                    "type": "string",
                    "description": "CÃ³digo do item da assinatura. <br>Formato: `si_XXXXXXXXXXXXXXXX` <br>Caso seja informado, o desconto serÃ¡ aplicado no item. Max: 36 caracteres"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "value": 10,
                    "discount_type": "percentage",
                    "cycles": "1",
                    "item_id": "si_GyL1lmGU6tOXYr2O"
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
                    "value": "{\n  \"id\": \"dis_LP4j5dXztPSj5A02\",\n    \"value\": 10,\n    \"discount_type\": \"percentage\",\n    \"cycles\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2019-05-22T14:23:55Z\",\n    \"updated_at\": \"2019-05-22T14:23:55Z\",\n    \"subscription\": {\n        \"id\": \"sub_DvPanXLsqcQnk8e1\",\n        \"code\": \"5Z7ZU01F60\",\n        \"start_at\": \"2019-05-22T00:00:00Z\",\n        \"interval\": \"day\",\n        \"interval_count\": 1,\n        \"billing_type\": \"prepaid\",\n        \"next_billing_at\": \"2019-05-25T00:00:00Z\",\n        \"payment_method\": \"credit_card\",\n        \"currency\": \"BRL\",\n        \"installments\": 1,\n        \"minimum_price\": 10,\n        \"status\": \"active\",\n        \"boleto_due_days\": 5,\n        \"created_at\": \"2019-05-22T14:05:49Z\",\n        \"updated_at\": \"2019-05-22T14:21:51Z\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "dis_LP4j5dXztPSj5A02"
                    },
                    "value": {
                      "type": "integer",
                      "example": 10,
                      "default": 0
                    },
                    "discount_type": {
                      "type": "string",
                      "example": "percentage"
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
                      "example": "2019-05-22T14:23:55Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2019-05-22T14:23:55Z"
                    },
                    "subscription": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "sub_DvPanXLsqcQnk8e1"
                        },
                        "code": {
                          "type": "string",
                          "example": "5Z7ZU01F60"
                        },
                        "start_at": {
                          "type": "string",
                          "example": "2019-05-22T00:00:00Z"
                        },
                        "interval": {
                          "type": "string",
                          "example": "day"
                        },
                        "interval_count": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
                        },
                        "billing_type": {
                          "type": "string",
                          "example": "prepaid"
                        },
                        "next_billing_at": {
                          "type": "string",
                          "example": "2019-05-25T00:00:00Z"
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
                          "example": 1,
                          "default": 0
                        },
                        "minimum_price": {
                          "type": "integer",
                          "example": 10,
                          "default": 0
                        },
                        "status": {
                          "type": "string",
                          "example": "active"
                        },
                        "boleto_due_days": {
                          "type": "integer",
                          "example": 5,
                          "default": 0
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2019-05-22T14:05:49Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2019-05-22T14:21:51Z"
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
                    "value": "{\n  \"message\": \"Subscription not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Subscription not found."
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
                    "value": "{\n  \"message\": \"The request is invalid.\",\n  \"errors\": {\n    \"discount.discount_type\": [\n      \"The discount_type field is invalid. Possible values are 'flat' or 'percentage'.\"\n    ]\n  },\n  \"request\": {\n    \"discount_type\": \"null\",\n    \"value\": 10\n  }\n}"
                  }
                },
                "schema": {
                  "oneOf": [
                    {
                      "type": "object",
                      "properties": {
                        "message": {
                          "type": "string",
                          "example": "The request is invalid."
                        },
                        "errors": {
                          "type": "object",
                          "properties": {
                            "discount.value": {
                              "type": "array",
                              "items": {
                                "type": "string",
                                "example": "The value field should be greater than the zero."
                              }
                            }
                          }
                        },
                        "request": {
                          "type": "object",
                          "properties": {
                            "discount_type": {
                              "type": "string",
                              "example": "percentage"
                            }
                          }
                        }
                      }
                    },
                    {
                      "type": "object",
                      "properties": {
                        "message": {
                          "type": "string",
                          "example": "The request is invalid."
                        },
                        "errors": {
                          "type": "object",
                          "properties": {
                            "discount.discount_type": {
                              "type": "array",
                              "items": {
                                "type": "string",
                                "example": "The discount_type field is invalid. Possible values are 'flat' or 'percentage'."
                              }
                            }
                          }
                        },
                        "request": {
                          "type": "object",
                          "properties": {
                            "discount_type": {
                              "type": "string",
                              "example": "null"
                            },
                            "value": {
                              "type": "integer",
                              "example": 10,
                              "default": 0
                            }
                          }
                        }
                      }
                    }
                  ]
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