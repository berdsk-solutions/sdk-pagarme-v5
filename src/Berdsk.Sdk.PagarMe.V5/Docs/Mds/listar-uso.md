# Listar uso

Este recurso permite listar os usos de um item de assinatura.

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
    "/subscriptions/{subscription_id}/items/{item_id}/usages": {
      "get": {
        "summary": "Listar uso",
        "description": "Este recurso permite listar os usos de um item de assinatura.",
        "operationId": "listar-uso",
        "parameters": [
          {
            "name": "subscription_id",
            "in": "path",
            "description": "CÃ³digo da assinatura.<br>Formato: `sub_XXXXXXXXXXXXXXXX`.",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "item_id",
            "in": "path",
            "description": "CÃ³digo do item da assinatura.<br>Formato: `si_XXXXXXXXXXXXXXXX`.",
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
                "properties": {
                  "code": {
                    "type": "string",
                    "description": "CÃ³digo de identificaÃ§Ã£o no sistema do cliente"
                  },
                  "group": {
                    "type": "string",
                    "description": "CÃ³digo de identificaÃ§Ã£o do grupo no sistema do cliente"
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
                    "value": "{\n  \"data\": [\n    {\n      \"id\": \"usage_QV1gBLhalU35RNbx\",\n      \"quantity\": 1,\n      \"status\": \"deleted\",\n      \"used_at\": \"2017-04-04T18:21:50Z\",\n      \"created_at\": \"2017-04-04T18:21:50Z\",\n      \"deleted_at\": \"2017-04-04T18:25:08Z\"\n    },\n    {\n      \"id\": \"usage_73ybm1nCMfRVYdxA\",\n      \"quantity\": 1,\n      \"description\": \"Bola\",\n      \"status\": \"active\",\n      \"used_at\": \"2017-04-04T00:00:00Z\",\n      \"created_at\": \"2017-04-04T18:21:18Z\"\n    }\n  ],\n  \"paging\": {\n    \"total\": 2\n  }\n}"
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
                            "example": "usage_QV1gBLhalU35RNbx"
                          },
                          "quantity": {
                            "type": "integer",
                            "example": 1,
                            "default": 0
                          },
                          "status": {
                            "type": "string",
                            "example": "deleted"
                          },
                          "used_at": {
                            "type": "string",
                            "example": "2017-04-04T18:21:50Z"
                          },
                          "created_at": {
                            "type": "string",
                            "example": "2017-04-04T18:21:50Z"
                          },
                          "deleted_at": {
                            "type": "string",
                            "example": "2017-04-04T18:25:08Z"
                          }
                        }
                      }
                    },
                    "paging": {
                      "type": "object",
                      "properties": {
                        "total": {
                          "type": "integer",
                          "example": 2,
                          "default": 0
                        }
                      }
                    }
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
                  "item not found": {
                    "value": "{\n    \"message\": \"Item not found.\"\n}"
                  },
                  "subsciption not found": {
                    "value": "{\n  \"message\": \"Subscription not found.\"\n}"
                  }
                },
                "schema": {
                  "oneOf": [
                    {
                      "title": "item not found",
                      "type": "object",
                      "properties": {
                        "message": {
                          "type": "string",
                          "example": "Item not found."
                        }
                      }
                    },
                    {
                      "title": "subsciption not found",
                      "type": "object",
                      "properties": {
                        "message": {
                          "type": "string",
                          "example": "Subscription not found."
                        }
                      }
                    }
                  ]
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