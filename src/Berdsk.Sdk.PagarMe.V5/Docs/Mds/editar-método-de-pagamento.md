# Editar mÃ©todo de pagamento

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
    "/charges/{charge_id}/payment-method": {
      "patch": {
        "summary": "Editar mÃ©todo de pagamento",
        "description": "",
        "operationId": "editar-mÃ©todo-de-pagamento",
        "parameters": [
          {
            "name": "charge_id",
            "in": "path",
            "description": "CÃ³digo da cobranÃ§a.",
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
                  "payment_method"
                ],
                "properties": {
                  "update_subscription": {
                    "type": "string",
                    "description": "Indica se o meio de pagamento da assinatura deve ser atualizado"
                  },
                  "payment_method": {
                    "type": "string",
                    "description": "Meio de pagamento. Valores possÃ­veis: **credit_card**, **boleto**, **voucher**, **bank_transfer** ou **safety_pay**"
                  },
                  "credit_card": {
                    "type": "object",
                    "description": "Dados sobre o pagamento com cartÃ£o de crÃ©dito (obrigatÃ³rio caso **payment_method** seja **credit_card**).",
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
                    "description": "Dados sobre o pagamento com voucher (obrigatÃ³rio caso **payment_method** seja **voucher**)",
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
                    "description": "Dados sobre o pagamento com boleto (obrigatÃ³rio caso **payment_method** seja **boleto**).",
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
                    "description": "Dados sobre o pagamento com transferÃªncia entre contas bancÃ¡rias. (obrigatÃ³rio caso **payment_method** seja **bank_transfer**).",
                    "properties": {
                      "bank": {
                        "type": "string",
                        "description": "CÃ³digo do Banco. 001 (Banco do Brasil); 237 (Bradesco) e 341 (Itau)."
                      }
                    }
                  },
                  "Pix": {
                    "type": "object",
                    "description": "Dados sobre o pagamento com Pix (obrigatÃ³rio caso **payment_method** seja **Pix**).",
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
                  "reuse_split": {
                    "type": "boolean",
                    "description": "Informa se vamos repassar as regras de split para proxima transaÃ§Ã£o"
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "payment_method": "boleto",
                    "boleto": {
                      "bank": "033",
                      "instructions": "Pagar atÃ© o vencimento",
                      "due_at": "2020-12-31"
                    },
                    "reuse_split": true
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
                    "value": "{\n    \"id\": \"ch_PA2gLJYc9hDxRrXV\",\n    \"code\": \"DPRWS1C38N\",\n    \"gateway_id\": \"c22a0e61-2e3e-4317-b11f-08d03046a1a8\",\n    \"amount\": 1490000,\n    \"status\": \"pending\",\n    \"currency\": \"BRL\",\n    \"payment_method\": \"boleto\",\n    \"created_at\": \"2017-10-05T19:16:51Z\",\n    \"updated_at\": \"2017-10-05T19:18:39Z\",\n    \"customer\": {\n        \"id\": \"cus_9rOWDePfdC5qRYgE\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"a999087b-1fa2-4ed9-8499-5065ebc2a46a@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2017-10-05T19:16:51Z\",\n        \"updated_at\": \"2017-10-05T19:16:51Z\",\n        \"phones\": {}\n    },\n    \"last_transaction\": {\n        \"id\": \"tran_OX28mah1bSP084wB\",\n        \"transaction_type\": \"boleto\",\n        \"gateway_id\": \"659298db-dcae-492a-afc5-47774026ca9f\",\n        \"amount\": 1490000,\n        \"status\": \"generated\",\n        \"success\": true,\n        \"url\": \"https://sandbox.pagar.me/Boleto/ViewBoleto.aspx?659298db-dcae-492a-afc5-47774026ca9f\",\n        \"pdf\": \"https://api.pagar.me/core/v1/transactions/tran_OX28mah1bSP084wB/pdf\",\n        \"line\": \"34191.75009 05636.791237 41234.510000 8 84860001490000\",\n        \"barcode\": \"https://api.pagar.mem/core/v1/transactions/tran_OX28mah1bSP084wB/barcode\",\n        \"qr_code\": \"https://api.pagar.me/core/v1/transactions/tran_OX28mah1bSP084wB/qrcode\",\n        \"nosso_numero\": \"00056367\",\n        \"bank\": \"033\",\n        \"document_number\": \"071838848\",\n        \"instructions\": \"Pagar atÃ© o vencimento\",\n        \"due_at\": \"2020-12-31T00:00:00Z\",\n        \"created_at\": \"2017-10-05T19:18:39Z\",\n        \"updated_at\": \"2017-10-05T19:18:39Z\",\n        \"gateway_response\": {\n            \"code\": \"201\"\n        }\n    },\n    \"metadata\": {\n        \"code\": \"123\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "ch_PA2gLJYc9hDxRrXV"
                    },
                    "code": {
                      "type": "string",
                      "example": "DPRWS1C38N"
                    },
                    "gateway_id": {
                      "type": "string",
                      "example": "c22a0e61-2e3e-4317-b11f-08d03046a1a8"
                    },
                    "amount": {
                      "type": "integer",
                      "example": 1490000,
                      "default": 0
                    },
                    "status": {
                      "type": "string",
                      "example": "pending"
                    },
                    "currency": {
                      "type": "string",
                      "example": "BRL"
                    },
                    "payment_method": {
                      "type": "string",
                      "example": "boleto"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2017-10-05T19:16:51Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2017-10-05T19:18:39Z"
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_9rOWDePfdC5qRYgE"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "a999087b-1fa2-4ed9-8499-5065ebc2a46a@avengers.com"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-10-05T19:16:51Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-10-05T19:16:51Z"
                        },
                        "phones": {
                          "type": "object",
                          "properties": {}
                        }
                      }
                    },
                    "last_transaction": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "tran_OX28mah1bSP084wB"
                        },
                        "transaction_type": {
                          "type": "string",
                          "example": "boleto"
                        },
                        "gateway_id": {
                          "type": "string",
                          "example": "659298db-dcae-492a-afc5-47774026ca9f"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 1490000,
                          "default": 0
                        },
                        "status": {
                          "type": "string",
                          "example": "generated"
                        },
                        "success": {
                          "type": "boolean",
                          "example": true,
                          "default": true
                        },
                        "url": {
                          "type": "string",
                          "example": "https://sandbox.pagar.me/Boleto/ViewBoleto.aspx?659298db-dcae-492a-afc5-47774026ca9f"
                        },
                        "pdf": {
                          "type": "string",
                          "example": "https://api.pagar.me/core/v1/transactions/tran_OX28mah1bSP084wB/pdf"
                        },
                        "line": {
                          "type": "string",
                          "example": "34191.75009 05636.791237 41234.510000 8 84860001490000"
                        },
                        "barcode": {
                          "type": "string",
                          "example": "https://api.pagar.mem/core/v1/transactions/tran_OX28mah1bSP084wB/barcode"
                        },
                        "qr_code": {
                          "type": "string",
                          "example": "https://api.pagar.me/core/v1/transactions/tran_OX28mah1bSP084wB/qrcode"
                        },
                        "nosso_numero": {
                          "type": "string",
                          "example": "00056367"
                        },
                        "bank": {
                          "type": "string",
                          "example": "033"
                        },
                        "document_number": {
                          "type": "string",
                          "example": "071838848"
                        },
                        "instructions": {
                          "type": "string",
                          "example": "Pagar atÃ© o vencimento"
                        },
                        "due_at": {
                          "type": "string",
                          "example": "2020-12-31T00:00:00Z"
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2017-10-05T19:18:39Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2017-10-05T19:18:39Z"
                        },
                        "gateway_response": {
                          "type": "object",
                          "properties": {
                            "code": {
                              "type": "string",
                              "example": "201"
                            }
                          }
                        }
                      }
                    },
                    "metadata": {
                      "type": "object",
                      "properties": {
                        "code": {
                          "type": "string",
                          "example": "123"
                        }
                      }
                    }
                  }
                }
              }
            }
          },
          "412": {
            "description": "412",
            "content": {
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"message\": \"This charge can't have the payment method changed.\"\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "message": {
                      "type": "string",
                      "example": "This charge can't have the payment method changed."
                    }
                  }
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