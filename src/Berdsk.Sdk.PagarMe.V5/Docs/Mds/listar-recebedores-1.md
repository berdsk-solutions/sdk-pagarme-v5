# Listar recebedores

Retorna uma lista de objetos com os dados dos recebedor encontrados.

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
    "/recipients": {
      "get": {
        "summary": "Listar recebedores",
        "description": "Retorna uma lista de objetos com os dados dos recebedor encontrados.",
        "operationId": "listar-recebedores-1",
        "parameters": [
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
          }
        ],
        "responses": {
          "200": {
            "description": "200",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"data\": [\n        {\n            \"id\": \"rp_Gxb5NJNiqvf0Y5Xv\",\n            \"name\": \"Tony Stark\",\n            \"email\": \"tstark@avengers.com\",\n            \"document\": \"26224451990\",\n            \"description\": \"Recebedor Tony Stark\",\n            \"type\": \"individual\",\n            \"status\": \"active\",\n            \"created_at\": \"2017-10-27T16:12:37Z\",\n            \"updated_at\": \"2017-10-27T16:12:37Z\",\n            \"transfer_settings\": {\n                \"transfer_enabled\": false,\n                \"transfer_interval\": \"Daily\",\n                \"transfer_day\": 0\n             },\n            \"default_bank_account\": {\n                \"id\": \"ba_KOoYDmEHvIEYD6v3\",\n                \"holder_name\": \"Tony Stark\",\n                \"holder_type\": \"individual\",\n                \"holder_document\": \"26224451990\",\n                \"bank\": \"341\",\n                \"branch_number\": \"12345\",\n                \"branch_check_digit\": \"6\",\n                \"account_number\": \"12345\",\n                \"account_check_digit\": \"6\",\n                \"type\": \"checking\",\n                \"status\": \"active\",\n                \"created_at\": \"2017-10-27T19:03:21Z\",\n                \"updated_at\": \"2017-10-27T19:03:21Z\",\n                \"metadata\": {\n                    \"meta_key\": \"meta_value\"\n                }\n            },\n            \"metadata\": {\n                \"key\": \"value\"\n            }\n        }\n    ],\n    \"paging\": {\n        \"total\": 1\n    }\n}"
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
                            "example": "rp_Gxb5NJNiqvf0Y5Xv"
                          },
                          "name": {
                            "type": "string",
                            "example": "Tony Stark"
                          },
                          "email": {
                            "type": "string",
                            "example": "tstark@avengers.com"
                          },
                          "document": {
                            "type": "string",
                            "example": "26224451990"
                          },
                          "description": {
                            "type": "string",
                            "example": "Recebedor Tony Stark"
                          },
                          "type": {
                            "type": "string",
                            "example": "individual"
                          },
                          "status": {
                            "type": "string",
                            "example": "active"
                          },
                          "created_at": {
                            "type": "string",
                            "example": "2017-10-27T16:12:37Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2017-10-27T16:12:37Z"
                          },
                          "transfer_settings": {
                            "type": "object",
                            "properties": {
                              "transfer_enabled": {
                                "type": "boolean",
                                "example": false,
                                "default": true
                              },
                              "transfer_interval": {
                                "type": "string",
                                "example": "Daily"
                              },
                              "transfer_day": {
                                "type": "integer",
                                "example": 0,
                                "default": 0
                              }
                            }
                          },
                          "default_bank_account": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "ba_KOoYDmEHvIEYD6v3"
                              },
                              "holder_name": {
                                "type": "string",
                                "example": "Tony Stark"
                              },
                              "holder_type": {
                                "type": "string",
                                "example": "individual"
                              },
                              "holder_document": {
                                "type": "string",
                                "example": "26224451990"
                              },
                              "bank": {
                                "type": "string",
                                "example": "341"
                              },
                              "branch_number": {
                                "type": "string",
                                "example": "12345"
                              },
                              "branch_check_digit": {
                                "type": "string",
                                "example": "6"
                              },
                              "account_number": {
                                "type": "string",
                                "example": "12345"
                              },
                              "account_check_digit": {
                                "type": "string",
                                "example": "6"
                              },
                              "type": {
                                "type": "string",
                                "example": "checking"
                              },
                              "status": {
                                "type": "string",
                                "example": "active"
                              },
                              "created_at": {
                                "type": "string",
                                "example": "2017-10-27T19:03:21Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2017-10-27T19:03:21Z"
                              },
                              "metadata": {
                                "type": "object",
                                "properties": {
                                  "meta_key": {
                                    "type": "string",
                                    "example": "meta_value"
                                  }
                                }
                              }
                            }
                          },
                          "metadata": {
                            "type": "object",
                            "properties": {
                              "key": {
                                "type": "string",
                                "example": "value"
                              }
                            }
                          }
                        }
                      }
                    },
                    "paging": {
                      "type": "object",
                      "properties": {
                        "total": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
                        }
                      }
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