# Eventos de webhook

| Atributos                   | DescriÃ§Ã£o                                                                               |
|:----------------------------|:----------------------------------------------------------------------------------------|
| `customer.created`          | Ocorre sempre que um comprador Ã© criado.                                                |
| `customer.updated`          | Ocorre sempre que um comprador Ã© atualizado.                                            |
| `card.created`              | Ocorre sempre que um cartÃ£o Ã© criado.                                                   |
| `card.updated`              | Ocorre sempre que um cartÃ£o Ã© atualizado.                                               |
| `card.deleted`              | Ocorre sempre que um cartÃ£o Ã© excluÃ­do.                                                 |
| `address.created`           | Ocorre sempre que um endereÃ§o Ã© criado.                                                 |
| `address.updated`           | Ocorre sempre que um endereÃ§o Ã© atualizado.                                             |
| `address.deleted`           | Ocorre sempre que um endereÃ§o Ã© excluÃ­do.                                               |
| `card.expired`              | Ocorre sempre que um cartÃ£o expira a data de validade.                                  |
| `plan.created`              | Ocorre sempre que um plano Ã© criado.                                                    |
| `plan.updated`              | Ocorre sempre que um plano Ã© atualizado.                                                |
| `plan.deleted`              | Ocorre sempre que um plano Ã© excluÃ­do.                                                  |
| `plan_item.created`         | Ocorre sempre que um item de plano Ã© criado.                                            |
| `plan_item.updated`         | Ocorre sempre que um item de plano Ã© atualizado.                                        |
| `plan_item.deleted`         | Ocorre sempre que um item de plano Ã© excluÃ­do.                                          |
| `subscription.created`      | Ocorre sempre que uma assinatura Ã© criada.                                              |
| `subscription.canceled`     | Ocorre sempre que a assinatura Ã© cancelada.                                             |
| `subscription_item.created` | Ocorre sempre que um item de assinatura Ã© criado.                                       |
| `subscription_item.updated` | Ocorre sempre que um item de assinatura Ã© atualizado.                                   |
| `subscription_item.deleted` | Ocorre sempre que um item de assinatura Ã© excluÃ­do.                                     |
| `discount.created`          | Ocorre sempre que um desconto Ã© criado.                                                 |
| `discount.deleted`          | Ocorre sempre que um desconto Ã© excluÃ­do.                                               |
| `increment.created`         | Ocorre sempre que um incremento Ã© criado.                                               |
| `increment.deleted`         | Ocorre sempre que um incremento Ã© excluÃ­do.                                             |
| `order.paid`                | Ocorre sempre que um pedido Ã© pago.                                                     |
| `order.payment_failed`      | Ocorre sempre que o pagamento de um pedido falha.                                       |
| `order.created`             | Ocorre sempre que um pedido Ã© criado.                                                   |
| `order.canceled`            | Ocorre sempre que um pedido Ã© cancelado.                                                |
| `order_item.created`        | Ocorre sempre que um item do pedido Ã© criado .                                          |
| `order_item.updated`        | Ocorre sempre que um item do pedido Ã© atualizado.                                       |
| `order_item.deleted`        | Ocorre sempre que um item do pedido Ã© excluÃ­do.                                         |
| `order.closed`              | Ocorre sempre que um pedido Ã© fechado.                                                  |
| `order.updated`             | Ocorre sempre que um pedido Ã© atualizado.                                               |
| `invoice.created`           | Ocorre sempre que uma fatura Ã© criada.                                                  |
| `invoice.updated`           | Ocorre sempre que uma fatura Ã© atualizada.                                              |
| `invoice.paid`              | Ocorre sempre que uma fatura Ã© paga.                                                    |
| `invoice.payment_failed`    | Ocorre sempre que o pagamento de uma fatura falha.                                      |
| `invoice.canceled`          | Ocorre sempre que uma fatura Ã© cancelada                                                |
| `charge.created`            | Ocorre sempre que uma cobranÃ§a Ã© criada.                                                |
| `charge.updated`            | Ocorre sempre que uma cobranÃ§a Ã© atualizado.                                            |
| `charge.paid`               | Ocorre sempre que uma cobranÃ§a Ã© paga.                                                  |
| `charge.payment_failed`     | Ocorre sempre que o pagamento de uma cobranÃ§a falha.                                    |
| `charge.refunded`           | Ocorre sempre que uma cobranÃ§a Ã© estornada.                                             |
| `charge.pending`            | Ocorre sempre que uma cobranÃ§a Ã© pendente.                                              |
| `charge.processing`         | Ocorre sempre que uma cobranÃ§a ainda estÃ¡ sendo processada.                             |
| `charge.underpaid`          | Ocorre sempre que uma cobranÃ§a foi paga a menos.                                        |
| `charge.overpaid`           | Ocorre sempre que uma cobranÃ§a foi paga a mais.                                         |
| `charge.partial_canceled`   | Ocorre sempre que uma cobranÃ§a foi parcialmente cancelada.                              |
| `charge.chargedback`        | Ocorre sempre que uma cobranÃ§a sofre chargeback.                                        |
| `usage.created`             | Ocorre sempre que o uso de um item no perÃ­odo Ã© criado.                                 |
| `usage.deleted`             | Ocorre sempre que o uso de um item no perÃ­odo Ã© excluÃ­do.                               |
| `recipient.created`         | Ocorre sempre que um recebedor Ã© criado.                                                |
| `recipient.deleted`         | Ocorre sempre que um recebedor Ã© excluÃ­do.                                              |
| `recipient.updated`         | Ocorre sempre que um recebedor Ã© atualizado.                                            |
| `bank_account.created`      | Ocorre sempre que uma conta bancÃ¡ria Ã© criada.                                          |
| `bank_account.updated`      | Ocorre sempre que uma conta bancÃ¡ria Ã© atualizada.                                      |
| `bank_account.deleted`      | Ocorre sempre que uma conta bancÃ¡ria Ã© excluÃ­do.                                        |
| `checkout.created`          | Ocorre quando um checkout Ã© criado.                                                     |
| `checkout.canceled`         | Ocorre quando um checkout Ã© cancelado.                                                  |
| `checkout.closed`           | Ocorre quando um checkout Ã© fechado.                                                    |
| `charge.antifraud_approved` | Ocorre quando um pedido no antifraude Ã© aprovado.                                       |
| `charge.antifraud_reproved` | Ocorre quando um pedido no antifraude Ã© reprovado.                                      |
| `charge.antifraud_manual`   | Ocorre quando um pedido no antifraude Ã© marcado para anÃ¡lise manual.                    |
| `charge.antifraud_pending`  | Ocorre quando um pedido estÃ¡ pendente de envio para a anÃ¡lise do serviÃ§o de antifraude. |