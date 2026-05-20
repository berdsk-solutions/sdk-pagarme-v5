# Editar recebedor

Rota para editar um recebedor, definindo os dados do recebedor, transferÃªncia e qual a conta bancÃ¡ria que serÃ¡ utilizada
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
    "/recipients/{recipient_id}": {
      "put": {
        "summary": "Editar recebedor",
        "description": "Rota para editar um recebedor, definindo os dados do recebedor, transferÃªncia e qual a conta bancÃ¡ria que serÃ¡ utilizada para envio dos pagamentos.",
        "operationId": "editar-recebedor-1",
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "properties": {
                  "register_information": {
                    "type": "object",
                    "description": "Dados cadastrais do recebedor. O objeto deve ser preenchido de acordo com o tipo do recebedor, Pessoa FÃ­sica [PF] ou Pessoa JurÃ­dica [PJ].",
                    "properties": {
                      "email": {
                        "type": "string",
                        "description": "[PF/PJ] E-mail do recebedor."
                      },
                      "document": {
                        "type": "string",
                        "description": "[PF/PJ] Para recebedores Pessoa FÃ­sica, utilizar 'individual' e para recebedores Pessoa JurÃ­dica, utilizar 'corporation'."
                      },
                      "site_url": {
                        "type": "string",
                        "description": "[PF/PJ] Site do recebedor. ObservaÃ§Ã£o: Ã‰ necessÃ¡rio incluir o protocolo Http ou Https."
                      },
                      "phone_numbers": {
                        "type": "array",
                        "description": "[PJ/PJ] Telefone do recebedor.",
                        "items": {
                          "properties": {
                            "ddd": {
                              "type": "string",
                              "description": "DDD (Discagem Direta Ã  Distância)"
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
                      },
                      "main_address": {
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
                      }
                    }
                  },
                  "metadata": {
                    "type": "string",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre o recebedor."
                  }
                }
              },
              "examples": {
                "Request Pessoa JurÃ­dica": {
                  "value": {
                    "register_information": {
                      "type": "corporation",
                      "document": "27123482000123",
                      "site_url": "http://www.site.com",
                      "company_name": "Jorge e Isabel Publicidade e Propaganda Alterado",
                      "trading_name": "Jorge e Isabel Publicidade e Propaganda ME Alterado",
                      "annual_revenue": "100000000",
                      "email": "alterado@teste.com",
                      "founding_date": "10/11/2010",
                      "cnae": "8599-6/03",
                      "managing_partners": [
                        {
                          "document": "26224451990",
                          "type": "individual",
                          "name": "JoÃ£o da Silva Alterado",
                          "birthdate": "10/02/1995 Alterado",
                          "email": "alterado@teste.com",
                          "monthly_income": "30000",
                          "professional_occupation": "Professor Alterado",
                          "self_declared_legal_representative": true,
                          "address": {
                            "street": "Av.Santos Lopes Alterada",
                            "complementary": "Apto. 104 Alterado",
                            "street_number": "189 Alterado",
                            "neighborhood": "Centro Alterado",
                            "city": "IrecÃª Alterado",
                            "state": "BA Alterado",
                            "zip_code": "44900000 Alterado",
                            "reference_point": "Em frente ao clube de tiro 1910 Alterado"
                          },
                          "phone_numbers": [
                            {
                              "ddd": "75",
                              "number": "98999999",
                              "type": "celular"
                            },
                            {
                              "ddd": "75",
                              "number": "98777777",
                              "type": "celular"
                            }
                          ]
                        }
                      ],
                      "main_address": {
                        "street": "Av.Santos Lopes Alterado",
                        "complementary": "Apto. 104 Alterado",
                        "street_number": "189 Alterado",
                        "neighborhood": "Centro Alterado",
                        "city": "IrecÃª Alterado",
                        "state": "BA Alterado",
                        "zip_code": "44900000 Alterado",
                        "reference_point": "Em frente ao clube de tiro 1910 Alterado"
                      },
                      "phone_numbers": [
                        {
                          "ddd": "75",
                          "number": "97999991",
                          "type": "celular"
                        }
                      ]
                    },
                    "metadata": {
                      "meta_key": "meta_value"
                    }
                  }
                },
                "Request Pessoa FÃ­sica": {
                  "value": {
                    "register_information": {
                      "email": "change@avengers.com",
                      "document": "26224451990",
                      "type": "individual",
                      "site_url": "http://www.site.com",
                      "phone_numbers": [
                        {
                          "ddd": "85",
                          "number": "987655433",
                          "type": "celular"
                        }
                      ],
                      "name": "Antonio da Silva e Santos",
                      "mother_name": "Maria da Silva Santos",
                      "birthdate": "02/02/1990",
                      "monthly_income": "30000",
                      "professional_occupation": "Padeiro",
                      "address": {
                        "street": "Rua Alberto Pereira",
                        "complementary": "Apto. 348",
                        "street_number": "115",
                        "neighborhood": "Gomes Souza",
                        "city": "Campina Grande",
                        "state": "PB",
                        "zip_code": "44900012",
                        "reference_point": "Em frente a UFPB"
                      }
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
                    "value": ""
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