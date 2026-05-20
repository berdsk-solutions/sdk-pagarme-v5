# Editar code de recebedor

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
    "/recipients/{recipient_id}/code": {
      "patch": {
        "summary": "Editar code de recebedor",
        "description": "",
        "operationId": "atualizar-code-de-recebedor",
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
                "required": [
                  "Code"
                ],
                "properties": {
                  "Code": {
                    "type": "string",
                    "description": "Referencia externa Ãºnica por recebedor"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "code": "123"
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
                    "value": "{\n    \"id\": \"rp_23452cBK6lP\",\n    \"name\": \"Tony Stark\",\n    \"email\": \"tstark@avengers.com\",\n    \"document\": \"223451990\",\n    \"description\": \"Recebedor Tony Stark\",\n    \"type\": \"individual\",\n    \"status\": \"active\",\n    \"created_at\": \"2018-05-23T16:17:39Z\",\n    \"updated_at\": \"2018-05-23T16:17:39Z\",\n    \"code\": \"123\",\n    \"transfer_settings\": {\n        \"transfer_enabled\": false,\n        \"transfer_interval\": \"Daily\",\n        \"transfer_day\": 0\n    },\n    \"default_bank_account\": {\n        \"id\": \"ba_2LYnR234Og\",\n        \"holder_name\": \"Tony Stark\",\n        \"holder_type\": \"individual\",\n        \"holder_document\": \"26224451990\",\n        \"bank\": \"341\",\n        \"branch_number\": \"12345\",\n        \"branch_check_digit\": \"6\",\n        \"account_number\": \"12345\",\n        \"account_check_digit\": \"6\",\n        \"type\": \"checking\",\n        \"status\": \"active\",\n        \"created_at\": \"2018-05-23T16:17:40Z\",\n        \"updated_at\": \"2018-05-23T16:17:40Z\",\n        \"metadata\": {\n            \"key\": \"value\"\n        }\n    },\n      \"automatic_anticipation_settings\": {\n        \"enabled\": true,\n        \"type\": \"full\",\n        \"volume_percentage\": 50,\n        \"delay\": 365,\n        \"days\": [\n            1,\n            3,\n            5\n        ]\n    },\n    \"gateway_recipients\": [\n        {\n            \"gateway\": \"pagarme\",\n            \"status\": \"active\",\n            \"pgid\": \"re_cjhjb34244o9jw6dyx5aizxn\",\n            \"createdAt\": \"2018-05-23T16:17:45Z\",\n            \"updatedAt\": \"2018-05-23T16:17:45Z\"\n        }\n    ],\n    \"metadata\": {\n        \"key\": \"value\"\n    }\n}"
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
                    "code": {
                      "type": "string",
                      "example": "123"
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