# Lista disputas de chargeback

Retorna uma lista paginada de disputas com base nos filtros fornecidos.

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
    "/v1/disputes": {
      "get": {
        "summary": "Lista disputas de chargeback",
        "tags": [
          "Disputas"
        ],
        "description": "Retorna uma lista paginada de disputas com base nos filtros fornecidos.",
        "parameters": [
          {
            "name": "createdAt__lte",
            "in": "query",
            "description": "Filtrar valores menores ou iguais Ã  data fornecida.",
            "schema": {
              "type": "string",
              "format": "date-time",
              "example": "2026-02-26T20:02:18"
            }
          },
          {
            "name": "createdAt__gte",
            "in": "query",
            "description": "Filtrar valores maiores ou iguais Ã  data fornecida.",
            "schema": {
              "type": "string",
              "format": "date-time",
              "example": "2026-02-26T20:02:18"
            }
          },
          {
            "name": "status",
            "in": "query",
            "description": "Filtra pelo status da disputa.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "reason.code",
            "in": "query",
            "description": "Filtra pelo cÃ³digo do motivo do chargeback.",
            "schema": {
              "type": "integer"
            }
          },
          {
            "name": "network",
            "in": "query",
            "description": "Filtra pela bandeira do cartÃ£o.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "forwardCursor",
            "in": "query",
            "description": "Identificador para avanÃ§ar na paginaÃ§Ã£o.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "limit",
            "in": "query",
            "description": "NÃºmero mÃ¡ximo de registros a serem retornados.",
            "schema": {
              "type": "integer",
              "default": 5,
              "maximum": 100
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Lista de disputas retornada com sucesso.",
            "content": {
              "application/json": {
                "schema": {
                  "type": "object",
                  "properties": {
                    "data": {
                      "type": "array",
                      "items": {
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
                      }
                    },
                    "page": {
                      "type": "object",
                      "properties": {
                        "forwardCursor": {
                          "type": "string",
                          "nullable": true,
                          "description": "Identificador para o inicio da prÃ³xima pÃ¡gina."
                        }
                      }
                    }
                  }
                },
                "examples": {
                  "default": {
                    "summary": "Exemplo de listagem de disputas",
                    "value": {
                      "data": [
                        {
                          "disputeId": 12345,
                          "transactionId": 67890,
                          "createdAt": "2026-02-20T14:30:00Z",
                          "updatedAt": "2026-02-22T10:15:00Z",
                          "responseDeadline": "2026-03-05T23:59:59Z",
                          "chargebackAmount": {
                            "amount": "150.47",
                            "currencyCode": "BRL"
                          },
                          "debitedAmount": {
                            "amount": "150.47",
                            "currencyCode": "BRL"
                          },
                          "status": "WAITING_MERCHANT_EVIDENCES",
                          "reason": {
                            "code": "4853",
                            "description": "FRAUD"
                          },
                          "stage": "CHARGEBACK",
                          "network": "VISA",
                          "institution": "STONE",
                          "events": [
                            {
                              "type": "FIRST_CHARGEBACK",
                              "createdAt": "2026-02-20T14:30:00Z"
                            },
                            {
                              "type": "DISPUTE_NOTIFIED",
                              "createdAt": "2026-02-20T14:35:00Z"
                            }
                          ]
                        }
                      ],
                      "page": {
                        "forwardCursor": "eyJpZCI6MTIzNDV9"
                      }
                    }
                  }
                }
              }
            }
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