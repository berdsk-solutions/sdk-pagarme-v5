# Obter recebedor

Retorna um objeto com os dados de um recebedor especÃ­fico.

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
    "/recipients/{recipient_id}": {
      "get": {
        "summary": "Obter recebedor",
        "description": "Retorna um objeto com os dados de um recebedor especÃ­fico.",
        "operationId": "obter-recebedor-1",
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
                  "Contrato antigo": {
                    "value": "{\n    \"id\": \"rp_P6b2aBqtPsbwG7xw\",\n    \"name\": \"Tony Stark\",\n    \"email\": \"tstark@pagar.me\",\n    \"document\": \"26224451990\",\n    \"description\": \"Recebedor tony stark\",\n    \"type\": \"individual\",\n    \"status\": \"active\",\n    \"created_at\": \"2017-08-03T20:29:28Z\",\n    \"updated_at\": \"2017-08-03T20:29:28Z\",\n    \"transfer_settings\": {\n         \"transfer_enabled\": false,\n         \"transfer_interval\": \"Daily\",\n         \"transfer_day\": 0\n    },\n    \"default_bank_account\": {\n        \"id\": \"ba_Ez2lE71FBUPa3XZK\",\n        \"holder_name\": \"Tony Stark\",\n        \"holder_type\": \"individual\",\n        \"holder_document\": \"26224451990\",\n        \"bank\": \"341\",\n        \"branch_number\": \"12345\",\n        \"branch_check_digit\": \"6\",\n        \"account_number\": \"12345\",\n        \"account_check_digit\": \"6\",\n        \"type\": \"checking\",\n        \"status\": \"active\",\n        \"created_at\": \"2017-08-03T20:29:28Z\",\n        \"updated_at\": \"2017-08-03T20:29:28Z\",\n        \"metadata\": {\n            \"key\": \"value\"\n        }\n    },\n    \"gateway_recipients\": [\n        {\n            \"gateway\": \"pagarme\",\n            \"status\": \"active\",\n            \"pgid\": \"re_cj5aaa5i000cdhj6ernz14j1i\",\n            \"createdAt\": \"2017-08-03T20:29:28Z\",\n            \"updatedAt\": \"2017-08-03T20:29:28Z\"\n        }\n    ],\n    \"metadata\": {\n        \"key\": \"value\"\n    }\n}"
                  },
                  "Contrato novo - PF": {
                    "value": "{\n    \"id\": \"re_clt7l11wu03cl019tj3frja7x\",\n    \"name\": \"Antonio da Silva\",\n    \"email\": \"tstark@avengers.com\",\n    \"code\": \"2c0b5b0b-7be5-4a29-b26d-12dd7ed71311\",\n    \"document\": \"26224451990\",\n    \"type\": \"individual\",\n    \"payment_mode\": \"bank_transfer\",\n    \"status\": \"active\",\n    \"created_at\": \"2024-02-29T18:51:57Z\",\n    \"updated_at\": \"2024-02-29T18:51:57Z\",\n    \"transfer_settings\": {\n        \"transfer_enabled\": true,\n        \"transfer_interval\": \"Weekly\",\n        \"transfer_day\": 1\n    },\n    \"default_bank_account\": {\n        \"id\": \"ba_dO5X325CBHr3QYe9\",\n        \"holder_name\": \"Tony Stark\",\n        \"holder_type\": \"individual\",\n        \"holder_document\": \"26224451990\",\n        \"bank\": \"341\",\n        \"branch_number\": \"1234\",\n        \"branch_check_digit\": \"6\",\n        \"account_number\": \"12345\",\n        \"account_check_digit\": \"6\",\n        \"type\": \"checking\",\n        \"status\": \"active\",\n        \"created_at\": \"2024-02-29T18:51:57Z\",\n        \"updated_at\": \"2024-02-29T18:51:57Z\",\n        \"metadata\": {\n            \"key\": \"value\"\n        }\n    },\n    \"gateway_recipients\": [\n        {\n            \"gateway\": \"pagarme\",\n            \"status\": \"active\",\n            \"pgid\": \"re_clt7l11wu03cl019tj3frja7x\",\n            \"createdAt\": \"2024-02-29T18:51:58Z\",\n            \"updatedAt\": \"2024-02-29T18:51:58Z\"\n        }\n    ],\n    \"automatic_anticipation_settings\": {\n        \"enabled\": false,\n        \"type\": \"full\",\n        \"volume_percentage\": 0,\n        \"delay\": 365\n    },\n    \"metadata\": {\n        \"key\": \"value\"\n    },\n    \"register_information\": {\n        \"email\": \"tstark@avengers.com\",\n        \"document\": \"26224451990\",\n        \"type\": \"individual\",\n        \"site_url\": \"http://www.site.com\",\n        \"phone_numbers\": [\n            {\n                \"ddd\": \"77\",\n                \"number\": \"987655432\",\n                \"type\": \"mobile\"\n            }\n        ],\n        \"name\": \"Antonio da Silva\",\n        \"mother_name\": \"Maria da Silva\",\n        \"birthdate\": \"02/10/1990\",\n        \"monthly_income\": \"300000\",\n        \"professional_occupation\": \"Professor\",\n        \"address\": {\n            \"street\": \"Rua Alberto Carvalho\",\n            \"complementary\": \"Apto. 345\",\n            \"street_number\": \"111\",\n            \"neighborhood\": \"Gomes Pereira\",\n            \"city\": \"Porto Seguro\",\n            \"state\": \"BA\",\n            \"zip_code\": \"44900000\",\n            \"reference_point\": \"PrÃ³ximo ao Posto Quatro Rodas\"\n        }\n    }\n}"
                  },
                  "Contrato novo - PJ": {
                    "value": "{\n    \"id\": \"re_clt7md7ej03th019tm0n4c1ct\",\n    \"name\": \"Jorge e Isabel Publicidade e Propaganda\",\n    \"email\": \"teste@teste.com\",\n    \"code\": \"2c0b5b0b-7be5-4a29-b26d-12dd7ed713e0\",\n    \"document\": \"27123482000123\",\n    \"type\": \"company\",\n    \"payment_mode\": \"bank_transfer\",\n    \"status\": \"active\",\n    \"created_at\": \"2024-02-29T19:29:24Z\",\n    \"updated_at\": \"2024-02-29T19:29:24Z\",\n    \"transfer_settings\": {\n        \"transfer_enabled\": true,\n        \"transfer_interval\": \"Weekly\",\n        \"transfer_day\": 1\n    },\n    \"default_bank_account\": {\n        \"id\": \"ba_301y9evH6NIgy6rl\",\n        \"holder_name\": \"Tony Stark\",\n        \"holder_type\": \"individual\",\n        \"holder_document\": \"27123482000123\",\n        \"bank\": \"341\",\n        \"branch_number\": \"1234\",\n        \"branch_check_digit\": \"6\",\n        \"account_number\": \"12345\",\n        \"account_check_digit\": \"6\",\n        \"type\": \"checking\",\n        \"status\": \"active\",\n        \"created_at\": \"2024-02-29T19:29:24Z\",\n        \"updated_at\": \"2024-02-29T19:29:24Z\",\n        \"metadata\": {\n            \"key\": \"value\"\n        }\n    },\n    \"gateway_recipients\": [\n        {\n            \"gateway\": \"pagarme\",\n            \"status\": \"active\",\n            \"pgid\": \"re_clt7md7ej03th019tm0n4c1ct\",\n            \"createdAt\": \"2024-02-29T19:29:24Z\",\n            \"updatedAt\": \"2024-02-29T19:29:24Z\"\n        }\n    ],\n    \"automatic_anticipation_settings\": {\n        \"enabled\": false,\n        \"type\": \"full\",\n        \"volume_percentage\": 0,\n        \"delay\": 365\n    },\n    \"metadata\": {\n        \"key\": \"value\"\n    },\n    \"register_information\": {\n        \"email\": \"teste@teste.com\",\n        \"document\": \"27123482000123\",\n        \"type\": \"corporation\",\n        \"site_url\": \"http://www.site.com\",\n        \"phone_numbers\": [\n            {\n                \"ddd\": \"71\",\n                \"number\": \"99999999\",\n                \"type\": \"mobile\"\n            }\n        ],\n        \"company_name\": \"Jorge e Isabel Publicidade e Propaganda\",\n        \"trading_name\": \"Jorge e Isabel Publicidade e Propaganda ME\",\n        \"annual_revenue\": \"100000000\",\n        \"founding_date\": \"10/10/2010\",\n        \"cnae\": \"4651-6/01\",\n        \"main_address\": {\n            \"street\": \"Av.Santos Lopes\",\n            \"complementary\": \"Apto. 104\",\n            \"street_number\": \"189\",\n            \"neighborhood\": \"Centro\",\n            \"city\": \"IrecÃª\",\n            \"state\": \"BA\",\n            \"zip_code\": \"44900000\",\n            \"reference_point\": \"Em frente ao clube de tiro 1910\"\n        },\n        \"managing_partners\": [\n            {\n                \"name\": \"JoÃ£o da Silva\",\n                \"email\": \"teste@teste.com\",\n                \"document\": \"26224451990\",\n                \"type\": \"individual\",\n                \"birthdate\": \"10/02/1995\",\n                \"monthly_income\": \"300000\",\n                \"professional_occupation\": \"Professor\",\n                \"self_declared_representative\": true,\n                \"address\": {\n                    \"street\": \"Av.Santos Lopes\",\n                    \"complementary\": \"Apto. 104\",\n                    \"street_number\": \"189\",\n                    \"neighborhood\": \"Centro\",\n                    \"city\": \"IrecÃª\",\n                    \"state\": \"BA\",\n                    \"zip_code\": \"44900000\",\n                    \"reference_point\": \"Em frente ao clube de tiro 1910\"\n                },\n                \"phone_numbers\": [\n                    {\n                        \"ddd\": \"71\",\n                        \"number\": \"99999999\",\n                        \"type\": \"mobile\"\n                    },\n                    {\n                        \"ddd\": \"71\",\n                        \"number\": \"97777777\",\n                        \"type\": \"mobile\"\n                    }\n                ]\n            }\n        ]\n    }\n}"
                  }
                },
                "schema": {
                  "oneOf": [
                    {
                      "title": "Contrato antigo",
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "rp_P6b2aBqtPsbwG7xw"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "tstark@pagar.me"
                        },
                        "document": {
                          "type": "string",
                          "example": "26224451990"
                        },
                        "description": {
                          "type": "string",
                          "example": "Recebedor tony stark"
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
                          "example": "2017-08-03T20:29:28Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-08-03T20:29:28Z"
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
                              "example": "ba_Ez2lE71FBUPa3XZK"
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
                              "example": "2017-08-03T20:29:28Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2017-08-03T20:29:28Z"
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
                        },
                        "gateway_recipients": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "gateway": {
                                "type": "string",
                                "example": "pagarme"
                              },
                              "status": {
                                "type": "string",
                                "example": "active"
                              },
                              "pgid": {
                                "type": "string",
                                "example": "re_cj5aaa5i000cdhj6ernz14j1i"
                              },
                              "createdAt": {
                                "type": "string",
                                "example": "2017-08-03T20:29:28Z"
                              },
                              "updatedAt": {
                                "type": "string",
                                "example": "2017-08-03T20:29:28Z"
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
                    },
                    {
                      "title": "Contrato novo - PF",
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "re_clt7l11wu03cl019tj3frja7x"
                        },
                        "name": {
                          "type": "string",
                          "example": "Antonio da Silva"
                        },
                        "email": {
                          "type": "string",
                          "example": "tstark@avengers.com"
                        },
                        "code": {
                          "type": "string",
                          "example": "2c0b5b0b-7be5-4a29-b26d-12dd7ed71311"
                        },
                        "document": {
                          "type": "string",
                          "example": "26224451990"
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
                          "example": "2024-02-29T18:51:57Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2024-02-29T18:51:57Z"
                        },
                        "transfer_settings": {
                          "type": "object",
                          "properties": {
                            "transfer_enabled": {
                              "type": "boolean",
                              "example": true,
                              "default": true
                            },
                            "transfer_interval": {
                              "type": "string",
                              "example": "Weekly"
                            },
                            "transfer_day": {
                              "type": "integer",
                              "example": 1,
                              "default": 0
                            }
                          }
                        },
                        "default_bank_account": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "ba_dO5X325CBHr3QYe9"
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
                              "example": "1234"
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
                              "example": "2024-02-29T18:51:57Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2024-02-29T18:51:57Z"
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
                        },
                        "gateway_recipients": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "gateway": {
                                "type": "string",
                                "example": "pagarme"
                              },
                              "status": {
                                "type": "string",
                                "example": "active"
                              },
                              "pgid": {
                                "type": "string",
                                "example": "re_clt7l11wu03cl019tj3frja7x"
                              },
                              "createdAt": {
                                "type": "string",
                                "example": "2024-02-29T18:51:58Z"
                              },
                              "updatedAt": {
                                "type": "string",
                                "example": "2024-02-29T18:51:58Z"
                              }
                            }
                          }
                        },
                        "automatic_anticipation_settings": {
                          "type": "object",
                          "properties": {
                            "enabled": {
                              "type": "boolean",
                              "example": false,
                              "default": true
                            },
                            "type": {
                              "type": "string",
                              "example": "full"
                            },
                            "volume_percentage": {
                              "type": "integer",
                              "example": 0,
                              "default": 0
                            },
                            "delay": {
                              "type": "integer",
                              "example": 365,
                              "default": 0
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
                        },
                        "register_information": {
                          "type": "object",
                          "properties": {
                            "email": {
                              "type": "string",
                              "example": "tstark@avengers.com"
                            },
                            "document": {
                              "type": "string",
                              "example": "26224451990"
                            },
                            "type": {
                              "type": "string",
                              "example": "individual"
                            },
                            "site_url": {
                              "type": "string",
                              "example": "http://www.site.com"
                            },
                            "phone_numbers": {
                              "type": "array",
                              "items": {
                                "type": "object",
                                "properties": {
                                  "ddd": {
                                    "type": "string",
                                    "example": "77"
                                  },
                                  "number": {
                                    "type": "string",
                                    "example": "987655432"
                                  },
                                  "type": {
                                    "type": "string",
                                    "example": "mobile"
                                  }
                                }
                              }
                            },
                            "name": {
                              "type": "string",
                              "example": "Antonio da Silva"
                            },
                            "mother_name": {
                              "type": "string",
                              "example": "Maria da Silva"
                            },
                            "birthdate": {
                              "type": "string",
                              "example": "02/10/1990"
                            },
                            "monthly_income": {
                              "type": "string",
                              "example": "300000"
                            },
                            "professional_occupation": {
                              "type": "string",
                              "example": "Professor"
                            },
                            "address": {
                              "type": "object",
                              "properties": {
                                "street": {
                                  "type": "string",
                                  "example": "Rua Alberto Carvalho"
                                },
                                "complementary": {
                                  "type": "string",
                                  "example": "Apto. 345"
                                },
                                "street_number": {
                                  "type": "string",
                                  "example": "111"
                                },
                                "neighborhood": {
                                  "type": "string",
                                  "example": "Gomes Pereira"
                                },
                                "city": {
                                  "type": "string",
                                  "example": "Porto Seguro"
                                },
                                "state": {
                                  "type": "string",
                                  "example": "BA"
                                },
                                "zip_code": {
                                  "type": "string",
                                  "example": "44900000"
                                },
                                "reference_point": {
                                  "type": "string",
                                  "example": "PrÃ³ximo ao Posto Quatro Rodas"
                                }
                              }
                            }
                          }
                        }
                      }
                    },
                    {
                      "title": "Contrato novo - PJ",
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "re_clt7md7ej03th019tm0n4c1ct"
                        },
                        "name": {
                          "type": "string",
                          "example": "Jorge e Isabel Publicidade e Propaganda"
                        },
                        "email": {
                          "type": "string",
                          "example": "teste@teste.com"
                        },
                        "code": {
                          "type": "string",
                          "example": "2c0b5b0b-7be5-4a29-b26d-12dd7ed713e0"
                        },
                        "document": {
                          "type": "string",
                          "example": "27123482000123"
                        },
                        "type": {
                          "type": "string",
                          "example": "company"
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
                          "example": "2024-02-29T19:29:24Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2024-02-29T19:29:24Z"
                        },
                        "transfer_settings": {
                          "type": "object",
                          "properties": {
                            "transfer_enabled": {
                              "type": "boolean",
                              "example": true,
                              "default": true
                            },
                            "transfer_interval": {
                              "type": "string",
                              "example": "Weekly"
                            },
                            "transfer_day": {
                              "type": "integer",
                              "example": 1,
                              "default": 0
                            }
                          }
                        },
                        "default_bank_account": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "ba_301y9evH6NIgy6rl"
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
                              "example": "27123482000123"
                            },
                            "bank": {
                              "type": "string",
                              "example": "341"
                            },
                            "branch_number": {
                              "type": "string",
                              "example": "1234"
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
                              "example": "2024-02-29T19:29:24Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2024-02-29T19:29:24Z"
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
                        },
                        "gateway_recipients": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "gateway": {
                                "type": "string",
                                "example": "pagarme"
                              },
                              "status": {
                                "type": "string",
                                "example": "active"
                              },
                              "pgid": {
                                "type": "string",
                                "example": "re_clt7md7ej03th019tm0n4c1ct"
                              },
                              "createdAt": {
                                "type": "string",
                                "example": "2024-02-29T19:29:24Z"
                              },
                              "updatedAt": {
                                "type": "string",
                                "example": "2024-02-29T19:29:24Z"
                              }
                            }
                          }
                        },
                        "automatic_anticipation_settings": {
                          "type": "object",
                          "properties": {
                            "enabled": {
                              "type": "boolean",
                              "example": false,
                              "default": true
                            },
                            "type": {
                              "type": "string",
                              "example": "full"
                            },
                            "volume_percentage": {
                              "type": "integer",
                              "example": 0,
                              "default": 0
                            },
                            "delay": {
                              "type": "integer",
                              "example": 365,
                              "default": 0
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
                        },
                        "register_information": {
                          "type": "object",
                          "properties": {
                            "email": {
                              "type": "string",
                              "example": "teste@teste.com"
                            },
                            "document": {
                              "type": "string",
                              "example": "27123482000123"
                            },
                            "type": {
                              "type": "string",
                              "example": "corporation"
                            },
                            "site_url": {
                              "type": "string",
                              "example": "http://www.site.com"
                            },
                            "phone_numbers": {
                              "type": "array",
                              "items": {
                                "type": "object",
                                "properties": {
                                  "ddd": {
                                    "type": "string",
                                    "example": "71"
                                  },
                                  "number": {
                                    "type": "string",
                                    "example": "99999999"
                                  },
                                  "type": {
                                    "type": "string",
                                    "example": "mobile"
                                  }
                                }
                              }
                            },
                            "company_name": {
                              "type": "string",
                              "example": "Jorge e Isabel Publicidade e Propaganda"
                            },
                            "trading_name": {
                              "type": "string",
                              "example": "Jorge e Isabel Publicidade e Propaganda ME"
                            },
                            "annual_revenue": {
                              "type": "string",
                              "example": "100000000"
                            },
                            "founding_date": {
                              "type": "string",
                              "example": "10/10/2010"
                            },
                            "cnae": {
                              "type": "string",
                              "example": "4651-6/01"
                            },
                            "main_address": {
                              "type": "object",
                              "properties": {
                                "street": {
                                  "type": "string",
                                  "example": "Av.Santos Lopes"
                                },
                                "complementary": {
                                  "type": "string",
                                  "example": "Apto. 104"
                                },
                                "street_number": {
                                  "type": "string",
                                  "example": "189"
                                },
                                "neighborhood": {
                                  "type": "string",
                                  "example": "Centro"
                                },
                                "city": {
                                  "type": "string",
                                  "example": "IrecÃª"
                                },
                                "state": {
                                  "type": "string",
                                  "example": "BA"
                                },
                                "zip_code": {
                                  "type": "string",
                                  "example": "44900000"
                                },
                                "reference_point": {
                                  "type": "string",
                                  "example": "Em frente ao clube de tiro 1910"
                                }
                              }
                            },
                            "managing_partners": {
                              "type": "array",
                              "items": {
                                "type": "object",
                                "properties": {
                                  "name": {
                                    "type": "string",
                                    "example": "JoÃ£o da Silva"
                                  },
                                  "email": {
                                    "type": "string",
                                    "example": "teste@teste.com"
                                  },
                                  "document": {
                                    "type": "string",
                                    "example": "26224451990"
                                  },
                                  "type": {
                                    "type": "string",
                                    "example": "individual"
                                  },
                                  "birthdate": {
                                    "type": "string",
                                    "example": "10/02/1995"
                                  },
                                  "monthly_income": {
                                    "type": "string",
                                    "example": "300000"
                                  },
                                  "professional_occupation": {
                                    "type": "string",
                                    "example": "Professor"
                                  },
                                  "self_declared_representative": {
                                    "type": "boolean",
                                    "example": true,
                                    "default": true
                                  },
                                  "address": {
                                    "type": "object",
                                    "properties": {
                                      "street": {
                                        "type": "string",
                                        "example": "Av.Santos Lopes"
                                      },
                                      "complementary": {
                                        "type": "string",
                                        "example": "Apto. 104"
                                      },
                                      "street_number": {
                                        "type": "string",
                                        "example": "189"
                                      },
                                      "neighborhood": {
                                        "type": "string",
                                        "example": "Centro"
                                      },
                                      "city": {
                                        "type": "string",
                                        "example": "IrecÃª"
                                      },
                                      "state": {
                                        "type": "string",
                                        "example": "BA"
                                      },
                                      "zip_code": {
                                        "type": "string",
                                        "example": "44900000"
                                      },
                                      "reference_point": {
                                        "type": "string",
                                        "example": "Em frente ao clube de tiro 1910"
                                      }
                                    }
                                  },
                                  "phone_numbers": {
                                    "type": "array",
                                    "items": {
                                      "type": "object",
                                      "properties": {
                                        "ddd": {
                                          "type": "string",
                                          "example": "71"
                                        },
                                        "number": {
                                          "type": "string",
                                          "example": "99999999"
                                        },
                                        "type": {
                                          "type": "string",
                                          "example": "mobile"
                                        }
                                      }
                                    }
                                  }
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  ]
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