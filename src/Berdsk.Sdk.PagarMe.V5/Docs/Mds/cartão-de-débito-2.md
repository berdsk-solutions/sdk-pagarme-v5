# CartÃ£o de dÃ©bito

Para criar um [pedido](https://docs.pagar.me/v5/reference#criar-pedido-2) com **cartÃ£o de dÃ©bito**, devemos incluir o
objeto `debit_card` dentro do nÃ³ `payment`, assim como a propriedade `"payment_method": "debit_card"`. O objeto
`debit_card` contÃªm os seguintes atributos:

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
        `statement_descriptor`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        Texto exibido na fatura do cartÃ£o. Max: 22 caracteres.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `card`, `card_id, `card\_token`ou`network\_token\`
      </td>

      <td style={{ textAlign: "left" }}>
        **object**
      </td>

      <td style={{ textAlign: "left" }}>
        CartÃ£o de dÃ©bito.\
        `card`: Informações referentes ao cartÃ£o do cliente.\
        `card_id` Ã© o identificador do cartÃ£o de um cliente.\
        `card_token` Ã© o token do cartÃ£o gerado pelo checkout transparente. [Saiba mais sobre cartÃµes](https://docs.pagar.me/v5/reference#pagarme-js).\
        `network_token`: Token referente a uma cartÃ£o gerado pelos serviÃ§os de tokenizaÃ§Ã£o das bandeiras.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `recurrence`
      </td>

      <td style={{ textAlign: "left" }}>
        **boolean**
      </td>

      <td style={{ textAlign: "left" }}>
        Indica se Ã© uma cobranÃ§a/pedido de recorrÃªncia.\
        Valor padrÃ£o: `false`
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
        Objeto chave/valor utilizado para armazenar informações adicionais sobre o pagamento.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `merchant_category_code`
      </td>

      <td style={{ textAlign: "left" }}>
        **integer**
      </td>

      <td style={{ textAlign: "left" }}>
        CÃ³digo de classificaÃ§Ã£o do ramo de atuaÃ§Ã£o do lojista.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `authentication`
      </td>

      <td style={{ textAlign: "left" }}>
        **object**
      </td>

      <td style={{ textAlign: "left" }}>
        Objeto que indica se a transaÃ§Ã£o de dÃ©bito Ã© autenticada ou nÃ£o.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `payload`
      </td>

      <td style={{ textAlign: "left" }}>
        **object**
      </td>

      <td style={{ textAlign: "left" }}>
        Objeto de dados criptografados, tais como: [GooglePay](https://docs.pagar.me/reference/google-paytm-api)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `initiated_type`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        Identificador do tipo de transaÃ§Ã£o avulsa.\
        Valores possÃ­veis: `partial_shipment` (Remessa Parcial), `related_or_delayed_charge` (CobranÃ§a Atrasada), `no_show` (Multa) ou `retry` (Retentativa).
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `recurrence_model`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        Identificador do tipo de recorrÃªncia.\
        Valores possÃ­veis: `standing_order` (Ordem Permanente), `instalment` (Parcelamento) ou `subscription` (Assinatura convencional com valor e frequÃªncia fixa).
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `channel`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        Identificador da origem da transaÃ§Ã£o\
        Valores possÃ­veis: `payment_link`\
        NecessÃ¡rio apenas para a bandeira Elo
      </td>
    </tr>

  </tbody>
</Table>

> ðŸš§ Funcionalidade disponÃ­vel apenas para clientes Gateway
>
> As funcionalidades apresentadas abaixo estÃ£o disponÃ­vel apenas para clientes gateway

Para os casos em que a transaÃ§Ã£o Ã© autenticada, o objeto `authentication` Ã© obrigatÃ³rio. Ele possui os seguintes campos:

|                 |            |                                                                                                   |
|:----------------|:-----------|:--------------------------------------------------------------------------------------------------|
| `type`          | **string** | *Indica o tipo de autenticaÃ§Ã£o utilizado*. Atualmente o Ãºnico tipo suportado Ã© **threed\_secure** |
| `threed_secure` | **object** | *Indica os campos a serem enviados para a autenticaÃ§Ã£o 3DS.*                                      |

Por fim, o objeto `threed_secure` contÃ©m os seguintes campos:

| Atributos           | Tipo       | Tamanho mÃ¡ximo | DescriÃ§Ã£o                                                                                                      |
|:--------------------|:-----------|:---------------|:---------------------------------------------------------------------------------------------------------------|
| `mpi`               | **string** | 11             | *Indica quem Ã© o autenticador da transaÃ§Ã£o*. Pode receber o valor "third\_party" para autenticadores externos. |
| `eci`               | **string** | 2              | *Indica o resultado da tentativa de autenticaÃ§Ã£o*. ObrigatÃ³rio quando o `mpi` Ã© "third\_party".                |
| `cavv`              | **string** | 256            | *CÃ³digo de autenticaÃ§Ã£o do dono do cartÃ£o*. ObrigatÃ³rio quando o `mpi` Ã© "third\_party".                       |
| `transaction_id`    | **string** | 256            | *id da transaÃ§Ã£o no autenticador*. ObrigatÃ³rio quando o `mpi` Ã© "third\_party".                                |
| `ds_transaction_id` | **string** | 256            | Identificador da transaÃ§Ã£o no Directory Service                                                                |
| `version`           | **string** | 6              | VersÃ£o do 3D-S                                                                                                 |
| `success_url`       | **string** | 512            | *Url de redirecionamento quando a transaÃ§Ã£o Ã© aprovada pelo autenticador*.                                     |

> ðŸ“˜ AutenticaÃ§Ã£o 3DS
>
> Os campos `mpi`, `eci`, `cavv` e `transaction_id` sÃ£o os necessÃ¡rios para uma transaÃ§Ã£o com autenticaÃ§Ã£o externa.

> â—ï¸ AtenÃ§Ã£o
>
> Atualmente Ã© ofertado 2 versÃµes para autenticaÃ§Ã£o de transações. A versÃ£o 1.0 do 3DS serÃ¡ descontinuada e o Pagar.me
> estÃ¡ aceitando novas integrações apenas na versÃ£o 2.0 que apresenta melhor experiÃªncia para o portador e maior nÃºmero de
> dispositivos suportados.

> â—ï¸ IndicaÃ§Ã£o de transações de link de pagamento
>
> A partir de 17 de outubro de 2025 serÃ¡ obrigatÃ³rio identificar que uma transaÃ§Ã£o foi originada atravÃ©s de um link de
> pagamento para cartÃµes da bandeira Elo.
>
> No fluxo transacional, para indicar que uma transaÃ§Ã£o Ã© de link de pagamento Ã© necessÃ¡rio enviar o campo `channel` com
> o valor `payment_link`.

```json Request cartÃ£o de dÃ©bito com autenticaÃ§Ã£o - 3DS (Pedido)
{
    "amount": 1000,
    "code": "123",
    "customer": {
        "name": "Tony Stark"
    },
    "currency": "BRL",
    "payment": {
        "payment_method": "debit_card",
        "operation_reference": "TESTEAPIDOCS",
        "debit_card": {
            "capture": false,
            "installments": 1,
            "statement_descriptor": "APIDOCS",
            "card": {
                "number": "4000000000000010",
                "holder_name": "Tony Stark",
                "exp_month": 11,
                "exp_year": 23,
                "cvv": "351"
            },
            "authentication": {
                "type": "threed_secure",
                "threed_secure": {
                    "mpi": "third_party",
                    "eci": "05",
                    "cavv": "BwABBylVaQAAAAFwllVpAAAAAAA=",
                    "ds_transaction_id": "Nmp3VFdWMlEwZ05pWGN3SGo4TDA=",
                    "version": "2"
                }
            }
        },
        "metadata": {
            "mundipagg_payment_method_code": "19"
        }
    }
}
```

```json Request cartÃ£o de dÃ©bito utilizando Network Token (Pedido)
{
    "items": [
        {
            "amount": 2990,
            "description": "Teste de dÃ©bito",
            "quantity": 1,
            "code": "123"
        }
    ],
    "customer": {
        "name": "Tony Stark",
        "email": "TonyStark@gmail.com",
        "document": "93095135270",
        "type": "individual",
        "document_type": "CPF",
        "address": {
            "line_1": "375, Av. General Justo, Centro",
            "line_2": "8Âº andar",
            "zip_code": "20021130",
            "city": "Rio de Janeiro",
            "state": "RJ",
            "country": "BR"
        }
    },
    "payments": [
        {
            "payment_method": "debit_card",
            "debit_card": {
                "capture": false,
                "installments": 1,
                "statement_descriptor": "AVENGERS",
                "network_token": {
                    "number": "5256621004565548",
                    "holder_name": "Tony Stark",
                    "exp_month": 12,
                    "exp_year": 2023,
                    "cryptograms": [
                        "ANfQt43bddROAAEnSAMhAAADFA===="
                    ],
                    "billing_address": {
                        "street": "Malibu Point",
                        "number": "10880",
                        "zip_code": "90265",
                        "neighborhood": "Central Malibu",
                        "city": "Malibu",
                        "state": "CA",
                        "country": "US"
                    }
                }
            },
        }
    ]
}
```

```json Response cartÃ£o de dÃ©bito utilizando Network Token (Pedido)
{
    "id": "or_nEA3rVEC7TqOVWM2",
    "code": "W2NQAEJF3J",
    "amount": 2990,
    "currency": "BRL",
    "closed": true,
    "items": [
        {
            "id": "oi_2jdEG82C8Cz5wLy4",
            "type": "product",
            "description": "Teste de dÃ©bito",
            "amount": 2990,
            "quantity": 1,
            "status": "active",
            "created_at": "2023-04-14T18:13:25Z",
            "updated_at": "2023-04-14T18:13:25Z",
            "code": "123"
        }
    ],
    "customer": {
        "id": "cus_4qN8MKbCxt8aDovj",
        "name": "Tony Stark",
        "email": "TonyStark@gmail.com",
        "document": "93095135270",
        "document_type": "cpf",
        "type": "individual",
        "delinquent": false,
        "address": {
            "id": "addr_bve7jDhwvsm5orDk",
            "line_1": "375, Av. General Justo, Centro",
            "line_2": "8Âº andar",
            "zip_code": "20021130",
            "city": "Rio de Janeiro",
            "state": "RJ",
            "country": "BR",
            "status": "active",
            "created_at": "2023-04-14T18:13:16Z",
            "updated_at": "2023-04-14T18:13:16Z"
        },
        "created_at": "2023-04-14T18:13:16Z",
        "updated_at": "2023-04-14T18:13:16Z",
        "phones": {}
    },
    "status": "paid",
    "created_at": "2023-04-14T18:13:25Z",
    "updated_at": "2023-04-14T18:13:28Z",
    "closed_at": "2023-04-14T18:13:25Z",
    "charges": [
        {
            "id": "ch_K83x0jXHMLumQalm",
            "code": "W2NQAEJF3J",
            "gateway_id": "f942829d-4a63-47b2-9af1-bef65ced0a5a",
            "amount": 2990,
            "paid_amount": 2990,
            "status": "paid",
            "currency": "BRL",
            "payment_method": "debit_card",
            "paid_at": "2023-04-14T18:13:27Z",
            "created_at": "2023-04-14T18:13:25Z",
            "updated_at": "2023-04-14T18:13:27Z",
            "customer": {
                "id": "cus_4qN8MKbCxt8aDovj",
                "name": "Tony Stark",
                "email": "TonyStark@gmail.com",
                "document": "93095135270",
                "document_type": "cpf",
                "type": "individual",
                "delinquent": false,
                "address": {
                    "id": "addr_bve7jDhwvsm5orDk",
                    "line_1": "375, Av. General Justo, Centro",
                    "line_2": "8Âº andar",
                    "zip_code": "20021130",
                    "city": "Rio de Janeiro",
                    "state": "RJ",
                    "country": "BR",
                    "status": "active",
                    "created_at": "2023-04-14T18:13:16Z",
                    "updated_at": "2023-04-14T18:13:16Z"
                },
                "created_at": "2023-04-14T18:13:16Z",
                "updated_at": "2023-04-14T18:13:16Z",
                "phones": {}
            },
            "last_transaction": {
                "id": "tran_BaQ7M70FRiQbVZew",
                "transaction_type": "debit_card",
                "gateway_id": "db376787-7071-49d4-9ab0-a3a5d4d176f2",
                "amount": 2990,
                "status": "captured",
                "success": true,
                "statement_descriptor": "AVENGERS",
                "acquirer_name": "stone",
                "acquirer_affiliation_code": "266B24CD5F429E56134743A01287BACB",
                "acquirer_tid": "20430073908801",
                "acquirer_nsu": "20430073908801",
                "acquirer_auth_code": "908801",
                "acquirer_message": "Stone|Aprovado",
                "acquirer_return_code": "0000",
                "operation_type": "capture",
                "network_token": {
                    "id": "nt_doLl3pGmUrIo5Pgn",
                    "first_six_digits": "525662",
                    "last_four_digits": "5548",
                    "brand": "Mastercard",
                    "holder_name": "Tony Stark",
                    "exp_month": 12,
                    "exp_year": 2023,
                    "created_at": "2023-04-14T18:13:16Z",
                    "updated_at": "2023-04-14T18:13:16Z",
                    "status": "active",
                    "billing_address": {
                        "street": "Malibu Point",
                        "number": "10880",
                        "zip_code": "90265",
                        "neighborhood": "Central Malibu",
                        "city": "Malibu",
                        "state": "CA",
                        "country": "US"
                    }
                },
                "payment_type": "Token",
                "created_at": "2023-04-14T18:13:25Z",
                "updated_at": "2023-04-14T18:13:25Z",
                "gateway_response": {
                    "code": "201",
                    "errors": []
                },
                "antifraud_response": {},
                "metadata": {}
            },
        }
    ]
}
```

```json Request cartÃ£o de dÃ©bito utilizando Network Token com autenticaÃ§Ã£o (Pedido)
{
    "items": [
        {
            "amount": 2990,
            "description": "Teste de dÃ©bito",
            "quantity": 1,
            "code": "123"
        }
    ],
    "customer": {
        "name": "Tony Stark",
        "email": "tonystark@gmail.com",
        "document": "93095135270",
        "type": "individual",
        "document_type": "CPF",
        "address": {
            "line_1": "375, Av. General Justo, Centro",
            "line_2": "8Âº andar",
            "zip_code": "20021130",
            "city": "Rio de Janeiro",
            "state": "RJ",
            "country": "BR"
        }
    },
    "payments": [
        {
            "payment_method": "debit_card",
            "debit_card": {
                "capture": false,
                "installments": 1,
                "statement_descriptor": "AVENGERS",
                "network_token": {
                    "number": "5256621004565548",
                    "holder_name": "Tony Stark",
                    "exp_month": 12,
                    "exp_year": 2023,
                    "cryptograms": [
                        "ANfQt43bddROAAEnSAMhAAADFA===="
                    ],
                    "billing_address": {
                        "street": "Malibu Point",
                        "number": "10880",
                        "zip_code": "90265",
                        "neighborhood": "Central Malibu",
                        "city": "Malibu",
                        "state": "CA",
                        "country": "US"
                    }
                },
                "authentication": {
                    "type": "threed_secure",
                    "threed_secure": {
                        "mpi": "acquirer",
                        "success_url": "http://www.pagar.me"
                    }
                }
            },
        }
    ]
}
```

```json Response cartÃ£o de dÃ©bito utilizando Network Token com autenticaÃ§Ã£o (Pedido)
{
    "id": "or_yJPVBm7szliRwx97",
    "code": "MKJDF40UO8",
    "amount": 2990,
    "currency": "BRL",
    "closed": true,
    "items": [
        {
            "id": "oi_a9g8lb5t6cQKXWpe",
            "type": "product",
            "description": "Teste de dÃ©bito",
            "amount": 2990,
            "quantity": 1,
            "status": "active",
            "created_at": "2023-04-14T18:25:38Z",
            "updated_at": "2023-04-14T18:25:38Z",
            "code": "123"
        }
    ],
    "customer": {
        "id": "cus_4qN8MKbCxt8aDovj",
        "name": "Tony Stark",
        "email": "TonyStark@gmail.com",
        "document": "93095135270",
        "document_type": "cpf",
        "type": "individual",
        "delinquent": false,
        "address": {
            "id": "addr_bve7jDhwvsm5orDk",
            "line_1": "375, Av. General Justo, Centro",
            "line_2": "8Âº andar",
            "zip_code": "20021130",
            "city": "Rio de Janeiro",
            "state": "RJ",
            "country": "BR",
            "status": "active",
            "created_at": "2023-04-14T18:13:16Z",
            "updated_at": "2023-04-14T18:13:16Z"
        },
        "created_at": "2023-04-14T18:13:16Z",
        "updated_at": "2023-04-14T18:13:16Z",
        "phones": {}
    },
    "status": "paid",
    "created_at": "2023-04-14T18:25:38Z",
    "updated_at": "2023-04-14T18:25:42Z",
    "closed_at": "2023-04-14T18:25:38Z",
    "charges": [
        {
            "id": "ch_aRLoYxLHefrMOkAG",
            "code": "MKJDF40UO8",
            "gateway_id": "824a2f78-0548-4655-9131-8b4065066d77",
            "amount": 2990,
            "paid_amount": 2990,
            "status": "paid",
            "currency": "BRL",
            "payment_method": "debit_card",
            "paid_at": "2023-04-14T18:25:42Z",
            "created_at": "2023-04-14T18:25:39Z",
            "updated_at": "2023-04-14T18:25:42Z",
            "customer": {
                "id": "cus_4qN8MKbCxt8aDovj",
                "name": "Tony Stark",
                "email": "TonyStark@gmail.com",
                "document": "93095135270",
                "document_type": "cpf",
                "type": "individual",
                "delinquent": false,
                "address": {
                    "id": "addr_bve7jDhwvsm5orDk",
                    "line_1": "375, Av. General Justo, Centro",
                    "line_2": "8Âº andar",
                    "zip_code": "20021130",
                    "city": "Rio de Janeiro",
                    "state": "RJ",
                    "country": "BR",
                    "status": "active",
                    "created_at": "2023-04-14T18:13:16Z",
                    "updated_at": "2023-04-14T18:13:16Z"
                },
                "created_at": "2023-04-14T18:13:16Z",
                "updated_at": "2023-04-14T18:13:16Z",
                "phones": {}
            },
            "last_transaction": {
                "id": "tran_jRpOmqgckHn6NBEb",
                "transaction_type": "debit_card",
                "gateway_id": "5c7d44af-f695-4046-8264-fa7a238b3bae",
                "amount": 2990,
                "status": "captured",
                "success": true,
                "statement_descriptor": "AVENGERS",
                "acquirer_name": "stone",
                "acquirer_affiliation_code": "266B24CD5F429E56134743A01287BACB",
                "acquirer_tid": "20430073908837",
                "acquirer_nsu": "20430073908837",
                "acquirer_auth_code": "908837",
                "acquirer_message": "Stone|Aprovado",
                "acquirer_return_code": "0000",
                "operation_type": "capture",
                "mpi": "acquirer",
                "network_token": {
                    "id": "nt_doLl3pGmUrIo5Pgn",
                    "first_six_digits": "525662",
                    "last_four_digits": "5548",
                    "brand": "Mastercard",
                    "holder_name": "Tony Stark",
                    "exp_month": 12,
                    "exp_year": 2023,
                    "created_at": "2023-04-14T18:13:16Z",
                    "updated_at": "2023-04-14T18:13:16Z",
                    "status": "active",
                    "billing_address": {
                        "street": "Malibu Point",
                        "number": "10880",
                        "zip_code": "90265",
                        "neighborhood": "Central Malibu",
                        "city": "Malibu",
                        "state": "CA",
                        "country": "US"
                    }
                },
                "payment_type": "Token",
                "created_at": "2023-04-14T18:25:39Z",
                "updated_at": "2023-04-14T18:25:39Z",
                "gateway_response": {
                    "code": "201",
                    "errors": []
                },
                "antifraud_response": {},
                "metadata": {}
            },
            }
        }
    ]
}
```

## Status das transações de CartÃ£o de DÃ©bito (Transaction)

As transações de CartÃ£o de DÃ©bito podem possuir os seguintes status:

| Status               | DescriÃ§Ã£o       |
|:---------------------|:----------------|
| `not_authorized`     | NÃ£o autorizada  |
| `pending`            | Pendente        |
| `captured`           | Capturada       |
| `refunded`           | Estornada       |
| `error_on_refunding` | Erro no estorno |
| `with_error`         | Com erro        |
| `failed`             | Falha           |