# Editar data de vencimento da cobranÃ§a

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
    "/charges/{charge_id}/due-date": {
      "patch": {
        "summary": "Editar data de vencimento da cobranÃ§a",
        "description": "",
        "operationId": "editar-data-de-vencimento-da-cobranÃ§a",
        "parameters": [
          {
            "name": "charge_id",
            "in": "path",
            "description": "CÃ³digo da cobranÃ§a.",
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
                  "due_at"
                ],
                "properties": {
                  "due_at": {
                    "type": "string",
                    "description": "Data de vencimento.",
                    "format": "date"
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
                    "value": "{\n  \"id\": \"ch_9R6419s6Btvp4ykO\",\n  \"code\": \"R8VI5WU79R\",\n  \"gateway_id\": \"efda8d57-50d8-4b19-b2d4-873bee2e1b62\",\n  \"amount\": 14900000,\n  \"status\": \"pending\",\n  \"currency\": \"BRL\",\n  \"payment_method\": \"boleto\",\n  \"due_at\": \"2017-04-04T00:00:00\",\n  \"created_at\": \"2017-04-04T21:34:32\",\n  \"updated_at\": \"2017-04-04T21:44:05\",\n  \"customer\": {\n    \"id\": \"cus_aEkwKv0SmNHMR931\",\n    \"name\": \"Luke Skywalker\",\n    \"email\": \"lskywalker@r2d2.com\",\n    \"delinquent\": false,\n    \"created_at\": \"2017-04-04T19:41:31\",\n    \"updated_at\": \"2017-04-04T19:41:31\"\n  },\n  \"last_transaction\": {\n    \"id\": \"tran_E3r7OrMh3hbjvwKj\",\n    \"transaction_type\": \"boleto\",\n    \"gateway_id\": \"19372a76-a8de-4017-aa91-8c9d21c34185\",\n    \"amount\": 14900000,\n    \"status\": \"generated\",\n    \"success\": true,\n    \"url\": \"https://sandbox.pagar.me/Boleto/ViewBoleto.aspx?19372a76-a8de-4017-aa91-8c9d21c34185\",\n    \"pdf\": \"https://api.pagar.me/core/v1.0/transactions/tran_E3r7OrMh3hbjvwKj/pdf\",\n    \"line\": \"34191.75009 03073.581237 41234.510000 2 71240014900000\",\n    \"barcode\": \"https://api.pagar.me/core/v1.0/transactions/tran_E3r7OrMh3hbjvwKj/barcode\",\n    \"qr_code\": \"https://api.pagar.me/core/v1.0/transactions/tran_E3r7OrMh3hbjvwKj/qrcode\",\n    \"nosso_numero\": \"00030735\",\n    \"bank\": \"001\",\n    \"document_number\": \"094408333\",\n    \"created_at\": \"2017-04-04T21:44:05\",\n    \"updated_at\": \"2017-04-04T21:44:05\"\n  },\n  \"metadata\": {\n    \"id\": \"my_charge_id\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "ch_9R6419s6Btvp4ykO"
                    },
                    "code": {
                      "type": "string",
                      "example": "R8VI5WU79R"
                    },
                    "gateway_id": {
                      "type": "string",
                      "example": "efda8d57-50d8-4b19-b2d4-873bee2e1b62"
                    },
                    "amount": {
                      "type": "integer",
                      "example": 14900000,
                      "default": 0
                    },
                    "status": {
                      "type": "string",
                      "example": "pending"
                    },
                    "currency": {
                      "type": "string",
                      "example": "BRL"
                    },
                    "payment_method": {
                      "type": "string",
                      "example": "boleto"
                    },
                    "due_at": {
                      "type": "string",
                      "example": "2017-04-04T00:00:00"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-04T21:34:32"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-04-04T21:44:05"
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
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-04-04T19:41:31"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-04T19:41:31"
                        }
                      }
                    },
                    "last_transaction": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "tran_E3r7OrMh3hbjvwKj"
                        },
                        "transaction_type": {
                          "type": "string",
                          "example": "boleto"
                        },
                        "gateway_id": {
                          "type": "string",
                          "example": "19372a76-a8de-4017-aa91-8c9d21c34185"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 14900000,
                          "default": 0
                        },
                        "status": {
                          "type": "string",
                          "example": "generated"
                        },
                        "success": {
                          "type": "boolean",
                          "example": true,
                          "default": true
                        },
                        "url": {
                          "type": "string",
                          "example": "https://sandbox.pagar.me/Boleto/ViewBoleto.aspx?19372a76-a8de-4017-aa91-8c9d21c34185"
                        },
                        "pdf": {
                          "type": "string",
                          "example": "https://api.pagar.me/core/v1.0/transactions/tran_E3r7OrMh3hbjvwKj/pdf"
                        },
                        "line": {
                          "type": "string",
                          "example": "34191.75009 03073.581237 41234.510000 2 71240014900000"
                        },
                        "barcode": {
                          "type": "string",
                          "example": "https://api.pagar.me/core/v1.0/transactions/tran_E3r7OrMh3hbjvwKj/barcode"
                        },
                        "qr_code": {
                          "type": "string",
                          "example": "https://api.pagar.me/core/v1.0/transactions/tran_E3r7OrMh3hbjvwKj/qrcode"
                        },
                        "nosso_numero": {
                          "type": "string",
                          "example": "00030735"
                        },
                        "bank": {
                          "type": "string",
                          "example": "001"
                        },
                        "document_number": {
                          "type": "string",
                          "example": "094408333"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-04-04T21:44:05"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-04T21:44:05"
                        }
                      }
                    },
                    "metadata": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "my_charge_id"
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