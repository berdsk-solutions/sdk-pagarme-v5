# Criar endereÃ§o

Para a criaÃ§Ã£o de um `address` Ã© necessÃ¡rio informar o `customer_id` do cliente ao qual serÃ¡ associado o endereÃ§o.

> ðŸš§ Clientes com endereÃ§os Internacionais
>
> Clientes que utilizarem passaporte como documento podem realizar transações, informando o endereÃ§o internacional e, em
> vez do CEP, inserindo o ZIP Code correspondente ao paÃ­s.
>
> NÃ£o Ã© possÃ­vel um cliente usar o passaporte e colocar um endereÃ§o nacional.

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
    "/customers/{customer_id}/addresses": {
      "post": {
        "summary": "Criar endereÃ§o",
        "description": "Para a criaÃ§Ã£o de um `address` Ã© necessÃ¡rio informar o `customer_id` do cliente ao qual serÃ¡ associado o endereÃ§o.",
        "operationId": "criar-endereÃ§o-1",
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
                  "line_1",
                  "zip_code",
                  "city",
                  "state",
                  "country"
                ],
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
                    "description": "CEP. Max: 16 caracteres. (Apenas numÃ©rico)"
                  },
                  "city": {
                    "type": "string",
                    "description": "Cidade. Max: 64 caracteres."
                  },
                  "state": {
                    "type": "string",
                    "description": "CÃ³digo do estado no formato ISO 3166-2. <a href=\"https://pt.wikipedia.org/wiki/ISO_3166-2\" target=\"_blank\">Saiba mais sobre ISO 3166-2</a>"
                  },
                  "country": {
                    "type": "string",
                    "description": "CÃ³digo do paÃ­s no formato ISO 3166-1 alpha-2. <a href=\"https://pt.wikipedia.org/wiki/ISO_3166-1_alfa-2\" target=\"_blank\">Saiba mais sobre ISO 3166-1 alpha-2</a>"
                  },
                  "metadata": {
                    "type": "string",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre o endereÃ§o. [Saiba mais sobre metadata](https://docs.mundipagg.com/v1/reference#metadata)"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "line_1": "375, Av. General Justo, Centro",
                    "line_2": "8Âº andar",
                    "zip_code": "20021130",
                    "city": "Rio de Janeiro",
                    "state": "RJ",
                    "country": "BR",
                    "metadata": {
                      "id": "my_address_id"
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
                    "value": "{\n  \"id\": \"addr_Pn5x69LCWhrANX2o\",\n  \"line_1\": \"375, Av. General Justo, Centro\",\n  \"line_2\": \"8Âº andar\",\n  \"zip_code\": \"20021130\",\n  \"city\": \"Rio de Janeiro\",\n  \"state\": \"RJ\",\n  \"country\": \"BR\",\n  \"status\": \"active\",\n  \"created_at\": \"2017-04-19T17:49:36Z\",\n  \"updated_at\": \"2017-04-19T17:49:36Z\",\n  \"customer\": {\n    \"id\": \"cus_aEkwKv0SmNHMR931\",\n    \"name\": \"Luke Skywalker\",\n    \"email\": \"lskywalker@r2d2.com\",\n    \"document\": \"26224451990\",\n    \"type\": \"individual\",\n    \"delinquent\": false,\n    \"created_at\": \"2017-04-04T19:41:31Z\",\n    \"updated_at\": \"2017-04-19T17:44:47Z\",\n    \"metadata\": {\n      \"id\": \"my_customer_id\"\n    }\n  },\n  \"metadata\": {\n    \"id\": \"my_address_id\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "addr_Pn5x69LCWhrANX2o"
                    },
                    "line_1": {
                      "type": "string",
                      "example": "375, Av. General Justo, Centro"
                    },
                    "line_2": {
                      "type": "string",
                      "example": "8Âº andar"
                    },
                    "zip_code": {
                      "type": "string",
                      "example": "20021130"
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
                    "status": {
                      "type": "string",
                      "example": "active"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-19T17:49:36Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-04-19T17:49:36Z"
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_aEkwKv0SmNHMR931"
                        },
                        "name": {
                          "type": "string",
                          "example": "Luke Skywalker"
                        },
                        "email": {
                          "type": "string",
                          "example": "lskywalker@r2d2.com"
                        },
                        "document": {
                          "type": "string",
                          "example": "26224451990"
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
                          "example": "2017-04-04T19:41:31Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-19T17:44:47Z"
                        },
                        "metadata": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "my_customer_id"
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
                          "example": "my_address_id"
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
                    "value": "{\n    \"message\": \"The request is invalid.\",\n    \"errors\": {\n        \"address.line_1\": [\n            \"The line_1 field is required.\"\n        ]\n    },\n    \"request\": {\n        \"zip_code\": \"90265\",\n        \"city\": \"TeresÃ³polis\",\n        \"state\": \"RJ\",\n        \"country\": \"BR\",\n        \"line_2\": \"sala 23\",\n        \"globalType\": true\n    }\n}"
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
                        "address.line_1": {
                          "type": "array",
                          "items": {
                            "type": "string",
                            "example": "The line_1 field is required."
                          }
                        }
                      }
                    },
                    "request": {
                      "type": "object",
                      "properties": {
                        "zip_code": {
                          "type": "string",
                          "example": "90265"
                        },
                        "city": {
                          "type": "string",
                          "example": "TeresÃ³polis"
                        },
                        "state": {
                          "type": "string",
                          "example": "RJ"
                        },
                        "country": {
                          "type": "string",
                          "example": "BR"
                        },
                        "line_2": {
                          "type": "string",
                          "example": "sala 23"
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