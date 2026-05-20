# Google Payâ„¢

Para criar um [pedido](https://docs.pagar.me/v5/reference#criar-pedido-2) com **Google Pay**!

## Contexto

A API Google Pay retorna as formas de pagamento em um payload `PaymentMethodToken` assinado e criptografado. As
informações retornadas sÃ£o cartÃµes com PAN ou tokenizados que tÃªm criptogramas e PANs de dispositivos.

Para mais informaÃ§Ãµes sobre os campos do token, acesse
a [documentaÃ§Ã£o Google](https://developers.google.com/pay/api/web/guides/resources/payment-data-cryptography?hl=pt-br#payment-method-token-structure).

Veja a seguir uma resposta do token da forma de pagamento no JSON:

```json Token da forma de pagamento (JSON)
{
  "protocolVersion":"ECv2",
  "signature":"MEQCIH6Q4OwQ0jAceFEkGF0JID6sJNXxOEi4r+mA7biRxqBQAiAondqoUpU/bdsrAOpZIsrHQS9nwiiNwOrr24RyPeHA0Q\u003d\u003d",
  "intermediateSigningKey":{
    "signedKey": "{\"keyExpiration\":\"1542323393147\",\"keyValue\":\"MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAE/1+3HBVSbdv+j7NaArdgMyoSAM43yRydzqdg1TxodSzA96Dj4Mc1EiKroxxunavVIvdxGnJeFViTzFvzFRxyCw\\u003d\\u003d\"}",
    "signatures": ["MEYCIQCO2EIi48s8VTH+ilMEpoXLFfkxAwHjfPSCVED/QDSHmQIhALLJmrUlNAY8hDQRV/y1iKZGsWpeNmIP+z+tCQHQxP0v"]
  },
  "signedMessage":"{\"tag\":\"jpGz1F1Bcoi/fCNxI9n7Qrsw7i7KHrGtTf3NrRclt+U\\u003d\",\"ephemeralPublicKey\":\"BJatyFvFPPD21l8/uLP46Ta1hsKHndf8Z+tAgk+DEPQgYTkhHy19cF3h/bXs0tWTmZtnNm+vlVrKbRU9K8+7cZs\\u003d\",\"encryptedMessage\":\"mKOoXwi8OavZ\"}"
}
```

## Fazendo o pedido

A autorizaÃ§Ã£o com o token do Google Pay acontece da mesma maneira que de um cartÃ£o, fornecendo os dados do token
recebido pelo Google.

Para criar uma cobranÃ§a ou um pedido com Google Pay, devemos incluir o objeto `credit_card` dentro do nÃ³ `payments`,
assim como a propriedade `"payment_method": "credit_card"`. AlÃ©m disso, o objeto `credit_card` deve conter os atributos
do `payload`. O objeto `payload `possui os seguintes atributos:

| Atributos    | Tipo       | DescriÃ§Ã£o                                                                    |
|:-------------|:-----------|:-----------------------------------------------------------------------------|
| `type`       | **string** | *Determina o tipo de token. Para Google Pay deve-se enviar`**google_pay**`.* |
| `google_pay` | **object** | *Campos a serem enviados para pagamento com Google Pay*                      |

O objeto `google_pay` possui os seguintes atributos:

| Atributos                  | Tipo       | DescriÃ§Ã£o                                                                                                                                                                                                                                                                                                                                            |
|:---------------------------|:-----------|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `data`                     | **string** | *Dados de pagamento criptografados.  Corresponde ao encryptedMessage do token Google.*                                                                                                                                                                                                                                                               |
| `signature`                | **string** | *Assinatura dos dados de pagamento. Verifica se a origem da mensagem Ã© o Google. Corresponde ao`signature` do token Google.*                                                                                                                                                                                                                         |
| `intermediate_signing_key` | **object** | *Objeto JSON serializado codificado em UTF-8 que contÃ©m os seguintes valores:*                                                                                                                                                                                                                                                                       |
| `signed_key`               | **string** | *Uma mensagem codificada em Base64 com a descriÃ§Ã£o de pagamento da chave.*                                                                                                                                                                                                                                                                           |
| `signatures`               | **string** | *Verifica se a origem da chave de assinatura intermediÃ¡ria Ã© o Google. Ã‰ codificada em Base64 e criada usando o ECDSA.*                                                                                                                                                                                                                              |
| `version`                  | **string** | *InformaÃ§Ã£o sobre a versÃ£o do token.* Ãšnico valor aceito Ã© **EC\_v2**                                                                                                                                                                                                                                                                                |
| `signed_message`           | **object** | *Objeto JSON serializado codificado em UTF-8 que contÃ©m os seguintes valores:*                                                                                                                                                                                                                                                                       |
| `encryptedMessage`         | **string** | *Uma mensagem criptografada e codificada em Base64 que contÃ©m informaÃ§Ãµes de pagamento e outros[campos de seguranÃ§a](https://developers.google.com/pay/api/web/guides/resources/payment-data-cryptography?hl=pt-br#encrypted-message).*                                                                                                              |
| `ephemeralPublicKey`       | **string** | *Uma chave pÃºblica temporÃ¡ria e codificada em Base64 que estÃ¡ associada Ã  chave privada para criptografar a mensagem no formato de ponto descompactado. Para mais informaÃ§Ãµes, consulte[Formato de chave pÃºblica de criptografia](https://developers.google.com/pay/api/web/guides/resources/payment-data-cryptography?hl=pt-br#public-key-format).* |
| `tag`                      | **string** | *Um MAC codificado em Base64 de`encryptedMessage`.*                                                                                                                                                                                                                                                                                                  |
| `merchant_identifier`      | **string** | *Identificador da loja no Pagar.me. O mesmo identificador que foi configurado no aplicativo para criar o token de pagamento.*                                                                                                                                                                                                                        |

> ðŸš§ AtenÃ§Ã£o!
>
> Todos os campos do objeto `google_pay` sÃ£o obrigatÃ³rios caso a transaÃ§Ã£o seja feita por esse meio de pagamento!
>
> **NÃ£o** manipule os campos!
>
> Observe tambÃ©m a documentaÃ§Ã£o de [criaÃ§Ã£o de pedido](https://docs.pagar.me/reference/criar-pedido-2) para conferir o
> contrato completo e os campos obrigatÃ³rios para seu modelo de negÃ³cio.

```json Request Google Pay (CriaÃ§Ã£o de pedido)
{
	"items": [
		{
			"amount": 105173,
			"description": "Chaveiro do Tesseract",
			"quantity": 1
		}
	],
	"customer": {
		"name": "Tony Stark",
		"email": "tstark@avengers.com"
	},
	"payments": [
		{
			"amount": 105173,
			"payment_method": "credit_card",
			"credit_card": {
				"statement_descriptor": "AVENGERS",
				"payload": {
					"type": "google_pay",
					"google_pay": {
						"signature": "MEUCIQD+nIwKFkBK9sd4aB4EOC/ADOhn1DUjc3zQJDVQE4mA3AIgLjljobb3YcclsxEqVRHUzW9xLvSs0yuatzkR8E0WAiM=",
						"intermediate_signing_key": {
							"signed_key": "{\"keyValue\":\"MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAEZX978i9NWBAONSBr3WjGF5VS4TenlDVRQrgKMtSfuR5dSjf3DXotumaRrR7Humeg3dt95S7fkjc2AeMkww9HPA\\u003d\\u003d\",\"keyExpiration\":\"1691085271820\"}",
							"signatures": [
								"MEYCIQCfLBI0d2EpAvEcEHeW7eX4E5JLTHxxs+iNgy470w5fPAIhAMWBaIUzaSwCgz1feUl86HLZ1oXYzBhkxa3t1MCSfTYl"
							]
						},
						"version": "ECv2",
						"signed_message": "{\"encryptedMessage\":\"fRPuSGxG6IUsZqXO5nnAKASVSxQu9dG2G6+0IQbP6mBehIzJboFnKJeozIu4t5rQaKnyL08OA5VX96m4MBewuM/YIubKF87qtjkIS7t/3hYtTHxGj01Z8TWSljeMyApCdaDBsvgo1/zRe4n7WSsm8ka4MpNEaBYz+BWcc0AMQb2ixt82TCrlcvv5NBe2jezdiN55Oo10eW6JZdb1e7Ss/zWVPOQe6iWyeq4fwMjuAMBwcNKF4ZPz5PD1g21J70f1DBSV1zfyOKotgSndZFqBEEfq7i2Lvf6Ps7a0u+DtHBBZU1v5j0WiQqeIVdcY1lSSajSboQg/F2NfREPwhk4psP4e4Sj71VGZ1pkoEgIIs9xAI7y5BlGuW+S+7QUhe6bsrBL2fA2jfJXGxn2hxU2vZ77dZ6xXlTetOtaTQxEU2yD7JTw5mKI9pL3oq6lkVMSKx/L8nJnQFcSCjCdM1Q15f/UgxXzA4w9lMYJlIO3HRh/y7KdQYYoTe2N7CsrSZcmm08oSsAe1kzHHLMGA7VNNxNkyqH0DzEv8ThS0bBb2HWxN2FVZbrFIJkmJa0uQKmwoUPYQ/Ri2/2TmnsG0\",\"ephemeralPublicKey\":\"BEVFEhmx/XPsGjuV/+/i8pAGafhiiHkdOzFcOGl8SeGmLVD3TcPSn52KdDqGYO42MntVk4bjdRCjJrpOqkxGo44\\u003d\",\"tag\":\"9eVSs9PLlZX8hyKAvF5lRZPdy9YtREhzJv+fzqfynXU\\u003d\"}",
            "merchant_identifier": "acc_xyzadasdw",
					}
				}
			}
		}
	]
}
```

```json Response Google Pay (CriaÃ§Ã£o de pedido)
{
    "id": "or_38KZgonh9EcrPZEQ",
    "code": "2ZRLTGNI7Y",
    "amount": 105173,
    "currency": "BRL",
    "closed": true,
    "items": [
        {
            "id": "oi_5O7YMOaU8vSjNmDr",
            "type": "product",
            "description": "Chaveiro do Tesseract",
            "amount": 105173,
            "quantity": 1,
            "status": "active",
            "created_at": "2023-08-08T13:53:01Z",
            "updated_at": "2023-08-08T13:53:01Z"
        }
    ],
    "customer": {
        "id": "cus_zyMgpnmuQvImBErW",
        "name": "Tony Stark",
        "email": "tstark@avengers.com",
        "delinquent": false,
        "created_at": "2023-08-04T17:58:57Z",
        "updated_at": "2023-08-04T17:58:57Z",
        "phones": {}
    },
    "status": "paid",
    "created_at": "2023-08-08T13:53:01Z",
    "updated_at": "2023-08-08T13:53:05Z",
    "closed_at": "2023-08-08T13:53:01Z",
    "charges": [
        {
            "id": "ch_g3kN6XWIAZUVY9Xz",
            "code": "2ZRLTGNI7Y",
            "amount": 105173,
            "status": "paid",
            "currency": "BRL",
            "payment_method": "credit_card",
            "created_at": "2023-08-08T13:53:02Z",
            "updated_at": "2023-08-08T13:53:05Z",
            "customer": {
                "id": "cus_zyMgpnmuQvImBErW",
                "name": "Tony Stark",
                "email": "tstark@avengers.com",
                "delinquent": false,
                "created_at": "2023-08-04T17:58:57Z",
                "updated_at": "2023-08-04T17:58:57Z",
                "phones": {}
            },
            "last_transaction": {
                "id": "tran_aP9wR6jt3tbKRgGJ",
                "transaction_type": "credit_card",
                "amount": 105173,
                "status": "paid",
                "success": false,
                "operation_type": "auth_and_capture",
                "created_at": "2023-08-08T13:53:05Z",
                "updated_at": "2023-08-08T13:53:05Z",
                "gateway_response": {
                    "code": "200"
                },
                "antifraud_response": {},
                "metadata": {}
            }
        }
    ],
    "checkouts": []
}
```