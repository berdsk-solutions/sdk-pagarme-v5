# Pacote

No `scheme_type` : `package`, o preÃ§o final Ã© baseado no consumo direto de um **bloco** de unidades.

```json JSON
{
    "scheme_type": "package",
    "price_brackets": [
        {
            "start_quantity": 0,
            "end_quantity": 10,
            "price": 5000
        },
        {
            "start_quantity": 11,
            "end_quantity": 50,
            "price": 7000
        },
        {
            "start_quantity": 51,
            "end_quantity": 100,
            "price": 10000,
            "overage_price": 90
        }
    ]
}
```

No exemplo acima temos a seguinte precificaÃ§Ã£o:

De 0 a 10 minutos = R$ 50,00.\
De 11 a 50 minutos = R$ 70,00.\
De 51 a 100 minutos = R$ 100,00.\
Cada minuto acima da Ãºltima faixa = R$0,90.

Se um cliente utilizar 25 minutos o valor serÃ¡ R$ 70,00.\
Se um cliente utilizar 110 minutos o valor serÃ¡ R$ 109,00 (R$ 100,00 + (10 x R$ 0,90)).