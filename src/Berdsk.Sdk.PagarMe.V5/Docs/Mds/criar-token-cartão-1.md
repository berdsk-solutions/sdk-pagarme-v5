# Criar Token cartÃ£o

> ðŸš§ Billing Address
>
> A entidade de billing address do cartÃ£o nÃ£o Ã© tokenizada. Logo, ao criar um pedido/cobranÃ§a com token tambÃ©m serÃ¡
> preciso informar o billing address.

> â—ï¸ AtenÃ§Ã£o
>
> 1 - Certifique-se de ter o seu domÃ­nio devidamente registrado na dashboard.
>
> Para orientações detalhadas sobre como cadastrar o domÃ­nio,
> consulte [cadastrando de domÃ­nio](https://docs.pagar.me/docs/configurando-a-dashboard-nuvemshop#configura%C3%A7%C3%A3o-de-dom%C3%ADnio).
>
> 2 - Ao utilizar este endpoint, observe que apenas o cabeÃ§alho Content-Type Ã© permitido.\
> NÃ£o Ã© permitido incluir o cabeÃ§alho de autorizaÃ§Ã£o ao realizar o request.

> â—ï¸ NÃƒO UTILIZE A SECRET\_KEY DO LOJISTA
>
> A autenticaÃ§Ã£o deste *endpoint* deverÃ¡ ser feita **exclusivamente** enviando a `public_key` do lojista no parâmetro *
*appId** na *query string*. A `secret_key` de sua loja **nÃ£o deverÃ¡** ser armazenada na pÃ¡gina, tÃ£o pouco ser enviada na
> requisiÃ§Ã£o.

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
    "/tokens": {
      "post": {
        "summary": "Criar Token cartÃ£o",
        "description": "",
        "operationId": "criar-token-cartÃ£o-1",
        "parameters": [
          {
            "name": "appId",
            "in": "query",
            "description": "Chave publica da conta.",
            "required": true,
            "schema": {
              "type": "string"
            }
          }
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "required": [
                  "type",
                  "card"
                ],
                "properties": {
                  "type": {
                    "type": "string",
                    "description": "Tipo do cartÃ£o"
                  },
                  "card": {
                    "type": "object",
                    "description": "Informações do cartÃ£o a ser tokenizado.",
                    "required": [
                      "number",
                      "exp_month",
                      "exp_year"
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
                        "description": "CPF ou CNPJ do portador do cartÃ£o. ObrigatÃ³rio caso o tipo do cartÃ£o seja voucher (bandeiras VR ou Pluxee)."
                      },
                      "exp_month": {
                        "type": "string",
                        "description": "MÃªs de validade do cartÃ£o. Valor entre 1 e 12 (inclusive)"
                      },
                      "exp_year": {
                        "type": "string",
                        "description": "Ano de validade do cartÃ£o. Formatos yy ou yyyy. Ex: 23 ou 2023."
                      },
                      "cvv": {
                        "type": "string",
                        "description": "CÃ³digo de seguranÃ§a do cartÃ£o. O campo aceita 4 ou 3 caracteres, variando por bandeira."
                      },
                      "brand": {
                        "type": "string",
                        "description": "(Opcional) Bandeira do cartÃ£o. Para cartÃµes de crÃ©dito, temos como valores possÃ­veis: Elo, Mastercard, Visa, Amex, ou Hipercard. Para voucher, temos como valores possÃ­veis: Alelo, VR ou Pluxee."
                      },
                      "label": {
                        "type": "string",
                        "description": "Indica a label do cartÃ£o"
                      }
                    }
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "type": "card",
                    "card": {
                      "number": "4000000000000010",
                      "holder_name": "Tony Stark",
                      "exp_month": 1,
                      "exp_year": 30,
                      "cvv": "651",
                      "label": "Sua bandeira"
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
                    "value": "{\n    \"id\": \"token_zVw7rqvHEPH8XlbE\",\n    \"type\": \"card\",\n    \"created_at\": \"2018-06-18T18:48:58Z\",\n    \"expires_at\": \"2018-06-18T18:49:58Z\",\n    \"card\": {\n        \"last_four_digits\": \"5580\",\n        \"holder_name\": \"Tony Stark\",\n        \"exp_month\": 1,\n        \"exp_year\": 30,\n        \"brand\": \"Visa\",\n        \"label\": \"Sua bandeira\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "token_zVw7rqvHEPH8XlbE"
                    },
                    "type": {
                      "type": "string",
                      "example": "card"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2018-06-18T18:48:58Z"
                    },
                    "expires_at": {
                      "type": "string",
                      "example": "2018-06-18T18:49:58Z"
                    },
                    "card": {
                      "type": "object",
                      "properties": {
                        "last_four_digits": {
                          "type": "string",
                          "example": "5580"
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
                        "exp_year": {
                          "type": "integer",
                          "example": 30,
                          "default": 0
                        },
                        "brand": {
                          "type": "string",
                          "example": "Visa"
                        },
                        "label": {
                          "type": "string",
                          "example": "Sua bandeira"
                        }
                      }
                    }
                  }
                }
              }
            }
          },
          "400": {
            "description": "400",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"message\": \"Could not renew card.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Could not renew card."
                    }
                  }
                }
              }
            }
          }
        },
        "deprecated": false,
        "security": []
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