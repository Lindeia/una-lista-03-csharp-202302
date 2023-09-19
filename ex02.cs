//Escreva o algoritmo de uma máquina de venda automática de salgadinhos, doces,
//sucos e refrigerantes. O algoritmo deve calcular o menor número de notas que deve ser dado de troco para um pagamento efetuado.
//O algoritmo deve ler o valor da compra e o valor pago.
//Se o valor pago for menor que o valor da compra, a máquina deve apresentar uma mensagem, informando que a quantia paga é insuficiente para realizar a compra.
//A máquina aceita apenas notas de R$ 50,00, R$ 20,00, R$ 10,00, R$ 5,00, R$ 2,00 e R$ 1,00.
//Exemplo:
//Valor pago: R$ 100,00
//Valor da compra: R$ 23,00
//Troco: R$ 77,00
//Notas de R$ 50,00: 1
//Notas de R$ 20,00: 1
//Notas de R$ 10,00: 0
//Notas de R$ 5,00: 1
//Notas de R$ 2,00: 1
//Notas de R$ 1,00: 0
internal class ex02
{
    private static void Main(string[] args)
    {
        double valorCompra, valorPago;

        Console.WriteLine("Informe o valor da compra: ");
        valorCompra = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor pago: ");
        valorPago = Convert.ToDouble(Console.ReadLine());

        while (valorPago < valorCompra)
        {
            Console.WriteLine("O VALOR PAGO É MENOR QUE O VALOR DA COMPRA!! \n\n Selecione a opção abaixo: \n 1- Alterar valor pago \n 2- Alterar valor da compra");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Informe o valor pago: ");
                    valorPago = Convert.ToDouble(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Informe o valor da compra: ");
                    valorCompra = Convert.ToDouble(Console.ReadLine());
                    break;
                default:
                    break;
            }

            while (opcao != 1 && opcao != 2)
            {
                Console.WriteLine("OPÇÃO INVÁLIDA!! \n\nSelecione uma opção abaixo: \n 1- Alterar valor pago \n 2- Alterar valor da compra");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe o valor pago: ");
                        valorPago = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Informe o valor da compra: ");
                        valorCompra = Convert.ToDouble(Console.ReadLine());
                        break;
                    default:
                        break;
                }
            }
        }

        double troco = valorPago - valorCompra;

        Console.WriteLine("\nValor da compra: " + valorCompra);
        Console.WriteLine("Valor pago: " + valorPago);
        Console.WriteLine("O troco é de R$ " + troco.ToString("F"));

        int n50, n20, n10, n5, n2, n1;

        n50 = Convert.ToInt32(troco) / 50;
        troco %= 50;
        n20 = Convert.ToInt32(troco) / 20;
        troco %= 20;
        n10 = Convert.ToInt32(troco) / 10;
        troco %= 10;
        n5 = Convert.ToInt32(troco) / 5;
        troco %= 5;
        n2 = Convert.ToInt32(troco) / 2;
        troco %= 2;
        n1 = Convert.ToInt32(troco);


        Console.WriteLine("\nNotas de R$ 50,00: " + n50);
        Console.WriteLine("Notas de R$ 20,00: " + n20);
        Console.WriteLine("Notas de R$ 10,00: " + n10);
        Console.WriteLine("Notas de R$ 5,00: " + n5);
        Console.WriteLine("Notas de R$ 2,00: " + n2);
        Console.WriteLine("Notas de R$ 1,00: " + n1);

        Console.ReadLine();
    }
}