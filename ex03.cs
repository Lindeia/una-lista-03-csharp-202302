internal class ex03
{
    private static void Main(string[] args)
    {
        double a, b, c, delta;

        Console.WriteLine("Digite o valor de (a): ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de (b): ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de (c): ");
        c = Convert.ToDouble(Console.ReadLine());

        if (a == 0 && b == 0 && c != 0)
        {
            Console.WriteLine("Coeficientes informados incorretamente.");
        }
        else if (a == 0 && b != 0)
        {
            Console.WriteLine("Essa é uma equação de primeiro grau.");
            double raiz = -c / b;
            Console.WriteLine("Valor da raiz real da equação: " + raiz);
        }
        else
        {
            delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                Console.WriteLine("Esta equação não possui raízes reais.");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Esta equação possui duas raízes reais iguais.");
                double raiz = -b / (2 * a);
                Console.WriteLine("Valor das raízes da equação: " + raiz);
            }
            else
            {
                Console.WriteLine("Esta equação possui duas raízes reais diferentes.");
                double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Valor da primeira raiz: " + raiz1);
                Console.WriteLine("Valor da segunda raiz: " + raiz2);
            }
        }
        Console.ReadLine();
    }
}