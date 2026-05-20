# CartÃ£o private label

Para criar um [pedido](https://docs.pagar.me/v5/reference#criar-pedido-2) com **cartÃ£o private label**, devemos incluir
o objeto `private_label` dentro do nÃ³ `payment`, assim como a propriedade `"payment_method": "private_label"`. O objeto
`private_label` contÃªm os seguintes atributos:

> â—ï¸ Produto Temporariamente Suspenso Para Novas Habilitações

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
        `installments`
      </td>

      <td style={{ textAlign: "left" }}>
        **integer**
      </td>

      <td style={{ textAlign: "left" }}>
        * Quantidade de parcelas\_. Valor padrÃ£o: `1`.
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
        * Texto exibido na fatura do cartÃ£o\_. Max: 22 caracteres.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `capture`
      </td>

      <td style={{ textAlign: "left" }}>
        **boolean**
      </td>

      <td style={{ textAlign: "left" }}>
        * Indica se o pagamento deve ser processado imediatamente\_. Caso seja `false` o pagamento deverÃ¡ ser confirmado posteriormente. Valor padrÃ£o: `true`.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `card`, `**card_id**` ou `card_token`
      </td>

      <td style={{ textAlign: "left" }}>
        **object**
      </td>

      <td style={{ textAlign: "left" }}>
        * CartÃ£o private label\_.\
          `card_id` Ã© o identificador do cartÃ£o de um cliente.\
          `card_token` Ã© o token do cartÃ£o gerado pelo checkout transparente. [Saiba mais sobre cartÃµes](https://docs.pagar.me/v5/reference#pagarme-js).
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
        * Objeto chave/valor utilizado para armazenar informações adicionais sobre o pagamento\_.
      </td>
    </tr>

  </tbody>
</Table>

```json Request cartÃ£o private label (Pedido)
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
        "email": "avengerstark@ligadajustica.com.br"
    },
    "payments": [
        {
            "payment_method": "private_label",
            "private_label": {
                "capture": true,
                "installments": 1,
                "statement_descriptor": "AVENGERS",
                "card": {
                    "number": "4716806755265342",
                    "holder_name": "Tony Stark",
                    "label": "Private Label",
                    "exp_month": 1,
                    "exp_year": 20,
                    "cvv": "151"
                }
            },
            "metadata": {
                "plan_id": "003000"
            }
        }
    ],
}
```

```json Response cartÃ£o private label (Pedido)
{
    "id": "or_57oxkMntecE1P6JO",
    "code": "PGW5F69IX6",
    "amount": 2990,
    "currency": "BRL",
    "closed": true,
    "items": [
        {
            "id": "oi_DZlmrdXfXQcmr5kO",
            "description": "Chaveiro do Tesseract",
            "amount": 2990,
            "quantity": 1,
            "status": "active",
            "created_at": "2019-01-21T18:37:48Z",
            "updated_at": "2019-01-21T18:37:48Z",
            "order": {
                "id": "or_57oxkMntecE1P6JO",
                "code": "PGW5F69IX6",
                "amount": 2990,
                "closed": true,
                "created_at": "2019-01-21T18:37:48Z",
                "updated_at": "2019-01-21T18:37:48Z",
                "closed_at": "2019-01-21T18:37:48Z",
                "currency": "BRL",
                "status": "paid",
                "customer_id": "cus_n3bqEzdsZUmNA7Qp",
                "items": [
                    {
                        "id": "oi_DZlmrdXfXQcmr5kO",
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
        "created_at": "2019-01-21T18:36:30Z",
        "updated_at": "2019-01-21T18:36:30Z",
        "phones": {}
    },
    "status": "paid",
    "created_at": "2019-01-21T18:37:48Z",
    "updated_at": "2019-01-21T18:37:48Z",
    "closed_at": "2019-01-21T18:37:48Z",
    "charges": [
        {
            "id": "ch_PNbX8jDIPuL1p5nM",
            "code": "PGW5F69IX6",
            "amount": 2990,
            "paid_amount": 2990,
            "status": "paid",
            "currency": "BRL",
            "payment_method": "private_label",
            "paid_at": "2019-01-21T18:37:48Z",
            "created_at": "2019-01-21T18:37:48Z",
            "updated_at": "2019-01-21T18:37:48Z",
            "customer": {
                "id": "cus_n3bqEzdsZUmNA7Qp",
                "name": "Tony Stark",
                "email": "avengerstark@ligadajustica.com.br",
                "delinquent": false,
                "created_at": "2019-01-21T18:36:30Z",
                "updated_at": "2019-01-21T18:36:30Z",
                "phones": {}
            },
            "last_transaction": {
                "id": "tran_G1byLaJUXHm5Eg4R",
                "transaction_type": "private_label",
                "gateway_id": "82c0acb3-75b0-48b8-a3ac-0e51c4b3744c",
                "amount": 2990,
                "status": "captured",
                "success": true,
                "installments": 1,
                "statement_descriptor": "AVENGERS",
                "acquirer_tid": "a4cf3de1-beb2-4724-822d-ac7ad14fa306",
                "acquirer_nsu": "a4cf3de1-beb2-4724-822d-ac7ad14fa306",
                "acquirer_auth_code": "903",
                "acquirer_message": "TransaÃ§Ã£o capturada com sucesso",
                "acquirer_return_code": "00",
                "operation_type": "auth_and_capture",
                "card": {
                    "id": "card_apxQeXJsV2fGVwPL",
                    "first_six_digits": "400000",
                    "last_four_digits": "0010",
                    "brand": "Visa",
                    "holder_name": "Tony Stark",
                    "exp_month": 1,
                    "exp_year": 2030,
                    "status": "active",
                    "type": "credit",
                    "private_label" true,
                    "created_at": "2019-01-21T18:37:48Z",
                    "updated_at": "2019-01-21T18:37:48Z",
                    "billing_address": {
                        "zip_code": "90265",
                        "city": "Malibu",
                        "state": "CA",
                        "country": "US",
                        "line_1": "10880, Malibu Point, Malibu Central"
                    }
                },
                "created_at": "2019-01-21T18:37:48Z",
                "updated_at": "2019-01-21T18:37:48Z",
                "gateway_response": {
                    "code": "200",
                    "errors": []
                }
            }
        }
    ],
    "checkouts": []
}
```

## Status da transaÃ§Ã£o de cartÃ£o private label (Transaction)

As transações de CartÃ£o Private Label podem possuir os seguintes status dependendo da regra de negÃ³cio definida pela
processadora do cartÃ£o:

| Status                       | DescriÃ§Ã£o                      |
|:-----------------------------|:-------------------------------|
| `authorized_pending_capture` | Autorizada pendente de captura |
| `not_authorized`             | NÃ£o autorizada                 |
| `captured`                   | Capturada                      |
| `partial_capture`            | Capturada parcialmente         |
| `waiting_capture`            | Aguardando captura             |
| `refunded`                   | Estornada                      |
| `voided`                     | Cancelada                      |
| `partial_refunded`           | Estornada parcialmente         |
| `partial_void`               | Cancelada parcialmente         |
| `error_on_voiding`           | Erro no cancelamento           |
| `error_on_refunding`         | Erro no estorno                |
| `waiting_cancellation`       | Aguardando cancelamento        |
| `with_error`                 | Com erro                       |
| `failed`                     | Falha                          |