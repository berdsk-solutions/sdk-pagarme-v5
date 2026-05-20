# Obter informações do BIN

# OpenAPI definition

```json
{
  "openapi": "3.1.0",
  "info": {
    "title": "bin-api",
    "version": "5"
  },
  "servers": [
    {
      "url": "https://api.pagar.me/bin/v1"
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
    "/{bin}": {
      "get": {
        "summary": "Obter informações do BIN",
        "description": "",
        "operationId": "obter-informações-do-bin",
        "parameters": [
          {
            "name": "bin",
            "in": "path",
            "description": "Bank Identifier Number.",
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
                    "value": "{\n  \"brand\": \"mastercard\",\n  \"brandName\": \"Mastercard\",\n  \"gaps\": [\n    4,\n    8,\n    12\n  ],\n  \"lenghts\": [\n    16\n  ],\n  \"mask\": \"/(\\\\d{1,4})/g\",\n  \"input\": \"/(?:^|s)(d{4})$/\",\n  \"cvv\": 3\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "brand": {
                      "type": "string",
                      "example": "mastercard"
                    },
                    "brandName": {
                      "type": "string",
                      "example": "Mastercard"
                    },
                    "gaps": {
                      "type": "array",
                      "items": {
                        "type": "integer",
                        "example": 4,
                        "default": 0
                      }
                    },
                    "lenghts": {
                      "type": "array",
                      "items": {
                        "type": "integer",
                        "example": 16,
                        "default": 0
                      }
                    },
                    "mask": {
                      "type": "string",
                      "example": "/(\\d{1,4})/g"
                    },
                    "input": {
                      "type": "string",
                      "example": "/(?:^|s)(d{4})$/"
                    },
                    "cvv": {
                      "type": "integer",
                      "example": 3,
                      "default": 0
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
        "deprecated": false,
        "x-readme": {
          "code-samples": [
            {
              "language": "curl",
              "code": "curl --request GET --url 'https://api.pagar.me/bin/v1/525663'"
            }
          ],
          "samples-languages": [
            "curl"
          ]
        }
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