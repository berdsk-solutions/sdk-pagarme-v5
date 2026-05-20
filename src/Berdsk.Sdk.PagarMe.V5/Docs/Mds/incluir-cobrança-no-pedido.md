# Incluir cobranÃ§a no pedido

Enquanto um pedido estiver **aberto**, Ã© possÃ­vel adicionar novas cobranÃ§as utilizando o `order_id` na criaÃ§Ã£o de uma
cobranÃ§a.

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
    "/charges": {
      "post": {
        "summary": "Incluir cobranÃ§a no pedido",
        "description": "Enquanto um pedido estiver **aberto**, Ã© possÃ­vel adicionar novas cobranÃ§as utilizando o `order_id` na criaÃ§Ã£o de uma cobranÃ§a.",
        "operationId": "incluir-cobranÃ§a-no-pedido",
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "required": [
                  "order_id",
                  "amount",
                  "payment"
                ],
                "properties": {
                  "order_id": {
                    "type": "string",
                    "description": "CÃ³digo do pedido"
                  },
                  "amount": {
                    "type": "integer",
                    "description": "Valor da cobranÃ§a em centavos",
                    "format": "int32"
                  },
                  "payment": {
                    "type": "object",
                    "description": "Dados sobre pagamento.",
                    "properties": {
                      "payment_method": {
                        "type": "string",
                        "description": "Meio de pagamento. Valores possÃ­veis: credit_card, boleto, voucher, bank_transfer, safety_pay, cash, pix",
                        "default": "credit_card"
                      },
                      "credit_card": {
                        "type": "object",
                        "description": "Dados sobre o pagamento com cartÃ£o de crÃ©dito (obrigatÃ³rio caso o payment_method seja credit_card)",
                        "properties": {
                          "operation_type": {
                            "type": "string",
                            "description": "Indica se a transaÃ§Ã£o deve ser capturada \"auth_and_capture\", autorizada \"auth_only\", ou prÃ© autorizada \"pre_auth\"."
                          },
                          "installments": {
                            "type": "integer",
                            "description": "Quantidade de parcelas. Se a transaÃ§Ã£o for uma recorrÃªncia, o nÃºmero de parcelas deverÃ¡ ser 1.",
                            "format": "int32"
                          },
                          "statement_descriptor": {
                            "type": "string",
                            "description": "Texto exibido na fatura do cartÃ£o. Max: 22 caracteres para clientes Gateway; 13 para clientes PSP"
                          },
                          "card": {
                            "type": "object",
                            "description": "CartÃ£o de crÃ©dito.",
                            "required": [
                              "number",
                              "holder_name",
                              "exp_month",
                              "exp_year"
                            ],
                            "properties": {
                              "number": {
                                "type": "string",
                                "description": "NÃºmero do cartÃ£o. Entre 13 e 19 caracteres"
                              },
                              "holder_name": {
                                "type": "string",
                                "description": "Nome do portador como estÃ¡ impresso no cartÃ£o. MÃ¡ximo de 64 caracteres (Caracteres especiais e nÃºmeros nÃ£o sÃ£o aceitos)"
                              },
                              "holder_document": {
                                "type": "string",
                                "description": "CPF ou CNPJ do portador do cartÃ£o. ObrigatÃ³rio caso o tipo do cartÃ£o seja voucher (bandeiras VR ou Pluxee)."
                              },
                              "exp_month": {
                                "type": "integer",
                                "description": "MÃªs de validade do cartÃ£o. Valor entre 1 e 12 (inclusive)",
                                "format": "int32"
                              },
                              "exp_year": {
                                "type": "integer",
                                "description": "Ano de validade do cartÃ£o. Formatos yy ou yyyy. Ex: 23 ou 2023.",
                                "format": "int32"
                              },
                              "cvv": {
                                "type": "string",
                                "description": "CÃ³digo de seguranÃ§a do cartÃ£o. O campo aceita 4 ou 3 caracteres, variando por bandeira."
                              },
                              "brand": {
                                "type": "string",
                                "description": "(Opcional) Bandeira do cartÃ£o. Para cartÃµes de crÃ©dito, temos como valores possÃ­veis: Elo, Mastercard, Visa, Amex, ou Hipercard. Para voucher, temos como valores possÃ­veis: Alelo, Ticket, VR ou Pluxee."
                              },
                              "label": {
                                "type": "string",
                                "description": "Indica a label do cartÃ£o"
                              },
                              "billing_address_id": {
                                "type": "string",
                                "description": "CÃ³digo do endereÃ§o de cobranÃ§a. Max: 36 caracteres.<>Opcional, pode ser utilizado no lugar do billing_address."
                              },
                              "billing_address": {
                                "type": "object",
                                "properties": {
                                  "line_1": {
                                    "type": "string",
                                    "description": "Linha 1 do endereÃ§o. (NÃºmero, Rua, e Bairro - Nesta ordem e separados por vÃ­rgula) Max: 256 caracteres."
                                  },
                                  "line_2": {
                                    "type": "string",
                                    "description": "Linha 2 do endereÃ§o. (Complemento - Andar, Sala, Apto). Max: 128 caracteres."
                                  },
                                  "zip_code": {
                                    "type": "string",
                                    "description": "CEP. Max: 16 caracteres."
                                  },
                                  "city": {
                                    "type": "string",
                                    "description": "Cidade. Max: 64 caracteres."
                                  },
                                  "state": {
                                    "type": "string",
                                    "description": "CÃ³digo do estado no formato ISO 3166-2."
                                  },
                                  "country": {
                                    "type": "string",
                                    "description": "CÃ³digo do paÃ­s no formato ISO 3166-1 alpha-2."
                                  }
                                }
                              }
                            }
                          },
                          "network_token": {
                            "type": "object",
                            "description": "Token de bandeira.",
                            "properties": {
                              "number": {
                                "type": "string",
                                "description": "NÃºmero do Network Token. Entre 13 e 19 caracteres. Ex: 4190000000000069"
                              },
                              "holder_name": {
                                "type": "string",
                                "description": "Nome do portador como estÃ¡ impresso no cartÃ£o. MÃ¡ximo de 64 caracteres (Caracteres especiais e nÃºmeros nÃ£o sÃ£o aceitos)"
                              },
                              "exp_month": {
                                "type": "integer",
                                "description": "MÃªs de validade do Network Token. Valor entre 1 e 12 (inclusive)",
                                "format": "int32"
                              },
                              "exp_year": {
                                "type": "integer",
                                "description": "Ano de validade do Network Token. Formatos yy ou yyyy. Ex: 23 ou 2023.",
                                "format": "int32"
                              },
                              "cryptograms": {
                                "type": "string",
                                "description": "Criptograma de autenticaÃ§Ã£o para Network Token. Pode enviar mais de um, caso queira em uma lista de strings. Formato em base64. Ex: ANfQt43bddROAAEnSAMhAAADFA===="
                              }
                            }
                          },
                          "card_id": {
                            "type": "string",
                            "description": "identificador do cartÃ£o de um cliente."
                          },
                          "card_token": {
                            "type": "string",
                            "description": "token do cartÃ£o gerado pelo checkout transparente"
                          },
                          "recurrence_cycle": {
                            "type": "string",
                            "description": "Informa se o pedido Ã© referente a uma recorrÃªncia externa.  PossÃ­veis valores: `first` ou `subsequent`."
                          },
                          "initiated_type": {
                            "type": "string",
                            "description": "Identificador do tipo de transaÃ§Ã£o avulsa. Valores possÃ­veis: `partial_shipment` (Remessa Parcial), `related_or_delayed_charge` (CobranÃ§a Atrasada), `no_show` (Multa) ou `retry` (Retentativa). Valores possÃ­veis: `standing_order` (Ordem Permanente), `instalment` (Parcelamento) ou `subscription` (Assinatura convencional com valor e frequÃªncia fixa). [Mais detalhes](https://docs.pagar.me/page/mitcit-transa%C3%A7%C3%B5es-card-on-file-mastercard)."
                          },
                          "recurrence_model": {
                            "type": "string",
                            "description": "Identificador do tipo de recorrÃªncia. Valores possÃ­veis: `standing_order` (Ordem Permanente), `instalment` (Parcelamento) ou `subscription` (Assinatura convencional com valor e frequÃªncia fixa). Valores possÃ­veis: `standing_order` (Ordem Permanente), `instalment` (Parcelamento) ou `subscription` (Assinatura convencional com valor e frequÃªncia fixa). [Mais detalhes](https://docs.pagar.me/page/mitcit-transa%C3%A7%C3%B5es-card-on-file-mastercard)."
                          },
                          "payment_origin": {
                            "type": "object",
                            "description": "Identificador da primeira cobranÃ§a de uma recorrÃªncia. [Mais detalhes](https://docs.pagar.me/docs/api-v5-identificador-de-recorr%C3%AAncia-para-assinaturas-externas).",
                            "properties": {
                              "charge_id": {
                                "type": "string",
                                "description": "Identificador da cobranÃ§a"
                              },
                              "brand_id": {
                                "type": "string",
                                "description": "Identificador da bandeira"
                              }
                            }
                          }
                        }
                      },
                      "voucher": {
                        "type": "object",
                        "description": "Dados sobre o pagamento com voucher (obrigatÃ³rio caso o payment_method seja voucher)",
                        "properties": {
                          "statement_descriptor": {
                            "type": "string",
                            "description": "Texto exibido na fatura do cartÃ£o. Max: 22 caracteres."
                          },
                          "card": {
                            "type": "object",
                            "description": "CartÃ£o voucher.",
                            "required": [
                              "number",
                              "holder_name",
                              "exp_month",
                              "exp_year"
                            ],
                            "properties": {
                              "number": {
                                "type": "string",
                                "description": "NÃºmero do cartÃ£o. Entre 13 e 19 caracteres"
                              },
                              "holder_name": {
                                "type": "string",
                                "description": "Nome do portador como estÃ¡ impresso no cartÃ£o. MÃ¡ximo de 64 caracteres (Caracteres especiais e nÃºmeros nÃ£o sÃ£o aceitos)"
                              },
                              "holder_document": {
                                "type": "string",
                                "description": "CPF ou CNPJ do portador do cartÃ£o. ObrigatÃ³rio caso o tipo do cartÃ£o seja voucher (bandeiras VR ou Pluxee)."
                              },
                              "exp_month": {
                                "type": "integer",
                                "description": "MÃªs de validade do cartÃ£o. Valor entre 1 e 12 (inclusive)",
                                "format": "int32"
                              },
                              "exp_year": {
                                "type": "integer",
                                "description": "Ano de validade do cartÃ£o. Formatos yy ou yyyy. Ex: 23 ou 2023.",
                                "format": "int32"
                              },
                              "cvv": {
                                "type": "string",
                                "description": "CÃ³digo de seguranÃ§a do cartÃ£o. O campo aceita 4 ou 3 caracteres, variando por bandeira."
                              },
                              "brand": {
                                "type": "string",
                                "description": "(Opcional) Bandeira do cartÃ£o. Para cartÃµes de crÃ©dito, temos como valores possÃ­veis: Elo, Mastercard, Visa, Amex, ou Hipercard. Para voucher, temos como valores possÃ­veis: Alelo, Ticket, VR ou Pluxee."
                              },
                              "label": {
                                "type": "string",
                                "description": "Indica a label do cartÃ£o"
                              },
                              "billing_address_id": {
                                "type": "string",
                                "description": "CÃ³digo do endereÃ§o de cobranÃ§a. Max: 36 caracteres.<>Opcional, pode ser utilizado no lugar do billing_address."
                              },
                              "billing_address": {
                                "type": "object",
                                "properties": {
                                  "line_1": {
                                    "type": "string",
                                    "description": "Linha 1 do endereÃ§o. (NÃºmero, Rua, e Bairro - Nesta ordem e separados por vÃ­rgula) Max: 256 caracteres."
                                  },
                                  "line_2": {
                                    "type": "string",
                                    "description": "Linha 2 do endereÃ§o. (Complemento - Andar, Sala, Apto). Max: 128 caracteres."
                                  },
                                  "zip_code": {
                                    "type": "string",
                                    "description": "CEP. Max: 16 caracteres."
                                  },
                                  "city": {
                                    "type": "string",
                                    "description": "Cidade. Max: 64 caracteres."
                                  },
                                  "state": {
                                    "type": "string",
                                    "description": "CÃ³digo do estado no formato ISO 3166-2."
                                  },
                                  "country": {
                                    "type": "string",
                                    "description": "CÃ³digo do paÃ­s no formato ISO 3166-1 alpha-2."
                                  }
                                }
                              }
                            }
                          },
                          "card_id": {
                            "type": "string",
                            "description": "identificador do cartÃ£o de um cliente"
                          },
                          "card_token": {
                            "type": "string",
                            "description": "token do cartÃ£o gerado pelo checkout transparente"
                          },
                          "card.holder_document": {
                            "type": "string",
                            "description": "NÃºmero do documento do portador do cartÃ£o. Este campo deverÃ¡ ser enviado dentro do objeto card e Ã© obrigatÃ³rio para voucher."
                          }
                        }
                      },
                      "boleto": {
                        "type": "object",
                        "description": "Dados sobre o pagamento com boleto (obrigatÃ³rio caso o payment_method seja boleto).",
                        "properties": {
                          "bank": {
                            "type": "string",
                            "description": "CÃ³digo do banco. 001 (Banco do Brasil); 033 (Santander); 237 (Bradesco); 341 (Itau); 745 (Citibank) e 104 (Caixa EconÃ´mica Federal)."
                          },
                          "instructions": {
                            "type": "string",
                            "description": "Instruções do boleto. Max: 256 caracteres."
                          },
                          "due_at": {
                            "type": "string",
                            "description": "Data de vencimento. (Opcional)"
                          },
                          "nosso_numero": {
                            "type": "string",
                            "description": "NÃºmero que identifica unicamente um boleto para uma conta."
                          },
                          "type": {
                            "type": "string",
                            "description": "Tipo de espÃ©cie do boleto.DM (Duplicata Mercantil) e BDP (Boleto de proposta)"
                          },
                          "document_number": {
                            "type": "string",
                            "description": "Identificador do boleto. Max: 16 caracteres."
                          },
                          "interest": {
                            "type": "object",
                            "description": "AplicaÃ§Ã£o do juros sobre o boleto.",
                            "required": [
                              "days",
                              "type",
                              "amount"
                            ],
                            "properties": {
                              "days": {
                                "type": "integer",
                                "description": "Dias apÃ³s a expiraÃ§Ã£o do boleto quando o juros deve ser cobrado.",
                                "format": "int32"
                              },
                              "type": {
                                "type": "string",
                                "description": "Tipo de divisÃ£o. Os valores possÃ­veis sÃ£o flat ou percentage."
                              },
                              "amount": {
                                "type": "string",
                                "description": "Valor em porcentagem ou em centavos da taxa de juros que serÃ¡ cobrada ao mÃªs."
                              }
                            }
                          },
                          "fine": {
                            "type": "object",
                            "description": "AplicaÃ§Ã£o da multa sobre o boleto.",
                            "required": [
                              "days",
                              "type",
                              "amount"
                            ],
                            "properties": {
                              "days": {
                                "type": "integer",
                                "description": "Dias apÃ³s a expiraÃ§Ã£o do boleto quando a multa deve ser cobrada.",
                                "format": "int32"
                              },
                              "type": {
                                "type": "string",
                                "description": "Tipo de divisÃ£o. Os valores possÃ­veis sÃ£o flat ou percentage."
                              },
                              "amount": {
                                "type": "integer",
                                "description": "Valor em porcentagem ou em centavos que serÃ¡ cobrada na multa.",
                                "format": "int32"
                              }
                            }
                          },
                          "discount": {
                            "type": "object",
                            "description": "Objeto raiz de desconto por antecipaÃ§Ã£o. Exclusivo PSP.",
                            "properties": {
                              "type": {
                                "type": "string",
                                "description": "Tipo do desconto: \"percentage\" (% sobre o total) ou \"flat\" (centavos). Aplica-se a todas as regras do array."
                              },
                              "rules": {
                                "type": "array",
                                "description": "Lista de regras de desconto ordenadas por limit_date crescente.",
                                "items": {
                                  "properties": {
                                    "limit_date": {
                                      "type": "string",
                                      "description": "Data limite da regra. Formato YYYY-MM-DD. Deve ser anterior ao due_at do boleto."
                                    },
                                    "amount": {
                                      "type": "integer",
                                      "description": "Valor do desconto. Se type: percentage: entre 0.01 e 100 (ex: 15.00 = 15%). Se type: flat: inteiro em centavos, mÃ­n. 1 (ex: 500 = R$5,00).",
                                      "format": "int32"
                                    }
                                  },
                                  "type": "object"
                                }
                              }
                            }
                          }
                        }
                      },
                      "bank_transfer": {
                        "type": "object",
                        "description": "Dados sobre o pagamento com transferÃªncia entre contas bancÃ¡rias. (obrigatÃ³rio caso o payment_method seja bank_transfer)",
                        "properties": {
                          "bank": {
                            "type": "string",
                            "description": "CÃ³digo do Banco. 001 (Banco do Brasil); 237 (Bradesco) e 341 (Itau)."
                          }
                        }
                      },
                      "Pix": {
                        "type": "object",
                        "description": "Dados sobre o pagamento com pix (obrigatÃ³rio caso o payment_method seja pix)",
                        "properties": {
                          "expires_in": {
                            "type": "integer",
                            "description": "Data de expiraÃ§Ã£o do Pix em segundos.",
                            "format": "int32"
                          },
                          "expires_at": {
                            "type": "string",
                            "description": "Data de expiraÃ§Ã£o do Pix. (Opcional | MandatÃ³rio caso nÃ£o enviado o expires_in) [Formato: YYYY-MM-DDThh:mm:ss] UTC",
                            "format": "date"
                          },
                          "additional_information": {
                            "type": "object",
                            "description": "Objeto chave/valor utilizado para adicionar informações sobre o pagamento. Esses dados serÃ£o visÃ­veis para o consumidor na hora do pagamento.",
                            "properties": {
                              "Name": {
                                "type": "string",
                                "description": "Nome utilizado para adicionar informações sobre o pagamento."
                              },
                              "Value": {
                                "type": "string",
                                "description": "Valor utilizado para adicionar informações sobre o pagamento."
                              }
                            }
                          }
                        }
                      },
                      "amount": {
                        "type": "integer",
                        "description": "Valor da cobranÃ§a em centavos",
                        "format": "int32"
                      },
                      "split": {
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
                      },
                      "cash": {
                        "type": "object",
                        "description": "Dados sobre o pagamento com cash(obrigatÃ³rio caso o payment_method seja cash).",
                        "properties": {
                          "description": {
                            "type": "string",
                            "description": "DescriÃ§Ã£o do pagamento. Max: 256 caracteres."
                          },
                          "confirm": {
                            "type": "boolean",
                            "description": "Indica se o pagamento serÃ¡ confirmado no ato da criaÃ§Ã£o da cobranÃ§a ou se deve ser confirmado posteriormente."
                          },
                          "": {
                            "type": "string"
                          }
                        }
                      }
                    }
                  },
                  "due_at": {
                    "type": "string",
                    "description": "Data de vencimento da cobranÃ§a.",
                    "format": "date"
                  },
                  "customer_id": {
                    "type": "string",
                    "description": "CÃ³digo do cliente."
                  },
                  "customer": {
                    "type": "object",
                    "description": "Dados do cliente. Se nem o **customer_id** nem o **customer** forem informados, serÃ¡ considerado o mesmo cliente do pedido.",
                    "properties": {}
                  },
                  "metadata": {
                    "type": "string",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre a cobranÃ§a."
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "order_id": "or_gnvV6V1VTgspL4JB",
                    "amount": 2990,
                    "payment": {
                      "payment_method": "credit_card",
                      "credit_card": {
                        "installments": 1,
                        "statement_descriptor": "AVENGERS",
                        "card": {
                          "number": "342793631858229",
                          "holder_name": "Tony Stark",
                          "exp_month": 1,
                          "exp_year": 30,
                          "cvv": "3531",
                          "billing_address": {
                            "zip_code": "90265",
                            "city": "Malibu",
                            "state": "CA",
                            "country": "US",
                            "line_1": "10880, Malibu Point, Malibu Central"
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
        "responses": {
          "200": {
            "description": "200",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n  \"id\": \"ch_xyRZw5XCLhl3ENjP\",\n  \"code\": \"LM4AVYSYQ9\",\n  \"gateway_id\": \"769e2123-a634-46dc-8bba-529bba7fb726\",\n  \"amount\": 2990,\n  \"status\": \"paid\",\n  \"currency\": \"BRL\",\n  \"payment_method\": \"credit_card\",\n  \"due_at\": \"2017-04-05T00:00:00\",\n  \"paid_at\": \"2017-04-05T05:51:44\",\n  \"created_at\": \"2017-04-05T05:51:37\",\n  \"updated_at\": \"2017-04-05T05:51:37\",\n  \"order\": {\n    \"id\": \"or_gnvV6V1VTgspL4JB\",\n    \"code\": \"MW6JTXGA2V\",\n    \"amount\": 2990,\n    \"currency\": \"BRL\",\n    \"closed\": false,\n    \"status\": \"pending\",\n    \"created_at\": \"2017-04-05T05:51:09\",\n    \"updated_at\": \"2017-04-05T05:51:09\"\n  },\n  \"customer\": {\n    \"id\": \"cus_o9m12XMfrWtYKdLM\",\n    \"name\": \"Tony Stark\",\n    \"email\": \"e44655d3-455a-47bd-a86b-4f537aad95b5@avengers.com\",\n    \"delinquent\": false,\n    \"created_at\": \"2017-04-05T05:51:09\",\n    \"updated_at\": \"2017-04-05T05:51:09\"\n  },\n  \"last_transaction\": {\n    \"id\": \"tran_Bo9LkGUjjiBXLpWk\",\n    \"transaction_type\": \"credit_card\",\n    \"funding_source\": \"prepaid\",\n    \"gateway_id\": \"3b0764c0-6940-4961-bac1-db5be550448a\",\n    \"amount\": 2990,\n    \"status\": \"captured\",\n    \"success\": true,\n    \"installments\": 1,\n    \"statement_descriptor\": \"AVENGERS\",\n    \"acquirer_name\": \"simulator\",\n    \"acquirer_affiliation_code\": \"12345\",\n    \"acquirer_tid\": \"270896\",\n    \"acquirer_nsu\": \"813228\",\n    \"acquirer_auth_code\": \"984353\",\n    \"acquirer_message\": \"Pagarme|TransaÃ§Ã£o autorizada com sucesso\",\n    \"acquirer_return_code\": \"0\",\n    \"operation_type\": \"auth_and_capture\",\n    \"credit_card\": {\n      \"id\": \"card_09eV0PrfQKClNVOd\",\n      \"last_four_digits\": \"8229\",\n      \"brand\": \"Amex\",\n      \"holder_name\": \"Tony Stark\",\n      \"exp_month\": 1,\n      \"exp_year\": 2030,\n      \"status\": \"active\",\n      \"created_at\": \"2017-04-05T05:51:37\",\n      \"updated_at\": \"2017-04-05T05:51:37\",\n      \"billing_address\": {\n         \"zip_code\": \"90265\",\n         \"city\": \"Malibu\",\n         \"state\": \"CA\",\n         \"country\": \"US\",\n         \"line_1\": \"10880, Malibu Point, Malibu Central\"\n      }\n    },\n    \"created_at\": \"2017-04-05T05:51:37\",\n    \"updated_at\": \"2017-04-05T05:51:37\"\n  }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "ch_xyRZw5XCLhl3ENjP"
                    },
                    "code": {
                      "type": "string",
                      "example": "LM4AVYSYQ9"
                    },
                    "gateway_id": {
                      "type": "string",
                      "example": "769e2123-a634-46dc-8bba-529bba7fb726"
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
                    "due_at": {
                      "type": "string",
                      "example": "2017-04-05T00:00:00"
                    },
                    "paid_at": {
                      "type": "string",
                      "example": "2017-04-05T05:51:44"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-04-05T05:51:37"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-04-05T05:51:37"
                    },
                    "order": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "or_gnvV6V1VTgspL4JB"
                        },
                        "code": {
                          "type": "string",
                          "example": "MW6JTXGA2V"
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
                          "example": false,
                          "default": true
                        },
                        "status": {
                          "type": "string",
                          "example": "pending"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-04-05T05:51:09"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-05T05:51:09"
                        }
                      }
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_o9m12XMfrWtYKdLM"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "e44655d3-455a-47bd-a86b-4f537aad95b5@avengers.com"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-04-05T05:51:09"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-05T05:51:09"
                        }
                      }
                    },
                    "last_transaction": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "tran_Bo9LkGUjjiBXLpWk"
                        },
                        "transaction_type": {
                          "type": "string",
                          "example": "credit_card"
                        },
                        "funding_source": {
                          "type": "string",
                          "example": "prepaid"
                        },
                        "gateway_id": {
                          "type": "string",
                          "example": "3b0764c0-6940-4961-bac1-db5be550448a"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 2990,
                          "default": 0
                        },
                        "status": {
                          "type": "string",
                          "example": "captured"
                        },
                        "success": {
                          "type": "boolean",
                          "example": true,
                          "default": true
                        },
                        "installments": {
                          "type": "integer",
                          "example": 1,
                          "default": 0
                        },
                        "statement_descriptor": {
                          "type": "string",
                          "example": "AVENGERS"
                        },
                        "acquirer_name": {
                          "type": "string",
                          "example": "simulator"
                        },
                        "acquirer_affiliation_code": {
                          "type": "string",
                          "example": "12345"
                        },
                        "acquirer_tid": {
                          "type": "string",
                          "example": "270896"
                        },
                        "acquirer_nsu": {
                          "type": "string",
                          "example": "813228"
                        },
                        "acquirer_auth_code": {
                          "type": "string",
                          "example": "984353"
                        },
                        "acquirer_message": {
                          "type": "string",
                          "example": "Pagarme|TransaÃ§Ã£o autorizada com sucesso"
                        },
                        "acquirer_return_code": {
                          "type": "string",
                          "example": "0"
                        },
                        "operation_type": {
                          "type": "string",
                          "example": "auth_and_capture"
                        },
                        "credit_card": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "card_09eV0PrfQKClNVOd"
                            },
                            "last_four_digits": {
                              "type": "string",
                              "example": "8229"
                            },
                            "brand": {
                              "type": "string",
                              "example": "Amex"
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
                              "example": 2030,
                              "default": 0
                            },
                            "status": {
                              "type": "string",
                              "example": "active"
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2017-04-05T05:51:37"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2017-04-05T05:51:37"
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
                            }
                          }
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-04-05T05:51:37"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-04-05T05:51:37"
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