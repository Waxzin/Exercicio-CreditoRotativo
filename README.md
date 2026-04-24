## Exercício `CreditoRotativo`

Em uma fatura de cartão de crédito a operadora oferta um crédito rotativo, permitindo que o cliente efetue um pagamento inferior ao valor total, mas cobrando o restante na próxima fatura com juros.

Faça um programa que receba o valor total da fatura, o percentual para o pagamento mínimo e a taxa de juros mensais. Exiba o valor do pagamento mínimo, o valor não pago, os juros sobre o rotativo, o valor a ser pago na próxima fatura e o custo do crédito rotativo (valor excedente em relação ao pagamento na fatura corrente). Considere os custos de IOF (Imposto sobre Operações Financeiras) de 0,38% ao mês e 0,0082% ao dia (use 30 dias).

Exemplo:

```
--- Crédito Rotativo de Cartão de Crédito ---

Valor total da fatura (R$)...: 1000
Pagamento mínimo (%).........: 15
Taxa de juros mensais (%)....: 9

Pagamento mínimo..................: R$150,00

Caso seja pago o valor mínimo:

Valor não pago....................: R$850,00
Juros.............................: R$76,50
IOF mensal........................: R$3,23
IOF diário........................: R$2,09

Valor a pagar na próxima fatura...: R$931,82
Custo do crédito rotativo.........: R$81,82
```
