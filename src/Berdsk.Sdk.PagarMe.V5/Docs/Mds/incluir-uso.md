# Incluir uso

Este recurso permite incluir um `usage` de um `items` associado a uma `subscription`.

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
      "post": {
        "summary": "Incluir uso",
        "description": "Este recurso permite incluir um `usage` de um `items` associado a uma `subscription`.",
        "operationId": "incluir-uso",
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
                  "quantity": {
                    "type": "integer",
                    "description": "Quantidade de usos a serem incluÃ­dos.",
                    "default": 1,
                    "format": "int32"
                  },
                  "description": {
                    "type": "string",
                    "description": "DescriÃ§Ã£o do uso."
                  },
                  "code": {
                    "type": "string",
                    "description": "CÃ³digo de identificaÃ§Ã£o no sistema do cliente"
                  },
                  "group": {
                    "type": "string",
                    "description": "CÃ³digo de identificaÃ§Ã£o do grupo no sistema do cliente"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "quantity": 50
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
                    "value": "{\n  \"id\": \"usage_QV1gBLhalU35RNbx\",\n  \"quantity\": 1,\n  \"status\": \"active\",\n  \"used_at\": \"2017-04-04T18:21:50Z\",\n  \"created_at\": \"2017-04-04T18:21:50Z\",\n  \"subscription_item\": {\n    \"id\": \"si_EJ8lP61Cotbyz9jx\",\n    \"description\": \"Bola\",\n    \"quantity\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2017-04-04T18:21:18Z\",\n    \"updated_at\": \"2017-04-04T18:21:18Z\",\n    \"subscription\": {\n      \"id\": \"sub_o0Jw4WYCMuPNqzGr\",\n      \"code\": \"09NFPLBZY0\",\n      \"start_at\": \"2017-04-04T00:00:00Z\",\n      \"interval\": \"month\",\n      \"interval_count\": 1,\n      \"billing_type\": \"postpaid\",\n      \"next_billing_at\": \"2017-05-04T00:00:00Z\",\n      \"payment_method\": \"credit_card\",\n      \"currency\": \"BRL\",\n      \"statement_descriptor\": \"Spotify\",\n      \"installments\": 1,\n      \"status\": \"active\",\n      \"created_at\": \"2017-04-04T18:21:17Z\",\n      \"updated_at\": \"2017-04-04T18:21:17Z\"\n    }\n  }\n}"
                  }
                },
                "schema": {
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
                      "example": "active"
                    },
                    "used_at": {
                      "type": "string",
                      "example": "2017-04-04T18:21:50Z"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-04T18:21:50Z"
                    },
                    "subscription_item": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "si_EJ8lP61Cotbyz9jx"
                        },
                        "description": {
                          "type": "string",
                          "example": "Bola"
                        },
                        "quantity": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
                        },
                        "status": {
                          "type": "string",
                          "example": "active"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-04-04T18:21:18Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-04T18:21:18Z"
                        },
                        "subscription": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "sub_o0Jw4WYCMuPNqzGr"
                            },
                            "code": {
                              "type": "string",
                              "example": "09NFPLBZY0"
                            },
                            "start_at": {
                              "type": "string",
                              "example": "2017-04-04T00:00:00Z"
                            },
                            "interval": {
                              "type": "string",
                              "example": "month"
                            },
                            "interval_count": {
                              "type": "integer",
                              "example": 1,
                              "default": 0
                            },
                            "billing_type": {
                              "type": "string",
                              "example": "postpaid"
                            },
                            "next_billing_at": {
                              "type": "string",
                              "example": "2017-05-04T00:00:00Z"
                            },
                            "payment_method": {
                              "type": "string",
                              "example": "credit_card"
                            },
                            "currency": {
                              "type": "string",
                              "example": "BRL"
                            },
                            "statement_descriptor": {
                              "type": "string",
                              "example": "Spotify"
                            },
                            "installments": {
                              "type": "integer",
                              "example": 1,
                              "default": 0
                            },
                            "status": {
                              "type": "string",
                              "example": "active"
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2017-04-04T18:21:17Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2017-04-04T18:21:17Z"
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
          "404": {
            "description": "404",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"message\": \"Item not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Item not found."
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