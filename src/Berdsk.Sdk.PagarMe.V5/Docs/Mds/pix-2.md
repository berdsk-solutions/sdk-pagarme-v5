# Pix

Para criar um [pedido](https://docs.pagar.me/v5/reference#criar-pedido-2) com **Pix**, devemos incluir o objeto `pix`
dentro do nÃ³ `payment`, assim como a propriedade `"payment_method": "pix"`. O objeto `pix` contÃ©m as seguintes
propriedades:

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
        `expires_in`
      </td>

      <td style={{ textAlign: "left" }}>
        **integer**
      </td>

      <td style={{ textAlign: "left" }}>
        * Data de expiraÃ§Ã£o do Pix em segundos\_.\
          (**MandatÃ³rio**).
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `expires_at`
      </td>

      <td style={{ textAlign: "left" }}>
        **datetime**
      </td>

      <td style={{ textAlign: "left" }}>
        * Data de expiraÃ§Ã£o do Pix\_.\
          (**Opcional | MandatÃ³rio caso nÃ£o enviado o expires\_in**) [Formato: YYYY-MM-DDThh:mm:ss](UTC)\
          Prazo mÃ¡ximo para expiraÃ§Ã£o de um QRCode Pix Ã© de 10 anos.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `additional_information`
      </td>

      <td style={{ textAlign: "left" }}>
        **Array of objects**
      </td>

      <td style={{ textAlign: "left" }}>
        * Objeto chave/valor utilizado para adicionar informações sobre o pagamento. Esses dados serÃ£o visÃ­veis para o consumidor na hora do pagamento\_.
      </td>
    </tr>

  </tbody>
</Table>

> ðŸ“˜ Bancos aceitos para transações de PIX
>
> O meio de pagamento PIX sÃ³ estÃ¡ disponÃ­vel para contas configuradas com um gateway especÃ­fico chamado Pagar.me .

> ðŸ“˜ Estorno de transações
>
> Para realizar o estorno de transações com pix Ã© necessÃ¡rio enviar uma requisiÃ§Ã£o de cancelamento de cobranÃ§a
> informando o id da cobranÃ§a que deve ser cancelada.

> ðŸ“˜ Pix com Split
>
> Para os clientes com afiliaÃ§Ã£o Pagar.me, Ã© possÃ­vel criar pedidos e cobranÃ§as com o meio de pagamento Pix incluindo a
> funcionalidade de Split.

```json Request Pix  (Pedido)
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
        "email": "avengerstark@ligadajustica.com.br",
        "type": "individual",
        "document": "01234567890",
        "phones": {
            "home_phone": {
                "country_code": "55",
                "number": "22180513",
                "area_code": "21"
            }
        }
    },
    "payments": [
        {
            "payment_method": "pix",
            "pix": {
                "expires_in": "52134613",
                "additional_information": [
                    {
                        "name": "Quantidade",
                        "value": "2"
                    }
                ]
            }
        }
    ]
}
```

```json Request Pix (Split)
{
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
        "email": "avengerstark@ligadajustica.com.br",
        "type": "individual",
        "document": "01234567890",
        "phones": {
            "home_phone": {
                "country_code": "55",
                "number": "22180513",
                "area_code": "21"
            }
        }
    },
    "payments": [
        {
            "payment_method": "pix",
            "pix": {
                "expires_in": "52134613",
                "additional_information": [
                    {
                        "name": "Quantidade",
                        "value": "2"
                    }
                ]
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
```

```json Response Pix (Pedido)
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
      "payment_method": "Pix",
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
        "transaction_type": "Pix",
        "gateway_id": "044581ea-67e8-4772-bd56-f10ade5499de",
        "amount": 3090,
        "status": "waiting_payment",
        "success": true,
        "qr_code": "00020101021226480019BR.COM.STONE.QRCODE0108A37F8712020912345678927820 014BR.GOV.BCB.PIX2560sandbox-qrcode.stone.com.br/api/v2/qr/sGY7FyVExavqkzFvkQu MXA28580010BR.COM.ELO0104516002151234567890000000308933BB1100401P520400 00530398654041.005802BR5911STONE TESTE6009SAO PAULO62600522sGY7FyVExavqkzFvkQuMXA50300017BR.GOV.BCB.BRCODE01051.0.0 80500010BR.COM.ELO01100915132023020200030201040613202363043BA1",
         "qr_code_url": "https://api.pagar.me/core/v1/transactions/tran_bZ0N3DjjUzTW68eq/qrcode.png",
         "additional_information": [
            {
             "name": "Quantidade",
             "value": "2"
            }
            ],
        "expires_at": "2020-09-20T00:00:00Z",
        "created_at": "2019-10-16T17:36:30Z",
        "updated_at": "2019-10-16T17:36:30Z",
        "gateway_response": {},
        "antifraud_response": {},
        "metadata": {}
      }
    }
  ],
  "checkouts": []
}
```

```json Response Pix (ApÃ³s o pagamento)
{
    "id": "ch_Qym35AmhvcZ5goJV",
    "code": "J3X6U97A6O",
    "gateway_id": "16232821",
    "amount": 350,
    "paid_amount": 350,
    "status": "paid",
    "currency": "BRL",
    "payment_method": "pix",
    "paid_at": "2021-12-01T17:55:27Z",
    "created_at": "2022-02-25T18:53:34Z",
    "updated_at": "2022-02-25T18:53:47Z",
    "customer": {
        "id": "cus_DZ5KolmUzSb6P7kE",
        "name": "Tony Stark",
        "email": "tonystark@pagar.me",
        "code": "MYRRR_ssCUSTOMER_001",
        "document": "1234567890",
        "document_type": "cpf",
        "type": "individual",
        "gender": "male",
        "delinquent": false,
        "address": {
            "id": "addr_o7EPa96T53UYYP2X",
            "line_1": "375, Av. General Justorr, Centro",
            "line_2": "8Âº anrrdar",
            "zip_code": "20421130",
            "city": "Rio 44de Janeiro",
            "state": "RJ",
            "country": "BR",
            "status": "active",
            "created_at": "2022-02-25T18:53:32Z",
            "updated_at": "2022-02-25T18:53:32Z"
        },
        "created_at": "2022-02-25T18:53:31Z",
        "updated_at": "2022-02-25T18:53:31Z",
        "birthdate": "1994-05-03T00:00:00Z",
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
        },
        "metadata": {
            "company": "Avsengers"
        }
    },
    "last_transaction": {
        "qr_code": "00020101021226840014br.gov.bcb.pix2562pix-h.stone.com.br/pix/v2/e6157b05-4987-4635-af58-968f165f386d52040000530398654043.505802BR5914EAD PLATAFORMA6014RIO DE JANEIRO62290525086dc8785e1f4ccaafed11fbd63049D7C",
        "qr_code_url": "http://localhost:22886/core/v1/transactions/tran_3Y6P751ASnhb7gje/qrcode?payment_method=pix",
        "expires_at": "2023-10-22T04:43:47Z",
        "end_to_end_id": "E12345678912",
        "payer": {
            "name": "Tony Stark",
            "document_type": "CPF",
            "document": "***.777.888-**",
            "bank_account": {
                "bank_name": "Pagarme",
                "ispb": "423452"
            }
        },
        "id": "tran_24zrDeoJf7FXLEp9",
        "transaction_type": "pix",
        "gateway_id": "16232821",
        "amount": 350,
        "status": "paid",
        "success": true,
        "created_at": "2022-02-25T18:53:47Z",
        "updated_at": "2022-02-25T18:53:47Z",
        "gateway_response": {},
        "antifraud_response": {},
        "metadata": {}
    }
}
```

> â—ï¸ IntegraÃ§Ã£o de Pagamento via Pix
>
> Para garantir a criaÃ§Ã£o de pagamento via Pix, Ã© necessÃ¡rio enviar o objeto `customer` contendo as seguintes
> informações:
>
> * `name`
> * `email`
> * `document`
> * `phones`
>
> Estas informações sÃ£o essenciais para o processamento bem-sucedido dos pagamentos.

## Status das transações de Pix (Transaction)

As transações de Pix podem possuir os seguintes status:

| Status            | DescriÃ§Ã£o            |
|:------------------|:---------------------|
| `waiting_payment` | Aguardando pagamento |
| `paid`            | Pago                 |
| `pending_refund`  | Aguardando estorno   |
| `refunded`        | Estornado            |
| `with_error`      | Com erro             |
| `failed`          | Falha                |