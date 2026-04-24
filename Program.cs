const double TaxaIOfMes = 0.0038;
const double TaxaIOfDia = 0.0000085;
decimal valorTotalFatura;
double percetualPagamentoMinimo, taxaJurosMensais;
decimal valorPagamentoMinimo, valorNaopago, valorDojuros, valorIOFMes, valorIOFDiario,
        valorProximaFatura, custoCreditoRotativo;


Console.WriteLine("--- Crédito Rotativo de Cartão de Crédito ---\n");
Console.Write("Valor total da fatura (R$)...: ");


Console.WriteLine("Valor total da fatura (R$)...: \n");
valorTotalFatura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Pagamento mínimo (%).........: \n");
percetualPagamentoMinimo = Convert.ToDouble(Console.ReadLine()) / 100;

Console.WriteLine("Taxa de juros mensais (%)....: \n");
taxaJurosMensais = Convert.ToDouble(Console.ReadLine()) / 100;

valorPagamentoMinimo = valorTotalFatura * Convert.ToDecimal(percetualPagamentoMinimo);
valorNaopago = valorTotalFatura - valorPagamentoMinimo;
valorDojuros = valorNaopago * Convert.ToDecimal(taxaJurosMensais);
valorIOFMes = valorNaopago * Convert.ToDecimal(TaxaIOfMes);
valorIOFDiario = valorNaopago * Convert.ToDecimal(TaxaIOfDia);

valorProximaFatura = valorNaopago + valorDojuros + valorIOFMes + valorIOFDiario;
custoCreditoRotativo = valorProximaFatura - valorNaopago;


Console.WriteLine($"\n Pagamento mínimo..................: {valorPagamentoMinimo:C2}");

Console.WriteLine("\nCaso seja pago o valor mínimo:");

Console.WriteLine("Valor não pago....................: R$850,00");
Console.WriteLine("Juros.............................: R$76,50");
Console.WriteLine("IOF mensal........................: R$3,23");
Console.WriteLine("IOF diário........................: R$2,09");
Console.WriteLine("Valor a pagar na próxima fatura...: R$931,82");
Console.WriteLine("Custo do crédito rotativo.........: R$81,82");




