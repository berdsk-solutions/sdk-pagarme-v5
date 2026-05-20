# Erros

HTTP Status Codes

A nossa API valida cada um dos campos enviados na requisiÃ§Ã£o antes de prosseguir com a criaÃ§Ã£o, consulta ou
gerenciamento dos pedidos, transações e recursos.

Utilizamos os cÃ³digos de resposta convencionais do HTTP para indicar o sucesso ou a falha de uma requisiÃ§Ã£o. Sendo
assim, cÃ³digos **2xx** indicam sucesso, **4xx** indicam erros por algum dado informado incorretamente (por exemplo,
algum campo obrigatÃ³rio nÃ£o enviado ou um cartÃ£o sem data de validade) e **5xx** indicando erros nos servidores do
Pagar.me.

**Tabela dos HTTP Status Code:**

| CÃ³digo | Status                | DefiniÃ§Ã£o                                                                        |
|:-------|:----------------------|:---------------------------------------------------------------------------------|
| `200`  | OK                    | Sucesso                                                                          |
| `400`  | Bad Request           | RequisiÃ§Ã£o invÃ¡lida                                                              |
| `401`  | Unauthorized          | Chave de API invÃ¡lida                                                            |
| `403`  | Forbidden             | Bloqueio por IP/DomÃ­nio                                                          |
| `404`  | Not Found             | O recurso solicitado nÃ£o existe                                                  |
| `412`  | Precondition Failed   | Parâmetros vÃ¡lidos mas a requisiÃ§Ã£o falhou                                       |
| `422`  | Unprocessable Entity  | Parâmetros invÃ¡lidos                                                             |
| `429`  | Too Many Requests     | Quantidade de requisições realizadas pelo IP maior que o permitido pela Pagar.me |
| `500`  | Internal Server Error | Ocorreu um erro interno                                                          |

## PossÃ­veis erros

```json 404 - Not Found
{
    "message": "Customer not found."
}
```

> "Cliente nÃ£o encontrado": Ocorre quando nÃ£o identificamos o objeto `customer` ou `customer_id`
> na [requisiÃ§Ã£o de criaÃ§Ã£o do pedido](https://docs.pagar.me/reference/criar-pedido-2).

```json 422 - Unprocessable Entity
{
    "message": "The request is invalid.",
    "errors": {
        "order.customer.name": [
            "The name field is required."
        ]
    },
  ...
```

> "O campo nome Ã© obrigatÃ³rio": Ocorre quando nÃ£o identificamos o campo `name` dentro do objeto `customer`. Ã‰ necessÃ¡rio
> adicionar o nome do cliente aos dados informados na requisiÃ§Ã£o
> de [requisiÃ§Ã£o de criaÃ§Ã£o do pedido](https://docs.pagar.me/reference/criar-pedido-2).

```json 422 - Unprocessable Entity
{
    "message": "The request is invalid.",
    "errors": {
        "order.payments[0].credit_card.card": [
            "The number field is not a valid card number"
        ]
    },
  ...
```

> "O campo do nÃºmero nÃ£o Ã© um nÃºmero de cartÃ£o vÃ¡lido": Ocorre quando o campo `number` dentro do objeto `card` nÃ£o Ã© um
> nÃºmero de cartÃ£o vÃ¡lido. Ã‰ necessÃ¡rio revisar o nÃºmero do cartÃ£o informado
> na [requisiÃ§Ã£o de criaÃ§Ã£o do pedido](https://docs.pagar.me/reference/criar-pedido-2).

```json 422 - Unprocessable Entity
{
    "message": "The request is invalid.",
    "errors": {
        "card.number": [
            "The field number must be a string with a minimum length of 13 and a maximum length of 19."
        ]
    },
  ...
```

> "O nÃºmero do campo deve ser uma `string` com comprimento mÃ­nimo de 13 e mÃ¡ximo de 19": Ocorre quando o campo `number`
> tem a quantidade de caracteres incorreta. Ã‰ necessÃ¡rio revisar o nÃºmero do cartÃ£o informado
> na [requisiÃ§Ã£o de criaÃ§Ã£o do cartÃ£o](https://docs.pagar.me/reference/criar-cart%C3%A3o).

```json 422 - Unprocessable Entity
{
    "message": "The request is invalid.",
    "errors": {
        "order.items": [
            "The items field is required"
        ]
    },
  ...
```

> "O campo itens Ã© obrigatÃ³rio": Ocorre quando nÃ£o encontramos o objeto `items` na requisiÃ§Ã£o. Para realizar
> a [criaÃ§Ã£o de um pedido](https://docs.pagar.me/reference/criar-pedido-2), Ã© obrigatÃ³rio informar os itens.

## PossÃ­veis erros - IntegraÃ§Ã£o PSP

```json 422 - Unprocessable Entity
...               
"gateway_response": {
    "code": "412",
    "errors": [
        {
            "message": "At least one customer phone is required."
        }
    ]
},
  ...
```

> "Ã‰ necessÃ¡rio pelo menos um telefone do cliente": O erro ocorre quando nÃ£o encontramos o objeto `phones` dentro do
> objeto `customer`. Para clientes *Pagar.me PSP* Ã© obrigatÃ³rio enviar o telefone dentro junto aos dados do
> cliente. [Mais sobre o objeto phones.](https://docs.pagar.me/reference/telefones-1)

> ðŸ“˜ Dados obrigatÃ³rios PSP x Gateway
>
> A integraÃ§Ã£o PSP ou Gateway afeta os dados necessÃ¡rios para efetuar certas solicitações, como a criaÃ§Ã£o de um pedido.
>
> Portanto, leve em consideraÃ§Ã£o o seu modelo de negÃ³cios ao seguir as orientações da
> nossa [ReferÃªncia da API](https://docs.pagar.me/reference/introdu%C3%A7%C3%A3o-1) e consultar a assistÃªncia de nossas
> equipes de suporte.