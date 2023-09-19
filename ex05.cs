internal class ex05
{
    private static void Main(string[] args)
    {
        double num1, num2, resultado = 0;
        string operacao;

        Console.WriteLine("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        
        while (resultado == 0)
        {
            Console.WriteLine("Digite o simbolo da operação: ");
            operacao = Console.ReadLine();


            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine("O valor da SOMA do número " + num1 + " e o número " + num2 + " é: " + resultado.ToString("F"));

                    break;

                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine("O valor da SUBTRAÇÃO do número " + num1 + " e o número " + num2 + " é: " + resultado.ToString("F"));
                    break;

                case "*":
                    resultado = num1 * num2;
                    Console.WriteLine("O valor da MULTIPLICAÇÃO do número " + num1 + " com o número " + num2 + " é: " + resultado.ToString("F"));
                    break;

                case "/":
                    resultado = num1 / num2;
                    Console.WriteLine("O valor da DIVISÃO do número " + num1 + " pelo número " + num2 + " é: " + resultado.ToString("F"));
                    break;

                case "^":
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine("O valor da POTÊNCIA do número " + num1 + " elevado ao número " + num2 + " é: " + resultado.ToString("F"));
                    break;

                default:
                    Console.WriteLine("O SIMBOLO DA OPERAÇÃO É INVÁLIDO!!");
                    break;
            }
        }
        Console.ReadLine();
    }
}