# Editar cartÃ£o

Com o verbo _HTTP PUT_, atravÃ©s do identificador do cartÃ£o (`card_id`) e do identificador do cliente ao qual o mesmo
estÃ¡ associado (`customer_id`) Ã© possÃ­vel alterar dados do cartÃ£o informado.

<br />

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
    "/customers/{customer_id}/cards/{card_id}": {
      "put": {
        "summary": "Editar cartÃ£o",
        "description": "Com o verbo _HTTP PUT_, atravÃ©s do identificador do cartÃ£o (`card_id`) e do identificador do cliente ao qual o mesmo estÃ¡ associado (`customer_id`) Ã© possÃ­vel alterar dados do cartÃ£o informado.",
        "operationId": "editar-cartÃ£o",
        "parameters": [
          {
            "name": "customer_id",
            "in": "path",
            "description": "CÃ³digo do cliente. Formato: `cus_XXXXXXXXXXXXXXXX`",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "card_id",
            "in": "path",
            "description": "CÃ³digo do CartÃ£o. Formato: `card_XXXXXXXXXXXXXXXX`.",
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
                  "exp_month",
                  "exp_year"
                ],
                "properties": {
                  "holder_name": {
                    "type": "string",
                    "description": "Nome do portador como estÃ¡ impresso no cartÃ£o. MÃ¡ximo de 64 caracteres (Caracteres especiais e nÃºmeros nÃ£o sÃ£o aceitos)"
                  },
                  "holder_document": {
                    "type": "string",
                    "description": "CPF ou CNPJ do portador do cartÃ£o. ObrigatÃ³rio caso o tipo do cartÃ£o seja voucher (bandeiras **VR** ou **Pluxee**)."
                  },
                  "exp_month": {
                    "type": "integer",
                    "description": "MÃªs de validade do cartÃ£o. Valor entre 1 e 12 (inclusive)",
                    "format": "int32"
                  },
                  "exp_year": {
                    "type": "integer",
                    "description": "Ano de validade do cartÃ£o. Formatos **yy** ou **yyyy**. Ex: 23 ou 2023.",
                    "format": "int32"
                  },
                  "billing_address_id": {
                    "type": "string",
                    "description": "CÃ³digo do endereÃ§o de cobranÃ§a. Max: 36 caracteres.<>**Opcional**, pode ser utilizado no lugar do `billing_address`."
                  },
                  "billing_address": {
                    "type": "object",
                    "description": "EndereÃ§o de cobranÃ§a.",
                    "properties": {}
                  },
                  "metadata": {
                    "type": "object",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre o cartÃ£o.  [Saiba mais sobre metadata](https://docs.mundipagg.com/v1/reference#metadata)",
                    "properties": {}
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "holder_name": "Peter Parker",
                    "exp_month": 12,
                    "exp_year": 2030,
                    "billing_address": {
                      "line_1": "375, Av. General Osorio, Centro",
                      "line_2": "7Âº Andar",
                      "zip_code": "220000111",
                      "city": "Rio de Janeiro",
                      "state": "RJ",
                      "country": "BR"
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
                    "value": "{\n    \"id\": \"card_oXpOkr1Sy3UQm7P9\",\n    \"first_six_digits\": \"542501\",\n    \"last_four_digits\": \"7793\",\n    \"brand\": \"Mastercard\",\n    \"holder_name\": \"Peter Parker\",\n    \"exp_month\": 12,\n    \"exp_year\": 2030,\n    \"status\": \"active\",\n    \"created_at\": \"2018-04-03T20:54:58Z\",\n    \"updated_at\": \"2018-04-04T12:25:32Z\",\n    \"billing_address\": {\n        \"zip_code\": \"220000111\",\n        \"city\": \"Rio de Janeiro\",\n        \"state\": \"RJ\",\n        \"country\": \"BR\",\n        \"line_1\": \"375, Av. General Osorio, Centro\",\n        \"line_2\": \"7Âº Andar\"\n    },\n    \"customer\": {\n        \"id\": \"cus_lNXOjXVSLZC4rQom\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"14a2f1a5-79a8-4b2b-a658-d4f931b0e02e@avengers.com\",\n        \"document\": \"93095135270\",\n        \"type\": \"individual\",\n        \"delinquent\": false,\n        \"created_at\": \"2018-04-03T20:11:48Z\",\n        \"updated_at\": \"2018-04-03T20:11:48Z\",\n        \"phones\": {\n            \"home_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            },\n            \"mobile_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            }\n        },\n        \"metadata\": {\n            \"company\": \"Avengers\"\n        }\n    },\n    \"type\": \"credit\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "card_oXpOkr1Sy3UQm7P9"
                    },
                    "first_six_digits": {
                      "type": "string",
                      "example": "542501"
                    },
                    "last_four_digits": {
                      "type": "string",
                      "example": "7793"
                    },
                    "brand": {
                      "type": "string",
                      "example": "Mastercard"
                    },
                    "holder_name": {
                      "type": "string",
                      "example": "Peter Parker"
                    },
                    "exp_month": {
                      "type": "integer",
                      "example": 12,
                      "default": 0
                    },
                    "exp_year": {
                      "type": "integer",
                      "example": 2030,
                      "default": 0
                    },
                    "status": {
                      "type": "string",
                      "example": "active"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2018-04-03T20:54:58Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2018-04-04T12:25:32Z"
                    },
                    "billing_address": {
                      "type": "object",
                      "properties": {
                        "zip_code": {
                          "type": "string",
                          "example": "220000111"
                        },
                        "city": {
                          "type": "string",
                          "example": "Rio de Janeiro"
                        },
                        "state": {
                          "type": "string",
                          "example": "RJ"
                        },
                        "country": {
                          "type": "string",
                          "example": "BR"
                        },
                        "line_1": {
                          "type": "string",
                          "example": "375, Av. General Osorio, Centro"
                        },
                        "line_2": {
                          "type": "string",
                          "example": "7Âº Andar"
                        }
                      }
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_lNXOjXVSLZC4rQom"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "14a2f1a5-79a8-4b2b-a658-d4f931b0e02e@avengers.com"
                        },
                        "document": {
                          "type": "string",
                          "example": "93095135270"
                        },
                        "type": {
                          "type": "string",
                          "example": "individual"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2018-04-03T20:11:48Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-04-03T20:11:48Z"
                        },
                        "phones": {
                          "type": "object",
                          "properties": {
                            "home_phone": {
                              "type": "object",
                              "properties": {
                                "country_code": {
                                  "type": "string",
                                  "example": "55"
                                },
                                "number": {
                                  "type": "string",
                                  "example": "000000000"
                                },
                                "area_code": {
                                  "type": "string",
                                  "example": "21"
                                }
                              }
                            },
                            "mobile_phone": {
                              "type": "object",
                              "properties": {
                                "country_code": {
                                  "type": "string",
                                  "example": "55"
                                },
                                "number": {
                                  "type": "string",
                                  "example": "000000000"
                                },
                                "area_code": {
                                  "type": "string",
                                  "example": "21"
                                }
                              }
                            }
                          }
                        },
                        "metadata": {
                          "type": "object",
                          "properties": {
                            "company": {
                              "type": "string",
                              "example": "Avengers"
                            }
                          }
                        }
                      }
                    },
                    "type": {
                      "type": "string",
                      "example": "credit"
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
                    "value": "{\n    \"message\": \"Card not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Card not found."
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
                    "value": "{\n    \"message\": \"The request is invalid.\",\n    \"errors\": {\n        \"card.exp_date\": [\n            \"The card expiration date is invalid.\"\n        ]\n    },\n    \"request\": {\n        \"holder_name\": \"Peter Parker\",\n        \"exp_month\": 12,\n        \"billing_address\": {\n            \"zip_code\": \"220000111\",\n            \"city\": \"Rio de Janeiro\",\n            \"state\": \"RJ\",\n            \"country\": \"BR\",\n            \"line_1\": \"375, Av. General Osorio, Centro\",\n            \"line_2\": \"7Âº Andar\",\n            \"globalType\": true\n        }\n    }\n}"
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
                        "card.exp_date": {
                          "type": "array",
                          "items": {
                            "type": "string",
                            "example": "The card expiration date is invalid."
                          }
                        }
                      }
                    },
                    "request": {
                      "type": "object",
                      "properties": {
                        "holder_name": {
                          "type": "string",
                          "example": "Peter Parker"
                        },
                        "exp_month": {
                          "type": "integer",
                          "example": 12,
                          "default": 0
                        },
                        "billing_address": {
                          "type": "object",
                          "properties": {
                            "zip_code": {
                              "type": "string",
                              "example": "220000111"
                            },
                            "city": {
                              "type": "string",
                              "example": "Rio de Janeiro"
                            },
                            "state": {
                              "type": "string",
                              "example": "RJ"
                            },
                            "country": {
                              "type": "string",
                              "example": "BR"
                            },
                            "line_1": {
                              "type": "string",
                              "example": "375, Av. General Osorio, Centro"
                            },
                            "line_2": {
                              "type": "string",
                              "example": "7Âº Andar"
                            },
                            "globalType": {
                              "type": "boolean",
                              "example": true,
                              "default": true
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