# Obter cliente

<br />

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
    "/customers/{customer_id}": {
      "get": {
        "summary": "Obter cliente",
        "description": "",
        "operationId": "obter-cliente-1",
        "parameters": [
          {
            "name": "customer_id",
            "in": "path",
            "description": "CÃ³digo do cliente. Formato `cus_XXXXXXXXXXXXXXXX`.",
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
                    "value": "{\n    \"id\": \"cus_6l5dMWZ0hkHZ4XnE\",\n    \"name\": \"Wonderful Woman\",\n    \"email\": \"wonderfulwoman@avengers.com\",\n  \t\"gender\": \"female\",\n    \"delinquent\": false,\n    \"address\": {\n        \"id\": \"addr_ONzp3ZbTvfDJ35k9\",\n        \"line_1\": \"375, Av. General Justo, Centro\",\n        \"line_2\": \"8Âº andar\",\n        \"zip_code\": \"20021130\",\n        \"city\": \"Rio de Janeiro\",\n        \"state\": \"RJ\",\n        \"country\": \"BR\",\n        \"status\": \"active\",\n        \"created_at\": \"2017-08-22T19:50:44Z\",\n        \"updated_at\": \"2017-08-22T19:50:44Z\"\n    },\n    \"created_at\": \"2017-08-22T19:50:44Z\",\n    \"updated_at\": \"2017-08-22T19:50:51Z\",\n    \"phones\": {},\n    \"metadata\": {\n        \"company\": \"Avengers\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "cus_6l5dMWZ0hkHZ4XnE"
                    },
                    "name": {
                      "type": "string",
                      "example": "Wonderful Woman"
                    },
                    "email": {
                      "type": "string",
                      "example": "wonderfulwoman@avengers.com"
                    },
                    "gender": {
                      "type": "string",
                      "example": "female"
                    },
                    "delinquent": {
                      "type": "boolean",
                      "example": false,
                      "default": true
                    },
                    "address": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "addr_ONzp3ZbTvfDJ35k9"
                        },
                        "line_1": {
                          "type": "string",
                          "example": "375, Av. General Justo, Centro"
                        },
                        "line_2": {
                          "type": "string",
                          "example": "8Âº andar"
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
                          "example": "active"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-08-22T19:50:44Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-08-22T19:50:44Z"
                        }
                      }
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-08-22T19:50:44Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-08-22T19:50:51Z"
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
                          "example": "Avengers"
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