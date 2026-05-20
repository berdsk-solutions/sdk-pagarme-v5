# Criando uma transferÃªncia

Realiza uma transferÃªncia para uma conta bancÃ¡ria previamente criada.

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
    "/transfers": {
      "post": {
        "summary": "Criando uma transferÃªncia",
        "description": "Realiza uma transferÃªncia para uma conta bancÃ¡ria previamente criada.",
        "operationId": "criando-uma-transferÃªncia",
        "parameters": [
          {
            "name": "Idempotency-Key",
            "in": "header",
            "description": "Valor Ãºnico que identifica a transaÃ§Ã£o para permitir uma nova tentativa de requisiÃ§Ã£o com a seguranÃ§a de que a mesma operaÃ§Ã£o nÃ£o serÃ¡ executada duas vezes acidentalmente.",
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
                  "amount"
                ],
                "properties": {
                  "amount": {
                    "type": "integer",
                    "description": "Valor, em centavos, a ser transferido para uma determinada conta bancÃ¡ria (valor precisa estar entre 1 e 2147483647)",
                    "format": "int32"
                  },
                  "recipient_id": {
                    "type": "string",
                    "description": "Indica que o valor da transferÃªncia sairÃ¡ da conta do recebedor identificado por este parâmetro. OBS: Caso o recipient_id seja passado, nÃ£o Ã© necessÃ¡rio passar bank_account_id"
                  },
                  "metadata": {
                    "type": "string",
                    "description": "VocÃª pode passar dados adicionais na criaÃ§Ã£o da transferÃªncia para facilitar uma futura anÃ¡lise de dados por seus sistemas.",
                    "format": "json"
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
                    "value": "{\n  \"object\": \"transfer\",\n  \"id\": 65485,\n  \"amount\": 100,\n  \"type\": \"ted\",\n  \"status\": \"pending_transfer\",\n  \"source_type\": \"recipient\",\n  \"source_id\": \"re_cix7pxz6f02ppcv6dn4ckcrcc\",\n  \"target_type\": \"bank_account\",\n  \"target_id\": \"17346045\",\n  \"fee\": 367,\n  \"funding_date\": null,\n  \"funding_estimated_date\": \"2017-02-18T02:00:00.000Z\",\n  \"transaction_id\": null,\n  \"date_created\": \"2017-02-17T16:24:20.933Z\",\n  \"bank_account\": {\n    \"object\": \"bank_account\",\n    \"id\": 17346045,\n    \"bank_code\": \"000\",\n    \"agencia\": \"00000\",\n    \"agencia_dv\": \"2\",\n    \"conta\": \"00000\",\n    \"conta_dv\": \"00\",\n    \"type\": \"conta_corrente\",\n    \"document_type\": \"cpf\",\n    \"document_number\": \"03602396681\",\n    \"legal_name\": \"nome2\",\n    \"charge_transfer_fees\": true,\n    \"date_created\": \"2016-12-27T22:08:10.536Z\"\n  },\n  \"metadata\": {\n    \"idProduto\": \"13933139\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "object": {
                      "type": "string",
                      "example": "transfer"
                    },
                    "id": {
                      "type": "integer",
                      "example": 65485,
                      "default": 0
                    },
                    "amount": {
                      "type": "integer",
                      "example": 100,
                      "default": 0
                    },
                    "type": {
                      "type": "string",
                      "example": "ted"
                    },
                    "status": {
                      "type": "string",
                      "example": "pending_transfer"
                    },
                    "source_type": {
                      "type": "string",
                      "example": "recipient"
                    },
                    "source_id": {
                      "type": "string",
                      "example": "re_cix7pxz6f02ppcv6dn4ckcrcc"
                    },
                    "target_type": {
                      "type": "string",
                      "example": "bank_account"
                    },
                    "target_id": {
                      "type": "string",
                      "example": "17346045"
                    },
                    "fee": {
                      "type": "integer",
                      "example": 367,
                      "default": 0
                    },
                    "funding_date": {},
                    "funding_estimated_date": {
                      "type": "string",
                      "example": "2017-02-18T02:00:00.000Z"
                    },
                    "transaction_id": {},
                    "date_created": {
                      "type": "string",
                      "example": "2017-02-17T16:24:20.933Z"
                    },
                    "bank_account": {
                      "type": "object",
                      "properties": {
                        "object": {
                          "type": "string",
                          "example": "bank_account"
                        },
                        "id": {
                          "type": "integer",
                          "example": 17346045,
                          "default": 0
                        },
                        "bank_code": {
                          "type": "string",
                          "example": "000"
                        },
                        "agencia": {
                          "type": "string",
                          "example": "00000"
                        },
                        "agencia_dv": {
                          "type": "string",
                          "example": "2"
                        },
                        "conta": {
                          "type": "string",
                          "example": "00000"
                        },
                        "conta_dv": {
                          "type": "string",
                          "example": "00"
                        },
                        "type": {
                          "type": "string",
                          "example": "conta_corrente"
                        },
                        "document_type": {
                          "type": "string",
                          "example": "cpf"
                        },
                        "document_number": {
                          "type": "string",
                          "example": "03602396681"
                        },
                        "legal_name": {
                          "type": "string",
                          "example": "nome2"
                        },
                        "charge_transfer_fees": {
                          "type": "boolean",
                          "example": true,
                          "default": true
                        },
                        "date_created": {
                          "type": "string",
                          "example": "2016-12-27T22:08:10.536Z"
                        }
                      }
                    },
                    "metadata": {
                      "type": "object",
                      "properties": {
                        "idProduto": {
                          "type": "string",
                          "example": "13933139"
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