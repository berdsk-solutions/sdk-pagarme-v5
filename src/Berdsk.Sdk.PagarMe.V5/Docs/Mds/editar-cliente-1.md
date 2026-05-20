# Editar cliente

> ðŸš§ O e-mail do cliente Ã© Ãºnico
>
> Ã‰ importante destacar que o campo **e-mail Ã© Ãºnico**, ou seja, caso seja requisitada **a criaÃ§Ã£o de um cliente com um
e-mail jÃ¡ cadastrado**, o *endpoint* irÃ¡ atualizar os dados do `customer` anteriormente cadastrado com o email
> informado.

> â—ï¸ Este endpoint altera todos os dados do customer
>
> Ao enviar uma requisiÃ§Ã£o sem todas as informações do customer, as informações nÃ£o enviadas serÃ£o sobrescritas como '
> null'. Por exemplo: Se o customer jÃ¡ tem um telefone cadastrado e vocÃª realizar um PUT sem o dado de telefone, o
> telefone serÃ¡ apagado.

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
    "/customers/{customer_id}": {
      "put": {
        "summary": "Editar cliente",
        "description": "",
        "operationId": "editar-cliente-1",
        "parameters": [
          {
            "name": "customer_id",
            "in": "path",
            "description": "CÃ³digo do cliente. Formato `cus_XXXXXXXXXXXXXXXX`.",
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
                "properties": {
                  "name": {
                    "type": "string",
                    "description": "Nome do cliente. Max: 64 caracteres."
                  },
                  "email": {
                    "type": "string",
                    "description": "E-mail do cliente. Max: 64 caracteres"
                  },
                  "code": {
                    "type": "string",
                    "description": "CÃ³digo de referÃªncia do cliente no sistema da loja. Max: 52 caracteres"
                  },
                  "document": {
                    "type": "string",
                    "description": "CPF, CNPJ ou PASSAPORTE do cliente. Max: 16 caracteres para CPF e CNPJ e Max: 50 caracteres para PASSAPORTE"
                  },
                  "document_type": {
                    "type": "string",
                    "description": "Tipo de documento. Valores possÃ­veis: CPF, CNPJ ou PASSPORT."
                  },
                  "type": {
                    "type": "string",
                    "description": "Tipo de cliente. Valores possÃ­veis: **individual** (pessoa fÃ­sica) ou **company** (pessoa jurÃ­dica).<br>**ObrigatÃ³rio**, caso o `document` seja enviado."
                  },
                  "gender": {
                    "type": "string",
                    "description": "Sexo do cliente . Valores possÃ­veis: **male** ou **female**"
                  },
                  "address": {
                    "type": "object",
                    "description": "EndereÃ§o do cliente. [Saiba mais sobre endereÃ§os](https://docs.pagar.me/reference/endere%C3%A7os)",
                    "properties": {}
                  },
                  "phone": {
                    "type": "object",
                    "description": "Telefones do cliente. [Saiba mais sobre o telefones](https://docs.pagar.me/reference#telefones-1)",
                    "properties": {}
                  },
                  "birthdate": {
                    "type": "string",
                    "description": "Data de nascimento do cliente.",
                    "format": "date"
                  },
                  "metadata": {
                    "type": "string",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre o cliente. [Saiba mais sobre metadata](https://docs.pagar.me/reference/metadata-1)"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "name": "Peter Parker",
                    "email": "parker@avengers.com",
                    "gender": "male"
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
                    "value": "{\n  \"id\": \"cus_6l5dMWZ0hkHZ4XnE\",\n  \"name\": \"Peter Parker\",\n  \"email\": \"parker@avengers.com\",\n  \"document\": \"26224451990\",\n  \"gender\": \"male\",\n  \"type\": \"individual\",\n  \"delinquent\": false,\n  \"created_at\": \"2017-05-02T23:26:49Z\",\n  \"updated_at\": \"2017-05-02T23:28:16Z\",\n  \"phones\": {\n    \"home_phone\": {\n      \"country_code\": \"55\",\n      \"number\": \"0000002000\",\n      \"area_code\": \"021\"\n    }\n  },\n  \"metadata\": {\n    \"id\": \"my_customer_id\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "cus_6l5dMWZ0hkHZ4XnE"
                    },
                    "name": {
                      "type": "string",
                      "example": "Peter Parker"
                    },
                    "email": {
                      "type": "string",
                      "example": "parker@avengers.com"
                    },
                    "document": {
                      "type": "string",
                      "example": "26224451990"
                    },
                    "gender": {
                      "type": "string",
                      "example": "male"
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
                      "example": "2017-05-02T23:26:49Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-05-02T23:28:16Z"
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
                              "example": "0000002000"
                            },
                            "area_code": {
                              "type": "string",
                              "example": "021"
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
                          "example": "my_customer_id"
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
                    "value": "{\n    \"message\": \"The request is invalid.\",\n    \"errors\": {\n        \"customer.name\": [\n            \"The name field is required.\"\n        ]\n    },\n    \"request\": {\n        \"email\": \"tonystarkk@avengers.com\",\n        \"code\": \"MY_CUSTOMER_001\",\n        \"document\": \"123456789\",\n        \"type\": \"individual\",\n        \"address\": {\n            \"line_1\": \"375, Av. General Justo, Centro\",\n            \"line_2\": \"8Âº andar\",\n            \"zip_code\": \"20021130\",\n            \"city\": \"Rio de Janeiro\",\n            \"state\": \"RJ\",\n            \"country\": \"BR\",\n        },\n        \"birthdate\": \"1984-05-03T00:00:00Z\",\n        \"phones\": {\n            \"home_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            },\n            \"mobile_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            }\n        },\n        \"gender\": \"male\",\n        \"metadata\": {\n            \"company\": \"Avengers\"\n        }\n    }\n}"
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