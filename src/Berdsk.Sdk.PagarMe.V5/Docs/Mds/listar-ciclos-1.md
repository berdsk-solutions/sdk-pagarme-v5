# Listar ciclos

Este recurso permite listar os ciclos associados a uma assinatura. Podem ser utilizados alguns parÃ¢metros como filtro da
listagem.

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
    "/subscriptions/{subscription_id}/cycles": {
      "get": {
        "summary": "Listar ciclos",
        "description": "Este recurso permite listar os ciclos associados a uma assinatura. Podem ser utilizados alguns parÃ¢metros como filtro da listagem.",
        "operationId": "listar-ciclos-1",
        "parameters": [
          {
            "name": "subscription_id",
            "in": "path",
            "description": "CÃ³digo da assinatura.",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "id",
            "in": "query",
            "description": "_CÃ³digo do ciclo_. Formato: `cycle_XXXXXXXXXXXXXXXX`.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "billing_at",
            "in": "query",
            "description": "Data de cobranÃ§a do ciclo",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "cycle",
            "in": "query",
            "description": "Quantidade de ciclos na assinatura",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "start_at",
            "in": "query",
            "description": "Data de inÃ­cio do ciclo",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "end_at",
            "in": "query",
            "description": "Data final do ciclo",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "duration",
            "in": "query",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "created_at",
            "in": "query",
            "description": "Data de criaÃ§Ã£o da assinatura",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "updated_at",
            "in": "query",
            "description": "Data de atualizaÃ§Ã£o do ciclo da assinatura.",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "status",
            "in": "query",
            "description": "Status dos ciclos. Valores possÃ­veis: **billed** ou **unbilled**",
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
                    "value": "{\n    \"data\": [\n        {\n            \"id\": \"cycle_Qal5a0LCpphoDpnR\",\n            \"billing_at\": \"2019-04-30T00:00:00Z\",\n            \"cycle\": 1,\n            \"start_at\": \"2019-04-30T00:00:00Z\",\n            \"end_at\": \"2019-07-29T23:59:59Z\",\n            \"duration\": 7862399,\n            \"created_at\": \"2019-04-30T18:09:32Z\",\n            \"updated_at\": \"2019-04-30T18:09:33Z\",\n            \"status\": \"billed\"\n        }\n    ],\n    \"paging\": {\n        \"total\": 1\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "data": {
                      "type": "array",
                      "items": {
                        "type": "object",
                        "properties": {
                          "id": {
                            "type": "string",
                            "example": "cycle_Qal5a0LCpphoDpnR"
                          },
                          "billing_at": {
                            "type": "string",
                            "example": "2019-04-30T00:00:00Z"
                          },
                          "cycle": {
                            "type": "integer",
                            "example": 1,
                            "default": 0
                          },
                          "start_at": {
                            "type": "string",
                            "example": "2019-04-30T00:00:00Z"
                          },
                          "end_at": {
                            "type": "string",
                            "example": "2019-07-29T23:59:59Z"
                          },
                          "duration": {
                            "type": "integer",
                            "example": 7862399,
                            "default": 0
                          },
                          "created_at": {
                            "type": "string",
                            "example": "2019-04-30T18:09:32Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2019-04-30T18:09:33Z"
                          },
                          "status": {
                            "type": "string",
                            "example": "billed"
                          }
                        }
                      }
                    },
                    "paging": {
                      "type": "object",
                      "properties": {
                        "total": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
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