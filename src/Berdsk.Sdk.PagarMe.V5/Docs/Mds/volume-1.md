# Volume

No `scheme_type` : `volume`, o preÃ§o final Ã© baseado na **faixa de consumo final** de unidades.

```json JSON
{
    "scheme_type": "volume",
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

Se utilizar entre 1 \~ 10 minutos - Cada minuto custa R$ 1,00.\
Se utilizar entre 11 \~ 20 minutos - Cada minuto custa R$ 0,90.\
Se utilizar entre 21 \~ 50 minutos - Cada minuto custa R$ 0,80.\
Cada minuto acima da Ãºltima faixa custa R$ 0,70.

Se um cliente utilizar 25 minutos o valor total serÃ¡ R$ 20,00 (25 x R$ 0,80).\
Se um cliente utilizar 52 minutos o valor total serÃ¡ R$ 41,40 ((50 x R$ 0,80) + (2 x R$ 0,70)).