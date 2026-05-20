# SafetyPay

Para criar um [pedido](https://docs.pagar.me/v5/reference#criar-pedido-2) com **SafetyPay**, devemos incluir a
propriedade `"payment_method": "safetypay"` dentro do nÃ³ `payment`.

> ðŸš§ Funcionalidade disponÃ­vel apenas para clientes Gateway
>
> As funcionalidades apresentadas abaixo estÃ£o disponÃ­vel apenas para clientes gateway

```json Request SafetyPay (Pedido)
{
	"items": [{
			"amount": 1000,
			"description": "Chaveiro do Tesseract",
			"quantity": 1
		}
	],
	"customer": {
		"name": "Tony Stark",
		"email": "matrinho@mailinator.com",
		"type": "individual",
		"document": "12345678900",
		"phones": {
			"home_phone": {
				"country_code": "55",
				"area_code": "21",
				"number": "32659874"
			},
			"mobile_phone": {
				"country_code": "55",
				"area_code": "21",
				"number": "998563214"
			}
		}
	},
	"payments": [{
			"payment_method": "safetypay"
		}
	]
}
```

```json Response SafetyPay (Pedido)
{
	"id": "or_l02Adj6Ytgs5debP",
	"code": "4LJQINWC1Y",
	"amount": 1500,
	"currency": "BRL",
	"closed": true,
	"items": [{
			"id": "oi_NV2K6KOSxIDZ6Z0a",
			"description": "Chaveiro do Tesseract",
			"amount": 1000,
			"quantity": 1,
			"status": "active",
			"created_at": "2019-01-21T18:56:14Z",
			"updated_at": "2019-01-21T18:56:14Z",
			"order": {
				"id": "or_l02Adj6Ytgs5debP",
				"code": "4LJQINWC1Y",
				"amount": 1500,
				"closed": true,
				"created_at": "2019-01-21T18:56:14Z",
				"updated_at": "2019-01-21T18:56:14Z",
				"closed_at": "2019-01-21T18:56:14Z",
				"currency": "BRL",
				"status": "pending",
				"customer_id": "cus_rN18K4KIMKcYW2RV",
				"metadata": {
					"nfeio_issuance_enabled": "true",
					"charge_failed_cancellation_enabled": "true",
					"charge_cancellation_enabled": "false",
					"nfeio_cancellation_enabled": "true"
				},
				"items": [{
						"id": "oi_NV2K6KOSxIDZ6Z0a",
						"description": "Chaveiro do Tesseract",
						"amount": 1000,
						"quantity": 1,
						"status": "active"
					}, {
						"id": "oi_JRv3j71cyGUa90Pk",
						"description": "Chaveiro do Tesseract2",
						"amount": 500,
						"quantity": 1,
						"status": "active"
					}
				]
			}
		}
	],
	"customer": {
		"id": "cus_rN18K4KIMKcYW2RV",
		"name": "Tony Stark",
		"email": "matrinho@mailinator.com",
		"document": "12345678900",
		"type": "individual",
		"delinquent": false,
		"created_at": "2019-01-21T18:55:22Z",
		"updated_at": "2019-01-21T18:55:22Z",
		"phones": {
			"home_phone": {
				"country_code": "55",
				"number": "32659874",
				"area_code": "21"
			},
			"mobile_phone": {
				"country_code": "55",
				"number": "998563214",
				"area_code": "21"
			}
		}
	},
	"status": "pending",
	"created_at": "2019-01-21T18:56:14Z",
	"updated_at": "2019-01-21T18:56:14Z",
	"closed_at": "2019-01-21T18:56:14Z",
	"charges": [{
			"id": "ch_JpXR7Q8Fg4u4YaeD",
			"code": "4LJQINWC1Y",
			"amount": 1500,
			"status": "pending",
			"currency": "BRL",
			"payment_method": "safetypay",
			"created_at": "2019-01-21T18:56:14Z",
			"updated_at": "2019-01-21T18:56:14Z",
			"customer": {
				"id": "cus_rN18K4KIMKcYW2RV",
				"name": "Tony Stark",
				"email": "matrinho@mailinator.com",
				"document": "12345678900",
				"type": "individual",
				"delinquent": false,
				"created_at": "2019-01-21T18:55:22Z",
				"updated_at": "2019-01-21T18:55:22Z",
				"phones": {
					"home_phone": {
						"country_code": "55",
						"number": "32659874",
						"area_code": "21"
					},
					"mobile_phone": {
						"country_code": "55",
						"number": "998563214",
						"area_code": "21"
					}
				}
			},
			"last_transaction": {
				"url": "https://sandbox-gateway.safetypay.com/Express4/Checkout/index?TokenID=6c60d19c-64bf-4a81-96d1-ad46bdba9764",
				"safetypay_tid": "e09f39ad33fc4c3b",
				"id": "tran_2vrxYNnhZpSQazQ5",
				"transaction_type": "safetypay",
				"gateway_id": "e09f39ad-33fc-4c3b-a88a-103df99c3614",
				"amount": 1490,
				"status": "pending",
				"success": true,
				"created_at": "2017-07-05T16:59:30Z",
				"updated_at": "2017-07-05T16:59:30Z",
				"gateway_response": {
					"code": "201"
				}
			}
		}
	]
}
```

## Status das transações de SafetyPay (Transaction)

As transações de SafatyPay podem possuir os seguintes status:

<Table align={["left","left"]}>
  <thead>
    <tr>
      <th>
        Status
      </th>

      <th>
        DescriÃ§Ã£o
      </th>
    </tr>

  </thead>

  <tbody>
    <tr>
      <td>
        `pending`
      </td>

      <td>
        Pendente
      </td>
    </tr>

    <tr>
      <td>
        `paid`
      </td>

      <td>
        Paga
      </td>
    </tr>

    <tr>
      <td>
        `overpaid`
      </td>

      <td>
        Paga a maior
      </td>
    </tr>

    <tr>
      <td>
        `underpaid`
      </td>

      <td>
        Paga a menor
      </td>
    </tr>

    <tr>
      <td>
        `with_error`
      </td>

      <td>
        Com erro
      </td>
    </tr>

    <tr>
      <td>
        `not_paid`
      </td>

      <td>
        NÃ£o paga
      </td>
    </tr>

    <tr>
      <td>
        `failed`
      </td>

      <td>
        Falha
      </td>
    </tr>

  </tbody>
</Table>