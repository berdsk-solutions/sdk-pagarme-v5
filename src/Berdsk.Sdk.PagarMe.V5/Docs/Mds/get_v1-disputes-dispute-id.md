# Consulta uma disputa especÃ­fica

# OpenAPI definition

```json
{
  "openapi": "3.0.3",
  "info": {
    "title": "Disputas",
    "version": "v2026-02-01",
    "description": "Chargeback API"
  },
  "servers": [
    {
      "url": "https://api.stone.com.br",
      "description": "production"
    },
    {
      "url": "https://sandbox.api.stone.com.br",
      "description": "sandbox"
    }
  ],
  "tags": [
    {
      "name": "Disputas",
      "description": "Operações relacionadas Ã  busca de disputas de chargeback. Aqui Ã© possÃ­vel ver o estado atual da disputa, histÃ³rico de eventos daquela disputa, dentre outras informações relevantes."
    }
  ],
  "paths": {
    "/v1/disputes/{dispute_id}": {
      "get": {
        "summary": "Consulta uma disputa especÃ­fica",
        "tags": [
          "Disputas"
        ],
        "parameters": [
          {
            "name": "dispute_id",
            "in": "path",
            "required": true,
            "description": "ID Ãºnico da disputa.",
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Detalhes da disputa encontrados.",
            "content": {
              "application/json": {
                "schema": {
                  "type": "object",
                  "properties": {
                    "disputeId": {
                      "type": "integer",
                      "description": "ID Ãºnico da disputa."
                    },
                    "transactionId": {
                      "type": "integer",
                      "description": "ID da transaÃ§Ã£o associada Ã  disputa."
                    },
                    "createdAt": {
                      "type": "string",
                      "format": "date-time",
                      "description": "Data da criaÃ§Ã£o da disputa."
                    },
                    "updatedAt": {
                      "type": "string",
                      "format": "date-time",
                      "description": "Data da Ãºltima atualizaÃ§Ã£o da disputa."
                    },
                    "responseDeadline": {
                      "type": "string",
                      "format": "date-time",
                      "description": "Data limite para o envio de evidÃªncias por parte do lojista."
                    },
                    "chargebackAmount": {
                      "type": "object",
                      "description": "Valor do chargeback.",
                      "properties": {
                        "amount": {
                          "type": "string",
                          "example": "150.47"
                        },
                        "currencyCode": {
                          "type": "string",
                          "example": "BRL"
                        }
                      }
                    },
                    "debitedAmount": {
                      "type": "object",
                      "description": "Valor debitado do lojista.",
                      "properties": {
                        "amount": {
                          "type": "string",
                          "example": "150.47"
                        },
                        "currencyCode": {
                          "type": "string",
                          "example": "BRL"
                        }
                      }
                    },
                    "status": {
                      "type": "string",
                      "enum": [
                        "WAITING_MERCHANT_EVIDENCES",
                        "WAITING_ACQUIRER_ANALYSIS",
                        "MERCHANT_EVIDENCE_DEADLINE_EXPIRED",
                        "WAITING_ISSUER",
                        "LOST",
                        "WON",
                        "DEADLINE_EXPIRED"
                      ],
                      "description": "Status atual da disputa."
                    },
                    "reason": {
                      "type": "object",
                      "description": "Motivo do pedido de chargeback.",
                      "properties": {
                        "code": {
                          "type": "string",
                          "description": "CÃ³digo do motivo do chargeback."
                        },
                        "description": {
                          "type": "string",
                          "enum": [
                            "FRAUD",
                            "PROCESSING_ERROR",
                            "COMMERCIAL_DISPUTE",
                            "AUTHORIZATION"
                          ],
                          "description": "DescriÃ§Ã£o do motivo do chargeback."
                        }
                      }
                    },
                    "stage": {
                      "type": "string",
                      "description": "EstÃ¡gio do ciclo de chargeback."
                    },
                    "network": {
                      "type": "string",
                      "description": "Bandeira do cartÃ£o."
                    },
                    "institution": {
                      "type": "string",
                      "enum": [
                        "STONE",
                        "PAGAR.ME"
                      ],
                      "description": "InstituiÃ§Ã£o onde a transaÃ§Ã£o foi processado."
                    },
                    "events": {
                      "type": "array",
                      "description": "Lista de eventos relacionados Ã  disputa.",
                      "items": {
                        "type": "object",
                        "properties": {
                          "type": {
                            "type": "string",
                            "enum": [
                              "FIRST_CHARGEBACK",
                              "DISPUTE_NOTIFIED",
                              "MERCHANT_EVIDENCE_RECEIVED",
                              "EVIDENCE_ANALYSIS_ACCEPTED",
                              "EVIDENCE_ANALYSIS_DENIED",
                              "LOST_DISPUTE"
                            ],
                            "description": "Tipo do evento relacionado Ã  disputa."
                          },
                          "createdAt": {
                            "type": "string",
                            "format": "date-time",
                            "description": "Data da criaÃ§Ã£o do evento."
                          }
                        }
                      }
                    }
                  }
                },
                "examples": {
                  "default": {
                    "summary": "Exemplo de uma disputa",
                    "value": {
                      "disputeId": 12345,
                      "transactionId": 67890,
                      "createdAt": "2026-02-20T14:30:00Z",
                      "updatedAt": "2026-02-25T09:00:00Z",
                      "responseDeadline": "2026-03-05T23:59:59Z",
                      "chargebackAmount": {
                        "amount": "250.00",
                        "currencyCode": "BRL"
                      },
                      "debitedAmount": {
                        "amount": "250.00",
                        "currencyCode": "BRL"
                      },
                      "status": "WON",
                      "reason": {
                        "code": "4837",
                        "description": "COMMERCIAL_DISPUTE"
                      },
                      "stage": "CHARGEBACK",
                      "network": "MASTERCARD",
                      "institution": "PAGAR.ME",
                      "events": [
                        {
                          "type": "FIRST_CHARGEBACK",
                          "createdAt": "2026-02-20T14:30:00Z"
                        },
                        {
                          "type": "DISPUTE_NOTIFIED",
                          "createdAt": "2026-02-20T14:35:00Z"
                        },
                        {
                          "type": "MERCHANT_EVIDENCE_RECEIVED",
                          "createdAt": "2026-02-22T11:00:00Z"
                        },
                        {
                          "type": "EVIDENCE_ANALYSIS_ACCEPTED",
                          "createdAt": "2026-02-25T09:00:00Z"
                        }
                      ]
                    }
                  }
                }
              }
            }
          },
          "404": {
            "description": "Disputa nÃ£o encontrada."
          }
        }
      }
    }
  },
  "components": {
    "securitySchemes": {
      "sec0": {
        "type": "http",
        "scheme": "basic"
      }
    }
  },
  "x-readme": {},
  "security": [
    {
      "sec0": []
    }
  ]
}
```