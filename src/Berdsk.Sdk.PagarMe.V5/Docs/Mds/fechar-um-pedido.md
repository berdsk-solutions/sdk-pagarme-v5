# Fechar um pedido

Utilizado para fechar um pedido para que nÃ£o seja mais possÃ­vel adicionar cobranÃ§as.

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
    "/orders/{order_id}/closed": {
      "patch": {
        "summary": "Fechar um pedido",
        "description": "Utilizado para fechar um pedido para que nÃ£o seja mais possÃ­vel adicionar cobranÃ§as.",
        "operationId": "fechar-um-pedido",
        "parameters": [
          {
            "name": "order_id",
            "in": "path",
            "description": "CÃ³digo do pedido.",
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
                  "status"
                ],
                "properties": {
                  "status": {
                    "type": "string",
                    "description": "Status final do pedido. Valores possÃ­veis: **paid**, **canceled** ou **failed**. Caso nÃ£o enviado, valor default serÃ¡ **paid**."
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
                    "value": "{\n  \"id\": \"or_koMvlQOTMCb9dpPO\",\n  \"code\": \"O8YDFPZUM3\",\n  \"amount\": 2990,\n  \"currency\": \"BRL\",\n  \"closed\": true,\n  \"items\": [\n    {\n      \"id\": \"oi_jkW1MBc9MtKdzK20\",\n      \"description\": \"Bolinho de feijoada\",\n      \"amount\": 2990,\n      \"quantity\": 1,\n      \"status\": \"active\",\n      \"created_at\": \"2017-06-06T16:03:41Z\",\n      \"updated_at\": \"2017-06-06T16:03:41Z\"\n    }\n  ],\n  \"customer\": {\n    \"id\": \"cus_mBloKMLnswtD4O3a\",\n    \"name\": \"Tony Stark\",\n    \"email\": \"avengerstark@ligadajustica.com.br\",\n    \"delinquent\": false,\n    \"created_at\": \"2016-10-07T19:50:39Z\",\n    \"updated_at\": \"2017-06-06T16:03:40Z\",\n    \"phones\": {},\n    \"metadata\": {\n      \"company\": \"Pagar.me\",\n      \"nome_da_mae\": \"Maria\"\n    }\n  },\n  \"status\": \"paid\",\n  \"created_at\": \"2017-06-06T16:03:40Z\",\n  \"updated_at\": \"2017-06-06T16:03:40Z\",\n  \"closed_at\": \"2017-06-06T16:03:47Z\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "or_koMvlQOTMCb9dpPO"
                    },
                    "code": {
                      "type": "string",
                      "example": "O8YDFPZUM3"
                    },
                    "amount": {
                      "type": "integer",
                      "example": 2990,
                      "default": 0
                    },
                    "currency": {
                      "type": "string",
                      "example": "BRL"
                    },
                    "closed": {
                      "type": "boolean",
                      "example": true,
                      "default": true
                    },
                    "items": {
                      "type": "array",
                      "items": {
                        "type": "object",
                        "properties": {
                          "id": {
                            "type": "string",
                            "example": "oi_jkW1MBc9MtKdzK20"
                          },
                          "description": {
                            "type": "string",
                            "example": "Bolinho de feijoada"
                          },
                          "amount": {
                            "type": "integer",
                            "example": 2990,
                            "default": 0
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
                            "example": "2017-06-06T16:03:41Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2017-06-06T16:03:41Z"
                          }
                        }
                      }
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_mBloKMLnswtD4O3a"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "avengerstark@ligadajustica.com.br"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2016-10-07T19:50:39Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-06-06T16:03:40Z"
                        },
                        "phones": {
                          "type": "object",
                          "properties": {}
                        },
                        "metadata": {
                          "type": "object",
                          "properties": {
                            "company": {
                              "type": "string",
                              "example": "Pagar.me"
                            },
                            "nome_da_mae": {
                              "type": "string",
                              "example": "Maria"
                            }
                          }
                        }
                      }
                    },
                    "status": {
                      "type": "string",
                      "example": "paid"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-06-06T16:03:40Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-06-06T16:03:40Z"
                    },
                    "closed_at": {
                      "type": "string",
                      "example": "2017-06-06T16:03:47Z"
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