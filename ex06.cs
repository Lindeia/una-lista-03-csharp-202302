internal class ex06
{
    private static void Main(string[] args)
    {
        int num1, num2, maior, menor, numAleatorio;

        Console.WriteLine("Digite o primeiro numero inteiro: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero inteiro: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        maior = Math.Max(num1, num2);
        menor = Math.Min(num1, num2);

        Random aleatorio = new Random();
        numAleatorio = aleatorio.Next(menor, maior + 1);

        Console.WriteLine("Número gerado aleatoriamente: " + numAleatorio);

        if (numAleatorio % 2 == 0)
        {
            Console.WriteLine("O número gerado é PAR!");
        } else
        {
            Console.WriteLine("O número gerado é ÍMPAR!");
        }

        Console.ReadLine();
    }
}