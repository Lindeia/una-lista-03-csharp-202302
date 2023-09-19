//Escreva um algoritmo que leia dois valores: o primeiro servindo de indicador de
// operação e o segundo correspondendo ao raio de um círculo ou esfera. Caso oprimeiro valor lido seja:
//a. 1: calcular e imprimir o perímetro do círculo.
//b. 2: calcular e imprimir a área do círculo.
//c. 3: calcular e imprimir o volume da esfera.
//Se o primeiro valor lido for diferente desses três valores possíveis, imprimir uma mensagem de erro, informando que o código da operação é inválido.

using System;
					
public class Program
{
	public static void Main()
	{
		double raio, numero;
		Console.WriteLine("Digite um número a ser cálculado: ");
		numero = double.Parse(Console.ReadLine());
		Console.WriteLine("Informe o raio ser cálculado: ");
		raio = double.Parse(Console.ReadLine());
		if(raio != numero)
		{
		Console.WriteLine("Não foi possível calcular. Tente novamente!");
		}
		else
		{
		Console.WriteLine($"O perímetro do círculo é de: {numero * 3.14 * raio}" );
		Console.WriteLine($"A área do círculo é de: {3.14 * (raio * raio)}" );
		Console.WriteLine($"O volume da esfera é de: {4/3 * 3.14 *(raio * raio * raio)}" );
		}
		Console.ReadLine();
	}
}