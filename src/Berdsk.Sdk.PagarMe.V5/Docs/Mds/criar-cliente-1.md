# Criar cliente

> ðŸš§ O e-mail do cliente Ã© Ãºnico
>
> Ã‰ importante destacar que o campo **e-mail Ã© Ãºnico**, ou seja, caso seja requisitada **a criaÃ§Ã£o de um cliente com um
e-mail jÃ¡ cadastrado**, o *endpoint* irÃ¡ atualizar os dados do `customer` anteriormente cadastrado com o email
> informado.

> ðŸš§ Clientes com Passaporte
>
> Clientes com documento do tipo "passport" na integraÃ§Ã£o da Sub Pagar.me sÃ³ conseguirÃ£o transacionar utilizando
> endereÃ§os internacionais, reconhecidos pelo ZIP Code de cada paÃ­s.

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
    "/customers": {
      "post": {
        "summary": "Criar cliente",
        "description": "",
        "operationId": "criar-cliente-1",
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
                    "description": "CPF, CNPJ ou PASSPORT do cliente. Max: 16 caracteres para CPF e CNPJ e Max: 50 caracteres para PASSPORT"
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
                    "description": "EndereÃ§o do cliente.",
                    "properties": {
                      "country": {
                        "type": "string",
                        "description": "PaÃ­s (CÃ³digo do paÃ­s no formato ISO 3166-1 alpha-2)(2 digitos)"
                      },
                      "state": {
                        "type": "string",
                        "description": "Estado (CÃ³digo do estado no formato ISO 3166-2)."
                      },
                      "city": {
                        "type": "string",
                        "description": "Cidade."
                      },
                      "zip_code": {
                        "type": "string",
                        "description": "CÃ³digo Postal (CEP) (Apenas numÃ©rico)."
                      },
                      "line_1": {
                        "type": "string",
                        "description": "Dados principais do endereÃ§o. Neste campo deve ser informado NÃºmero, Rua, Bairro, nesta ordem e separados por vÃ­rgula."
                      },
                      "line_2": {
                        "type": "string",
                        "description": "Dados complementares do endereÃ§o. Neste campo pode ser informado complemento, referÃªncias."
                      }
                    }
                  },
                  "phones": {
                    "type": "object",
                    "description": "Telefones do cliente. [Saiba mais sobre o telefones](https://docs.pagar.me/reference#telefones-1)",
                    "properties": {
                      "home_phone": {
                        "type": "object",
                        "description": "Telefone residencial do cliente.",
                        "properties": {
                          "country_code": {
                            "type": "string",
                            "description": "CÃ³digo do PaÃ­s (Apenas numÃ©rico)."
                          },
                          "area_code": {
                            "type": "string",
                            "description": "CÃ³digo da Ã¡rea (Apenas numÃ©rico)."
                          },
                          "number": {
                            "type": "string",
                            "description": "NÃºmero do telefone (Apenas numÃ©rico)."
                          }
                        }
                      },
                      "mobile_phone": {
                        "type": "object",
                        "description": "Telefone celular do cliente.",
                        "properties": {
                          "country_code": {
                            "type": "string",
                            "description": "CÃ³digo do PaÃ­s (Apenas numÃ©rico)."
                          },
                          "area_code": {
                            "type": "string",
                            "description": "CÃ³digo da Ã¡rea (Apenas numÃ©rico)."
                          },
                          "number": {
                            "type": "string",
                            "description": "NÃºmero do telefone (Apenas numÃ©rico)."
                          }
                        }
                      }
                    }
                  },
                  "birthdate": {
                    "type": "string",
                    "description": "Data de nascimento do cliente.",
                    "default": "mm/dd/aaa",
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
                    "name": "Tony Stark",
                    "email": "tonystarkk@avengers.com",
                    "code": "MY_CUSTOMER_001",
                    "document": "93095135270",
                    "type": "individual",
                    "document_type": "CPF",
                    "gender": "male",
                    "address": {
                      "line_1": "375, Av. General Justo, Centro",
                      "line_2": "8Âº andar",
                      "zip_code": "20021130",
                      "city": "Rio de Janeiro",
                      "state": "RJ",
                      "country": "BR"
                    },
                    "birthdate": "05/03/1984",
                    "phones": {
                      "home_phone": {
                        "country_code": "55",
                        "area_code": "21",
                        "number": "000000000"
                      },
                      "mobile_phone": {
                        "country_code": "55",
                        "area_code": "21",
                        "number": "000000000"
                      }
                    },
                    "metadata": {
                      "company": "Avengers"
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
                    "value": "{\n    \"id\": \"cus_QA5V47r9c0Im3dzN\",\n    \"name\": \"Tony Stark\",\n    \"email\": \"tonystarkk@avengers.com\",\n    \"code\": \"MY_CUSTOMER_001\",\n    \"document\": \"93095135270\",\n    \"document_type\": \"CPF\",  \n    \"type\": \"individual\",\n    \"gender\": \"male\",\n    \"delinquent\": false,\n    \"address\": {\n        \"id\": \"addr_KewjagEfrCbY1doZ\",\n        \"line_1\": \"375, Av. General Justo, Centro\",\n        \"line_2\": \"8Âº andar\",\n        \"zip_code\": \"20021130\",\n        \"city\": \"Rio de Janeiro\",\n        \"state\": \"RJ\",\n        \"country\": \"BR\",\n        \"status\": \"active\",\n        \"created_at\": \"2017-09-22T15:36:46Z\",\n        \"updated_at\": \"2018-04-03T17:46:20Z\"\n    },\n    \"created_at\": \"2017-09-22T15:36:46Z\",\n    \"updated_at\": \"2018-04-03T17:46:20Z\",\n    \"birthdate\": \"1984-05-03T00:00:00Z\",\n    \"phones\": {\n        \"home_phone\": {\n            \"country_code\": \"55\",\n            \"number\": \"000000000\",\n            \"area_code\": \"21\"\n        },\n        \"mobile_phone\": {\n            \"country_code\": \"55\",\n            \"number\": \"000000000\",\n            \"area_code\": \"21\"\n        }\n    },\n    \"metadata\": {\n        \"id\": \"my_customer_id\",\n        \"company\": \"Avengers\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "cus_QA5V47r9c0Im3dzN"
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
                      "example": "CPF"
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
                    "address": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "addr_KewjagEfrCbY1doZ"
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
                          "example": "2017-09-22T15:36:46Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-04-03T17:46:20Z"
                        }
                      }
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-09-22T15:36:46Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2018-04-03T17:46:20Z"
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
                        "id": {
                          "type": "string",
                          "example": "my_customer_id"
                        },
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