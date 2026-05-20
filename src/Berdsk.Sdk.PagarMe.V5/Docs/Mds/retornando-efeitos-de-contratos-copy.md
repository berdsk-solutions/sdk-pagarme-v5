# Retornando Contratos

| Campo           | DescriÃ§Ã£o                       |
|:----------------|:--------------------------------|
| Key             | Chave do contrato (contractKey) |
| contractHolder  | Credor                          |
| contractType    | Tipo de contrato                |
| isCanceled      | Ativo                           |
| createdAt       | Data da criaÃ§Ã£o                 |
| bankAccount     | DomicÃ­lio BancÃ¡rio              |
| tradeRepository | Registradora do credor          |
| PaymentScheme   | Arranjo de pagamento            |

# OpenAPI definition

```json
{
  "openapi": "3.1.0",
  "info": {
    "title": "pagarme-api-register-v5",
    "version": "5"
  },
  "servers": [
    {
      "url": "https://api.pagar.me/register/v5"
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
    "/settlement_obligations/contracts": {
      "get": {
        "summary": "Retornando Contratos",
        "description": "",
        "operationId": "retornando-efeitos-de-contratos-copy",
        "parameters": [
          {
            "name": "recipient_id",
            "in": "query",
            "description": "ID de recebedor desejado",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "expected_settlement_date_since",
            "in": "query",
            "description": "Data inicial da consulta",
            "required": true,
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "expected_settlement_date_until",
            "in": "query",
            "description": "Data final da consulta",
            "required": true,
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
                    "value": "[\n    {\n        \"key\": \"016546874e-9571-9rt7-b789-1161r16r1618\",\n        \"contract_type\": \"OwnershipAssignment\",\n        \"created_at\": \"2023-09-01T18:23:00.867373Z\",\n        \"is_canceled\": false,\n        \"contract_holder\": \"20898464000024\",\n        \"bank_accounts\": [\n            {\n                \"branch\": \"0011\",\n                \"account\": \"018757\",\n                \"account_digit\": \"9\",\n                \"account_type\": \"CC\",\n                \"ispb\": \"012678971\",\n                \"document_type\": \"CNPJ\",\n                \"document_number\": \"20898464000024\"\n            }\n        ],\n        \"trade_repository\": \"310258107000093\"\n    }\n]"
                  }
                },
                "schema": {
                  "type": "array",
                  "items": {
                    "type": "object",
                    "properties": {
                      "key": {
                        "type": "string",
                        "example": "016546874e-9571-9rt7-b789-1161r16r1618"
                      },
                      "contract_type": {
                        "type": "string",
                        "example": "OwnershipAssignment"
                      },
                      "created_at": {
                        "type": "string",
                        "example": "2023-09-01T18:23:00.867373Z"
                      },
                      "is_canceled": {
                        "type": "boolean",
                        "example": false,
                        "default": true
                      },
                      "contract_holder": {
                        "type": "string",
                        "example": "20898464000024"
                      },
                      "bank_accounts": {
                        "type": "array",
                        "items": {
                          "type": "object",
                          "properties": {
                            "branch": {
                              "type": "string",
                              "example": "0011"
                            },
                            "account": {
                              "type": "string",
                              "example": "018757"
                            },
                            "account_digit": {
                              "type": "string",
                              "example": "9"
                            },
                            "account_type": {
                              "type": "string",
                              "example": "CC"
                            },
                            "ispb": {
                              "type": "string",
                              "example": "012678971"
                            },
                            "document_type": {
                              "type": "string",
                              "example": "CNPJ"
                            },
                            "document_number": {
                              "type": "string",
                              "example": "20898464000024"
                            }
                          }
                        }
                      },
                      "trade_repository": {
                        "type": "string",
                        "example": "310258107000093"
                      }
                    }
                  }
                }
              }
            }
          },
          "204": {
            "description": "204",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n  message: \"No content\"\n}"
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
                    "value": "{\n  message: \"recipient not found\"\n}"
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