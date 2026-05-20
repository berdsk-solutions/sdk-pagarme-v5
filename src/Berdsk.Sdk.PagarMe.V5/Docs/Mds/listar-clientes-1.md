# Listar clientes

Este recurso permite a obtenÃ§Ã£o da **carteira de clientes** do lojista. Pode ser utilizados alguns parâmetros como
filtro da listagem

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
    "/customers": {
      "get": {
        "summary": "Listar clientes",
        "description": "Este recurso permite a obtenÃ§Ã£o da **carteira de clientes** do lojista. Pode ser utilizados alguns parâmetros como filtro da listagem",
        "operationId": "listar-clientes-1",
        "parameters": [
          {
            "name": "name",
            "in": "query",
            "description": "Nome do cliente",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "document",
            "in": "query",
            "description": "CPF ou CNPJ do cliente. Max: 16 caracteres",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "email",
            "in": "query",
            "description": "E-mail do cliente",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "gender",
            "in": "query",
            "description": "Sexo do cliente . Valores possÃ­veis: **male** ou **female**",
            "schema": {
              "type": "string"
            }
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
            "description": "Quantidade de itens por pÃ¡gina.",
            "schema": {
              "type": "integer",
              "format": "int32",
              "default": 10
            }
          },
          {
            "name": "code",
            "in": "query",
            "description": "CÃ³digo do cliente no sistema do lojista",
            "schema": {
              "type": "string",
              "default": "10"
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
                    "value": "{\n  \"data\": [\n    {\n      \"id\": \"cus_n2Y17zAt67s2Oplg\",\n      \"name\": \"Monitor\",\n      \"gender\": \"male\",\n      \"email\": \"9bfdfb6b-405f-489e-a4e0-b66101c86743@pagar.me\",\n      \"delinquent\": false,\n      \"created_at\": \"2017-04-19T17:43:10Z\",\n      \"updated_at\": \"2017-04-19T17:43:10Z\"\n    },\n    {\n      \"id\": \"cus_Z7DvZNpUZhYlvndR\",\n      \"name\": \"Monitor\",\n      \"gender\": \"female\",\n      \"email\": \"c17b44be-85a8-4a1c-a9d1-5e0109cb4ece@pagar.me\",\n      \"delinquent\": false,\n      \"created_at\": \"2017-04-19T17:42:51Z\",\n      \"updated_at\": \"2017-04-19T17:42:51Z\"\n    },\n  \"paging\": {\n    \"total\": 545797,\n    \"next\": \"https://api.pagar.me:4443/core/v1/customers?page=2&size=10\"\n  }\n}"
                  }
                }
              }
            }
          },
          "401": {
            "description": "401",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"message\": \"Authorization has been denied for this request.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Authorization has been denied for this request."
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