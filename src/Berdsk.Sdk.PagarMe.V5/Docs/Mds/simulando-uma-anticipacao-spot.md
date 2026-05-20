# Simulando uma AntecipaÃ§Ã£o Spot

Obtem previsÃµes precisas sobre o valor a ser recebido, os custos envolvidos na operaÃ§Ã£o, e a data de pagamento. Para iniciar a simulaÃ§Ã£o da antecipaÃ§Ã£o, Ã© necessÃ¡rio utilizar a rota:

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
    "/recipients/{recipient_id}/bulk_anticipations/simulate": {
      "get": {
        "summary": "Simulando uma AntecipaÃ§Ã£o Spot",
        "description": "Obtem previsÃµes precisas sobre o valor a ser recebido, os custos envolvidos na operaÃ§Ã£o, e a data de pagamento. Para iniciar a simulaÃ§Ã£o da antecipaÃ§Ã£o, Ã© necessÃ¡rio utilizar a rota:",
        "operationId": "simulando-uma-antecipaÃ§Ã£o-spot",
        "parameters": [
          {
            "name": "recipient_id",
            "in": "path",
            "description": "ID do recebedor para o qual deseja simular a antecipaÃ§Ã£o.",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "timeframe",
            "in": "query",
            "description": "Define o perÃ­odo de onde os recebÃ­veis serÃ£o escolhidos para simulaÃ§Ã£o â€” ou seja, do inicio ou do fim da sua agenda de recebÃ­veis.",
            "required": true,
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "requested_amount",
            "in": "query",
            "description": "Valor lÃ­quido, em centavos, que vocÃª deseja receber na antecipaÃ§Ã£o, o valor deve estar entre o limite antecipÃ¡vel do recebedor. Caso queira consultar os limites antecipÃ¡veis utilize a rota /limits.",
            "required": true,
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          },
          {
            "name": "payment_date",
            "in": "query",
            "description": "Data que vocÃª deseja receber a antecipaÃ§Ã£o em sua conta Pagar.me. O parâmetro payment_date pode ser para qualquer dia no futuro e do dia atual atÃ© as 11h, caso jÃ¡ tenha passado desse horÃ¡rio, por favor adicione um payment_date para o prÃ³ximo dia Ãºtil. Data em string no formato ISO 8601",
            "required": true,
            "schema": {
              "type": "string"
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
                    "value": "{\n  \"amount\": 1000000,                \n  \"fee\": 20000,                   \n  \"fraudCoverageFee\": 0,      \n  \"anticipationAmount\": 900000,    \n  \"anticipationFee\": 80000,       \n  \"timeframe\": \"start\",              \n  \"paymentDate\": \"2025-08-10T00:00:00.000Z\",            \n  \"startIntervalDate\": \"2025-08-05T00:00:00.000Z\",\n  \"endIntervalDate\": \"2024-12-18T00:00:00.000Z\"    \n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "amount": {
                      "type": "integer",
                      "example": 1000000,
                      "default": 0
                    },
                    "fee": {
                      "type": "integer",
                      "example": 20000,
                      "default": 0
                    },
                    "fraudCoverageFee": {
                      "type": "integer",
                      "example": 0,
                      "default": 0
                    },
                    "anticipationAmount": {
                      "type": "integer",
                      "example": 900000,
                      "default": 0
                    },
                    "anticipationFee": {
                      "type": "integer",
                      "example": 80000,
                      "default": 0
                    },
                    "timeframe": {
                      "type": "string",
                      "example": "start"
                    },
                    "paymentDate": {
                      "type": "string",
                      "example": "2025-08-10T00:00:00.000Z"
                    },
                    "startIntervalDate": {
                      "type": "string",
                      "example": "2025-08-05T00:00:00.000Z"
                    },
                    "endIntervalDate": {
                      "type": "string",
                      "example": "2024-12-18T00:00:00.000Z"
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
                    "value": "{ \"errors\": [{ \"type\": \"invalid_parameter_error\", \"parameter_name\": \"payment_date\", \"message\": \"A data de pagamento deve ser um dia Ãºtil.\" }] }"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "errors": {
                      "type": "array",
                      "items": {
                        "type": "object",
                        "properties": {
                          "type": {
                            "type": "string",
                            "example": "invalid_parameter_error"
                          },
                          "parameter_name": {
                            "type": "string",
                            "example": "payment_date"
                          },
                          "message": {
                            "type": "string",
                            "example": "A data de pagamento deve ser um dia Ãºtil."
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