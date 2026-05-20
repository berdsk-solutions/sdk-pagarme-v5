# Objeto TransferÃªncia

Objeto retornado ao se criar uma transferÃªncia bancÃ¡ria.

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
        Id
      </td>

      <td style={{ textAlign: "left" }}>
        Int
      </td>

      <td style={{ textAlign: "left" }}>
        NÃºmero identificador da transaÃ§Ã£o
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        Amount
      </td>

      <td style={{ textAlign: "left" }}>
        Int
      </td>

      <td style={{ textAlign: "left" }}>
        Valor, em centavos, do valor transferido
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        Type
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Tipo da transaÃ§Ã£o.\
        Valores possÃ­veis: `ted`, `doc` ou `credito_em_conta`
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        Status
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Estado no qual a transaÃ§Ã£o se encontra.\
        Valores possÃ­veis: `pending_transfer`, `transferred`, `failed`, `processing` ou `canceled`
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        Fee
      </td>

      <td style={{ textAlign: "left" }}>
        Int
      </td>

      <td style={{ textAlign: "left" }}>
        Taxa cobrada pela transferÃªncia, em centavos.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        Funding\_date
      </td>

      <td style={{ textAlign: "left" }}>
        Int
      </td>

      <td style={{ textAlign: "left" }}>
        Data da ocorrÃªncia da transferÃªncia
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        Funding\_estimated\_date
      </td>

      <td style={{ textAlign: "left" }}>
        Int
      </td>

      <td style={{ textAlign: "left" }}>
        Data estimada para efetivaÃ§Ã£o da transferÃªncia (ISODate)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        transaction\_id
      </td>

      <td style={{ textAlign: "left" }}>
        Numeric
      </td>

      <td style={{ textAlign: "left" }}>
        Campo Legado. Identificador da transaÃ§Ã£o estornada
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        Bank\_account
      </td>

      <td style={{ textAlign: "left" }}>
        Object
      </td>

      <td style={{ textAlign: "left" }}>
        Objeto contendo os dados da conta bancÃ¡ria que irÃ¡ receber a transferÃªncia. [Saiba mais sobre Conta BancÃ¡ria](https://docs.pagar.me/reference/conta-banc%C3%A1ria-1)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        Date\_created
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Data da criaÃ§Ã£o da transferÃªncia (ISODate)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        metadata
      </td>

      <td style={{ textAlign: "left" }}>
        JSON
      </td>

      <td style={{ textAlign: "left" }}>
        Objeto com dados adicionais informados na criaÃ§Ã£o da transferÃªncia.  [Saiba mais sobre metadata](https://docs.pagar.me/reference/metadata-1) .
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        bank\_response
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Em caso de falha na transferÃªncia, retorna motivo da falha informado pelo Banco.
      </td>
    </tr>
  </tbody>
</Table>