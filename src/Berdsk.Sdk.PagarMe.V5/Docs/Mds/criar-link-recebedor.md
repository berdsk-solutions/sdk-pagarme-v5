# Criar link de de Prova de Vida (KYC)

Rota para gerar o QR Code de acesso ao webapp.

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
    "/recipients/{recipient_id}/kyc_link": {
      "post": {
        "summary": "Criar link de de Prova de Vida (KYC)",
        "description": "Rota para gerar o QR Code de acesso ao webapp.",
        "operationId": "criar-link-recebedor",
        "parameters": [
          {
            "name": "recipient_id",
            "in": "path",
            "description": "CÃ³digo do recebedor.",
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
                    "value": "{\n    \"url\": \"www.pagar.me/kyc/14214214215...\",\n    \"base64_qrcode\": \"PD56bWwgdVyc2lvb...pIi8+PC9zdmc+\",\n    \"expires_at\": \"2025-05-10T17:17:26Z\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "url": {
                      "type": "string",
                      "example": "www.pagar.me/kyc/14214214215..."
                    },
                    "base64_qrcode": {
                      "type": "string",
                      "example": "PD56bWwgdVyc2lvb...pIi8+PC9zdmc+"
                    },
                    "expires_at": {
                      "type": "string",
                      "example": "2025-05-10T17:17:26Z"
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
                    "value": "{\n    \"errors\": [\n        {\n            \"message\": \"Must be passed a parameter to Create QrCode.\"\n        }\n    ]\n}"
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
                          "message": {
                            "type": "string",
                            "example": "Must be passed a parameter to Create QrCode."
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
                    "value": "{\n    \"errors\": [\n        {\n            \"message\": \"re_clsnosxwp000a019ts7a262ay doesnÂ´t have any kyc with partially_denied status.\"\n        }\n    ]\n}"
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
                          "message": {
                            "type": "string",
                            "example": "re_clsnosxwp000a019ts7a262ay doesnÂ´t have any kyc with partially_denied status."
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
        "deprecated": false,
        "x-readme": {
          "code-samples": [
            {
              "language": "curl",
              "code": "curl --request POST \\\n     --url https://api.pagar.me/core/v5/recipients/re_clsnosxwp000a019ts7a262ay/kyc_link \\\n     --header 'accept: application/json' \\\n     --header 'content-type: application/json'"
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