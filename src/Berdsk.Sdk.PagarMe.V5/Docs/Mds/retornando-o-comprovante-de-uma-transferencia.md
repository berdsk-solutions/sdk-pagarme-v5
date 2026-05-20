# Retornando o comprovante de uma transferÃªncia

Retorna o comprovante de uma transferÃªncia realizada com sucesso. SÃ³ Ã© possÃ­vel retornar comprovantes de transferÃªncias com status **transferred**.

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
    "/transfers/{transfer_id}/receipt": {
      "post": {
        "summary": "Retornando o comprovante de uma transferÃªncia",
        "description": "Retorna o comprovante de uma transferÃªncia realizada com sucesso. SÃ³ Ã© possÃ­vel retornar comprovantes de transferÃªncias com status **transferred**.",
        "operationId": "retornando-o-comprovante-de-uma-transferÃªncia",
        "parameters": [
          {
            "name": "transfer_id",
            "in": "path",
            "description": "ID da transferÃªncia que se deseja buscar o comprovante",
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
                    "value": ""
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