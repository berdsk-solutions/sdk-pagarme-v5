# Renovar cartÃ£o

Com o verbo _HTTP POST_, atravÃ©s do identificador do cartÃ£o (`card_id`) e do identificador do cliente (`customer_id`) ao
qual o cartÃ£o estÃ¡ associado, Ã© possÃ­vel renovar o cartÃ£o da **Wallet** do cliente, utilizando a funcionalidade manual
do Card Updater.

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
    "/customers/{customer_id}/cards/{card_id}/renew": {
      "post": {
        "summary": "Renovar cartÃ£o",
        "description": "Com o verbo _HTTP POST_, atravÃ©s do identificador do cartÃ£o (`card_id`) e do identificador do cliente (`customer_id`) ao qual o cartÃ£o estÃ¡ associado, Ã© possÃ­vel renovar o cartÃ£o da **Wallet** do cliente, utilizando a funcionalidade manual do Card Updater.",
        "operationId": "renovar-cartÃ£o-1",
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
                    "value": "{\n  \"id\": \"card_MgwPAXnU7rHW5mNj\",\n  \"first_six_digits\": \"519645\",\n  \"last_four_digits\": \"5475\",\n  \"brand\": \"Mastercard\",\n  \"holder_name\": \"Tony Stark\",\n  \"exp_month\": 3,\n  \"exp_year\": 2020,\n  \"status\": \"active\",\n  \"type\": \"credit\",\n  \"is_renewed\": true,\n  \"created_at\": \"2018-06-22T22:49:48Z\",\n  \"updated_at\": \"2018-06-22T22:49:48Z\",\n  \"billing_address\": {\n    \"zip_code\": \"90265\",\n    \"city\": \"Malibu\",\n    \"state\": \"CA\",\n    \"country\": \"US\",\n    \"line_1\": \"10880, Malibu Point, Malibu Central\"\n  },\n  \"customer\": {\n    \"id\": \"cus_BzRmLzQHEyurPkKo\",\n    \"name\": \"Tony Stark\",\n    \"email\": \"203b6f70-61ec-4f30-b00a-8a1823500ab4@avengers.com\",\n    \"document\": \"93095135270\",\n    \"type\": \"individual\",\n    \"delinquent\": false,\n    \"created_at\": \"2018-06-22T21:36:49Z\",\n    \"updated_at\": \"2018-06-22T21:36:49Z\",\n    \"phones\": {\n      \"home_phone\": {\n        \"country_code\": \"55\",\n        \"number\": \"000000000\",\n        \"area_code\": \"21\"\n      },\n      \"mobile_phone\": {\n        \"country_code\": \"55\",\n        \"number\": \"000000000\",\n        \"area_code\": \"21\"\n      }\n    },\n    \"metadata\": {\n      \"company\": \"Avengers\"\n    }\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "card_MgwPAXnU7rHW5mNj"
                    },
                    "first_six_digits": {
                      "type": "string",
                      "example": "519645"
                    },
                    "last_four_digits": {
                      "type": "string",
                      "example": "5475"
                    },
                    "brand": {
                      "type": "string",
                      "example": "Mastercard"
                    },
                    "holder_name": {
                      "type": "string",
                      "example": "Tony Stark"
                    },
                    "exp_month": {
                      "type": "integer",
                      "example": 3,
                      "default": 0
                    },
                    "exp_year": {
                      "type": "integer",
                      "example": 2020,
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
                    "is_renewed": {
                      "type": "boolean",
                      "example": true,
                      "default": true
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2018-06-22T22:49:48Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2018-06-22T22:49:48Z"
                    },
                    "billing_address": {
                      "type": "object",
                      "properties": {
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
                        "line_1": {
                          "type": "string",
                          "example": "10880, Malibu Point, Malibu Central"
                        }
                      }
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_BzRmLzQHEyurPkKo"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "203b6f70-61ec-4f30-b00a-8a1823500ab4@avengers.com"
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
                          "example": "2018-06-22T21:36:49Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-06-22T21:36:49Z"
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
          "412": {
            "description": "412",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"message\": \"Could not renew card.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "Could not renew card."
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