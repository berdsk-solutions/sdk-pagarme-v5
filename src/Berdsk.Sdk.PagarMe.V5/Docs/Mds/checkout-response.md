# Checkout Pagar.me

Com o **Link de pagamento Pagar.me**, oferecemos uma pÃ¡gina de Checkout desenvolvida por nÃ³s e hospedada em nossos
servidores. Desta forma, vocÃª nÃ£o precisa se preocupar em desenvolver essa interface.

## IntegraÃ§Ã£o com o Checkout

**Passo 1**:\
Envie uma requisiÃ§Ã£o de [criaÃ§Ã£o de um Link de pagamento](https://docs.pagar.me/reference/create-link) com as
informações da venda e configurações do
Checkout [Saiba mais sobre as configurações do Checkout](https://docs.pagar.me/reference/checkout-copy).

```json JSON (Request)
{
  "is_building": false,
  "payment_settings": {
    "credit_card_settings": {
      "installments_setup": {
        "interest_type": "simple"
      },
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
    },
    "accepted_payment_methods": [
      "credit_card"
    ]
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
```

**Passo 2**:\
A resposta da requisiÃ§Ã£o de criaÃ§Ã£o de um checkout conterÃ¡ um campo `url`:

```json JSON (Response)
{
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
        ],
       "items_total_cost": 12000,
       "total_cost": 12000,
       "shipping_cost": 0,
       "shipping_total_cost": 0,
    },
    "name": "Banner N12345",
    "type": "order",
    "total_sessions": 0,
    "max_paid_sessions": 0,
    "total_paid_sessions": 0,
    "max_sessions": 0,
    "created_at": "2024-05-13T01:09:40.6331583Z",
    "url": "https://payment-link.pagar.me/pl_GNe8zkaO2MlBxxGcJcv0BALq9Pon514W",
    "updated_at": "2024-05-13T01:09:40.6331583Z",
    "id": "pl_GNe8zkaO2MlBxxGcJcv0BALq9Pon514W",
    "expires_in": 0,
    "status": "active"
}
```

Esta URL deverÃ¡ ser disponibilizada ao comprador por sua aplicaÃ§Ã£o. Ao acessar a URL o comprador serÃ¡ redirecionado para
o ambiente do Pagar.me para a realizaÃ§Ã£o do pagamento.

<Image alt="Se vocÃª nÃ£o estÃ¡ nessa versÃ£o do checkout, fique atento!  " align="center" src="https://files.readme.io/5aa79e4541f98378d5408d047964709b480e6ebcda803616a8cef234e6d2abbe-image.png" />

> ðŸš§ Se vocÃª nÃ£o estÃ¡ nessa versÃ£o do Checkout acima, fique atento!
>
> Para ter acesso a nova interface do Checkout e outras novidades, indicamos que realize a migraÃ§Ã£o da sua conta para a
> versÃ£o mais recente da nossa API - V5. No canto superior esquerdo da tela Ã© indicado qual versÃ£o da documentaÃ§Ã£o vocÃª
> estÃ¡ vendo. Clique na seta onde indica a versÃ£o e altere para a V5 para acessar a documentaÃ§Ã£o.
>
> Se vocÃª jÃ¡ Ã© cliente, precisa realizar obrigatoriamente a migraÃ§Ã£o para a versÃ£o V5.
>
> Em caso de dÃºvidas, basta entrar em contato com o nosso time de atendimento atravÃ©s do e-mail, enviando a sua dÃºvida
> para [relacionamento@pagar.me](mailto:relacionamento@pagar.me) e por telefone, ligando para 4004-1330. Se vocÃª jÃ¡ Ã©
> cliente pode tambÃ©m entrar em contato atravÃ©s do chat dentro da sua Dashboard.