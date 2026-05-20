# Boleto

Para criar um [pedido](https://docs.pagar.me/v5/reference#criar-pedido-2) com **boleto**, devemos incluir o objeto
`boleto` dentro do nÃ³ `payment`, assim como a propriedade `"payment_method": "boleto"`. O objeto `boleto` contÃ©m as
seguintes propriedades:

<Table align={["left","left","left"]}>
  <thead>
    <tr>
      <th style={{ textAlign: "left" }}>
        Atributos
      </th>

      <th style={{ textAlign: "left" }}>
        Tipo
      </th>

      <th style={{ textAlign: "left" }}>
        DescriÃ§Ã£o
      </th>
    </tr>

  </thead>

  <tbody>
    <tr>
      <td style={{ textAlign: "left" }}>
        `bank`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        Direciona a emissÃ£o para o banco informado. Valores possÃ­veis:`001` (Banco do Brasil); `033` (Santander); `104` (Caixa EconÃ´mica Federal); `197` (Banco Stone);`237` (Bradesco); `341` (Itau);`745` (Citibank) . (**Opcional**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `instructions`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        * Instruções do boleto\_. Max: 256 caracteres.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `due_at`
      </td>

      <td style={{ textAlign: "left" }}>
        **datetime**
      </td>

      <td style={{ textAlign: "left" }}>
        * Data de vencimento\_. (**Opcional**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `nosso_numero`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        * NÃºmero que identifica unicamente um boleto para uma conta\_.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `type`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        * Tipo de espÃ©cie do boleto\_.`DM` (Duplicata Mercantil) e `BDP` (Boleto de proposta)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `metadata`
      </td>

      <td style={{ textAlign: "left" }}>
        **object**
      </td>

      <td style={{ textAlign: "left" }}>
        * Objeto chave/valor utilizado para armazenar informações adicionais sobre o pagamento\_.[Saiba mais sobre metadata](https://docs.pagar.me/v5/reference#metadata-1).
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `document_number`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        * Identificador do boleto\_. Max: 16 caracteres.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `statement_descriptor`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        Texto exibido na fatura do boleto. Max: 13 caracteres. (**Opcional**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `interest`
      </td>

      <td style={{ textAlign: "left" }}>
        **object**
      </td>

      <td style={{ textAlign: "left" }}>
        AplicaÃ§Ã£o do juros apÃ³s vencimento do boleto. (**Opcional**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `interest.days`
      </td>

      <td style={{ textAlign: "left" }}>
        **int**
      </td>

      <td style={{ textAlign: "left" }}>
        Dias apÃ³s a expiraÃ§Ã£o do boleto quando o juros deve ser cobrado. (**ObrigatÃ³rio enviar se o objeto`interest` for enviado**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `interest.type`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        Tipo de divisÃ£o. Os valores possÃ­veis sÃ£o `flat` ou `percentage`. (**ObrigatÃ³rio enviar se o objeto`interest` for enviado**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `interest.amount`
      </td>

      <td style={{ textAlign: "left" }}>
        **int**
      </td>

      <td style={{ textAlign: "left" }}>
        Valor em porcentagem ou em centavos da taxa de juros que serÃ¡ cobrada ao mÃªs. (**ObrigatÃ³rio enviar se o objeto`interest` for enviado**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `fine`
      </td>

      <td style={{ textAlign: "left" }}>
        **object**
      </td>

      <td style={{ textAlign: "left" }}>
        AplicaÃ§Ã£o de multa apÃ³s vencimento do boleto. (**Opcional**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `fine.days`
      </td>

      <td style={{ textAlign: "left" }}>
        **int**
      </td>

      <td style={{ textAlign: "left" }}>
        Dias apÃ³s a expiraÃ§Ã£o do boleto quando a multa deve ser cobrada. (**ObrigatÃ³rio enviar se o objeto`fine` for enviado**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `fine.type`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        Tipo de divisÃ£o. Os valores possÃ­veis sÃ£o `flat` ou `percentage`. (**ObrigatÃ³rio enviar se o objeto`fine` for enviado**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `fine.amount`
      </td>

      <td style={{ textAlign: "left" }}>
        **int**
      </td>

      <td style={{ textAlign: "left" }}>
        Valor em porcentagem ou em centavos que serÃ¡ cobrada na multa. (**ObrigatÃ³rio enviar se o objeto`fine` for enviado**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `discount`
      </td>

      <td style={{ textAlign: "left" }}>
        **object**
      </td>

      <td style={{ textAlign: "left" }}>
        Desconto por antecipaÃ§Ã£o de pagamento. (**Opcional**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `discount.type`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        Tipo do desconto: "percentage" (% sobre o total) ou "flat" (centavos).\
        Aplica-se a todas as regras do array. (**ObrigatÃ³rio enviar se o objeto`discount` for enviado**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `discount.rules`
      </td>

      <td style={{ textAlign: "left" }}>
        **array**
      </td>

      <td style={{ textAlign: "left" }}>
        Lista de regras de desconto ordenadas por limit\_date crescente. (**ObrigatÃ³rio enviar se o objeto`discount` for enviado**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `rules.limit_date`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        Data limite da regra. Formato YYYY-MM-DD. Deve ser anterior ao due\_at do boleto. (**ObrigatÃ³rio enviar se o objeto`discount` for enviado**)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `rules.amount`
      </td>

      <td style={{ textAlign: "left" }}>
        **number**
      </td>

      <td style={{ textAlign: "left" }}>
        Valor do desconto.\
        Se type: percentage: entre 0.01 e 100 (ex: 15.00 = 15%).\
        Se type: flat: inteiro em centavos, mÃ­n. 1 (ex: 500 = R$5,00). (**ObrigatÃ³rio enviar se o objeto`discount` for enviado**)
      </td>
    </tr>

  </tbody>
</Table>

<Callout icon="ðŸ¦" theme="default">
  ### BANCO EMISSOR

Caso sua loja possua mais de uma afiliaÃ§Ã£o de boleto ativa, de bancos diferentes, Ã© possÃ­vel direcionar a emissÃ£o para
um banco especÃ­fico utilizando o campo `bank`.

Caso o parâmetro nÃ£o seja enviado, a emissÃ£o ocorrerÃ¡ conforme prioridades prÃ©-configuradas na sua loja.
</Callout>

> ðŸš§ CANCELAMENTO DE BOLETO
>
> Para clientes gateway, o cancelamento de uma charge de boleto nÃ£o gera um estorno financeiro para o cliente final. O
> cancelamento sÃ³ modifica o status da charge na API para registro do integrador.

> ðŸš§ JUROS, MULTA E DESCONTO NO BOLETO
>
> Somente clientes com integraÃ§Ã£o do tipo PSP (liquidaÃ§Ã£o via Pagar.me) podem utilizar boletos com Juros e Multa.
> Cliente com integraÃ§Ã£o Gateway nÃ£o tem acesso a funcionalidade.

> ðŸ“˜ SOBRE OS VALORES (AMOUNT) DE JUROS E MULTA
>
> **Os parâmetros`interest.amount` e `fine.amount` serÃ£o alterados de acordo com o `interest.type` e `fine.type`
utilizados no request:**
>
> * `flat`: Representa valores inteiros em centavos, portanto o valor do amount nÃ£o poderÃ¡ ser inferior a 1. O amount
    neste caso serÃ¡ cobrado de forma diÃ¡ria;
> * `percentage`: Representa valores em porcentagem, portanto o valor do amount neste caso deve ser maior que 0 e menor
    que 100. Campo aceitarÃ¡ valores parciais com o seguinte formato: `"amount": 1.5` (Significa Juros/Multa de 1,5% do
    valor do pedido). O amount neste caso serÃ¡ cobrado de forma mensal;

> â—ï¸ BOLETOS COM REGISTRO TÃŠM CAMPOS OBRIGATÃ“RIOS
>
> Para requisições de cobranÃ§a de **boletos com registro** os campos `name`, `address` e `document` do cliente (objeto
`customer`) devem ser enviados **OBRIGATORIAMENTE**.

```json Request boleto (Pedido)
{
    "items": [
        {
            "amount": 2990,
            "description": "Chaveiro do Tesseract",
            "quantity": 1
        }
    ],
    "customer": {
        "name": "Tony Stark",
        "email": "avengerstark@ligadajustica.com.br" ,
        "document_type": "CPF",
        "document": "93095135270",
        "type": "Individual",
        "address": {
    	"line_1": "375, Av. General Justo, Centro",
    	"line_2": "8Âº andar",
    	"zip_code": "20021130",
    	"city": "Rio de Janeiro",
    	"state": "RJ",
    	"country": "BR"
    }
    },
    "shipping": {
        "amount": 100,
        "description": "Stark",
        "recipient_name": "Tony Stark",
        "recipient_phone": "24586787867",
        "address": {
            "line_1": "10880, Malibu Point, Malibu Central",
            "zip_code": "90265",
            "city": "Malibu",
            "state": "CA",
            "country": "US"    
        }
    },
    "payments": [
        {
            "payment_method": "boleto",
      "boleto": {
        "instructions": "Pagar atÃ© o vencimento",
        "due_at": "2022-09-20T00:00:00Z",
        "document_number": "123",
        "type": "DM"            
                    }
                }
           
        
    ]
}
```

```json Response boleto (Pedido)
{
  "id": "or_56GXnk6T0eU88qMm",
  "code": "YV3RCRIN24",
  "amount": 3090,
  "currency": "BRL",
  "closed": true,
  "items": [
    {
      "id": "oi_6rXqKEzuZYcRo2zL",
      "description": "Chaveiro do Tesseract",
      "amount": 2990,
      "quantity": 1,
      "status": "active",
      "created_at": "2019-10-16T17:36:30Z",
      "updated_at": "2019-10-16T17:36:30Z"
    }
  ],
  "customer": {
    "id": "cus_x4nz0P4SbOTA0KBZ",
    "name": "Tony Stark",
    "email": "avengerstark@ligadajustica.com.br",
    "document": "14582256988",
    "type": "individual",
    "delinquent": false,
    "created_at": "2019-05-02T17:06:01Z",
    "updated_at": "2019-06-12T14:50:18Z",
    "phones": {}
  },
  "shipping": {
    "amount": 100,
    "description": "Stark",
    "recipient_name": "Tony Stark",
    "recipient_phone": "24586787867",
    "address": {
      "city": "Malibu",
      "state": "CA",
      "country": "US",
      "zip_code": "90265",
      "line_1": "10880, Malibu Point, Malibu Central"
    }
  },
  "status": "pending",
  "created_at": "2019-10-16T17:36:30Z",
  "updated_at": "2019-10-16T17:36:30Z",
  "closed_at": "2019-10-16T17:36:30Z",
  "ip": "52.168.67.32",
  "session_id": "322b821a",
  "device": {
    "platform": "ANDROID OS"
  },
  "location": {
    "latitude": "-22.970722",
    "longitude": "43.182365"
  },
  "charges": [
    {
      "id": "ch_K2rJ5nlHwTE4qRDP",
      "code": "YV3RCRIN24",
      "gateway_id": "3b4bb2d9-19b3-4638-a974-0bb914fff472",
      "amount": 3090,
      "status": "pending",
      "currency": "BRL",
      "payment_method": "boleto",
      "created_at": "2019-10-16T17:36:30Z",
      "updated_at": "2019-10-16T17:36:31Z",
      "customer": {
        "id": "cus_x4nz0P4SbOTA0KBZ",
        "name": "Tony Stark",
        "email": "avengerstark@ligadajustica.com.br",
        "document": "14582256988",
        "type": "individual",
        "delinquent": false,
        "created_at": "2019-05-02T17:06:01Z",
        "updated_at": "2019-06-12T14:50:18Z",
        "phones": {}
      },
      "last_transaction": {
        "id": "tran_bZ0N3DjjUzTW68eq",
        "transaction_type": "boleto",
        "gateway_id": "044581ea-67e8-4772-bd56-f10ade5499de",
        "amount": 3090,
        "status": "generated",
        "success": true,
        "url": "https://sandbox.pagar.me/Boleto/ViewBoleto.aspx?044581ea-67e8-4772-bd56-f10ade5499de",
        "pdf": "https://api.pagar.me/core/v1/transactions/tran_bZ0N3DjjUzTW68eq/pdf",
        "line": "34191.75462 24615.781234 41234.510000 3 83840000003090",
        "barcode": "https://api.pagar.me/core/v1/transactions/tran_bZ0N3DjjUzTW68eq/barcode",
        "qr_code": "https://api.pagar.me/core/v1/transactions/tran_bZ0N3DjjUzTW68eq/qrcode",
        "nosso_numero": "46246157",
        "type": "DM",
        "document_number": "123",
        "instructions": "Pagar atÃ© o vencimento",
        "due_at": "2020-09-20T00:00:00Z",
        "created_at": "2019-10-16T17:36:30Z",
        "updated_at": "2019-10-16T17:36:30Z",
        "gateway_response": {
          "code": "201"
        },
        "antifraud_response": {}
      }
    }
  ],
  "checkouts": []
}
```

```json Request Boleto with interest/fine
{
    "items": [
        {
            "amount": 500,
            "description": "Chaveiro do Tesseract",
            "quantity": 1,
            "code": "123"
        }
    ],
    "customer": {
        "name": "Tony Stark",
        "email": "avengerstark@ligadajustica.com.br",
        "document": "21811216137",
        "type": "individual",
        "address": {
            "line_1": "375, Av. General Justo, Centro",
            "line_2": "8Âº andar",
            "zip_code": "20021130",
            "city": "Rio de Janeiro",
            "state": "RJ",
            "country": "BR"
        },
        "phones": {
            "home_phone": {
                "country_code": "55",
                "area_code": "21",
                "number": "000000000"
            },
            "mobile_phone": {
                "country_code": "55",
                "area_code": "21",
                "number": "000000000"
            }
        }
    },
    "payments": [
        {
            "payment_method": "boleto",
            "boleto": {
                "instructions": "Pagar atÃ© o vencimento",
                "due_at": "2023-07-24T00:00:00Z",
                "document_number": "123",
                "type": "DM",
                "interest": {
                    "days": "2",
                    "type": "percentage",
                    "amount": 20
                },
                "fine": {
                    "days": "2",
                    "type": "flat",
                    "amount": 10
                }
            }
        }
    ]
}
```

```json Response with interest/fine
{
    "id": "or_eKd6Nk7hKyFd2BMl",
    "code": "849WF0YCW7",
    "amount": 500,
    "currency": "BRL",
    "closed": true,
    "items": [
        {
            "id": "oi_8pazKKpFnpS9KzE7",
            "type": "product",
            "description": "Chaveiro do Tesseract",
            "amount": 500,
            "quantity": 1,
            "status": "active",
            "created_at": "2022-10-13T20:24:39Z",
            "updated_at": "2022-10-13T20:24:39Z",
            "code": "123"
        }
    ],
    "customer": {
        "id": "cus_3LVRrkoUVF8AlrY0",
        "name": "Tony Stark",
        "email": "avengerstark@ligadajustica.com.br",
        "document": "21811216137",
        "document_type": "cpf",
        "type": "individual",
        "delinquent": false,
        "address": {
            "id": "addr_KgWJNxBsKsQG7PDj",
            "line_1": "375, Av. General Justo, Centro",
            "line_2": "8Âº andar",
            "zip_code": "20021130",
            "city": "Rio de Janeiro",
            "state": "RJ",
            "country": "BR",
            "status": "active",
            "created_at": "2021-07-20T14:25:18Z",
            "updated_at": "2022-10-13T19:52:19Z"
        },
        "created_at": "2020-11-23T17:55:51Z",
        "updated_at": "2022-10-13T19:52:19Z",
        "phones": {
            "home_phone": {
                "country_code": "55",
                "number": "000000000",
                "area_code": "21"
            },
            "mobile_phone": {
                "country_code": "55",
                "number": "000000000",
                "area_code": "21"
            }
        }
    },
    "status": "pending",
    "created_at": "2022-10-13T20:24:39Z",
    "updated_at": "2022-10-13T20:24:39Z",
    "closed_at": "2022-10-13T20:24:39Z",
    "charges": [
        {
            "id": "ch_PA50xD0GSaCZxrNB",
            "code": "849WF0YCW7",
            "gateway_id": "18752786",
            "amount": 500,
            "status": "pending",
            "currency": "BRL",
            "payment_method": "boleto",
            "created_at": "2022-10-13T20:24:39Z",
            "updated_at": "2022-10-13T20:24:39Z",
            "customer": {
                "id": "cus_3LVRrkoUVF8AlrY0",
                "name": "Tony Stark",
                "email": "avengerstark@ligadajustica.com.br",
                "document": "21811216137",
                "document_type": "cpf",
                "type": "individual",
                "delinquent": false,
                "address": {
                    "id": "addr_KgWJNxBsKsQG7PDj",
                    "line_1": "375, Av. General Justo, Centro",
                    "line_2": "8Âº andar",
                    "zip_code": "20021130",
                    "city": "Rio de Janeiro",
                    "state": "RJ",
                    "country": "BR",
                    "status": "active",
                    "created_at": "2021-07-20T14:25:18Z",
                    "updated_at": "2022-10-13T19:52:19Z"
                },
                "created_at": "2020-11-23T17:55:51Z",
                "updated_at": "2022-10-13T19:52:19Z",
                "phones": {
                    "home_phone": {
                        "country_code": "55",
                        "number": "000000000",
                        "area_code": "21"
                    },
                    "mobile_phone": {
                        "country_code": "55",
                        "number": "000000000",
                        "area_code": "21"
                    }
                }
            },
            "last_transaction": {
                "id": "tran_naLPrX2COIlEAol9",
                "transaction_type": "boleto",
                "gateway_id": "18752786",
                "amount": 500,
                "status": "generated",
                "success": true,
                "url": "https://pagar.me",
                "pdf": "https://pagar.me?format=pdf",
                "line": "1234 5678",
                "barcode": "https://api.pagar.me/core/v5/transactions/tran_naLPrX2COIlEAol9/barcode",
                "qr_code": "https://api.pagar.me/core/v5/transactions/tran_naLPrX2COIlEAol9/qrcode",
                "nosso_numero": "18752786",
                "type": "DM",
                "bank": "198",
                "document_number": "18752786",
                "instructions": "Pagar atÃ© o vencimento",
                "due_at": "2023-07-24T23:59:59Z",
                "interest": {
                    "days": 2,
                    "type": "percentage",
                    "amount": 20.0
                },
                "fine": {
                    "days": 2,
                    "type": "flat",
                    "amount": 10.0
                },
                "created_at": "2022-10-13T20:24:39Z",
                "updated_at": "2022-10-13T20:24:39Z",
                "gateway_response": {
                    "code": "200"
                },
                "antifraud_response": {}
            }
        }
    ],
    "checkouts": []
}
```

```json Request Boleto with discount percentage
{
  "items": [
    {
      "amount": 500,
      "description": "Produto exemplo",
      "quantity": 1
    }
  ],
  "customer": {
    "name": "Tony Stark",
    "email": "avengerstark@ligadajustica.com.br",
    "document": "21811216137",
    "type": "individual",
    "address": {
      "line_1": "375, Av. General Justo, Centro",
      "line_2": "8Âº andar",
      "zip_code": "20021130",
      "city": "Rio de Janeiro",
      "state": "RJ",
      "country": "BR"
    },
    "phones": {
      "home_phone": {
        "country_code": "55",
        "area_code": "21",
        "number": "000000000"
      },
      "mobile_phone": {
        "country_code": "55",
        "area_code": "21",
        "number": "000000000"
      }
    }
  },
  "payments": [
    {
      "payment_method": "boleto",
      "boleto": {
        "instructions": "Pagar atÃ© o vencimento",
        "due_at": "2026-07-30T00:00:00Z",
        "document_number": "DOC-2026-001",
        "type": "DM",
        "interest": {
          "days": 2,
          "type": "percentage",
          "amount": 1.5
        },
        "fine": {
          "days": 2,
          "type": "flat",
          "amount": 500
        },
        "discount": {
          "type": "percentage",
          "rules": [
            {
              "limit_date": "2026-07-20",
              "amount": 15.00
            },
            {
              "limit_date": "2026-07-25",
              "amount": 10.00
            },
            {
              "limit_date": "2026-07-27",
              "amount": 5.00
            }
          ]
        }
      }
    }
  ]
}
```

```json Response Boleto with discount percentage
{
    "id": "or_eKd6Nk7hKyFd2BMl",
    "code": "849WF0YCW7",
    "amount": 500,
    "currency": "BRL",
    "closed": true,
    "items": [
        {
            "id": "oi_8pazKKpFnpS9KzE7",
            "type": "product",
            "description": "Chaveiro do Tesseract",
            "amount": 500,
            "quantity": 1,
            "status": "active",
            "created_at": "2022-10-13T20:24:39Z",
            "updated_at": "2022-10-13T20:24:39Z",
            "code": "123"
        }
    ],
    "customer": {
        "id": "cus_3LVRrkoUVF8AlrY0",
        "name": "Tony Stark",
        "email": "avengerstark@ligadajustica.com.br",
        "document": "21811216137",
        "document_type": "cpf",
        "type": "individual",
        "delinquent": false,
        "address": {
            "id": "addr_KgWJNxBsKsQG7PDj",
            "line_1": "375, Av. General Justo, Centro",
            "line_2": "8Âº andar",
            "zip_code": "20021130",
            "city": "Rio de Janeiro",
            "state": "RJ",
            "country": "BR",
            "status": "active",
            "created_at": "2021-07-20T14:25:18Z",
            "updated_at": "2022-10-13T19:52:19Z"
        },
        "created_at": "2020-11-23T17:55:51Z",
        "updated_at": "2022-10-13T19:52:19Z",
        "phones": {
            "home_phone": {
                "country_code": "55",
                "number": "000000000",
                "area_code": "21"
            },
            "mobile_phone": {
                "country_code": "55",
                "number": "000000000",
                "area_code": "21"
            }
        }
    },
    "status": "pending",
    "created_at": "2022-10-13T20:24:39Z",
    "updated_at": "2022-10-13T20:24:39Z",
    "closed_at": "2022-10-13T20:24:39Z",
    "charges": [
        {
            "id": "ch_PA50xD0GSaCZxrNB",
            "code": "849WF0YCW7",
            "gateway_id": "18752786",
            "amount": 500,
            "status": "pending",
            "currency": "BRL",
            "payment_method": "boleto",
            "created_at": "2022-10-13T20:24:39Z",
            "updated_at": "2022-10-13T20:24:39Z",
            "customer": {
                "id": "cus_3LVRrkoUVF8AlrY0",
                "name": "Tony Stark",
                "email": "avengerstark@ligadajustica.com.br",
                "document": "21811216137",
                "document_type": "cpf",
                "type": "individual",
                "delinquent": false,
                "address": {
                    "id": "addr_KgWJNxBsKsQG7PDj",
                    "line_1": "375, Av. General Justo, Centro",
                    "line_2": "8Âº andar",
                    "zip_code": "20021130",
                    "city": "Rio de Janeiro",
                    "state": "RJ",
                    "country": "BR",
                    "status": "active",
                    "created_at": "2021-07-20T14:25:18Z",
                    "updated_at": "2022-10-13T19:52:19Z"
                },
                "created_at": "2020-11-23T17:55:51Z",
                "updated_at": "2022-10-13T19:52:19Z",
                "phones": {
                    "home_phone": {
                        "country_code": "55",
                        "number": "000000000",
                        "area_code": "21"
                    },
                    "mobile_phone": {
                        "country_code": "55",
                        "number": "000000000",
                        "area_code": "21"
                    }
                }
            },
            "last_transaction": {
                "id": "tran_naLPrX2COIlEAol9",
                "transaction_type": "boleto",
                "gateway_id": "18752786",
                "amount": 500,
                "status": "generated",
                "success": true,
                "url": "https://pagar.me",
                "pdf": "https://pagar.me?format=pdf",
                "line": "1234 5678",
                "barcode": "https://api.pagar.me/core/v5/transactions/tran_naLPrX2COIlEAol9/barcode",
                "qr_code": "https://api.pagar.me/core/v5/transactions/tran_naLPrX2COIlEAol9/qrcode",
                "nosso_numero": "18752786",
                "type": "DM",
                "bank": "198",
                "document_number": "18752786",
                "instructions": "Pagar atÃ© o vencimento",
                "due_at": "2023-07-24T23:59:59Z",
                "interest": {
                    "days": 2,
                    "type": "percentage",
                    "amount": 20.0
                },
                "fine": {
                    "days": 2,
                    "type": "flat",
                    "amount": 10.0
                },
                "created_at": "2022-10-13T20:24:39Z",
                "updated_at": "2022-10-13T20:24:39Z",
                "gateway_response": {
                    "code": "200"
                },
                "antifraud_response": {}
            }
        }
    ],
    "checkouts": []
}
```

```json Request Boleto with discount flat
{
  "items": [
    {
      "amount": 500,
      "description": "Produto exemplo",
      "quantity": 1
    }
  ],
  "customer": {
    "name": "Tony Stark",
    "email": "avengerstark@ligadajustica.com.br",
    "document": "21811216137",
    "type": "individual",
    "address": {
      "line_1": "375, Av. General Justo, Centro",
      "line_2": "8Âº andar",
      "zip_code": "20021130",
      "city": "Rio de Janeiro",
      "state": "RJ",
      "country": "BR"
    },
    "phones": {
      "home_phone": {
        "country_code": "55",
        "area_code": "21",
        "number": "000000000"
      },
      "mobile_phone": {
        "country_code": "55",
        "area_code": "21",
        "number": "000000000"
      }
    }
  },
  "payments": [
    {
      "payment_method": "boleto",
      "boleto": {
        "instructions": "Pagar atÃ© o vencimento",
        "due_at": "2026-07-30T00:00:00Z",
        "document_number": "DOC-2026-001",
        "type": "DM",
        "interest": {
          "days": 2,
          "type": "percentage",
          "amount": 1.5
        },
        "fine": {
          "days": 2,
          "type": "flat",
          "amount": 500
        },
        "discount": {
          "type": "flat",
          "rules": [
            {
              "limit_date": "2026-07-20",
              "amount": 300
            },
            {
              "limit_date": "2026-07-25",
              "amount": 150
            }
          ]
        }
      }
    }
  ]
}
```

```Text Request Boleto with discount flat
{
    "id": "or_eKd6Nk7hKyFd2BMl",
    "code": "849WF0YCW7",
    "amount": 500,
    "currency": "BRL",
    "closed": true,
    "items": [
        {
            "id": "oi_8pazKKpFnpS9KzE7",
            "type": "product",
            "description": "Chaveiro do Tesseract",
            "amount": 500,
            "quantity": 1,
            "status": "active",
            "created_at": "2022-10-13T20:24:39Z",
            "updated_at": "2022-10-13T20:24:39Z",
            "code": "123"
        }
    ],
    "customer": {
        "id": "cus_3LVRrkoUVF8AlrY0",
        "name": "Tony Stark",
        "email": "avengerstark@ligadajustica.com.br",
        "document": "21811216137",
        "document_type": "cpf",
        "type": "individual",
        "delinquent": false,
        "address": {
            "id": "addr_KgWJNxBsKsQG7PDj",
            "line_1": "375, Av. General Justo, Centro",
            "line_2": "8Âº andar",
            "zip_code": "20021130",
            "city": "Rio de Janeiro",
            "state": "RJ",
            "country": "BR",
            "status": "active",
            "created_at": "2021-07-20T14:25:18Z",
            "updated_at": "2022-10-13T19:52:19Z"
        },
        "created_at": "2020-11-23T17:55:51Z",
        "updated_at": "2022-10-13T19:52:19Z",
        "phones": {
            "home_phone": {
                "country_code": "55",
                "number": "000000000",
                "area_code": "21"
            },
            "mobile_phone": {
                "country_code": "55",
                "number": "000000000",
                "area_code": "21"
            }
        }
    },
    "status": "pending",
    "created_at": "2022-10-13T20:24:39Z",
    "updated_at": "2022-10-13T20:24:39Z",
    "closed_at": "2022-10-13T20:24:39Z",
    "charges": [
        {
            "id": "ch_PA50xD0GSaCZxrNB",
            "code": "849WF0YCW7",
            "gateway_id": "18752786",
            "amount": 500,
            "status": "pending",
            "currency": "BRL",
            "payment_method": "boleto",
            "created_at": "2022-10-13T20:24:39Z",
            "updated_at": "2022-10-13T20:24:39Z",
            "customer": {
                "id": "cus_3LVRrkoUVF8AlrY0",
                "name": "Tony Stark",
                "email": "avengerstark@ligadajustica.com.br",
                "document": "21811216137",
                "document_type": "cpf",
                "type": "individual",
                "delinquent": false,
                "address": {
                    "id": "addr_KgWJNxBsKsQG7PDj",
                    "line_1": "375, Av. General Justo, Centro",
                    "line_2": "8Âº andar",
                    "zip_code": "20021130",
                    "city": "Rio de Janeiro",
                    "state": "RJ",
                    "country": "BR",
                    "status": "active",
                    "created_at": "2021-07-20T14:25:18Z",
                    "updated_at": "2022-10-13T19:52:19Z"
                },
                "created_at": "2020-11-23T17:55:51Z",
                "updated_at": "2022-10-13T19:52:19Z",
                "phones": {
                    "home_phone": {
                        "country_code": "55",
                        "number": "000000000",
                        "area_code": "21"
                    },
                    "mobile_phone": {
                        "country_code": "55",
                        "number": "000000000",
                        "area_code": "21"
                    }
                }
            },
            "last_transaction": {
                "id": "tran_naLPrX2COIlEAol9",
                "transaction_type": "boleto",
                "gateway_id": "18752786",
                "amount": 500,
                "status": "generated",
                "success": true,
                "url": "https://pagar.me",
                "pdf": "https://pagar.me?format=pdf",
                "line": "1234 5678",
                "barcode": "https://api.pagar.me/core/v5/transactions/tran_naLPrX2COIlEAol9/barcode",
                "qr_code": "https://api.pagar.me/core/v5/transactions/tran_naLPrX2COIlEAol9/qrcode",
                "nosso_numero": "18752786",
                "type": "DM",
                "bank": "198",
                "document_number": "18752786",
                "instructions": "Pagar atÃ© o vencimento",
                "due_at": "2023-07-24T23:59:59Z",
                "interest": {
                    "days": 2,
                    "type": "percentage",
                    "amount": 20.0
                },
                "fine": {
                    "days": 2,
                    "type": "flat",
                    "amount": 10.0
                },
                "created_at": "2022-10-13T20:24:39Z",
                "updated_at": "2022-10-13T20:24:39Z",
                "gateway_response": {
                    "code": "200"
                },
                "antifraud_response": {}
            }
        }
    ],
    "checkouts": []
}
```

## Status das transações de boleto (Transaction)

As transações de boleto podem possuir os seguintes status:

| Status       | DescriÃ§Ã£o                             |
|:-------------|:--------------------------------------|
| `generated`  | Gerado                                |
| `viewed`     | Visualizado                           |
| `underpaid`  | Pago a menor                          |
| `overpaid`   | Pago a maior                          |
| `paid`       | Pago                                  |
| `voided`     | Cancelado                             |
| `with_error` | Com erro                              |
| `failed`     | Falha                                 |
| `processing` | Boleto ainda estÃ¡ em etapa de criaÃ§Ã£o |

> ðŸ“˜ VisualizaÃ§Ã£o de boletos vencidos
>
> Atualmente Ã© possÃ­vel acessar um boleto atÃ© 60 dias apÃ³s o seu vencimento.\
> ApÃ³s esse perÃ­odo o mesmo nÃ£o estarÃ¡ mais disponÃ­vel para consulta e pagamento.