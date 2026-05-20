# Faixa

No `scheme_type` : `tier`, o preÃ§o final Ã© baseado nas faixa de consumo de unidades, **de forma cumulativa**.

```json JSON
{
    "scheme_type": "tier",
    "price_brackets": [
        {
            "start_quantity": 0,
            "end_quantity": 10,
            "price": 100
        },
        {
            "start_quantity": 11,
            "end_quantity": 20,
            "price": 90
        },
        {
            "start_quantity": 21,
            "end_quantity": 50,
            "price": 80,
            "overage_price": 70
        }
    ]
}
```

No exemplo acima temos a seguinte precificaÃ§Ã£o:

Do 1Â° ao 10Â° minuto - Cada minuto custa R$ 1,00.\
Do 11Â° ao 20Â° minuto - Cada minuto custa R$ 0,90.\
Do 21Â° ao 50Â° minuto - Cada minuto custa R$ 0,80.\
Cada minuto acima da Ãºltima faixa custa R$ 0,70.

Se um cliente utilizar 25 minutos o valor total serÃ¡ R$23,00 ((10 x R$ 1,00) + (10 x R$ 0,90) + (5 x R$0,80)).