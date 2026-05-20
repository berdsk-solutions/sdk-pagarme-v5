# Objeto Settlements

Ao buscar os objetos de pagamentos de cartÃ£o (settlements) de um recebedor, as seguintes informações compÃµem o objeto retornado:

<Table align={["left","left","left"]}>
  <thead>
    <tr>
      <th style={{ textAlign: "left" }}>
        Atributo
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
        id
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Identificador da Settlement
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        amount
      </td>

      <td style={{ textAlign: "left" }}>
        Int
      </td>

      <td style={{ textAlign: "left" }}>
        Valor da Settlement
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        product
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Produto referente Ã  liquidaÃ§Ã£o. PossÃ­veis valores: credit, debit ou anticipation
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        card\_brand
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Bandeira do cartÃ£o
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        payment\_date
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Data de pagamento da Settlement (Data no padrÃ£o ISO 8601)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        recipient\_id
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        ID do Recebedor
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        document\_type
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Tipo de documento. PossÃ­veis valores: individual(CPF) ou company(CNPJ)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        contract\_obligation\_id
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        ID da obrigaÃ§Ã£o de contrato da registradora (campo legado. valor default null)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        liquidation\_arrangement\_id
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        ID da LiquidationArrangement
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        liquidation\_type
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Tipo da liquidaÃ§Ã£o, interna ou externa
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        contract\_key
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Chave do contrato na registradora

        Caso nÃ£o seja nulo, a Settlement teve seu valor liquidado em um efeito de contrato da registradora
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        liquidation\_engine
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Motor de liquidaÃ§Ã£o interno
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        external\_engine\_payment\_id
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Representa o ID do motor de liquidaÃ§Ã£o utilizado internamente.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        funding\_account\_id
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Identificador da conta fonte pagadora
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        status
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Status da Settlement. PossÃ­veis valores: failed, success, pending
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        ispb
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        ISPB da conta destino da Settlement. Para ISPBs mais populares Ã© retornado o nome da instituiÃ§Ã£o bancÃ¡ria, para os menos utilizados Ã© retornado o cÃ³digo

        Este campo sÃ³ Ã© retornado caso get\_ispb seja passado na QueryString da request
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        target\_account.ispb
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        CÃ³digo ISPB da conta destino da Settlement

        Este campo sÃ³ Ã© retornado caso get\_ispb seja passado na QueryString da request
      </td>
    </tr>
  </tbody>
</Table>