# Editar regras do Split

Com o verbo HTTP PATCH, atravÃ©s do identificador da assinatura (subscription_id) Ã© possÃ­vel ativar, desativar ou alterar
as regras do split na recorrÃªncia.

Para realizar a ediÃ§Ã£o tem que ser enviado pelo menos um dos campos, `enabled` ou `rules`, ambos campos sÃ£o opcionais e
independentes.

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
    "/subscriptions/{subscription_id}/split": {
      "patch": {
        "summary": "Editar regras do Split",
        "description": "Com o verbo HTTP PATCH, atravÃ©s do identificador da assinatura (subscription_id) Ã© possÃ­vel ativar, desativar ou alterar as regras do split na recorrÃªncia.\n\nPara realizar a ediÃ§Ã£o tem que ser enviado pelo menos um dos campos, `enabled` ou `rules`, ambos campos sÃ£o opcionais e independentes.",
        "operationId": "editar-ativaÃ§Ã£o-ou-regras-do-split",
        "parameters": [
          {
            "name": "subscription_id",
            "in": "path",
            "description": "CÃ³digo da Assinatura. <br>Formato: `sub_XXXXXXXXXXXXXXXX`.",
            "schema": {
              "type": "string"
            },
            "required": true
          }
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "properties": {
                  "enabled": {
                    "type": "boolean",
                    "description": "Ativa ou desativa as regras de split na assinatura.  Pode ser `true` ou `False`"
                  },
                  "rules": {
                    "type": "array",
                    "items": {
                      "properties": {
                        "amount": {
                          "type": "integer",
                          "description": "Valor destinado ao recebedor.",
                          "format": "int32"
                        },
                        "recipient_id": {
                          "type": "string",
                          "description": "CÃ³digo do recebedor. Formato: rp_XXXXXXXXXXXXXXXX."
                        },
                        "type": {
                          "type": "string",
                          "description": "Tipo de divisÃ£o. Os valores possÃ­veis sÃ£o flat ou percentage."
                        },
                        "options": {
                          "type": "object",
                          "description": "Informações da responsabilidade do recebedor na transaÃ§Ã£o.",
                          "properties": {
                            "charge_processing_fee": {
                              "type": "boolean",
                              "description": "Indica se o recebedor vinculado Ã  regra serÃ¡ cobrado pelas taxas da transaÃ§Ã£o"
                            },
                            "charge_remainder_fee": {
                              "type": "boolean",
                              "description": "Indica se o recebedor vinculado Ã  regra irÃ¡ receber o restante dos recebÃ­veis apÃ³s uma divisÃ£o"
                            },
                            "liable": {
                              "type": "boolean",
                              "description": "Indica se o recebedor Ã© responsÃ¡vel pela transaÃ§Ã£o em caso de chargeback."
                            }
                          }
                        }
                      },
                      "type": "object"
                    }
                  }
                }
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "200",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"id\": \"sub_WpkrQvNriRs6QKGz\",\n    \"code\": \"EP13T6I0KR\",\n    \"start_at\": \"2022-01-12T00:00:00Z\",\n    \"interval\": \"month\",\n    \"interval_count\": 1,\n    \"billing_type\": \"postpaid\",\n    \"current_cycle\": {\n        \"id\": \"cycle_z7NyjWYtLoCWXnM3\",\n        \"start_at\": \"2022-01-12T00:00:00Z\",\n        \"end_at\": \"2022-01-13T23:59:59Z\",\n        \"billing_at\": \"2022-01-14T00:00:00Z\",\n        \"status\": \"unbilled\",\n        \"cycle\": 1\n    },\n    \"next_billing_at\": \"2022-02-14T00:00:00Z\",\n    \"payment_method\": \"credit_card\",\n    \"currency\": \"BRL\",\n    \"installments\": 1,\n    \"status\": \"active\",\n    \"created_at\": \"2022-01-12T15:22:04Z\",\n    \"updated_at\": \"2022-01-12T15:59:58Z\",\n    \"customer\": {\n        \"id\": \"cus_Vg47ZR5qFqS9j0nr\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"297a5636-3dc1-4cca-b590-c00729b9c322@avengers.com\",\n        \"document\": \"78057744049\",\n        \"type\": \"individual\",\n        \"delinquent\": false,\n        \"created_at\": \"2022-01-12T15:22:04Z\",\n        \"updated_at\": \"2022-01-12T15:22:04Z\",\n        \"phones\": {\n            \"home_phone\": {\n                \"country_code\": \"55\",\n                \"number\": \"22180513\",\n                \"area_code\": \"21\"\n            }\n        }\n    },\n    \"card\": {\n        \"id\": \"card_1jgv2gMiE3S9ROlX\",\n        \"first_six_digits\": \"400000\",\n        \"last_four_digits\": \"0010\",\n        \"brand\": \"Visa\",\n        \"holder_name\": \"Tony Stark\",\n        \"exp_month\": 1,\n        \"exp_year\": 2022,\n        \"status\": \"active\",\n        \"type\": \"credit\",\n        \"created_at\": \"2022-01-12T15:22:04Z\",\n        \"updated_at\": \"2022-01-12T15:22:04Z\",\n        \"billing_address\": {\n            \"street\": \"Malibu Point\",\n            \"number\": \"10880\",\n            \"zip_code\": \"90265\",\n            \"neighborhood\": \"Central Malibu\",\n            \"city\": \"Malibu\",\n            \"state\": \"CA\",\n            \"country\": \"US\",\n            \"line_1\": \"10880, Malibu Point, Central Malibu\"\n        }\n    },\n    \"items\": [\n        {\n            \"id\": \"si_7ga8GLwEhYf63JMR\",\n            \"name\": \"Premium\",\n            \"description\": \"Sem anuncios\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2022-01-12T15:22:05Z\",\n            \"updated_at\": \"2022-01-12T15:22:05Z\",\n            \"pricing_scheme\": {\n                \"price\": 1490,\n                \"scheme_type\": \"unit\"\n            }\n        },\n        {\n            \"id\": \"si_8lwNdZKTmfqOBXME\",\n            \"name\": \"Silver\",\n            \"description\": \"Com anuncios\",\n            \"quantity\": 1,\n            \"status\": \"active\",\n            \"created_at\": \"2022-01-12T15:22:05Z\",\n            \"updated_at\": \"2022-01-12T15:22:05Z\",\n            \"pricing_scheme\": {\n                \"price\": 1490,\n                \"scheme_type\": \"unit\"\n            }\n        }\n    ],\n    \"split\": {\n        \"enabled\": false,\n        \"rules\": [\n            {\n                \"id\": \"sr_WadeEMbhkHoAeEP7\",\n                \"type\": \"percentage\",\n                \"amount\": 40,\n                \"recipient\": {\n                    \"id\": \"rp_PxYn9ztlLtvY8lGN\",\n                    \"name\": \"Recipient 1\",\n                    \"email\": \"tstark@avengers.com\",\n                    \"document\": \"26224451990\",\n                    \"description\": \"Recipient 1\",\n                    \"type\": \"individual\",\n                    \"payment_mode\": \"bank_transfer\",\n                    \"status\": \"active\",\n                    \"created_at\": \"2022-01-12T15:21:50Z\",\n                    \"updated_at\": \"2022-01-12T15:21:50Z\"\n                },\n                \"options\": {\n                    \"liable\": true,\n                    \"charge_processing_fee\": true,\n                    \"charge_remainder_fee\": true\n                }\n            },\n            {\n                \"id\": \"sr_DAkNVgQQu9UZ6LYz\",\n                \"type\": \"percentage\",\n                \"amount\": 40,\n                \"recipient\": {\n                    \"id\": \"rp_wMQPAKzI6BFwd5Ol\",\n                    \"name\": \"Recipient 2\",\n                    \"email\": \"tstark@avengers.com\",\n                    \"document\": \"26224451990\",\n                    \"description\": \"Recipient 2\",\n                    \"type\": \"individual\",\n                    \"payment_mode\": \"bank_transfer\",\n                    \"status\": \"active\",\n                    \"created_at\": \"2022-01-12T15:59:10Z\",\n                    \"updated_at\": \"2022-01-12T15:59:10Z\"\n                },\n                \"options\": {\n                    \"liable\": true,\n                    \"charge_processing_fee\": true,\n                    \"charge_remainder_fee\": false\n                }\n            },\n            {\n                \"id\": \"sr_0OJ5y8wuKrfGGzNb\",\n                \"type\": \"percentage\",\n                \"amount\": 20,\n                \"recipient\": {\n                    \"id\": \"rp_mWAzMySKwfXNz1oD\",\n                    \"name\": \"Recipient 3\",\n                    \"email\": \"tstark@avengers.com\",\n                    \"document\": \"26224451990\",\n                    \"description\": \"Recipient 2\",\n                    \"type\": \"individual\",\n                    \"payment_mode\": \"bank_transfer\",\n                    \"status\": \"active\",\n                    \"created_at\": \"2022-01-12T15:59:45Z\",\n                    \"updated_at\": \"2022-01-12T15:59:45Z\"\n                },\n                \"options\": {\n                    \"liable\": true,\n                    \"charge_processing_fee\": true,\n                    \"charge_remainder_fee\": false\n                }\n            }\n        ]\n    },\n    \"metadata\": {\n        \"id\": \"teste\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "sub_WpkrQvNriRs6QKGz"
                    },
                    "code": {
                      "type": "string",
                      "example": "EP13T6I0KR"
                    },
                    "start_at": {
                      "type": "string",
                      "example": "2022-01-12T00:00:00Z"
                    },
                    "interval": {
                      "type": "string",
                      "example": "month"
                    },
                    "interval_count": {
                      "type": "integer",
                      "example": 1,
                      "default": 0
                    },
                    "billing_type": {
                      "type": "string",
                      "example": "postpaid"
                    },
                    "current_cycle": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cycle_z7NyjWYtLoCWXnM3"
                        },
                        "start_at": {
                          "type": "string",
                          "example": "2022-01-12T00:00:00Z"
                        },
                        "end_at": {
                          "type": "string",
                          "example": "2022-01-13T23:59:59Z"
                        },
                        "billing_at": {
                          "type": "string",
                          "example": "2022-01-14T00:00:00Z"
                        },
                        "status": {
                          "type": "string",
                          "example": "unbilled"
                        },
                        "cycle": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
                        }
                      }
                    },
                    "next_billing_at": {
                      "type": "string",
                      "example": "2022-02-14T00:00:00Z"
                    },
                    "payment_method": {
                      "type": "string",
                      "example": "credit_card"
                    },
                    "currency": {
                      "type": "string",
                      "example": "BRL"
                    },
                    "installments": {
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
                      "example": "2022-01-12T15:22:04Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2022-01-12T15:59:58Z"
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_Vg47ZR5qFqS9j0nr"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "297a5636-3dc1-4cca-b590-c00729b9c322@avengers.com"
                        },
                        "document": {
                          "type": "string",
                          "example": "78057744049"
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
                          "example": "2022-01-12T15:22:04Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2022-01-12T15:22:04Z"
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
                                  "example": "22180513"
                                },
                                "area_code": {
                                  "type": "string",
                                  "example": "21"
                                }
                              }
                            }
                          }
                        }
                      }
                    },
                    "card": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "card_1jgv2gMiE3S9ROlX"
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
                        "exp_month": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
                        },
                        "exp_year": {
                          "type": "integer",
                          "example": 2022,
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
                          "example": "2022-01-12T15:22:04Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2022-01-12T15:22:04Z"
                        },
                        "billing_address": {
                          "type": "object",
                          "properties": {
                            "street": {
                              "type": "string",
                              "example": "Malibu Point"
                            },
                            "number": {
                              "type": "string",
                              "example": "10880"
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
                            "line_1": {
                              "type": "string",
                              "example": "10880, Malibu Point, Central Malibu"
                            }
                          }
                        }
                      }
                    },
                    "items": {
                      "type": "array",
                      "items": {
                        "type": "object",
                        "properties": {
                          "id": {
                            "type": "string",
                            "example": "si_7ga8GLwEhYf63JMR"
                          },
                          "name": {
                            "type": "string",
                            "example": "Premium"
                          },
                          "description": {
                            "type": "string",
                            "example": "Sem anuncios"
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
                            "example": "2022-01-12T15:22:05Z"
                          },
                          "updated_at": {
                            "type": "string",
                            "example": "2022-01-12T15:22:05Z"
                          },
                          "pricing_scheme": {
                            "type": "object",
                            "properties": {
                              "price": {
                                "type": "integer",
                                "example": 1490,
                                "default": 0
                              },
                              "scheme_type": {
                                "type": "string",
                                "example": "unit"
                              }
                            }
                          }
                        }
                      }
                    },
                    "split": {
                      "type": "object",
                      "properties": {
                        "enabled": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "rules": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "sr_WadeEMbhkHoAeEP7"
                              },
                              "type": {
                                "type": "string",
                                "example": "percentage"
                              },
                              "amount": {
                                "type": "integer",
                                "example": 40,
                                "default": 0
                              },
                              "recipient": {
                                "type": "object",
                                "properties": {
                                  "id": {
                                    "type": "string",
                                    "example": "rp_PxYn9ztlLtvY8lGN"
                                  },
                                  "name": {
                                    "type": "string",
                                    "example": "Recipient 1"
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
                                    "example": "Recipient 1"
                                  },
                                  "type": {
                                    "type": "string",
                                    "example": "individual"
                                  },
                                  "payment_mode": {
                                    "type": "string",
                                    "example": "bank_transfer"
                                  },
                                  "status": {
                                    "type": "string",
                                    "example": "active"
                                  },
                                  "created_at": {
                                    "type": "string",
                                    "example": "2022-01-12T15:21:50Z"
                                  },
                                  "updated_at": {
                                    "type": "string",
                                    "example": "2022-01-12T15:21:50Z"
                                  }
                                }
                              },
                              "options": {
                                "type": "object",
                                "properties": {
                                  "liable": {
                                    "type": "boolean",
                                    "example": true,
                                    "default": true
                                  },
                                  "charge_processing_fee": {
                                    "type": "boolean",
                                    "example": true,
                                    "default": true
                                  },
                                  "charge_remainder_fee": {
                                    "type": "boolean",
                                    "example": true,
                                    "default": true
                                  }
                                }
                              }
                            }
                          }
                        }
                      }
                    },
                    "metadata": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "teste"
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