# Criar pedido

Essa funcionalidade estÃ¡ disponÃ­vel para clientes Gateway e PSP Pagar.me

> â—ï¸ NÃƒO ENVIE DADOS ABERTOS DO CARTÃƒO DO COMPRADOR
>
> Para poder trafegar dados de cartÃ£o abertos em seu servidor, vocÃª deve
> ser [PCI Compliance. ](https://pagar.me/blog/pci-compliance/)Por isso, **recomendamos fortemente** que as requisições
> sejam enviadas sempre usando o `card_id` ou `card_token`, de forma que vocÃª nÃ£o precise trafegar os dados de cartÃ£o no
> seu servidor.
>
> *Apenas clientes Gateway estÃ£o aptos a utilizar o* `card_token `*na CriaÃ§Ã£o do Pedido, caso seja cliente PSP,
recomendamos usar o* `card_id`

> â—ï¸ DADOS DO COMPRADOR SÃƒO OBRIGATÃ“RIOS
>
> Caso seja informado o `customer_id`, nÃ£o Ã© necessÃ¡rio incluir o objeto `customer`. Entretanto, Ã© **obrigatÃ³rio** que
> um desses parâmetros seja informado.
>
> Para clientes Pagar.me PSP, Ã© obrigatÃ³rio preencher todos os campos do objeto `customer`, incluindo endereÃ§o e
> telefone. Veja mais em [Carteira de Clientes](https://docs.pagar.me/docs/carteira-de-clientes).

> ðŸš§ Envio do CVV
>
> Em transações recorrentes, o CVV sÃ³ deve ser enviado na primeira transaÃ§Ã£o de recorrÃªncia (recurrence\_cycle = first).

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
    "/orders": {
      "post": {
        "summary": "Criar pedido com split",
        "description": "Para realizar pedidos com split, vocÃª deve criar um objeto order com o objeto split. \nPara formar o objeto split, vocÃª deve primeiramente cadastrar recebedores. \nO objeto order com split possui os seguintes atributos:",
        "operationId": "criar-pedido-com-split-1",
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "required": [
                  "items",
                  "payments"
                ],
                "properties": {
                  "code": {
                    "type": "string",
                    "description": "CÃ³digo identificador do pedido no sistema da loja. Max: 52 caracteres."
                  },
                  "items": {
                    "type": "array",
                    "description": "Itens do pedido. [Saiba mais sobre itens do pedido](https://docs.pagar.me/reference/item-do-pedido-1)",
                    "items": {
                      "properties": {
                        "amount": {
                          "type": "integer",
                          "description": "Valor unitÃ¡rio. Obrigatoriamente maior que zero.",
                          "format": "int32"
                        },
                        "description": {
                          "type": "string",
                          "description": "DescriÃ§Ã£o do item."
                        },
                        "quantity": {
                          "type": "integer",
                          "description": "Quantidade de itens.",
                          "format": "int32"
                        },
                        "code": {
                          "type": "string",
                          "description": "CÃ³digo do item no sistema da loja."
                        }
                      },
                      "required": [
                        "code"
                      ],
                      "type": "object"
                    }
                  },
                  "customer_id": {
                    "type": "string",
                    "description": "CÃ³digo do cliente."
                  },
                  "customer": {
                    "type": "object",
                    "description": "Dados do cliente. ObrigatÃ³rio caso o **customer_id** nÃ£o seja informado. [Saiba mais sobre clientes](https://docs.pagar.me/reference/clientes-1)",
                    "required": [
                      "name"
                    ],
                    "properties": {
                      "name": {
                        "type": "string",
                        "description": "Nome do cliente. Max: 64 caracteres."
                      },
                      "type": {
                        "type": "string",
                        "description": "Tipo de cliente. Valores possÃ­veis: individual (pessoa fÃ­sica) ou company (pessoa jurÃ­dica). ObrigatÃ³rio, caso o document seja enviado."
                      },
                      "email": {
                        "type": "string",
                        "description": "E-mail do cliente. Max: 64 caracteres."
                      },
                      "code": {
                        "type": "string",
                        "description": "CÃ³digo de referÃªncia do cliente no sistema da loja. Max: 52 caracteres."
                      },
                      "document": {
                        "type": "string",
                        "description": "CPF, CNPJ ou PASSAPORTE do cliente. Max: 16 caracteres para CPF e CNPJ e Max: 50 caracteres para PASSAPORTE."
                      },
                      "document_type": {
                        "type": "string",
                        "description": "Tipo de documento. Valores possÃ­veis: \"CPF\", \"CNPJ\" ou \"PASSPORT\"."
                      },
                      "gender": {
                        "type": "string",
                        "description": "Sexo do cliente . Valores possÃ­veis: male ou female."
                      },
                      "address": {
                        "type": "object",
                        "description": "EndereÃ§o do cliente.",
                        "properties": {
                          "country": {
                            "type": "string",
                            "description": "PaÃ­s (CÃ³digo do paÃ­s no formato ISO 3166-1 alpha-2)(2 digitos)"
                          },
                          "state": {
                            "type": "string",
                            "description": "Estado (CÃ³digo do estado no formato ISO 3166-2)."
                          },
                          "city": {
                            "type": "string",
                            "description": "Cidade."
                          },
                          "zip_code": {
                            "type": "string",
                            "description": "CÃ³digo Postal (CEP) (Apenas numÃ©rico)."
                          },
                          "line_1": {
                            "type": "string",
                            "description": "Dados principais do endereÃ§o. Neste campo deve ser informado NÃºmero, Rua, Bairro, nesta ordem e separados por vÃ­rgula."
                          },
                          "line_2": {
                            "type": "string",
                            "description": "Dados complementares do endereÃ§o. Neste campo pode ser informado complemento, referÃªncias."
                          }
                        }
                      },
                      "phones": {
                        "type": "object",
                        "description": "Telefone residencial do cliente.",
                        "properties": {
                          "home_phone": {
                            "type": "object",
                            "description": "Telefone residencial do cliente.",
                            "properties": {
                              "country_code": {
                                "type": "string",
                                "description": "CÃ³digo do PaÃ­s (Apenas numÃ©rico)."
                              },
                              "area_code": {
                                "type": "string",
                                "description": "CÃ³digo da Ã¡rea (Apenas numÃ©rico)."
                              },
                              "number": {
                                "type": "string",
                                "description": "NÃºmero do telefone (Apenas numÃ©rico)."
                              }
                            }
                          },
                          "mobile_phone": {
                            "type": "object",
                            "description": "Telefone celular do cliente.",
                            "properties": {
                              "country_code": {
                                "type": "string",
                                "description": "CÃ³digo do PaÃ­s (Apenas numÃ©rico)."
                              },
                              "area_code": {
                                "type": "string",
                                "description": "CÃ³digo da Ã¡rea (Apenas numÃ©rico)."
                              },
                              "number": {
                                "type": "string",
                                "description": "NÃºmero do telefone (Apenas numÃ©rico)."
                              }
                            }
                          }
                        }
                      },
                      "birthdate": {
                        "type": "string",
                        "description": "Data de nascimento do cliente.",
                        "format": "date"
                      },
                      "metadata": {
                        "type": "string",
                        "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre o cliente."
                      }
                    }
                  },
                  "shipping": {
                    "type": "object",
                    "description": "Dados para entrega.",
                    "properties": {
                      "amount": {
                        "type": "integer",
                        "description": "Valor da entrega.",
                        "format": "int32"
                      },
                      "description": {
                        "type": "string",
                        "description": "DescriÃ§Ã£o da entrega."
                      },
                      "recipient_name": {
                        "type": "string",
                        "description": "DestinatÃ¡rio da entrega."
                      },
                      "recipient_phone": {
                        "type": "string",
                        "description": "Telefone do destinatÃ¡rio."
                      },
                      "address": {
                        "type": "object",
                        "description": "EndereÃ§o de entrega",
                        "properties": {
                          "country": {
                            "type": "string",
                            "description": "PaÃ­s (CÃ³digo do paÃ­s no formato ISO 3166-1 alpha-2)(2 digitos)"
                          },
                          "state": {
                            "type": "string",
                            "description": "Estado (CÃ³digo do estado no formato ISO 3166-2)."
                          },
                          "city": {
                            "type": "string",
                            "description": "Cidade."
                          },
                          "zip_code": {
                            "type": "string",
                            "description": "CÃ³digo Postal (CEP) (Apenas numÃ©rico)."
                          },
                          "line_1": {
                            "type": "string",
                            "description": "Dados principais do endereÃ§o. Neste campo deve ser informado NÃºmero, Rua, Bairro, nesta ordem e separados por vÃ­rgula."
                          },
                          "line_2": {
                            "type": "string",
                            "description": "Dados complementares do endereÃ§o. Neste campo pode ser informado complemento, referÃªncias."
                          }
                        }
                      }
                    }
                  },
                  "payments": {
                    "type": "array",
                    "description": "Lista de dados de pagamento. [Saiba mais sobre pagamentos.](https://docs.pagar.me/reference/vis%C3%A3o-geral-sobre-pagamento)",
                    "items": {
                      "properties": {
                        "payment_method": {
                          "type": "string",
                          "description": "Meio de pagamento. Valores possÃ­veis: credit_card, boleto, Pix, Debit Card"
                        },
                        "credit_card": {
                          "type": "object",
                          "description": "Dados sobre o pagamento com cartÃ£o de crÃ©dito (obrigatÃ³rio caso o payment_method seja credit_card).",
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
                        "debit_card": {
                          "type": "object",
                          "description": "Dados sobre o pagamento com cartÃ£o de dÃ©bito (obrigatÃ³rio caso o payment_method seja debit_card).",
                          "properties": {
                            "statement_descriptor": {
                              "type": "string",
                              "description": "Texto exibido na fatura do cartÃ£o. Max: 22 caracteres."
                            },
                            "card": {
                              "type": "object",
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
                              "description": "identificador do cartÃ£o de um cliente."
                            },
                            "card_token": {
                              "type": "string",
                              "description": "token do cartÃ£o gerado pelo checkout transparente"
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
                            "initiated_type": {
                              "type": "string",
                              "description": "Identificador do tipo de transaÃ§Ã£o avulsa. Valores possÃ­veis: `partial_shipment` (Remessa Parcial), `related_or_delayed_charge` (CobranÃ§a Atrasada), `no_show` (Multa) ou `retry` (Retentativa)."
                            },
                            "recurrence_model": {
                              "type": "string",
                              "description": "Identificador do tipo de recorrÃªncia. Valores possÃ­veis: `standing_order` (Ordem Permanente), `instalment` (Parcelamento) ou `subscription` (Assinatura convencional com valor e frequÃªncia fixa)."
                            }
                          }
                        },
                        "split": {
                          "type": "array",
                          "description": "Dados para o split de pagamentos.",
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
                      },
                      "type": "object"
                    }
                  },
                  "closed": {
                    "type": "boolean",
                    "description": "Informa se o pedido serÃ¡ criado **aberto** ou **fechado**"
                  },
                  "metadata": {
                    "type": "string",
                    "description": "Objeto chave/valor utilizado para armazenar informações adicionais sobre o pedido."
                  }
                }
              },
              "examples": {
                "Request Example": {
                  "value": {
                    "items": [
                      {
                        "amount": 100,
                        "description": "Chaveiro do Tesseract",
                        "quantity": 1,
                        "code": "12345"
                      }
                    ],
                    "customer": {
                      "name": "Tony Stark",
                      "email": "Tony@Avangers.com"
                    },
                    "payments": [
                      {
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
                              "line_1": "10880, Malibu Point, Malibu Central",
                              "zip_code": "90265",
                              "city": "Malibu",
                              "state": "CA",
                              "country": "US"
                            }
                          }
                        },
                        "split": [
                          {
                            "amount": 50,
                            "recipient_id": "rp_5yGwpMGckBHVYmb6",
                            "type": "percentage",
                            "options": {
                              "charge_processing_fee": true,
                              "charge_remainder_fee": true,
                              "liable": true
                            }
                          },
                          {
                            "amount": 50,
                            "type": "percentage",
                            "recipient_id": "rp_yLnAyVpHbQIqZxwO",
                            "options": {
                              "charge_processing_fee": false,
                              "charge_remainder_fee": false,
                              "liable": false
                            }
                          }
                        ]
                      }
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
              "application/json": {
                "examples": {
                  "Result": {
                    "value": "{\n    \"id\": \"ch_NW0ABG5HQikn3Lv4\",\n    \"code\": \"487FO9HYV3\",\n    \"gateway_id\": \"3554818\",\n    \"amount\": 100,\n    \"paid_amount\": 100,\n    \"status\": \"paid\",\n    \"currency\": \"BRL\",\n    \"payment_method\": \"credit_card\",\n    \"paid_at\": \"2018-05-22T18:38:22Z\",\n    \"created_at\": \"2018-05-22T18:38:08Z\",\n    \"updated_at\": \"2018-05-22T18:38:08Z\",\n    \"customer\": {\n        \"id\": \"cus_dgLJ8jmURSe0DQ0N\",\n        \"name\": \"Tony Stark\",\n        \"email\": \"tony0@avengers.com\",\n        \"delinquent\": false,\n        \"created_at\": \"2018-05-22T18:38:06Z\",\n        \"updated_at\": \"2018-05-22T18:38:06Z\",\n        \"phones\": {}\n    },\n    \"last_transaction\": {\n        \"id\": \"tran_1lLxVjc3JCXVxnED\",\n        \"transaction_type\": \"credit_card\",\n        \"gateway_id\": \"3554818\",\n        \"amount\": 100,\n        \"status\": \"captured\",\n        \"success\": true,\n        \"installments\": 1,\n        \"statement_descriptor\": \"AVENGERS\",\n        \"acquirer_name\": \"pagarme\",\n        \"acquirer_tid\": \"3554818\",\n        \"acquirer_nsu\": \"3554818\",\n        \"acquirer_return_code\": \"0000\",\n        \"operation_type\": \"auth_and_capture\",\n        \"card\": {\n            \"id\": \"card_nKojDZnNIjh9D5z1\",\n            \"first_six_digits\": \"401118\",\n            \"last_four_digits\": \"5580\",\n            \"brand\": \"Visa\",\n            \"holder_name\": \"Tony Stark\",\n            \"exp_month\": 1,\n            \"exp_year\": 2030,\n            \"status\": \"active\",\n            \"created_at\": \"2018-05-22T18:38:11Z\",\n            \"updated_at\": \"2018-05-22T18:38:11Z\",\n            \"type\": \"credit\"\n        },\n        \"created_at\": \"2018-05-22T18:38:13Z\",\n        \"updated_at\": \"2018-05-22T18:38:13Z\",\n        \"gateway_response\": {\n            \"code\": \"200\"\n        },\n        \"split\": [\n          {\n            \"id\": \"sr_1qeQrB3s1synMW45\",\n            \"type\": \"percentage\",\n            \"gateway_id\": \"sr_ck5gv9dr3005di96euc53hcsc\",\n            \"amount\": 50,\n            \"recipient\": {\n              \"id\": \"rp_5yGwpMGckBHVYmb6\",\n              \"name\": \"First recipient\",\n              \"email\": \"first_recipient@pagar.me\",\n              \"document\": \"12728994706\",\n              \"description\": \"DescriÃ§Ã£o do recebedor 1\",\n              \"type\": \"individual\",\n              \"status\": \"active\",\n              \"created_at\": \"2020-01-02T20:23:14Z\",\n              \"updated_at\": \"2020-01-02T20:23:14Z\"\n            },\n            \"options\": {\n              \"liable\": true,\n              \"charge_processing_fee\": true,\n              \"charge_remainder_fee\": true\n            }\n          },\n          {\n            \"id\": \"sr_nmywGvbhalUnMVGd\",\n            \"type\": \"percentage\",\n            \"gateway_id\": \"sr_ck5gv9dr4005ei96emuw9z1hc\",\n            \"amount\": 50,\n            \"recipient\": {\n              \"id\": \"rp_yLnAyVpHbQIqZxwO\",\n              \"name\": \"Second recipient\",\n              \"email\": \"second_recipient@pagar.me\",\n              \"document\": \"15313587000166\",\n              \"description\": \"DescriÃ§Ã£o do recebedor 2\",\n              \"type\": \"company\",\n              \"status\": \"active\",\n              \"created_at\": \"2020-01-02T20:23:17Z\",\n              \"updated_at\": \"2020-01-02T20:23:17Z\"\n            },\n            \"options\": {\n              \"liable\": false,\n              \"charge_processing_fee\": false,\n              \"charge_remainder_fee\": false\n            }\n          }\n        ]\n    },\n    \"metadata\": {\n        \"code\": \"123\"\n    }\n}"
                  }
                },
                "schema": {
                  "type": "object",
                  "properties": {
                    "id": {
                      "type": "string",
                      "example": "ch_NW0ABG5HQikn3Lv4"
                    },
                    "code": {
                      "type": "string",
                      "example": "487FO9HYV3"
                    },
                    "gateway_id": {
                      "type": "string",
                      "example": "3554818"
                    },
                    "amount": {
                      "type": "integer",
                      "example": 100,
                      "default": 0
                    },
                    "paid_amount": {
                      "type": "integer",
                      "example": 100,
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
                    "paid_at": {
                      "type": "string",
                      "example": "2018-05-22T18:38:22Z"
                    },
                    "created_at": {
                      "type": "string",
                      "example": "2018-05-22T18:38:08Z"
                    },
                    "updated_at": {
                      "type": "string",
                      "example": "2018-05-22T18:38:08Z"
                    },
                    "customer": {
                      "type": "object",
                      "properties": {
                        "id": {
                          "type": "string",
                          "example": "cus_dgLJ8jmURSe0DQ0N"
                        },
                        "name": {
                          "type": "string",
                          "example": "Tony Stark"
                        },
                        "email": {
                          "type": "string",
                          "example": "tony0@avengers.com"
                        },
                        "delinquent": {
                          "type": "boolean",
                          "example": false,
                          "default": true
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2018-05-22T18:38:06Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-05-22T18:38:06Z"
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
                          "example": "tran_1lLxVjc3JCXVxnED"
                        },
                        "transaction_type": {
                          "type": "string",
                          "example": "credit_card"
                        },
                        "gateway_id": {
                          "type": "string",
                          "example": "3554818"
                        },
                        "amount": {
                          "type": "integer",
                          "example": 100,
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
                          "example": "pagarme"
                        },
                        "acquirer_tid": {
                          "type": "string",
                          "example": "3554818"
                        },
                        "acquirer_nsu": {
                          "type": "string",
                          "example": "3554818"
                        },
                        "acquirer_return_code": {
                          "type": "string",
                          "example": "0000"
                        },
                        "operation_type": {
                          "type": "string",
                          "example": "auth_and_capture"
                        },
                        "card": {
                          "type": "object",
                          "properties": {
                            "id": {
                              "type": "string",
                              "example": "card_nKojDZnNIjh9D5z1"
                            },
                            "first_six_digits": {
                              "type": "string",
                              "example": "401118"
                            },
                            "last_four_digits": {
                              "type": "string",
                              "example": "5580"
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
                              "example": 2030,
                              "default": 0
                            },
                            "status": {
                              "type": "string",
                              "example": "active"
                            },
                            "created_at": {
                              "type": "string",
                              "example": "2018-05-22T18:38:11Z"
                            },
                            "updated_at": {
                              "type": "string",
                              "example": "2018-05-22T18:38:11Z"
                            },
                            "type": {
                              "type": "string",
                              "example": "credit"
                            }
                          }
                        },
                        "created_at": {
                          "type": "string",
                          "example": "2018-05-22T18:38:13Z"
                        },
                        "updated_at": {
                          "type": "string",
                          "example": "2018-05-22T18:38:13Z"
                        },
                        "gateway_response": {
                          "type": "object",
                          "properties": {
                            "code": {
                              "type": "string",
                              "example": "200"
                            }
                          }
                        },
                        "split": {
                          "type": "array",
                          "items": {
                            "type": "object",
                            "properties": {
                              "id": {
                                "type": "string",
                                "example": "sr_1qeQrB3s1synMW45"
                              },
                              "type": {
                                "type": "string",
                                "example": "percentage"
                              },
                              "gateway_id": {
                                "type": "string",
                                "example": "sr_ck5gv9dr3005di96euc53hcsc"
                              },
                              "amount": {
                                "type": "integer",
                                "example": 50,
                                "default": 0
                              },
                              "recipient": {
                                "type": "object",
                                "properties": {
                                  "id": {
                                    "type": "string",
                                    "example": "rp_5yGwpMGckBHVYmb6"
                                  },
                                  "name": {
                                    "type": "string",
                                    "example": "First recipient"
                                  },
                                  "email": {
                                    "type": "string",
                                    "example": "first_recipient@pagar.me"
                                  },
                                  "document": {
                                    "type": "string",
                                    "example": "12728994706"
                                  },
                                  "description": {
                                    "type": "string",
                                    "example": "DescriÃ§Ã£o do recebedor 1"
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
                                    "example": "2020-01-02T20:23:14Z"
                                  },
                                  "updated_at": {
                                    "type": "string",
                                    "example": "2020-01-02T20:23:14Z"
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