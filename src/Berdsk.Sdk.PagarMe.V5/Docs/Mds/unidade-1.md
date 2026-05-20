# Unidade

No `scheme_type` : `unit`, preÃ§o final Ã© baseado no consumo **direto** de unidades.

```json JSON
{
  "scheme_type": "unit",
  "price": 500,
  "minimum_price": 100,
}
```

No exemplo acima temos a seguinte precificaÃ§Ã£o:

1 minuto = R$ 5,00.

Assim, se um cliente utilizar 100 minutos o valor total serÃ¡ R$ 500,00 (100 x R$ 5,00).\
Caso o consumo seja menor que 1 minuto, serÃ¡ cobrado o valor mÃ­nimo R$ 1,00.