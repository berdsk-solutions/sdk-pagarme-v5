# Criar link de pagamento

> ðŸ“˜ Importante!
>
> Essa documentaÃ§Ã£o se refere a URL e autenticaÃ§Ã£o de uma conta em ProduÃ§Ã£o, caso queira realizar testes em uma conta de Test, vocÃª deve utilizar as seguintes informações:
>
> **REQUEST URL:** [https://sdx-api.pagar.me/core/v5/paymentlinks](https://sdx-api.pagar.me/core/v5/paymentlinks)
>
> **AUTENTICATION:** sk\_test
>
> **O body continuarÃ¡ o mesmo!**

> ðŸš§ Importante!
>
> Em Links de pagamento com o`type: subscription` **NÃƒO** Ã© possÃ­vel realizar parcelamentos e/ou split!
>
> Caso queira utilizar um plano junto com a assinatura, Ã© necessÃ¡rio realizar a criaÃ§Ã£o do plano antes de criar o Link de pagamento, mais informações sobre os planos podem ser encontradas [aqui](https://docs.pagar.me/docs/plano) .

> ðŸ“˜ Importante! Funcionalidade de Split no Link estÃ¡ disponÃ­vel
>
> Pagamentos de link com regras de split definidas em `split_settings` sÃ³ serÃ£o repassados especificamente pra links que foram pagos com `payment_method: credit_card`, por hora **NÃƒO** suportamos em outros meios de pagamento, incluindo carteiras digitais.
>
> Essa funcionalidade tambÃ©m nÃ£o Ã© suportada para links de pagamento com o `type: subscription`.
>
> A funcionalidade de split de pagamento sÃ³ funcionarÃ¡ apenas para **Clientes do digital (PSP)**

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
    "/paymentlinks (COPY)": {
      "post": {
        "summary": "Criar link de pagamento",
        "description": "",
        "operationId": "criar-link",
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "type": "object",
                "required": [
                  "type",
                  "payment_settings",
                  "cart_settings"
                ],
                "properties": {
                  "is_building": {
                    "type": "boolean",
                    "description": "Define se o link de pagamento serÃ¡ criado com o status building ou ativo, em caso de envio do campo true tal permite que vocÃª ative um link em determinado momento posteriormente, para realizar uma aÃ§Ã£o promocional, por exemplo;",
                    "default": false
                  },
                  "name": {
                    "type": "string",
                    "description": "Nome que serÃ¡ exibido na dashboard e ao buscar o link de pagamento atravÃ©s da API. MÃ¡ximo de 64 caracteres."
                  },
                  "order_code": {
                    "type": "string",
                    "description": "Permite ao lojista informar um identificador de sua plataforma para correlaÃ§Ã£o"
                  },
                  "type": {
                    "type": "string",
                    "description": "Define o tipo do link de pagamento a ser criado, podendo ser \"order\", para criaÃ§Ã£o de pedidos, ou \"subscription\", para recorrÃªncias."
                  },
                  "expires_at": {
                    "type": "string",
                    "description": "Define a data de expiraÃ§Ã£o do link de pagamento. Formato ISO 8601. Caso nÃ£o seja enviado o link nÃ£o terÃ¡ expiraÃ§Ã£o por tempo. NÃ£o deve ser enviado caso o campo expires_in seja enviado.",
                    "format": "date"
                  },
                  "expires_in": {
                    "type": "integer",
                    "description": "Define o tempo de expiraÃ§Ã£o do link de pagamento em minutos apÃ³s o mesmo estar ativo. Tempo em minutos. Caso nÃ£o seja enviado, o link nÃ£o terÃ¡ expiraÃ§Ã£o por tempo. NÃ£o deve ser enviado caso o campo expires_at seja enviado.",
                    "format": "int32"
                  },
                  "max_sessions": {
                    "type": "integer",
                    "description": "Define o mÃ¡ximo de pedidos que o link de pagamento pode gerar, sejam eles pagos ou nÃ£o. Caso nÃ£o seja enviado, nÃ£o haverÃ¡ limite de pedidos criados.",
                    "format": "int32"
                  },
                  "max_paid_sessions": {
                    "type": "integer",
                    "description": "Define o mÃ¡ximo de pedidos pagos que o link de pagamento pode gerar. Caso nÃ£o seja enviado, nÃ£o haverÃ¡ limite de pagamentos.",
                    "format": "int32"
                  },
                  "payment_settings": {
                    "type": "object",
                    "description": "Configurações de pagamento do link.",
                    "properties": {
                      "accepted_payment_methods": {
                        "type": "array",
                        "description": "Define os mÃ©todos de pagamento aceitos. Valores permitidos: \"credit_card\", \"boleto\" e \"pix\".",
                        "items": {
                          "type": "string"
                        }
                      },
                      "statement_descriptor": {
                        "type": "string",
                        "description": "Define o identificador que irÃ¡ aparecer na fatura do comprador. Limite de 13 caracteres."
                      },
                      "credit_card_settings": {
                        "type": "object",
                        "description": "Define as configurações de pagamento quando cartÃ£o de crÃ©dito for selecionado. ObrigatÃ³rio quando enviado \"credit_card\" em \"accepted_payment_methods\".",
                        "properties": {
                          "operation_type": {
                            "type": "string",
                            "description": "Indica se a transaÃ§Ã£o deve ser capturada (\"auth_and_capture\") ou apenas autorizada (\"auth_only\")."
                          },
                          "delay_to_capture": {
                            "type": "integer",
                            "description": "Tempo prÃ©-definido para a captura do pagamento apÃ³s autorizaÃ§Ã£o. Valor em xxx.",
                            "format": "int32"
                          },
                          "installments": {
                            "type": "array",
                            "description": "Configurações de parcelamento do link. NÃ£o deverÃ¡ ser enviado caso o campo \"installments_setup\" seja definido.",
                            "items": {
                              "properties": {
                                "number": {
                                  "type": "integer",
                                  "description": "NÃºmero de parcelas",
                                  "format": "int32"
                                },
                                "total": {
                                  "type": "integer",
                                  "description": "Valor total que serÃ¡ cobrado caso essa opÃ§Ã£o de parcelamento seja selecionada, em centavos.",
                                  "format": "int32"
                                }
                              },
                              "required": [
                                "number",
                                "total"
                              ],
                              "type": "object"
                            }
                          },
                          "installments_setup": {
                            "type": "object",
                            "description": "Configurações de parcelamento do link. NÃ£o deverÃ¡ ser enviado caso o campo \"installments\" seja definido.",
                            "properties": {
                              "max_installments": {
                                "type": "integer",
                                "description": "NÃºmero mÃ¡ximo de parcelas permitido.",
                                "format": "int32"
                              },
                              "amount": {
                                "type": "integer",
                                "description": "Valor total que serÃ¡ cobrado pelo link, em centavos.",
                                "format": "int32"
                              },
                              "interest_type": {
                                "type": "string",
                                "description": "Tipo de cÃ¡lculo utilizado para a inclusÃ£o de acrÃ©scimo de juros no parcelamento, se aplicÃ¡vel.",
                                "default": "simple"
                              },
                              "interest_rate": {
                                "type": "integer",
                                "description": "Valor percentual que serÃ¡ utilizado para o acrÃ©scimo de juros no parcelamento.",
                                "format": "int32"
                              },
                              "customer_fee": {
                                "type": "boolean",
                                "description": "Define se as taxas deverÃ£o ser automaticamente repassadas no parcelamento do link. Para clientes PSP, caso esse campo seja \"true\", os campos \"interest_type\" e \"interest_rate\" nÃ£o devem ser enviados."
                              },
                              "free_installments": {
                                "type": "integer",
                                "description": "NÃºmero de parcelas que nÃ£o terÃ£o acrÃ©scimo de juros.",
                                "format": "int32"
                              },
                              "brand": {
                                "type": "string",
                                "description": "Define a bandeira para recuperar as taxas do lojista. Caso o campo \"customer_fee\" seja \"true\", e os campos \"interest_type\" e \"interest_rate\" nÃ£o forem informados. Apenas para clientes PSP."
                              }
                            }
                          }
                        }
                      },
                      "boleto_settings": {
                        "type": "object",
                        "description": "Define as configurações de pagamento quando boleto for selecionado. ObrigatÃ³rio quando enviado \"boleto\" em \"accepted_payment_methods\".",
                        "properties": {
                          "due_at": {
                            "type": "string",
                            "description": "Define a data de expiraÃ§Ã£o do boleto gerado. Formato ISO 8601. NÃ£o deverÃ¡ ser enviado caso o campo \"due_in\" seja definido.",
                            "format": "date"
                          },
                          "due_in": {
                            "type": "integer",
                            "description": "Define quantidade de tempo para expiraÃ§Ã£o do boleto a partir do momento que o mesmo Ã© gerado. Valor em dias. NÃ£o deverÃ¡ ser enviado caso o campo \"due_in\" seja definido.",
                            "format": "int32"
                          },
                          "discount": {
                            "type": "integer",
                            "description": "Valor de desconto a ser aplicado ao boleto, em centavos. NÃ£o deve ser enviado caso o campo \"discount_percentage\" seja definido.",
                            "format": "int32"
                          },
                          "discount_percentage": {
                            "type": "number",
                            "description": "Valor de desconto a ser aplicado ao boleto, em porcentagem. NÃ£o deve ser enviado caso o campo \"discount\" seja definido.",
                            "format": "double"
                          },
                          "instructions": {
                            "type": "string",
                            "description": "Instruções do boleto. MÃ¡ximo 255 caracteres."
                          }
                        }
                      },
                      "pix_settings": {
                        "type": "object",
                        "description": "Define as configurações de pagamento quando pix for selecionado. ObrigatÃ³rio quando enviado \"pix\" em \"accepted_payment_methods\".",
                        "properties": {
                          "expires_in": {
                            "type": "integer",
                            "description": "Define quantidade de tempo para expiraÃ§Ã£o do pix a partir do momento que o mesmo Ã© gerado. Valor em segundos. NÃ£o deverÃ¡ ser enviado caso o campo \"expires_at\" seja definido.",
                            "format": "int32"
                          },
                          "expires_at": {
                            "type": "string",
                            "description": "Define a data de expiraÃ§Ã£o do pix gerado. Formato ISO 8601. NÃ£o deverÃ¡ ser enviado caso o campo \"expires_in\" seja definido.",
                            "format": "date"
                          },
                          "discount": {
                            "type": "integer",
                            "description": "Valor de desconto a ser aplicado ao pix, em centavos. NÃ£o deve ser enviado caso o campo \"discount_percentage\" seja definido.",
                            "format": "int32"
                          },
                          "discount_percentage": {
                            "type": "number",
                            "description": "Valor de desconto a ser aplicado ao pix, em porcentagem. NÃ£o deve ser enviado caso o campo \"discount\" seja definido.",
                            "format": "double"
                          },
                          "additiona_information": {
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
                      }
                    }
                  },
                  "customer_settings": {
                    "type": "object",
                    "description": "Define os dados do cliente, se aplicÃ¡vel.",
                    "properties": {
                      "customer_id": {
                        "type": "string",
                        "description": "CÃ³digo do cliente."
                      },
                      "customer": {
                        "type": "object",
                        "description": "Dados do cliente. NÃ£o deverÃ¡ ser enviado caso o campo \"customer_id\" seja definido.",
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
                      }
                    }
                  },
                  "cart_settings": {
                    "type": "object",
                    "description": "Define os dados do carrinho que serÃ¡ pago pelo link de pagamento.",
                    "properties": {
                      "shipping_cost": {
                        "type": "integer",
                        "description": "Valor de entrega, em centavos",
                        "format": "int32"
                      },
                      "items": {
                        "type": "array",
                        "description": "Define os itens que estÃ£o inclusos no carrinho que serÃ¡ pago pelo link.",
                        "items": {
                          "properties": {
                            "name": {
                              "type": "string",
                              "description": "Nome do item."
                            },
                            "description": {
                              "type": "string",
                              "description": "DescriÃ§Ã£o do item. MÃ¡ximo de xxx caracteres"
                            },
                            "amount": {
                              "type": "integer",
                              "description": "Valor unitÃ¡rio do item, em centavos.",
                              "format": "int32"
                            },
                            "shipping_cost": {
                              "type": "integer",
                              "description": "Valor de entrega do item, em centavos.",
                              "format": "int32"
                            },
                            "default_quantity": {
                              "type": "integer",
                              "description": "Quantidade de itens.",
                              "format": "int32"
                            }
                          },
                          "required": [
                            "name",
                            "amount",
                            "default_quantity"
                          ],
                          "type": "object"
                        }
                      },
                      "recurrences": {
                        "type": "array",
                        "description": "Define as configurações da recorrÃªncia que serÃ¡ gerada a partir do pagamento do link.",
                        "items": {
                          "properties": {
                            "plan_id": {
                              "type": "string",
                              "description": "Id do plano com as configurações da assinatura que serÃ¡ gerada."
                            },
                            "plan": {
                              "type": "object",
                              "description": "Dados do plano da assinatura que serÃ¡ gerada. NÃ£o deverÃ¡ ser enviado caso o campo \"plan_id\" seja definido."
                            },
                            "start_in": {
                              "type": "integer",
                              "description": "Data de inÃ­cio da assinatura, em dias. NÃ£o deverÃ¡ ser enviado caso o campo \"start_at\" seja definido.",
                              "format": "int32"
                            },
                            "start_at": {
                              "type": "string",
                              "description": "Data de inÃ­cio da assinatura. NÃ£o deverÃ¡ ser enviado caso o campo \"start_in\" seja definido.",
                              "format": "date"
                            }
                          },
                          "type": "object"
                        }
                      }
                    }
                  },
                  "layout_settings": {
                    "type": "object",
                    "description": "Dados de layout.",
                    "properties": {
                      "image_url": {
                        "type": "string",
                        "description": "Logo que serÃ¡ utilizado no checkout."
                      },
                      "primary_color": {
                        "type": "string",
                        "description": "Cor primÃ¡ria que serÃ¡ aplicada no checkout, em hexadecimal."
                      },
                      "secondary_color": {
                        "type": "string",
                        "description": "Cor secundÃ¡ria que serÃ¡ aplicada no checkout."
                      }
                    }
                  },
                  "split_settings": {
                    "type": "object",
                    "description": "Define as regras de split de pagamento",
                    "properties": {
                      "rules": {
                        "type": "array",
                        "description": "Regras de split a serem enviadas no link de pamganeto",
                        "items": {
                          "properties": {
                            "recipient_id": {
                              "type": "string",
                              "description": "CÃ³digo do recebedor. Formato: re_XXXXXXXXXXXXXXXX."
                            },
                            "amount": {
                              "type": "integer",
                              "description": "Valor destinado ao recebedor.",
                              "format": "int32"
                            },
                            "type": {
                              "type": "string",
                              "description": "Tipo de divisÃ£o. Os valores possÃ­veis sÃ£o flat ou percentage.",
                              "default": "percentage",
                              "enum": [
                                "flat",
                                "percentage"
                              ]
                            },
                            "options": {
                              "type": "object",
                              "description": "Informações da responsabilidade do recebedor na transaÃ§Ã£o.",
                              "properties": {
                                "liable": {
                                  "type": "boolean",
                                  "description": "Indica se o recebedor Ã© responsÃ¡vel pela transaÃ§Ã£o em caso de chargeback.",
                                  "default": true
                                },
                                "charge_processing_fee": {
                                  "type": "boolean",
                                  "description": "Indica se o recebedor vinculado Ã  regra serÃ¡ cobrado pelas taxas da transaÃ§Ã£o",
                                  "default": true
                                },
                                "charge_remainder_fee": {
                                  "type": "boolean",
                                  "description": "Indica se o recebedor vinculado Ã  regra irÃ¡ receber o restante dos recebÃ­veis apÃ³s uma divisÃ£o",
                                  "default": true
                                }
                              }
                            }
                          },
                          "type": "object"
                        }
                      }
                    }
                  },
                  "flow_settings": {
                    "type": "object",
                    "properties": {
                      "success_url": {
                        "type": "string",
                        "default": "",
                        "description": "Define a url de redirecionamento ao final do checkout para permitir o comprador retornar a loja"
                      }
                    },
                    "description": ""
                  }
                }
              },
              "examples": {
                "Link de pedido": {
                  "value": {
                    "payment_settings": {
                      "accepted_payment_methods": [
                        "credit_card"
                      ],
                      "credit_card_settings": {
                        "operation_type": "auth_and_capture",
                        "installments": [
                          {
                            "number": 1,
                            "total": 12000
                          },
                          {
                            "number": 2,
                            "total": 12000
                          }
                        ]
                      }
                    },
                    "cart_settings": {
                      "items": [
                        {
                          "amount": 12000,
                          "name": "Banner",
                          "default_quantity": 1
                        }
                      ]
                    },
                    "name": "Banner N12345",
                    "type": "order"
                  }
                },
                "Link de pedido (com acrÃ©scimo de juros)": {
                  "value": {
                    "payment_settings": {
                      "accepted_payment_methods": [
                        "pix",
                        "boleto",
                        "credit_card"
                      ],
                      "credit_card_settings": {
                        "operation_type": "auth_and_capture",
                        "installments_setup": {
                          "max_installments": 12,
                          "amount": 10000,
                          "interest_type": "simple",
                          "interest_rate": 2,
                          "free_installments": 1
                        }
                      }
                    },
                    "cart_settings": {
                      "items": [
                        {
                          "amount": 5000,
                          "name": "Banner",
                          "description": "Banner personalizado",
                          "default_quantity": 2
                        }
                      ]
                    },
                    "name": "Banner N67890 ",
                    "type": "order"
                  }
                },
                "Link de RecorrÃªncia": {
                  "value": {
                    "max_paid_sessions": 1,
                    "payment_settings": {
                      "accepted_payment_methods": [
                        "credit_card"
                      ],
                      "credit_card_settings": {
                        "operation_type": "auth_and_capture"
                      }
                    },
                    "customer_settings": {
                      "customer_id": "cus_8ka4RGDF9F7MvemD"
                    },
                    "expires_at": "2024-05-12T19:44:39.5870000Z",
                    "cart_settings": {
                      "recurrences": [
                        {
                          "start_in": 1,
                          "plan_id": "plan_odzJgEyf9fqgR7Kj"
                        }
                      ]
                    },
                    "name": "Banner mensal N135",
                    "type": "subscription"
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
                    "value": "{\n    \"payment_settings\": {\n        \"accepted_payment_methods\": [\n            \"credit_card\"\n        ],\n        \"credit_card_settings\": {\n            \"operation_type\": \"auth_and_capture\",\n            \"installments\": [\n                {\n                    \"number\": 1,\n                    \"total\": 12000\n                },\n                {\n                    \"number\": 2,\n                    \"total\": 12000\n                }\n            ]\n        }\n    },\n    \"cart_settings\": {\n        \"items\": [\n            {\n                \"amount\": 12000,\n                \"name\": \"Banner\",\n                \"default_quantity\": 1\n            }\n        ],\n       \"items_total_cost\": 12000,\n       \"total_cost\": 12000,\n       \"shipping_cost\": 0,\n       \"shipping_total_cost\": 0,\n    },\n    \"name\": \"Banner N12345\",\n    \"type\": \"order\",\n    \"total_sessions\": 0,\n    \"max_paid_sessions\": 0,\n    \"total_paid_sessions\": 0,\n    \"max_sessions\": 0,\n    \"created_at\": \"2024-05-13T01:09:40.6331583Z\",\n    \"url\": \"https://payment-link.pagar.me/pl_GNe8zkaO2MlBxxGcJcv0BALq9Pon514W\",\n    \"updated_at\": \"2024-05-13T01:09:40.6331583Z\",\n    \"id\": \"pl_GNe8zkaO2MlBxxGcJcv0BALq9Pon514W\",\n    \"expires_in\": 0,\n    \"status\": \"active\"\n}"
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