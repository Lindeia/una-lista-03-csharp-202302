using System;
//1. Escreva um algoritmo que leia 3 números a partir do teclado. O algoritmo deve apresentar:
//a. O maior número.
//b. O menor número.
//c. A média aritmética dos três números.
					
public class Program
{
	public static void Main()
	{
		double num1, num2, resultado;
		Console.WriteLine("Digite um número:  "); 
		num1 = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Digite outro número:  "); 
		num2 = double.Parse(Console.ReadLine());
		
		if (num1 > num2)
		{	
			Console.WriteLine("O maior numero digitado é: " + num1);
		}
		else
		{
			Console.WriteLine("O menor número digitado é: " + num2);
		}
		resultado = (num1 + num2) / 2;
		
		Console.WriteLine("A média aritmética entre os numeros digitados é: " + resultado);
		Console.ReadLine();

	}
}