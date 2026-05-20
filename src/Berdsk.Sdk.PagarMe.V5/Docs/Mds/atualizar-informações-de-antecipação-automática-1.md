# Atualizar configurações de antecipaÃ§Ã£o automÃ¡tica

> â—ï¸ LiberaÃ§Ã£o de configurações de antecipaÃ§Ã£o automÃ¡tica
>
> Para utilizar configurações de antecipaÃ§Ã£o automÃ¡tica Ã© necessÃ¡rio realizar a liberaÃ§Ã£o junto a Pagar.me .

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
    "/recipients/{recipient_id}/automatic-anticipation-settings": {
      "patch": {
        "summary": "Atualizar configurações de antecipaÃ§Ã£o automÃ¡tica",
        "description": "",
        "operationId": "atualizar-informações-de-antecipaÃ§Ã£o-automÃ¡tica-1",
        "parameters": [
          {
            "name": "recipient_id",
            "in": "path",
            "description": "Identificador do recebedor",
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
                    "description": "VariÃ¡vel que indica se o recebedor irÃ¡ possuir antecipaÃ§Ã£o automaticamentica.",
                    "default": false
                  },
                  "type": {
                    "type": "string",
                    "description": "ConfiguraÃ§Ã£o de como devemos criar as antecipações automÃ¡ticas do recebedor. Valores possÃ­veis full  e 1025. Se informado full serÃ¡ criada antecipações seguindo a regra de volume mÃ¡ximo antecipÃ¡vel. Se informado 1025 serÃ¡ criada antecipações de vendas inteiras, modelos D+X e 10/25.",
                    "default": "full"
                  },
                  "volume_percentage": {
                    "type": "string",
                    "description": "Porcentagem do valor passÃ­vel de antecipaÃ§Ã£o para este recebedor. Valores entre 0 e 100."
                  },
                  "days": {
                    "type": "array",
                    "description": "Lista de dias em que serÃ£o criar as antecipações automÃ¡ticas. Valores possÃ­veis de 1 a 31, necessÃ¡rio informar entre chaves\"[ ]\"",
                    "items": {
                      "type": "string"
                    }
                  },
                  "delay": {
                    "type": "string",
                    "description": "Quantidade de dias, contados a partir do dia da antecipaÃ§Ã£o para trÃ¡s, que serÃ£o desconsiderados na criaÃ§Ã£o desta antecipaÃ§Ã£o"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "enabled": true,
                    "type": "full",
                    "volume_percentage": "50",
                    "days": [
                      1,
                      3,
                      5
                    ],
                    "delay": null
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
                    "value": "{\n    \"id\": \"rp_23452cBK6lP\",\n    \"name\": \"Tony Stark\",\n    \"email\": \"tstark@avengers.com\",\n    \"document\": \"223451990\",\n    \"description\": \"Recebedor Tony Stark\",\n    \"type\": \"individual\",\n    \"status\": \"active\",\n    \"created_at\": \"2018-05-23T16:17:39Z\",\n    \"updated_at\": \"2018-05-23T16:17:39Z\",\n    \"transfer_settings\": {\n        \"transfer_enabled\": false,\n        \"transfer_interval\": \"Daily\",\n        \"transfer_day\": 0\n    },\n    \"default_bank_account\": {\n        \"id\": \"ba_2LYnR234Og\",\n        \"holder_name\": \"Tony Stark\",\n        \"holder_type\": \"individual\",\n        \"holder_document\": \"26224451990\",\n        \"bank\": \"341\",\n        \"branch_number\": \"12345\",\n        \"branch_check_digit\": \"6\",\n        \"account_number\": \"12345\",\n        \"account_check_digit\": \"6\",\n        \"type\": \"checking\",\n        \"status\": \"active\",\n        \"created_at\": \"2018-05-23T16:17:40Z\",\n        \"updated_at\": \"2018-05-23T16:17:40Z\",\n        \"metadata\": {\n            \"key\": \"value\"\n        }\n    },\n      \"automatic_anticipation_settings\": {\n        \"enabled\": true,\n        \"type\": \"full\",\n        \"volume_percentage\": 50,\n        \"delay\": 365,\n        \"days\": [\n            1,\n            3,\n            5\n        ]\n    },\n    \"gateway_recipients\": [\n        {\n            \"gateway\": \"pagarme\",\n            \"status\": \"active\",\n            \"pgid\": \"re_cjhjb34244o9jw6dyx5aizxn\",\n            \"createdAt\": \"2018-05-23T16:17:45Z\",\n            \"updatedAt\": \"2018-05-23T16:17:45Z\"\n        }\n    ],\n    \"metadata\": {\n        \"key\": \"value\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "rp_23452cBK6lP"
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
                      "example": "223451990"
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
                      "example": "2018-05-23T16:17:39Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2018-05-23T16:17:39Z"
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
                          "example": "ba_2LYnR234Og"
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
                          "example": "2018-05-23T16:17:40Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-05-23T16:17:40Z"
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
                    "automatic_anticipation_settings": {
                      "type": "object",
                      "properties": {
                        "enabled": {
                          "type": "boolean",
                          "example": true,
                          "default": true
                        },
                        "type": {
                          "type": "string",
                          "example": "full"
                        },
                        "volume_percentage": {
                          "type": "integer",
                          "example": 50,
                          "default": 0
                        },
                        "delay": {
                          "type": "integer",
                          "example": 365,
                          "default": 0
                        },
                        "days": {
                          "type": "array",
                          "items": {
                            "type": "integer",
                            "example": 1,
                            "default": 0
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
                            "example": "re_cjhjb34244o9jw6dyx5aizxn"
                          },
                          "createdAt": {
                            "type": "string",
                            "example": "2018-05-23T16:17:45Z"
                          },
                          "updatedAt": {
                            "type": "string",
                            "example": "2018-05-23T16:17:45Z"
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