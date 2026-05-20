# Criar recebedor

Rota para criar um recebedor, definindo os dados do recebedor, transferÃªncia e qual a conta bancÃ¡ria que serÃ¡ utilizada
para envio dos pagamentos.

> ðŸš§ **AtenÃ§Ã£o - MudanÃ§as no contrato de recebedores**
>
> Com objetivo de atender as diretrizes dispostas
> na [Circular 3.978/20 do Banco Central](https://www.bcb.gov.br/pre/normativos/busca/downloadNormativo.asp?arquivo=/Lists/Normativos/Attachments/50905/Circ_3978_v1_O.pdf)
> sobre os procedimentos a serem adotados para prevenÃ§Ã£o Ã  lavagem de dinheiro e financiamento ao terrorismo Ã©
> imprescindÃ­vel o envio de dados mÃ­nimos de cadastro para os sellers dos marketplaces.
>
> O novo contrato para a criaÃ§Ã£o de recebedores entrou em vigor em **Fevereiro de 2024**. Para obter mais informações,
> consulte o
> artigo [MudanÃ§as de contrato na criaÃ§Ã£o de Recebedores](https://docs.pagar.me/page/novas-regras-para-cria%C3%A7%C3%A3o-de-sellers-de-marketplace-c-v5).

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
    "/recipients": {
      "post": {
        "summary": "Criar recebedor",
        "description": "Rota para criar um recebedor, definindo os dados do recebedor, transferÃªncia e qual a conta bancÃ¡ria que serÃ¡ utilizada para envio dos pagamentos.",
        "operationId": "criar-recebedor-1",
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "required": [
                  "register_information",
                  "default_bank_account"
                ],
                "properties": {
                  "code": {
                    "type": "string",
                    "description": "Referencia externa Ãºnica por recebedor"
                  },
                  "register_information": {
                    "type": "object",
                    "description": "Dados cadastrais do recebedor. O objeto deve ser preenchido de acordo com o tipo do recebedor, Pessoa FÃ­sica [PF] ou Pessoa JurÃ­dica [PJ].",
                    "required": [
                      "email",
                      "document",
                      "type",
                      "company_name",
                      "trading_name",
                      "annual_revenue",
                      "name",
                      "birthdate",
                      "monthly_income",
                      "professional_occupation"
                    ],
                    "properties": {
                      "email": {
                        "type": "string",
                        "description": "[PF/PJ] E-mail do recebedor."
                      },
                      "document": {
                        "type": "string",
                        "description": "[PF/PJ] NÃºmero do documento. Recebedores Pessoa FÃ­sica preencherÃ£o o CPF e os recebedores Pessoa JurÃ­dica preencherÃ£o o CNPJ."
                      },
                      "type": {
                        "type": "string",
                        "description": "[PF/PJ] Para recebedores Pessoa FÃ­sica, utilizar 'individual' e para recebedores Pessoa JurÃ­dica, utilizar 'corporation'."
                      },
                      "site_url": {
                        "type": "string",
                        "description": "[PF/PJ] Site do recebedor. ObservaÃ§Ã£o: Ã‰ necessÃ¡rio incluir o protocolo Http ou Https."
                      },
                      "phone_numbers": {
                        "type": "object",
                        "description": "[PJ] Telefone do recebedor.",
                        "required": [
                          "ddd",
                          "number"
                        ],
                        "properties": {
                          "ddd": {
                            "type": "string",
                            "description": "DDD (Discagem Direta Ã  DistÃ¢ncia)"
                          },
                          "number": {
                            "type": "string",
                            "description": "NÃºmero do telefone"
                          },
                          "type": {
                            "type": "string",
                            "description": "Tipo do telefone"
                          }
                        }
                      },
                      "company_name": {
                        "type": "string",
                        "description": "[PJ] Nome fantasia do recebedor. Campo exclusivo para recebedores Pessoa JurÃ­dica."
                      },
                      "trading_name": {
                        "type": "string",
                        "description": "[PJ] RazÃ£o social da empresa. Campo exclusivo para recebedores Pessoa JurÃ­dica."
                      },
                      "annual_revenue": {
                        "type": "integer",
                        "description": "[PJ] Receita anual da empresa. Campo exclusivo para recebedores Pessoa JurÃ­dica.",
                        "format": "int32"
                      },
                      "corporation_type": {
                        "type": "string",
                        "description": "[PJ] Tipo da empresa. Campo exclusivo para recebedores Pessoa JurÃ­dica."
                      },
                      "founding_date": {
                        "type": "string",
                        "description": "[PJ] Data de fundaÃ§Ã£o da empresa. Campo exclusivo para recebedores Pessoa JurÃ­dica."
                      },
                      "main_address": {
                        "type": "object",
                        "description": "[PJ] EndereÃ§o da empresa. Campo exclusivo para recebedores Pessoa JurÃ­dica.",
                        "required": [
                          "street",
                          "complementary",
                          "street_number",
                          "neighborhood",
                          "city",
                          "state",
                          "zip_code",
                          "reference_point"
                        ],
                        "properties": {
                          "street": {
                            "type": "string",
                            "description": "Rua"
                          },
                          "complementary": {
                            "type": "string",
                            "description": "Complemento"
                          },
                          "street_number": {
                            "type": "string",
                            "description": "NÃºmero"
                          },
                          "neighborhood": {
                            "type": "string",
                            "description": "Bairro"
                          },
                          "city": {
                            "type": "string",
                            "description": "Cidade"
                          },
                          "state": {
                            "type": "string",
                            "description": "Estado"
                          },
                          "zip_code": {
                            "type": "string",
                            "description": "CEP. Para endereÃ§o brasileiro, deve conter uma numeraÃ§Ã£o de 8 dÃ­gitos"
                          },
                          "reference_point": {
                            "type": "string",
                            "description": "Ponto de referÃªncia do endereÃ§o"
                          }
                        }
                      },
                      "managing_partners": {
                        "type": "array",
                        "description": "[PJ] Representante legal atrelado a empresa. Campo exclusivo para recebedores Pessoa JurÃ­dica.",
                        "items": {
                          "properties": {
                            "name": {
                              "type": "string",
                              "description": "Nome do representante legal atrelado a empresa representada pelo recebedor"
                            },
                            "email": {
                              "type": "string",
                              "description": "E-mail do representante legal atrelado a empresa representada pelo recebedor"
                            },
                            "document": {
                              "type": "string",
                              "description": "NÃºmero do CPF do representante legal atrelado a empresa representada pelo recebedor"
                            },
                            "type": {
                              "type": "string",
                              "description": "Sempre serÃ¡ 'individual'"
                            },
                            "mother_name": {
                              "type": "string",
                              "description": "Nome da mÃ£e do representante legal atrelado a empresa representada pelo recebedor"
                            },
                            "birthdate": {
                              "type": "string",
                              "description": "AniversÃ¡rio do representante legal atrelado a empresa representada pelo recebedor"
                            },
                            "monthly_income": {
                              "type": "string",
                              "description": "Renda mensal mÃ©dia ou estimada declarada pelo representante legal atrelado a empresa representada pelo recebedor. Exemplo: de R$1.000,00 atÃ© R$2.000,00"
                            },
                            "professional_occupation": {
                              "type": "string",
                              "description": "OcupaÃ§Ã£o profissional do representante legal atrelado a empresa representada pelo recebedor"
                            },
                            "self_declared_legal_representative": {
                              "type": "boolean",
                              "description": "Garantia de que aquele cadastro de pessoal fÃ­sica se identifica como representante legal do CNPJ do recebedor ao qual estÃ¡ atrelado"
                            },
                            "address": {
                              "type": "object",
                              "required": [
                                "street",
                                "complementary",
                                "street_number",
                                "neighborhood",
                                "city",
                                "state",
                                "zip_code",
                                "reference_point"
                              ],
                              "properties": {
                                "street": {
                                  "type": "string",
                                  "description": "Rua"
                                },
                                "complementary": {
                                  "type": "string",
                                  "description": "Complemento"
                                },
                                "street_number": {
                                  "type": "string",
                                  "description": "NÃºmero"
                                },
                                "neighborhood": {
                                  "type": "string",
                                  "description": "Bairro"
                                },
                                "city": {
                                  "type": "string",
                                  "description": "Cidade"
                                },
                                "state": {
                                  "type": "string",
                                  "description": "Estado"
                                },
                                "zip_code": {
                                  "type": "string",
                                  "description": "CEP. Para endereÃ§o brasileiro, deve conter uma numeraÃ§Ã£o de 8 dÃ­gitos"
                                },
                                "reference_point": {
                                  "type": "string",
                                  "description": "Ponto de referÃªncia do endereÃ§o"
                                }
                              }
                            },
                            "phone_numbers": {
                              "type": "array",
                              "items": {
                                "properties": {
                                  "ddd": {
                                    "type": "string",
                                    "description": "DDD (Discagem Direta Ã  DistÃ¢ncia)"
                                  },
                                  "number": {
                                    "type": "string",
                                    "description": "NÃºmero do telefone"
                                  },
                                  "type": {
                                    "type": "string",
                                    "description": "Tipo do telefone"
                                  }
                                },
                                "required": [
                                  "ddd",
                                  "number"
                                ],
                                "type": "object"
                              }
                            }
                          },
                          "required": [
                            "name",
                            "email",
                            "document",
                            "birthdate",
                            "monthly_income",
                            "professional_occupation",
                            "self_declared_legal_representative"
                          ],
                          "type": "object"
                        }
                      },
                      "name": {
                        "type": "string",
                        "description": "[PF] Nome do recebedor. Campo exclusivo para recebedores Pessoa FÃ­sica."
                      },
                      "mother_name": {
                        "type": "string",
                        "description": "[PF] Nome da mÃ£e. Campo exclusivo para recebedores Pessoa FÃ­sica."
                      },
                      "birthdate": {
                        "type": "string",
                        "description": "[PF] AniversÃ¡rio. Campo exclusivo para recebedores Pessoa FÃ­sica."
                      },
                      "monthly_income": {
                        "type": "integer",
                        "description": "[PF] Renda mensal. Campo exclusivo para recebedores Pessoa FÃ­sica.",
                        "format": "int32"
                      },
                      "professional_occupation": {
                        "type": "string",
                        "description": "[PF] OcupaÃ§Ã£o profissional. Campo exclusivo para recebedores Pessoa FÃ­sica."
                      },
                      "address": {
                        "type": "object",
                        "description": "[PF] EndereÃ§o do recebedor.",
                        "required": [
                          "street",
                          "complementary",
                          "street_number",
                          "neighborhood",
                          "city",
                          "state",
                          "zip_code",
                          "reference_point"
                        ],
                        "properties": {
                          "street": {
                            "type": "string",
                            "description": "Rua"
                          },
                          "complementary": {
                            "type": "string",
                            "description": "Complemento"
                          },
                          "street_number": {
                            "type": "string",
                            "description": "NÃºmero"
                          },
                          "neighborhood": {
                            "type": "string",
                            "description": "Bairro"
                          },
                          "city": {
                            "type": "string",
                            "description": "Cidade"
                          },
                          "state": {
                            "type": "string",
                            "description": "Estado"
                          },
                          "zip_code": {
                            "type": "string",
                            "description": "CEP. Para endereÃ§o brasileiro, deve conter uma numeraÃ§Ã£o de 8 dÃ­gitos"
                          },
                          "reference_point": {
                            "type": "string",
                            "description": "Ponto de referÃªncia do endereÃ§o"
                          }
                        }
                      }
                    }
                  },
                  "default_bank_account": {
                    "type": "object",
                    "description": "Dados da conta bancÃ¡ria do recebedor.",
                    "required": [
                      "holder_name",
                      "holder_type",
                      "holder_document",
                      "bank",
                      "branch_number",
                      "account_number",
                      "account_check_digit",
                      "type"
                    ],
                    "properties": {
                      "holder_name": {
                        "type": "string",
                        "description": "Nome do titular da conta."
                      },
                      "holder_type": {
                        "type": "string",
                        "description": "Tipo de titular. Valores possÃ­veis sÃ£o **individual** (pessoa fÃ­sica) ou **company** (pessoa jurÃ­dica)."
                      },
                      "holder_document": {
                        "type": "string",
                        "description": "NÃºmero do documento do titular da conta. Deve ser igual ao documento do recebedor."
                      },
                      "bank": {
                        "type": "string",
                        "description": "CÃ³digo do banco."
                      },
                      "branch_number": {
                        "type": "string",
                        "description": "NÃºmero da agÃªncia."
                      },
                      "branch_check_digit": {
                        "type": "string",
                        "description": "CÃ³digo verificador da agÃªncia."
                      },
                      "account_number": {
                        "type": "string",
                        "description": "NÃºmero da conta. MÃ¡ximo 13 caracteres numÃ©ricos"
                      },
                      "account_check_digit": {
                        "type": "string",
                        "description": "CÃ³digo verificador da conta."
                      },
                      "type": {
                        "type": "string",
                        "description": "Tipo da conta. Valores possÃ­veis sÃ£o **checking** ou **savings**."
                      },
                      "metadata": {
                        "type": "object",
                        "description": "Objeto chave/valor utilizado para armazenar informaÃ§Ãµes adicionais sobre a conta bancÃ¡ria.",
                        "properties": {}
                      }
                    }
                  },
                  "transfer_settings": {
                    "type": "object",
                    "description": "InformaÃ§Ãµes de transferÃªncia do recebedor",
                    "properties": {
                      "transfer_enabled": {
                        "type": "boolean",
                        "description": "_Indica se o recebedor receberÃ¡ seus pagamentos automaticamente `."
                      },
                      "transfer_interval": {
                        "type": "string",
                        "description": "Indica a frequÃªncia das transferÃªncias automÃ¡ticas para a conta do recebedor."
                      },
                      "transfer_day": {
                        "type": "integer",
                        "description": "Indica o dia em que ocorrerÃ¡ as transferÃªncias automÃ¡ticas.",
                        "format": "int32"
                      }
                    }
                  },
                  "automatic_anticipation_settings": {
                    "type": "object",
                    "description": "InformaÃ§Ãµes de antecipaÃ§Ã£o automÃ¡tica do recebedor",
                    "properties": {
                      "enabled": {
                        "type": "boolean",
                        "description": "Indica se o recebedor receberÃ¡ antecipaÃ§Ãµes automaticamente"
                      },
                      "type": {
                        "type": "string",
                        "description": "ndica o tipo de antecipaÃ§Ã£o automÃ¡tica que serÃ¡ configurado para a conta do recebedor. Valores possÃ­veis **full** e **1025**."
                      },
                      "volume_percentage": {
                        "type": "string",
                        "description": "Indica o volume passÃ­vel de ser antecipado para o recebedor."
                      },
                      "days": {
                        "type": "array",
                        "description": "Indica os dias em que ocorrerÃ¡ as antecipaÃ§Ãµes automÃ¡ticas.",
                        "items": {
                          "type": "string"
                        }
                      },
                      "delay": {
                        "type": "string",
                        "description": "Indica a quantidade de dias que serÃ£o desconsiderados na contabilizaÃ§Ã£o do valor passÃ­vel de ser antecipado. A contagem de dias Ã© realizada a partir do dia da antecipaÃ§Ã£o para trÃ¡s"
                      }
                    }
                  },
                  "metadata": {
                    "type": "string",
                    "description": "Objeto chave/valor utilizado para armazenar informaÃ§Ãµes adicionais sobre o recebedor."
                  }
                }
              },
              "examples": {
                "Request Pessoa JurÃ­dica": {
                  "value": {
                    "code": "1234",
                    "register_information": {
                      "company_name": "Recebedor pessoa juridica",
                      "trading_name": "Empresa LTDA",
                      "email": "empresax@avengers.com",
                      "document": "77699131000133",
                      "type": "corporation",
                      "site_url": "http://www.site.com",
                      "annual_revenue": 1000000,
                      "corporation_type": "LTDA",
                      "founding_date": "2010-10-30",
                      "main_address": {
                        "street": "Av. General Justo",
                        "complementary": "Bloco A",
                        "street_number": "375",
                        "neighborhood": "Centro",
                        "city": "Rio de Janeiro",
                        "state": "RJ",
                        "zip_code": "20021130",
                        "reference_point": "Ao lado da banca de jornal"
                      },
                      "phone_numbers": [
                        {
                          "ddd": "21",
                          "number": "994647568",
                          "type": "mobile"
                        }
                      ],
                      "managing_partners": [
                        {
                          "name": "Tony Stark",
                          "email": "tstark@avengers.com",
                          "document": "26224451990",
                          "type": "individual",
                          "mother_name": "Nome da mae",
                          "birthdate": "12/10/1995",
                          "monthly_income": 120000,
                          "professional_occupation": "Vendedor",
                          "self_declared_legal_representative": true,
                          "address": {
                            "street": "Av. General Justo",
                            "complementary": "Bloco A",
                            "street_number": "375",
                            "neighborhood": "Centro",
                            "city": "Rio de Janeiro",
                            "state": "RJ",
                            "zip_code": "20021130",
                            "reference_point": "Ao lado da banca de jornal"
                          },
                          "phone_numbers": [
                            {
                              "ddd": "27",
                              "number": "999992628",
                              "type": "mobile"
                            }
                          ]
                        }
                      ]
                    },
                    "transfer_settings": {
                      "transfer_enabled": "false",
                      "transfer_interval": "Daily",
                      "transfer_day": 0
                    },
                    "default_bank_account": {
                      "holder_name": "Tony Stark",
                      "holder_type": "individual",
                      "holder_document": "26224451990",
                      "bank": "341",
                      "branch_number": "1234",
                      "branch_check_digit": "6",
                      "account_number": "12345",
                      "account_check_digit": "6",
                      "type": "checking"
                    },
                    "automatic_anticipation_settings": {
                      "enabled": "true",
                      "type": "full",
                      "volume_percentage": "50",
                      "delay": "null"
                    }
                  }
                },
                "Request Pessoa FÃ­sica": {
                  "value": {
                    "code": "1234",
                    "register_information": {
                      "name": "Recebedor Pessoa fisica",
                      "email": "tstark@avengers.com",
                      "document": "26224451990",
                      "type": "individual",
                      "site_url": "https://sitedorecebedor.com.br",
                      "mother_name": "Nome da mae",
                      "birthdate": "12/10/1995",
                      "monthly_income": 120000,
                      "professional_occupation": "Vendedor",
                      "address": {
                        "street": "Av. General Justo",
                        "complementary": "Bloco A",
                        "street_number": "375",
                        "neighborhood": "Centro",
                        "city": "Rio de Janeiro",
                        "state": "RJ",
                        "zip_code": "20021130",
                        "reference_point": "Ao lado da banca de jornal"
                      },
                      "phone_numbers": [
                        {
                          "ddd": "21",
                          "number": "994647568",
                          "type": "mobile"
                        }
                      ]
                    },
                    "transfer_settings": {
                      "transfer_enabled": "false",
                      "transfer_interval": "Daily",
                      "transfer_day": 0
                    },
                    "default_bank_account": {
                      "holder_name": "Tony Stark",
                      "holder_type": "individual",
                      "holder_document": "26224451990",
                      "bank": "341",
                      "branch_number": "1234",
                      "branch_check_digit": "6",
                      "account_number": "12345",
                      "account_check_digit": "6",
                      "type": "checking"
                    },
                    "automatic_anticipation_settings": {
                      "enabled": "true",
                      "type": "full",
                      "volume_percentage": "50",
                      "delay": "null"
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
                    "value": "{\n    \"id\": \"re_clxnqkxk709sc019taqhmj4kf\",\n    \"name\": \"Antonio da Silva\",\n    \"email\": \"tstark@avengers.com\",\n    \"code\": \"21875b51-d4c3-46d3-aeee-d8b3112aab55\",\n    \"document\": \"26224451990\",\n    \"type\": \"individual\",\n    \"payment_mode\": \"bank_transfer\",\n    \"status\": \"active\",\n    \"created_at\": \"2024-06-20T20:50:31Z\",\n    \"updated_at\": \"2024-06-20T20:50:31Z\",\n    \"transfer_settings\": {\n        \"transfer_enabled\": true,\n        \"transfer_interval\": \"Weekly\",\n        \"transfer_day\": 1\n    },\n    \"default_bank_account\": {\n        \"id\": \"ba_LlpvMnqcXSO2EVW8\",\n        \"holder_name\": \"Tony Stark\",\n        \"holder_type\": \"individual\",\n        \"holder_document\": \"26224451990\",\n        \"bank\": \"341\",\n        \"branch_number\": \"1234\",\n        \"branch_check_digit\": \"6\",\n        \"account_number\": \"12345\",\n        \"account_check_digit\": \"6\",\n        \"type\": \"checking\",\n        \"status\": \"active\",\n        \"created_at\": \"2024-06-20T20:50:31Z\",\n        \"updated_at\": \"2024-06-20T20:50:31Z\",\n        \"metadata\": {\n            \"key\": \"value\"\n        }\n    },\n    \"gateway_recipients\": [\n        {\n            \"gateway\": \"pagarme\",\n            \"status\": \"active\",\n            \"pgid\": \"re_clxnqkxk709sc019taqhmj4kf\",\n            \"createdAt\": \"2024-06-20T20:50:31Z\",\n            \"updatedAt\": \"2024-06-20T20:50:31Z\"\n        }\n    ],\n    \"automatic_anticipation_settings\": {\n        \"enabled\": false,\n        \"type\": \"full\",\n        \"volume_percentage\": 0,\n        \"delay\": 365\n    },\n    \"metadata\": {\n        \"key\": \"value\"\n    },\n    \"register_information\": {\n        \"email\": \"tstark@avengers.com\",\n        \"document\": \"26224451990\",\n        \"type\": \"individual\",\n        \"site_url\": \"http://www.site.com\",\n        \"phone_numbers\": [\n            {\n                \"ddd\": \"77\",\n                \"number\": \"987655432\",\n                \"type\": \"mobile\"\n            }\n        ],\n        \"name\": \"Antonio da Silva\",\n        \"mother_name\": \"Maria da Silva\",\n        \"birthdate\": \"02/10/1990\",\n        \"monthly_income\": \"3000\",\n        \"professional_occupation\": \"Professor\",\n        \"address\": {\n            \"street\": \"Rua Alberto Carvalho\",\n            \"complementary\": \"Apto. 345\",\n            \"street_number\": \"111\",\n            \"neighborhood\": \"Gomes Pereira\",\n            \"city\": \"Porto Seguro\",\n            \"state\": \"BA\",\n            \"zip_code\": \"44900000\",\n            \"reference_point\": \"PrÃ³ximo ao Posto Quatro Rodas\"\n        }\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "re_clxnqkxk709sc019taqhmj4kf"
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
                      "example": "21875b51-d4c3-46d3-aeee-d8b3112aab55"
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
                      "example": "2024-06-20T20:50:31Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2024-06-20T20:50:31Z"
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
                          "example": "ba_LlpvMnqcXSO2EVW8"
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
                          "example": "2024-06-20T20:50:31Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2024-06-20T20:50:31Z"
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
                            "example": "re_clxnqkxk709sc019taqhmj4kf"
                          },
                          "createdAt": {
                            "type": "string",
                            "example": "2024-06-20T20:50:31Z"
                          },
                          "updatedAt": {
                            "type": "string",
                            "example": "2024-06-20T20:50:31Z"
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
                          "example": "3000"
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