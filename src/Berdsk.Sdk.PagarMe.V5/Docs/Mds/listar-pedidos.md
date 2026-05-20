# Listar pedidos

> ðŸ“˜ PaginaÃ§Ã£o
>
> Este recurso utiliza **paginaÃ§Ã£o** para manipulaÃ§Ã£o da listagem resultante e retorna no mÃ¡ximo 30 JSONs por
> pÃ¡gina [Saiba mais sobre paginaÃ§Ã£o](https://docs.pagar.me/reference/pagina%C3%A7%C3%A3o-1).

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
    "/orders": {
      "get": {
        "summary": "Listar pedidos",
        "description": "",
        "operationId": "listar-pedidos",
        "parameters": [
          {
            "name": "code",
            "in": "query",
            "description": "CÃ³digo de referÃªncia do pedido no sistema da loja.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "status",
            "in": "query",
            "description": "Status do pedido.  Valores possÃ­veis: **pending**, **paid**, **canceled** ou **failed**",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "customer_id",
            "in": "query",
            "description": "CÃ³digo do cliente.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "created_since",
            "in": "query",
            "description": "Data de inÃ­cio do perÃ­odo de criaÃ§Ã£o a ser listado.",
            "schema": {
              "type": "string",
              "format": "date"
            }
          },
          {
            "name": "created_until",
            "in": "query",
            "description": "Data de final do perÃ­odo de criaÃ§Ã£o a ser listado.",
            "schema": {
              "type": "string",
              "format": "date"
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
                    "value": "{\n  \"data\": [\n    {\n      \"id\": \"or_28dN9w7CLU79kDjL\",\n      \"code\": \"62LVFN7I4R\",\n      \"amount\": 2990,\n      \"currency\": \"BRL\",\n      \"closed\": true,\n      \"items\": [\n        {\n          \"id\": \"oi_d478RMAS3bC74PrL\",\n          \"description\": \"Chaveiro do Tesseract\",\n          \"amount\": 2990,\n          \"quantity\": 1,\n          \"status\": \"active\",\n          \"created_at\": \"2017-04-19T16:01:09Z\",\n          \"updated_at\": \"2017-04-19T16:01:09Z\"\n        }\n      ],\n      \"customer\": {\n        \"id\": \"cus_eaEXlZvhBfeGlDOm\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"f1492621-4f39-45f7-adfb-82a373a0a85c@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2017-04-19T16:01:09Z\",\n        \"updated_at\": \"2017-04-19T16:01:09Z\"\n      },\n      \"status\": \"paid\",\n      \"created_at\": \"2017-04-19T16:01:09Z\",\n      \"updated_at\": \"2017-04-19T16:01:11Z\",\n      \"closed_at\": \"2017-04-19T16:01:11Z\",\n      \"charges\": [\n        {\n          \"id\": \"ch_gmnW101c9YTvQVLB\",\n          \"code\": \"62LVFN7I4R\",\n          \"gateway_id\": \"ef5e977b-93d2-485a-b15d-36e5eb3d8cf5\",\n          \"amount\": 2990,\n          \"status\": \"paid\",\n          \"currency\": \"BRL\",\n          \"payment_method\": \"credit_card\",\n          \"paid_at\": \"2017-04-19T16:01:11Z\",\n          \"created_at\": \"2017-04-19T16:01:09Z\",\n          \"updated_at\": \"2017-04-19T16:01:09Z\",\n          \"customer\": {\n            \"id\": \"cus_eaEXlZvhBfeGlDOm\",\n            \"name\": \"Tony Stark\",\n            \"email\": \"f1492621-4f39-45f7-adfb-82a373a0a85c@avengers.com\",\n            \"delinquent\": false,\n            \"created_at\": \"2017-04-19T16:01:09Z\",\n            \"updated_at\": \"2017-04-19T16:01:09Z\"\n          }\n        }\n      ]\n    },\n    {\n      \"id\": \"or_dW6vZoJfLhw3Rb10\",\n      \"code\": \"65JGU05FX0\",\n      \"amount\": 2990,\n      \"currency\": \"BRL\",\n      \"closed\": true,\n      \"items\": [\n        {\n          \"id\": \"oi_zYGxV8rU36HPWQMg\",\n          \"description\": \"Chaveiro do Tesseract\",\n          \"amount\": 2990,\n          \"quantity\": 1,\n          \"status\": \"active\",\n          \"created_at\": \"2017-04-19T15:58:23Z\",\n          \"updated_at\": \"2017-04-19T15:58:23Z\"\n        }\n      ],\n      \"customer\": {\n        \"id\": \"cus_rG3592i17uQgxK2Q\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"5d76b138-2963-40f7-ba71-c9ae2cc65518@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2017-04-19T15:58:23Z\",\n        \"updated_at\": \"2017-04-19T15:58:23Z\"\n      },\n      \"status\": \"failed\",\n      \"created_at\": \"2017-04-19T15:58:23Z\",\n      \"updated_at\": \"2017-04-19T15:58:24Z\",\n      \"closed_at\": \"2017-04-19T15:58:24Z\",\n      \"charges\": [\n        {\n          \"id\": \"ch_nM5PkjcyLUa6Nr1w\",\n          \"code\": \"65JGU05FX0\",\n          \"amount\": 2990,\n          \"status\": \"failed\",\n          \"currency\": \"BRL\",\n          \"payment_method\": \"credit_card\",\n          \"created_at\": \"2017-04-19T15:58:23Z\",\n          \"updated_at\": \"2017-04-19T15:58:24Z\",\n          \"customer\": {\n            \"id\": \"cus_rG3592i17uQgxK2Q\",\n            \"name\": \"Tony Stark\",\n            \"email\": \"5d76b138-2963-40f7-ba71-c9ae2cc65518@avengers.com\",\n            \"delinquent\": false,\n            \"created_at\": \"2017-04-19T15:58:23Z\",\n            \"updated_at\": \"2017-04-19T15:58:23Z\"\n          }\n        }\n      ]\n    }\n  ],\n  \"paging\": {\n    \"total\": 406,\n    \"next\": \"https://api.pagar.me/core/v1/orders?page=2&size=2\"\n  }\n}"
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
                            "example": "or_28dN9w7CLU79kDjL"
                          },
                          "code": {
                            "type": "string",
                            "example": "62LVFN7I4R"
                          },
                          "amount": {
                            "type": "integer",
                            "example": 2990,
                            "default": 0
                          },
                          "currency": {
                            "type": "string",
                            "example": "BRL"
                          },
                          "closed": {
                            "type": "boolean",
                            "example": true,
                            "default": true
                          },
                          "items": {
                            "type": "array",
                            "items": {
                              "type": "object",
                              "properties": {
                                "id": {
                                  "type": "string",
                                  "example": "oi_d478RMAS3bC74PrL"
                                },
                                "description": {
                                  "type": "string",
                                  "example": "Chaveiro do Tesseract"
                                },
                                "amount": {
                                  "type": "integer",
                                  "example": 2990,
                                  "default": 0
                                },
                                "quantity": {
                                  "type": "integer",
                                  "example": 1,
                                  "default": 0
                                },
                                "status": {
                                  "type": "string",
                                  "example": "active"
                                },
                                "created_at": {
                                  "type": "string",
                                  "example": "2017-04-19T16:01:09Z"
                                },
                                "updated_at": {
                                  "type": "string",
                                  "example": "2017-04-19T16:01:09Z"
                                }
                              }
                            }
                          },
                          "customer": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "cus_eaEXlZvhBfeGlDOm"
                              },
                              "name": {
                                "type": "string",
                                "example": "Tony Stark"
                              },
                              "email": {
                                "type": "string",
                                "example": "f1492621-4f39-45f7-adfb-82a373a0a85c@avengers.com"
                              },
                              "delinquent": {
                                "type": "boolean",
                                "example": false,
                                "default": true
                              },
                              "created_at": {
                                "type": "string",
                                "example": "2017-04-19T16:01:09Z"
                              },
                              "updated_at": {
                                "type": "string",
                                "example": "2017-04-19T16:01:09Z"
                              }
                            }
                          },
                          "status": {
                            "type": "string",
                            "example": "paid"
                          },
                          "created_at": {
                            "type": "string",
                            "example": "2017-04-19T16:01:09Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2017-04-19T16:01:11Z"
                          },
                          "closed_at": {
                            "type": "string",
                            "example": "2017-04-19T16:01:11Z"
                          },
                          "charges": {
                            "type": "array",
                            "items": {
                              "type": "object",
                              "properties": {
                                "id": {
                                  "type": "string",
                                  "example": "ch_gmnW101c9YTvQVLB"
                                },
                                "code": {
                                  "type": "string",
                                  "example": "62LVFN7I4R"
                                },
                                "gateway_id": {
                                  "type": "string",
                                  "example": "ef5e977b-93d2-485a-b15d-36e5eb3d8cf5"
                                },
                                "amount": {
                                  "type": "integer",
                                  "example": 2990,
                                  "default": 0
                                },
                                "status": {
                                  "type": "string",
                                  "example": "paid"
                                },
                                "currency": {
                                  "type": "string",
                                  "example": "BRL"
                                },
                                "payment_method": {
                                  "type": "string",
                                  "example": "credit_card"
                                },
                                "paid_at": {
                                  "type": "string",
                                  "example": "2017-04-19T16:01:11Z"
                                },
                                "created_at": {
                                  "type": "string",
                                  "example": "2017-04-19T16:01:09Z"
                                },
                                "updated_at": {
                                  "type": "string",
                                  "example": "2017-04-19T16:01:09Z"
                                },
                                "customer": {
                                  "type": "object",
                                  "properties": {
                                    "id": {
                                      "type": "string",
                                      "example": "cus_eaEXlZvhBfeGlDOm"
                                    },
                                    "name": {
                                      "type": "string",
                                      "example": "Tony Stark"
                                    },
                                    "email": {
                                      "type": "string",
                                      "example": "f1492621-4f39-45f7-adfb-82a373a0a85c@avengers.com"
                                    },
                                    "delinquent": {
                                      "type": "boolean",
                                      "example": false,
                                      "default": true
                                    },
                                    "created_at": {
                                      "type": "string",
                                      "example": "2017-04-19T16:01:09Z"
                                    },
                                    "updated_at": {
                                      "type": "string",
                                      "example": "2017-04-19T16:01:09Z"
                                    }
                                  }
                                }
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
                          "example": 406,
                          "default": 0
                        },
                        "next": {
                          "type": "string",
                          "example": "https://api.pagar.me/core/v1/orders?page=2&size=2"
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