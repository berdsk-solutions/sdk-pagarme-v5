# Atualizar conta bancÃ¡ria do recebedor

> â—ï¸ Para utilizar esta rota, Ã© necessÃ¡rio configurar a sua Allow List
>
> Para adicionar novos IPs na lista de permissÃµes Ã© sÃ³ seguir o passo a passo indicado na pÃ¡gina:\
> [Allow List](https://docs.pagar.me/docs/ip-allowlist)
>
> Caso contrÃ¡rio, ao utilizar a rota de atualizaÃ§Ã£o de conta bancÃ¡ria do recebedor o retorno serÃ¡:\
> `{
>     "message": "Request denied. Second authentication factor is necessary."
> }`

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
    "/recipients/{recipient_id}/default-bank-account": {
      "patch": {
        "summary": "Atualizar conta bancÃ¡ria do recebedor",
        "description": "",
        "operationId": "atualizar-conta-bancÃ¡ria-do-recebedor-1",
        "parameters": [
          {
            "name": "recipient_id",
            "in": "path",
            "description": "CÃ³digo do recebedor",
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
                  "bank_account"
                ],
                "properties": {
                  "bank_account": {
                    "type": "object",
                    "description": "Dados da conta bancÃ¡ria",
                    "required": [
                      "holder_name",
                      "holder_type",
                      "holder_document",
                      "bank",
                      "branch_number",
                      "account_number",
                      "account_check_digit",
                      "type"
                    ],
                    "properties": {
                      "holder_name": {
                        "type": "string",
                        "description": "Nome do titular da conta."
                      },
                      "holder_type": {
                        "type": "string",
                        "description": "Tipo de titular. Valores possÃ­veis sÃ£o **individual** (pessoa fÃ­sica) ou **company** (pessoa jurÃ­dica)."
                      },
                      "holder_document": {
                        "type": "string",
                        "description": "NÃºmero do documento do titular da conta. Deve ser igual ao documento do recebedor."
                      },
                      "bank": {
                        "type": "string",
                        "description": "CÃ³digo do banco."
                      },
                      "branch_number": {
                        "type": "string",
                        "description": "NÃºmero da agÃªncia."
                      },
                      "branch_check_digit": {
                        "type": "string",
                        "description": "CÃ³digo verificador da agÃªncia."
                      },
                      "account_number": {
                        "type": "string",
                        "description": "NÃºmero da conta. MÃ¡ximo 13 caracteres numÃ©ricos"
                      },
                      "account_check_digit": {
                        "type": "string",
                        "description": "CÃ³digo verificador da conta."
                      },
                      "type": {
                        "type": "string",
                        "description": "Tipo da conta. Valores possÃ­veis sÃ£o **checking** ou **savings**."
                      },
                      "metadata": {
                        "type": "object",
                        "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre a conta bancÃ¡ria.",
                        "properties": {}
                      }
                    }
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "bank_account": {
                      "holder_name": "Tony Stark",
                      "holder_type": "individual",
                      "holder_document": "26224451990",
                      "bank": "341",
                      "branch_number": "1234",
                      "branch_check_digit": "6",
                      "account_number": "12345",
                      "account_check_digit": "6",
                      "type": "checking",
                      "metadata": {
                        "meta_key": "meta_value"
                      }
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
                    "value": "{\n    \"id\": \"rp_Gxb5NJNiqvf0Y5Xv\",\n    \"name\": \"Tony Stark\",\n    \"email\": \"tstark@avengers.com\",\n    \"document\": \"26224451990\",\n    \"description\": \"Recebedor Tony Stark\",\n    \"type\": \"individual\",\n    \"status\": \"active\",\n    \"created_at\": \"2017-10-27T16:12:37Z\",\n    \"updated_at\": \"2017-10-27T16:12:37Z\",\n    \"default_bank_account\": {\n        \"id\": \"ba_KOoYDmEHvIEYD6v3\",\n        \"holder_name\": \"Tony Stark\",\n        \"holder_type\": \"individual\",\n        \"holder_document\": \"26224451990\",\n        \"bank\": \"341\",\n        \"branch_number\": \"1234\",\n        \"branch_check_digit\": \"6\",\n        \"account_number\": \"12345\",\n        \"account_check_digit\": \"6\",\n        \"type\": \"checking\",\n        \"status\": \"active\",\n        \"created_at\": \"2017-10-27T19:03:21Z\",\n        \"updated_at\": \"2017-10-27T19:03:21Z\",\n        \"metadata\": {\n            \"meta_key\": \"meta_value\"\n        }\n    },\n    \"gateway_recipients\": [\n        {\n            \"gateway\": \"pagarme\",\n            \"status\": \"active\",\n            \"pgid\": \"re_cj9a3j9ok01275g6emauxwla8\",\n            \"createdAt\": \"2017-10-27T16:12:38Z\",\n            \"updatedAt\": \"2017-10-27T16:12:38Z\"\n        }\n    ],\n    \"metadata\": {\n        \"key\": \"value\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "rp_Gxb5NJNiqvf0Y5Xv"
                    },
                    "name": {
                      "type": "string",
                      "example": "Tony Stark"
                    },
                    "email": {
                      "type": "string",
                      "example": "tstark@avengers.com"
                    },
                    "document": {
                      "type": "string",
                      "example": "26224451990"
                    },
                    "description": {
                      "type": "string",
                      "example": "Recebedor Tony Stark"
                    },
                    "type": {
                      "type": "string",
                      "example": "individual"
                    },
                    "status": {
                      "type": "string",
                      "example": "active"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-10-27T16:12:37Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-10-27T16:12:37Z"
                    },
                    "default_bank_account": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "ba_KOoYDmEHvIEYD6v3"
                        },
                        "holder_name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "holder_type": {
                          "type": "string",
                          "example": "individual"
                        },
                        "holder_document": {
                          "type": "string",
                          "example": "26224451990"
                        },
                        "bank": {
                          "type": "string",
                          "example": "341"
                        },
                        "branch_number": {
                          "type": "string",
                          "example": "1234"
                        },
                        "branch_check_digit": {
                          "type": "string",
                          "example": "6"
                        },
                        "account_number": {
                          "type": "string",
                          "example": "12345"
                        },
                        "account_check_digit": {
                          "type": "string",
                          "example": "6"
                        },
                        "type": {
                          "type": "string",
                          "example": "checking"
                        },
                        "status": {
                          "type": "string",
                          "example": "active"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-10-27T19:03:21Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-10-27T19:03:21Z"
                        },
                        "metadata": {
                          "type": "object",
                          "properties": {
                            "meta_key": {
                              "type": "string",
                              "example": "meta_value"
                            }
                          }
                        }
                      }
                    },
                    "gateway_recipients": {
                      "type": "array",
                      "items": {
                        "type": "object",
                        "properties": {
                          "gateway": {
                            "type": "string",
                            "example": "pagarme"
                          },
                          "status": {
                            "type": "string",
                            "example": "active"
                          },
                          "pgid": {
                            "type": "string",
                            "example": "re_cj9a3j9ok01275g6emauxwla8"
                          },
                          "createdAt": {
                            "type": "string",
                            "example": "2017-10-27T16:12:38Z"
                          },
                          "updatedAt": {
                            "type": "string",
                            "example": "2017-10-27T16:12:38Z"
                          }
                        }
                      }
                    },
                    "metadata": {
                      "type": "object",
                      "properties": {
                        "key": {
                          "type": "string",
                          "example": "value"
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
                    "value": "{}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {}
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