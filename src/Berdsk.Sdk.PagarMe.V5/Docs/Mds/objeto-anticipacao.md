# Objeto antecipaÃ§Ã£o

Ao criar ou atualizar uma antecipaÃ§Ã£o, este serÃ¡ o objeto que vocÃª irÃ¡ receber como resposta em cada etapa do processo de efetivaÃ§Ã£o da antecipaÃ§Ã£o.

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
        `id`
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Identificador da antecipaÃ§Ã£o
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `amount`
      </td>

      <td style={{ textAlign: "left" }}>
        integer
      </td>

      <td style={{ textAlign: "left" }}>
        Valor bruto, em centavos, da antecipaÃ§Ã£o criada.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `anticipation_fee`
      </td>

      <td style={{ textAlign: "left" }}>
        integer
      </td>

      <td style={{ textAlign: "left" }}>
        Taxa de antecipaÃ§Ã£o relacionada aos recebÃ­veis antecipados.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `fee`
      </td>

      <td style={{ textAlign: "left" }}>
        integer
      </td>

      <td style={{ textAlign: "left" }}>
        Taxa de adquirÃªncia relacionada aos recebÃ­veis antecipados.
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `automatic_transfer`
      </td>

      <td style={{ textAlign: "left" }}>
        boolean
      </td>

      <td style={{ textAlign: "left" }}>
        Define se o valor da antecipaÃ§Ã£o serÃ¡ transferido automaticamente para a conta bancÃ¡ria do recebedor
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `payment_date`
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Data de pagamento da antecipaÃ§Ã£o (data no formato ISO 8601)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `status`
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Status da antecipaÃ§Ã£o. Valores possÃ­veis:`pending`, `pre_approved`, `approved`, `refused`, `canceled`
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `timeframe`
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        PerÃ­odo do qual os recebÃ­veis irÃ£o vir, do Ã­nicio ou do fim de sua agenda de recebÃ­veis. Ex: Caso vocÃª escolha do comeÃ§o (start), seu custo serÃ¡ menor mas hÃ¡ maior impacto no seu fluxo de caixa.\
        Valores possÃ­veis: `start`, `end`
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `type`
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Indica o tipo da antecipaÃ§Ã£o, automÃ¡tica ou manual â€œspotâ€. Valores possÃ­veis: `automatic` ou `spot`
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `created_at`
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Data de criaÃ§Ã£o de antecipaÃ§Ã£o (data no formato ISO 8601)
      </td>
    </tr>

    <tr>
      <td style={{ textAlign: "left" }}>
        `updated_at`
      </td>

      <td style={{ textAlign: "left" }}>
        String
      </td>

      <td style={{ textAlign: "left" }}>
        Data da Ãºltima atualizaÃ§Ã£o de antecipaÃ§Ã£o (data no formato ISO 8601)
      </td>
    </tr>
  </tbody>
</Table>

> ðŸ“˜ Status
>
> **pending** â†’ antecipaÃ§Ã£o criada mas pendente de processamento
>
> **approved/pre\_approved** â†’ antecipaÃ§Ã£o aprovada, serÃ¡ processada na prÃ³xima leva
>
> **refused** â†’ antecipaÃ§Ã£o recusada
>
> **canceled** â†’ antecipaÃ§Ã£o cancelada