# Listar endereÃ§os

Este recurso permite a recuperaÃ§Ã£o dos endereÃ§os de um determinado cliente atravÃ©s do seu identificador(`customer_id`).
Pode ser utilizados alguns parâmetros como filtro da listagem.

<br />

> ðŸ“˜ PaginaÃ§Ã£o
>
> Este recurso utiliza **paginaÃ§Ã£o** para manipulaÃ§Ã£o da listagem
> resultante. [Saiba mais sobre paginaÃ§Ã£o](https://docs.pagar.me/reference/pagina%C3%A7%C3%A3o-1).

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
    "/customers/{customer_id}/addresses": {
      "get": {
        "summary": "Listar endereÃ§os",
        "description": "Este recurso permite a recuperaÃ§Ã£o dos endereÃ§os de um determinado cliente atravÃ©s do seu identificador(`customer_id`). Pode ser utilizados alguns parâmetros como filtro da listagem.",
        "operationId": "listar-endereÃ§os-1",
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
            "name": "page",
            "in": "query",
            "description": "PÃ¡gina atual.",
            "schema": {
              "type": "integer",
              "format": "int32",
              "default": 1
            }
          },
          {
            "name": "size",
            "in": "query",
            "description": "Quantidade de itens.",
            "schema": {
              "type": "integer",
              "format": "int32",
              "default": 10
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
                    "value": "{\n  \"data\": [\n    {\n      \"id\": \"addr_84BkRGZBtWiYJ9ox\",\n      \"line_1\": \"10882, Malibu Point, Central Malibu\",\n      \"zip_code\": \"90265\",\n      \"city\": \"Malibu\",\n      \"state\": \"CA\",\n      \"country\": \"US\",\n      \"status\": \"active\",\n      \"created_at\": \"2017-04-19T17:49:05Z\",\n      \"updated_at\": \"2017-04-19T17:49:05Z\"\n    },\n    {\n      \"id\": \"addr_yQAlePAumWuBa3qJ\",\n      \"line_1\": \"375, Av. General Justo, Centro\",\n      \"line_2\": \"9Âº andar\",\n      \"zip_code\": \"20021130\",\n      \"city\": \"Rio de Janeiro\",\n      \"state\": \"RJ\",\n      \"country\": \"BR\",\n      \"status\": \"active\",\n      \"created_at\": \"2017-04-04T19:41:31Z\",\n      \"updated_at\": \"2017-04-04T19:41:31Z\"\n    }\n  ],\n  \"paging\": {\n    \"total\": 2\n  }\n}"
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
                            "example": "addr_84BkRGZBtWiYJ9ox"
                          },
                          "line_1": {
                            "type": "string",
                            "example": "10882, Malibu Point, Central Malibu"
                          },
                          "zip_code": {
                            "type": "string",
                            "example": "90265"
                          },
                          "city": {
                            "type": "string",
                            "example": "Malibu"
                          },
                          "state": {
                            "type": "string",
                            "example": "CA"
                          },
                          "country": {
                            "type": "string",
                            "example": "US"
                          },
                          "status": {
                            "type": "string",
                            "example": "active"
                          },
                          "created_at": {
                            "type": "string",
                            "example": "2017-04-19T17:49:05Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2017-04-19T17:49:05Z"
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
                  "Result": {
                    "value": "{\n    \"message\": \"Customer not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Customer not found."
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