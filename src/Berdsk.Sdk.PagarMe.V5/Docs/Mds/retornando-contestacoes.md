# Retornando Contestações

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
      "get": {
        "summary": "Retornando Contestações",
        "description": "",
        "operationId": "retornando-contestacoes",
        "parameters": [
          {
            "name": "contract_key",
            "in": "query",
            "description": "Chave Identificadora do contrato",
            "required": true,
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "page",
            "in": "query",
            "description": "PaginaÃ§Ã£o",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          },
          {
            "name": "size",
            "in": "query",
            "description": "Quantidade de Itens (Contestações) a serem retornardos",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          },
          {
            "name": "id",
            "in": "query",
            "description": "Chave Identificadora da ContestaÃ§Ã£o que foi aberta",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "original_assetHolder_document",
            "in": "query",
            "description": "Documento do originador da UR",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "status",
            "in": "query",
            "description": "Status da ContestaÃ§Ã£o (CÃ³digo do motivo da contestaÃ§Ã£o. A lista dos cÃ³digos estÃ¡ na Response code 200 Enum de System)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "created_at",
            "in": "query",
            "description": "Data de Abertura da ContestaÃ§Ã£o",
            "schema": {
              "type": "string",
              "format": "date"
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
                    "value": "Response 200\n{\n\t\"data\": [\n\t\t{\n\t\t\t\"id\": \"string\",\n\t\t\t\"status\": \"string\",\n\t\t\t\"contested_document\": \"string\",\n\t\t\t\"original_asset_holder_document\": \"string\",\n\t\t\t\"reason_code\": \"string\",\n\t\t\t\"contract_key\": \"string\",\n\t\t\t\"created_at\": \"Date time\",\n\t\t\t\"reason_description\": \"string\",\n\t\t\t\"description\": \"string\",\n\t\t\t\"skip_contract\": boolean\n\t\t}\n\t],\n\t\"paging\": {\n\t\t\"total\": int,\n\t\t\"previous\": \"string\",\n\t\t\"next\": \"string\"\n\t}\n}"
                  }
                }
              },
              "text/plain": {
                "examples": {
                  "Status Code": {
                    "value": "Enum de ReasonCode:\n{\n  // CÃ³digos Legado\n  [Description(\"ContestaÃ§Ã£o com base em rejeiÃ§Ã£o bancÃ¡ria onde a conta teve um erro ao ser invalidada\")]\n  SO07 = 7,\n  \n  [Description(\"ContestaÃ§Ã£o com base em rejeiÃ§Ã£o bancÃ¡ria indevida por parte da ID\")]\n  SO08 = 8,\n  \n  [Description(\"ContestaÃ§Ã£o com base em revogaÃ§Ã£o de optin por parte de um credor\")]\n  SO09 = 9,\n  \n  [Description(\"ContestaÃ§Ã£o com base em evidÃªncia do EC de que o contrato Ã© indevido\")]\n  SO10 = 10,\n  \n  [Description(\"ContestaÃ§Ã£o com base em rejeiÃ§Ã£o por falta de acordo entre o banco e a bandeira no SLC\")]\n  SO11 = 11,\n  \n  // CÃ³digos atuais\n  [Description(\"Problemas para liquidaÃ§Ã£o do instrumento contratual ocasionado pelos dados bancÃ¡rios invÃ¡lidos\")]\n  SO01 = 1,\n  \n  [Description(\"Titular ou usuÃ¡rio final recebedor nÃ£o reconhece a operaÃ§Ã£o\")]\n  SO02 = 2,\n  \n  [Description(\"Duplicidade de lanÃ§amento de operaÃ§Ã£o\")]\n  SO03 = 3,\n  \n  [Description(\"OperaÃ§Ã£o em divergÃªncia com o instrumento contratual\")]\n  SO04 = 4,\n  \n  [Description(\"Outros\")] SO05 = 5,\n  \n  [Description(\"DivergÃªncia entre valor esperado pelo financiador ou pela nÃ£o financeira e o valor efetivamente liquidado pela instituiÃ§Ã£o credenciadora ou subcredenciadora devedora da obrigaÃ§Ã£o\")]\n  SO06 = 6,\n  \n  [Description(\"AusÃªncia de liquidaÃ§Ã£o\")]\n  SO12 = 12,\n  \n  [Description(\"Gravame baixado ainda recebendo liquidações na conta indicada\")]\n  SO13 = 13,\n  \n  [Description(\"Titular ou usuÃ¡rio final recebedor nÃ£o reconhece a anuÃªncia\")]\n  SO15 = 15,\n  \n  [Description(\"ComunicaÃ§Ã£o de resiliÃ§Ã£o ou liberaÃ§Ã£o de excedente nÃ£o atendida\")]\n  SO14 = 14,\n  \n  [Description(\"NÃ£o recebimento da agenda solicitada\")]\n  SO16 = 16,\n  \n  [Description(\"DivergÃªncia de valores na agenda\")]\n  SO17 = 17,\n  \n  [Description(\"Outros\")] \n  SO18 = 18,\n  \n  [Description(\"ComunicaÃ§Ã£o de resiliÃ§Ã£o ou liberaÃ§Ã£o de excedente indevida\")]\n  SO19 = 19\n}"
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
              "language": "text",
              "code": "{\n  contract_key: string\n  page: int\n\tsize: int\n}"
            }
          ],
          "samples-languages": [
            "text"
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