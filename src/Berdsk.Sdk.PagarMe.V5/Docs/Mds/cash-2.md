# Cash

Para criar um [pedido](https://docs.pagar.me/v5/reference#criar-pedido-2) com **cash**, devemos incluir o objeto `cash`
dentro do nÃ³ `payment`, assim como a propriedade `"payment_method": "cash"`. O objeto `cash` contÃ©m as seguintes
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
        `description`
      </td>

      <td style={{ textAlign: "left" }}>
        **string**
      </td>

      <td style={{ textAlign: "left" }}>
        * DescriÃ§Ã£o do pagamento\_. Max: 256 caracteres.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `confirm`
      </td>

      <td style={{ textAlign: "left" }}>
        **boolean**
      </td>

      <td style={{ textAlign: "left" }}>
        * Indica se o pagamento serÃ¡ confirmado no ato da criaÃ§Ã£o da cobranÃ§a ou se deve ser confirmado posteriormente\_.
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

```json Request cash (Pedido)
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
			"payment_method": "cash",
			"cash": {
				"description": "Teste",
				"confirm": false
			}
		}
	]
}
```

```json Response cash (Pedido)
{
    "id": "ch_1GWo9VyiBJs4AOBy",
    "code": "6OY1HPSX3L",
    "amount": 1490,
    "paid_amount": 1490,
    "status": "pending",
    "currency": "BRL",
    "payment_method": "cash",
    "created_at": "2018-06-28T18:58:03Z",
    "updated_at": "2018-06-28T18:58:03Z",
    "customer": {
        "id": "cus_qGW6pRYCrU5qwPm2",
        "name": "Tony Stark",
        "email": "tony.stark@avengers.com",
        "delinquent": false,
        "created_at": "2018-06-28T18:58:03Z",
        "updated_at": "2018-06-28T18:58:03Z",
        "phones": {}
    },
    "last_transaction": {
        "description": "Teste",
        "id": "tran_4rKBYmDT9TxWyJgn",
        "transaction_type": "cash",
        "amount": 1490,
        "status": "pending",
        "success": true,
        "created_at": "2018-06-28T18:58:05Z",
        "updated_at": "2018-06-28T18:58:05Z",
        "gateway_response": {}
    },
    "metadata": {
        "code": "123"
    }
}
```

## Status das transações de Cash (Transaction)

As transações de Cash podem pussuir os seguintes status:

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

  </tbody>
</Table>