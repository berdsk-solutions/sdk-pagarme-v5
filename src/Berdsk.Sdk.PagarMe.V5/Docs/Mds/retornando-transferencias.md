# Retornando transferÃªncias

Retorna os dados de todas as transferÃªncias previamente realizadas.

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
      "get": {
        "summary": "Retornando transferÃªncias",
        "description": "Retorna os dados de todas as transferÃªncias previamente realizadas.",
        "operationId": "retornando-transferÃªncias",
        "parameters": [
          {
            "name": "count",
            "in": "query",
            "description": "Retorna n resultados, com um mÃ¡ximo de 1000",
            "schema": {
              "type": "string",
              "default": "10"
            }
          },
          {
            "name": "cursor",
            "in": "query",
            "description": "Ãštil para implementaÃ§Ã£o de uma paginaÃ§Ã£o de resultados, permitindo a troca de pÃ¡ginas utilizando `x-cursor-nextpage` ou `x-cursor-previouspage`.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cursor-nextpage",
            "in": "query",
            "description": "Retornado nos headers da resposta contÃ©m o Token que permite acesso a prÃ³xima pÃ¡gina.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cursor-previouspage",
            "in": "query",
            "description": "Retornado nos headers da resposta contÃ©m o Token que permite acesso a pÃ¡gina anterior.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "bank_account_id",
            "in": "query",
            "description": "Filtro de bank account id",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "amount",
            "in": "query",
            "description": "Filtro de amount",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "recipient_id",
            "in": "query",
            "description": "Filtro de recipient id",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "id",
            "in": "query",
            "description": "ID da transferÃªncia procurada",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "date_created",
            "in": "query",
            "description": "Filtro de data da criaÃ§Ã£o da transferÃªncia",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "created_at",
            "in": "query",
            "description": "Mesmo que date_created",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "status",
            "in": "query",
            "description": "Filtro para um dos status: pending_transfer, transferred, failed, processing, canceled",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "date_updated",
            "in": "query",
            "description": "Filtro para data de Ãºltimo update",
            "schema": {
              "type": "string",
              "format": "date"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "200",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "[\n  {\n    \"object\": \"transfer\",\n    \"id\": 65485,\n    \"amount\": 100,\n    \"type\": \"ted\",\n    \"status\": \"pending_transfer\",\n    \"source_type\": \"recipient\",\n    \"source_id\": \"re_cix7pxz6f02ppcv6dn4ckcrcc\",\n    \"target_type\": \"bank_account\",\n    \"target_id\": \"17346045\",\n    \"fee\": 367,\n    \"funding_date\": null,\n    \"funding_estimated_date\": \"2017-02-18T02:00:00.000Z\",\n    \"transaction_id\": null,\n    \"date_created\": \"2017-02-17T16:24:20.933Z\",\n    \"bank_response\": null,\n    \"bank_account\": {\n      \"object\": \"bank_account\",\n      \"id\": 17346045,\n      \"bank_code\": \"000\",\n      \"agencia\": \"00000\",\n      \"agencia_dv\": \"2\",\n      \"conta\": \"00000\",\n      \"conta_dv\": \"00\",\n      \"type\": \"conta_corrente\",\n      \"document_type\": \"cpf\",\n      \"document_number\": \"03602396681\",\n      \"legal_name\": \"nome2\",\n      \"charge_transfer_fees\": true,\n      \"date_created\": \"2016-12-27T22:08:10.536Z\"\n    },\n    \"metadata\": {\n      \"idProduto\": \"13933139\"\n    }\n  },\n  {\n    \"object\": \"transfer\",\n    \"id\": 65482,\n    \"amount\": 1000,\n    \"type\": \"ted\",\n    \"status\": \"pending_transfer\",\n    \"source_type\": \"recipient\",\n    \"source_id\": \"re_ciu4jif1j007td56dsm17yew9\",\n    \"target_type\": \"bank_account\",\n    \"target_id\": \"17298390\",\n    \"fee\": 367,\n    \"funding_date\": null,\n    \"funding_estimated_date\": \"2017-02-18T02:00:00.000Z\",\n    \"transaction_id\": null,\n    \"date_created\": \"2017-02-17T16:16:03.044Z\",\n    \"bank_response\": null,\n    \"bank_account\": {\n      \"object\": \"bank_account\",\n      \"id\": 17298390,\n      \"bank_code\": \"000\",\n      \"agencia\": \"0000\",\n      \"agencia_dv\": null,\n      \"conta\": \"00000\",\n      \"conta_dv\": \"0\",\n      \"type\": \"conta_corrente\",\n      \"document_type\": \"cnpj\",\n      \"document_number\": \"00000000000000\",\n      \"legal_name\": \"CONTA BANCARIA DE TESTES\",\n      \"charge_transfer_fees\": true,\n      \"date_created\": \"2016-10-10T20:57:40.506Z\"\n    },\n    \"metadata\": {\n      \"idProduto\": \"13933140\"\n    }\n  },\n  {\n    \"object\": \"transfer\",\n    \"id\": 65481,\n    \"amount\": 1000,\n    \"type\": \"ted\",\n    \"status\": \"pending_transfer\",\n    \"source_type\": \"recipient\",\n    \"source_id\": \"re_ciu4jif1j007td56dsm17yew9\",\n    \"target_type\": \"bank_account\",\n    \"target_id\": \"17298390\",\n    \"fee\": 367,\n    \"funding_date\": null,\n    \"funding_estimated_date\": \"2017-02-18T02:00:00.000Z\",\n    \"transaction_id\": null,\n    \"date_created\": \"2017-02-17T16:15:54.089Z\",\n    \"bank_response\": null,\n    \"bank_account\": {\n      \"object\": \"bank_account\",\n      \"id\": 17298390,\n      \"bank_code\": \"000\",\n      \"agencia\": \"0000\",\n      \"agencia_dv\": null,\n      \"conta\": \"00000\",\n      \"conta_dv\": \"0\",\n      \"type\": \"conta_corrente\",\n      \"document_type\": \"cnpj\",\n      \"document_number\": \"00000000000000\",\n      \"legal_name\": \"CONTA BANCARIA DE TESTES\",\n      \"charge_transfer_fees\": true,\n      \"date_created\": \"2016-10-10T20:57:40.506Z\"\n    },\n    \"metadata\": {\n      \"idProduto\": \"13933141\"\n    }\n  }\n]"
                  }
                },
                "schema": {
                  "type": "array",
                  "items": {
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
                      "bank_response": {},
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