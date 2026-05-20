# Criar cartÃ£o

Este recurso cria um `card` associado ao `customer` atravÃ©s do `customer_id` informado.

<br />

> ðŸš§ Falha na verificaÃ§Ã£o de cartÃ£o
>
> Quando a verificaÃ§Ã£o de cartÃ£o esta ativa e ocorre uma falha na verificaÃ§Ã£o, a API irÃ¡ retornar erro "412" com a
> mensagem: "Could not create credit card. The card verification failed."

> ðŸš§ CartÃ£o jÃ¡ cadastrado
>
> Caso um cliente tente cadastrar um **mesmo cartÃ£o mais de uma vez\***, serÃ¡ retornado o mesmo `card_id` do cartÃ£o
> previamente cadastrado.

> â—ï¸ Campo "brand" Ã© obrigatÃ³rio para cartÃµes Private Label
>
> Caso o cartÃ£o seja *private label* (ou seja `private_label` = **true**), `brand` serÃ¡ um campo obrigatÃ³rio.

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
    "/customers/{customer_id}/cards": {
      "post": {
        "summary": "Criar cartÃ£o",
        "description": "Este recurso cria um `card` associado ao `customer` atravÃ©s do `customer_id` informado.",
        "operationId": "criar-cartÃ£o",
        "parameters": [
          {
            "name": "customer_id",
            "in": "path",
            "description": "CÃ³digo do cliente. Formato: `cus_XXXXXXXXXXXXXXXX`",
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
                  "number",
                  "holder_name",
                  "exp_month",
                  "exp_year",
                  "cvv"
                ],
                "properties": {
                  "number": {
                    "type": "string",
                    "description": "NÃºmero do cartÃ£o. Entre 13 e 19 caracteres"
                  },
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
                  "cvv": {
                    "type": "string",
                    "description": "CÃ³digo de seguranÃ§a do cartÃ£o. O campo aceita 4 ou 3 caracteres, variando por bandeira."
                  },
                  "brand": {
                    "type": "string",
                    "description": "Bandeira do cartÃ£o. Para cartÃµes de crÃ©dito, temos como valores possÃ­veis: **elo**, **mastercard**, **visa**, **amex**, **jcb**, **aura**, **hipercard**, **diners**, **unionpay** ou **discover**."
                  },
                  "label": {
                    "type": "string",
                    "description": "Indica a label do cartÃ£o"
                  },
                  "billing_address_id": {
                    "type": "string",
                    "description": "CÃ³digo do endereÃ§o de cobranÃ§a. Max: 36 caracteres.<>**Opcional**, pode ser utilizado no lugar do `billing_address`."
                  },
                  "billing_address": {
                    "type": "object",
                    "description": "EndereÃ§o de cobranÃ§a.",
                    "properties": {
                      "line_1": {
                        "type": "string",
                        "description": "Linha 1 do endereÃ§o. (NÃºmero, Rua, e Bairro - Nesta ordem e separados por vÃ­rgula) Max: 256 caracteres."
                      },
                      "line_2": {
                        "type": "string",
                        "description": "Linha 2 do endereÃ§o. (Complemento - Andar, Sala, Apto). Max: 128 caracteres."
                      },
                      "zip_code": {
                        "type": "string",
                        "description": "CEP. Max: 16 caracteres."
                      },
                      "city": {
                        "type": "string",
                        "description": "Cidade. Max: 64 caracteres."
                      },
                      "state": {
                        "type": "string",
                        "description": "CÃ³digo do estado no formato ISO 3166-2."
                      },
                      "country": {
                        "type": "string",
                        "description": "CÃ³digo do paÃ­s no formato ISO 3166-1 alpha-2."
                      }
                    }
                  },
                  "options": {
                    "type": "object",
                    "description": "Objeto com opções para a criaÃ§Ã£o do cartÃ£o. Um exemplo de opÃ§Ã£o que pode ser adicionada ao cartÃ£o Ã© o `verify_card` : `true`, que informa que haverÃ¡ uma validaÃ§Ã£o do cartÃ£o antes da utilizaÃ§Ã£o (Zero Dollar Auth).",
                    "properties": {}
                  },
                  "metadata": {
                    "type": "string",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre o cartÃ£o.  [Saiba mais sobre metadata](https://docs.pagar.me/reference/metadata-1)"
                  },
                  "token": {
                    "type": "string",
                    "description": "Pode ser enviado no lugar dos dados do cartÃ£o, caso este jÃ¡ tenha sido tokenizado previamente. [Saiba mais sobre criaÃ§Ã£o de token de cartÃ£o.](https://docs.pagar.me/reference/criar-token-cart%C3%A3o-1)"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "number": "4000000000000010",
                    "holder_name": "Tony Stark",
                    "holder_document": "93095135270",
                    "exp_month": 1,
                    "exp_year": 30,
                    "cvv": "351",
                    "brand": "Mastercard",
                    "label": "Sua bandeira",
                    "billing_address": {
                      "line_1": "375, Av. General Osorio, Centro",
                      "line_2": "7Âº Andar",
                      "zip_code": "220000111",
                      "city": "Rio de Janeiro",
                      "state": "RJ",
                      "country": "BR"
                    },
                    "options": {
                      "verify_card": true
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
                    "value": "{\n    \"id\": \"card_8ELY0AwVF9HDa3jK\",\n    \"first_six_digits\": \"542501\",\n    \"last_four_digits\": \"7793\",\n    \"brand\": \"Mastercard\",\n    \"holder_name\": \"Tony Stark\",\n    \"holder_document\": \"93095135270\",\n    \"exp_month\": 1,\n    \"exp_year\": 2030,\n    \"status\": \"active\",\n    \"label\": \"Sua bandeira\",\n    \"created_at\": \"2017-07-07T19:50:33Z\",\n    \"updated_at\": \"2017-07-07T19:50:33Z\",\n    \"billing_address\": {\n        \"zip_code\": \"220000111\",\n        \"city\": \"Rio de Janeiro\",\n        \"state\": \"RJ\",\n        \"country\": \"BR\",\n        \"line_1\": \"375, Av. General Osorio, Centro\",\n        \"line_2\": \"7Âº Andar\"\n    },\n    \"customer\": {\n        \"id\": \"cus_yoqONwOJI1IBNbjl\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"0fee2dc5-e440-4dd1-9cd6-9c2bc90533d0@avengers.com\",\n        \"document\": \"93095135270\",\n        \"type\": \"individual\",\n        \"delinquent\": false,\n        \"created_at\": \"2017-07-07T19:50:23Z\",\n        \"updated_at\": \"2017-07-07T19:50:23Z\",\n        \"phones\": {\n            \"home_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            },\n            \"mobile_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            }\n        },\n        \"metadata\": {\n            \"company\": \"Avengers\"\n        }\n    },\n    \"type\": \"credit\"\n}"
                  },
                  "OK - Network Token": {
                    "value": "{\n    \"id\": \"card_ej6MVD4sYLUBVy92\",\n    \"first_six_digits\": \"400000\",\n    \"last_four_digits\": \"0010\",\n    \"brand\": \"Visa\",\n    \"holder_name\": \"Tony Stark\",\n    \"holder_document\": \"93095135270\",\n    \"exp_month\": 1,\n    \"exp_year\": 2030,\n    \"status\": \"active\",\n    \"type\": \"credit\",\n    \"created_at\": \"2023-03-17T14:01:48Z\",\n    \"updated_at\": \"2023-03-17T14:01:48Z\",\n    \"billing_address\": {\n        \"zip_code\": \"220000111\",\n        \"city\": \"Rio de Janeiro\",\n        \"state\": \"RJ\",\n        \"country\": \"BR\",\n        \"line_1\": \"375, Av. General Osorio, Centro\",\n        \"line_2\": \"7Âº Andar\"\n    },\n    \"network_token\": {\n        \"token_unique_reference\": \"ea90e8e8-af1d-4f22-a2f0-a54d5f8b55b5\",\n        \"status\": \"active\"\n    },\n    \"customer\": {\n        \"id\": \"cus_9oYdjPACaAUXgJq0\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"tonystarkk@avengers.com\",\n        \"code\": \"MY_CUSTOMER_001\",\n        \"document\": \"93095135270\",\n        \"document_type\": \"cpf\",\n        \"type\": \"individual\",\n        \"gender\": \"male\",\n        \"delinquent\": false,\n        \"created_at\": \"2023-03-17T14:01:45Z\",\n        \"updated_at\": \"2023-03-17T14:01:45Z\",\n        \"birthdate\": \"1984-05-03T00:00:00Z\",\n        \"phones\": {\n            \"home_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            },\n            \"mobile_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            }\n        },\n        \"metadata\": {\n            \"company\": \"Avengers\"\n        }\n    }\n}"
                  }
                },
                "schema": {
                  "oneOf": [
                    {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "card_8ELY0AwVF9HDa3jK"
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
                          "example": "Tony Stark"
                        },
                        "holder_document": {
                          "type": "string",
                          "example": "93095135270"
                        },
                        "exp_month": {
                          "type": "integer",
                          "example": 1,
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
                        "label": {
                          "type": "string",
                          "example": "Sua bandeira"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-07-07T19:50:33Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-07-07T19:50:33Z"
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
                              "example": "cus_yoqONwOJI1IBNbjl"
                            },
                            "name": {
                              "type": "string",
                              "example": "Tony Stark"
                            },
                            "email": {
                              "type": "string",
                              "example": "0fee2dc5-e440-4dd1-9cd6-9c2bc90533d0@avengers.com"
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
                              "example": "2017-07-07T19:50:23Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2017-07-07T19:50:23Z"
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
                    },
                    {
                      "title": "OK - Network Token",
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "card_ej6MVD4sYLUBVy92"
                        },
                        "first_six_digits": {
                          "type": "string",
                          "example": "400000"
                        },
                        "last_four_digits": {
                          "type": "string",
                          "example": "0010"
                        },
                        "brand": {
                          "type": "string",
                          "example": "Visa"
                        },
                        "holder_name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "holder_document": {
                          "type": "string",
                          "example": "93095135270"
                        },
                        "exp_month": {
                          "type": "integer",
                          "example": 1,
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
                        "type": {
                          "type": "string",
                          "example": "credit"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2023-03-17T14:01:48Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2023-03-17T14:01:48Z"
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
                        "network_token": {
                          "type": "object",
                          "properties": {
                            "token_unique_reference": {
                              "type": "string",
                              "example": "ea90e8e8-af1d-4f22-a2f0-a54d5f8b55b5"
                            },
                            "status": {
                              "type": "string",
                              "example": "active"
                            }
                          }
                        },
                        "customer": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "cus_9oYdjPACaAUXgJq0"
                            },
                            "name": {
                              "type": "string",
                              "example": "Tony Stark"
                            },
                            "email": {
                              "type": "string",
                              "example": "tonystarkk@avengers.com"
                            },
                            "code": {
                              "type": "string",
                              "example": "MY_CUSTOMER_001"
                            },
                            "document": {
                              "type": "string",
                              "example": "93095135270"
                            },
                            "document_type": {
                              "type": "string",
                              "example": "cpf"
                            },
                            "type": {
                              "type": "string",
                              "example": "individual"
                            },
                            "gender": {
                              "type": "string",
                              "example": "male"
                            },
                            "delinquent": {
                              "type": "boolean",
                              "example": false,
                              "default": true
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2023-03-17T14:01:45Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2023-03-17T14:01:45Z"
                            },
                            "birthdate": {
                              "type": "string",
                              "example": "1984-05-03T00:00:00Z"
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
                        }
                      }
                    }
                  ]
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
                    "value": "{\n    \"message\": \"Customer not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Customer not found."
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
                    "value": "{\n    \"message\": \"The request is invalid.\",\n    \"errors\": {\n        \"card\": [\n            \"The card expiration date is invalid.\"\n        ]\n    },\n    \"request\": {\n        \"number\": \"5425019448107793\",\n        \"last_four_digits\": \"7793\",\n        \"brand\": \"Mastercard\",\n        \"holder_name\": \"Tony Stark\",\n        \"exp_month\": 1,\n        \"cvv\": \"123\",\n    \"billing_address\": {\n        \"zip_code\": \"220000111\",\n        \"city\": \"Rio de Janeiro\",\n        \"state\": \"RJ\",\n        \"country\": \"BR\",\n        \"line_1\": \"375, Av. General Osorio, Centro\",\n        \"line_2\": \"7Âº Andar\"\n    },\n        \"options\": {\n            \"verify_card\": true\n        }\n    }\n}"
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
                        "card": {
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
                        "number": {
                          "type": "string",
                          "example": "5425019448107793"
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
                          "example": "Tony Stark"
                        },
                        "exp_month": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
                        },
                        "cvv": {
                          "type": "string",
                          "example": "123"
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
                        "options": {
                          "type": "object",
                          "properties": {
                            "verify_card": {
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