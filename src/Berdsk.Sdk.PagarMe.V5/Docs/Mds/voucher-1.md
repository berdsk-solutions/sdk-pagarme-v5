# Voucher

Para criar um [pedido](https://docs.pagar.me/v5/reference#criar-pedido-2) com **voucher**, devemos incluir o objeto
`voucher` dentro do nÃ³ `payment`, assim como a propriedade `"payment_method": "voucher"`. O objeto `voucher` contÃ©m as
seguintes propriedades:

> ðŸš§ Funcionalidade disponÃ­vel apenas para clientes Gateway
>
> As funcionalidades apresentadas abaixo estÃ£o disponÃ­vel apenas para clientes gateway.

> ðŸš§ Bandeiras
>
> Possibilitamos a integraÃ§Ã£o com as principais bandeiras do mercado: **VR benefÃ­cios**, **Pluxee** e **Ticket**.
>
> **Alelo:** Devido ao tÃ©rmino do contrato entre a Cielo e a Alelo, nÃ£o Ã© possÃ­vel realizar novas integrações com essa
> bandeira de voucher.

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
        * Texto exibido na fatura do cartÃ£o\_. Max: 22 caracteres.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `card`, `card_id` ou `card_token`
      </td>

      <td style={{ textAlign: "left" }}>
        **object**
      </td>

      <td style={{ textAlign: "left" }}>
        * CartÃ£o de crÃ©dito\_.\
          `card_id` Ã© o identificador do cartÃ£o de um cliente.\
          `***card_token***` Ã© o token do cartÃ£o gerado pelo checkout transparente. [Saiba mais sobre cartÃµes](https://docs.pagar.me/v5/reference#pagarme-js).
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `card.holder_document`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        * NÃºmero do documento do portador do cartÃ£o\_. Este campo deverÃ¡ ser enviado dentro do objeto `card` e Ã© **obrigatÃ³rio** para voucher.
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

  </tbody>
</Table>

```json Request voucher (Pedido)
{
	"items": [{
			"amount": 2990,
			"description": "Chaveiro do Tesseract",
			"quantity": 1
		}
	],
	"customer": {
		"name": "Tony Stark",
		"email": "avengerstark@ligadajustica.com.br"
	},
	"payments": [{
			"payment_method": "voucher",
			"voucher": {
				"statement_descriptor": "AVENGERS",
				"card": {
					"number": "4000000000000010",
					"holder_name": "Tony Stark",
					"holder_document": "93095135270",
					"exp_month": 1,
					"exp_year": 30,
					"cvv": "351",
					"billing_address": {
						"line_1": "10880, Malibu Point, Malibu Central",
						"zip_code": "90265",
						"city": "Malibu",
						"state": "CA",
						"country": "US"
					}
				}
			}
		}
	]
}
```

```json Response voucher (Pedido)
{
	"id": "or_rW4pw5yck1fwdD7O",
	"code": "0WX7TE6BJ6",
	"amount": 2990,
	"currency": "BRL",
	"closed": true,
	"items": [{
			"id": "oi_D3XEBzJuE9hABb1a",
			"description": "Chaveiro do Tesseract",
			"amount": 2990,
			"quantity": 1,
			"status": "active",
			"created_at": "2019-01-22T14:20:18Z",
			"updated_at": "2019-01-22T14:20:18Z",
			"order": {
				"id": "or_rW4pw5yck1fwdD7O",
				"code": "0WX7TE6BJ6",
				"amount": 2990,
				"closed": true,
				"created_at": "2019-01-22T14:20:18Z",
				"updated_at": "2019-01-22T14:20:19Z",
				"closed_at": "2019-01-22T14:20:18Z",
				"currency": "BRL",
				"status": "paid",
				"customer_id": "cus_n3bqEzdsZUmNA7Qp",
				"items": [{
						"id": "oi_D3XEBzJuE9hABb1a",
						"description": "Chaveiro do Tesseract",
						"amount": 2990,
						"quantity": 1,
						"status": "active"
					}
				]
			}
		}
	],
	"customer": {
		"id": "cus_n3bqEzdsZUmNA7Qp",
		"name": "Tony Stark",
		"email": "avengerstark@ligadajustica.com.br",
		"delinquent": false,
		"address": {
			"id": "addr_yEd4rG0HJNupdX2m",
			"line_1": "375, Av. General Justo, Centro",
			"line_2": "8Âº andar",
			"zip_code": "20021130",
			"city": "Rio de Janeiro",
			"state": "RJ",
			"country": "BR",
			"status": "active",
			"created_at": "2019-01-21T18:44:17Z",
			"updated_at": "2019-01-21T18:44:17Z",
			"metadata": {
				"id": "my_address_id"
			}
		},
		"created_at": "2019-01-21T18:36:30Z",
		"updated_at": "2019-01-21T18:44:17Z",
		"phones": {}
	},
	"status": "paid",
	"created_at": "2019-01-22T14:20:18Z",
	"updated_at": "2019-01-22T14:20:19Z",
	"closed_at": "2019-01-22T14:20:18Z",
	"charges": [{
			"id": "ch_dZWwGNQIgCgXyO14",
			"code": "0WX7TE6BJ6",
			"amount": 2990,
			"paid_amount": 2990,
			"status": "paid",
			"currency": "BRL",
			"payment_method": "voucher",
			"paid_at": "2019-01-22T14:20:19Z",
			"created_at": "2019-01-22T14:20:18Z",
			"updated_at": "2019-01-22T14:20:18Z",
			"customer": {
				"id": "cus_n3bqEzdsZUmNA7Qp",
				"name": "Tony Stark",
				"email": "avengerstark@ligadajustica.com.br",
				"delinquent": false,
				"address": {
					"id": "addr_yEd4rG0HJNupdX2m",
					"line_1": "375, Av. General Justo, Centro",
					"line_2": "8Âº andar",
					"zip_code": "20021130",
					"city": "Rio de Janeiro",
					"state": "RJ",
					"country": "BR",
					"status": "active",
					"created_at": "2019-01-21T18:44:17Z",
					"updated_at": "2019-01-21T18:44:17Z",
					"metadata": {
						"id": "my_address_id"
					}
				},
				"created_at": "2019-01-21T18:36:30Z",
				"updated_at": "2019-01-21T18:44:17Z",
				"phones": {}
			},
			"last_transaction": {
				"id": "tran_x30Ml3TVkUan61vl",
				"transaction_type": "voucher",
				"gateway_id": "abe20e9d-fc1f-4458-86c0-b5e21a172ed8",
				"amount": 2990,
				"status": "captured",
				"success": true,
				"statement_descriptor": "AVENGERS",
				"acquirer_tid": "f55f99cd-fdc0-4271-a8f8-5be39c496fce",
				"acquirer_nsu": "f55f99cd-fdc0-4271-a8f8-5be39c496fce",
				"acquirer_message": "TransaÃ§Ã£o capturada com sucesso",
				"acquirer_return_code": "00",
				"operation_type": "auth_and_capture",
				"card": {
					"id": "card_apxQeXJsV2fGVwPL",
					"first_six_digits": "400000",
					"last_four_digits": "0010",
					"brand": "Visa",
					"holder_name": "Tony Stark",
					"holder_document": "93095135270",
					"exp_month": 1,
					"exp_year": 2030,
					"status": "active",
					"type": "credit",
					"created_at": "2019-01-21T18:37:48Z",
					"updated_at": "2019-01-22T14:20:18Z",
					"billing_address": {
						"zip_code": "90265",
						"city": "Malibu",
						"state": "CA",
						"country": "US",
						"line_1": "10880, Malibu Point, Malibu Central"
					},
					"customer": {
						"id": "cus_n3bqEzdsZUmNA7Qp",
						"name": "Tony Stark",
						"email": "avengerstark@ligadajustica.com.br",
						"delinquent": false,
						"address": {
							"id": "addr_yEd4rG0HJNupdX2m",
							"line_1": "375, Av. General Justo, Centro",
							"line_2": "8Âº andar",
							"zip_code": "20021130",
							"city": "Rio de Janeiro",
							"state": "RJ",
							"country": "BR",
							"status": "active",
							"created_at": "2019-01-21T18:44:17Z",
							"updated_at": "2019-01-21T18:44:17Z",
							"metadata": {
								"id": "my_address_id"
							}
						},
						"created_at": "2019-01-21T18:36:30Z",
						"updated_at": "2019-01-21T18:44:17Z",
						"phones": {}
					}
				},
				"created_at": "2019-01-22T14:20:19Z",
				"updated_at": "2019-01-22T14:20:19Z",
				"gateway_response": {
					"code": "200"
				}
			}
		}
	],
	"checkouts": []
}
```

## Status das transações de Voucher (Transaction)

As transações de Voucher podem possuir os seguintes status:

| Status                       | DescriÃ§Ã£o                      |
|:-----------------------------|:-------------------------------|
| `authorized_pending_capture` | Autorizada pendente de captura |
| `not_authorized`             | NÃ£o autorizada                 |
| `captured`                   | Capturada                      |
| `partial_capture`            | Capturada parcialmente         |
| `refunded`                   | Estornada                      |
| `voided`                     | Cancelada                      |
| `partial_refunded`           | Estornada parcialmente         |
| `partial_void`               | Cancelada parcialemente        |
| `error_on_voiding`           | Erro no cancelamento           |
| `error_on_refunding`         | Erro no estorno                |
| `waiting_cancellation`       | Aguardando cancelamento        |
| `with_error`                 | Com erro                       |
| `failed`                     | Falha                          |