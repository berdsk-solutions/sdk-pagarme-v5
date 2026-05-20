# Incluir incremento

Este recurso permite adicionar um incremento, atravÃ©s do identificador da assinatura (`subscription_id`).

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
    "/subscriptions/{subscription_id}/increments": {
      "post": {
        "summary": "Incluir incremento",
        "description": "Este recurso permite adicionar um incremento, atravÃ©s do identificador da assinatura (`subscription_id`).",
        "operationId": "incluir-incremento-1",
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
                  "increment_type"
                ],
                "properties": {
                  "value": {
                    "type": "string",
                    "description": "Valor do incremento."
                  },
                  "increment_type": {
                    "type": "string",
                    "description": "Tipo do incremento. <br>Valores possÃ­veis: **flat** ou **percentage**. O padrÃ£o Ã© **percentage**"
                  },
                  "cycles": {
                    "type": "integer",
                    "description": "Indica quantas vezes o incremento serÃ¡ aplicado. <br>Caso nÃ£o seja informada, o incremento serÃ¡ aplicado atÃ© que o item seja excluÃ­do",
                    "format": "int32"
                  },
                  "item_id": {
                    "type": "string",
                    "description": "CÃ³digo do item da assinatura. <br>Formato: `si_XXXXXXXXXXXXXXXX` <br>Caso seja informado, o incremento serÃ¡ aplicado no item. Max: 36 caracteres"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "value": 20,
                    "increment_type": "percentage"
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
                    "value": "{\n  \"id\": \"inc_IYzpxgjsOs0fDIoP\",\n  \"value\": 20,\n  \"increment_type\": \"percentage\",\n  \"status\": \"active\",\n  \"created_at\": \"2017-04-04T18:36:43Z\",\n  \"subscription\": {\n    \"id\": \"sub_o0Jw4WYCMuPNqzGr\",\n    \"code\": \"09NFPLBZY0\",\n    \"start_at\": \"2017-04-04T00:00:00Z\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"billing_type\": \"postpaid\",\n    \"next_billing_at\": \"2017-05-04T00:00:00Z\",\n    \"payment_method\": \"credit_card\",\n    \"currency\": \"BRL\",\n    \"statement_descriptor\": \"Spotify\",\n    \"installments\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2017-04-04T18:21:17Z\",\n    \"updated_at\": \"2017-04-04T18:21:17Z\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "inc_IYzpxgjsOs0fDIoP"
                    },
                    "value": {
                      "type": "integer",
                      "example": 20,
                      "default": 0
                    },
                    "increment_type": {
                      "type": "string",
                      "example": "percentage"
                    },
                    "status": {
                      "type": "string",
                      "example": "active"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-04T18:36:43Z"
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
                          "example": "2017-04-04T18:21:17Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-04T18:21:17Z"
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
                    "value": "{\n  \"message\": \"The request is invalid.\",\n  \"errors\": {\n    \"increment.increment_type\": [\n      \"The increment_type field is invalid. Possible values are 'flat' or 'percentage'.\"\n    ]\n  },\n  \"request\": {\n    \"increment_type\": \"null\",\n    \"value\": 10\n  }\n}"
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
                            "increment.value": {
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
                            "increment_type": {
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
                            "increment.increment_type": {
                              "type": "array",
                              "items": {
                                "type": "string",
                                "example": "The increment_type field is invalid. Possible values are 'flat' or 'percentage'."
                              }
                            }
                          }
                        },
                        "request": {
                          "type": "object",
                          "properties": {
                            "increment_type": {
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