# Contestando um Contrato

![](https://files.readme.io/4af9247-image.png)

# OpenAPI definition

```json
{
  "openapi": "3.1.0",
  "info": {
    "title": "pagarme-api-register-v5",
    "version": "5"
  },
  "servers": [
    {
      "url": "https://api.pagar.me/register/v5"
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
    "/contestations": {
      "post": {
        "summary": "Contestando um Contrato",
        "description": "",
        "operationId": "contestando-um-contrato-v5",
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "required": [
                  "reason_code"
                ],
                "properties": {
                  "author": {
                    "properties": {
                      "email": {
                        "type": "string",
                        "description": "seu e-mail cadastrado no pagar.me"
                      },
                      "system": {
                        "type": "string",
                        "description": "Sistema originador da contestaÃ§Ã£o. Em integraÃ§Ã£o com a API, sempre utilizamos o valor API",
                        "enum": [
                          ""
                        ]
                      },
                      "user_Agent": {
                        "type": "string",
                        "description": "Nome da Sua empresa no Pagar.me"
                      }
                    },
                    "required": [
                      "email",
                      "system",
                      "user_Agent"
                    ],
                    "type": "object"
                  },
                  "original_asset_holder": {
                    "properties": {
                      "name": {
                        "type": "string",
                        "description": "Nome do seller originador do recebÃ­vel."
                      },
                      "document": {
                        "type": "string",
                        "description": "Documento do seller originador do recebÃ­vel."
                      }
                    },
                    "required": [
                      "name"
                    ],
                    "type": "object"
                  },
                  "contested": {
                    "properties": {
                      "name": {
                        "type": "string",
                        "description": "Nome do Credor(Asset Holder)."
                      },
                      "document": {
                        "type": "string",
                        "description": "Documento do Credor(Asset Holder)."
                      }
                    },
                    "required": [
                      "document"
                    ],
                    "type": "object"
                  },
                  "target": {
                    "properties": {
                      "key": {
                        "type": "string",
                        "description": "Chave do contrato obtida no endpoint settlement_obligations"
                      },
                      "type": {
                        "type": "string",
                        "description": "Tipo do contrato, sempre passamos o valor Contract.",
                        "enum": [
                          "Contract"
                        ]
                      }
                    },
                    "required": [
                      "key",
                      "type"
                    ],
                    "type": "object"
                  },
                  "reason_code": {
                    "type": "string",
                    "description": "CÃ³digo do motivo da contestaÃ§Ã£o. A lista dos cÃ³digos estÃ¡ na Response code 200 Enum de System",
                    "enum": [
                      "ContestaÃ§Ã£o com base em rejeiÃ§Ã£o bancÃ¡ria onde a conta teve um erro ao ser invalidada   SO07 = 7",
                      "ContestaÃ§Ã£o com base em rejeiÃ§Ã£o bancÃ¡ria indevida por parte da ID   SO08 = 8",
                      "ContestaÃ§Ã£o com base em revogaÃ§Ã£o de optin por parte de um credor   SO09 = 9",
                      "ContestaÃ§Ã£o com base em evidÃªncia do EC de que o contrato Ã© indevido   SO10 = 10",
                      "ContestaÃ§Ã£o com base em rejeiÃ§Ã£o por falta de acordo entre o banco e a bandeira no SLC   SO11 = 11",
                      "Problemas para liquidaÃ§Ã£o do instrumento contratual ocasionado pelos dados bancÃ¡rios invÃ¡lidos   SO01 = 1",
                      "Titular ou usuÃ¡rio final recebedor nÃ£o reconhece a operaÃ§Ã£o   SO02 = 2",
                      "Duplicidade de lanÃ§amento de operaÃ§Ã£o   SO03 = 3",
                      "OperaÃ§Ã£o em divergÃªncia com o instrumento contratual   SO04 = 4",
                      "Outros SO05 = 5",
                      "DivergÃªncia entre valor esperado pelo financiador ou pela nÃ£o financeira e o valor efetivamente liquidado pela instituiÃ§Ã£o credenciadora ou subcredenciadora devedora da obrigaÃ§Ã£o   SO06 = 6",
                      "AusÃªncia de liquidaÃ§Ã£o   SO12 = 12",
                      "Gravame baixado ainda recebendo liquidações na conta indicada   SO13 = 13",
                      "Titular ou usuÃ¡rio final recebedor nÃ£o reconhece a anuÃªncia   SO15 = 15",
                      "ComunicaÃ§Ã£o de resiliÃ§Ã£o ou liberaÃ§Ã£o de excedente nÃ£o atendida   SO14 = 14",
                      "NÃ£o recebimento da agenda solicitada   SO16 = 16",
                      "DivergÃªncia de valores na agenda   SO17 = 17",
                      "Outros    SO18 = 18",
                      "ComunicaÃ§Ã£o de resiliÃ§Ã£o ou liberaÃ§Ã£o de excedente indevida   SO19 = 19"
                    ]
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
              "text/plain": {
                "examples": {
                  "reasoncode": {
                    "value": "Enum de ReasonCode:\n{\n  // CÃ³digos Legado\n  [Description(\"ContestaÃ§Ã£o com base em rejeiÃ§Ã£o bancÃ¡ria onde a conta teve um erro ao ser invalidada\")]\n  SO07 = 7,\n  \n  [Description(\"ContestaÃ§Ã£o com base em rejeiÃ§Ã£o bancÃ¡ria indevida por parte da ID\")]\n  SO08 = 8,\n  \n  [Description(\"ContestaÃ§Ã£o com base em revogaÃ§Ã£o de optin por parte de um credor\")]\n  SO09 = 9,\n  \n  [Description(\"ContestaÃ§Ã£o com base em evidÃªncia do EC de que o contrato Ã© indevido\")]\n  SO10 = 10,\n  \n  [Description(\"ContestaÃ§Ã£o com base em rejeiÃ§Ã£o por falta de acordo entre o banco e a bandeira no SLC\")]\n  SO11 = 11,\n  \n  // CÃ³digos atuais\n  [Description(\"Problemas para liquidaÃ§Ã£o do instrumento contratual ocasionado pelos dados bancÃ¡rios invÃ¡lidos\")]\n  SO01 = 1,\n  \n  [Description(\"Titular ou usuÃ¡rio final recebedor nÃ£o reconhece a operaÃ§Ã£o\")]\n  SO02 = 2,\n  \n  [Description(\"Duplicidade de lanÃ§amento de operaÃ§Ã£o\")]\n  SO03 = 3,\n  \n  [Description(\"OperaÃ§Ã£o em divergÃªncia com o instrumento contratual\")]\n  SO04 = 4,\n  \n  [Description(\"Outros\")] SO05 = 5,\n  \n  [Description(\"DivergÃªncia entre valor esperado pelo financiador ou pela nÃ£o financeira e o valor efetivamente liquidado pela instituiÃ§Ã£o credenciadora ou subcredenciadora devedora da obrigaÃ§Ã£o\")]\n  SO06 = 6,\n  \n  [Description(\"AusÃªncia de liquidaÃ§Ã£o\")]\n  SO12 = 12,\n  \n  [Description(\"Gravame baixado ainda recebendo liquidações na conta indicada\")]\n  SO13 = 13,\n  \n  [Description(\"Titular ou usuÃ¡rio final recebedor nÃ£o reconhece a anuÃªncia\")]\n  SO15 = 15,\n  \n  [Description(\"ComunicaÃ§Ã£o de resiliÃ§Ã£o ou liberaÃ§Ã£o de excedente nÃ£o atendida\")]\n  SO14 = 14,\n  \n  [Description(\"NÃ£o recebimento da agenda solicitada\")]\n  SO16 = 16,\n  \n  [Description(\"DivergÃªncia de valores na agenda\")]\n  SO17 = 17,\n  \n  [Description(\"Outros\")] \n  SO18 = 18,\n  \n  [Description(\"ComunicaÃ§Ã£o de resiliÃ§Ã£o ou liberaÃ§Ã£o de excedente indevida\")]\n  SO19 = 19\n}"
                  }
                }
              }
            }
          },
          "201": {
            "description": "201",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n  message: \"No Content\"\n}"
                  }
                }
              }
            }
          },
          "401": {
            "description": "401",
            "content": {
              "text/plain": {
                "examples": {
                  "Result": {
                    "value": "{\n  message: \"NÃ£o Autorizado\"\n}"
                  }
                }
              }
            }
          },
          "409": {
            "description": "409",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{DuplicaÃ§Ã£o de contestaÃ§Ã£o ja aberta}"
                  }
                }
              }
            }
          }
        },
        "deprecated": false,
        "x-readme": {
          "code-samples": [
            {
              "language": "curl",
              "code": "{\n    \"author\": {\n        \"email\": \"joao@pagar.me\",\n        \"system\": \"API\",\n        \"user_agent\": \"joao.jorge\"\n    },\n    \"original_asset_holder\": {\n        \"name\": \"033 - Otica \",\n        \"document\": \"00000000000000\"\n    },\n    \"contested\": {\n        \"name\": \"111 - BANCO \",\n        \"document\": \"00000000000000\"\n    },\n    \"target\": {\n        \"key\": \"8935d7g4-0bfg-3f45-8g12-2635gfb3g233\",\n        \"type\": \"Contract\"\n    },\n    \"reason_code\": \"C06ÃŸ\"\n}"
            }
          ],
          "samples-languages": [
            "curl"
          ]
        }
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