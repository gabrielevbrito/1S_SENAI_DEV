using System;

namespace SomaDoisValores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            Console.WriteLine("Faça a soma de dois valores!");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite o primeiro valor: ");
            int valorUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int valorDois = int.Parse(Console.ReadLine());

            //Processamento
            int soma = valorUm + valorDois;

            //Exibir
            Console.WriteLine("A soma dos valores é: "+soma);






        }
    }
}
