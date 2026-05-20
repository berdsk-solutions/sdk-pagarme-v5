# TokenizaÃ§Ã£o

<br />Caso nÃ£o seja possÃ­vel embarcar nosso script **tokenizecard.js** em sua pÃ¡gina, vocÃª pode **chamar diretamente a
API de criaÃ§Ã£o de tokens de cartÃ£o**. Os dados de cartÃ£o deverÃ£o ser enviados para a API da Pagar.me antes de submeter o
formulÃ¡rio para o seu servidor. NÃ³s retornaremos um objeto `token`, que deverÃ¡ ser utilizado em sua requisiÃ§Ã£o, no lugar
dos dados de cartÃ£o.

> â—ï¸ NÃƒO TRAFEGUE DADOS DE CARTÃƒO EM SEU SERVIDOR
>
> Ã‰ importante que vocÃª garanta que os dados abertos de cartÃ£o (nÃºmero, cvv, vencimento e nome do titular) **nÃ£o serÃ£o
enviados para seu servidor**.

> ðŸš§ O Token do cartÃ£o Ã© temporÃ¡rio
>
> Os tokens de cartÃ£o tem tempo de expiraÃ§Ã£o de 60 segundos, e sÃ³ poderÃ£o ser usados uma Ãºnica vez. Se quiser armazenar
> de forma permanente o cartÃ£o em nosso sistema, [leia mais sobre cartÃµes](https://docs.pagar.me/v5/reference#cartÃµes-1).

O objeto `token` possui os seguinte atributos:

<Table align={["left","left","left"]}>
  <thead>
    <tr>
      <th>
        Atributos
      </th>

      <th>
        Tipo
      </th>

      <th>
        DescriÃ§Ã£o
      </th>
    </tr>

  </thead>

  <tbody>
    <tr>
      <td>
        `id`
      </td>

      <td>
        **string**
      </td>

      <td>
        * Token do cartÃ£o\_. Formato: `token_XXXXXXXXXXXXXXXX`
      </td>
    </tr>

    <tr>
      <td>
        `type`
      </td>

      <td>
        **string**
      </td>

      <td>
        * Tipo do token\_. Valor padrÃ£o: `card`.
      </td>
    </tr>

    <tr>
      <td>
        `created_at`
      </td>

      <td>
        **datetime**
      </td>

      <td>
        * Data de criaÃ§Ã£o do token\_.
      </td>
    </tr>

    <tr>
      <td>
        `expires_at`
      </td>

      <td>
        **datetime**
      </td>

      <td>
        * Data de expiraÃ§Ã£o do token\_.
      </td>
    </tr>

    <tr>
      <td>
        `card`
      </td>

      <td>
        **objeto**
      </td>

      <td>
        * Dados do cartÃ£o\_.
      </td>
    </tr>

  </tbody>
</Table>