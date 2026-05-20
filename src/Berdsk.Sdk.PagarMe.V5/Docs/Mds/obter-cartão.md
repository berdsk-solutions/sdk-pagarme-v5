# Obter cartÃ£o

Possibilita a recuperaÃ§Ã£o de um `card` atravÃ©s dos identificadores do cartÃ£o (`card_id`) e do cliente associado (
`customer_id`), informados por parâmetro.

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
    "/customers/{customer_id}/cards/{card_id}": {
      "get": {
        "summary": "Obter cartÃ£o",
        "description": "Possibilita a recuperaÃ§Ã£o de um `card` atravÃ©s dos identificadores do cartÃ£o (`card_id`) e do cliente associado (`customer_id`), informados por parâmetro.",
        "operationId": "obter-cartÃ£o",
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
            "name": "card_id",
            "in": "path",
            "description": "CÃ³digo do cartÃ£o. Formato: `card_XXXXXXXXXXXXXXXX`.",
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
                    "value": "{\n    \"id\": \"card_8ELY0AwVF9HDa3jK\",\n    \"first_six_digits\": \"542501\",\n    \"last_four_digits\": \"7793\",\n    \"brand\": \"Mastercard\",\n    \"holder_name\": \"Tony Stark\",\n    \"exp_month\": 1,\n    \"exp_year\": 2030,\n    \"status\": \"active\",\n    \"created_at\": \"2017-07-07T19:50:33Z\",\n    \"updated_at\": \"2017-07-07T19:50:33Z\",\n    \"billing_address\": {\n        \"line_1\": \"10880, Malibu Point, Malibu Central\",\n        \"zip_code\": \"90265\",\n        \"city\": \"Malibu\",\n        \"state\": \"CA\",\n        \"country\": \"US\",\n    },\n    \"customer\": {\n        \"id\": \"cus_yoqONwOJI1IBNbjl\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"0fee2dc5-e440-4dd1-9cd6-9c2bc90533d0@avengers.com\",\n        \"document\": \"93095135270\",\n        \"type\": \"individual\",\n        \"delinquent\": false,\n        \"created_at\": \"2017-07-07T19:50:23Z\",\n        \"updated_at\": \"2017-07-07T19:50:23Z\",\n        \"phones\": {\n            \"home_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            },\n            \"mobile_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            }\n        },\n        \"metadata\": {\n            \"company\": \"Avengers\"\n        }\n    },\n    \"type\": \"credit\"\n}"
                  },
                  "OK - Network Token": {
                    "value": "{\n    \"id\": \"card_ej6MVD4sYLUBVy92\",\n    \"first_six_digits\": \"400000\",\n    \"last_four_digits\": \"0010\",\n    \"brand\": \"Visa\",\n    \"holder_name\": \"Tony Stark\",\n    \"holder_document\": \"93095135270\",\n    \"exp_month\": 1,\n    \"exp_year\": 2030,\n    \"status\": \"active\",\n    \"type\": \"credit\",\n    \"created_at\": \"2023-03-17T14:01:48Z\",\n    \"updated_at\": \"2023-03-17T14:01:48Z\",\n    \"billing_address\": {\n        \"zip_code\": \"220000111\",\n        \"city\": \"Rio de Janeiro\",\n        \"state\": \"RJ\",\n        \"country\": \"BR\",\n        \"line_1\": \"375, Av. General Osorio, Centro\",\n        \"line_2\": \"7Âº Andar\"\n    },\n    \"network_token\": {\n        \"token_unique_reference\": \"ea90e8e8-af1d-4f22-a2f0-a54d5f8b55b5\",\n        \"status\": \"active\"\n    },\n    \"customer\": {\n        \"id\": \"cus_9oYdjPACaAUXgJq0\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"tonystarkk@avengers.com\",\n        \"code\": \"MY_CUSTOMER_001\",\n        \"document\": \"93095135270\",\n        \"document_type\": \"cpf\",\n        \"type\": \"individual\",\n        \"gender\": \"male\",\n        \"delinquent\": false,\n        \"created_at\": \"2023-03-17T14:01:45Z\",\n        \"updated_at\": \"2023-03-17T14:01:45Z\",\n        \"birthdate\": \"1984-05-03T00:00:00Z\",\n        \"phones\": {\n            \"home_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            },\n            \"mobile_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"000000000\",\n                \"area_code\": \"21\"\n            }\n        },\n        \"metadata\": {\n            \"company\": \"Avengers\"\n        }\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "card_ej6MVD4sYLUBVy92"
                    },
                    "first_six_digits": {
                      "type": "string",
                      "example": "400000"
                    },
                    "last_four_digits": {
                      "type": "string",
                      "example": "0010"
                    },
                    "brand": {
                      "type": "string",
                      "example": "Visa"
                    },
                    "holder_name": {
                      "type": "string",
                      "example": "Tony Stark"
                    },
                    "holder_document": {
                      "type": "string",
                      "example": "93095135270"
                    },
                    "exp_month": {
                      "type": "integer",
                      "example": 1,
                      "default": 0
                    },
                    "exp_year": {
                      "type": "integer",
                      "example": 2030,
                      "default": 0
                    },
                    "status": {
                      "type": "string",
                      "example": "active"
                    },
                    "type": {
                      "type": "string",
                      "example": "credit"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2023-03-17T14:01:48Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2023-03-17T14:01:48Z"
                    },
                    "billing_address": {
                      "type": "object",
                      "properties": {
                        "zip_code": {
                          "type": "string",
                          "example": "220000111"
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
                        "line_1": {
                          "type": "string",
                          "example": "375, Av. General Osorio, Centro"
                        },
                        "line_2": {
                          "type": "string",
                          "example": "7Âº Andar"
                        }
                      }
                    },
                    "network_token": {
                      "type": "object",
                      "properties": {
                        "token_unique_reference": {
                          "type": "string",
                          "example": "ea90e8e8-af1d-4f22-a2f0-a54d5f8b55b5"
                        },
                        "status": {
                          "type": "string",
                          "example": "active"
                        }
                      }
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_9oYdjPACaAUXgJq0"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "tonystarkk@avengers.com"
                        },
                        "code": {
                          "type": "string",
                          "example": "MY_CUSTOMER_001"
                        },
                        "document": {
                          "type": "string",
                          "example": "93095135270"
                        },
                        "document_type": {
                          "type": "string",
                          "example": "cpf"
                        },
                        "type": {
                          "type": "string",
                          "example": "individual"
                        },
                        "gender": {
                          "type": "string",
                          "example": "male"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2023-03-17T14:01:45Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2023-03-17T14:01:45Z"
                        },
                        "birthdate": {
                          "type": "string",
                          "example": "1984-05-03T00:00:00Z"
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
                    "value": "{\n    \"message\": \"Card not found.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Card not found."
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