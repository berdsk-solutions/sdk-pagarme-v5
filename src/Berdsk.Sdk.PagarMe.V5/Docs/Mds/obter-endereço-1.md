# Obter endereÃ§o

AtravÃ©s dos identificadores do cliente (`customer_id`) e do endereÃ§o (`address_id`) Ã© possÃ­vel obter o endereÃ§o do
cliente.

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
    "/customers/{customer_id}/addresses/{address_id}": {
      "get": {
        "summary": "Obter endereÃ§o",
        "description": "AtravÃ©s dos identificadores do cliente (`customer_id`) e do endereÃ§o (`address_id`) Ã© possÃ­vel obter o endereÃ§o do cliente.",
        "operationId": "obter-endereÃ§o-1",
        "parameters": [
          {
            "name": "customer_id",
            "in": "path",
            "description": "CÃ³digo do cliente. Formato: `cus_XXXXXXXXXXXXXXXX`.",
            "schema": {
              "type": "string"
            },
            "required": true
          },
          {
            "name": "address_id",
            "in": "path",
            "description": "CÃ³digo do endereÃ§o. Formato: `addr_XXXXXXXXXXXXXXXX`.",
            "schema": {
              "type": "string"
            },
            "required": true
          }
        ],
        "responses": {
          "200": {
            "description": "200",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n  \"id\": \"addr_Pn5x69LCWhrANX2o\",\n  \"line_1\": \"375, Av. General Justo, Centro\",\n  \"line_2\": \"10Âº andar\",\n  \"zip_code\": \"20021130\",\n  \"city\": \"Rio de Janeiro\",\n  \"state\": \"RJ\",\n  \"country\": \"BR\",\n  \"status\": \"deleted\",\n  \"created_at\": \"2017-04-19T17:49:36Z\",\n  \"updated_at\": \"2017-04-19T17:50:18Z\",\n  \"deleted_at\": \"2017-04-19T17:50:34Z\",\n  \"customer\": {\n    \"id\": \"cus_aEkwKv0SmNHMR931\",\n    \"name\": \"Luke Skywalker\",\n    \"email\": \"lskywalker@r2d2.com\",\n    \"document\": \"26224451990\",\n    \"type\": \"individual\",\n    \"delinquent\": false,\n    \"created_at\": \"2017-04-04T19:41:31Z\",\n    \"updated_at\": \"2017-04-19T17:44:47Z\",\n    \"metadata\": {\n      \"id\": \"my_customer_id\"\n    }\n  },\n  \"metadata\": {\n    \"id\": \"work\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "addr_Pn5x69LCWhrANX2o"
                    },
                    "line_1": {
                      "type": "string",
                      "example": "375, Av. General Justo, Centro"
                    },
                    "line_2": {
                      "type": "string",
                      "example": "10Âº andar"
                    },
                    "zip_code": {
                      "type": "string",
                      "example": "20021130"
                    },
                    "city": {
                      "type": "string",
                      "example": "Rio de Janeiro"
                    },
                    "state": {
                      "type": "string",
                      "example": "RJ"
                    },
                    "country": {
                      "type": "string",
                      "example": "BR"
                    },
                    "status": {
                      "type": "string",
                      "example": "deleted"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-19T17:49:36Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-04-19T17:50:18Z"
                    },
                    "deleted_at": {
                      "type": "string",
                      "example": "2017-04-19T17:50:34Z"
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
                        "document": {
                          "type": "string",
                          "example": "26224451990"
                        },
                        "type": {
                          "type": "string",
                          "example": "individual"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-04-04T19:41:31Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-19T17:44:47Z"
                        },
                        "metadata": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "my_customer_id"
                            }
                          }
                        }
                      }
                    },
                    "metadata": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "work"
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
                    "value": "{\n    \"message\": \"Address not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Address not found."
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