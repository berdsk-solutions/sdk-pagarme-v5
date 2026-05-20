# Excluir endereÃ§o

Com o verbo _HTTP DELETE_, atravÃ©s do identificador do endereÃ§o(`address_id`) e do identificador do cliente (
`customer_id`) ao qual o endereÃ§o estÃ¡ associado, Ã© possÃ­vel remover o endereÃ§o da **Wallet** do cliente.

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
      "delete": {
        "summary": "Excluir endereÃ§o",
        "description": "Com o verbo _HTTP DELETE_, atravÃ©s do identificador do endereÃ§o(`address_id`) e do identificador do cliente (`customer_id`) ao qual o endereÃ§o estÃ¡ associado, Ã© possÃ­vel remover o endereÃ§o da **Wallet** do cliente.",
        "operationId": "excluir-endereÃ§o-1",
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
                    "value": "{\n    \"id\": \"addr_GEjbAjaUK9h1PRLa\",\n    \"line_1\": \"10882, Malibu Point, Central Malibu\",\n    \"street\": \"Malibu Point\",\n    \"number\": \"10882\",\n    \"zip_code\": \"90265\",\n    \"neighborhood\": \"Central Malibu\",\n    \"city\": \"Malibu\",\n    \"state\": \"CA\",\n    \"country\": \"US\",\n    \"status\": \"deleted\",\n    \"created_at\": \"2018-12-14T18:57:18Z\",\n    \"updated_at\": \"2018-12-14T18:58:36Z\",\n    \"deleted_at\": \"2018-12-14T18:58:36Z\",\n    \"customer\": {\n        \"id\": \"cus_lMyKPqXiRhR8w9Dr\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"17cdffc1-d919-4530-9427-c82ba5b5c77f@avengers.com\",\n        \"document\": \"93095135270\",\n        \"type\": \"individual\",\n        \"delinquent\": false,\n        \"created_at\": \"2018-12-14T17:55:36Z\",\n        \"updated_at\": \"2018-12-14T17:55:36Z\",\n        \"phones\": {\n            \"home_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            },\n            \"mobile_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            }\n        },\n        \"metadata\": {\n            \"company\": \"Avengers\"\n        }\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "addr_GEjbAjaUK9h1PRLa"
                    },
                    "line_1": {
                      "type": "string",
                      "example": "10882, Malibu Point, Central Malibu"
                    },
                    "street": {
                      "type": "string",
                      "example": "Malibu Point"
                    },
                    "number": {
                      "type": "string",
                      "example": "10882"
                    },
                    "zip_code": {
                      "type": "string",
                      "example": "90265"
                    },
                    "neighborhood": {
                      "type": "string",
                      "example": "Central Malibu"
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
                      "example": "deleted"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2018-12-14T18:57:18Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2018-12-14T18:58:36Z"
                    },
                    "deleted_at": {
                      "type": "string",
                      "example": "2018-12-14T18:58:36Z"
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_lMyKPqXiRhR8w9Dr"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "17cdffc1-d919-4530-9427-c82ba5b5c77f@avengers.com"
                        },
                        "document": {
                          "type": "string",
                          "example": "93095135270"
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
                          "example": "2018-12-14T17:55:36Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-12-14T17:55:36Z"
                        },
                        "phones": {
                          "type": "object",
                          "properties": {
                            "home_phone": {
                              "type": "object",
                              "properties": {
                                "country_code": {
                                  "type": "string",
                                  "example": "55"
                                },
                                "number": {
                                  "type": "string",
                                  "example": "000000000"
                                },
                                "area_code": {
                                  "type": "string",
                                  "example": "21"
                                }
                              }
                            },
                            "mobile_phone": {
                              "type": "object",
                              "properties": {
                                "country_code": {
                                  "type": "string",
                                  "example": "55"
                                },
                                "number": {
                                  "type": "string",
                                  "example": "000000000"
                                },
                                "area_code": {
                                  "type": "string",
                                  "example": "21"
                                }
                              }
                            }
                          }
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